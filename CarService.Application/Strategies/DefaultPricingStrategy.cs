namespace CarService.Application.Strategies;

public class DefaultPricingStrategy : IPricingStrategy
{
    public decimal CalculatePrice(decimal basePrice)
    {
        return basePrice;
    }
}