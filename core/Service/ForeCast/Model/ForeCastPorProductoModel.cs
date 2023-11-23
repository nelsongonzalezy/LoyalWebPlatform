namespace core.Service
{
    public class ForeCastPorProductoModel
    {
        public int CantidadRegistros { get; set; }
        public int CodigoPoliza { get; set; }
        public string? DescripcionPoliza { get; set; }
        public decimal PorcentajePolizaSobreTotal { get; set; }
        public decimal Cobrado { get; set; }
        public int Vidas { get; set; }
    }
}
