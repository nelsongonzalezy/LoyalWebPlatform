namespace core.Service
{
    public class VwCampanaEstadosModel
    {
        public int CantidadRegistros { get; set; }
        public string? CodigoEstadoCertificado { get; set; }
        public string? DescripcionEstadoCertificado { get; set; }
        public decimal PrimaComisionable { get; set; }
        public decimal CostoAdministrativo { get; set; }
        public decimal PorcentajeCantidadRegistros { get; set; }
    }
}
