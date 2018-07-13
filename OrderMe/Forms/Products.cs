using OrderMe.DAL;
using OrderMe.Models;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Linq;
using System.Data;
using System;

namespace OrderMe.Forms
{
    public partial class Products : Form
    {
        private List<Product> _Products;
        private List<Brand> _Brands;
        private List<Supplier> _Suppliers;
        private List<ProductCategory> _Categories;
        private readonly Repository _repository;

        public Products(Repository repo)
        {
            InitializeComponent();
            _repository = repo;
            _Products = _repository.Getproducts();
            loadProductsGrid(_Products);
            loadComboboxes();

        }

        void loadProductsGrid(List<Product> products)
        {
            foreach (var product in products)
            {
                DataGridViewRow row = (DataGridViewRow)ProductsGrid.Rows[0].Clone();
                row.Cells[0].Value = product.ProductId;
                row.Cells[1].Value = product.Active;
                row.Cells[2].Value = product.Category.Brand.Name;
                row.Cells[3].Value = product.Category.Name;
                row.Cells[4].Value = product.SKU;
                row.Cells[5].Value = product.ProductName;

                if (!showactivecheckbox.Checked)
                {
                    ProductsGrid.Rows.Add(row);
                }
                else
                {
                    if(product.Active) ProductsGrid.Rows.Add(row);
                }
                
            }
        }

        void loadComboboxes()
        {
            _Brands = _repository.GetActivebrands();
            BrandCB.DataSource = _Brands;
            BrandCB.DisplayMember = "Name";
            BrandCB.ValueMember = "BrandId";

            _Suppliers = _repository.GetActiveSuppliers();
            SupplierCB.DataSource = _Suppliers;
            SupplierCB.DisplayMember = "Name";
            SupplierCB.ValueMember = "SupplierId";
        }

        private void BrandCB_SelectedValueChanged(object sender, System.EventArgs e)
        {
            int id;
            if (int.TryParse(BrandCB.SelectedValue.ToString(), out id))
            {
                id = int.Parse(BrandCB.SelectedValue.ToString());
                _Categories = _repository.GetCategoryByBrandId(id);

                CategoryCB.DataSource = _Categories;
                CategoryCB.DisplayMember = "Name";
                CategoryCB.ValueMember = "ProductCategoryId";
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

        private void ProductsGrid_SelectionChanged(object sender, System.EventArgs e)
        {
            if (!NewProdCheckBox.Checked)
            {
                loadProductToEdit();
            }
        }

        private void NewProdCheckBox_OnChange(object sender, EventArgs e)
        {
            if (NewProdCheckBox.Checked)
            {
                NameTxt.Text = string.Empty;
                skuTextBox.Text = string.Empty;
                ActiveChBox.Checked = true;
                SupplierCB.Visible = true;
            }
            else
            {
                SupplierCB.Visible = false;
                loadProductToEdit();
            }
                

        }

        void loadProductToEdit()
        {
            try
            {
                if (ProductsGrid.SelectedRows.Count > 0)
                {
                    if (ProductsGrid.SelectedRows[0].Cells["ProductId"].Value != null)
                    {
                        var prod = _repository.GetproductById(int.Parse(ProductsGrid.SelectedRows[0].Cells["ProductId"].Value.ToString()));

                        NameTxt.Text = prod.ProductName;
                        skuTextBox.Text = prod.SKU;
                        ActiveChBox.Checked = prod.Active;

                        BrandCB.SelectedValue = prod.Category.Brand.BrandId;
                        CategoryCB.SelectedValue = prod.Category.ProductCategoryId;
                    }
                }

            }
            catch (Exception ex)
            {
                var error = ex.Message;
            }
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {

            // get the supplier and category, doesn't matter if we are creating or editing
            Supplier Supp = _Suppliers
                        .Where(s => s.SupplierId == int.Parse(SupplierCB.SelectedValue.ToString())).FirstOrDefault();

            ProductCategory category = _Categories
                        .Where(c => c.ProductCategoryId == int.Parse(CategoryCB.SelectedValue.ToString())).FirstOrDefault();

            //new instance
            Product prod = new Product();

            //if we are editing
            if (!NewProdCheckBox.Checked)
            {
                prod = _Products
                    .Where(p => p.ProductId == int.Parse(ProductsGrid.SelectedRows[0].Cells["ProductId"].Value.ToString()))
                    .FirstOrDefault();
                if (prod == null)
                {
                    prod = _repository.GetProductBySKU(ProductsGrid.SelectedRows[0].Cells["SKU"].Value.ToString());
                }
            }
            //validate and if everything is fine, save changes
            if (!string.IsNullOrEmpty(skuTextBox.Text) && !string.IsNullOrEmpty(NameTxt.Text))
            {
                prod.SKU = skuTextBox.Text;
                prod.ProductName = NameTxt.Text;
                prod.Category = category;
                prod.Active = ActiveChBox.Checked;

                _repository.CreateOrEditProduct(prod);

                //save SupplierProduct only when is a new product
                if (NewProdCheckBox.Checked)
                {
                    var LastProd = _repository.GetLastProduct();
                    _repository.CreateSupplierProduct(Supp.SupplierId, LastProd.ProductId);
                }

                //refresh Product Grid
                ProductsGrid.Rows.Clear();

                _Products = _repository.Getproducts();

                loadProductsGrid(_Products);

                //reset create edit form
                if (NewProdCheckBox.Checked)
                {
                    skuTextBox.Text = string.Empty;
                    NameTxt.Text = string.Empty;
                }
                





            }

            // else show message validation
        }

        private void showactivecheckbox_OnChange(object sender, EventArgs e)
        {
            ProductsGrid.Rows.Clear();
            loadProductsGrid(_Products);
        }
    }


}
