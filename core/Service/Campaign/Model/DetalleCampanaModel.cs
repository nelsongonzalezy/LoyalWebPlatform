namespace core.Service.Campaign.Model
{
    public class DetalleCampanaModel
    {
        public int CodigoDetalleCampana { get; set; }
        public string? TipoAgenteCampana { get; set; }
        public int CodigoCampana { get; set; }
        public string? DescripcionDetalleCampana { get; set; }
        public decimal RangoInicial { get; set; }
        public decimal RangoFinal { get; set; }
        public int ColorDetalleCampanaR { get; set; }
        public int ColorDetalleCampanaG { get; set; }
        public int ColorDetalleCampanaB { get; set; }

    }
}
