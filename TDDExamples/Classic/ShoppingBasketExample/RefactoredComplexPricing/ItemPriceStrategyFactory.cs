using TDDExamples.Classic.ShoppingBasketExample.RefactoredComplexPricing.PricingStrategies;

namespace TDDExamples.Classic.ShoppingBasketExample.RefactoredComplexPricing
{
    public static class ItemPriceStrategyFactory
    {
        public static IItemPriceCalculator GetItemPriceCalculator(Item item)
        {
            if (item.Product.Name.StartsWith("A") ||
                item.Product.Name.StartsWith("E") ||
                item.Product.Name.StartsWith("I") ||
                item.Product.Name.StartsWith("O") ||
                item.Product.Name.StartsWith("U"))
            {
                return new NameWithVowel();
            }

            if (item.Product.Name.StartsWith("T"))
            {
                return new NameBeginingWithT();
            }

            if (item.Product.Name.Length > 5)
            {
                return new NameLength();
            }

            return new NoVAT();
        }
    }
}