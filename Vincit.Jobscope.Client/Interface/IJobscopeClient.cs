namespace Vincit.Jobscope.Client.Interface;

public interface IJobscopeClient : IBaseHttpClient
{
    Task<bool> GetAccessToken();
    Task<IList<Job>> GetJobs(string? PartialJobNumber = default, bool? IncludeComplete = default, int? Top = default);
    Task<IList<Release>> GetReleases(string? PartialJobNumber = default, string? PartialReleaseNumber = default, bool? IncludeComplete = default, int? Top = default);
    Task<IList<ReleaseLineItem>> GetReleaseLineItems(string? PartialJobNumber = default, string? PartialReleaseNumber = default, bool? IncludeComplete = default, int? Top = default);
    
    Task<IList<Part>> GetParts(string? PartialPartNumber = default, string? DescriptionContains = default, bool? IncludeInActive = default, int? Top = default);
    Task<IList<PartRouting>> GetPartRoutings(string? PartNumber, bool? IncludeInActive = default);

    Task<IList<RoutingOperation>> GetRoutingOperations(string? PartialRoutingCode = default, bool? IncludeInActive = default, int? Top = default);
    Task<IList<RoutingHeader>> GetRoutingHeaders(string? PartialRoutingId = default, bool? IncludeInActive = default, int? Top = default);
    Task<IList<BillOfMaterialComponent>> GetBillOfMaterialComponents(string? PartialAssemblyNumber = default, int? Top = default);

    Task<IList<GLAccount>> GetGLAccounts(string? PartialAccount = default, string? PartialAccountLevelCode = default, int? Top = default);
    Task<IList<APInvoice>> GetAPInvoices(string? PartialInvoiceNumber = default, int? Top = default, bool? IncludePaid = default);
    Task<IList<ARInvoice>> GetARInvoices(string? PartialInvoiceNumber = default, int? Top = default, bool? IncludeComplete = default);
    Task<IList<ARInvoiceLine>> GetARInvoiceLines(string? PartialInvoiceNumber = default, int? Top = default, bool? IncludeComplete = default);

    Task<IList<ComponentModel>> GetComponentModels(bool? IncludeInActive = default);

    Task<IList<Customer>> GetCustomers(string? PartialCustomerNumber = default, int? Top = default, bool? IncludeInActive = default);
    Task<IList<CustomerInquiryMaster>> GetCustomerInquiryMasters(string? PartialInquiryNumber = default, int? Top = default, bool? IncludeClosed = default);
    Task<IList<CustomerInquiryLine>> GetCustomerInquiryLines(string? PartialInquiryNumber = default, int? Top = default, bool? IncludeClosed = default);

    Task<IList<CustomerActivity>> GetCustomerActivitys(string? PartialCustomerNumber = default, int? Top = default, bool? IncludeClosed = default);




    bool TokenValid { get; }


}

