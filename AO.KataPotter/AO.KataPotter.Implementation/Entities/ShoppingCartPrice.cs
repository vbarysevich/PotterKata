using AO.KataPotter.Interfaces.Entities;

namespace AO.KataPotter.Implementation.Entities
{
    public class ShoppingCartPrice : IShoppingCartPrice
    {
        private readonly decimal _price;
        private readonly decimal _priceNoDiscount;

        public ShoppingCartPrice(decimal price, decimal priceNoDiscount)
        {
            this._price = price;
            this._priceNoDiscount = priceNoDiscount;
        }

        public decimal Price
        {
            get { return this._price; }
        }

        public decimal PriceNoDiscount
        {
            get { return this._priceNoDiscount; }
        }
    }
}
