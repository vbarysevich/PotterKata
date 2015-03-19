using AO.KataPotter.Interfaces.Repository;

namespace AO.KataPotter.Implementation.Repository
{
    public class GarryPotterRepository : IRepository
    {
        public Interfaces.Entities.IBook FindBookByName(string name)
        {
            throw new System.NotImplementedException();
        }

        public int BookCount
        {
            get { throw new System.NotImplementedException(); }
        }
    }
}
