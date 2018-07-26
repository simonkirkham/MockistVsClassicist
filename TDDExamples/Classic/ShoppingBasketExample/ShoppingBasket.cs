using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace TDDExamples.Classic.ShoppingBasketExample
{
    public class ShoppingBasket
    {

        private readonly ICollection<Item> _itemsInBasket;

        public ShoppingBasket()
        {
            _itemsInBasket = new Collection<Item>();
        }

        public void Add(Product product, int quantity)
        {
            _itemsInBasket.Add(new Item(product, quantity));
        }

        public decimal CalculateTotal()
        {

            var totalExcludingVAT = 0m;

            for (var i = 0; i < _itemsInBasket.Count; i++)
                totalExcludingVAT += _itemsInBasket.ElementAt(i).Product.Price*_itemsInBasket.ElementAt(i).Quantity
                                     + _itemsInBasket.ElementAt(i).Product.Price*_itemsInBasket.ElementAt(i).Quantity
                                     *(_itemsInBasket.ElementAt(i).Product.Price*_itemsInBasket.ElementAt(i).Quantity
                                       <= 100
                                         ? 17.50m/100
                                         : 20.00m/100);

            return totalExcludingVAT;
        }
    }
}