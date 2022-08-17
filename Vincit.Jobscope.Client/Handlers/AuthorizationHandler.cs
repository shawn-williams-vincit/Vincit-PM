namespace Vincit.Jobscope.Client.Handlers;

public class AuthorizationHandler : DelegatingHandler
{
    private readonly AppState _appState;

    public AuthorizationHandler(AppState appState)
    {
        _appState = appState;
    }

    protected override Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken)
    {
        if (!string.IsNullOrWhiteSpace(_appState.AccessToken))
        {
            request.Headers.Authorization = new AuthenticationHeaderValue("Bearer", _appState.AccessToken);
        }

        return base.SendAsync(request, cancellationToken);
    }
}
