using CarService.Core.Entities;
using CarService.Infrastructure.Data;

namespace CarService.Infrastructure.Repositories;

public class VehicleRepository : Repository<Vehicle>
{
    public VehicleRepository(AppDbContext context) : base(context)
    {
    }
}