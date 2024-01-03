namespace core.Service
{
    public class VwCampanaDetalleAgentModel
    {
        public int CodigoCampana { get; set; }
        public int Fila { get; set; }
        public string CodigoMGA { get; set; }
        public string NombreMGA { get; set; }
        public string CodigoAgenteVenta { get; set; }
        public string NombreAgenteVenta { get; set; }
        public int Cantidad { get; set; }
        public Decimal Prima { get; set; }
        public Decimal PrimaCobrada { get; set; }
        public Decimal PrimaPendiente { get; set; }
    }
}
