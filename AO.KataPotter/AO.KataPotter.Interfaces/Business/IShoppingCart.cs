using System.Collections.Generic;
using AO.KataPotter.Interfaces.Entities;

namespace AO.KataPotter.Interfaces.Business
{
    public interface IShoppingCart
    {
        List<IShoppingCartItem> BookItems { get; }

        void AddBookByName(string bookName, int quantity);
    }
}
