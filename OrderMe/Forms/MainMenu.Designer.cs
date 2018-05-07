using System.Windows.Forms;

namespace OrderMe.Forms
{
    partial class MainMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenu));
            BunifuAnimatorNS.Animation animation2 = new BunifuAnimatorNS.Animation();
            BunifuAnimatorNS.Animation animation1 = new BunifuAnimatorNS.Animation();
            this.Drawer = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.closeBtn = new Bunifu.Framework.UI.BunifuImageButton();
            this.MenuBtn = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuFormFadeTransition1 = new Bunifu.Framework.UI.BunifuFormFadeTransition(this.components);
            this.tShow = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.tHide = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.OrdersBtn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.ProductsBtn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.NewOrderBtn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.Drawer.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.closeBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MenuBtn)).BeginInit();
            this.SuspendLayout();
            // 
            // Drawer
            // 
            this.Drawer.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Drawer.BackgroundImage")));
            this.Drawer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Drawer.Controls.Add(this.NewOrderBtn);
            this.Drawer.Controls.Add(this.ProductsBtn);
            this.Drawer.Controls.Add(this.OrdersBtn);
            this.tHide.SetDecoration(this.Drawer, BunifuAnimatorNS.DecorationType.None);
            this.tShow.SetDecoration(this.Drawer, BunifuAnimatorNS.DecorationType.None);
            this.Drawer.Dock = System.Windows.Forms.DockStyle.Left;
            this.Drawer.GradientBottomLeft = System.Drawing.Color.Crimson;
            this.Drawer.GradientBottomRight = System.Drawing.Color.Crimson;
            this.Drawer.GradientTopLeft = System.Drawing.Color.Crimson;
            this.Drawer.GradientTopRight = System.Drawing.Color.Crimson;
            this.Drawer.Location = new System.Drawing.Point(0, 0);
            this.Drawer.Name = "Drawer";
            this.Drawer.Quality = 10;
            this.Drawer.Size = new System.Drawing.Size(221, 860);
            this.Drawer.TabIndex = 5;
            this.Drawer.Visible = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Crimson;
            this.panel1.Controls.Add(this.bunifuCustomLabel1);
            this.panel1.Controls.Add(this.closeBtn);
            this.panel1.Controls.Add(this.MenuBtn);
            this.tHide.SetDecoration(this.panel1, BunifuAnimatorNS.DecorationType.None);
            this.tShow.SetDecoration(this.panel1, BunifuAnimatorNS.DecorationType.None);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(221, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1219, 42);
            this.panel1.TabIndex = 6;
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.BackColor = System.Drawing.Color.Transparent;
            this.tShow.SetDecoration(this.bunifuCustomLabel1, BunifuAnimatorNS.DecorationType.None);
            this.tHide.SetDecoration(this.bunifuCustomLabel1, BunifuAnimatorNS.DecorationType.None);
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Lucida Sans", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(48, 9);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(106, 24);
            this.bunifuCustomLabel1.TabIndex = 8;
            this.bunifuCustomLabel1.Text = "Order Me";
            // 
            // closeBtn
            // 
            this.closeBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.closeBtn.BackColor = System.Drawing.Color.Transparent;
            this.closeBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tHide.SetDecoration(this.closeBtn, BunifuAnimatorNS.DecorationType.None);
            this.tShow.SetDecoration(this.closeBtn, BunifuAnimatorNS.DecorationType.None);
            this.closeBtn.Image = ((System.Drawing.Image)(resources.GetObject("closeBtn.Image")));
            this.closeBtn.ImageActive = null;
            this.closeBtn.Location = new System.Drawing.Point(1191, 9);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(25, 19);
            this.closeBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.closeBtn.TabIndex = 1;
            this.closeBtn.TabStop = false;
            this.closeBtn.Zoom = 10;
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
            // 
            // MenuBtn
            // 
            this.MenuBtn.BackColor = System.Drawing.Color.Transparent;
            this.MenuBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tHide.SetDecoration(this.MenuBtn, BunifuAnimatorNS.DecorationType.None);
            this.tShow.SetDecoration(this.MenuBtn, BunifuAnimatorNS.DecorationType.None);
            this.MenuBtn.Image = ((System.Drawing.Image)(resources.GetObject("MenuBtn.Image")));
            this.MenuBtn.ImageActive = null;
            this.MenuBtn.Location = new System.Drawing.Point(6, 9);
            this.MenuBtn.Name = "MenuBtn";
            this.MenuBtn.Size = new System.Drawing.Size(22, 30);
            this.MenuBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.MenuBtn.TabIndex = 0;
            this.MenuBtn.TabStop = false;
            this.MenuBtn.Zoom = 10;
            this.MenuBtn.Click += new System.EventHandler(this.MenuBtn_Click);
            // 
            // bunifuFormFadeTransition1
            // 
            this.bunifuFormFadeTransition1.Delay = 1;
            // 
            // tShow
            // 
            this.tShow.AnimationType = BunifuAnimatorNS.AnimationType.HorizSlide;
            this.tShow.Cursor = null;
            animation2.AnimateOnlyDifferences = true;
            animation2.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.BlindCoeff")));
            animation2.LeafCoeff = 0F;
            animation2.MaxTime = 1F;
            animation2.MinTime = 0F;
            animation2.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.MosaicCoeff")));
            animation2.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation2.MosaicShift")));
            animation2.MosaicSize = 0;
            animation2.Padding = new System.Windows.Forms.Padding(0);
            animation2.RotateCoeff = 0F;
            animation2.RotateLimit = 0F;
            animation2.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.ScaleCoeff")));
            animation2.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.SlideCoeff")));
            animation2.TimeCoeff = 0F;
            animation2.TransparencyCoeff = 0F;
            this.tShow.DefaultAnimation = animation2;
            // 
            // tHide
            // 
            this.tHide.AnimationType = BunifuAnimatorNS.AnimationType.HorizSlide;
            this.tHide.Cursor = null;
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
            this.tHide.DefaultAnimation = animation1;
            // 
            // OrdersBtn
            // 
            this.OrdersBtn.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.OrdersBtn.BackColor = System.Drawing.Color.Crimson;
            this.OrdersBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.OrdersBtn.BorderRadius = 0;
            this.OrdersBtn.ButtonText = "Orders";
            this.OrdersBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tHide.SetDecoration(this.OrdersBtn, BunifuAnimatorNS.DecorationType.None);
            this.tShow.SetDecoration(this.OrdersBtn, BunifuAnimatorNS.DecorationType.None);
            this.OrdersBtn.DisabledColor = System.Drawing.Color.Gray;
            this.OrdersBtn.Font = new System.Drawing.Font("Lucida Sans", 11.75F);
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
            this.OrdersBtn.IconZoom = 50D;
            this.OrdersBtn.IsTab = false;
            this.OrdersBtn.Location = new System.Drawing.Point(0, 160);
            this.OrdersBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.OrdersBtn.Name = "OrdersBtn";
            this.OrdersBtn.Normalcolor = System.Drawing.Color.Crimson;
            this.OrdersBtn.OnHovercolor = System.Drawing.Color.DeepPink;
            this.OrdersBtn.OnHoverTextColor = System.Drawing.Color.White;
            this.OrdersBtn.selected = false;
            this.OrdersBtn.Size = new System.Drawing.Size(220, 62);
            this.OrdersBtn.TabIndex = 1;
            this.OrdersBtn.Text = "Orders";
            this.OrdersBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.OrdersBtn.Textcolor = System.Drawing.Color.White;
            this.OrdersBtn.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // ProductsBtn
            // 
            this.ProductsBtn.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.ProductsBtn.BackColor = System.Drawing.Color.Crimson;
            this.ProductsBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ProductsBtn.BorderRadius = 0;
            this.ProductsBtn.ButtonText = "Products";
            this.ProductsBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tHide.SetDecoration(this.ProductsBtn, BunifuAnimatorNS.DecorationType.None);
            this.tShow.SetDecoration(this.ProductsBtn, BunifuAnimatorNS.DecorationType.None);
            this.ProductsBtn.DisabledColor = System.Drawing.Color.Gray;
            this.ProductsBtn.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.ProductsBtn.IconZoom = 70D;
            this.ProductsBtn.IsTab = false;
            this.ProductsBtn.Location = new System.Drawing.Point(4, 230);
            this.ProductsBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ProductsBtn.Name = "ProductsBtn";
            this.ProductsBtn.Normalcolor = System.Drawing.Color.Crimson;
            this.ProductsBtn.OnHovercolor = System.Drawing.Color.DeepPink;
            this.ProductsBtn.OnHoverTextColor = System.Drawing.Color.White;
            this.ProductsBtn.selected = false;
            this.ProductsBtn.Size = new System.Drawing.Size(216, 62);
            this.ProductsBtn.TabIndex = 2;
            this.ProductsBtn.Text = "Products";
            this.ProductsBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ProductsBtn.Textcolor = System.Drawing.Color.White;
            this.ProductsBtn.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // NewOrderBtn
            // 
            this.NewOrderBtn.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.NewOrderBtn.BackColor = System.Drawing.Color.Crimson;
            this.NewOrderBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.NewOrderBtn.BorderRadius = 0;
            this.NewOrderBtn.ButtonText = "New Order";
            this.NewOrderBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tHide.SetDecoration(this.NewOrderBtn, BunifuAnimatorNS.DecorationType.None);
            this.tShow.SetDecoration(this.NewOrderBtn, BunifuAnimatorNS.DecorationType.None);
            this.NewOrderBtn.DisabledColor = System.Drawing.Color.Gray;
            this.NewOrderBtn.Font = new System.Drawing.Font("Lucida Sans", 11.75F);
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
            this.NewOrderBtn.IconZoom = 90D;
            this.NewOrderBtn.IsTab = false;
            this.NewOrderBtn.Location = new System.Drawing.Point(0, 90);
            this.NewOrderBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.NewOrderBtn.Name = "NewOrderBtn";
            this.NewOrderBtn.Normalcolor = System.Drawing.Color.Crimson;
            this.NewOrderBtn.OnHovercolor = System.Drawing.Color.DeepPink;
            this.NewOrderBtn.OnHoverTextColor = System.Drawing.Color.White;
            this.NewOrderBtn.selected = false;
            this.NewOrderBtn.Size = new System.Drawing.Size(220, 62);
            this.NewOrderBtn.TabIndex = 3;
            this.NewOrderBtn.Text = "New Order";
            this.NewOrderBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.NewOrderBtn.Textcolor = System.Drawing.Color.White;
            this.NewOrderBtn.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(1440, 860);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Drawer);
            this.tShow.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.tHide.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1440, 860);
            this.MinimizeBox = false;
            this.Name = "MainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainMenu";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Drawer.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.closeBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MenuBtn)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Bunifu.Framework.UI.BunifuGradientPanel Drawer;
        private Panel panel1;
        private Bunifu.Framework.UI.BunifuImageButton closeBtn;
        private Bunifu.Framework.UI.BunifuImageButton MenuBtn;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private Bunifu.Framework.UI.BunifuFormFadeTransition bunifuFormFadeTransition1;
        private BunifuAnimatorNS.BunifuTransition tHide;
        private BunifuAnimatorNS.BunifuTransition tShow;
        private Bunifu.Framework.UI.BunifuFlatButton ProductsBtn;
        private Bunifu.Framework.UI.BunifuFlatButton OrdersBtn;
        private Bunifu.Framework.UI.BunifuFlatButton NewOrderBtn;
    }
}