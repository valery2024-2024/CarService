namespace CarService.Application.Strategies;

public interface IPricingStrategy
{
    decimal CalculatePrice(decimal basePrice);
}