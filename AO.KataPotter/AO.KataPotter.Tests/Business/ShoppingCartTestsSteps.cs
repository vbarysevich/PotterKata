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
            
        }

        [Given(@"I put (.*) copy of ""(.*)"" book")]
        public void GivenIPutCopyOfBook(int quantity, string bookName)
        {
            this._shoppingCart.AddBookByName(bookName, quantity);
        }

        [Then(@"my shoping cart contains (.*) shopping item")]
        public void ThenMyShopingCartContainsShoppingItem(int expectedCount)
        {
            Assert.AreEqual(expectedCount, this._shoppingCart.BookItems.Count);
            
        }
    }
}
