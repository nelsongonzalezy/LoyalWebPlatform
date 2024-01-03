namespace core.Service
{
    public class StaffModel
    {
        public IEnumerable<StafPorSexoModel> StafPorSexo { get; set; }
        public IEnumerable<DetalleStaffModel> DetalleStaff { get; set; }
    }
    public class ResponseStaffModel
    {

        public string Message { get; set; }

        public StaffModel Content { get; set; }

        public double ElapsedMilliseconds { get; set; }

        public int? TotalRegistros { get; set; }
        public int? PaginaActual { get; set; }
    }
}
