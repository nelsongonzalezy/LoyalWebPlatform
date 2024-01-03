namespace core.Service
{
    public class CifraCertificadosRenovacionesModel
    {
        public int CantidadRegistros { get; set; }
        public string? CodigoEstadoCertificado { get; set; }
        public string? DescripcionEstadoCertificado { get; set; }
    }
    public class ResponseCifraCertificadosRenovacionesModel
    {
        public string Message { get; set; }

        public List<CifraCertificadosRenovacionesModel> Content { get; set; }

        public double ElapsedMilliseconds { get; set; }

        public int? TotalRegistros { get; set; }
        public int? PaginaActual { get; set; }
    }
}
