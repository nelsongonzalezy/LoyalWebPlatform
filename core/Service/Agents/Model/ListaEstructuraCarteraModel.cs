namespace core.Service
{
    public class ListaEstructuraCarteraModel
    {
        public int CodigoAgente { get; set; }
        public string? NombreAgente { get; set; }
        public string? CodigoEstadoAgente { get; set; }
        public string? DescripcionEstadoAgente { get; set; }
        public decimal Activas { get; set; }
        public decimal PendientePago { get; set; }
        public decimal ActivaNuevoNegocio { get; set; }
        public decimal ActivaRenovacion { get; set; }
        public decimal PeriodoGracia { get; set; }
        public decimal Cancelado { get; set; }
        public decimal PendientePrimerPago { get; set; }
        public int CantidadActivas { get; set; }
        public int CantidadPeriodoGracia { get; set; }
        public int CantidadCanceladas { get; set; }
        public int CantidadPendientePago { get; set; }
    }
    public class ResponseListaEstructuraCarteraModel 
    {
        public string Message { get; set; }

        public List<ListaEstructuraCarteraModel> Content { get; set; }

        public double ElapsedMilliseconds { get; set; }

        public int? TotalRegistros { get; set; }
        public int? PaginaActual { get; set; }
    }
}
