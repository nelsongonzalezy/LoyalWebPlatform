namespace core.Service
{
    public interface IForeCast
    {
        Task<IQueryable<ForeCastModel>> GetListForeCast();
        Task<DetalleForeCastModel> GetDetailsForeCast(int CodigoPeriodo, string CodigoTipoVenta);
    }
}
