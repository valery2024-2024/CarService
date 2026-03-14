using CarService.Core.Entities;

namespace CarService.Application.Services;

public interface IClientService
{
    Task<List<Client>> GetAllAsync();

    Task CreateAsync(string name, string phone);
}