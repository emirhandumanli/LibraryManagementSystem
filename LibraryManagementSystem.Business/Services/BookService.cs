using LibraryManagementSystem.Business.Abstractions;
using LibraryManagementSystem.DataAccess.Repositories;
using LibraryManagementSystem.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem.Business.Services
{
    public class BookService : IBookService<Book>
    {
        private readonly BookRepository _bookRepository;
        public void Add(Book entity)
        {
            _bookRepository.Add(entity);
        }

        public void Delete(Guid id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Book> GetAll()
        {
            throw new NotImplementedException();
        }

        public Book GetById(Guid id)
        {
            return _bookRepository.GetByID(id);
            
        }

        public bool IfEntityExists(string title)
        {
            return _bookRepository.IfEntityExists(b => b.Title == title);
        }

        public bool IfEntityExists(Expression<Func<Book, bool>> filter)
        {
            return _bookRepository.IfEntityExists(filter);
        }

        public void Update(Book entity)
        {
            _bookRepository.Update(entity);
        }
    }
}
