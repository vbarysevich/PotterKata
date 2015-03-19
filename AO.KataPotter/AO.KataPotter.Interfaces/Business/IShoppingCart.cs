using System.Collections.Generic;
using AO.KataPotter.Interfaces.Entities;

namespace AO.KataPotter.Interfaces.Business
{
    public interface IShoppingCart
    {
        List<IShoppingCartItem> BookItems { get; }

        /// <summary>
        /// Adds book to the shopping cart items. Should not accept not positive quantities.
        /// </summary>
        /// <param name="bookName"></param>
        /// <param name="quantity"></param>
        void AddBookByName(string bookName, int quantity);
    }
}
