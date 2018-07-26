namespace TDDExamples.Mocking.ShoppingBasketExample
{
    public interface IItemPriceCalculator
    {
        decimal CalculateCost(Item item);
    }
}