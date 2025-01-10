using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem.Business.Abstractions
{
    public interface IBookService<T> where T : class
    {
        IEnumerable<T> GetAll();
        void Add(T entity);
        void Update(T entity);
        void Delete(Guid id);
        T GetById(Guid id);
        bool IfEntityExists(Expression<Func<T, bool>> filter);
    }
}
