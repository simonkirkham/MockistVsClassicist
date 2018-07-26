namespace TDDExamples
{
    public class Product
    {
        public Product(decimal price, string name)
        {
            Price = price;
            Name = name;
        }

        public decimal Price { get; }

        public string Name { get; }
    }
}