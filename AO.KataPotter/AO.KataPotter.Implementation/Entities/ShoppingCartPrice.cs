using AO.KataPotter.Interfaces.Entities;

namespace AO.KataPotter.Implementation.Entities
{
    public class ShoppingCartPrice : IShoppingCartPrice
    {
        private readonly decimal _price;

        public ShoppingCartPrice(decimal price)
        {
            this._price = price;
        }

        public decimal Price
        {
            get { return this._price; }
        }
    }
}
