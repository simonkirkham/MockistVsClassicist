using Moq;
using NUnit.Framework;
using TDDExamples.Mocking.ShoppingBasketExample;

namespace TDDExamples.UnitTests.Mocking.ShoppingBasketExample
{

    public class ShoppingBasketTests
    {
        [Test]
        public void WhenCalculatingTheTotalForNoItems()
        {
            //Arrange
            var mockItemPriceCalculator = new Mock<IItemPriceCalculator>();

            var systemUnderTest = new ShoppingBasket(mockItemPriceCalculator.Object);

            //Act
            var total = systemUnderTest.CalculateTotal();

            //Assert
            Assert.That(total, Is.EqualTo(0.00m));
        }

        [Test]
        public void WhenCalculatingTheTotalForOneItem()
        {
            //Arrange
            var mockItemPriceCalculator = new Mock<IItemPriceCalculator>();

            var systemUnderTest = new ShoppingBasket(mockItemPriceCalculator.Object);

            var apple = new Product(10.0m, "Apple");

            systemUnderTest.Add(apple, 2);            

            mockItemPriceCalculator.Setup(c => c.CalculateCost(It.Is<Item>(i => i.Product == apple && i.Quantity == 2))).Returns(5);
                        
            //Act
            var total = systemUnderTest.CalculateTotal();

            //Assert
            Assert.That(total, Is.EqualTo(5.00m));
        }

        [Test]
        public void WhenCalculatingTheTotalForTwoItems()
        {
            //Arrange
            var mockItemPriceCalculator = new Mock<IItemPriceCalculator>();

            var systemUnderTest = new ShoppingBasket(mockItemPriceCalculator.Object);

            var apple = new Product(10.0m, "Apple");
            var banana = new Product(20.0m, "Banana");

            systemUnderTest.Add(apple, 2);
            systemUnderTest.Add(banana, 1);

            mockItemPriceCalculator.Setup(c => c.CalculateCost(It.Is<Item>(i => i.Product == apple && i.Quantity == 2))).Returns(5);
            mockItemPriceCalculator.Setup(c => c.CalculateCost(It.Is<Item>(i => i.Product == banana && i.Quantity == 1))).Returns(10);

            //Act
            var total = systemUnderTest.CalculateTotal();

            //Assert
            Assert.That(total, Is.EqualTo(15.00m));

            mockItemPriceCalculator.Verify(m => m.CalculateCost(It.IsAny<Item>()));

        }
    }
}