using System;
using AO.KataPotter.Interfaces.Business;
using AO.KataPotter.Interfaces.Entities;

namespace AO.KataPotter.Implementation.Business.CalculatorStrategy
{
    public class LinqStrategyCalculator : BaseCalculator
    {
        public override IShoppingCartPrice CalculateCartPrice(IShoppingCart shoppingCart)
        {
            throw new NotImplementedException();
        }
    }
}
