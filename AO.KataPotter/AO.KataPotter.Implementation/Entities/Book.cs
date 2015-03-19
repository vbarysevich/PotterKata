using AO.KataPotter.Interfaces.Entities;

namespace AO.KataPotter.Implementation.Entities
{
    public class Book : IBook
    {
        public Book() : this(string.Empty)
        {
            
        }
        public Book(string name)
        {
            this.Name = name;
        }

        public string Name { get; set; }
    }
}
