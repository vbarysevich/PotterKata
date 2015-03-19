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

        [Given(@"The seller uses linq calculation method")]
        public void GivenTheSellerUsesLinqCalculationMethod()
        {
            _calculator = new LinqStrategyCalculator(); 
            //Note: 20150319 VB Can be added IoC here change strategy on fly.
        }
    }
}
