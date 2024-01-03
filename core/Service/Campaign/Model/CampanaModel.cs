namespace core.Service
{
    public class CampanaModel
    {
        public IEnumerable<VwCampanaModel> Campanas { get; set; }
        public IEnumerable<VwCampanaDetalleAgentModel> CampanasAgentes { get; set; }
        public IEnumerable<VwCampanaEstadosModel> CampanasEstados { get; set; }
        public IEnumerable<VwCampanaProductosModel> CampanasProductos { get; set; }
        public DtCampanaModel DtCampanas { get; set; }
        public IEnumerable<DtDetalleCampanasModel> DtDetalleCampanas { get; set; }
        public IEnumerable<VwCampanaDetalleMgaModel> CampanasMga { get; set; }
        public IEnumerable<VwCampanaDetalleAgenciaModel> CampanasAgencia { get; set; }

        public string? mensaje { get; set; }
    }   
    public class ResponseCampanaModel
    {
        public string Message { get; set; }

        public CampanaModel Content { get; set; }

        public double ElapsedMilliseconds { get; set; }

        public int? TotalRegistros { get; set; }
        public int? PaginaActual { get; set; }
        
    }

}
