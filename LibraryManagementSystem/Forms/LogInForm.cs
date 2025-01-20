using LibraryManagementSystem.Business.Services;
using LibraryManagementSystem.DataAccess.Context;
using LibraryManagementSystem.DataAccess.Repositories;

namespace LibraryManagementSystem.UI.Forms
{
    public partial class LogInForm : Form
    {
        private readonly UserService _userService;
        public LogInForm(UserService userService)
        {
            InitializeComponent();
            var dbContext = new ApplicationDbContext();
            var userRepository = new UserRepository(dbContext);

            _userService = new UserService(userRepository);
        }

        private void lblRegister_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SignInForm signInForm = new SignInForm(_userService);
            signInForm.Show();
            this.Hide();
        }

        private void LogInForm_Load(object sender, EventArgs e)
        {

        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text;
            string password = txtPassword.Text;

            try
            {
                var user = _userService.Login(email, password);

                if (user.Role == "Admin")
                {
                    AdminForm adminForm = new AdminForm();
                    adminForm.Show();
                }
                else
                {
                    UserForm userForm = new UserForm();
                    userForm.Show();
                }
                this.Hide();
            }
            catch (UnauthorizedAccessException ex)
            {
                MessageBox.Show(ex.Message,"Login Failed",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            catch(Exception ex) 
            {
                MessageBox.Show($"An error occured: {ex.Message}","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

    }
}
