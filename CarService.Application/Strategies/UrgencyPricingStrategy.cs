namespace CarService.Application.Strategies;

public class UrgencyPricingStrategy : IPricingStrategy
{
    public decimal CalculatePrice(decimal basePrice)
    {
        return basePrice * 1.2m;
    }
}