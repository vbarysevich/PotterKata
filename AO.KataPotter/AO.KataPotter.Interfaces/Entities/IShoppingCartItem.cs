namespace AO.KataPotter.Interfaces.Entities
{
    /// <summary>
    /// Represents item in the shopping cart
    /// </summary>
    public interface IShoppingCartItem
    {
        int Quantity { get; set; }

        IBook Book { get; set; }
    }
}
