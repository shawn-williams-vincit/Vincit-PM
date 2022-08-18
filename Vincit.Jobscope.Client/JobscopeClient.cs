using System.Web;

namespace Vincit.Jobscope.Client;

public class JobscopeClient : BaseHttpClient, IJobscopeClient
{
    private readonly Credentials credentials;
    private readonly AppState appState;
    private static Timer? TimeOutTimer; 
    private static bool tokenValid;

    public JobscopeClient(HttpClient httpClient, AppState appState, Credentials credentials) : base(httpClient)
    {
        this.credentials = credentials;
        this.appState = appState;

        //Create the Timer, but don't start it yet
        TimeOutTimer = new Timer(new TimerCallback(TickTimer), null, Timeout.Infinite, Timeout.Infinite);
        tokenValid = false;

    }


    static void TickTimer(object state)
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

    public async Task<IList<Job>> GetJobs(string? partialJobNumber = default, bool? includeComplete = default, int? top = default)
    {
        var url = "api/Jobs?";
        if (partialJobNumber != null)
        {
            url = url + $"PartialJobNumber={HttpUtility.UrlEncode(partialJobNumber)}";
        }
        if (includeComplete != null)
        {
            url = url + $"IncludeComplete={includeComplete}";
        }
        if (top != null)
        {
            url = url + $"Top={top}";
        }

        return await Get<IList<Job>>(url) ?? new List<Job>();
    }


    public async Task<IList<Release>> GetReleases(string? partialJobNumber = default, string? partialReleaseNumber = default, bool? includeComplete = default, int? top = default)
    {
        var url = "api/Releases?";
        if (partialJobNumber != null)
        {
            url = url + $"PartialJobNumber={HttpUtility.UrlEncode(partialJobNumber)}";
        }
        if (partialReleaseNumber != null)
        {
            url = url + $"PartialReleaseNumber={HttpUtility.UrlEncode(partialReleaseNumber)}";
        }
        if (includeComplete != null)
        {
            url = url + $"IncludeComplete={includeComplete}";
        }
        if (top != null)
        {
            url = url + $"Top={top}";
        }

        return await Get<IList<Release>>(url) ?? new List<Release>();

    }

    #endregion

}
