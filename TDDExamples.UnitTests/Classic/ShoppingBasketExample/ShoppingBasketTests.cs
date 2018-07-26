using Moq;
using NUnit.Framework;
using TDDExamples.Classic.ShoppingBasketExample;

namespace TDDExamples.UnitTests.Classic.ShoppingBasketExample
{

    public class ShoppingBasketTests
    {
        [Test]
        public void WhenCalculatingTheTotalForNoItems()
        {
            //Arrange
            var systemUnderTest = new ShoppingBasket();

            //Act
            var total = systemUnderTest.CalculateTotal();

            //Assert
            Assert.That(total, Is.EqualTo(0.00m));
        }

        [Test]
        public void WhenCalculatingTheTotalForOneItem()
        {
            //Arrange
            var systemUnderTest = new ShoppingBasket();

            var apple = new Product(10.0m, "Apple");

            systemUnderTest.Add(apple, 2);

            //Act
            var total = systemUnderTest.CalculateTotal();

            //Assert
            Assert.That(total, Is.EqualTo(23.50m));
        }

        [Test]
        public void WhenCalculatingTheTotalForTwoItems()
        {
            //Arrange
            var systemUnderTest = new ShoppingBasket();

            var apple = new Product(10.0m, "Apple");
            var banana = new Product(20.0m, "Banana");

            systemUnderTest.Add(apple, 2);
            systemUnderTest.Add(banana, 1);
                        
            //Act
            var total = systemUnderTest.CalculateTotal();

            //Assert
            Assert.That(total, Is.EqualTo(47.00m));
        }

        [Test]
        public void WhenCalculatingTheTotalForOneItemOver100HundredPounds()
        {
            //Arrange
            var systemUnderTest = new ShoppingBasket();

            var apple = new Product(10.1m, "Apple");

            systemUnderTest.Add(apple, 10);

            //Act
            var total = systemUnderTest.CalculateTotal();

            //Assert
            Assert.That(total, Is.EqualTo(121.20));
        }

        [Test]
        public void WhenCalculatingTheTotalForTwoItemsOneOverOneUnderA100HundredPounds()
        {
            //Arrange
            var systemUnderTest = new ShoppingBasket();

            var apple = new Product(10.1m, "Apple");
            var banana = new Product(20.0m, "Banana");

            systemUnderTest.Add(apple, 10);
            systemUnderTest.Add(banana, 1);

            //Act
            var total = systemUnderTest.CalculateTotal();

            //Assert
            Assert.That(total, Is.EqualTo(144.70m));
        }
    }
}