using CarService.Core.Interfaces;
using CarService.Infrastructure.Data;

namespace CarService.Infrastructure.Repositories;

public class UnitOfWork : IUnitOfWork
{
    private readonly AppDbContext _context;

    public IServiceRequestRepository ServiceRequests { get; }

    public UnitOfWork(AppDbContext context)
    {
        _context = context;
        ServiceRequests = new ServiceRequestRepository(context);
    }

    public async Task<int> SaveChangesAsync()
    {
        return await _context.SaveChangesAsync();
    }
}