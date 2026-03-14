using CarService.Core.Entities;

namespace CarService.Application.Services;

public interface IVehicleService
{
    Task<List<Vehicle>> GetAllAsync();

    Task CreateAsync(string brand, string model, int year, string vin, int clientId);
}