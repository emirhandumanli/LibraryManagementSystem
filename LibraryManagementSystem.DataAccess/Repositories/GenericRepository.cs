using LibraryManagementSystem.DataAccess.Abstractions;
using LibraryManagementSystem.DataAccess.Context;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace LibraryManagementSystem.DataAccess.Repositories
{
    public class GenericRepository<T> : IRepository<T> where T : class
    {
        private readonly ApplicationDbContext _context;
        private readonly DbSet<T> _dbSet;
        public GenericRepository(ApplicationDbContext dbContext)
        {
            _context = dbContext;
            _dbSet = _context.Set<T>();
        }
        public void Add(T entity)
        {
            _context.Add(entity);
            _context.SaveChanges();
            
        }

        public void Delete(Guid id)
        {
            _dbSet.Remove(GetByID(id));
            _context.SaveChanges();
        }

        public IEnumerable<T> GetAll()
        {
            return _dbSet.ToList();
        }

        public T GetByID(Guid id)
        {
            var entity = _dbSet.Find(id);
            if (entity == null)
            {
                throw new Exception("Hata.");
            }
            return entity;
        }

        public bool IfEntityExists(Expression<Func<T, bool>> filter)
        {
            return _dbSet.Any(filter);    
        }

        public void Update(T entity)
        {
            _context.SaveChanges();
        }
    }
}
