using CarService.Core.Interfaces;

namespace CarService.Core.Interfaces;

public interface IUnitOfWork
{
    IServiceRequestRepository ServiceRequests { get; }

    Task<int> SaveChangesAsync();
}