using AO.KataPotter.Interfaces.Entities;

namespace AO.KataPotter.Interfaces.Repository
{
    /// <summary>
    /// Represent the series book data 
    /// </summary>
    public interface IRepository
    {
        IBook FindBookByName(string name);

        int BookCount { get; }
    }
}
