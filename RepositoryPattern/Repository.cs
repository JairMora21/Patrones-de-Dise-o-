using DesignPatterns.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.RepositoryPattern
{
    //En el where le decimos que TEnity tiene que ser una clase, una interfaz, delegado o arreglo
    internal class Repository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        private readonly DesingPatternsContext _context;
        private DbSet<TEntity> _dbSet;
        public Repository(DesingPatternsContext context)
        {
            _context = context;
            _dbSet = context.Set<TEntity>();
        }
        public void Delete(int id) => _dbSet.Remove(GetById(id));

        public IEnumerable<TEntity> GetAll() => _dbSet.ToList();

        public TEntity GetById(int id) => _dbSet.Find(id);

        public void Insert(TEntity entity) => _dbSet.Add(entity);

        public void Save() => _context.SaveChanges();

        public void Update(TEntity entity)
        {
            _dbSet.Attach(entity);
            _context.Entry(entity).State = EntityState.Modified;
        }
    }
}
