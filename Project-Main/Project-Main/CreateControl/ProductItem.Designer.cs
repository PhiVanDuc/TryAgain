namespace Project_Main.CreateControl
{
    partial class ProductItem
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductItem));
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.ProductImage = new Guna.UI2.WinForms.Guna2PictureBox();
            this.lblNameProduct = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblPrice = new System.Windows.Forms.Label();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.ProductImage)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 12;
            this.guna2Elipse1.TargetControl = this;
            // 
            // ProductImage
            // 
            this.ProductImage.Dock = System.Windows.Forms.DockStyle.Top;
            this.ProductImage.Image = ((System.Drawing.Image)(resources.GetObject("ProductImage.Image")));
            this.ProductImage.ImageRotate = 0F;
            this.ProductImage.Location = new System.Drawing.Point(0, 0);
            this.ProductImage.Name = "ProductImage";
            this.ProductImage.Size = new System.Drawing.Size(246, 119);
            this.ProductImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ProductImage.TabIndex = 0;
            this.ProductImage.TabStop = false;
            // 
            // lblNameProduct
            // 
            this.lblNameProduct.BackColor = System.Drawing.Color.Transparent;
            this.lblNameProduct.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNameProduct.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.lblNameProduct.Location = new System.Drawing.Point(8, 127);
            this.lblNameProduct.Margin = new System.Windows.Forms.Padding(8, 5, 3, 3);
            this.lblNameProduct.Name = "lblNameProduct";
            this.lblNameProduct.Size = new System.Drawing.Size(90, 19);
            this.lblNameProduct.TabIndex = 1;
            this.lblNameProduct.Text = "Tên sản phẩm";
            // 
            // lblPrice
            // 
            this.lblPrice.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblPrice.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.lblPrice.Image = ((System.Drawing.Image)(resources.GetObject("lblPrice.Image")));
            this.lblPrice.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblPrice.Location = new System.Drawing.Point(30, 156);
            this.lblPrice.Margin = new System.Windows.Forms.Padding(3, 5, 3, 0);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(181, 23);
            this.lblPrice.TabIndex = 2;
            this.lblPrice.Text = "0.0 vnd";
            this.lblPrice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // guna2Button1
            // 
            this.guna2Button1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.guna2Button1.BorderRadius = 5;
            this.guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.Location = new System.Drawing.Point(33, 188);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.Size = new System.Drawing.Size(178, 36);
            this.guna2Button1.TabIndex = 3;
            this.guna2Button1.Text = "Thêm vào hóa đơn";
            // 
            // ProductItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.guna2Button1);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.lblNameProduct);
            this.Controls.Add(this.ProductImage);
            this.Name = "ProductItem";
            this.Size = new System.Drawing.Size(246, 233);
            ((System.ComponentModel.ISupportInitialize)(this.ProductImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblNameProduct;
        private Guna.UI2.WinForms.Guna2PictureBox ProductImage;
        private System.Windows.Forms.Label lblPrice;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
    }
}
