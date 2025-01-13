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
    public class UserService : IService<User>
    {
        private readonly UserRepository _userRepository;
        public UserService(UserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public void Add(User entity)
        {
            _userRepository.Add(entity);
        }

        public void Delete(Guid id)
        {
            _userRepository.Delete(id);
        }

        public IEnumerable<User> GetAll()
        {
            return _userRepository.GetAll();
        }

        public User GetById(Guid id)
        {
            return _userRepository.GetByID(id);
        }
        public void Update(User entity)
        {
            _userRepository.Update(entity);
        }

        public bool IfEntityExists(Expression<Func<User, bool>> filter)
        {
            return _userRepository.IfEntityExists(filter);
        }

        public User Login(string email, string password)
        {
            var user = _userRepository.GetAll().FirstOrDefault(u => u.Email == email && u.Password == password);
            if (user == null)
            {
                throw new Exception("Bilgileri yanlış girdiniz.");
            }
            return user;
        }

        public void RegisterUser(User user)
        {
            if (user == null)
            {
                throw new Exception(nameof(user));
            }
            if (_userRepository.IfEntityExists(u => u.Email == user.Email))
            {
                throw new Exception("Kullanıcı zaten mevcut.");
            }
            _userRepository.Add(user);
        }

        
    }
}
