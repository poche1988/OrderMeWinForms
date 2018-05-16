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
        }
    }
}
