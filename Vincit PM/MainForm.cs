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
        private IList<ReleaseLineItem> ReleaseLineItems = new List<ReleaseLineItem>();  

        private IList<RoutingOperation> RoutingOperations = new List<RoutingOperation>();
        private IList<RoutingHeader> RoutingHeaders = new List<RoutingHeader>();    
        private IList<BillOfMaterialComponent> BillOfMaterialComponents = new List<BillOfMaterialComponent>(); 
        private IList<GLAccount> GLAccounts = new List<GLAccount>();    



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

            string JobNumber = "I210341";

            Jobs = await jobscopeClient.GetJobs(JobNumber);
            //DGVJobs.DataSource = Jobs;


            Releases = await jobscopeClient.GetReleases(JobNumber);
            //DGVJobs.DataSource = Releases;

            string? ReleaseNumber = Releases[0].ReleaseNumber;
            ReleaseLineItems = await jobscopeClient.GetReleaseLineItems(ReleaseNumber);
            //ReleaseLineItems = await jobscopeClient.GetReleaseLineItems("I220113");
            //DGVJobs.DataSource = ReleaseLineItems;

            //RoutingOperations = await jobscopeClient.GetRoutingOperations();
            //DGVJobs.DataSource = RoutingOperations;

            //RoutingHeaders = await jobscopeClient.GetRoutingHeaders();
            //DGVJobs.DataSource = RoutingHeaders;

            //BillOfMaterialComponents = await jobscopeClient.GetBillOfMaterialComponents();
            //DGVJobs.DataSource = BillOfMaterialComponents;


            //Unathorized
            //GLAccounts = await jobscopeClient.GetGLAccounts();
            //DGVJobs.DataSource = GLAccounts;

            // var cquery = from j in Jobs
            //            join r in Releases
            //                on j.JobNumber equals r.JobNumber
            //            select new
            //            {
            //                j.JobNumber,
            //                r.ReleaseNumber,
            //                r.ReleaseId
            //            };


            //var linqquery = Jobs.Join(
            //                            Releases,
            //                            Releases => Releases.JobNumber,
            //                            Jobs => Jobs.JobNumber,
            //                            (j, r) => new
            //                            {
            //                                j.JobNumber,
            //                                r.ReleaseNumber,
            //                                r.ReleaseId
            //                            });


            //DGVJobs.DataSource = linqquery;

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