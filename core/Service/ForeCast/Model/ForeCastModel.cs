namespace core.Service
{
    public class ForeCastModel
    {
        public int CodigoPeriodo { get; set; }
        public string DescripcionPeriodo { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime FechaFin { get; set; }
        public decimal PorcentajeRecargoRenovacion { get; set; }
        public decimal PrimaModerada { get; set; }
        public decimal RenovacionModerada { get; set; }
        public decimal PrimaAgresiva { get; set; }
        public decimal RenovacionAgresiva { get; set; }
        public decimal PrimaModeradaPosPandemia { get; set; }
        public decimal RenovacionModeradaPosPandemia { get; set; }
        public decimal PrimaAgresivaPosPandemia { get; set; }
        public decimal RenovacionAgresivaPosPandemia { get; set; }
        public int PolizaModerada { get; set; }
        public decimal RenovacionPolizaModerada { get; set; }
        public int PolizaAgresiva { get; set; }
        public decimal RenovacionPolizaAgresiva { get; set; }
        public int PolizaModeradaPosPandemia { get; set; }
        public decimal RenovacionPolizaModeradaPosPandemia { get; set; }
        public int PolizaAgresivaPosPandemia { get; set; }
        public decimal RenovacionPolizaAgresivaPosPandemia { get; set; }
        public int VidasModerada { get; set; }
        public decimal RenovacionVidasModerada { get; set; }
        public int VidasAgresiva { get; set; }
        public decimal RenovacionVidasAgresiva { get; set; }
        public int VidasModeradaPosPandemia { get; set; }
        public decimal RenovacionVidasModeradaPosPandemia { get; set; }
        public int VidasAgresivaPosPandemia { get; set; }
        public decimal RenovacionVidasAgresivaPosPandemia { get; set; }
        public decimal Cobrado { get; set; }
        public int Asegurados { get; set; }
        public int Polizas { get; set; }
        public decimal RenovacionCobrado { get; set; }
        public int RenovacionAsegurados { get; set; }
        public int RenovacionPolizas { get; set; }

    }
    public class ResponseForeCastModel
    {
        public string Message { get; set; }

        public List<ForeCastModel> Content { get; set; }

        public double ElapsedMilliseconds { get; set; }

        public int? TotalRegistros { get; set; }
        public int? PaginaActual { get; set; }
    }
}
