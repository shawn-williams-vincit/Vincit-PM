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
        private IList<Release> Releases = new List<Release>();

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

            Jobs = await jobscopeClient.GetJobs("220113");
            DGVJobs.DataSource = Jobs;

            //Releases = await jobscopeClient.GetReleases("220113");
            //DGVJobs.DataSource = Releases;

        }


        //var query = from order in workOrders
        //            join plan in plans
        //                 on order.WorkOrderNumber equals plan.WorkOrderNumber
        //            select new
        //            {
        //                order.WorkOrderNumber,
        //                order.Description,
        //                plan.ScheduledDate
        //            };
        #endregion

    }
}