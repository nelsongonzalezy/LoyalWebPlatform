namespace core.Service
{
    public class AgenteCarteraModel
    {
        public int CodigoCertificado { get; set; }
        public string? NumeroPoliza { get; set; }
        public string? DescripcionTipoVenta { get; set; }
        public string? NombreCompleto { get; set; }
        public int NumeroAsegurados { get; set; }
        public string? DescripcionPoliza { get; set; }
        public string? DescripcionPais { get; set; }
        public string? DescripcionEstadoCertificado { get; set; }
        public DateTime FechaInicioVigencia { get; set; }
        public string? DescripcionFormaPago { get; set; }
        public decimal Prima { get; set; }
        public string? DescripcionPlan { get; set; }
        public int CodigoAgente { get; set; }
        public string? NombreAgente { get; set; }
        public int CuotasPagadas { get; set; }
        public decimal CuotasPagadasValor { get; set; }
        public int CuotasPendiente { get; set; }
        public decimal CuotasPendienteValor { get; set; }
        public int CuotasCanceladas { get; set; }
        public decimal CuotasCanceladasValor { get; set; }
        public int NumeroCuotasAnho { get; set; }
        public string FechaSiguientePago { get; set; } = string.Empty;
    }
}
