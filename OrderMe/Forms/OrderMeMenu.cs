using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OrderMe.Forms
{
    public partial class OrderMeMenu : Form
    {
        public OrderMeMenu()
        {
            InitializeComponent();
            OpenFormInContainer(new NewOrder());
        }

        private void CloseBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MenuBtn_Click(object sender, EventArgs e)
        {
            if (sideMenu.Width == 50)
            {
                sideMenu.Visible = false;
                sideMenu.Width = 200;
                tShow.ShowSync(sideMenu);
            }
            else
            {
                sideMenu.Visible = false;
                sideMenu.Width = 50;
                tShow.ShowSync(sideMenu);
            }
        }

        private void OpenFormInContainer(object form)
        {
            if (this.FormContainer.Controls.Count > 0)
                this.FormContainer.Controls.RemoveAt(0);

            Form f = form as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.FormContainer.Controls.Add(f);
            this.FormContainer.Tag = f;
            f.Show();

        }

        private void NewOrderBtn_Click(object sender, EventArgs e)
        {
            OpenFormInContainer(new NewOrder());
        }

        private void OrdersBtn_Click(object sender, EventArgs e)
        {
            OpenFormInContainer(new Orders());
        }

        private void ProductsBtn_Click(object sender, EventArgs e)
        {
            OpenFormInContainer(new Products());
        }
    }
}
