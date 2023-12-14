namespace core.Service
{
    public class VwCicloComisionesAgenteModel
    {
        public int CodigoAgente { get; set; }
        public string? NombreAgente { get; set; }
        public int CodigoCicloComisiones { get; set; }
        public decimal TotalNuevoNegocio { get; set; }
        public decimal TotalRenovaciones { get; set; }
        public decimal TotalAcumulado { get; set; }
        public decimal TotalAjustes { get; set; }
        public decimal TotalComisiones { get; set; }
        public int CantidadPolizas { get; set; }
        public int CodigoEstadoCuenta { get; set; }
        public int CodigoPagoComision { get; set; }
        public string? CodigoEstadoCicloComisionesAgente { get; set; }
        public string? DescripcionEstadoCicloComisionesAgente { get; set; }
        public int IndicadorEnviarPago { get; set; }
        public int IndicadorBatch { get; set; }
        public int NumeroFila { get; set; }
    }
}
