namespace core.Service
{
    public class ForeCastPorPaisModel
    {
        public int CantidadRegistros { get; set; }
        public int CodigoPais { get; set; }
        public string? DescripcionPais { get; set; }
        public decimal PorcentajePaisSobreTotal { get; set; }
        public decimal Cobrado { get; set; }
        public int Vidas { get; set; }
    }
}
