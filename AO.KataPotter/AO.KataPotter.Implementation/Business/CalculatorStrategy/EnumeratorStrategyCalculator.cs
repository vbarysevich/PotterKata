using System.Collections.Generic;
using AO.KataPotter.Implementation.Entities;
using AO.KataPotter.Interfaces.Business;
using AO.KataPotter.Interfaces.Entities;

namespace AO.KataPotter.Implementation.Business.CalculatorStrategy
{
    /// <summary>
    /// Implements calculation without linq.
    /// </summary>
    public class EnumeratorStrategyCalculator : BaseCalculator
    {
        public override IShoppingCartPrice CalculateCartPrice(IShoppingCart shoppingCart)
        {
            var distinctItems = new List<IShoppingCartItem>();
            foreach (var bookItem in shoppingCart.BookItems)
            {
                if (distinctItems.IndexOf(bookItem) < 0)
                {
                    distinctItems.Add(bookItem);
                }
                else
                {
                    distinctItems[distinctItems.IndexOf(bookItem)].Quantity += bookItem.Quantity;
                }
            }

            decimal total = 0m;
            var ratio = DistinctDiscounts.ContainsKey(distinctItems.Count) ? DistinctDiscounts[distinctItems.Count] : 0;
            foreach (var bookItem in distinctItems)
            {
                total += ratio*DEFAULT_PRICE + (bookItem.Quantity + (ratio > 0 ? - 1 : 0))*DEFAULT_PRICE;
            }

            return new ShoppingCartPrice(total, 0);

        }
    }
}
