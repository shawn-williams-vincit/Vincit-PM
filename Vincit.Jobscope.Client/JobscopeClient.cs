using System.Web;

namespace Vincit.Jobscope.Client;

public class JobscopeClient : BaseHttpClient, IJobscopeClient
{
    private readonly Credentials credentials;
    private readonly AppState appState;

    public JobscopeClient(HttpClient httpClient, AppState appState, Credentials credentials) : base(httpClient)
    {
        this.credentials = credentials;
        this.appState = appState;
    }

    #region Implementation of IJobscopeClient

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
        return true;
    }

    public async Task<IList<Job>> GetJobs(string? partialJobNumber = default, bool? includeComplete = default, int? top = default)
    {
        var url = "api/Jobs?";
        if (partialJobNumber != null)
        {
            url = $"PartialJobNumber={HttpUtility.UrlEncode(partialJobNumber)}";
        }
        if (includeComplete != null)
        {
            url = $"IncludeComplete={includeComplete}";
        }
        if (top != null)
        {
            url = $"Top={top}";
        }

        return await Get<IList<Job>>(url) ?? new List<Job>();
    }

    #endregion

}
