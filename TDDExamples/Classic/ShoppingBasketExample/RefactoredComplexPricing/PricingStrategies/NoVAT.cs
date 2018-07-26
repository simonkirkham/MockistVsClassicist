namespace TDDExamples.Classic.ShoppingBasketExample.RefactoredComplexPricing.PricingStrategies
{
    public class NoVAT : IItemPriceCalculator
    {
        public decimal Calculate(Item item)
        {
            return (item.Product.Price * item.Quantity);
        }
    }
}