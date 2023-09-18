namespace core.Service
{
    public interface ICampanig
    {
        Task<CampanaModel> GetCampana(CampanaRequestModel model);
    }
}
