using System.Collections.ObjectModel;

namespace TDDExamples.Classic.ShoppingBasketExample.RefactoredComplexPricing
{
    public class ComplexPricingShoppingBasket
    {
        private readonly Collection<Item> _itemsInBasket;

        public ComplexPricingShoppingBasket()
        {
            _itemsInBasket = new Collection<Item>();
        }

        public void Add(Item item)
        {
            _itemsInBasket.Add(item);
        }

        public decimal CalculateTotal()
        {
            var subtotal = 0m;

            foreach (var item in _itemsInBasket)
            {
                var pricingStrategy = ItemPriceStrategyFactory.GetItemPriceCalculator(item);

                subtotal = pricingStrategy.Calculate(item);
            }

            return subtotal;
        }
    }
}