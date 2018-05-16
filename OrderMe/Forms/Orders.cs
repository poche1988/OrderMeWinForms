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

namespace OrderMe.Forms
{
    public partial class Orders : Form
    {
        private List<Order> _Orders;
        private readonly Repository _repository;
        public Orders(List<Order> order, Repository repo)
        {
            _Orders = order;
            _repository = repo;
            InitializeComponent();
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
                OrderGrid.Rows[0].Selected = true;
            }

            else
            {
                OrderGrid.Visible = false;
                NoOrdersLabel.Visible = true;
                this.Update();
            }

        }

        private void loadOrderDetailsGrid()
        {
            DataGridViewRow row = this.OrderGrid.SelectedRows[0];

            if (row.Cells["Id"].Value != null)
            {
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
                
            }
        }

        private void OrderGrid_SelectionChanged(object sender, EventArgs e)
        {
            loadOrderDetailsGrid();
        }
    }
}
