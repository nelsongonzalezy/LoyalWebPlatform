namespace core.Service
{
    public class VwCicloComisionesModel
    {
        public int CodigoCicloComisiones { get; set; }
        public string? CodigoEstadoCicloComisiones { get; set; }
        public string? DescripcionEstadoCicloComisiones { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime FechaFin { get; set; }
        public int IndicadorCicloPago { get; set; }
        public int CantidadTotalPagos { get; set; }
        public decimal MontoTotalPagos { get; set; }
    }
}
