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

        public override bool Equals(object obj)
        {
            if (obj == this)
            {
                return true;
            }
            var item = obj as ShoppingCartItem;
            if (item != null)
            {
                return this.Book.Name.Equals(item.Book.Name);
            }
            return false;
        }

        public override int GetHashCode()
        {
            return this.Book.Name.GetHashCode();
        }
    }
}
