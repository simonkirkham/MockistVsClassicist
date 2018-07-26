namespace TDDExamples
{
    public class Item
    {
        public Item(Product product, int quantity)
        {
            Quantity = quantity;
            Product = product;
        }

        public int Quantity { get; }

        public Product Product { get; }
    }
}