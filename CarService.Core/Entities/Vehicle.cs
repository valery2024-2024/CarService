namespace CarService.Core.Entities;

public class Vehicle
{
    public int Id { get; set; }

    public string Brand { get; set; } = string.Empty;

    public string Model { get; set; } = string.Empty;

    public int Year { get; set; }

    public string VIN { get; set; } = string.Empty;

    public int ClientId { get; set; }

    public Client? Client { get; set; }

    public List<ServiceRequest> ServiceRequests { get; set; } = new();
}