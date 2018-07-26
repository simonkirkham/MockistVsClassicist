namespace TDDExamples.Classic.ShoppingBasketExample.RefactoredComplexPricing.PricingStrategies
{
    public interface IItemPriceCalculator
    {
        decimal Calculate(Item item);
    }
}