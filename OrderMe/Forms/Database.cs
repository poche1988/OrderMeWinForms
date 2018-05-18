using OrderMe.Models;
using OrderMe.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace OrderMe.Forms
{
    public partial class Database : Form
    {
        private List<Product> _products;
        private List<Order> _orders;

        public Database(List<Product> products, List<Order> orders)
        {
            _products = products;
            _orders = orders;
            InitializeComponent();
        }

        private void BackUpBtn_Click(object sender, EventArgs e)
        {
            bool created = CSVCreator.OrdersBackupCreator(_orders, "Orders");
            if (created) MessageBox.Show("Back up succesfully created");
        }

        private void CreateProductsBackUpBtn_Click(object sender, EventArgs e)
        {
            bool created = CSVCreator.ProductsBackupCreator(_products);
            if (created) MessageBox.Show("Back up succesfully created");
        }
    }
}
