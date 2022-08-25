using System.Web;

namespace Vincit.Jobscope.Client;

public class JobscopeClient : BaseHttpClient, IJobscopeClient
{
    private readonly Credentials credentials;
    private readonly AppState appState;
    private static readonly Timer TimeOutTimer = new(new TimerCallback(TickTimer), null, Timeout.Infinite, Timeout.Infinite); 
    private static bool tokenValid;

    public JobscopeClient(HttpClient httpClient, AppState appState, Credentials credentials) : base(httpClient)
    {
        this.credentials = credentials;
        this.appState = appState;

        //Create the Timer, but don't start it yet
        tokenValid = false;

    }


    static void TickTimer(object? state)
    {
        //Timer has expired
        tokenValid = false;
    }
    #region Implementation of IJobscopeClient

    public bool TokenValid { get { return tokenValid; } }

    public async Task<bool> GetAccessToken()
    {
        var url = "token/user";
        var payload = $"grant_type=password&username={credentials.Username}&password={credentials.Password}";

        var response = await Post<CredentialResponse>(url: url, content: payload);
        if (response == null || string.IsNullOrEmpty(response.AccessToken))
        {
            return false;
        }

        appState.AccessToken = response.AccessToken;
        TimeOutTimer.Change((int)response.ExpiresInSeconds, Timeout.Infinite);
        tokenValid=false; 

        return true;
    }

    public async Task<IList<Part>> GetParts(string? PartialPartNumber = default, string? DescriptionContains = default, bool? IncludeInActive = default, int? Top = default)
    {
        var url = "api/Parts?";
        if (PartialPartNumber != null)
        {
            url = url + $"PartialPartNumber={HttpUtility.UrlEncode(PartialPartNumber)}";
        }
        if (DescriptionContains != null)
        {
            url = url + $"DescriptionContains={DescriptionContains}";
        }
        if (IncludeInActive != null)
        {
            url = url + $"IncludeInActive={IncludeInActive}";
        }
        if (Top != null)
        {
            url = url + $"Top={Top}";
        }

        return await Get<IList<Part>>(url) ?? new List<Part>();

    }
    public async Task<IList<PartRouting>> GetPartRoutings(string? PartNumber, bool? IncludeInActive = default)
    {
        var url = "api/PartRoutings?";
        if (PartNumber != null)
        {
            url = url + $"PartNumber={HttpUtility.UrlEncode(PartNumber)}";
        }
        if (IncludeInActive != null)
        {
            url = url + $"IncludeInActive={IncludeInActive}";
        }

        return await Get<IList<PartRouting>>(url) ?? new List<PartRouting>();

    }
 
    public async Task<IList<Job>> GetJobs(string? PartialJobNumber = default, bool? IncludeComplete = default, int? Top = default)
    {
        var url = "api/Jobs?";
        if (PartialJobNumber != null)
        {
            url = url + $"PartialJobNumber={HttpUtility.UrlEncode(PartialJobNumber)}";
        }
        if (IncludeComplete != null)
        {
            url = url + $"IncludeComplete={IncludeComplete}";
        }
        if (Top != null)
        {
            url = url + $"Top={Top}";
        }

        return await Get<IList<Job>>(url) ?? new List<Job>();
    }
    
    public async Task<IList<Release>> GetReleases(string? PartialJobNumber = default, string? PartialReleaseNumber = default, bool? IncludeComplete = default, int? Top = default)
    {
        var url = "api/Releases?";
        if (PartialJobNumber != null)
        {
            url = url + $"PartialJobNumber={HttpUtility.UrlEncode(PartialJobNumber)}";
        }
        if (PartialReleaseNumber != null)
        {
            url = url + $"PartialReleaseNumber={HttpUtility.UrlEncode(PartialReleaseNumber)}";
        }
        if (IncludeComplete != null)
        {
            url = url + $"IncludeComplete={IncludeComplete}";
        }
        if (Top != null)
        {
            url = url + $"Top={Top}";
        }

        return await Get<IList<Release>>(url) ?? new List<Release>();

    }
    public async Task<IList<ReleaseLineItem>> GetReleaseLineItems(string? PartialJobNumber = default, string? PartialReleaseNumber = default, bool? IncludeComplete = default, int? Top = default)
    {
        var url = "api/ReleaseLineItems?";
        if (PartialJobNumber != null)
        {
            url = url + $"PartialJobNumber={HttpUtility.UrlEncode(PartialJobNumber)}";
        }
        if (PartialReleaseNumber != null)
        {
            url = url + $"PartialReleaseNumber={HttpUtility.UrlEncode(PartialReleaseNumber)}";
        }
        if (IncludeComplete != null)
        {
            url = url + $"IncludeComplete={IncludeComplete}";
        }
        if (Top != null)
        {
            url = url + $"Top={Top}";
        }

        return await Get<IList<ReleaseLineItem>>(url) ?? new List<ReleaseLineItem>();

    }

