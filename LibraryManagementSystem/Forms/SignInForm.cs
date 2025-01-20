using LibraryManagementSystem.Business.Services;
using LibraryManagementSystem.DataAccess.Context;
using LibraryManagementSystem.DataAccess.Repositories;
using LibraryManagementSystem.Entities.Models;

namespace LibraryManagementSystem.UI.Forms
{
    public partial class SignInForm : Form
    {
        private readonly UserService _userService;
        public SignInForm()
        {
            InitializeComponent();
            var dbContext = new ApplicationDbContext();
            var userRepository = new UserRepository(dbContext);

            _userService = new UserService(userRepository);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string firstName = txtName.Text;
            string lastName = txtLastName.Text;
            string email = txtEmail.Text;
            string password = txtPassword.Text;

            if (string.IsNullOrWhiteSpace(firstName) || string.IsNullOrWhiteSpace(lastName) ||
                string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Please fill in all the fields.","Validation Error",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                return;
            }

            var newUser = new User
            {
                Email = email,
                Password = password,
                Role = "User" 
            };

            try
            {
                _userService.RegisterUser(newUser);
                MessageBox.Show("Registration Successfull! You can now log in.","Success",MessageBoxButtons.OK,MessageBoxIcon.Information);

                LogInForm loginForm = new LogInForm();
                loginForm.Show();
                this.Close();
            }
            catch (InvalidOperationException ex)
            {
                MessageBox.Show(ex.Message,"Registration Failed",MessageBoxButtons.OK,MessageBoxIcon.Error);
                
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occured: {ex.Message}","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }
    }
}
