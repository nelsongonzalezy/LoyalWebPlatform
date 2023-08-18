namespace core.Service
{
    public class RequestMonitorDetailModel
    {
        public int CodigoSolicitud { get; set; }
        public int CodigoCotizacion { get; set; }
        public string CodigoEstadoSolicitud { get; set; } = string.Empty;
        public string DescripcionEstadoSolicitud { get; set; } = string.Empty;
        public DateTime FechaSolicitud { get; set; }
        public int CodigoPais { get; set; }
        public string DescripcionPais { get; set; } = string.Empty;
        public int CodigoProducto { get; set; }
        public string DescripcionProducto { get; set; } = string.Empty;
        public int codigopoliza { get; set; }
        public string DescripcionPoliza { get; set; } = string.Empty;
        public int codigoplan { get; set; }
        public string DescripcionPlan { get; set; } = string.Empty;
        public int CodigoFormaPago { get; set; }
        public string DescripcionFormaPago { get; set; } = string.Empty;
        public int NumeroDependientes { get; set; }
        public bool IndicadorTrasplante { get; set; }
        public bool IndicadorMaternidad { get; set; }
        public int codigoagente { get; set; }
        public string NombreAgente { get; set; } = string.Empty;
    }
}
