﻿namespace OrderMe.Forms
{
    partial class NewOrder
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewOrder));
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ContactTxtBox = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.CompanyTxtBox = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.DateLabel = new System.Windows.Forms.Label();
            this.DateTxtBox = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.ProductsGrid = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.brand = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoryname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SKU = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CreateOrderBtn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuFlatButton2 = new Bunifu.Framework.UI.BunifuFlatButton();
            ((System.ComponentModel.ISupportInitialize)(this.ProductsGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 22);
            this.label1.TabIndex = 1;
            this.label1.Text = "New Order";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.panel1.Location = new System.Drawing.Point(2, 34);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(950, 2);
            this.panel1.TabIndex = 2;
            // 
            // ContactTxtBox
            // 
            this.ContactTxtBox.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.ContactTxtBox.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ContactTxtBox.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.ContactTxtBox.BorderThickness = 1;
            this.ContactTxtBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.ContactTxtBox.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.ContactTxtBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ContactTxtBox.isPassword = false;
            this.ContactTxtBox.Location = new System.Drawing.Point(380, 43);
            this.ContactTxtBox.Margin = new System.Windows.Forms.Padding(4);
            this.ContactTxtBox.Name = "ContactTxtBox";
            this.ContactTxtBox.Size = new System.Drawing.Size(158, 44);
            this.ContactTxtBox.TabIndex = 8;
            this.ContactTxtBox.Text = "Annelies van der Poel";
            this.ContactTxtBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.label2.Location = new System.Drawing.Point(12, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 21);
            this.label2.TabIndex = 9;
            this.label2.Text = "Company";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.label3.Location = new System.Drawing.Point(295, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 21);
            this.label3.TabIndex = 10;
            this.label3.Text = "Contact";
            // 
            // CompanyTxtBox
            // 
            this.CompanyTxtBox.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.CompanyTxtBox.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.CompanyTxtBox.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.CompanyTxtBox.BorderThickness = 1;
            this.CompanyTxtBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.CompanyTxtBox.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.CompanyTxtBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.CompanyTxtBox.isPassword = false;
            this.CompanyTxtBox.Location = new System.Drawing.Point(107, 43);
            this.CompanyTxtBox.Margin = new System.Windows.Forms.Padding(4);
            this.CompanyTxtBox.Name = "CompanyTxtBox";
            this.CompanyTxtBox.Size = new System.Drawing.Size(158, 44);
            this.CompanyTxtBox.TabIndex = 11;
            this.CompanyTxtBox.Text = "Otis & Louie LTD";
            this.CompanyTxtBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // DateLabel
            // 
            this.DateLabel.AutoSize = true;
            this.DateLabel.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.DateLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.DateLabel.Location = new System.Drawing.Point(577, 54);
            this.DateLabel.Name = "DateLabel";
            this.DateLabel.Size = new System.Drawing.Size(50, 21);
            this.DateLabel.TabIndex = 12;
            this.DateLabel.Text = "Date";
            // 
            // DateTxtBox
            // 
            this.DateTxtBox.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.DateTxtBox.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.DateTxtBox.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.DateTxtBox.BorderThickness = 1;
            this.DateTxtBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.DateTxtBox.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.DateTxtBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.DateTxtBox.isPassword = false;
            this.DateTxtBox.Location = new System.Drawing.Point(634, 43);
            this.DateTxtBox.Margin = new System.Windows.Forms.Padding(4);
            this.DateTxtBox.Name = "DateTxtBox";
            this.DateTxtBox.Size = new System.Drawing.Size(158, 44);
            this.DateTxtBox.TabIndex = 13;
            this.DateTxtBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // ProductsGrid
            // 
            this.ProductsGrid.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ProductsGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.ProductsGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ProductsGrid.BackgroundColor = System.Drawing.SystemColors.Control;
            this.ProductsGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ProductsGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ProductsGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.ProductsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ProductsGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.brand,
            this.categoryname,
            this.SKU,
            this.productname,
            this.quantity});
            this.ProductsGrid.DoubleBuffered = true;
            this.ProductsGrid.EnableHeadersVisualStyles = false;
            this.ProductsGrid.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.ProductsGrid.HeaderForeColor = System.Drawing.Color.White;
            this.ProductsGrid.Location = new System.Drawing.Point(16, 103);
            this.ProductsGrid.Name = "ProductsGrid";
            this.ProductsGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.ProductsGrid.Size = new System.Drawing.Size(776, 361);
            this.ProductsGrid.TabIndex = 14;
            // 
            // brand
            // 
            this.brand.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.brand.HeaderText = "Brand";
            this.brand.Name = "brand";
            this.brand.ReadOnly = true;
            this.brand.Width = 65;
            // 
            // categoryname
            // 
            this.categoryname.HeaderText = "Product";
            this.categoryname.Name = "categoryname";
            this.categoryname.ReadOnly = true;
            // 
            // SKU
            // 
            this.SKU.HeaderText = "SKU";
            this.SKU.Name = "SKU";
            this.SKU.ReadOnly = true;
            // 
            // productname
            // 
            this.productname.HeaderText = "Size";
            this.productname.Name = "productname";
            this.productname.ReadOnly = true;
            // 
            // quantity
            // 
            this.quantity.HeaderText = "Quantity";
            this.quantity.Name = "quantity";
            // 
            // CreateOrderBtn
            // 
            this.CreateOrderBtn.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.CreateOrderBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.CreateOrderBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CreateOrderBtn.BorderRadius = 0;
            this.CreateOrderBtn.ButtonText = "Create Order";
            this.CreateOrderBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CreateOrderBtn.DisabledColor = System.Drawing.Color.Gray;
            this.CreateOrderBtn.Iconcolor = System.Drawing.Color.Transparent;
            this.CreateOrderBtn.Iconimage = ((System.Drawing.Image)(resources.GetObject("CreateOrderBtn.Iconimage")));
            this.CreateOrderBtn.Iconimage_right = null;
            this.CreateOrderBtn.Iconimage_right_Selected = null;
            this.CreateOrderBtn.Iconimage_Selected = null;
            this.CreateOrderBtn.IconMarginLeft = 0;
            this.CreateOrderBtn.IconMarginRight = 0;
            this.CreateOrderBtn.IconRightVisible = true;
            this.CreateOrderBtn.IconRightZoom = 0D;
            this.CreateOrderBtn.IconVisible = true;
            this.CreateOrderBtn.IconZoom = 90D;
            this.CreateOrderBtn.IsTab = false;
            this.CreateOrderBtn.Location = new System.Drawing.Point(29, 487);
            this.CreateOrderBtn.Name = "CreateOrderBtn";
            this.CreateOrderBtn.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.CreateOrderBtn.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.CreateOrderBtn.OnHoverTextColor = System.Drawing.Color.White;
            this.CreateOrderBtn.selected = false;
            this.CreateOrderBtn.Size = new System.Drawing.Size(223, 48);
            this.CreateOrderBtn.TabIndex = 15;
            this.CreateOrderBtn.Text = "Create Order";
            this.CreateOrderBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.CreateOrderBtn.Textcolor = System.Drawing.Color.White;
            this.CreateOrderBtn.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CreateOrderBtn.Click += new System.EventHandler(this.CreateOrderBtn_Click);
            // 
            // bunifuFlatButton2
            // 
            this.bunifuFlatButton2.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.bunifuFlatButton2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton2.BorderRadius = 0;
            this.bunifuFlatButton2.ButtonText = "     Create and Submit Order";
            this.bunifuFlatButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton2.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton2.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton2.Iconimage = ((System.Drawing.Image)(resources.GetObject("bunifuFlatButton2.Iconimage")));
            this.bunifuFlatButton2.Iconimage_right = null;
            this.bunifuFlatButton2.Iconimage_right_Selected = null;
            this.bunifuFlatButton2.Iconimage_Selected = null;
            this.bunifuFlatButton2.IconMarginLeft = 0;
            this.bunifuFlatButton2.IconMarginRight = 0;
            this.bunifuFlatButton2.IconRightVisible = true;
            this.bunifuFlatButton2.IconRightZoom = 0D;
            this.bunifuFlatButton2.IconVisible = true;
            this.bunifuFlatButton2.IconZoom = 50D;
            this.bunifuFlatButton2.IsTab = false;
            this.bunifuFlatButton2.Location = new System.Drawing.Point(289, 487);
            this.bunifuFlatButton2.Name = "bunifuFlatButton2";
            this.bunifuFlatButton2.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.bunifuFlatButton2.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.bunifuFlatButton2.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton2.selected = false;
            this.bunifuFlatButton2.Size = new System.Drawing.Size(223, 48);
            this.bunifuFlatButton2.TabIndex = 16;
            this.bunifuFlatButton2.Text = "     Create and Submit Order";
            this.bunifuFlatButton2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuFlatButton2.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton2.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // NewOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(950, 564);
            this.Controls.Add(this.bunifuFlatButton2);
            this.Controls.Add(this.CreateOrderBtn);
            this.Controls.Add(this.ProductsGrid);
            this.Controls.Add(this.DateTxtBox);
            this.Controls.Add(this.DateLabel);
            this.Controls.Add(this.CompanyTxtBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ContactTxtBox);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "NewOrder";
            this.Text = "NewOrder";
            ((System.ComponentModel.ISupportInitialize)(this.ProductsGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuMetroTextbox ContactTxtBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private Bunifu.Framework.UI.BunifuMetroTextbox CompanyTxtBox;
        private System.Windows.Forms.Label DateLabel;
        private Bunifu.Framework.UI.BunifuMetroTextbox DateTxtBox;
        private Bunifu.Framework.UI.BunifuCustomDataGrid ProductsGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn brand;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoryname;
        private System.Windows.Forms.DataGridViewTextBoxColumn SKU;
        private System.Windows.Forms.DataGridViewTextBoxColumn productname;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantity;
        private Bunifu.Framework.UI.BunifuFlatButton CreateOrderBtn;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton2;
    }
}