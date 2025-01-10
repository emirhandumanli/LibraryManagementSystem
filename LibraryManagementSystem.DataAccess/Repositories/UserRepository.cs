using LibraryManagementSystem.DataAccess.Context;
using LibraryManagementSystem.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem.DataAccess.Repositories
{
    public class UserRepository : GenericRepository<User>
    {
        public UserRepository(ApplicationDbContext dbContext) : base(dbContext)
        {
        }
    }
}
