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
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MenuBtn_Click(object sender, EventArgs e)
        {
            if (Drawer.Visible)
            {
                tHide.HideSync(Drawer);
            }
            else
                tShow.ShowSync(Drawer);
        }

        private void hideDrawer()
        {

        }

        private void showDrawer()
        {

        }

        
    }
}
