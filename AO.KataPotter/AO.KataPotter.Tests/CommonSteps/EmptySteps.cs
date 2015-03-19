using TechTalk.SpecFlow;

namespace AO.KataPotter.Tests.CommonSteps
{
    [Binding]
    public class EmptySteps
    {
        [Given(@"Nothing")]
        public void GivenNothing()
        {
            ScenarioContext.Current.Pending();
        }
    }
}
