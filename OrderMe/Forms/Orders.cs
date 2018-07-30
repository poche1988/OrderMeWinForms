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
using System.Data.Entity;
using OrderMe.Services;

namespace OrderMe.Forms
{
    public partial class Orders : Form
    {
        private List<Order> _Orders;
        private readonly Repository _repository;
        private OrderMeMenu _form;
        public Orders(List<Order> order, Repository repo, OrderMeMenu form)
        {
            _Orders = order;
            _repository = repo;
            _form = form;
            InitializeComponent();
            dateFrom.Value = DateTime.Today;
            DateTo.Value = DateTime.Today;
            loadOrderGrid(_Orders);
        }

        void loadOrderGrid(List<Order> orders)
        {
            if (orders.Count > 0)
            {
                foreach (var order in orders)
                {
                    DataGridViewRow row = (DataGridViewRow)OrderGrid.Rows[0].Clone();
                    row.Cells[0].Value = order.OrderId;
                    row.Cells[1].Value = order.Date.ToString("dd-MM-yyyy");
                    row.Cells[2].Value = order.OrderStatus;

                    OrderGrid.Rows.Add(row);
                }
                OrderGrid.Visible = true;
                OrderDetailsGrid.Visible = true;
                DeleteOrderBtn.Visible = true;
                NoOrdersLabel.Visible = false;
                odLine.Visible = true;
                OrderDetailsLbl.Visible = true;
                SubmitBtn.Visible = true;
                this.Update();
            }

            else
            {
                OrderGrid.Visible = false;
                OrderDetailsGrid.Visible = false;
                DeleteOrderBtn.Visible = false;
                NoOrdersLabel.Visible = true;
                odLine.Visible = false;
                OrderDetailsLbl.Visible = false;
                SubmitBtn.Visible = false;
                this.Update();
            }

        }

        private void loadOrderDetailsGrid()
        {
            if (OrderGrid.Rows.Count > 0)
            {
                try
                {
                    if (OrderGrid.SelectedRows[0].Cells["Id"].Value != null)
                    {
                        DataGridViewRow row = this.OrderGrid.SelectedRows[0];
                        OrderDetailsGrid.Rows.Clear();

                        var orderdetails = _Orders.Where(o => o.OrderId == Convert.ToInt32(row.Cells["Id"].Value))
                            .Select(o => o.OrderDetails).ToList();

                        if (orderdetails[0].Count > 0)
                        {
                            foreach (OrderDetail od in orderdetails[0])
                            {
                                DataGridViewRow rowod = (DataGridViewRow)OrderDetailsGrid.Rows[0].Clone();
                                rowod.Cells[0].Value = od.Product.Category.Brand.Name;
                                rowod.Cells[1].Value = od.Product.Category.Name + " " + od.Product.ProductName;
                                rowod.Cells[2].Value = od.Quantity;

                                OrderDetailsGrid.Rows.Add(rowod);
                            }
                        }

                        if (row.Cells["Status"].Value.ToString() == "Sent")
                            SubmitBtn.Enabled = false;
                        else
                            SubmitBtn.Enabled = true;
                    }
                }
                catch
                {
                    // do something
                }

            }
        }

        private void OrderGrid_SelectionChanged(object sender, EventArgs e)
        {
            //load comments
            try
            {
                if (OrderGrid.SelectedRows[0].Cells["Id"].Value != null)
                {
                    DataGridViewRow row = this.OrderGrid.SelectedRows[0];
                    var order = _Orders.Where(o => o.OrderId == Convert.ToInt32(row.Cells["Id"].Value)).FirstOrDefault();
                    CommentsTxt.Text = order.Comment;
                    EmailTxt.Text = order.Supplier.Email;
                }
            }
            catch
            {
                // do something
            }

            loadOrderDetailsGrid();
        }

        private void DeleteOrderBtn_Click(object sender, EventArgs e)
        {


            DataGridViewRow row = this.OrderGrid.SelectedRows[0];

            if (row.Cells["Id"].Value != null)
            {
                DialogResult result = MessageBox.Show("You are deleting an order. Are you sure?", "Delete", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                if (result.Equals(DialogResult.OK))
                {
                    var id = Convert.ToInt32(row.Cells["Id"].Value);
                    Cursor.Current = Cursors.WaitCursor;
                    _repository.DeleteOrder(id);
                    _form.UpdateOrdersList();
                }
                else
                {
                    //do something
                }

            }
        }

        private void SearchBtn_Click(object sender, EventArgs e)
        {
            if (dateFrom.Value != null && DateTo.Value != null & dateFrom.Value.Date <= DateTo.Value.Date)
            {
                OrderGrid.Rows.Clear();
                List<Order> orders = _Orders.Where(o => o.Date.Date >= dateFrom.Value.Date && o.Date.Date <= DateTo.Value.Date).ToList();
                loadOrderGrid(orders);
            }
        }

        private void SubmitBtn_Click(object sender, EventArgs e)
        {
            var emailAddress = EmailTxt.Text;
            var comments = CommentsTxt.Text;
            Cursor.Current = Cursors.WaitCursor;
            DataGridViewRow row = this.OrderGrid.SelectedRows[0];
            Order order = _Orders.Where(o => o.OrderId == Convert.ToInt32(row.Cells["Id"].Value)).FirstOrDefault();
            bool sent = EmailSender.SendEmail(order, emailAddress, comments);
            if (sent)
            {
                _repository.ChangeOrderStatusToSent(order.OrderId);
                _form.UpdateOrdersList();
            }
        }
    }
}
