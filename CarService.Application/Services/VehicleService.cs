using CarService.Core.Entities;
using CarService.Core.Interfaces;

namespace CarService.Application.Services;

public class VehicleService : IVehicleService
{
    private readonly IUnitOfWork _unitOfWork;

    public VehicleService(IUnitOfWork unitOfWork)
    {
        _unitOfWork = unitOfWork;
    }

    public async Task<List<Vehicle>> GetAllAsync()
    {
        return await _unitOfWork.Vehicles.GetAllAsync();
    }

    public async Task CreateAsync(string brand, string model, int year, string vin, int clientId)
    {
        var vehicle = new Vehicle
        {
            Brand = brand,
            Model = model,
            Year = year,
            VIN = vin,
            ClientId = clientId
        };

        await _unitOfWork.Vehicles.AddAsync(vehicle);

        await _unitOfWork.SaveChangesAsync();
    }
}