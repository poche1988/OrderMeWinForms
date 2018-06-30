namespace OrderMe.Forms
{
    partial class Suppliers
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Suppliers));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.label6 = new System.Windows.Forms.Label();
            this.bunifuSeparator3 = new Bunifu.Framework.UI.BunifuSeparator();
            this.showActiveSuppCheckBox = new Bunifu.Framework.UI.BunifuCheckbox();
            this.label5 = new System.Windows.Forms.Label();
            this.bunifuSeparator2 = new Bunifu.Framework.UI.BunifuSeparator();
            this.label4 = new System.Windows.Forms.Label();
            this.NameTxt = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.bunifuSeparator1 = new Bunifu.Framework.UI.BunifuSeparator();
            this.label3 = new System.Windows.Forms.Label();
            this.ActiveCheckBox = new Bunifu.Framework.UI.BunifuCheckbox();
            this.label1 = new System.Windows.Forms.Label();
            this.saveEditBtn = new System.Windows.Forms.PictureBox();
            this.EmailTxt = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.BrandName = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.newSuppBtn = new System.Windows.Forms.PictureBox();
            this.NewSuppTXT = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.brandLbl = new System.Windows.Forms.Label();
            this.SuppGrid = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SupplierName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Active = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.newEmailTxt = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.saveEditBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.newSuppBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SuppGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.label6.Location = new System.Drawing.Point(569, 87);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 19);
            this.label6.TabIndex = 61;
            this.label6.Text = "Products";
            // 
            // bunifuSeparator3
            // 
            this.bunifuSeparator3.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator3.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.bunifuSeparator3.LineThickness = 1;
            this.bunifuSeparator3.Location = new System.Drawing.Point(553, 109);
            this.bunifuSeparator3.Name = "bunifuSeparator3";
            this.bunifuSeparator3.Size = new System.Drawing.Size(612, 15);
            this.bunifuSeparator3.TabIndex = 60;
            this.bunifuSeparator3.Transparency = 255;
            this.bunifuSeparator3.Vertical = false;
            // 
            // showActiveSuppCheckBox
            // 
            this.showActiveSuppCheckBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.showActiveSuppCheckBox.ChechedOffColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.showActiveSuppCheckBox.Checked = true;
            this.showActiveSuppCheckBox.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.showActiveSuppCheckBox.ForeColor = System.Drawing.Color.White;
            this.showActiveSuppCheckBox.Location = new System.Drawing.Point(212, 179);
            this.showActiveSuppCheckBox.Name = "showActiveSuppCheckBox";
            this.showActiveSuppCheckBox.Size = new System.Drawing.Size(20, 20);
            this.showActiveSuppCheckBox.TabIndex = 59;
            this.showActiveSuppCheckBox.OnChange += new System.EventHandler(this.showActiveSuppCheckBox_OnChange);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.label5.Location = new System.Drawing.Point(30, 179);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(176, 17);
            this.label5.TabIndex = 58;
            this.label5.Text = "Show only active suppliers";
            // 
            // bunifuSeparator2
            // 
            this.bunifuSeparator2.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator2.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.bunifuSeparator2.LineThickness = 1;
            this.bunifuSeparator2.Location = new System.Drawing.Point(-15, 161);
            this.bunifuSeparator2.Name = "bunifuSeparator2";
            this.bunifuSeparator2.Size = new System.Drawing.Size(537, 15);
            this.bunifuSeparator2.TabIndex = 57;
            this.bunifuSeparator2.Transparency = 255;
            this.bunifuSeparator2.Vertical = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.label4.Location = new System.Drawing.Point(152, 467);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 19);
            this.label4.TabIndex = 56;
            this.label4.Text = "Edit Supplier";
            // 
            // NameTxt
            // 
            this.NameTxt.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.NameTxt.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.NameTxt.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.NameTxt.BorderThickness = 1;
            this.NameTxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.NameTxt.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.NameTxt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.NameTxt.isPassword = false;
            this.NameTxt.Location = new System.Drawing.Point(119, 506);
            this.NameTxt.Margin = new System.Windows.Forms.Padding(4);
            this.NameTxt.Name = "NameTxt";
            this.NameTxt.Size = new System.Drawing.Size(308, 44);
            this.NameTxt.TabIndex = 3;
            this.NameTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // bunifuSeparator1
            // 
            this.bunifuSeparator1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.bunifuSeparator1.LineThickness = 1;
            this.bunifuSeparator1.Location = new System.Drawing.Point(-15, 484);
            this.bunifuSeparator1.Name = "bunifuSeparator1";
            this.bunifuSeparator1.Size = new System.Drawing.Size(520, 15);
            this.bunifuSeparator1.TabIndex = 54;
            this.bunifuSeparator1.Transparency = 255;
            this.bunifuSeparator1.Vertical = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.label3.Location = new System.Drawing.Point(38, 518);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 21);
            this.label3.TabIndex = 53;
            this.label3.Text = "Name:";
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
            this.ActiveCheckBox.TabIndex = 52;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.label1.Location = new System.Drawing.Point(38, 622);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 21);
            this.label1.TabIndex = 51;
            this.label1.Text = "Active";
            // 
            // saveEditBtn
            // 
            this.saveEditBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.saveEditBtn.Image = ((System.Drawing.Image)(resources.GetObject("saveEditBtn.Image")));
            this.saveEditBtn.Location = new System.Drawing.Point(391, 610);
            this.saveEditBtn.Name = "saveEditBtn";
            this.saveEditBtn.Size = new System.Drawing.Size(36, 36);
            this.saveEditBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.saveEditBtn.TabIndex = 50;
            this.saveEditBtn.TabStop = false;
            this.saveEditBtn.Click += new System.EventHandler(this.saveEditBtn_Click);
            // 
            // EmailTxt
            // 
            this.EmailTxt.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.EmailTxt.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.EmailTxt.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.EmailTxt.BorderThickness = 1;
            this.EmailTxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.EmailTxt.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.EmailTxt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.EmailTxt.isPassword = false;
            this.EmailTxt.Location = new System.Drawing.Point(119, 559);
            this.EmailTxt.Margin = new System.Windows.Forms.Padding(4);
            this.EmailTxt.Name = "EmailTxt";
            this.EmailTxt.Size = new System.Drawing.Size(308, 44);
            this.EmailTxt.TabIndex = 4;
            this.EmailTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // BrandName
            // 
            this.BrandName.AutoSize = true;
            this.BrandName.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.BrandName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.BrandName.Location = new System.Drawing.Point(38, 569);
            this.BrandName.Name = "BrandName";
            this.BrandName.Size = new System.Drawing.Size(55, 21);
            this.BrandName.TabIndex = 48;
            this.BrandName.Text = "Email:";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.panel2.Location = new System.Drawing.Point(534, 58);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(2, 584);
            this.panel2.TabIndex = 47;
            // 
            // newSuppBtn
            // 
            this.newSuppBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.newSuppBtn.Image = ((System.Drawing.Image)(resources.GetObject("newSuppBtn.Image")));
            this.newSuppBtn.Location = new System.Drawing.Point(342, 109);
            this.newSuppBtn.Name = "newSuppBtn";
            this.newSuppBtn.Size = new System.Drawing.Size(44, 44);
            this.newSuppBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.newSuppBtn.TabIndex = 46;
            this.newSuppBtn.TabStop = false;
            this.newSuppBtn.Click += new System.EventHandler(this.newSuppBtn_Click);
            // 
            // NewSuppTXT
            // 
            this.NewSuppTXT.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.NewSuppTXT.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.NewSuppTXT.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.NewSuppTXT.BorderThickness = 1;
            this.NewSuppTXT.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.NewSuppTXT.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.NewSuppTXT.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.NewSuppTXT.isPassword = false;
            this.NewSuppTXT.Location = new System.Drawing.Point(142, 58);
            this.NewSuppTXT.Margin = new System.Windows.Forms.Padding(4);
            this.NewSuppTXT.Name = "NewSuppTXT";
            this.NewSuppTXT.Size = new System.Drawing.Size(193, 44);
            this.NewSuppTXT.TabIndex = 1;
            this.NewSuppTXT.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // brandLbl
            // 
            this.brandLbl.AutoSize = true;
            this.brandLbl.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.brandLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.brandLbl.Location = new System.Drawing.Point(24, 69);
            this.brandLbl.Name = "brandLbl";
            this.brandLbl.Size = new System.Drawing.Size(111, 21);
            this.brandLbl.TabIndex = 44;
            this.brandLbl.Text = "New Supplier";
            // 
            // SuppGrid
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.SuppGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.SuppGrid.BackgroundColor = System.Drawing.SystemColors.Control;
            this.SuppGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.SuppGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 12F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.SuppGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.SuppGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SuppGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.SupplierName,
            this.Email,
            this.Active});
            this.SuppGrid.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.SuppGrid.DefaultCellStyle = dataGridViewCellStyle3;
            this.SuppGrid.DoubleBuffered = true;
            this.SuppGrid.EnableHeadersVisualStyles = false;
            this.SuppGrid.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.SuppGrid.HeaderForeColor = System.Drawing.Color.White;
            this.SuppGrid.Location = new System.Drawing.Point(26, 202);
            this.SuppGrid.Name = "SuppGrid";
            this.SuppGrid.ReadOnly = true;
            this.SuppGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.SuppGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.SuppGrid.Size = new System.Drawing.Size(467, 262);
            this.SuppGrid.TabIndex = 43;
            this.SuppGrid.SelectionChanged += new System.EventHandler(this.SuppGrid_SelectionChanged);
            // 
            // Id
            // 
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Visible = false;
            // 
            // SupplierName
            // 
            this.SupplierName.FillWeight = 120F;
            this.SupplierName.HeaderText = "Supplier";
            this.SupplierName.Name = "SupplierName";
            this.SupplierName.ReadOnly = true;
            this.SupplierName.Width = 120;
            // 
            // Email
            // 
            this.Email.FillWeight = 180F;
            this.Email.HeaderText = "Email";
            this.Email.Name = "Email";
            this.Email.ReadOnly = true;
            this.Email.Width = 180;
            // 
            // Active
            // 
            this.Active.HeaderText = "Active";
            this.Active.Name = "Active";
            this.Active.ReadOnly = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.panel1.Location = new System.Drawing.Point(12, 34);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(950, 2);
            this.panel1.TabIndex = 42;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 14F);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.label2.Location = new System.Drawing.Point(22, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 22);
            this.label2.TabIndex = 41;
            this.label2.Text = "Suppliers";
            // 
            // newEmailTxt
            // 
            this.newEmailTxt.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.newEmailTxt.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.newEmailTxt.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.newEmailTxt.BorderThickness = 1;
            this.newEmailTxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.newEmailTxt.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.newEmailTxt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.newEmailTxt.isPassword = false;
            this.newEmailTxt.Location = new System.Drawing.Point(142, 109);
            this.newEmailTxt.Margin = new System.Windows.Forms.Padding(4);
            this.newEmailTxt.Name = "newEmailTxt";
            this.newEmailTxt.Size = new System.Drawing.Size(193, 44);
            this.newEmailTxt.TabIndex = 2;
            this.newEmailTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.label7.Location = new System.Drawing.Point(22, 122);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(111, 21);
            this.label7.TabIndex = 63;
            this.label7.Text = "               Email";
            // 
            // Suppliers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1150, 664);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.newEmailTxt);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.bunifuSeparator3);
            this.Controls.Add(this.showActiveSuppCheckBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.bunifuSeparator2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.NameTxt);
            this.Controls.Add(this.bunifuSeparator1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ActiveCheckBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.saveEditBtn);
            this.Controls.Add(this.EmailTxt);
            this.Controls.Add(this.BrandName);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.newSuppBtn);
            this.Controls.Add(this.NewSuppTXT);
            this.Controls.Add(this.brandLbl);
            this.Controls.Add(this.SuppGrid);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Suppliers";
            this.Text = "Suppliers";
            ((System.ComponentModel.ISupportInitialize)(this.saveEditBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.newSuppBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SuppGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Label label6;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator3;
        private Bunifu.Framework.UI.BunifuCheckbox showActiveSuppCheckBox;
        private System.Windows.Forms.Label label5;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator2;
        private System.Windows.Forms.Label label4;
        private Bunifu.Framework.UI.BunifuMetroTextbox NameTxt;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator1;
        private System.Windows.Forms.Label label3;
        private Bunifu.Framework.UI.BunifuCheckbox ActiveCheckBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox saveEditBtn;
        private Bunifu.Framework.UI.BunifuMetroTextbox EmailTxt;
        private System.Windows.Forms.Label BrandName;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox newSuppBtn;
        private Bunifu.Framework.UI.BunifuMetroTextbox NewSuppTXT;
        private System.Windows.Forms.Label brandLbl;
        private Bunifu.Framework.UI.BunifuCustomDataGrid SuppGrid;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private Bunifu.Framework.UI.BunifuMetroTextbox newEmailTxt;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn SupplierName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn Active;
    }
}