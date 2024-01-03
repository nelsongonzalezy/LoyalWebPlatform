namespace core.Service
{
    public class VwDetalleCicloComisionesAgenteModel
    {
        public int CodigoAgente { get; set; }
        public int CodigoCicloComisiones { get; set; }
        public int CodigoCronogramaPagos { get; set; }
        public string? OrigenVenta { get; set; }
        public string? NumeroPoliza { get; set; }
        public int CodigoCertificado { get; set; }
        public DateTime FechaPago { get; set; }
        public string? CicloComisionOriginal { get; set; }
        public string? TipoPago { get; set; }
        public string? TitularPoliza { get; set; }
        public int CodigoAgenteGenera { get; set; }
        public string? NombreAgente { get; set; }
        public string? NombreGrupo { get; set; }
        public decimal PrimaAnual { get; set; }
        public decimal PrimaNeta { get; set; }
        public decimal CostoAdministrativo { get; set; }
        public decimal PrimaComisionableAnual { get; set; }
        public decimal PrimaComisionable { get; set; }
        public decimal PorcentajeComision { get; set; }
        public decimal MontoComision { get; set; }
        public string? FormaPago { get; set; }
        public int CodigoAgenteMGA { get; set; }
        public string? AgenteMGA { get; set; }
        public string? CodigoTipoVenta { get; set; }
        public string? DescripcionTipoVenta { get; set; }
    }
}
