namespace core.Service
{
    public interface IHttpServicesAuthorized
    {
        Task<TResponse> GetAuthorizedAsync<TResponse>(string pathUrl, string token);
        Task<TResponse> PutAuthorizedAsync<TSource, TResponse>(string pathUrl, string token, TSource body);
        Task<TResponse> DeleteAuthorizedAsync<TSource, TResponse>(string pathUrl, string token, TSource body);
        Task<TResponse> PostAuthorizedAsync<TSource, TResponse>(string pathUrl, string token, TSource body);
    }


}
