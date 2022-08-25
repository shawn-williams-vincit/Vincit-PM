using System.Collections;

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

        private IList<Part> Parts = new List<Part>();

        private IList<Job> Jobs = new List<Job>();
        private IList<Release> Releases = new List<Release>();
        private IList<ReleaseLineItem> ReleaseLineItems = new List<ReleaseLineItem>();  

        private IList<RoutingOperation> RoutingOperations = new List<RoutingOperation>();
        private IList<RoutingHeader> RoutingHeaders = new List<RoutingHeader>();    
        private IList<BillOfMaterialComponent> BillOfMaterialComponents = new List<BillOfMaterialComponent>(); 

        private IList<GLAccount> GLAccounts = new List<GLAccount>();  
        private IList<APInvoice> APInvoices = new List<APInvoice>();
        private IList<ARInvoice> ARInvoices = new List<ARInvoice>();
        private IList<ARInvoiceLine> ARInvoiceLines = new List<ARInvoiceLine>();

        public IList<ComponentModel> ComponentModels = new List<ComponentModel>();

        public IList<Customer> Customers = new List<Customer>();
        public IList<CustomerInquiryMaster> CustomerInquiryMasters = new List<CustomerInquiryMaster>();
        public IList<CustomerInquiryLine> CustomerInquiryLines = new List<CustomerInquiryLine>();   

        public IList<CustomerActivity> CustomerActivitys = new List<CustomerActivity>();



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
            try
            {

                if(!jobscopeClient.TokenValid)
                {
                    if (!await jobscopeClient.GetAccessToken())
                    {
                        throw new InvalidOperationException(message: "Unable to acquire Jobscope Token!");
                    }
                }



                //DGVJobs.DataSource = await jobscopeClient.GetCustomerActivitys();

                //DGVJobs.DataSource = await jobscopeClient.GetCustomers();
                //DGVJobs.DataSource = await jobscopeClient.GetCustomerInquiryMasters();
                //DGVJobs.DataSource = await jobscopeClient.GetCustomerInquiryLines();

                //DGVJobs.DataSource = await jobscopeClient.GetComponentModels();


                //ARInvoiceLines = await jobscopeClient.GetARInvoiceLines();
                //DGVJobs.DataSource = ARInvoiceLines;

                //ARInvoices = await jobscopeClient.GetARInvoices();
                //DGVJobs.DataSource= ARInvoices;

                //APInvoices = await jobscopeClient.GetAPInvoices();
                //DGVJobs.DataSource = APInvoices;

                //Parts = await jobscopeClient.GetParts();
                //DGVJobs.DataSource = Parts;


                string JobNumber = "I210232";
                Jobs = await jobscopeClient.GetJobs(JobNumber);
                DGVJobs.DataSource = Jobs;

                JobBudget JB = new JobBudget(Jobs[0]);
                MessageBox.Show(JB.Original_MaterialCost.ToString() + "  " + JB.Original_Margin.ToString() + "  " + JB.Original_MarginPercent.ToString());


                //Releases = await jobscopeClient.GetReleases(JobNumber);
                //DGVJobs.DataSource = Releases;

                //string? ReleaseNumber = Releases[0].ReleaseNumber;
                //ReleaseLineItems = await jobscopeClient.GetReleaseLineItems(ReleaseNumber);
                //ReleaseLineItems = await jobscopeClient.GetReleaseLineItems("I210341");
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

                //var cquery = (from j in Jobs
                //                          join r in Releases
                //                              on j.JobNumber equals r.JobNumber
                //                          join rl in ReleaseLineItems
                //                             on r.ReleaseNumber equals rl.ReleaseNumber
                //                          select new JoinQuery
                //                          {
                //                              JobNumber = j.JobNumber,
                //                              ReleaseNumber = r.ReleaseNumber,
                //                              RelLineNumber = rl.LineItemNumber,
                //                          }).ToList();


                //DGVJobs.DataSource = cquery;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,"Jobscope API Error",MessageBoxButtons.OK);
            }

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
        //    var selectedPromos =
        //        (from promo in promos
        //         join promoClaimed in promosClaimed on promo.objectId equals promoClaimed.PromotionId
        //         select new { PromoName = promo.Name, PromoCode = promo.Code }).ToList();

        //return selectedPromos;


        #endregion

    }
}