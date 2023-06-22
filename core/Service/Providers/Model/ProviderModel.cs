using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace core.Service
{
    public class ProviderModel
    {
        public int CodigoProveedor { get; set; }
        public string RazonSocialProveedor { get; set; }
        public int CodigoPais { get; set; }
        public string DescripcionPais { get; set; }
        public string Ciudad { get; set; }
        public string Estado { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
        public string CodigoEstadoProveedor { get; set; }
        public string DescripcionEstadoProveedor { get; set; }

        public DateTime FechaEfectividad { get; set; }
    }
}
