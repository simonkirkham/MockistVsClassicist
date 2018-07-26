using NUnit.Framework;
using TDDExamples.Mocking.ShoppingBasketExample;

namespace TDDExamples.UnitTests.Mocking.ShoppingBasketExample
{
    public class ItemPriceCalculatorTests
    {
        [Test]
        public void WhenTheItemIsLessThan100()
        {
            //Arrange
            var systemUnderTest = new ItemPriceCalculator();
            var apple = new Product(10.0m, "Apple");

            var item = new Item(apple, 2);

            //Act
            var total = systemUnderTest.CalculateCost(item);


            //Assert
            Assert.That(total, Is.EqualTo(23.50m));
        }



        [Test]
        public void WhenTheItemIsMoreThan100()
        {
            //Arrange
            var systemUnderTest = new ItemPriceCalculator();
            var apple = new Product(10.01m, "Apple");

            var item = new Item(apple, 10);

            //Act
            var total = systemUnderTest.CalculateCost(item);

            //Assert
            Assert.That(total, Is.EqualTo(120.12m));
        }
    }
}