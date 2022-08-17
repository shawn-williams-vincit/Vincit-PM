namespace Vincit.Jobscope.Client.Models;

public class CredentialResponse
{
    [JsonPropertyName("access_token")]
    public string? AccessToken { get; set; }
    [JsonPropertyName("token_type")]
    public string? TokenType { get; set; }
    [JsonPropertyName("expires_in")]
    public int ExpiresInSeconds { get; set; }
}