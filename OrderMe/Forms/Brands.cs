using OrderMe.DAL;
using OrderMe.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace OrderMe.Forms
{
    public partial class Brands : Form
    {
        private List<Brand> _Brands;
        private List<ProductCategory> _Categories;
        private readonly Repository _repository;

        public Brands(Repository repo)
        {
            _repository = repo;
            InitializeComponent();
            loadBrandsGrid();
        }

        void loadBrandsGrid()
        {
            _Brands = _repository.Getbrands();
            BrandGrid.Rows.Clear();
            foreach (var brand in _Brands)
            {
                DataGridViewRow row = (DataGridViewRow)BrandGrid.Rows[0].Clone();
                row.Cells[0].Value = brand.BrandId;
                row.Cells[1].Value = brand.Name;
                row.Cells[2].Value = brand.Active;

                if(!showActiveBrandsCheckBox.Checked)
                BrandGrid.Rows.Add(row);
                else
                    if(brand.Active) BrandGrid.Rows.Add(row);
            }
        }

        void loadCategoriesGrid()
        {
            _Categories = _repository.GetCategoryByBrandId(int.Parse(IdTxt.Text));
            BranCategoriesGrid.Rows.Clear();

            if (_Categories.Count > 0)
            {
                foreach (var category in _Categories)
                {
                    DataGridViewRow row = (DataGridViewRow)BranCategoriesGrid.Rows[0].Clone();
                    row.Cells[0].Value = category.ProductCategoryId;
                    row.Cells[1].Value = category.Brand.Name;
                    row.Cells[2].Value = category.Name;
                    row.Cells[3].Value = category.active;

                    if (!showonlyactivecategorieschbox.Checked)
                        BranCategoriesGrid.Rows.Add(row);
                    else
                    if (category.active) BranCategoriesGrid.Rows.Add(row);

                }
            }
        }

        private void newBrandBtn_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(NewBrandTXT.Text))
            {
                var b = new Brand
                {
                    Name = NewBrandTXT.Text,
                    Active = true
                };
                _repository.addBrand(b);
                loadBrandsGrid();
                NewBrandTXT.Text = null;

            }
        }

        private void saveEditBtn_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(EditBrandTxt.Text))
            {
                _repository.EditBrand(int.Parse(IdTxt.Text), EditBrandTxt.Text, ActiveCheckBox.Checked);
                loadBrandsGrid();
            }
        }

        private void BrandGrid_SelectionChanged(object sender, EventArgs e)
        {
            if (BrandGrid.Rows.Count > 0)
            {
                try
                {
                    if (BrandGrid.SelectedRows[0].Cells["Id"].Value != null)
                    {
                        DataGridViewRow row = this.BrandGrid.SelectedRows[0];
                        EditBrandTxt.Text = row.Cells["Brand"].Value.ToString();
                        IdTxt.Text = row.Cells["Id"].Value.ToString();
                        ActiveCheckBox.Checked = bool.Parse(row.Cells["Active"].Value.ToString());
                        loadCategoriesGrid();
                    }
                }
                catch(Exception ex) {
                    var error = ex.Message;
                }
                

            }
        }

        private void showActiveBrandsCheckBox_OnChange(object sender, EventArgs e)
        {
            loadBrandsGrid();
        }

        private void AddCategoryBtn_Click(object sender, EventArgs e)
        {
            Brand brand = _Brands.Where(b => b.BrandId == int.Parse(IdTxt.Text)).FirstOrDefault();

            if (!string.IsNullOrEmpty(newcategoryTxt.Text))
            {
                var category = new ProductCategory
                {
                    Name = newcategoryTxt.Text,
                    Brand = brand,
                    active = true
                };
                _repository.addCategory(category);
                loadCategoriesGrid();
                newcategoryTxt.Text = null;
            }
            
        }

        private void EditCategoryBtn_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(CatNameTxt.Text))
            {
                _repository.EditCategory(int.Parse(CatIdTxt.Text), CatNameTxt.Text, CatActiveChBox.Checked);
                loadCategoriesGrid();
            }
        }

        private void BranCategoriesGrid_SelectionChanged(object sender, EventArgs e)
        {
            if (BranCategoriesGrid.Rows.Count > 0)
            {
                try
                {
                    if (BranCategoriesGrid.SelectedRows[0].Cells["CategoryId"].Value != null)
                    {
                        DataGridViewRow row = this.BranCategoriesGrid.SelectedRows[0];
                        CatNameTxt.Text = row.Cells["Category"].Value.ToString();
                        CatIdTxt.Text = row.Cells["CategoryId"].Value.ToString();
                        CatActiveChBox.Checked = bool.Parse(row.Cells["CatActive"].Value.ToString());
                    }
                }
                catch (Exception ex)
                {
                    var error = ex.Message;
                }


            }
        }

        private void showonlyactivecategorieschbox_OnChange(object sender, EventArgs e)
        {
            loadCategoriesGrid();
        }
    }
}
