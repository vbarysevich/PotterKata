using System.Collections.Generic;
using AO.KataPotter.Implementation.Entities;
using AO.KataPotter.Implementation.Repository;
using AO.KataPotter.Interfaces.Business;
using AO.KataPotter.Interfaces.Entities;
using AO.KataPotter.Interfaces.Repository;

namespace AO.KataPotter.Implementation.Business
{
    public class ShoppingCart : IShoppingCart
    {
        readonly IRepository _repository = new GarryPotterRepository();
        private readonly List<IShoppingCartItem> _bookItems = new List<IShoppingCartItem>();

        public List<IShoppingCartItem> BookItems
        {
            get { return _bookItems; }
        }

        public void AddBookByName(string bookName, int quantity)
        {
            var book = this._repository.FindBookByName(bookName);
            _bookItems.Add(new ShoppingCartItem { Book = book, Quantity = quantity });
        }
    }
}
