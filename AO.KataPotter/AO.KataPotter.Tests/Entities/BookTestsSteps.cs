using TechTalk.SpecFlow;

namespace AO.KataPotter.Tests.Entities
{
    [Binding]
    public class BookTestsSteps
    {
        [Given(@"I create a new Book Instance with empty ctor")]
        public void GivenICreateANewBookInstanceWithEmptyCtor()
        {
            ScenarioContext.Current.Pending();
        }

        [Given(@"I create a new Book Instance with name ""(.*)"" to ctor")]
        public void GivenICreateANewBookInstanceWithNameToCtor(string bookName)
        {
            ScenarioContext.Current.Pending();
        }

        [When(@"Book Name property should have ""(.*)"" value")]
        public void WhenBookNamePropertyShouldHaveValue(string bookName)
        {
            ScenarioContext.Current.Pending();
        }
    }
}
