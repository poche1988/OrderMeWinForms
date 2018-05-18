namespace OrderMe.Forms
{
    partial class Database
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Database));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.BackUpBtn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.CreateProductsBackUpBtn = new Bunifu.Framework.UI.BunifuFlatButton();
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
            this.panel1.Location = new System.Drawing.Point(2, 34);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(950, 2);
            this.panel1.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(195, 22);
            this.label1.TabIndex = 3;
            this.label1.Text = "Database Order Me";
            // 
            // BackUpBtn
            // 
            this.BackUpBtn.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.BackUpBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.BackUpBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BackUpBtn.BorderRadius = 0;
            this.BackUpBtn.ButtonText = "Create Back Up of Orders";
            this.BackUpBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BackUpBtn.DisabledColor = System.Drawing.Color.Gray;
            this.BackUpBtn.Iconcolor = System.Drawing.Color.Transparent;
            this.BackUpBtn.Iconimage = ((System.Drawing.Image)(resources.GetObject("BackUpBtn.Iconimage")));
            this.BackUpBtn.Iconimage_right = null;
            this.BackUpBtn.Iconimage_right_Selected = null;
            this.BackUpBtn.Iconimage_Selected = null;
            this.BackUpBtn.IconMarginLeft = 0;
            this.BackUpBtn.IconMarginRight = 0;
            this.BackUpBtn.IconRightVisible = true;
            this.BackUpBtn.IconRightZoom = 0D;
            this.BackUpBtn.IconVisible = true;
            this.BackUpBtn.IconZoom = 90D;
            this.BackUpBtn.IsTab = false;
            this.BackUpBtn.Location = new System.Drawing.Point(16, 148);
            this.BackUpBtn.Name = "BackUpBtn";
            this.BackUpBtn.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.BackUpBtn.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.BackUpBtn.OnHoverTextColor = System.Drawing.Color.White;
            this.BackUpBtn.selected = false;
            this.BackUpBtn.Size = new System.Drawing.Size(270, 48);
            this.BackUpBtn.TabIndex = 16;
            this.BackUpBtn.Text = "Create Back Up of Orders";
            this.BackUpBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BackUpBtn.Textcolor = System.Drawing.Color.White;
            this.BackUpBtn.TextFont = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BackUpBtn.Click += new System.EventHandler(this.BackUpBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.label2.Location = new System.Drawing.Point(12, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(313, 21);
            this.label2.TabIndex = 17;
            this.label2.Text = "* The back ups are created as CSV files.";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.label3.Location = new System.Drawing.Point(12, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(229, 21);
            this.label3.TabIndex = 18;
            this.label3.Text = "* Files Directory: C:\\OrderMe";
            // 
            // CreateProductsBackUpBtn
            // 
            this.CreateProductsBackUpBtn.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.CreateProductsBackUpBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.CreateProductsBackUpBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CreateProductsBackUpBtn.BorderRadius = 0;
            this.CreateProductsBackUpBtn.ButtonText = "Create Back Up of Products";
            this.CreateProductsBackUpBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CreateProductsBackUpBtn.DisabledColor = System.Drawing.Color.Gray;
            this.CreateProductsBackUpBtn.Iconcolor = System.Drawing.Color.Transparent;
            this.CreateProductsBackUpBtn.Iconimage = ((System.Drawing.Image)(resources.GetObject("CreateProductsBackUpBtn.Iconimage")));
            this.CreateProductsBackUpBtn.Iconimage_right = null;
            this.CreateProductsBackUpBtn.Iconimage_right_Selected = null;
            this.CreateProductsBackUpBtn.Iconimage_Selected = null;
            this.CreateProductsBackUpBtn.IconMarginLeft = 0;
            this.CreateProductsBackUpBtn.IconMarginRight = 0;
            this.CreateProductsBackUpBtn.IconRightVisible = true;
            this.CreateProductsBackUpBtn.IconRightZoom = 0D;
            this.CreateProductsBackUpBtn.IconVisible = true;
            this.CreateProductsBackUpBtn.IconZoom = 90D;
            this.CreateProductsBackUpBtn.IsTab = false;
            this.CreateProductsBackUpBtn.Location = new System.Drawing.Point(16, 220);
            this.CreateProductsBackUpBtn.Name = "CreateProductsBackUpBtn";
            this.CreateProductsBackUpBtn.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.CreateProductsBackUpBtn.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.CreateProductsBackUpBtn.OnHoverTextColor = System.Drawing.Color.White;
            this.CreateProductsBackUpBtn.selected = false;
            this.CreateProductsBackUpBtn.Size = new System.Drawing.Size(270, 48);
            this.CreateProductsBackUpBtn.TabIndex = 19;
            this.CreateProductsBackUpBtn.Text = "Create Back Up of Products";
            this.CreateProductsBackUpBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.CreateProductsBackUpBtn.Textcolor = System.Drawing.Color.White;
            this.CreateProductsBackUpBtn.TextFont = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CreateProductsBackUpBtn.Click += new System.EventHandler(this.CreateProductsBackUpBtn_Click);
            // 
            // Database
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1150, 664);
            this.Controls.Add(this.CreateProductsBackUpBtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BackUpBtn);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Database";
            this.Text = "Database";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private Bunifu.Framework.UI.BunifuFlatButton BackUpBtn;
        private Bunifu.Framework.UI.BunifuFlatButton CreateProductsBackUpBtn;
    }
}