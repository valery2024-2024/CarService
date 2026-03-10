using CarService.Core.Entities;
using CarService.Core.Enums;
using CarService.Application.Strategies;

namespace CarService.Application.Factories;

public class ServiceRequestFactory : IServiceRequestFactory
{
    private readonly IPricingStrategy _pricingStrategy;

    public ServiceRequestFactory(IPricingStrategy pricingStrategy)
    {
        _pricingStrategy = pricingStrategy;
    }

    public ServiceRequest Create(int vehicleId, string description, decimal basePrice)
    {
        var finalPrice = _pricingStrategy.CalculatePrice(basePrice);

        return new ServiceRequest
        {
            VehicleId = vehicleId,
            Description = description,
            BasePrice = basePrice,
            FinalPrice = finalPrice,
            CreatedAt = DateTime.UtcNow,
            Status = ServiceStatus.New
        };
    }
}