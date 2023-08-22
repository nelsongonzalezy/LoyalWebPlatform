namespace core.Service
{
    public class RequestMonitorStatusModel
    {
        public int CantidadRegistros { get; set; }
        public string codigoEstadoSolicitud { get; set; } = string.Empty;
        public string DescripcionEstadoSolicitud { get; set; } = string.Empty;
        public string Icon { get; set; } = string.Empty;
    }
    public class ResponseRequestMonitorStatusModel
    {
        public ResponseRequestMonitorStatusModel() { }


        public string Message { get; set; }

        public List<RequestMonitorStatusModel> Content { get; set; }

        public double ElapsedMilliseconds { get; set; }

        public int? TotalRegistros { get; set; }
        public int? PaginaActual { get; set; }
    }

}
