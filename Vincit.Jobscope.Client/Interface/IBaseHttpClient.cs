namespace Vincit.Jobscope.Client.Interface;

public interface IBaseHttpClient
{
    Task<RT?> Get<RT>(string url) where RT : class;
    Task<RT?> Post<RT>(string url, string content) where RT : class;
    Task<RT?> Post<RT, CT>(string url, CT content) where RT : class;
    Task<RT?> Put<RT, CT>(string url, CT content) where RT : class;
    Task Delete(string url);
}
