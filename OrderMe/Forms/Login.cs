using OrderMe.DAL;
using System;
using System.Linq;
using System.Windows.Forms;

namespace OrderMe.Forms
{
    public partial class Login : Form
    {
        private Repository _repository;
        public Login()
        {
            InitializeComponent();
            _repository = Repository.GetInstance();
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void SignInBtn_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(UsernameTxtBox.Text) || !string.IsNullOrEmpty(PasswordTxtBox.Text))
            {
                string username = UsernameTxtBox.Text;

                var user = _repository.GetUserByUsername(username);

                if (user != null)
                {
                    if (user.Password == PasswordTxtBox.Text)
                    {
                        MainMenu mm = new MainMenu();
                        this.Hide();
                        mm.Show();

                    }
                    else
                    {
                        //error wrong pass
                    }
                }
                else
                {
                    //error wrong username
                }
            }
            else
            {
                // error complete both fieldsss
            }

        }
    }
}
