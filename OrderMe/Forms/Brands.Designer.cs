namespace OrderMe.Forms
{
    partial class Brands
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Brands));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.BrandGrid = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.NewBrandTXT = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.brandLbl = new System.Windows.Forms.Label();
            this.newBrandBtn = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.saveEditBtn = new System.Windows.Forms.PictureBox();
            this.EditBrandTxt = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.BrandName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ActiveCheckBox = new Bunifu.Framework.UI.BunifuCheckbox();
            this.label3 = new System.Windows.Forms.Label();
            this.bunifuSeparator1 = new Bunifu.Framework.UI.BunifuSeparator();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Brand = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Active = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdTxt = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.label4 = new System.Windows.Forms.Label();
            this.bunifuSeparator2 = new Bunifu.Framework.UI.BunifuSeparator();
            this.label5 = new System.Windows.Forms.Label();
            this.showActiveBrandsCheckBox = new Bunifu.Framework.UI.BunifuCheckbox();
            ((System.ComponentModel.ISupportInitialize)(this.BrandGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.newBrandBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.saveEditBtn)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.panel1.Location = new System.Drawing.Point(12, 34);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(950, 2);
            this.panel1.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 14F);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.label2.Location = new System.Drawing.Point(22, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 22);
            this.label2.TabIndex = 5;
            this.label2.Text = "Brands";
            // 
            // BrandGrid
            // 
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.BrandGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.BrandGrid.BackgroundColor = System.Drawing.SystemColors.Control;
            this.BrandGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.BrandGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Century Gothic", 12F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.BrandGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.BrandGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.BrandGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Brand,
            this.Active});
            this.BrandGrid.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Century Gothic", 10.5F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.BrandGrid.DefaultCellStyle = dataGridViewCellStyle6;
            this.BrandGrid.DoubleBuffered = true;
            this.BrandGrid.EnableHeadersVisualStyles = false;
            this.BrandGrid.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.BrandGrid.HeaderForeColor = System.Drawing.Color.White;
            this.BrandGrid.Location = new System.Drawing.Point(26, 160);
            this.BrandGrid.Name = "BrandGrid";
            this.BrandGrid.ReadOnly = true;
            this.BrandGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.BrandGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.BrandGrid.Size = new System.Drawing.Size(382, 304);
            this.BrandGrid.TabIndex = 7;
            this.BrandGrid.SelectionChanged += new System.EventHandler(this.BrandGrid_SelectionChanged);
            // 
            // NewBrandTXT
            // 
            this.NewBrandTXT.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.NewBrandTXT.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.NewBrandTXT.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.NewBrandTXT.BorderThickness = 1;
            this.NewBrandTXT.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.NewBrandTXT.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.NewBrandTXT.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.NewBrandTXT.isPassword = false;
            this.NewBrandTXT.Location = new System.Drawing.Point(119, 58);
            this.NewBrandTXT.Margin = new System.Windows.Forms.Padding(4);
            this.NewBrandTXT.Name = "NewBrandTXT";
            this.NewBrandTXT.Size = new System.Drawing.Size(193, 44);
            this.NewBrandTXT.TabIndex = 24;
            this.NewBrandTXT.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // brandLbl
            // 
            this.brandLbl.AutoSize = true;
            this.brandLbl.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.brandLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.brandLbl.Location = new System.Drawing.Point(24, 69);
            this.brandLbl.Name = "brandLbl";
            this.brandLbl.Size = new System.Drawing.Size(96, 21);
            this.brandLbl.TabIndex = 23;
            this.brandLbl.Text = "New Brand";
            // 
            // newBrandBtn
            // 
            this.newBrandBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.newBrandBtn.Image = ((System.Drawing.Image)(resources.GetObject("newBrandBtn.Image")));
            this.newBrandBtn.Location = new System.Drawing.Point(319, 59);
            this.newBrandBtn.Name = "newBrandBtn";
            this.newBrandBtn.Size = new System.Drawing.Size(44, 44);
            this.newBrandBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.newBrandBtn.TabIndex = 25;
            this.newBrandBtn.TabStop = false;
            this.newBrandBtn.Click += new System.EventHandler(this.newBrandBtn_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.panel2.Location = new System.Drawing.Point(394, 59);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(2, 584);
            this.panel2.TabIndex = 26;
            // 
            // saveEditBtn
            // 
            this.saveEditBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.saveEditBtn.Image = ((System.Drawing.Image)(resources.GetObject("saveEditBtn.Image")));
            this.saveEditBtn.Location = new System.Drawing.Point(276, 610);
            this.saveEditBtn.Name = "saveEditBtn";
            this.saveEditBtn.Size = new System.Drawing.Size(36, 36);
            this.saveEditBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.saveEditBtn.TabIndex = 29;
            this.saveEditBtn.TabStop = false;
            this.saveEditBtn.Click += new System.EventHandler(this.saveEditBtn_Click);
            // 
            // EditBrandTxt
            // 
            this.EditBrandTxt.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.EditBrandTxt.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.EditBrandTxt.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.EditBrandTxt.BorderThickness = 1;
            this.EditBrandTxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.EditBrandTxt.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.EditBrandTxt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.EditBrandTxt.isPassword = false;
            this.EditBrandTxt.Location = new System.Drawing.Point(119, 559);
            this.EditBrandTxt.Margin = new System.Windows.Forms.Padding(4);
            this.EditBrandTxt.Name = "EditBrandTxt";
            this.EditBrandTxt.Size = new System.Drawing.Size(193, 44);
            this.EditBrandTxt.TabIndex = 28;
            this.EditBrandTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // BrandName
            // 
            this.BrandName.AutoSize = true;
            this.BrandName.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.BrandName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.BrandName.Location = new System.Drawing.Point(38, 569);
            this.BrandName.Name = "BrandName";
            this.BrandName.Size = new System.Drawing.Size(56, 21);
            this.BrandName.TabIndex = 27;
            this.BrandName.Text = "Brand";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.label1.Location = new System.Drawing.Point(38, 622);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 21);
            this.label1.TabIndex = 30;
            this.label1.Text = "Active";
            // 
            // ActiveCheckBox
            // 
            this.ActiveCheckBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.ActiveCheckBox.ChechedOffColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.ActiveCheckBox.Checked = false;
            this.ActiveCheckBox.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.ActiveCheckBox.ForeColor = System.Drawing.Color.White;
            this.ActiveCheckBox.Location = new System.Drawing.Point(119, 623);
            this.ActiveCheckBox.Name = "ActiveCheckBox";
            this.ActiveCheckBox.Size = new System.Drawing.Size(20, 20);
            this.ActiveCheckBox.TabIndex = 31;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.label3.Location = new System.Drawing.Point(38, 518);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 21);
            this.label3.TabIndex = 32;
            this.label3.Text = "Brand Id:";
            // 
            // bunifuSeparator1
            // 
            this.bunifuSeparator1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.bunifuSeparator1.LineThickness = 1;
            this.bunifuSeparator1.Location = new System.Drawing.Point(-15, 484);
            this.bunifuSeparator1.Name = "bunifuSeparator1";
            this.bunifuSeparator1.Size = new System.Drawing.Size(408, 15);
            this.bunifuSeparator1.TabIndex = 33;
            this.bunifuSeparator1.Transparency = 255;
            this.bunifuSeparator1.Vertical = false;
            // 
            // Id
            // 
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Visible = false;
            // 
            // Brand
            // 
            this.Brand.FillWeight = 200F;
            this.Brand.HeaderText = "Brand";
            this.Brand.Name = "Brand";
            this.Brand.ReadOnly = true;
            this.Brand.Width = 200;
            // 
            // Active
            // 
            this.Active.HeaderText = "Active";
            this.Active.Name = "Active";
            this.Active.ReadOnly = true;
            // 
            // IdTxt
            // 
            this.IdTxt.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.IdTxt.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.IdTxt.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.IdTxt.BorderThickness = 1;
            this.IdTxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.IdTxt.Enabled = false;
            this.IdTxt.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.IdTxt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.IdTxt.isPassword = false;
            this.IdTxt.Location = new System.Drawing.Point(119, 506);
            this.IdTxt.Margin = new System.Windows.Forms.Padding(4);
            this.IdTxt.Name = "IdTxt";
            this.IdTxt.Size = new System.Drawing.Size(193, 44);
            this.IdTxt.TabIndex = 34;
            this.IdTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.label4.Location = new System.Drawing.Point(152, 467);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 19);
            this.label4.TabIndex = 35;
            this.label4.Text = "Edit Brand";
            // 
            // bunifuSeparator2
            // 
            this.bunifuSeparator2.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator2.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.bunifuSeparator2.LineThickness = 1;
            this.bunifuSeparator2.Location = new System.Drawing.Point(-20, 109);
            this.bunifuSeparator2.Name = "bunifuSeparator2";
            this.bunifuSeparator2.Size = new System.Drawing.Size(408, 15);
            this.bunifuSeparator2.TabIndex = 36;
            this.bunifuSeparator2.Transparency = 255;
            this.bunifuSeparator2.Vertical = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.label5.Location = new System.Drawing.Point(25, 127);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(166, 17);
            this.label5.TabIndex = 37;
            this.label5.Text = "Show only active brands";
            // 
            // showActiveBrandsCheckBox
            // 
            this.showActiveBrandsCheckBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.showActiveBrandsCheckBox.ChechedOffColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.showActiveBrandsCheckBox.Checked = true;
            this.showActiveBrandsCheckBox.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.showActiveBrandsCheckBox.ForeColor = System.Drawing.Color.White;
            this.showActiveBrandsCheckBox.Location = new System.Drawing.Point(197, 127);
            this.showActiveBrandsCheckBox.Name = "showActiveBrandsCheckBox";
            this.showActiveBrandsCheckBox.Size = new System.Drawing.Size(20, 20);
            this.showActiveBrandsCheckBox.TabIndex = 38;
            this.showActiveBrandsCheckBox.OnChange += new System.EventHandler(this.showActiveBrandsCheckBox_OnChange);
            // 
            // Brands
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1150, 664);
            this.Controls.Add(this.showActiveBrandsCheckBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.bunifuSeparator2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.IdTxt);
            this.Controls.Add(this.bunifuSeparator1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ActiveCheckBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.saveEditBtn);
            this.Controls.Add(this.EditBrandTxt);
            this.Controls.Add(this.BrandName);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.newBrandBtn);
            this.Controls.Add(this.NewBrandTXT);
            this.Controls.Add(this.brandLbl);
            this.Controls.Add(this.BrandGrid);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Brands";
            this.Text = "Brands";
            ((System.ComponentModel.ISupportInitialize)(this.BrandGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.newBrandBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.saveEditBtn)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private Bunifu.Framework.UI.BunifuCustomDataGrid BrandGrid;
        private Bunifu.Framework.UI.BunifuMetroTextbox NewBrandTXT;
        private System.Windows.Forms.Label brandLbl;
        private System.Windows.Forms.PictureBox newBrandBtn;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator1;
        private System.Windows.Forms.Label label3;
        private Bunifu.Framework.UI.BunifuCheckbox ActiveCheckBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox saveEditBtn;
        private Bunifu.Framework.UI.BunifuMetroTextbox EditBrandTxt;
        private System.Windows.Forms.Label BrandName;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Brand;
        private System.Windows.Forms.DataGridViewTextBoxColumn Active;
        private Bunifu.Framework.UI.BunifuMetroTextbox IdTxt;
        private Bunifu.Framework.UI.BunifuCheckbox showActiveBrandsCheckBox;
        private System.Windows.Forms.Label label5;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator2;
        private System.Windows.Forms.Label label4;
    }
}