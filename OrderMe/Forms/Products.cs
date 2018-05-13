using OrderMe.DAL;
using OrderMe.Models;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Linq;
using System.Data;

namespace OrderMe.Forms
{
    public partial class Products : Form
    {
        private List<Product> _Products;
        public Products(List<Product> products)
        {
            InitializeComponent();
            _Products = products;
            loadProductsGrid(_Products);
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

                ProductsGrid.Rows.Add(row);
            }
        }

        private void searchTxtBox_OnValueChanged(object sender, System.EventArgs e)
        {
            ProductsGrid.Rows.Clear();
            //||
            if (searchTxtBox.Text.Length > 0)
            {
                var filteredproducts = _Products
                    .Where(p => 
                    p.SKU.ToLower().Contains(searchTxtBox.Text.ToLower()) ||
                    p.ProductName.ToLower().Contains(searchTxtBox.Text.ToLower()) ||
                    p.Category.Name.ToLower().Contains(searchTxtBox.Text.ToLower()) ||
                    p.Category.Brand.Name.ToLower().Contains(searchTxtBox.Text.ToLower()))
                    .ToList();

                loadProductsGrid(filteredproducts);
            }
            else
            {
                loadProductsGrid(_Products);
            }
        }
    }


}
