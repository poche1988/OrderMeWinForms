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
    }
}
