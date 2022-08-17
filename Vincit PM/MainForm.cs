namespace Vincit.PM
{
    public partial class MainForm : Form
    {
        public MainForm(IJobscopeClient jobscopeClient)
        {
            InitializeComponent();

            this.jobscopeClient = jobscopeClient;

            CheckTokenTimeOut.Interval = 1000;
            CheckTokenTimeOut.Tick += CheckTokenTimeOut_Tick;
        }

        #region Local Variables

        private readonly IJobscopeClient jobscopeClient;        

        static readonly System.Windows.Forms.Timer CheckTokenTimeOut = new();
        static readonly Stopwatch TokenLifeSpan = new();

        private IList<Job> Jobs = new List<Job>();

        #endregion        

        #region Event Handlers

        private async void MainForm_Load(object sender, EventArgs e)
        {
            await Populate();
        }

        private void CheckTokenTimeOut_Tick(object? sender, EventArgs e)
        {
            // TODO: This is one possible approach, but it may be better managed
            // by the JobscopeClient. It should almost definitely NOT be managed
            // in the individual Form scope. We can refactor this later

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

        #endregion

        #region Implementation

        private async Task Populate()
        {
            if (!await jobscopeClient.GetAccessToken())
            {
                throw new InvalidOperationException(message: "Unable to acquire Jobscope Token!");
            }

            TokenLifeSpan.Restart();

            Jobs = await jobscopeClient.GetJobs();

            DGVJobs.DataSource = Jobs;
        }

        #endregion

    }
}