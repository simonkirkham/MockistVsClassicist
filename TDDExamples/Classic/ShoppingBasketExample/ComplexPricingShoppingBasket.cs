using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDDExamples.Classic.ShoppingBasketExample
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
                if (item.Product.Name.StartsWith("A") ||
                    item.Product.Name.StartsWith("E") ||
                    item.Product.Name.StartsWith("I") ||
                    item.Product.Name.StartsWith("O") ||
                    item.Product.Name.StartsWith("U"))
                {
                    subtotal += (item.Product.Price*item.Quantity) + ((item.Product.Price*item.Quantity)*0.2m);
                }
                else if (item.Product.Name.StartsWith("T"))
                {
                    subtotal += (item.Product.Price * item.Quantity) + (4 * item.Quantity);
                }
                else if (item.Product.Name.Length > 5)
                {
                    subtotal += (item.Product.Price * item.Quantity) + (2 * item.Product.Name.Length);
                }
                else
                {
                    subtotal += (item.Product.Price * item.Quantity);
                }
            }

            return subtotal;
        }
    }
}
