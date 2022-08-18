namespace Vincit.Jobscope.Client.Interface;

public interface IJobscopeClient : IBaseHttpClient
{
    Task<bool> GetAccessToken();
    Task<IList<Job>> GetJobs(string? partialJobNumber = default, bool? includeComplete = default, int? top = default);
    Task<IList<ReleaseTest>> GetReleases(string? partialJobNumber = default, string? partialReleaseNumber = default, bool? includeComplete = default, int? top = default);


    bool TokenValid { get; }


}

