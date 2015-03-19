using AO.KataPotter.Interfaces.Repository;
using NUnit.Framework;
using TechTalk.SpecFlow;

namespace AO.KataPotter.Tests.Repository
{
    [Binding]
    public class RepositoryTestsSteps
    {
        private IRepository _repository;

        [Given(@"Initialise Garry Potter Repository")]
        public void GivenInitialiseGarryPotterRepository()
        {
            
        }

        [When(@"Book count is (.*)")]
        public void WhenBookCountIs(int expectedCount)
        {
            Assert.AreEqual(expectedCount, this._repository.BookCount);
        }

        [When(@"I search book by ""(.*)"" name it returns book")]
        public void WhenISearchBookByNameItReturnsBook(string bookName)
        {
            var book = this._repository.FindBookByName(bookName);
            Assert.IsNotNull(book);
        }

        [When(@"I search book by ""(.*)"" name it returns book with the same name")]
        public void WhenISearchBookByNameItReturnsBookWithTheSameName(string bookName)
        {
            var book = this._repository.FindBookByName(bookName);
            Assert.AreEqual(bookName, book.Name);
        }


        [When(@"I search book by ""(.*)"" name it returns nothing")]
        public void WhenISearchBookByNameItReturnsNothing(string bookName)
        {
            var book = this._repository.FindBookByName(bookName);
            Assert.IsNull(book);
        }
    }
}
