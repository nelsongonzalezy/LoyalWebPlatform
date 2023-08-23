using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace core.Service
{
    public class DraftService :IDraft
    {
        private readonly IHttpServicesUnAuthorized _unAuthorized;
        public DraftService(IHttpServicesUnAuthorized unAuthorized) {
            this._unAuthorized = unAuthorized;
        }

        public async Task<IQueryable<DraftStatusModel>> GetAllStatus()
        {
            var y = await _unAuthorized.GetUnAuthorizedAsync<ResponseRequestMonitorStatusModel>("api/v1/Solicitud/ObtenerCifraSolicitudProducto");
            var x = new List<DraftStatusModel>();

            x.Add(new DraftStatusModel() { CantidadRegistros = 22, codigoEstadoSolicitud = "03", DescripcionEstadoSolicitud = "Pendiente UW", Icon= "ri-shopping-bag-3-line" });
            x.Add(new DraftStatusModel() { CantidadRegistros = 1423, codigoEstadoSolicitud = "04", DescripcionEstadoSolicitud = "Aprobada", Icon= "ri-shopping-bag-3-line" });
            x.Add(new DraftStatusModel() { CantidadRegistros = 110, codigoEstadoSolicitud = "05", DescripcionEstadoSolicitud = "Denegada", Icon= "ri-shopping-bag-3-line" });
            x.Add(new DraftStatusModel() { CantidadRegistros = 184, codigoEstadoSolicitud = "06", DescripcionEstadoSolicitud = "Anulada", Icon= "ri-shopping-bag-3-line" });
            return x.AsQueryable();
        }
    }
}
