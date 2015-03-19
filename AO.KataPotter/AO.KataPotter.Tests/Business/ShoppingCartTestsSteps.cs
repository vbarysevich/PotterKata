using TechTalk.SpecFlow;

namespace AO.KataPotter.Tests.Business
{
    [Binding]
    public class ShoppingCartTestsSteps
    {
        [Given(@"I enter the Garry Potter shop")]
        public void GivenIEnterTheGarryPotterShop()
        {
            ScenarioContext.Current.Pending();
        }

        [Given(@"I put (.*) copy of ""(.*)"" book")]
        public void GivenIPutCopyOfBook(int p0, string p1)
        {
            ScenarioContext.Current.Pending();
        }

        [Then(@"my shoping cart contains (.*) shopping item")]
        public void ThenMyShopingCartContainsShoppingItem(int p0)
        {
            ScenarioContext.Current.Pending();
        }
    }
}
