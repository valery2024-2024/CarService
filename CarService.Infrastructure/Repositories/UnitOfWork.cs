using CarService.Core.Entities;
using CarService.Core.Interfaces;
using CarService.Infrastructure.Data;

namespace CarService.Infrastructure.Repositories;

public class UnitOfWork : IUnitOfWork
{
    private readonly AppDbContext _context;
    public IRepository<Client> Clients { get; }
    public IRepository<Vehicle> Vehicles { get; }

    public IServiceRequestRepository ServiceRequests { get; }

    public UnitOfWork(AppDbContext context)
    {
        _context = context;
        Clients = new Repository<Client>(context);
        Vehicles = new Repository<Vehicle>(context);
        ServiceRequests = new ServiceRequestRepository(context);
    }

    public async Task<int> SaveChangesAsync()
    {
        return await _context.SaveChangesAsync();
    }
}