namespace Vincit.PM
{
    public partial class MainForm : Form
    {
        public MainForm(IJobscopeClient jobscopeClient)
        {
            InitializeComponent();

            this.jobscopeClient = jobscopeClient;

        }

        #region Local Variables

        private readonly IJobscopeClient jobscopeClient;        

        private IList<Job> Jobs = new List<Job>();
        private IList<ReleaseTest> Releases = new List<ReleaseTest>();

        #endregion        

        #region Event Handlers

        private async void MainForm_Load(object sender, EventArgs e)
        {
            await Populate();
        }


        #endregion

        #region Implementation

        private async Task Populate()
        {
            if(!jobscopeClient.TokenValid)
            {
                if (!await jobscopeClient.GetAccessToken())
                {
                    throw new InvalidOperationException(message: "Unable to acquire Jobscope Token!");
                }
            }

            //Jobs = await jobscopeClient.GetJobs("220113");
            //DGVJobs.DataSource = Jobs;

            Releases = await jobscopeClient.GetReleases("220113");
            DGVJobs.DataSource = Releases;

        }

        #endregion

    }
}