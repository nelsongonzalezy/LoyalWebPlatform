namespace core.Service
{
    public interface IRequestMonitor
    {
        Task<IQueryable<RequestMonitorStatusModel>> GetAllStatus();
        Task<IQueryable<RequestMonitorDetailModel>> GetAlList();
        Task<IQueryable<RequestMonitorDetailModel>> Getbyid(int CodigoSolicitud);
        Task<IQueryable<SolicitudTareasModel>> GetTaskByID(string codigoSolicitud);
    }
}
