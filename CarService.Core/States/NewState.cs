using CarService.Core.Entities;
using CarService.Core.Enums;

namespace CarService.Core.States;

public class NewState : IServiceRequestState
{
    public void Start(ServiceRequest request)
    {
        request.Status = ServiceStatus.InProgress;
    }

    public void Complete(ServiceRequest request)
    {
        throw new Exception("Cannot complete request that has not started.");
    }
}