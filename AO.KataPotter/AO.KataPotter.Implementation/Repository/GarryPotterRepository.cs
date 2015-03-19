using System;
using System.Collections.Generic;
using System.Linq;
using AO.KataPotter.Implementation.Entities;
using AO.KataPotter.Interfaces.Entities;
using AO.KataPotter.Interfaces.Repository;
using This = AO.KataPotter.Implementation.Repository.GarryPotterRepository;

namespace AO.KataPotter.Implementation.Repository
{
    public class GarryPotterRepository : IRepository
    {
        private static readonly List<IBook> Series = new List<IBook>
        {
            new Book{Name = "#1"}, 
            new Book{Name = "#2"},
            new Book{Name = "#3"},
            new Book{Name = "#4"},
            new Book{Name = "#5"},
            new Book{Name = "#6"},
            new Book{Name = "#7"}
        };

        public IBook FindBookByName(string name)
        {
            return This.Series.FirstOrDefault(z => z.Name.Equals(name, StringComparison.OrdinalIgnoreCase));
        }

        public int BookCount
        {
            get { return This.Series.Count; }
        }
    }
}
