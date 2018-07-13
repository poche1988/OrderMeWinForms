using OrderMe.DAL;
using OrderMe.Models;
using OrderMe.Services;
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
        private List<Supplier> _Suppliers;
        private readonly Repository _repository;
        private readonly OrderMeMenu _form;

        public NewOrder(List<Product> products, Repository repo, OrderMeMenu form)
        {
            _repository = repo;
            _form = form;
            InitializeComponent();
            DateTxtBox.Text = DateTime.Today.ToString("dd/MM/yyyy");
            loadSupplierCB();
            
        }

        private void loadSupplierCB()
        {
            _Suppliers = _repository.GetActiveSuppliers();
            SupplierCB.DataSource = _Suppliers;
            SupplierCB.DisplayMember = "Name";
            SupplierCB.ValueMember = "SupplierId";
        }

        void loadProductsGrid(List<Product> products)
        {
            ProductsGrid.Rows.Clear();

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
            Order od = createOrder(OrderState.Created);
            _repository.CreateOrder(od);
            _form.UpdateOrdersList();
        }

        private void createandsubmitBtn_Click(object sender, EventArgs e)
        {
            var emailAddress = EmailTxt.Text;
            var comments = CommentsTXT.Text;
            Order order = createOrder(OrderState.Created);
            bool sent = EmailSender.SendEmail(order, emailAddress, comments);
            if (sent) order.OrderStatus = OrderState.Sent;
            _repository.CreateOrder(order);
            _form.UpdateOrdersList();

        }

        private Order createOrder(OrderState state)
        {
            int number;

            Order order = new Order
            {
                Date = DateTime.Today,
                Company = CompanyTxtBox.Text,
                Contact = ContactTxtBox.Text,
                OrderStatus = state
            };



            foreach (DataGridViewRow row in ProductsGrid.Rows)
            {
                OrderDetail od = new OrderDetail();

                if (row.Cells[2].Value != null)
                {
                    od.Product = _products.Where(p => p.SKU == row.Cells[2].Value).FirstOrDefault();
                    var x = row.Cells[4].Value;
                    if (row.Cells[4].Value != null && Int32.TryParse(row.Cells[4].Value.ToString(), out number))
                    {
                        od.Quantity = Convert.ToInt32(row.Cells[4].Value.ToString());
                        order.AddDetail(od);
                    }

                }
            }
            showCreatingMessage();

            return order;
        }

        private void showCreatingMessage()
        {
            CreatinMsgPanel.Visible = true;
            this.Update();
            Cursor.Current = Cursors.WaitCursor;

        }

        //to take the value in editing mode when you click on create or sumbit order
        private void ProductsGrid_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            if (ProductsGrid.IsCurrentCellDirty)
            {
                ProductsGrid.CommitEdit(DataGridViewDataErrorContexts.Commit);
            }
        }

        //only numbers in Quantity column
        private void ProductsGrid_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {

            e.Control.KeyPress += new KeyPressEventHandler(Control_KeyPress);

        }

        private void Control_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }

            
        }

        private void SupplierCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            var Supp = SupplierCB.SelectedItem as Supplier;
            //Supplier Supp = _Suppliers
            //            .Where(s => s.SupplierId == int.Parse(SupplierCB.SelectedItem.ToString())).FirstOrDefault();

            if (Supp != null)
            {
                _products= _repository.GetActiveProductsbySupplier(Supp.SupplierId);

                loadProductsGrid(_products);

                EmailTxt.Text = Supp.Email;
            }

        }
    }
}
