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
            var y = await _unAuthorized.GetUnAuthorizedAsync<ResponseForeCastModel>("api/v1/ForeCast/ObtenerForeCast");

            return y.Content.AsQueryable();
        }
        public async Task<DetalleForeCastModel> GetDetailsForeCast(int CodigoPeriodo, string CodigoTipoVenta)
        {
            var y = await _unAuthorized.GetUnAuthorizedAsync<ResponseDetalleForeCastModel>("api/v1/ForeCast/ObtenerDetalleForeCast?CodigoPeriodo="+CodigoPeriodo+"&CodigoTipoVenta="+ CodigoTipoVenta + "");

            return y.Content;
        }        
        public async Task<DetalleForeCastModel> GetForeCastTotal(int CodigoPeriodo)
        {
            var y = await _unAuthorized.GetUnAuthorizedAsync<ResponseDetalleForeCastModel>("api/v1/ForeCast/ObtenerDetalleForeCast?CodigoPeriodo="+CodigoPeriodo+"");

            return y.Content;
        }
        public async Task<DetalleForeCastModel> GetForeCastTotal()
        {
            var y = await _unAuthorized.GetUnAuthorizedAsync<ResponseDetalleForeCastModel>("api/v1/ForeCast/ObtenerDetalleForeCastTotal");

            return y.Content;
        }
    }
}
