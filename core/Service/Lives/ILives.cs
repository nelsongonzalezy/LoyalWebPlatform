namespace core.Service
{
    public interface ILives 
    {
        Task<IQueryable<VidasResponseModel>> GetAllLife();
        Task<IQueryable<CifrasPersonasCertificadoResponseModel>> GetAllCountLife(); 
    }
}
