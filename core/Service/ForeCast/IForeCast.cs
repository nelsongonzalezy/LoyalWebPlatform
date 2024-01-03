namespace core.Service
{
    public interface IForeCast
    {
        Task<IQueryable<ForeCastModel>> GetListForeCast();
        Task<DetalleForeCastModel> GetDetailsForeCast(int CodigoPeriodo, string CodigoTipoVenta);
        Task<DetalleForeCastModel> GetForeCastTotal();
        Task<DetalleForeCastModel> GetForeCastTotal(int CodigoPeriodo);
    }
}
