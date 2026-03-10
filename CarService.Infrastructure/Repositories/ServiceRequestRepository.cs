using Microsoft.EntityFrameworkCore;
using CarService.Core.Entities;
using CarService.Core.Interfaces;
using CarService.Infrastructure.Data;

namespace CarService.Infrastructure.Repositories;

public class ServiceRequestRepository 
    : Repository<ServiceRequest>, IServiceRequestRepository
{
    public ServiceRequestRepository(AppDbContext context) : base(context)
    {
    }

    public async Task<List<ServiceRequest>> GetByVehicleIdAsync(int vehicleId)
    {
        return await _context.ServiceRequests
            .Where(x => x.VehicleId == vehicleId)
            .ToListAsync();
    }
}