namespace core.Service
{
    public class VwCampanaDetalleAgenciaModel
    {
        public int CodigoCampana { get; set; }
        public int Fila { get; set; }
        public string? CodigoAgencia { get; set; }
        public string? NombreAgencia { get; set; }
        public int Cantidad { get; set; }
        public Decimal Prima { get; set; }
        public Decimal PrimaReal { get; set; }
        public Decimal PrimaCobrada { get; set; }
    }
}
