namespace core.Service
{
    public class VentasPorAnioModel
    {
        public int Anio { get; set; }
        public List<VentaModel> Ventas { get; set; }
    }

    public class VentaModel
    {
        public int Mes { get; set; }
        public decimal Total { get; set; }
    }
}
