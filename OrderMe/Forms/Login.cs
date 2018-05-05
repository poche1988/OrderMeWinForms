using OrderMe.DAL;
using System;
using System.Windows.Forms;

namespace OrderMe.Forms
{
    public partial class Login : Form
    {
        private Repository _repository;
        public Login()
        {
            _repository = Repository.GetInstance();
            InitializeComponent();
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
                        ShowErrorMsg("Wrong password");
                    }
                }
                else
                {
                    ShowErrorMsg("Wrong username");
                }
            }
            else
            {
                ShowErrorMsg("Both fields are required");
            }

        }

        private void ShowErrorMsg(string error)
        {
            ErrorTxt.Text = error;
        }
    }
}
