namespace core.Service
{
    public class CifraCertificadoEstadoModel
    {
        public int CantidadRegistros { get; set; }
        public string CodigoEstadoCertificado { get; set; }
        public string DescripcionEstadoCertificado { get; set; }
        public string Icon { get; set; }
    }
    public class ResponseRequestCifraSolicitudEstadoModel
    {
        public string Message { get; set; }

        public List<CifraCertificadoEstadoModel> Content { get; set; }

        public double ElapsedMilliseconds { get; set; }

        public int? TotalRegistros { get; set; }
        public int? PaginaActual { get; set; }
    }
}
