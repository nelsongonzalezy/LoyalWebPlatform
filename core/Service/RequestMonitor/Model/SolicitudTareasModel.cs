namespace core.Service
{
    public class SolicitudTareasModel
    {
        public int? CodigoTarea { get; set; }
        public int? CodigoTipoTarea { get; set; }
        public string DescripcionTipoTarea { get; set; }
        public int? CodigoEstadoTarea { get; set; }
        public string DescripcionEstadoTarea { get; set; }
        public DateTime? FechaInicioTarea { get; set; }
        public DateTime? FechaFinTarea { get; set; }
        public DateTime? FechaVencimientoTarea { get; set; }
        public string DescripcionTarea { get; set; }
        public string DataBusqueda { get; set; }
        public int? UsuarioAsignado { get; set; }
        public string NombreUsuarioAsignado { get; set; }
        public string NumeroPoliza { get; set; }
        public string DescripcionPoliza { get; set; }
        public string NombreCompleto { get; set; }
        public int? CodigoAgente { get; set; }
        public string NombreAgente { get; set; }
        public string DescripcionPlanesConsulta { get; set; }
        public int? CodigoSolicitud { get; set; }
        public DateTime? FechaRegistro { get; set; }
        public int? Notas { get; set; }
    }
    public class ResponseRequestSolicitudTareasModel
    {
        public ResponseRequestSolicitudTareasModel() { }


        public string Message { get; set; }

        public List<SolicitudTareasModel> Content { get; set; }

        public double ElapsedMilliseconds { get; set; }

        public int? TotalRegistros { get; set; }
        public int? PaginaActual { get; set; }
    }
}
