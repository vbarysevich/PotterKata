using System.Linq;
using AO.KataPotter.Implementation.Entities;
using AO.KataPotter.Interfaces.Business;
using AO.KataPotter.Interfaces.Entities;

namespace AO.KataPotter.Implementation.Business.CalculatorStrategy
{
    public class LinqStrategyCalculator : BaseCalculator
    {
        public override IShoppingCartPrice CalculateCartPrice(IShoppingCart shoppingCart)
        {
            var bookGroups = shoppingCart.BookItems.GroupBy(p => p.Book).Select(p => p.Count()).ToList();

            var booksForDiscount = bookGroups.Count * (1 - (DistinctDiscounts.Keys.Contains(bookGroups.Count) ? DistinctDiscounts[bookGroups.Count] : 0) / 100);
            var totalPrice = DEFAULT_PRICE * (booksForDiscount + (shoppingCart.BookItems.Sum(_ => _.Quantity) - bookGroups.Count));

            return new ShoppingCartPrice(totalPrice, 0);
        }
    }
}