using DesignPatterns.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.RepositoryPattern
{
    public interface IBeerRepository
    {
        IEnumerable<Beer> GetBeers(); 
        Beer GetBeer(int id);
        void InsertBeer(Beer beer);
        void DeleteBeer(int id);
        void UpdateBeer(Beer beer);
        void Save();

    }
}
