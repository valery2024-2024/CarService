using CarService.Core.Entities;

namespace CarService.Core.Interfaces;

public interface IUnitOfWork
{
    IRepository<Client> Clients { get; }
    IServiceRequestRepository ServiceRequests { get; }

    Task<int> SaveChangesAsync();
}