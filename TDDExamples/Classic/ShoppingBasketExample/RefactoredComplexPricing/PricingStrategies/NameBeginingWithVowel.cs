namespace TDDExamples.Classic.ShoppingBasketExample.RefactoredComplexPricing.PricingStrategies
{
    public class NameWithVowel : IItemPriceCalculator
    {
        public decimal Calculate(Item item)
        {
            return (item.Product.Price * item.Quantity) + ((item.Product.Price * item.Quantity) * 0.2m);
        }

        //public static bool CanHandle(Item item)
        //{
        //    return item.Product.Name.StartsWith("A") ||
        //           item.Product.Name.StartsWith("E") ||
        //           item.Product.Name.StartsWith("I") ||
        //           item.Product.Name.StartsWith("O") ||
        //           item.Product.Name.StartsWith("U");
        //}
    }
}