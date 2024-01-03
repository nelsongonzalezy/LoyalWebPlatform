namespace core.Service
{
    public class DtDetalleCampanasModel
    {
        public int CodigoDetalleCampana { get; set; }
        public string TipoAgenteCampana { get; set; }
        public int CodigoCampana { get; set; }
        public string DescripcionDetalleCampana { get; set; }
        public decimal RangoInicial { get; set; }
        public decimal RangoFinal { get; set; }
        public string ColorDetalleCampanaR { get; set; }
        public string ColorDetalleCampanaG { get; set; }
        public string ColorDetalleCampanaB { get; set; }
        public bool FormaAnual { get; set; }
        public bool FormaSemestral { get; set; }
        public bool FormaTrimestral { get; set; }
        public bool FormaMensual { get; set; }
    }
}
