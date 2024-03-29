﻿namespace core.Service
{
    public interface ICampanig
    {
        Task<CampanaModel> GetCampana(CampanaRequestModel model);
        Task<IQueryable<CampanasModel>> GetListCampana();
        Task<bool> CreateCampana(CreateCampaignModel model);
    }
}
