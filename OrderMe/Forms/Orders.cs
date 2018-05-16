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
                    row.Cells[0].Value = order.Date.ToString("dd-MM-yyyy");
                    row.Cells[1].Value = order.OrderStatus;

                    OrderGrid.Rows.Add(row);
                }
            }

            else
            {
                OrderGrid.Visible = false;
                NoOrdersLabel.Visible = true;
                this.Update();
            }

        }
    }
}
