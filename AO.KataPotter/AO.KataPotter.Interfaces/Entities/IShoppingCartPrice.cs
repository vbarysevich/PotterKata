namespace AO.KataPotter.Interfaces.Entities
{
    /// <summary>
    /// Represents the model when we calculate total price with and without discount. 
    /// </summary>
    public interface IShoppingCartPrice
    {
        decimal Price { get; }
    }
}
