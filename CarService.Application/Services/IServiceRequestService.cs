using CarService.Core.Entities;

namespace CarService.Application.Services;

public interface IServiceRequestService
{
    Task<List<ServiceRequest>> GetAllAsync();

    Task<ServiceRequest?> GetByIdAsync(int id);

    Task CreateAsync(int vehicleId, string description, decimal basePrice, string pricingStrategy);
    Task UpdateAsync(ServiceRequest request);
}