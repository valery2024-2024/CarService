using Microsoft.EntityFrameworkCore;
using CarService.Core.Entities;
using CarService.Core.Interfaces;
using CarService.Infrastructure.Data;

namespace CarService.Infrastructure.Repositories;

public class ClientRepository : Repository<Client>
{
    public ClientRepository(AppDbContext context) : base(context)
    {
    }
}