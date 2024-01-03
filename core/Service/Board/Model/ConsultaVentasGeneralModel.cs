namespace core.Service
{
    public class ConsultaVentasGeneralModel
    {
        public IEnumerable<VentasTotalesModel>? VentasTotales { get; set; }
        public IEnumerable<VentasTotalesNuevosNegociosModel>? NuevosNegocios { get; set; }
        public IEnumerable<VentasTotalesRenovacionesModel>? Renovaciones { get; set; }


    }
    public class ConsultaVentasGeneralResponse
    {
        public string Message { get; set; }

        public ConsultaVentasGeneralModel Content { get; set; }

        public double ElapsedMilliseconds { get; set; }

        public int? TotalRegistros { get; set; }
        public int? PaginaActual { get; set; }
    }
}
