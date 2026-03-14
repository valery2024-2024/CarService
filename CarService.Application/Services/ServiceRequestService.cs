using CarService.Core.Entities;
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

    public async Task CreateAsync(int vehicleId, string description, decimal basePrice)
    {
        var request = _factory.Create(vehicleId, description, basePrice);

        await _unitOfWork.ServiceRequests.AddAsync(request);

        await _unitOfWork.SaveChangesAsync();
    }
    public async Task UpdateAsync(ServiceRequest request)
    {
        _unitOfWork.ServiceRequests.Update(request);
        _unitOfWork.ServiceRequests.Update(request);
    }
}