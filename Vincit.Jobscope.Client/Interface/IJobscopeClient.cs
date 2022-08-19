namespace Vincit.Jobscope.Client.Interface;

public interface IJobscopeClient : IBaseHttpClient
{
    Task<bool> GetAccessToken();
    Task<IList<Job>> GetJobs(string? PartialJobNumber = default, bool? IncludeComplete = default, int? Top = default);
    Task<IList<Release>> GetReleases(string? PartialJobNumber = default, string? PartialReleaseNumber = default, bool? IncludeComplete = default, int? Top = default);
    Task<IList<ReleaseLineItem>> GetReleaseLineItems(string? PartialJobNumber = default, string? PartialReleaseNumber = default, bool? IncludeComplete = default, int? Top = default);
    
    
    Task<IList<RoutingOperation>> GetRoutingOperations(string? PartialRoutingCode = default, bool? IncludeInActive = default, int? Top = default);
    Task<IList<RoutingHeader>> GetRoutingHeaders(string? PartialRoutingId = default, bool? IncludeInActive = default, int? Top = default);
    Task<IList<BillOfMaterialComponent>> GetBillOfMaterialComponents(string? PartialAssemblyNumber = default, int? Top = default);

    Task<IList<GLAccount>> GetGLAccounts(string? PartialAccount = default, string? PartialAccountLevelCode = default, int? Top = default);




    bool TokenValid { get; }


}

