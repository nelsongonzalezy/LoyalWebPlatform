namespace core.Service
{
    public class ProductService : IProduct 
    {

        private readonly IHttpServicesUnAuthorized _unAuthorized; 
        public ProductService(IHttpServicesUnAuthorized unAuthorized)
        {
            this._unAuthorized = unAuthorized;
        }

        public async Task<IQueryable<ProducComponentModel>> GetProducComponent()
        {
            var y = await _unAuthorized.GetUnAuthorizedAsync<ResponseProduct>("api/v1/Solicitud/ObtenerCifraSolicitudProducto");
            foreach (var item in y.Content)
            {
                if (item.CodigoProducto ==3)
                {
                    item.Color = "background-color:rgb(48,182,181)";
                    item.Img = "/assets/img/liberty.png";
                }               
                if (item.CodigoProducto ==1)
                {
                    item.Color = "background-color:rgb(60,95,138)";
                    item.Img = "/assets/img/beyond.png";
                }                
                if (item.CodigoProducto ==4)
                {
                    item.Color = "background-color:rgb(132,26,102)";
                    item.Img = "/assets/img/legacy.png";
                }               
                if (item.CodigoProducto ==2)
                {
                    item.Color = "background-color:rgb(141,195,65)";
                    item.Img = "/assets/img/privilege.png";
                }
            }
            return y.Content.AsQueryable();
        }
    }
}
