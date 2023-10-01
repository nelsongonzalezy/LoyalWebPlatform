namespace core.Service
{
    public interface ILives 
    {
        Task<VidasResponseModel> GetAllLife();
        Task<IQueryable<CifrasPersonasCertificadoResponseModel>> GetAllCountLife(); 
    }
}
