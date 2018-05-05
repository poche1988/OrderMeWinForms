namespace OrderMe.Forms
{
    partial class Login
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

        

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.bunifuGradientPanel1 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.UsernameTxtBox = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.PasswordTxtBox = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.ExitBtn = new Bunifu.Framework.UI.BunifuImageButton();
            this.SignInBtn = new Bunifu.Framework.UI.BunifuThinButton2();
            this.bunifuGradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ExitBtn)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuGradientPanel1
            // 
            this.bunifuGradientPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel1.BackgroundImage")));
            this.bunifuGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel1.Controls.Add(this.pictureBox2);
            this.bunifuGradientPanel1.Controls.Add(this.UsernameTxtBox);
            this.bunifuGradientPanel1.Controls.Add(this.pictureBox1);
            this.bunifuGradientPanel1.Controls.Add(this.PasswordTxtBox);
            this.bunifuGradientPanel1.Controls.Add(this.bunifuCustomLabel1);
            this.bunifuGradientPanel1.Controls.Add(this.ExitBtn);
            this.bunifuGradientPanel1.Controls.Add(this.SignInBtn);
            this.bunifuGradientPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bunifuGradientPanel1.GradientBottomLeft = System.Drawing.SystemColors.Highlight;
            this.bunifuGradientPanel1.GradientBottomRight = System.Drawing.Color.SeaGreen;
            this.bunifuGradientPanel1.GradientTopLeft = System.Drawing.Color.LightSeaGreen;
            this.bunifuGradientPanel1.GradientTopRight = System.Drawing.Color.Violet;
            this.bunifuGradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.bunifuGradientPanel1.Name = "bunifuGradientPanel1";
            this.bunifuGradientPanel1.Quality = 10;
            this.bunifuGradientPanel1.Size = new System.Drawing.Size(384, 361);
            this.bunifuGradientPanel1.TabIndex = 0;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.DarkCyan;
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox2.ImageLocation = "";
            this.pictureBox2.Location = new System.Drawing.Point(43, 171);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(38, 38);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox2.TabIndex = 11;
            this.pictureBox2.TabStop = false;
            // 
            // UsernameTxtBox
            // 
            this.UsernameTxtBox.BackColor = System.Drawing.SystemColors.Control;
            this.UsernameTxtBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.UsernameTxtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.UsernameTxtBox.ForeColor = System.Drawing.Color.Gray;
            this.UsernameTxtBox.HintForeColor = System.Drawing.Color.Gray;
            this.UsernameTxtBox.HintText = "username";
            this.UsernameTxtBox.isPassword = false;
            this.UsernameTxtBox.LineFocusedColor = System.Drawing.Color.White;
            this.UsernameTxtBox.LineIdleColor = System.Drawing.Color.DarkCyan;
            this.UsernameTxtBox.LineMouseHoverColor = System.Drawing.Color.White;
            this.UsernameTxtBox.LineThickness = 3;
            this.UsernameTxtBox.Location = new System.Drawing.Point(78, 102);
            this.UsernameTxtBox.Margin = new System.Windows.Forms.Padding(4);
            this.UsernameTxtBox.Name = "UsernameTxtBox";
            this.UsernameTxtBox.Size = new System.Drawing.Size(261, 38);
            this.UsernameTxtBox.TabIndex = 8;
            this.UsernameTxtBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.DarkCyan;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.Location = new System.Drawing.Point(43, 102);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(38, 38);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // PasswordTxtBox
            // 
            this.PasswordTxtBox.BackColor = System.Drawing.SystemColors.Control;
            this.PasswordTxtBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.PasswordTxtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.PasswordTxtBox.ForeColor = System.Drawing.Color.Gray;
            this.PasswordTxtBox.HintForeColor = System.Drawing.Color.Gray;
            this.PasswordTxtBox.HintText = "";
            this.PasswordTxtBox.isPassword = true;
            this.PasswordTxtBox.LineFocusedColor = System.Drawing.Color.White;
            this.PasswordTxtBox.LineIdleColor = System.Drawing.Color.DarkCyan;
            this.PasswordTxtBox.LineMouseHoverColor = System.Drawing.Color.White;
            this.PasswordTxtBox.LineThickness = 3;
            this.PasswordTxtBox.Location = new System.Drawing.Point(78, 171);
            this.PasswordTxtBox.Margin = new System.Windows.Forms.Padding(4);
            this.PasswordTxtBox.Name = "PasswordTxtBox";
            this.PasswordTxtBox.Size = new System.Drawing.Size(261, 38);
            this.PasswordTxtBox.TabIndex = 9;
            this.PasswordTxtBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Lucida Sans", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(12, 9);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(99, 24);
            this.bunifuCustomLabel1.TabIndex = 4;
            this.bunifuCustomLabel1.Text = "OrderMe";
            // 
            // ExitBtn
            // 
            this.ExitBtn.BackColor = System.Drawing.Color.Transparent;
            this.ExitBtn.Image = ((System.Drawing.Image)(resources.GetObject("ExitBtn.Image")));
            this.ExitBtn.ImageActive = null;
            this.ExitBtn.Location = new System.Drawing.Point(348, 3);
            this.ExitBtn.Name = "ExitBtn";
            this.ExitBtn.Size = new System.Drawing.Size(33, 30);
            this.ExitBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ExitBtn.TabIndex = 3;
            this.ExitBtn.TabStop = false;
            this.ExitBtn.Zoom = 10;
            this.ExitBtn.Click += new System.EventHandler(this.ExitBtn_Click);
            // 
            // SignInBtn
            // 
            this.SignInBtn.ActiveBorderThickness = 1;
            this.SignInBtn.ActiveCornerRadius = 20;
            this.SignInBtn.ActiveFillColor = System.Drawing.Color.LightSeaGreen;
            this.SignInBtn.ActiveForecolor = System.Drawing.Color.White;
            this.SignInBtn.ActiveLineColor = System.Drawing.Color.White;
            this.SignInBtn.BackColor = System.Drawing.Color.Transparent;
            this.SignInBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("SignInBtn.BackgroundImage")));
            this.SignInBtn.ButtonText = "Sign In";
            this.SignInBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SignInBtn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SignInBtn.ForeColor = System.Drawing.Color.SeaGreen;
            this.SignInBtn.IdleBorderThickness = 1;
            this.SignInBtn.IdleCornerRadius = 20;
            this.SignInBtn.IdleFillColor = System.Drawing.Color.DarkCyan;
            this.SignInBtn.IdleForecolor = System.Drawing.Color.White;
            this.SignInBtn.IdleLineColor = System.Drawing.Color.White;
            this.SignInBtn.Location = new System.Drawing.Point(93, 235);
            this.SignInBtn.Margin = new System.Windows.Forms.Padding(5);
            this.SignInBtn.Name = "SignInBtn";
            this.SignInBtn.Size = new System.Drawing.Size(181, 41);
            this.SignInBtn.TabIndex = 0;
            this.SignInBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.SignInBtn.Click += new System.EventHandler(this.SignInBtn_Click);
            // 
            // Login
            // 
            this.ClientSize = new System.Drawing.Size(384, 361);
            this.ControlBox = false;
            this.Controls.Add(this.bunifuGradientPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.bunifuGradientPanel1.ResumeLayout(false);
            this.bunifuGradientPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ExitBtn)).EndInit();
            this.ResumeLayout(false);

        }

        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel1;
        private Bunifu.Framework.UI.BunifuThinButton2 SignInBtn;
        private Bunifu.Framework.UI.BunifuImageButton ExitBtn;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private Bunifu.Framework.UI.BunifuMaterialTextbox UsernameTxtBox;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox PasswordTxtBox;
    }
}