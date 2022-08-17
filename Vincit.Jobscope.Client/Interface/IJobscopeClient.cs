namespace Vincit.Jobscope.Client.Interface;

    public interface IJobscopeClient : IBaseHttpClient
    {
        Task<bool> GetAccessToken();
        Task<IList<Job>> GetJobs(string? partialJobNumber = default, bool? includeComplete = default, int? top = default);

    }

