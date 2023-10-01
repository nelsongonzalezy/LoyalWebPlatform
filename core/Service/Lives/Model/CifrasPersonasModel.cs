namespace core.Service
{
    public class CifrasPersonasModel
    {
        public string GrupoEdad { get; set; }
        public string Sexo { get; set; }
        public int TotalPersonas { get; set; }
        public decimal PorcentajeGrupoEdadSobreTotal { get; set; }
        public decimal PorcentajeGrupoEdadSobreGrupo { get; set; }
        public string? DescripcionPoliza { get; set; }
        public int CodigoPoliza { get; set; }

    }
}
