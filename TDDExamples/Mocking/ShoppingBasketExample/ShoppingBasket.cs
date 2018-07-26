using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace TDDExamples.Mocking.ShoppingBasketExample
{
    public class ShoppingBasket
    {
        private readonly IItemPriceCalculator _itemPriceCalculator;
        private readonly ICollection<Item> _itemsInBasket;

        public ShoppingBasket(IItemPriceCalculator itemPriceCalculator)
        {
            _itemPriceCalculator = itemPriceCalculator;

            _itemsInBasket = new Collection<Item>();
        }

        public void Add(Product product, int quantity)
        {
            _itemsInBasket.Add(new Item(product, quantity));
        }

        public decimal CalculateTotal()
        {
            return _itemsInBasket.Sum(i => _itemPriceCalculator.CalculateCost(i));
        }        
    }
}