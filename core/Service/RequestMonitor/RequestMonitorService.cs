namespace core.Service
{
    public class RequestMonitorService : IRequestMonitor
    {
        private readonly IHttpServicesUnAuthorized _unAuthorized;
        public RequestMonitorService(IHttpServicesUnAuthorized unAuthorized)
        {
            this._unAuthorized = unAuthorized;
        }
        public async Task<IQueryable<RequestMonitorStatusModel>> GetAllStatus()
        {
            var y = await _unAuthorized.GetUnAuthorizedAsync<ResponseRequestMonitorStatusModel>("api/v1/Solicitud/ObtenerCifraSolicitudEstado");
            var x = new List<RequestMonitorStatusModel>();
            foreach (var item in y.Content)
            {
                item.Icon = "ri-shopping-bag-3-line";
            }
            return y.Content.AsQueryable();
        }
        public async Task<IQueryable<RequestMonitorDetailModel>> GetAlList()
        {
            var y = await _unAuthorized.GetUnAuthorizedAsync<ResponseMonitorDetailModel>("api/v1/Solicitud");
           
            return y.Content.AsQueryable();
        }
        public async Task<IQueryable<RequestMonitorDetailModel>> Getbyid(int CodigoSolicitud)
        {
            var y = await _unAuthorized.GetUnAuthorizedAsync<ResponseMonitorDetailModel>("api/v1/Solicitud/?codigoSolicitud=" + CodigoSolicitud.ToString());

            return y.Content.AsQueryable();
        }
        public async Task<IQueryable<SolicitudTareasModel>> GetTaskByID(string codigoSolicitud)
        {
            var y = await _unAuthorized.GetUnAuthorizedAsync<ResponseRequestSolicitudTareasModel>("api/v1/Solicitud/SolicitudTarea?codigoSolicitud=" + codigoSolicitud.ToString());

            return y.Content.AsQueryable();
        }

    }
}
