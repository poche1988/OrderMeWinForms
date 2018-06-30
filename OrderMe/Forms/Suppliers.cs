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
                        //cargar productos en la grilla q va a estar a la derecha
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

        
    }
}
