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
        public async Task<IQueryable<CampanasModel>> GetListCampana()
        {
            var y = await _unAuthorized.GetUnAuthorizedAsync<ResponseCampanaListModel>("api/v1/Campana/ListadeCampanas?CodigoCamapana=0");

            return y.Content.AsQueryable();
        }
        public async Task<bool> CreateCampana(CreateCampaignModel model)
        {
            var y = await _unAuthorized.PostUnAuthorizedAsync<CreateCampaignModel, bool>("api/v1/Campana/Crear", model);

            return y;
        }
    }
}
