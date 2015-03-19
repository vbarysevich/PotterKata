using AO.KataPotter.Interfaces.Entities;

namespace AO.KataPotter.Implementation.Entities
{
    /// <summary>
    /// Product item in the shopping cart
    /// </summary>
    public class ShoppingCartItem : IShoppingCartItem
    {
        public int Quantity { get; set; }

        public IBook Book { get; set; }
    }
}
