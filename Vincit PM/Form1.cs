using System.Diagnostics;
using Vincit.Jobscope.Domain.Entities;


namespace Vincit_PM
{
    public partial class Form1 : Form
    {
        #region LOCAL VARIABLES
        const string JobscopeApiBaseAddress = "https://jobscope01/JeeApi/";
        static ServiceProvider? serviceProvider;
        static IJobscopeClient? jobscopeClient;
        static IList<Job>? Jobs;
        static System.Windows.Forms.Timer CheckTokenTimeOut = new System.Windows.Forms.Timer();
        static Stopwatch TokenLifeSpan = new Stopwatch();

        #endregion Local Variables END

        #region CONSTRUCT
        public Form1()
        {
            InitializeComponent();

            CheckTokenTimeOut.Interval = 1000;
            CheckTokenTimeOut.Tick += CheckTokenTimeOut_Tick;
            Populate();

            PopulateObjects();

        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void CheckTokenTimeOut_Tick(object? sender, EventArgs e)
        {
            //Need to get JobscopeClient Token timeout
            long JSTimeOut = 1500; //Assume a value
            //long JSTimeOut = 500; //Assume a value

            //How close to timeout?
            long TimeToTimeout = JSTimeOut - TokenLifeSpan.ElapsedMilliseconds;

            if(TimeToTimeout <= CheckTokenTimeOut.Interval)
            {
                //Within one interval
                //Get a new token now

            }
        }

        #endregion Construct END


        private static async void Populate()
        {
            //Assume I don't have a token
            bool GotToken = false;

            //Make sure I have a Token
            if(jobscopeClient == null)
            {
                Task<bool> GetTokenTask = GetToken();
                GotToken =  await GetTokenTask;
                //Got a new token
                TokenLifeSpan.Restart();

                //MessageBox.Show("GotToken = " + GotToken.ToString());
            }
            else
            {
                MessageBox.Show("Have Token");
                GotToken = true;
              
            }

            if(GotToken)
            {
                //Have a token
                //Now get Jobs
                Jobs = await GetJobs();
                //MessageBox.Show(Jobs.Count().ToString());
                //How do I DataSource into DGVJobs?
                //PopulateObjects();
            }
            else
            {
                //SHOULD NEVER GET HERE?
                //DON'T HAVE TOKEN
                //NOTIFY AND BAIL
            }



        }

        #region REFRESH FORM
        private void LocateObjects()
        {

        }
        public void PopulateObjects()
        {
            var source = new BindingSource();
            source.DataSource = Jobs;
            DGVJobs.DataSource = source;
            
        }


        #endregion Refresh Form END



        #region API INTERACTIONS
        static async Task<bool> GetToken()
        {
            var serviceCollection = new ServiceCollection();
            ConfigureServiceCollection(serviceCollection);
            serviceCollection.AddLogging();
            serviceProvider = serviceCollection.BuildServiceProvider();

            jobscopeClient = serviceProvider.GetService<IJobscopeClient>();
            
            if (jobscopeClient == null)
            {
                return false;
            }

            if (!await jobscopeClient.GetAccessToken())
            {
                //throw new Exception(message: "Unable to get Access Token from JobScope");
                return false;
            }
            
            return true;

        }

        public static async Task<IList<Job>?> GetJobs()
        {
            if (jobscopeClient == null) return null;

            IList<Job>? jobs = await jobscopeClient.GetJobs();
            if (jobs.Count == 0)
            {
                throw new Exception(message: "Unable to get 'Jobs' from JobScope");
            }
            else
            {
            }
                return jobs;    

        }

        private static void ConfigureServiceCollection(IServiceCollection services)
        {

            //// Create a IDictionary to get the environment variables
            //IDictionary data = Environment.GetEnvironmentVariables();

            //// Display the details with key and value
            //foreach (DictionaryEntry i in data)
            //{
            //    Console.WriteLine("{0}:{1}", i.Key, i.Value);
            //}



            services.AddSingleton(factory =>
            {
                var username = Environment.GetEnvironmentVariable(variable: "JOBSCOPEAPI_USERNAME");
                if (string.IsNullOrWhiteSpace(username))
                {
                    throw new ArgumentNullException(paramName: "username", message: "JOBSCOPEAPI_USERNAME value not found!");
                }

                var password = Environment.GetEnvironmentVariable(variable: "JOBSCOPEAPI_PASSWORD");
                if (string.IsNullOrWhiteSpace(password))
                {
                    throw new ArgumentNullException(paramName: "username", message: "JOBSCOPEAPI_PASSWORD value not found!");
                }

                return new Credentials
                {
                    Username = username,
                    Password = password
                };
            });

            services.AddSingleton<AppState>();

            services.AddTransient<AuthorizationHandler>();

            services
                .AddHttpClient("Vincit.Jobscope", client => client.BaseAddress = new Uri(uriString: JobscopeApiBaseAddress))
                .AddHttpMessageHandler<AuthorizationHandler>();

            services
                .AddScoped(sp => sp.GetRequiredService<IHttpClientFactory>().CreateClient("Vincit.Jobscope"));

            services.AddScoped<IJobscopeClient, JobscopeClient>();
        }
        #endregion api interaction END

 
    }
}