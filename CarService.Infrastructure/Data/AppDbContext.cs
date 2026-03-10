using Microsoft.EntityFrameworkCore;
using CarService.Core.Entities;

namespace CarService.Infrastructure.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options)
        : base(options)
    {
    }

    public DbSet<Client> Clients { get; set; }

    public DbSet<Vehicle> Vehicles { get; set; }

    public DbSet<ServiceRequest> ServiceRequests { get; set; }
}