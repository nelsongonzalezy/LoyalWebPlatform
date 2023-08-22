namespace core.Service
{
    public interface IRequestMonitor
    {
        Task<IQueryable<RequestMonitorStatusModel>> GetAllStatus();
        Task<IQueryable<RequestMonitorDetailModel>> GetAlList();
    }
}
