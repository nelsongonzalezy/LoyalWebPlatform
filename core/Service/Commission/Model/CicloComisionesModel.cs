namespace core.Service
{

    public class CicloComisionesModel
    {
        public IEnumerable<VwCicloComisionesModel> CicloComisiones { get; set; }
        public IEnumerable<VwCicloComisionesAgenteModel> CicloComisionesAgente { get; set; }
        public IEnumerable<VwDetalleCicloComisionesAgenteModel> DetalleCicloComisionesAgente { get; set; }
    }
    public class ResponseCicloComisionesModel
    {
        public string Message { get; set; }

        public CicloComisionesModel Content { get; set; }

        public double ElapsedMilliseconds { get; set; }

        public int? TotalRegistros { get; set; }
        public int? PaginaActual { get; set; }
    }


}
