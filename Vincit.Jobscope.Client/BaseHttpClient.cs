namespace Vincit.Jobscope.Client;

public abstract class BaseHttpClient : IBaseHttpClient
{
    private readonly JsonSerializerOptions jsonDeserializerOptions;

    protected HttpClient HttpClient { get; set; }

    public BaseHttpClient(HttpClient httpClient)
    {
        HttpClient = httpClient;
        jsonDeserializerOptions = new JsonSerializerOptions
        {
            PropertyNameCaseInsensitive = true
        };
    }

    #region Http Methods

    public async Task<RT?> Get<RT>(string url) where RT : class
    {
        return await ProcessRequest<RT, object>(url, HttpMethod.Get);
    }

    public async Task<RT?> Post<RT>(string url, string content) where RT : class
    {
        return await ProcessRequest<RT>(url, HttpMethod.Post, content);
    }

    public async Task<RT?> Post<RT, CT>(string url, CT content) where RT : class
    {
        return await ProcessRequest<RT, CT>(url, HttpMethod.Post, content);
    }

    public async Task<RT?> Put<RT, CT>(string url, CT content) where RT : class
    {
        return await ProcessRequest<RT, CT>(url, HttpMethod.Put, content);
    }

    public async Task Delete(string url)
    {
        await ProcessRequest<object>(url, HttpMethod.Delete, content: null);
        return;
    }

    #endregion

    #region Implementation

    private async Task<RT?> ProcessRequest<RT, CT>(string url, HttpMethod method, CT? content = default) where RT : class
    {
        string? json = null;
        if (content != null)
        {
            json = JsonSerializer.Serialize(content);
        }
        return await ProcessRequest<RT>(url, method, content: json, mimeType: "application/json");
    }

    private async Task<RT?> ProcessRequest<RT>(string url, HttpMethod method, string? content = default, string? mimeType = default) where RT : class
    {
        var request = BuildRequest(url, method, content: content, mimeType: mimeType);

        var response = await HttpClient.SendAsync(request);

        if (response.IsSuccessStatusCode)
        {
            var responseString = await response.Content.ReadAsStringAsync();
            if (string.IsNullOrWhiteSpace(responseString))
            {
                return default;
            }
            var responseObject = JsonSerializer.Deserialize<RT>(json: responseString, options: jsonDeserializerOptions);

            if (responseObject == null)
            {
                return default;
            }

            return responseObject;
        }
        else
        {
            throw new Exception($"{method}:{url} return {response.StatusCode}");
        }
    }

    private HttpRequestMessage BuildRequest(string url, HttpMethod method, string? content, string? mimeType = null)
    {
        var request = new HttpRequestMessage(method, url);

        if (content != null)
        {
            request.Content = new StringContent(content, encoding: Encoding.UTF8, mediaType: mimeType);
        }

        return request;
    }

    #endregion
}

