using OrderMe.DAL;
using OrderMe.Models;
using OrderMe.Services;
using System;
using System.Collections.Generic;
using System.Windows.Forms;


namespace OrderMe.Forms
{
    public partial class Suppliers : Form
    {
        private Repository _repository;
        private List<Supplier> _supps;
        private List<Brand> _Brands;
        private List<Product> _ActiveProducts;
        private List<Product> _SupplierProducts;

        public Suppliers(Repository repo)
        {
            _repository = repo;
            
            InitializeComponent();
            loadSuppGrid();
            loadComboboxes();
        }

        //load methods

        private void loadComboboxes()
        {
            //load brands
            _Brands = _repository.GetActivebrands();
            BrandCB.DataSource = _Brands;
            BrandCB.DisplayMember = "Name";
            BrandCB.ValueMember = "BrandId";

            //load products
            _ActiveProducts = _repository.GetActiveProducts();

            Dictionary<int, string> comboSource = new Dictionary<int, string>();
            
            foreach (Product prod in _ActiveProducts)
            {
                comboSource.Add(prod.ProductId, prod.Category.Brand.Name + " " +prod.Category.Name + " " + prod.ProductName);
            }

            ProductCB.DataSource = new BindingSource(comboSource, null);
            ProductCB.DisplayMember = "Value";
            ProductCB.ValueMember = "Key";

        }

        void loadSuppGrid()
        {
            _supps = _repository.GetSuppliers();
            SuppGrid.Rows.Clear();

            foreach (Supplier supp in _supps)
            {
                DataGridViewRow row = (DataGridViewRow)SuppGrid.Rows[0].Clone();
                row.Cells[0].Value = supp.SupplierId;
                row.Cells[1].Value = supp.Name;
                row.Cells[2].Value = supp.Email;
                row.Cells[3].Value = supp.Active;

                if (!showActiveSuppCheckBox.Checked)
                    SuppGrid.Rows.Add(row);
                else
                    if (supp.Active) SuppGrid.Rows.Add(row);
            }
        }

        private void loadProductSupplierGrid(int spId)
        {
            _SupplierProducts = _repository.GetProductsbySupplier(spId);

            ProductSuplierGrid.Rows.Clear();

            foreach (Product prod in _SupplierProducts)
            {
                DataGridViewRow row = (DataGridViewRow)ProductSuplierGrid.Rows[0].Clone();
                row.Cells[0].Value = prod.ProductId;
                row.Cells[1].Value = prod.Category.Brand.Name + " " + prod.Category.Name + " " + prod.ProductName;

                ProductSuplierGrid.Rows.Add(row);

            }
        }

        //Events

        private void showActiveSuppCheckBox_OnChange(object sender, EventArgs e)
        {
            loadSuppGrid();
        }

        private void newSuppBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(newEmailTxt.Text) || string.IsNullOrEmpty(NewSuppTXT.Text))
            {
                MessageBox.Show("Complete the name and email", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else if (!EmailSender.IsValidEmail(newEmailTxt.Text))
            {
                MessageBox.Show("Wrong email", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

            
            else 
            {
                var supp = new Supplier { Active = true, Email = newEmailTxt.Text, Name = NewSuppTXT.Text};
                _repository.createSupplier(supp);
                loadSuppGrid();
                NewSuppTXT.Text = string.Empty;
                newEmailTxt.Text = string.Empty;
            }
        }

        private void SuppGrid_SelectionChanged(object sender, EventArgs e)
        {
            if (SuppGrid.Rows.Count > 0)
            {
                try
                {
                    if (SuppGrid.SelectedRows[0].Cells["Id"].Value != null)
                    {
                        DataGridViewRow row = this.SuppGrid.SelectedRows[0];
                        NameTxt.Text = row.Cells["SupplierName"].Value.ToString();
                        EmailTxt.Text = row.Cells["Email"].Value.ToString();
                        ActiveCheckBox.Checked = bool.Parse(row.Cells["Active"].Value.ToString());

                        //load products
                        loadProductSupplierGrid(int.Parse(SuppGrid.SelectedRows[0].Cells["Id"].Value.ToString()));
                    }
                }
                catch (Exception ex)
                {
                    var error = ex.Message;
                }


            }
        }

        private void saveEditBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(NameTxt.Text) || string.IsNullOrEmpty(EmailTxt.Text))
            {
                MessageBox.Show("Complete the name and email", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else if (!EmailSender.IsValidEmail(EmailTxt.Text))
            {
                MessageBox.Show("Wrong email", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

            else
            {
                _repository.EditSupplier(int.Parse(SuppGrid.SelectedRows[0].Cells["Id"].Value.ToString()), NameTxt.Text, EmailTxt.Text, ActiveCheckBox.Checked);
                loadSuppGrid();
            }
        }

        private void AddProductSupplierBtn_Click(object sender, EventArgs e)
        {
            

            if (SuppGrid.SelectedRows[0].Cells["Id"].Value != null)
            {
                int supplierId = int.Parse(SuppGrid.SelectedRows[0].Cells["Id"].Value.ToString());
                int ProductId = ((KeyValuePair<int, string>)ProductCB.SelectedItem).Key;
                _repository.CreateSupplierProduct(supplierId, ProductId);

                //refresh supplierProductGrid
                loadProductSupplierGrid(int.Parse(SuppGrid.SelectedRows[0].Cells["Id"].Value.ToString()));

            }
        }

        private void DeleteSupplierProductBtn_Click(object sender, EventArgs e)
        {
            if (SuppGrid.SelectedRows[0].Cells["Id"].Value != null && ProductSuplierGrid.SelectedRows[0].Cells["ProductId"].Value != null)
            {
                int supplierId = int.Parse(SuppGrid.SelectedRows[0].Cells["Id"].Value.ToString());
                int ProductId = int.Parse(ProductSuplierGrid.SelectedRows[0].Cells["ProductId"].Value.ToString());
                _repository.DeleteSupplierProduct(supplierId, ProductId);

                //refresh supplierProductGrid
                loadProductSupplierGrid(int.Parse(SuppGrid.SelectedRows[0].Cells["Id"].Value.ToString()));
            }
        }

        private void AsignBrandProductsBtn_Click(object sender, EventArgs e)
        {
            if (SuppGrid.SelectedRows[0].Cells["Id"].Value != null)
            {
                int supplierId = int.Parse(SuppGrid.SelectedRows[0].Cells["Id"].Value.ToString());

                int BrandId;
                if (int.TryParse(BrandCB.SelectedValue.ToString(), out BrandId))
                {
                    BrandId = int.Parse(BrandCB.SelectedValue.ToString());
                    List<Product> productsbybrand = _repository.GetActiveProductsbyBrand(BrandId);
                    foreach (Product prod in productsbybrand)
                    {
                        _repository.CreateSupplierProduct(supplierId, prod.ProductId);
                    }

                    //refresh supplierProductGrid
                    loadProductSupplierGrid(int.Parse(SuppGrid.SelectedRows[0].Cells["Id"].Value.ToString()));
                }
            }
            
        }
    }
}
