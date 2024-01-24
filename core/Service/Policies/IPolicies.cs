namespace core.Service
{
    public interface IPolicies
    {
        Task<IQueryable<CertificadosModel>> GetAll();
        Task<IQueryable<CifraCertificadoEstadoModel>> GetAllStatus();
        Task<IQueryable<CifraCertificadoProductoModel>> GetAllProduct();
        Task<IQueryable<CifraCertificadosRenovacionesModel>> GetAllRenewal();
        Task<IQueryable<CertificadosRenovacionModel>> GetFiguresRenewal();
        Task<VwSolcitudConsultaModel> GetByCode(int codigoSolicitud);
        Task<IQueryable<VvCertificadosPorPaisModel>> GetpoliciesForCountry();

        Task<bool> RecodeAgent(RecodeAgentModel model);

    }
}