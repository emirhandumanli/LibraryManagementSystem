using LibraryManagementSystem.Business.Services;
using LibraryManagementSystem.DataAccess.Context;
using LibraryManagementSystem.DataAccess.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryManagementSystem.UI.Forms
{
    public partial class UserForm : Form
    {
        private readonly UserService _userService;
        private readonly BookService _bookService;
        public UserForm()
        {
            InitializeComponent();
            var dbContext = new ApplicationDbContext();
            var userRepository = new UserRepository(dbContext);
            var bookRepository = new BookRepository(dbContext);


            _userService = new UserService(userRepository);
            _bookService = new BookService(bookRepository);
        }

        private void UserForm_Load(object sender, EventArgs e)
        {
            
        }

    }
}
