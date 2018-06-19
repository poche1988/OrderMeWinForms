using OrderMe.DAL;
using OrderMe.Models;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace OrderMe.Forms
{
    public partial class Brands : Form
    {
        private List<Brand> _Brands;
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
    }
}
