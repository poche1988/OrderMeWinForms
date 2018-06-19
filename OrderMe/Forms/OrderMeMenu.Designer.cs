namespace OrderMe.Forms
{
    partial class OrderMeMenu
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
            BunifuAnimatorNS.Animation animation1 = new BunifuAnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OrderMeMenu));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.sideMenu = new System.Windows.Forms.Panel();
            this.SupliersBtn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.BrandsBtn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.DatabaseBtn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.ProductsBtn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.OrdersBtn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.NewOrderBtn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.MenuBtn = new Bunifu.Framework.UI.BunifuImageButton();
            this.Header = new System.Windows.Forms.Panel();
            this.CloseBtn = new Bunifu.Framework.UI.BunifuImageButton();
            this.label1 = new System.Windows.Forms.Label();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.FormContainer = new System.Windows.Forms.Panel();
            this.tShow = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.sideMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MenuBtn)).BeginInit();
            this.Header.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CloseBtn)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // sideMenu
            // 
            this.sideMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.sideMenu.Controls.Add(this.SupliersBtn);
            this.sideMenu.Controls.Add(this.BrandsBtn);
            this.sideMenu.Controls.Add(this.DatabaseBtn);
            this.sideMenu.Controls.Add(this.ProductsBtn);
            this.sideMenu.Controls.Add(this.OrdersBtn);
            this.sideMenu.Controls.Add(this.NewOrderBtn);
            this.sideMenu.Controls.Add(this.MenuBtn);
            this.tShow.SetDecoration(this.sideMenu, BunifuAnimatorNS.DecorationType.None);
            this.sideMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.sideMenu.Location = new System.Drawing.Point(0, 36);
            this.sideMenu.Name = "sideMenu";
            this.sideMenu.Size = new System.Drawing.Size(50, 664);
            this.sideMenu.TabIndex = 0;
            // 
            // SupliersBtn
            // 
            this.SupliersBtn.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.SupliersBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.SupliersBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.SupliersBtn.BorderRadius = 0;
            this.SupliersBtn.ButtonText = "        Suppliers";
            this.SupliersBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tShow.SetDecoration(this.SupliersBtn, BunifuAnimatorNS.DecorationType.None);
            this.SupliersBtn.DisabledColor = System.Drawing.Color.Gray;
            this.SupliersBtn.Iconcolor = System.Drawing.Color.Transparent;
            this.SupliersBtn.Iconimage = ((System.Drawing.Image)(resources.GetObject("SupliersBtn.Iconimage")));
            this.SupliersBtn.Iconimage_right = null;
            this.SupliersBtn.Iconimage_right_Selected = null;
            this.SupliersBtn.Iconimage_Selected = null;
            this.SupliersBtn.IconMarginLeft = 0;
            this.SupliersBtn.IconMarginRight = 0;
            this.SupliersBtn.IconRightVisible = true;
            this.SupliersBtn.IconRightZoom = 0D;
            this.SupliersBtn.IconVisible = true;
            this.SupliersBtn.IconZoom = 60D;
            this.SupliersBtn.IsTab = true;
            this.SupliersBtn.Location = new System.Drawing.Point(0, 236);
            this.SupliersBtn.Name = "SupliersBtn";
            this.SupliersBtn.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.SupliersBtn.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.SupliersBtn.OnHoverTextColor = System.Drawing.Color.White;
            this.SupliersBtn.selected = false;
            this.SupliersBtn.Size = new System.Drawing.Size(200, 50);
            this.SupliersBtn.TabIndex = 6;
            this.SupliersBtn.Text = "        Suppliers";
            this.SupliersBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SupliersBtn.Textcolor = System.Drawing.Color.Silver;
            this.SupliersBtn.TextFont = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // BrandsBtn
            // 
            this.BrandsBtn.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.BrandsBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.BrandsBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BrandsBtn.BorderRadius = 0;
            this.BrandsBtn.ButtonText = "         Brands";
            this.BrandsBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tShow.SetDecoration(this.BrandsBtn, BunifuAnimatorNS.DecorationType.None);
            this.BrandsBtn.DisabledColor = System.Drawing.Color.Gray;
            this.BrandsBtn.Iconcolor = System.Drawing.Color.Transparent;
            this.BrandsBtn.Iconimage = ((System.Drawing.Image)(resources.GetObject("BrandsBtn.Iconimage")));
            this.BrandsBtn.Iconimage_right = null;
            this.BrandsBtn.Iconimage_right_Selected = null;
            this.BrandsBtn.Iconimage_Selected = null;
            this.BrandsBtn.IconMarginLeft = 0;
            this.BrandsBtn.IconMarginRight = 0;
            this.BrandsBtn.IconRightVisible = true;
            this.BrandsBtn.IconRightZoom = 0D;
            this.BrandsBtn.IconVisible = true;
            this.BrandsBtn.IconZoom = 55D;
            this.BrandsBtn.IsTab = true;
            this.BrandsBtn.Location = new System.Drawing.Point(0, 189);
            this.BrandsBtn.Name = "BrandsBtn";
            this.BrandsBtn.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.BrandsBtn.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.BrandsBtn.OnHoverTextColor = System.Drawing.Color.White;
            this.BrandsBtn.selected = false;
            this.BrandsBtn.Size = new System.Drawing.Size(200, 50);
            this.BrandsBtn.TabIndex = 5;
            this.BrandsBtn.Text = "         Brands";
            this.BrandsBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BrandsBtn.Textcolor = System.Drawing.Color.Silver;
            this.BrandsBtn.TextFont = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BrandsBtn.Click += new System.EventHandler(this.BrandsBtn_Click);
            // 
            // DatabaseBtn
            // 
            this.DatabaseBtn.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.DatabaseBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.DatabaseBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.DatabaseBtn.BorderRadius = 0;
            this.DatabaseBtn.ButtonText = "        Database";
            this.DatabaseBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tShow.SetDecoration(this.DatabaseBtn, BunifuAnimatorNS.DecorationType.None);
            this.DatabaseBtn.DisabledColor = System.Drawing.Color.Gray;
            this.DatabaseBtn.Iconcolor = System.Drawing.Color.Transparent;
            this.DatabaseBtn.Iconimage = ((System.Drawing.Image)(resources.GetObject("DatabaseBtn.Iconimage")));
            this.DatabaseBtn.Iconimage_right = null;
            this.DatabaseBtn.Iconimage_right_Selected = null;
            this.DatabaseBtn.Iconimage_Selected = null;
            this.DatabaseBtn.IconMarginLeft = 0;
            this.DatabaseBtn.IconMarginRight = 0;
            this.DatabaseBtn.IconRightVisible = true;
            this.DatabaseBtn.IconRightZoom = 0D;
            this.DatabaseBtn.IconVisible = true;
            this.DatabaseBtn.IconZoom = 60D;
            this.DatabaseBtn.IsTab = true;
            this.DatabaseBtn.Location = new System.Drawing.Point(0, 283);
            this.DatabaseBtn.Name = "DatabaseBtn";
            this.DatabaseBtn.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.DatabaseBtn.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.DatabaseBtn.OnHoverTextColor = System.Drawing.Color.White;
            this.DatabaseBtn.selected = false;
            this.DatabaseBtn.Size = new System.Drawing.Size(200, 50);
            this.DatabaseBtn.TabIndex = 4;
            this.DatabaseBtn.Text = "        Database";
            this.DatabaseBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.DatabaseBtn.Textcolor = System.Drawing.Color.Silver;
            this.DatabaseBtn.TextFont = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DatabaseBtn.Click += new System.EventHandler(this.DatabaseBtn_Click);
            // 
            // ProductsBtn
            // 
            this.ProductsBtn.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.ProductsBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.ProductsBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ProductsBtn.BorderRadius = 0;
            this.ProductsBtn.ButtonText = "        Products";
            this.ProductsBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tShow.SetDecoration(this.ProductsBtn, BunifuAnimatorNS.DecorationType.None);
            this.ProductsBtn.DisabledColor = System.Drawing.Color.Gray;
            this.ProductsBtn.Iconcolor = System.Drawing.Color.Transparent;
            this.ProductsBtn.Iconimage = ((System.Drawing.Image)(resources.GetObject("ProductsBtn.Iconimage")));
            this.ProductsBtn.Iconimage_right = null;
            this.ProductsBtn.Iconimage_right_Selected = null;
            this.ProductsBtn.Iconimage_Selected = null;
            this.ProductsBtn.IconMarginLeft = 0;
            this.ProductsBtn.IconMarginRight = 0;
            this.ProductsBtn.IconRightVisible = true;
            this.ProductsBtn.IconRightZoom = 0D;
            this.ProductsBtn.IconVisible = true;
            this.ProductsBtn.IconZoom = 60D;
            this.ProductsBtn.IsTab = true;
            this.ProductsBtn.Location = new System.Drawing.Point(0, 142);
            this.ProductsBtn.Name = "ProductsBtn";
            this.ProductsBtn.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.ProductsBtn.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.ProductsBtn.OnHoverTextColor = System.Drawing.Color.White;
            this.ProductsBtn.selected = false;
            this.ProductsBtn.Size = new System.Drawing.Size(200, 50);
            this.ProductsBtn.TabIndex = 3;
            this.ProductsBtn.Text = "        Products";
            this.ProductsBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ProductsBtn.Textcolor = System.Drawing.Color.Silver;
            this.ProductsBtn.TextFont = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductsBtn.Click += new System.EventHandler(this.ProductsBtn_Click);
            // 
            // OrdersBtn
            // 
            this.OrdersBtn.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.OrdersBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.OrdersBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.OrdersBtn.BorderRadius = 0;
            this.OrdersBtn.ButtonText = "        Orders";
            this.OrdersBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tShow.SetDecoration(this.OrdersBtn, BunifuAnimatorNS.DecorationType.None);
            this.OrdersBtn.DisabledColor = System.Drawing.Color.Gray;
            this.OrdersBtn.Iconcolor = System.Drawing.Color.Transparent;
            this.OrdersBtn.Iconimage = ((System.Drawing.Image)(resources.GetObject("OrdersBtn.Iconimage")));
            this.OrdersBtn.Iconimage_right = null;
            this.OrdersBtn.Iconimage_right_Selected = null;
            this.OrdersBtn.Iconimage_Selected = null;
            this.OrdersBtn.IconMarginLeft = 0;
            this.OrdersBtn.IconMarginRight = 0;
            this.OrdersBtn.IconRightVisible = true;
            this.OrdersBtn.IconRightZoom = 0D;
            this.OrdersBtn.IconVisible = true;
            this.OrdersBtn.IconZoom = 60D;
            this.OrdersBtn.IsTab = true;
            this.OrdersBtn.Location = new System.Drawing.Point(0, 95);
            this.OrdersBtn.Name = "OrdersBtn";
            this.OrdersBtn.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.OrdersBtn.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.OrdersBtn.OnHoverTextColor = System.Drawing.Color.White;
            this.OrdersBtn.selected = false;
            this.OrdersBtn.Size = new System.Drawing.Size(200, 50);
            this.OrdersBtn.TabIndex = 2;
            this.OrdersBtn.Text = "        Orders";
            this.OrdersBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.OrdersBtn.Textcolor = System.Drawing.Color.Silver;
            this.OrdersBtn.TextFont = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OrdersBtn.Click += new System.EventHandler(this.OrdersBtn_Click);
            // 
            // NewOrderBtn
            // 
            this.NewOrderBtn.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.NewOrderBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.NewOrderBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.NewOrderBtn.BorderRadius = 0;
            this.NewOrderBtn.ButtonText = "        New Order";
            this.NewOrderBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tShow.SetDecoration(this.NewOrderBtn, BunifuAnimatorNS.DecorationType.None);
            this.NewOrderBtn.DisabledColor = System.Drawing.Color.Gray;
            this.NewOrderBtn.Iconcolor = System.Drawing.Color.Transparent;
            this.NewOrderBtn.Iconimage = ((System.Drawing.Image)(resources.GetObject("NewOrderBtn.Iconimage")));
            this.NewOrderBtn.Iconimage_right = null;
            this.NewOrderBtn.Iconimage_right_Selected = null;
            this.NewOrderBtn.Iconimage_Selected = null;
            this.NewOrderBtn.IconMarginLeft = 0;
            this.NewOrderBtn.IconMarginRight = 0;
            this.NewOrderBtn.IconRightVisible = true;
            this.NewOrderBtn.IconRightZoom = 0D;
            this.NewOrderBtn.IconVisible = true;
            this.NewOrderBtn.IconZoom = 60D;
            this.NewOrderBtn.IsTab = true;
            this.NewOrderBtn.Location = new System.Drawing.Point(0, 48);
            this.NewOrderBtn.Name = "NewOrderBtn";
            this.NewOrderBtn.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.NewOrderBtn.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.NewOrderBtn.OnHoverTextColor = System.Drawing.Color.White;
            this.NewOrderBtn.selected = true;
            this.NewOrderBtn.Size = new System.Drawing.Size(200, 50);
            this.NewOrderBtn.TabIndex = 1;
            this.NewOrderBtn.Text = "        New Order";
            this.NewOrderBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.NewOrderBtn.Textcolor = System.Drawing.Color.Silver;
            this.NewOrderBtn.TextFont = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewOrderBtn.Click += new System.EventHandler(this.NewOrderBtn_Click);
            // 
            // MenuBtn
            // 
            this.MenuBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.MenuBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tShow.SetDecoration(this.MenuBtn, BunifuAnimatorNS.DecorationType.None);
            this.MenuBtn.Image = ((System.Drawing.Image)(resources.GetObject("MenuBtn.Image")));
            this.MenuBtn.ImageActive = null;
            this.MenuBtn.Location = new System.Drawing.Point(12, 6);
            this.MenuBtn.Name = "MenuBtn";
            this.MenuBtn.Size = new System.Drawing.Size(27, 24);
            this.MenuBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.MenuBtn.TabIndex = 0;
            this.MenuBtn.TabStop = false;
            this.MenuBtn.Zoom = 10;
            this.MenuBtn.Click += new System.EventHandler(this.MenuBtn_Click);
            // 
            // Header
            // 
            this.Header.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.Header.Controls.Add(this.CloseBtn);
            this.Header.Controls.Add(this.label1);
            this.tShow.SetDecoration(this.Header, BunifuAnimatorNS.DecorationType.None);
            this.Header.Dock = System.Windows.Forms.DockStyle.Top;
            this.Header.Location = new System.Drawing.Point(0, 0);
            this.Header.Name = "Header";
            this.Header.Size = new System.Drawing.Size(1200, 36);
            this.Header.TabIndex = 1;
            // 
            // CloseBtn
            // 
            this.CloseBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CloseBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.CloseBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tShow.SetDecoration(this.CloseBtn, BunifuAnimatorNS.DecorationType.None);
            this.CloseBtn.Image = ((System.Drawing.Image)(resources.GetObject("CloseBtn.Image")));
            this.CloseBtn.ImageActive = null;
            this.CloseBtn.Location = new System.Drawing.Point(1173, 9);
            this.CloseBtn.Name = "CloseBtn";
            this.CloseBtn.Size = new System.Drawing.Size(15, 15);
            this.CloseBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.CloseBtn.TabIndex = 2;
            this.CloseBtn.TabStop = false;
            this.CloseBtn.Zoom = 10;
            this.CloseBtn.Click += new System.EventHandler(this.CloseBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.tShow.SetDecoration(this.label1, BunifuAnimatorNS.DecorationType.None);
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(216)))), ((int)(((byte)(255)))));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(207, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Order Me - Otis and Louie";
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.Header;
            this.bunifuDragControl1.Vertical = true;
            // 
            // FormContainer
            // 
            this.FormContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.tShow.SetDecoration(this.FormContainer, BunifuAnimatorNS.DecorationType.None);
            this.FormContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FormContainer.Location = new System.Drawing.Point(50, 36);
            this.FormContainer.Name = "FormContainer";
            this.FormContainer.Size = new System.Drawing.Size(1150, 664);
            this.FormContainer.TabIndex = 2;
            // 
            // tShow
            // 
            this.tShow.AnimationType = BunifuAnimatorNS.AnimationType.HorizSlide;
            this.tShow.Cursor = null;
            animation1.AnimateOnlyDifferences = true;
            animation1.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.BlindCoeff")));
            animation1.LeafCoeff = 0F;
            animation1.MaxTime = 1F;
            animation1.MinTime = 0F;
            animation1.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicCoeff")));
            animation1.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicShift")));
            animation1.MosaicSize = 0;
            animation1.Padding = new System.Windows.Forms.Padding(0);
            animation1.RotateCoeff = 0F;
            animation1.RotateLimit = 0F;
            animation1.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.ScaleCoeff")));
            animation1.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.SlideCoeff")));
            animation1.TimeCoeff = 0F;
            animation1.TransparencyCoeff = 0F;
            this.tShow.DefaultAnimation = animation1;
            // 
            // OrderMeMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.ClientSize = new System.Drawing.Size(1200, 700);
            this.Controls.Add(this.FormContainer);
            this.Controls.Add(this.sideMenu);
            this.Controls.Add(this.Header);
            this.tShow.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "OrderMeMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OrderMeMenu";
            this.sideMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.MenuBtn)).EndInit();
            this.Header.ResumeLayout(false);
            this.Header.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CloseBtn)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Panel sideMenu;
        private Bunifu.Framework.UI.BunifuImageButton CloseBtn;
        private Bunifu.Framework.UI.BunifuFlatButton NewOrderBtn;
        private Bunifu.Framework.UI.BunifuImageButton MenuBtn;
        private System.Windows.Forms.Panel Header;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private Bunifu.Framework.UI.BunifuFlatButton ProductsBtn;
        private Bunifu.Framework.UI.BunifuFlatButton OrdersBtn;
        private BunifuAnimatorNS.BunifuTransition tShow;
        public System.Windows.Forms.Panel FormContainer;
        private Bunifu.Framework.UI.BunifuFlatButton DatabaseBtn;
        private Bunifu.Framework.UI.BunifuFlatButton BrandsBtn;
        private Bunifu.Framework.UI.BunifuFlatButton SupliersBtn;
    }
}