using OrderMe.DAL;
using OrderMe.Models;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace OrderMe.Forms
{
    public partial class Login : Form
    {
        /*
         * I'm bringing a list of users before InitializeComponent to initialize EF so the login is not the first query and run quick
         */

        private Repository _repository;
        private List<User> _Users;
        public Login()
        {
            _repository = Repository.GetInstance();
            _Users = _repository.GetUsers();
            InitializeComponent();
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void SignIn_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(UsernameTxtBox.Text) || !string.IsNullOrEmpty(PasswordTxtBox.Text))
            {
                string username = UsernameTxtBox.Text;
                User user = _Users.Where(u => u.Username == username).FirstOrDefault();

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
