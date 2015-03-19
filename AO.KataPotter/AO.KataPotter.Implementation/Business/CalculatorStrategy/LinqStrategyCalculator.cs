using System.Linq;
using AO.KataPotter.Implementation.Entities;
using AO.KataPotter.Interfaces.Business;
using AO.KataPotter.Interfaces.Entities;

namespace AO.KataPotter.Implementation.Business.CalculatorStrategy
{
    /// <summary>
    /// Implements calculation using linq.
    /// </summary>
    public class LinqStrategyCalculator : BaseCalculator
    {
        public override IShoppingCartPrice CalculateCartPrice(IShoppingCart shoppingCart)
        {
            var seriesCount = shoppingCart.BookItems.GroupBy(p => p.Book).Count();

            var discountRatio = seriesCount * (1 - (DistinctDiscounts.Keys.Contains(seriesCount) ? DistinctDiscounts[seriesCount] : 0) / 100);
            var totalPrice = DEFAULT_PRICE * (discountRatio + (shoppingCart.BookItems.Sum(_ => _.Quantity) - seriesCount));

            return new ShoppingCartPrice(totalPrice, 0);
        }
    }
}