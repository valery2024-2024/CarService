using CarService.Core.Entities;

namespace CarService.Core.Interfaces;

public interface IUnitOfWork
{
    IRepository<Client> Clients { get; }
    IRepository<Vehicle> Vehicles { get; }
    IServiceRequestRepository ServiceRequests { get; }

    Task<int> SaveChangesAsync();
}