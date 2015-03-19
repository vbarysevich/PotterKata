using System.Collections.Generic;
using AO.KataPotter.Interfaces.Business;
using AO.KataPotter.Interfaces.Entities;

namespace AO.KataPotter.Implementation.Business.CalculatorStrategy
{
    public abstract class BaseCalculator : ICalculator
    {
        protected const decimal DEFAULT_PRICE = 8m;

        protected Dictionary<int, decimal> DistinctDiscounts = new Dictionary<int, decimal>
        {
            { 2, 5m }, 
            { 3, 10m }, 
            { 4, 15m }, 
            { 5, 25m },
            { 6, 30m }, 
            { 7, 35m }
        };

        public abstract IShoppingCartPrice CalculateCartPrice(IShoppingCart shoppingCart);
    }
}
