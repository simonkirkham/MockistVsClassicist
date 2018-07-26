namespace TDDExamples.Mocking.ShoppingBasketExample
{
    public class ItemPriceCalculator : IItemPriceCalculator
    {
        private const decimal StandardRateVAT = 17.50m;
        private const decimal HigherRateVAT = 20.00m;

        public decimal CalculateCost(Item item)
        {
            var totalExcludingVAT = item.Product.Price * item.Quantity;

            var vatToUse = StandardRateVAT;

            if (totalExcludingVAT > 100)

            {
                vatToUse = HigherRateVAT;
            }

            return totalExcludingVAT + (totalExcludingVAT*(vatToUse / 100));
        }
    }
}