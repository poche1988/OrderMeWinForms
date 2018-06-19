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
        public Brands(List<Brand> Brands, Repository repo)
        {
            _Brands = Brands;
            _repository = repo;
            InitializeComponent();
            loadBrandsGrid(_Brands);
        }

        void loadBrandsGrid(List<Brand> Brands)
        {
            foreach (var brand in Brands)
            {
                DataGridViewRow row = (DataGridViewRow)BrandGrid.Rows[0].Clone();
                row.Cells[0].Value = brand.Name;
                row.Cells[1].Value = brand.Active;

                BrandGrid.Rows.Add(row);
            }
        }
    }
}
