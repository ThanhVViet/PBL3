namespace Chinh_That
{
    partial class UpdateProduct
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UpdateProduct));
            this.ProductIDBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.CancelButton = new System.Windows.Forms.Button();
            this.ProductCategoryComboBox = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.ProductPriceBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.UpdateProductButton = new System.Windows.Forms.Button();
            this.ProductNameBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ProductPictureBox = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.ProductPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // ProductIDBox
            // 
            this.ProductIDBox.Enabled = false;
            this.ProductIDBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductIDBox.Location = new System.Drawing.Point(239, 62);
            this.ProductIDBox.Margin = new System.Windows.Forms.Padding(5);
            this.ProductIDBox.Multiline = true;
            this.ProductIDBox.Name = "ProductIDBox";
            this.ProductIDBox.Size = new System.Drawing.Size(240, 30);
            this.ProductIDBox.TabIndex = 62;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label6.Location = new System.Drawing.Point(32, 67);
            this.label6.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(103, 25);
            this.label6.TabIndex = 61;
            this.label6.Text = "Product ID";
            // 
            // CancelButton
            // 
            this.CancelButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CancelButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CancelButton.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.CancelButton.Location = new System.Drawing.Point(37, 541);
            this.CancelButton.Margin = new System.Windows.Forms.Padding(5);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(216, 35);
            this.CancelButton.TabIndex = 60;
            this.CancelButton.Text = "Hủy";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // ProductCategoryComboBox
            // 
            this.ProductCategoryComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductCategoryComboBox.FormattingEnabled = true;
            this.ProductCategoryComboBox.Location = new System.Drawing.Point(239, 255);
            this.ProductCategoryComboBox.Margin = new System.Windows.Forms.Padding(5);
            this.ProductCategoryComboBox.Name = "ProductCategoryComboBox";
            this.ProductCategoryComboBox.Size = new System.Drawing.Size(240, 33);
            this.ProductCategoryComboBox.TabIndex = 59;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label5.Location = new System.Drawing.Point(32, 263);
            this.label5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(164, 25);
            this.label5.TabIndex = 58;
            this.label5.Text = "Product Category";
            // 
            // ProductPriceBox
            // 
            this.ProductPriceBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductPriceBox.Location = new System.Drawing.Point(241, 189);
            this.ProductPriceBox.Margin = new System.Windows.Forms.Padding(5);
            this.ProductPriceBox.Multiline = true;
            this.ProductPriceBox.Name = "ProductPriceBox";
            this.ProductPriceBox.Size = new System.Drawing.Size(240, 35);
            this.ProductPriceBox.TabIndex = 57;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label4.Location = new System.Drawing.Point(32, 199);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(128, 25);
            this.label4.TabIndex = 56;
            this.label4.Text = "Product Price";
            // 
            // UpdateProductButton
            // 
            this.UpdateProductButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.UpdateProductButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UpdateProductButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpdateProductButton.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.UpdateProductButton.Location = new System.Drawing.Point(263, 541);
            this.UpdateProductButton.Margin = new System.Windows.Forms.Padding(5);
            this.UpdateProductButton.Name = "UpdateProductButton";
            this.UpdateProductButton.Size = new System.Drawing.Size(216, 35);
            this.UpdateProductButton.TabIndex = 55;
            this.UpdateProductButton.Text = "Cập nhật";
            this.UpdateProductButton.UseVisualStyleBackColor = true;
            this.UpdateProductButton.Click += new System.EventHandler(this.UpdateProductButton_Click);
            // 
            // ProductNameBox
            // 
            this.ProductNameBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductNameBox.Location = new System.Drawing.Point(237, 130);
            this.ProductNameBox.Margin = new System.Windows.Forms.Padding(5);
            this.ProductNameBox.Multiline = true;
            this.ProductNameBox.Name = "ProductNameBox";
            this.ProductNameBox.Size = new System.Drawing.Size(244, 34);
            this.ProductNameBox.TabIndex = 52;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label3.Location = new System.Drawing.Point(32, 337);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(144, 25);
            this.label3.TabIndex = 51;
            this.label3.Text = "Product Picture";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Location = new System.Drawing.Point(32, 139);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 25);
            this.label1.TabIndex = 50;
            this.label1.Text = "Product Name";
            // 
            // ProductPictureBox
            // 
            this.ProductPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ProductPictureBox.Location = new System.Drawing.Point(237, 337);
            this.ProductPictureBox.Margin = new System.Windows.Forms.Padding(5);
            this.ProductPictureBox.Name = "ProductPictureBox";
            this.ProductPictureBox.Size = new System.Drawing.Size(244, 158);
            this.ProductPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ProductPictureBox.TabIndex = 53;
            this.ProductPictureBox.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-2, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(178, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 63;
            this.pictureBox1.TabStop = false;
            // 
            // UpdateProduct
            // 
            this.AcceptButton = this.UpdateProductButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(39)))));
            this.ClientSize = new System.Drawing.Size(518, 660);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.ProductIDBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.ProductCategoryComboBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.ProductPriceBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.UpdateProductButton);
            this.Controls.Add(this.ProductPictureBox);
            this.Controls.Add(this.ProductNameBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.Name = "UpdateProduct";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UpdateProduct";
            this.Load += new System.EventHandler(this.Update_Products_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ProductPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ProductIDBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.ComboBox ProductCategoryComboBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox ProductPriceBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button UpdateProductButton;
        private System.Windows.Forms.PictureBox ProductPictureBox;
        private System.Windows.Forms.TextBox ProductNameBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}