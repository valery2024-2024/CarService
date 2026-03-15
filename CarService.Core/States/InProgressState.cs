using CarService.Core.Entities;
using CarService.Core.Enums;

namespace CarService.Core.States;

public class InProgressState : IServiceRequestState
{
    public void Start(ServiceRequest request)
    {
        throw new Exception("Request already in progress.");
    }

    public void Complete(ServiceRequest request)
    {
        request.Status = ServiceStatus.Completed;
    }
}