namespace core.Service
{
    public class VwCampanaDetalleMgaModel
    { 
        public int CodigoCampana { get; set; }
        public int Fila { get; set; }
        public string? CodigoMGA { get; set; }
        public string? NombreMGA { get; set; }
        public int Cantidad { get; set; }
        public Decimal Prima { get; set; }
        public Decimal PrimaReal { get; set; }
        public Decimal PrimaCobrada { get; set; }
    }
}
