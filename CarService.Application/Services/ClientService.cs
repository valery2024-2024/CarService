using CarService.Core.Entities;
using CarService.Core.Interfaces;

namespace CarService.Application.Services;

public class ClientService : IClientService
{
    private readonly IUnitOfWork _unitOfWork;

    public ClientService(IUnitOfWork unitOfWork)
    {
        _unitOfWork = unitOfWork;
    }

    public async Task<List<Client>> GetAllAsync()
    {
        return await _unitOfWork.Clients.GetAllAsync();
    }

    public async Task CreateAsync(string name, string phone)
    {
        var client = new Client
        {
            Name = name,
            Phone = phone
        };

        await _unitOfWork.Clients.AddAsync(client);

        await _unitOfWork.SaveChangesAsync();
    }
}