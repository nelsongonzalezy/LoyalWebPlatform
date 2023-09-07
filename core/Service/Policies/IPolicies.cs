namespace core.Service
{
    public interface IPolicies
    {
        Task<IQueryable<CertificadosModel>> GetAll();
        Task<IQueryable<CifraCertificadoEstadoModel>> GetAllStatus();
        Task<IQueryable<CifraCertificadoProductoModel>> GetAllProduct();
        Task<IQueryable<CifraCertificadosRenovacionesModel>> GetAllRenewal();
        Task<IQueryable<CertificadosRenovacionModel>> GetFiguresRenewal();
        
    }
}
