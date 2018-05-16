using OrderMe.DAL;
using OrderMe.Models;
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
    public partial class NewOrder : Form
    {
        private List<Product> _products;
        private readonly Repository _repository;
        private readonly OrderMeMenu _form;

        public NewOrder(List<Product> products, Repository repo, OrderMeMenu form)
        {
            _repository = repo;
            _products = products;
            _form = form;
            InitializeComponent();
            DateTxtBox.Text = DateTime.Today.ToString("dd/MM/yyyy");
            loadProductsGrid(_products);
        }

        void loadProductsGrid(List<Product> products)
        {
            foreach (var product in products)
            {
                DataGridViewRow row = (DataGridViewRow)ProductsGrid.Rows[0].Clone();
                row.Cells[0].Value = product.Category.Brand.Name;
                row.Cells[1].Value = product.Category.Name;
                row.Cells[2].Value = product.SKU;
                row.Cells[3].Value = product.ProductName;
                //row.Cells[4].Value = "0";
                
                ProductsGrid.Rows.Add(row);
            }

           
        }

        private void CreateOrderBtn_Click(object sender, EventArgs e)
        {
            int number;

            Order order = new Order {
                Date = DateTime.Today,
                Company = CompanyTxtBox.Text,
                Contact = ContactTxtBox.Text,
                OrderStatus = OrderState.Created
            };

            
            
            foreach (DataGridViewRow row in ProductsGrid.Rows)
            {
                OrderDetail od = new OrderDetail();

                if (row.Cells[2].Value != null)
                {
                    od.Product = _products.Where(p => p.SKU == row.Cells[2].Value).FirstOrDefault();

                    if (row.Cells[4].Value != null && Int32.TryParse(row.Cells[4].Value.ToString(), out number))
                    {
                        od.Quantity = Convert.ToInt32(row.Cells[4].Value.ToString());
                        order.AddDetail(od);
                    }
                    //else
                    //    od.Quantity = 0;
                    //order.AddDetail(od);
                }
            }
            showCreatingMessage();
            _repository.CreateOrder(order);
            _form.UpdateOrdersList();
        }

        private void showCreatingMessage()
        {
            CreatinMsgPanel.Visible = true;
            this.Update();
            Cursor.Current = Cursors.WaitCursor;
            
        }
    }
}
