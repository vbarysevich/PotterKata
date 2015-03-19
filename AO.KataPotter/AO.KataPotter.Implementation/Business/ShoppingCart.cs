using System;
using System.Collections.Generic;
using AO.KataPotter.Interfaces.Business;
using AO.KataPotter.Interfaces.Entities;

namespace AO.KataPotter.Implementation.Business
{
    public class ShoppingCart : IShoppingCart
    {
        public List<IShoppingCartItem> BookItems
        {
            get { throw new NotImplementedException(); }
        }

        public void AddBookByName(string bookName, int quantity)
        {
            throw new NotImplementedException();
        }
    }
}
