using System;
using TechTalk.SpecFlow;

namespace AO.KataPotter.Tests.Repository
{
    [Binding]
    public class RepositoryTestsSteps
    {
        [Given(@"Initialise Garry Potter Repository")]
public void GivenInitialiseGarryPotterRepository()
{
    ScenarioContext.Current.Pending();
}

        [When(@"Book count is (.*)")]
public void WhenBookCountIs(int p0)
{
    ScenarioContext.Current.Pending();
}

        [When(@"I search book by ""(.*)"" name it returns book")]
public void WhenISearchBookByNameItReturnsBook(string p0)
{
    ScenarioContext.Current.Pending();
}

        [When(@"I search book by ""(.*)"" name it returns nothing")]
public void WhenISearchBookByNameItReturnsNothing(string p0)
{
    ScenarioContext.Current.Pending();
}
    }
}
