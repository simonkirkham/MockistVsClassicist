namespace TDDExamples.Classic.ShoppingBasketExample.RefactoredComplexPricing.PricingStrategies
{
    public class NameBeginingWithT : IItemPriceCalculator
    {
        public decimal Calculate(Item item)
        {
            return (item.Product.Price * item.Quantity) + (4 * item.Quantity);
        }
    }
}