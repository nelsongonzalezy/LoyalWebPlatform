namespace core.Service
{
    public class ForeCastService : IForeCast
    {
        private readonly IHttpServicesUnAuthorized _unAuthorized;
        public ForeCastService(IHttpServicesUnAuthorized unAuthorized)
        {
            _unAuthorized = unAuthorized;
        }
        public async Task<IQueryable<ForeCastModel>> GetListForeCast()
        {
            var y = await _unAuthorized.GetUnAuthorizedAsync<ResponseForeCastModel>("api/v1/ForeCast");

            return y.Content.AsQueryable();
        }
    }
}
