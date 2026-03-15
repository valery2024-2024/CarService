using CarService.Core.Entities;
using CarService.Core.Enums;
using CarService.Application.Strategies;
using CarService.Core.Interfaces;
using CarService.Application.Factories;



namespace CarService.Application.Services;

public class ServiceRequestService : IServiceRequestService
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly IServiceRequestFactory _factory;

    public ServiceRequestService(
        IUnitOfWork unitOfWork,
        IServiceRequestFactory factory)
    {
        _unitOfWork = unitOfWork;
        _factory = factory;
    }

    public async Task<List<ServiceRequest>> GetAllAsync()
    {
        return await _unitOfWork.ServiceRequests.GetAllAsync();
    }

    public async Task<ServiceRequest?> GetByIdAsync(int id)
    {
        return await _unitOfWork.ServiceRequests.GetByIdAsync(id);
    }

    public async Task CreateAsync(int vehicleId, string description, decimal basePrice, string pricingStrategy)
    {
        IPricingStrategy strategy = pricingStrategy switch
        {
            "Loyalty" => new LoyaltyPricingStrategy(),
            "Urgency" => new UrgencyPricingStrategy(),
            _ => new DefaultPricingStrategy()
        };
        
        var finalPrice = strategy.CalculatePrice(basePrice);
        
        var request = new ServiceRequest
        {
            VehicleId = vehicleId,
            Description = description,
            BasePrice = basePrice,
            FinalPrice = finalPrice,
            CreatedAt = DateTime.Now,
            Status = ServiceStatus.New
        };

        await _unitOfWork.ServiceRequests.AddAsync(request);

        await _unitOfWork.SaveChangesAsync();
    }
    public async Task UpdateAsync(ServiceRequest request)
    {
        _unitOfWork.ServiceRequests.Update(request);
        await _unitOfWork.SaveChangesAsync();
    }
}