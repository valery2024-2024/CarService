using CarService.Core.Enums;

namespace CarService.Core.Entities;

public class ServiceRequest
{
    public int Id { get; set; }

    public string Description { get; set; } = string.Empty;

    public decimal BasePrice { get; set; }

    public decimal FinalPrice { get; set; }

    public DateTime CreatedAt { get; set; }

    public ServiceStatus Status { get; set; }

    public int VehicleId { get; set; }

    public Vehicle? Vehicle { get; set; }
}