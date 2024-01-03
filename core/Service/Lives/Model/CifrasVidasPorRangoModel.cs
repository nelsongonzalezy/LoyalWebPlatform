namespace core.Service
{
    public class CifrasVidasPorRangoModel
    {
        public string? GrupoEdad { get; set; }
        public int CodigoPoliza { get; set; }
        public string? DescripcionPoliza { get; set; }
        public int TotalPersonas { get; set; }
        public decimal PorcentajeGrupoEdadSobreTotal { get; set; }
    }
}
