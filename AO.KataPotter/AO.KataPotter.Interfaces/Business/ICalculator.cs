using AO.KataPotter.Interfaces.Entities;

namespace AO.KataPotter.Interfaces.Business
{
    public interface ICalculator
    {
        /// <summary>
        /// Represents the logic to get actual price for the shopping cart.
        /// </summary>
        /// <param name="shoppingCart"></param>
        /// <returns></returns>
        IShoppingCartPrice CalculateCartPrice(IShoppingCart shoppingCart);
    }
}
