using CarService.Core.Entities;

namespace CarService.Core.Interfaces;

public interface IServiceRequestRepository : IRepository<ServiceRequest>
{
    Task<List<ServiceRequest>> GetByVehicleIdAsync(int vehicleId);
}