    public async Task<IList<BillOfMaterialComponent>> GetBillOfMaterialComponents(string? PartialAssemblyNumber = default, int? Top = default)
    {
        var url = "api/BillOfMaterialComponents?";
        if (PartialAssemblyNumber != null)
        {
            url = url + $"PartialAssemblyNumber={HttpUtility.UrlEncode(PartialAssemblyNumber)}";
        }
        if (Top != null)
        {
            url = url + $"Top={Top}";
        }

        return await Get<IList<BillOfMaterialComponent>>(url) ?? new List<BillOfMaterialComponent>();

    }

    public async Task<IList<RoutingOperation>> GetRoutingOperations(string? PartialRoutingCode = default, bool? IncludeInActive = default, int? Top = default)
    {
        var url = "api/RoutingOperations?";
        if (PartialRoutingCode != null)
        {
            url = url + $"PartialRoutingCode={HttpUtility.UrlEncode(PartialRoutingCode)}";
        }
        if (IncludeInActive != null)
        {
            url = url + $"IncludeInActive={IncludeInActive}";
        }
        if (Top != null)
        {
            url = url + $"Top={Top}";
        }

        return await Get<IList<RoutingOperation>>(url) ?? new List<RoutingOperation>();

    }
    public async Task<IList<RoutingHeader>> GetRoutingHeaders(string? PartialRoutingId = default, bool? IncludeInActive = default, int? Top = default)
    {
        var url = "api/RoutingHeaders?";
        if (PartialRoutingId != null)
        {
            url = url + $"PartialRoutingCode={HttpUtility.UrlEncode(PartialRoutingId)}";
        }
        if (IncludeInActive != null)
        {
            url = url + $"IncludeInActive={IncludeInActive}";
        }
        if (Top != null)
        {
            url = url + $"Top={Top}";
        }

        return await Get<IList<RoutingHeader>>(url) ?? new List<RoutingHeader>();

    }


    public async Task<IList<GLAccount>> GetGLAccounts(string? PartialAccount = default, string? PartialAccountLevelCode = default, int? Top = default)
    {
        var url = "api/GLAccounts?";
        if (PartialAccount != null)
        {
            url = url + $"PartialAccount={HttpUtility.UrlEncode(PartialAccount)}";
        }
        if (PartialAccountLevelCode != null)
        {
            url = url + $"PartialAccountLevelCode={PartialAccountLevelCode}";
        }
        if (Top != null)
        {
            url = url + $"Top={Top}";
        }

        return await Get<IList<GLAccount>>(url) ?? new List<GLAccount>();

    }
    public async Task<IList<APInvoice>> GetAPInvoices(string? PartialInvoiceNumber = default, int? Top = default, bool? IncludePaid = default)
    {
        var url = "api/APInvoices?";
        if (PartialInvoiceNumber != null)
        {
            url = url + $"PartialInvoiceNumber={HttpUtility.UrlEncode(PartialInvoiceNumber)}";
        }
        if (Top != null)
        {
            url = url + $"Top={Top}";
        }
        if (IncludePaid != null)
        {
            url = url + $"IncludePaid={IncludePaid}";
        }

        return await Get<IList<APInvoice>>(url) ?? new List<APInvoice>();

    }
    public async Task<IList<ARInvoice>> GetARInvoices(string? PartialInvoiceNumber = default, int? Top = default, bool? IncludeComplete = default)
    {
        var url = "api/ARInvoices?";
        if (PartialInvoiceNumber != null)
        {
            url = url + $"PartialInvoiceNumber={HttpUtility.UrlEncode(PartialInvoiceNumber)}";
        }
        if (Top != null)
        {
            url = url + $"Top={Top}";
        }
        if (IncludeComplete != null)
        {
            url = url + $"IncludeComplete={IncludeComplete}";
        }

        return await Get<IList<ARInvoice>>(url) ?? new List<ARInvoice>();

    }
    public async Task<IList<ARInvoiceLine>> GetARInvoiceLines(string? PartialInvoiceNumber = default, int? Top = default, bool? IncludeComplete = default)
    {
        var url = "api/ARInvoiceLines?";
        if (PartialInvoiceNumber != null)
        {
            url = url + $"PartialInvoiceNumber={HttpUtility.UrlEncode(PartialInvoiceNumber)}";
        }
        if (Top != null)
        {
            url = url + $"Top={Top}";
        }
        if (IncludeComplete != null)
        {
            url = url + $"IncludeComplete={IncludeComplete}";
        }

        return await Get<IList<ARInvoiceLine>>(url) ?? new List<ARInvoiceLine>();

    }


