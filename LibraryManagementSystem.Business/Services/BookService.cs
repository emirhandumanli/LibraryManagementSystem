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
    public class BookService : IService<Book>
    {
        private readonly BookRepository _bookRepository;
        public void Add(Book entity)
        {
            _bookRepository.Add(entity);
        }
        public void Update(Book entity)
        {
            _bookRepository.Update(entity);
        }

        public void Delete(Guid id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Book> GetAll()
        {
            return _bookRepository.GetAll();
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

        public User Login(string email, string password)
        {
            throw new NotImplementedException();
        }

        public void RegisterUser(User user)
        {
            throw new NotImplementedException();
        }

       
    }
}
