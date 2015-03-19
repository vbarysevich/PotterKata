using AO.KataPotter.Interfaces.Entities;

namespace AO.KataPotter.Implementation.Entities
{
    public class ShoppingCartItem : IShoppingCartItem
    {
        public int Quantity { get; set; }

        public IBook Book { get; set; }
    }
}
