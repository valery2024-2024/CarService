using CarService.Core.Entities;

namespace CarService.Core.States;

public interface IServiceRequestState
{
    void Start(ServiceRequest request);

    void Complete(ServiceRequest request);
}