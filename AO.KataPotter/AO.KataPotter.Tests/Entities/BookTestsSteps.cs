using AO.KataPotter.Implementation.Entities;
using AO.KataPotter.Interfaces.Entities;
using NUnit.Framework;
using TechTalk.SpecFlow;

namespace AO.KataPotter.Tests.Entities
{
    [Binding]
    public class BookTestsSteps
    {
        private IBook _book;

        [Given(@"I create a new Book Instance with empty ctor")]
        public void GivenICreateANewBookInstanceWithEmptyCtor()
        {
            _book = new Book();
        }

        [Given(@"I create a new Book Instance with name ""(.*)"" to ctor")]
        public void GivenICreateANewBookInstanceWithNameToCtor(string bookName)
        {
            _book = new Book(bookName);
        }

        [When(@"Book Name property should have ""(.*)"" value")]
        public void WhenBookNamePropertyShouldHaveValue(string expectedBookName)
        {
            Assert.AreEqual(expectedBookName, _book.Name);
        }
    }
}
