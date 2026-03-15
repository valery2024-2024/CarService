using CarService.Core.Entities;
using CarService.Core.Enums;

namespace CarService.Core.States;

public class CompletedState : IServiceRequestState
{
    public void Start(ServiceRequest request)
    {
        throw new Exception("Completed request cannot be started.");
    }

    public void Complete(ServiceRequest request)
    {
        throw new Exception("Request already completed.");
    }
}