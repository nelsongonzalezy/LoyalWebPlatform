namespace core.Service
{
    public class VvCertificadosPorPaisModel
    {
        public int CantidadRegistros { get; set; }
        public int codigopais { get; set; }
        public string? descripcionPais { get; set; }
        public string? latitud { get; set; }
        public string? longitud { get; set; }
        public decimal PorcentajePaisSobreTotal { get; set; }
        public decimal Cobrado { get; set; }
        public int Vidas { get; set; }
    }
    public class ResponseRequestVvCertificadosPorPaisModel
    {
        public string Message { get; set; }

        public List<VvCertificadosPorPaisModel> Content { get; set; }

        public double ElapsedMilliseconds { get; set; }

        public int? TotalRegistros { get; set; }
        public int? PaginaActual { get; set; }
    }
}
