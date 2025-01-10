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
    public class UserService : IUserService<User>
    {
        private readonly UserRepository _userRepository;
        public UserService(UserRepository userRepository)
        {
            _userRepository = userRepository;
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
            if (_userRepository.IfEntityExists(u => u.Name == user.Name))
            {
                throw new Exception("Kullanıcı zaten mevcut.");
            }
            _userRepository.Add(user);
        }
    }
}
