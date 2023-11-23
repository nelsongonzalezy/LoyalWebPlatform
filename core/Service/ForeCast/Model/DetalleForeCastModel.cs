namespace core.Service
{
    public class DetalleForeCastModel
    {
        public ForeCastModel ForeCast { get; set; }
        public IEnumerable<ForeCastPorProductoModel> ForeCastPorProducto { get; set; }
        public IEnumerable<ForeCastPorPaisModel> ForeCastPorPais { get; set; }
        public IEnumerable<DetallePolizasForeCastModel> DetallePolizasForeCast { get; set; }
    }
    public class ResponseDetalleForeCastModel
    {
        public string Message { get; set; }

        public DetalleForeCastModel Content { get; set; }

        public double ElapsedMilliseconds { get; set; }

        public int? TotalRegistros { get; set; }
        public int? PaginaActual { get; set; }
    }
}
