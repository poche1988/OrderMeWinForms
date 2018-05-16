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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.OrderGrid = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NoOrdersLabel = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.OrderGrid)).BeginInit();
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
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.OrderGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.OrderGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.OrderGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Date,
            this.Status});
            this.OrderGrid.DoubleBuffered = true;
            this.OrderGrid.EnableHeadersVisualStyles = false;
            this.OrderGrid.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.OrderGrid.HeaderForeColor = System.Drawing.Color.White;
            this.OrderGrid.Location = new System.Drawing.Point(31, 64);
            this.OrderGrid.Name = "OrderGrid";
            this.OrderGrid.ReadOnly = true;
            this.OrderGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.OrderGrid.Size = new System.Drawing.Size(256, 472);
            this.OrderGrid.TabIndex = 5;
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
            this.NoOrdersLabel.Location = new System.Drawing.Point(28, 64);
            this.NoOrdersLabel.Name = "NoOrdersLabel";
            this.NoOrdersLabel.Size = new System.Drawing.Size(120, 22);
            this.NoOrdersLabel.TabIndex = 6;
            this.NoOrdersLabel.Text = "NO ORDERS";
            this.NoOrdersLabel.Visible = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.panel2.Location = new System.Drawing.Point(293, 64);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(2, 484);
            this.panel2.TabIndex = 7;
            // 
            // Orders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(950, 564);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.NoOrdersLabel);
            this.Controls.Add(this.OrderGrid);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Orders";
            this.Text = "Orders";
            ((System.ComponentModel.ISupportInitialize)(this.OrderGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private Bunifu.Framework.UI.BunifuCustomDataGrid OrderGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.Label NoOrdersLabel;
        private System.Windows.Forms.Panel panel2;
    }
}