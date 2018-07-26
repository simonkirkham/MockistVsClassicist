using NUnit.Framework;
using TDDExamples.Classic.ShoppingBasketExample;

namespace TDDExamples.UnitTests.Classic
{
    public class ComplexPricingShoppingBasketTests
    {
        [TestCase("Aardvark")]
        [TestCase("Eel")]
        [TestCase("Iguana")]
        [TestCase("Ocelot")]
        [TestCase("Unicorn")]
        public void WhenItemNameBeginsWithVowelVATShouldBeTwentyPercent(string productName)
        {
            //Arrange
            var sut = new ComplexPricingShoppingBasket();
            var item = new Item(new Product(10, productName), 3);

            sut.Add(item);

            //Act
            var result = sut.CalculateTotal();

            //Assert
            Assert.That(result, Is.EqualTo(36m));
        }


        [Test]
        public void WhenItemNameBeginsWithTVATShouldBeFlatRateOfFour()
        {
            //Arrange
            var sut = new ComplexPricingShoppingBasket();
            var item = new Item(new Product(10, "Tree Frog"), 3);

            sut.Add(item);

            //Act
            var result = sut.CalculateTotal();

            //Assert
            Assert.That(result, Is.EqualTo(42m));
        }

        [Test]
        public void WhenTheItemNameHasMoreThan5LettersVATShouldBeTwiceTheLetters()
        {
            //Arrange
            var sut = new ComplexPricingShoppingBasket();
            var item = new Item(new Product(10, "Hippopotomonstrosesquipedaliophobia"), 3);

            sut.Add(item);

            //Act
            var result = sut.CalculateTotal();

            //Assert
            Assert.That(result, Is.EqualTo(100m));
        }


        [Test]
        public void WhenTheItemIsNotCoveredByPreviousPricingRulesVATShuldBeZero()
        {
            //Arrange
            var sut = new ComplexPricingShoppingBasket();
            var item = new Item(new Product(10, "Newt"), 3);

            sut.Add(item);

            //Act
            var result = sut.CalculateTotal();

            //Assert
            Assert.That(result, Is.EqualTo(30m));
        }
    }
}