using System.Drawing;

namespace OrderMe.Forms
{
    partial class Orders
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Orders));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.OrderGrid = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NoOrdersLabel = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.OrderDetailsGrid = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.Brand = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Product = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DeleteOrderBtn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.SubmitBtn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.OrderDetailsLbl = new System.Windows.Forms.Label();
            this.odLine = new System.Windows.Forms.Panel();
            this.dateFrom = new Bunifu.Framework.UI.BunifuDatepicker();
            this.DateTo = new Bunifu.Framework.UI.BunifuDatepicker();
            this.datefromlbl = new System.Windows.Forms.Label();
            this.datetolbl = new System.Windows.Forms.Label();
            this.SearchBtn = new Bunifu.Framework.UI.BunifuImageButton();
            ((System.ComponentModel.ISupportInitialize)(this.OrderGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OrderDetailsGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SearchBtn)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.panel1.Location = new System.Drawing.Point(2, 34);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(950, 2);
            this.panel1.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 14F);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 22);
            this.label2.TabIndex = 3;
            this.label2.Text = "Orders";
            // 
            // OrderGrid
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.OrderGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.OrderGrid.BackgroundColor = System.Drawing.SystemColors.Control;
            this.OrderGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.OrderGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 12F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.OrderGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.OrderGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.OrderGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Date,
            this.Status});
            this.OrderGrid.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.OrderGrid.DefaultCellStyle = dataGridViewCellStyle3;
            this.OrderGrid.DoubleBuffered = true;
            this.OrderGrid.EnableHeadersVisualStyles = false;
            this.OrderGrid.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.OrderGrid.HeaderForeColor = System.Drawing.Color.White;
            this.OrderGrid.Location = new System.Drawing.Point(2, 113);
            this.OrderGrid.Name = "OrderGrid";
            this.OrderGrid.ReadOnly = true;
            this.OrderGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.OrderGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.OrderGrid.Size = new System.Drawing.Size(382, 539);
            this.OrderGrid.TabIndex = 5;
            this.OrderGrid.SelectionChanged += new System.EventHandler(this.OrderGrid_SelectionChanged);
            // 
            // Id
            // 
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            // 
            // Date
            // 
            this.Date.HeaderText = "Date";
            this.Date.Name = "Date";
            this.Date.ReadOnly = true;
            // 
            // Status
            // 
            this.Status.HeaderText = "Status";
            this.Status.Name = "Status";
            this.Status.ReadOnly = true;
            // 
            // NoOrdersLabel
            // 
            this.NoOrdersLabel.AutoSize = true;
            this.NoOrdersLabel.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NoOrdersLabel.Location = new System.Drawing.Point(821, 48);
            this.NoOrdersLabel.Name = "NoOrdersLabel";
            this.NoOrdersLabel.Size = new System.Drawing.Size(120, 22);
            this.NoOrdersLabel.TabIndex = 6;
            this.NoOrdersLabel.Text = "NO ORDERS";
            this.NoOrdersLabel.Visible = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.panel2.Location = new System.Drawing.Point(419, 113);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(2, 584);
            this.panel2.TabIndex = 7;
            // 
            // OrderDetailsGrid
            // 
            this.OrderDetailsGrid.AllowUserToDeleteRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.OrderDetailsGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.OrderDetailsGrid.BackgroundColor = System.Drawing.SystemColors.Control;
            this.OrderDetailsGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.OrderDetailsGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Century Gothic", 12F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.OrderDetailsGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.OrderDetailsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.OrderDetailsGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Brand,
            this.Product,
            this.Quantity});
            this.OrderDetailsGrid.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Century Gothic", 10.5F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.OrderDetailsGrid.DefaultCellStyle = dataGridViewCellStyle6;
            this.OrderDetailsGrid.DoubleBuffered = true;
            this.OrderDetailsGrid.EnableHeadersVisualStyles = false;
            this.OrderDetailsGrid.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.OrderDetailsGrid.HeaderForeColor = System.Drawing.Color.White;
            this.OrderDetailsGrid.Location = new System.Drawing.Point(494, 157);
            this.OrderDetailsGrid.Name = "OrderDetailsGrid";
            this.OrderDetailsGrid.ReadOnly = true;
            this.OrderDetailsGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.OrderDetailsGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.OrderDetailsGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.OrderDetailsGrid.Size = new System.Drawing.Size(458, 361);
            this.OrderDetailsGrid.TabIndex = 8;
            // 
            // Brand
            // 
            this.Brand.HeaderText = "Brand";
            this.Brand.Name = "Brand";
            this.Brand.ReadOnly = true;
            // 
            // Product
            // 
            this.Product.FillWeight = 200F;
            this.Product.HeaderText = "Product";
            this.Product.Name = "Product";
            this.Product.ReadOnly = true;
            this.Product.Width = 200;
            // 
            // Quantity
            // 
            this.Quantity.HeaderText = "Quantity";
            this.Quantity.Name = "Quantity";
            this.Quantity.ReadOnly = true;
            // 
            // DeleteOrderBtn
            // 
            this.DeleteOrderBtn.Activecolor = System.Drawing.Color.Red;
            this.DeleteOrderBtn.BackColor = System.Drawing.Color.White;
            this.DeleteOrderBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.DeleteOrderBtn.BorderRadius = 1;
            this.DeleteOrderBtn.ButtonText = "  Delete Order";
            this.DeleteOrderBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DeleteOrderBtn.DisabledColor = System.Drawing.Color.Gray;
            this.DeleteOrderBtn.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteOrderBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.DeleteOrderBtn.Iconcolor = System.Drawing.Color.Transparent;
            this.DeleteOrderBtn.Iconimage = ((System.Drawing.Image)(resources.GetObject("DeleteOrderBtn.Iconimage")));
            this.DeleteOrderBtn.Iconimage_right = null;
            this.DeleteOrderBtn.Iconimage_right_Selected = null;
            this.DeleteOrderBtn.Iconimage_Selected = null;
            this.DeleteOrderBtn.IconMarginLeft = 0;
            this.DeleteOrderBtn.IconMarginRight = 0;
            this.DeleteOrderBtn.IconRightVisible = true;
            this.DeleteOrderBtn.IconRightZoom = 0D;
            this.DeleteOrderBtn.IconVisible = true;
            this.DeleteOrderBtn.IconZoom = 40D;
            this.DeleteOrderBtn.IsTab = false;
            this.DeleteOrderBtn.Location = new System.Drawing.Point(958, 157);
            this.DeleteOrderBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.DeleteOrderBtn.Name = "DeleteOrderBtn";
            this.DeleteOrderBtn.Normalcolor = System.Drawing.Color.White;
            this.DeleteOrderBtn.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.DeleteOrderBtn.OnHoverTextColor = System.Drawing.Color.DarkRed;
            this.DeleteOrderBtn.selected = false;
            this.DeleteOrderBtn.Size = new System.Drawing.Size(180, 48);
            this.DeleteOrderBtn.TabIndex = 16;
            this.DeleteOrderBtn.Text = "  Delete Order";
            this.DeleteOrderBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.DeleteOrderBtn.Textcolor = System.Drawing.Color.DarkRed;
            this.DeleteOrderBtn.TextFont = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteOrderBtn.Click += new System.EventHandler(this.DeleteOrderBtn_Click);
            // 
            // SubmitBtn
            // 
            this.SubmitBtn.Activecolor = System.Drawing.Color.Red;
            this.SubmitBtn.BackColor = System.Drawing.Color.White;
            this.SubmitBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.SubmitBtn.BorderRadius = 0;
            this.SubmitBtn.ButtonText = "  Submit Order";
            this.SubmitBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SubmitBtn.DisabledColor = System.Drawing.Color.Gray;
            this.SubmitBtn.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SubmitBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.SubmitBtn.Iconcolor = System.Drawing.Color.Transparent;
            this.SubmitBtn.Iconimage = ((System.Drawing.Image)(resources.GetObject("SubmitBtn.Iconimage")));
            this.SubmitBtn.Iconimage_right = null;
            this.SubmitBtn.Iconimage_right_Selected = null;
            this.SubmitBtn.Iconimage_Selected = null;
            this.SubmitBtn.IconMarginLeft = 0;
            this.SubmitBtn.IconMarginRight = 0;
            this.SubmitBtn.IconRightVisible = true;
            this.SubmitBtn.IconRightZoom = 0D;
            this.SubmitBtn.IconVisible = true;
            this.SubmitBtn.IconZoom = 35D;
            this.SubmitBtn.IsTab = false;
            this.SubmitBtn.Location = new System.Drawing.Point(958, 224);
            this.SubmitBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.SubmitBtn.Name = "SubmitBtn";
            this.SubmitBtn.Normalcolor = System.Drawing.Color.White;
            this.SubmitBtn.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.SubmitBtn.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.SubmitBtn.selected = false;
            this.SubmitBtn.Size = new System.Drawing.Size(180, 48);
            this.SubmitBtn.TabIndex = 17;
            this.SubmitBtn.Text = "  Submit Order";
            this.SubmitBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SubmitBtn.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.SubmitBtn.TextFont = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SubmitBtn.Click += new System.EventHandler(this.SubmitBtn_Click);
            // 
            // OrderDetailsLbl
            // 
            this.OrderDetailsLbl.AutoSize = true;
            this.OrderDetailsLbl.Font = new System.Drawing.Font("Century Gothic", 14F);
            this.OrderDetailsLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.OrderDetailsLbl.Location = new System.Drawing.Point(490, 113);
            this.OrderDetailsLbl.Name = "OrderDetailsLbl";
            this.OrderDetailsLbl.Size = new System.Drawing.Size(127, 22);
            this.OrderDetailsLbl.TabIndex = 18;
            this.OrderDetailsLbl.Text = "Order details";
            // 
            // odLine
            // 
            this.odLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.odLine.Location = new System.Drawing.Point(494, 138);
            this.odLine.Name = "odLine";
            this.odLine.Size = new System.Drawing.Size(950, 2);
            this.odLine.TabIndex = 5;
            // 
            // dateFrom
            // 
            this.dateFrom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.dateFrom.BorderRadius = 0;
            this.dateFrom.ForeColor = System.Drawing.Color.White;
            this.dateFrom.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dateFrom.FormatCustom = null;
            this.dateFrom.Location = new System.Drawing.Point(116, 42);
            this.dateFrom.Name = "dateFrom";
            this.dateFrom.Size = new System.Drawing.Size(281, 36);
            this.dateFrom.TabIndex = 19;
            this.dateFrom.Value = new System.DateTime(2018, 5, 18, 9, 30, 13, 150);
            // 
            // DateTo
            // 
            this.DateTo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.DateTo.BorderRadius = 0;
            this.DateTo.ForeColor = System.Drawing.Color.White;
            this.DateTo.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.DateTo.FormatCustom = null;
            this.DateTo.Location = new System.Drawing.Point(437, 42);
            this.DateTo.Name = "DateTo";
            this.DateTo.Size = new System.Drawing.Size(281, 36);
            this.DateTo.TabIndex = 20;
            this.DateTo.Value = new System.DateTime(2018, 5, 18, 9, 30, 13, 150);
            // 
            // datefromlbl
            // 
            this.datefromlbl.AutoSize = true;
            this.datefromlbl.Font = new System.Drawing.Font("Century Gothic", 14F);
            this.datefromlbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.datefromlbl.Location = new System.Drawing.Point(56, 48);
            this.datefromlbl.Name = "datefromlbl";
            this.datefromlbl.Size = new System.Drawing.Size(54, 22);
            this.datefromlbl.TabIndex = 21;
            this.datefromlbl.Text = "From";
            // 
            // datetolbl
            // 
            this.datetolbl.AutoSize = true;
            this.datetolbl.Font = new System.Drawing.Font("Century Gothic", 14F);
            this.datetolbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.datetolbl.Location = new System.Drawing.Point(401, 48);
            this.datetolbl.Name = "datetolbl";
            this.datetolbl.Size = new System.Drawing.Size(30, 22);
            this.datetolbl.TabIndex = 22;
            this.datetolbl.Text = "To";
            // 
            // SearchBtn
            // 
            this.SearchBtn.BackColor = System.Drawing.Color.Transparent;
            this.SearchBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SearchBtn.ErrorImage = ((System.Drawing.Image)(resources.GetObject("SearchBtn.ErrorImage")));
            this.SearchBtn.Image = ((System.Drawing.Image)(resources.GetObject("SearchBtn.Image")));
            this.SearchBtn.ImageActive = null;
            this.SearchBtn.Location = new System.Drawing.Point(755, 42);
            this.SearchBtn.Name = "SearchBtn";
            this.SearchBtn.Size = new System.Drawing.Size(42, 36);
            this.SearchBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.SearchBtn.TabIndex = 23;
            this.SearchBtn.TabStop = false;
            this.SearchBtn.Zoom = 10;
            this.SearchBtn.Click += new System.EventHandler(this.SearchBtn_Click);
            // 
            // Orders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1150, 664);
            this.Controls.Add(this.SearchBtn);
            this.Controls.Add(this.datetolbl);
            this.Controls.Add(this.datefromlbl);
            this.Controls.Add(this.DateTo);
            this.Controls.Add(this.dateFrom);
            this.Controls.Add(this.odLine);
            this.Controls.Add(this.OrderDetailsLbl);
            this.Controls.Add(this.SubmitBtn);
            this.Controls.Add(this.DeleteOrderBtn);
            this.Controls.Add(this.OrderDetailsGrid);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.NoOrdersLabel);
            this.Controls.Add(this.OrderGrid);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Orders";
            this.Text = "Orders";
            ((System.ComponentModel.ISupportInitialize)(this.OrderGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.OrderDetailsGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SearchBtn)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private Bunifu.Framework.UI.BunifuCustomDataGrid OrderGrid;
        private System.Windows.Forms.Label NoOrdersLabel;
        private System.Windows.Forms.Panel panel2;
        private Bunifu.Framework.UI.BunifuCustomDataGrid OrderDetailsGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.DataGridViewTextBoxColumn Brand;
        private System.Windows.Forms.DataGridViewTextBoxColumn Product;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private Bunifu.Framework.UI.BunifuFlatButton DeleteOrderBtn;
        private Bunifu.Framework.UI.BunifuFlatButton SubmitBtn;
        private System.Windows.Forms.Label OrderDetailsLbl;
        private System.Windows.Forms.Panel odLine;
        private Bunifu.Framework.UI.BunifuDatepicker dateFrom;
        private Bunifu.Framework.UI.BunifuDatepicker DateTo;
        private System.Windows.Forms.Label datefromlbl;
        private System.Windows.Forms.Label datetolbl;
        private Bunifu.Framework.UI.BunifuImageButton SearchBtn;
    }
}