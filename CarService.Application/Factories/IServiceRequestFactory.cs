using CarService.Core.Entities;

namespace CarService.Application.Factories;

public interface IServiceRequestFactory
{
    ServiceRequest Create(int vehicleId, string description, decimal basePrice);
}