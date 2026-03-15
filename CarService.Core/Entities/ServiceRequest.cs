using CarService.Core.States;
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
    private IServiceRequestState GetState()
    {
        return Status switch
        {
            ServiceStatus.New => new NewState(),
            ServiceStatus.InProgress => new InProgressState(),
            ServiceStatus.Completed => new CompletedState(),
            _ => throw new Exception("Invalid state")
        };
    }
    public void Start()
    {
        var state = GetState();
        state.Start(this);
    }
    public void Complete()
    {
        var state = GetState();
        state.Complete(this);
    }
}