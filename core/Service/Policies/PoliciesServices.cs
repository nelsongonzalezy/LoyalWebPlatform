namespace core.Service
{
    public class PoliciesServices : IPolicies
    {
        private readonly IHttpServicesUnAuthorized _unAuthorized;
        public PoliciesServices(IHttpServicesUnAuthorized unAuthorized)
        {
            this._unAuthorized = unAuthorized;
        }
        public async Task<IQueryable<CertificadosModel>> GetAll()
        {
            var y = await _unAuthorized.GetUnAuthorizedAsync<ResponseRequestCertificadosModel>("api/v1/Certificados/ObtenerCertificados");
           
            
            return y.Content.AsQueryable();
        }       
        public async Task<IQueryable<CifraCertificadoEstadoModel>> GetAllStatus()
        {
            var y = await _unAuthorized.GetUnAuthorizedAsync<ResponseRequestCifraSolicitudEstadoModel>("api/v1/Certificados/ObtenerCertificadosEstado");
            foreach (var item in y.Content)
            {
                item.Icon = "ri-shopping-bag-3-line";
            }

            return y.Content.AsQueryable();
        }        
        public async Task<IQueryable<CifraCertificadoProductoModel>> GetAllProduct()
        {
            var y = await _unAuthorized.GetUnAuthorizedAsync<ResponseRequestCifraSolicitudProductoModel>("api/v1/Certificados/ObtenerCertificadosProducto");
            foreach (var item in y.Content)
            {
                if (item.CodigoProducto == 3)
                {
                    item.Color = "background-color:rgb(48,182,181)";
                    item.Img = "/assets/img/liberty.png";
                }
                if (item.CodigoProducto == 1)
                {
                    item.Color = "background-color:rgb(60,95,138)";
                    item.Img = "/assets/img/beyond.png";
                }
                if (item.CodigoProducto == 4)
                {
                    item.Color = "background-color:rgb(132,26,102)";
                    item.Img = "/assets/img/legacy.png";
                }
                if (item.CodigoProducto == 2)
                {
                    item.Color = "background-color:rgb(141,195,65)";
                    item.Img = "/assets/img/privilege.png";
                }

            }

            return y.Content.AsQueryable();
        }
    }
}
