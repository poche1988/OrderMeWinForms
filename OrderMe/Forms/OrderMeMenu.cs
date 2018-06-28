using OrderMe.DAL;
using OrderMe.Models;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace OrderMe.Forms
{
    public partial class OrderMeMenu : Form
    {
        private Repository _repository;
        private List<Product> _Products;
        private List<Order> _Orders;

        public OrderMeMenu()
        {
            InitializeComponent();
            _repository = Repository.GetInstance();
            _Products = _repository.Getproducts();
            _Orders = _repository.GetOrders();
            OpenFormInContainer(new NewOrder(_Products, _repository,this));
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

        public void OpenFormInContainer(object form)
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

        public void UpdateOrdersList()
        {
            _Orders = _repository.GetOrders();
            OpenFormInContainer(new Orders(_Orders, _repository, this));
        }

        private void NewOrderBtn_Click(object sender, EventArgs e)
        {
            OpenFormInContainer(new NewOrder(_Products, _repository, this));
        }

        private void OrdersBtn_Click(object sender, EventArgs e)
        {
            OpenFormInContainer(new Orders(_Orders, _repository, this));
        }

        private void ProductsBtn_Click(object sender, EventArgs e)
        {
            OpenFormInContainer(new Products(_repository));
        }

        private void DatabaseBtn_Click(object sender, EventArgs e)
        {
            OpenFormInContainer(new Database(_Products, _Orders));
        }

        private void BrandsBtn_Click(object sender, EventArgs e)
        {
            OpenFormInContainer(new Brands(_repository));
        }
    }
}
