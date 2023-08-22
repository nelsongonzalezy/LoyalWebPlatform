namespace core.Service
{
    public class RequestMonitorDetailModel
    {
        public int? CodigoSolicitud { get; set; }
        public int? CodigoCotizacion { get; set; }
        public string CodigoEstadoSolicitud { get; set; }
        public string DescripcionEstadoSolicitud { get; set; }
        public DateTime FechaSolicitud { get; set; }
        public int? CodigoPais { get; set; }
        public string DescripcionPais { get; set; }
        public int? CodigoProducto { get; set; }
        public string DescripcionProducto { get; set; }
        public int? CodigoPoliza { get; set; }
        public string DescripcionPoliza { get; set; }
        public int? CodigoPlan { get; set; }
        public string DescripcionPlan { get; set; }
        public int? CodigoFormaPago { get; set; }
        public string DescripcionFormaPago { get; set; }
        public int? NumeroDependientes { get; set; }
        public string IndicadorTrasplante { get; set; }
        public string IndicadorMaternidad { get; set; }
        public int? CodigoAgente { get; set; }
        public string NombreAgente { get; set; }
    }
    public class ResponseMonitorDetailModel
    {
        public ResponseMonitorDetailModel() { }


        public string Message { get; set; }

        public List<RequestMonitorDetailModel> Content { get; set; }

        public double ElapsedMilliseconds { get; set; }

        public int? TotalRegistros { get; set; }
        public int? PaginaActual { get; set; }
    }
}