    public async Task<IList<ComponentModel>> GetComponentModels(bool? IncludeInActive = default)
    {
        var url = "api/ComponentModels?";
        if (IncludeInActive != null)
        {
            url = url + $"IncludeInActive={IncludeInActive}";
        }

        return await Get<IList<ComponentModel>>(url) ?? new List<ComponentModel>();

    }

    public async Task<IList<Customer>> GetCustomers(string? PartialCustomerNumber = default, int? Top = default, bool? IncludeInActive = default)
    {
        var url = "api/Customers?";
        if (PartialCustomerNumber != null)
        {
            url = url + $"PartialCustomerNumber={HttpUtility.UrlEncode(PartialCustomerNumber)}";
        }
        if (Top != null)
        {
            url = url + $"Top={Top}";
        }
        if (IncludeInActive != null)
        {
            url = url + $"IncludeInActive={IncludeInActive}";
        }

        return await Get<IList<Customer>>(url) ?? new List<Customer>();

    }
    public async Task<IList<CustomerInquiryMaster>> GetCustomerInquiryMasters(string? PartialInquiryNumber = default, int? Top = default, bool? IncludeClosed = default)
    {
        var url = "api/CustomerInquiryMasters?";
        if (PartialInquiryNumber != null)
        {
            url = url + $"PartialInquiryNumber={HttpUtility.UrlEncode(PartialInquiryNumber)}";
        }
        if (Top != null)
        {
            url = url + $"Top={Top}";
        }
        if (IncludeClosed != null)
        {
            url = url + $"IncludeClosed={IncludeClosed}";
        }

        return await Get<IList<CustomerInquiryMaster>>(url) ?? new List<CustomerInquiryMaster>();

    }
    public async Task<IList<CustomerInquiryLine>> GetCustomerInquiryLines(string? PartialInquiryNumber = default, int? Top = default, bool? IncludeClosed = default)
    {
        var url = "api/CustomerInquiryLines?";
        if (PartialInquiryNumber != null)
        {
            url = url + $"PartialInquiryNumber={HttpUtility.UrlEncode(PartialInquiryNumber)}";
        }
        if (Top != null)
        {
            url = url + $"Top={Top}";
        }
        if (IncludeClosed != null)
        {
            url = url + $"IncludeClosed={IncludeClosed}";
        }

        return await Get<IList<CustomerInquiryLine>>(url) ?? new List<CustomerInquiryLine>();

    }

    public async Task<IList<CustomerActivity>> GetCustomerActivitys(string? PartialCustomerNumber = default, int? Top = default, bool? IncludeClosed = default)
    {
        var url = "api/CustomerActivitys?";
        if (PartialCustomerNumber != null)
        {
            url = url + $"PartialCustomerNumber={HttpUtility.UrlEncode(PartialCustomerNumber)}";
        }
        if (Top != null)
        {
            url = url + $"Top={Top}";
        }
        if (IncludeClosed != null)
        {
            url = url + $"IncludeClosed={IncludeClosed}";
        }

        return await Get<IList<CustomerActivity>>(url) ?? new List<CustomerActivity>();

    }








    #endregion

}
