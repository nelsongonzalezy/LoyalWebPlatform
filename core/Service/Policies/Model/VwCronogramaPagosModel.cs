namespace core.Service
{
    public class VwCronogramaPagosModel
    {
        public string? NumeroPoliza { get; set; }
        public int CodigoCronogramaPagos { get; set; }
        public int CodigoCertificado { get; set; }
        public int NumeroCuota { get; set; }
        public string? NumeroCupon { get; set; }
        public string? CodigoEstadoCuota { get; set; }
        public string? DescripcionEstadoCuota { get; set; }
        public decimal ValorCuota { get; set; }
        public decimal CostoAdministrativo { get; set; }
        public decimal ValorPrima { get; set; }
        public decimal ValorIntereses { get; set; }
        public decimal ValorSaldoCuota { get; set; }
        public DateTime FechaVencimiento { get; set; }
        public DateTime FechaCobro { get; set; }
        public DateTime FechaPago { get; set; }
        public DateTime FechaRegistro { get; set; }
        public int UsuarioRegistro { get; set; }
        public int CodigoCuentaActual { get; set; }
        public string? DescripcionEstadoCertificado { get; set; }
        public string? CodigoTipoVenta { get; set; }
        public int CodigoAvisoPrima { get; set; }
        public string? CodigoEstadoCertificado { get; set; }
        public decimal Prima { get; set; }
        public int NumeroAsegurados { get; set; }
        public DateTime FechaEfectividad { get; set; }
        public DateTime FechaInicioCobertura { get; set; }
        public DateTime FechaFinCobertura { get; set; }
        public int IndicadorPagoAutomatico { get; set; }
    }
}
