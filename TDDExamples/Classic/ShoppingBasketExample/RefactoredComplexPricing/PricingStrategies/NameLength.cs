namespace TDDExamples.Classic.ShoppingBasketExample.RefactoredComplexPricing.PricingStrategies
{
    public class NameLength : IItemPriceCalculator
    {
        public decimal Calculate(Item item)
        {
            return (item.Product.Price * item.Quantity) + (2 * item.Product.Name.Length);
        }
    }
}