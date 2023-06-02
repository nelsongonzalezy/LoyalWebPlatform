namespace core.Service
{
    public interface IHttpServicesUnAuthorized
    {
        Task<TResponse> GetUnAuthorizedAsync<TResponse>(string pathUrl);
        Task<TResponse> PostUnAuthorizedAsync<TSource, TResponse>(string pathUrl, TSource body);
        Task<TResponse> PutUnAuthorizedAsync<TSource, TResponse>(string pathUrl, TSource body);
    }
}
