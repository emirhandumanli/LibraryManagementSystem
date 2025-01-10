using LibraryManagementSystem.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem.Business.Abstractions
{
    public interface IUserService<T> where T : class
    {
        void RegisterUser(User user);
        User Login(string email,string password);
        bool IfEntityExists(Expression<Func<T, bool>> filter);
    }
}
