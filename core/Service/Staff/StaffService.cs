namespace core.Service
{
    public class StaffService  :IStaff
    {
        private readonly IHttpServicesUnAuthorized _unAuthorized;

        public StaffService(IHttpServicesUnAuthorized unAuthorized)
        {
            _unAuthorized = unAuthorized;
        }
        public async Task<StaffModel> GetDetailsStaff()
        {
            var y = await _unAuthorized.GetUnAuthorizedAsync<ResponseStaffModel>("api/v1/Personal/ObtenerDetallePersonal");

            return y.Content;
        }
    }
}
