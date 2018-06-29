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
    public partial class Suppliers : Form
    {
        private Repository _repository;
        private List<Supplier> _supps;

        public Suppliers(Repository repo)
        {
            _repository = repo;
            InitializeComponent();
            loadSuppGrid();
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

        private void showActiveSuppCheckBox_OnChange(object sender, EventArgs e)
        {
            loadSuppGrid();
        }

        private void newSuppBtn_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(newEmailTxt.Text) && !string.IsNullOrEmpty(NewSuppTXT.Text))
            {
                var supp = new Supplier { Active = true, Email = newEmailTxt.Text, Name = NewSuppTXT.Text};
                _repository.createSupplier(supp);
                loadSuppGrid();
            }
        }
    }
}
