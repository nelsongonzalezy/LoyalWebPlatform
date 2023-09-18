namespace core.Service
{
    public class CampaignService : ICampanig
    {
        private readonly IHttpServicesUnAuthorized _unAuthorized;
        public CampaignService(IHttpServicesUnAuthorized unAuthorized) 
        {
            _unAuthorized = unAuthorized;
        }
        public async Task<CampanaModel> GetCampana(CampanaRequestModel model)
        {
            var y = await _unAuthorized.PostUnAuthorizedAsync<CampanaRequestModel,ResponseCampanaModel>("api/v1/Campana", model);

            return y.Content;
        }
    }
}
