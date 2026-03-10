namespace CarService.Application.Strategies;

public class LoyaltyPricingStrategy : IPricingStrategy
{
    public decimal CalculatePrice(decimal basePrice)
    {
        return basePrice * 0.9m;
    }
}