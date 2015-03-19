using AO.KataPotter.Interfaces.Entities;

namespace AO.KataPotter.Interfaces.Business
{
    public interface ICalculator
    {
        IShoppingCartPrice CalculateCartPrice(IShoppingCart shoppingCart);
    }
}
