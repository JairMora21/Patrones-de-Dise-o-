using DesignPatterns.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.RepositoryPattern
{
    public class BeerRepository : IBeerRepository
    {
        //Agregar el contexto
        private readonly DesingPatternsContext _context;
        //Agregar el constructor con el contextoS
        public BeerRepository(DesingPatternsContext context)
        {
            _context = context;
        }

        public void InsertBeer(Beer beer) => _context.Beers.Add(beer);
        public void DeleteBeer(int id) => _context.Beers.Remove(GetBeer(id));
        public Beer GetBeer(int id) => _context.Beers.Find(id);
        public IEnumerable<Beer> GetBeers() => _context.Beers.ToList();
        public void UpdateBeer(Beer beer) => _context.Beers.Update(beer);
        public void Save() => _context.SaveChanges();



    }
}
