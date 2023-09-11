using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace core.Service
{
    public class ListaAseguradosModel
    {
        public string NumeroPoliza { get; set; }
        public int CodigoPersona { get; set; }
        public string DescripcionEstadoPersonaSolicitud { get; set; }
        public string DescripcionTipoPersonaCotizacion { get; set; }
        public string NombreCompleto { get; set; }
    }
}
