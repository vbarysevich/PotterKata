using System;
using AO.KataPotter.Implementation.Business;
using AO.KataPotter.Implementation.Business.CalculatorStrategy;
using AO.KataPotter.Interfaces.Business;
using NUnit.Framework;
using TechTalk.SpecFlow;

namespace AO.KataPotter.Tests.Business
{
    [Binding]
    public class ShoppingCartTestsSteps
    {
        private IShoppingCart _shoppingCart;

        [Given(@"I enter the Garry Potter shop")]
        public void GivenIEnterTheGarryPotterShop()
        {
            this._shoppingCart = new ShoppingCart();
        }

        [Given(@"I put (.*) cop(?:y|ies) of ""(.*)"" book")]
        public void GivenIPutCopyOfBook(int quantity, string bookName)
        {
            this._shoppingCart.AddBookByName(bookName, quantity);
        }

        [Then(@"my shoping cart contains (.*) shopping item(?:s|)$")]
        public void ThenMyShopingCartContainsShoppingItem(int expectedCount)
        {
            Assert.AreEqual(expectedCount, this._shoppingCart.BookItems.Count);
            
        }

        /*Use step definition in the same file, so in this case we don't use scenarion context to share data between test classes.*/
        private ICalculator _calculator;

        [Then(@"the total price is (.*)")]
        public void ThenTheTotalPriceIs(decimal expectedPrice)
        {
            var shoppingCartPrice = _calculator.CalculateCartPrice(this._shoppingCart);
            Assert.AreEqual(expectedPrice, shoppingCartPrice.Price);
        }

        [Given(@"The seller uses (.*) calculation method")]
        public void GivenTheSellerUsesLinqCalculationMethod(string calcStrategy)
        {
            switch (calcStrategy)
            {
                case "linq":
                    _calculator = new LinqStrategyCalculator();
                    break;
                case "enum":
                    _calculator = new EnumeratorStrategyCalculator();
                    break;
                default:
                    throw new ArgumentOutOfRangeException(string.Format("The specified <{0}> calculation strategy doesn't exist.", calcStrategy));
            }
        }
    }
}
