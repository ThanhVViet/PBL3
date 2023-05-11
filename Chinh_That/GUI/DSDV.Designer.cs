namespace Chinh_That
{
    partial class DSDV
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DSDV));
            this.ProductsGridView = new System.Windows.Forms.DataGridView();
            this.ProductIDColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductPriceColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductQuantityColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalPriceColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DeleteColumn = new System.Windows.Forms.DataGridViewButtonColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.FLP = new System.Windows.Forms.FlowLayoutPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.TotalBillBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnALL_P = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.btnAllSale = new System.Windows.Forms.Button();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.rjButton1 = new Chinh_That.Custom.RJButton();
            this.btnAdd_P = new Chinh_That.Custom.RJButton();
            this.rjPictureBox2 = new Chinh_That.Custom.RJPictureBox();
            this.rjButton2 = new Chinh_That.Custom.RJButton();
            this.rjPictureBox1 = new Chinh_That.Custom.RJPictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.ProductsGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rjPictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rjPictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.SuspendLayout();
            // 
            // ProductsGridView
            // 
            this.ProductsGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ProductsGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ProductsGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ProductsGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ProductIDColumn,
            this.ProductNameColumn,
            this.ProductPriceColumn,
            this.ProductQuantityColumn,
            this.TotalPriceColumn,
            this.DeleteColumn});
            this.ProductsGridView.Location = new System.Drawing.Point(1106, 161);
            this.ProductsGridView.Margin = new System.Windows.Forms.Padding(4);
            this.ProductsGridView.Name = "ProductsGridView";
            this.ProductsGridView.RowHeadersWidth = 51;
            this.ProductsGridView.Size = new System.Drawing.Size(620, 711);
            this.ProductsGridView.TabIndex = 25;
            this.ProductsGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ProductsGridView_CellContentClick);
            // 
            // ProductIDColumn
            // 
            this.ProductIDColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ProductIDColumn.FillWeight = 50F;
            this.ProductIDColumn.HeaderText = "ID";
            this.ProductIDColumn.MinimumWidth = 6;
            this.ProductIDColumn.Name = "ProductIDColumn";
            // 
            // ProductNameColumn
            // 
            this.ProductNameColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ProductNameColumn.DataPropertyName = "product_name";
            this.ProductNameColumn.HeaderText = "Product Name";
            this.ProductNameColumn.MinimumWidth = 6;
            this.ProductNameColumn.Name = "ProductNameColumn";
            // 
            // ProductPriceColumn
            // 
            this.ProductPriceColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ProductPriceColumn.DataPropertyName = "prices";
            this.ProductPriceColumn.HeaderText = "Price";
            this.ProductPriceColumn.MinimumWidth = 6;
            this.ProductPriceColumn.Name = "ProductPriceColumn";
            // 
            // ProductQuantityColumn
            // 
            this.ProductQuantityColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ProductQuantityColumn.DataPropertyName = "product_quanity";
            this.ProductQuantityColumn.HeaderText = "Quantity";
            this.ProductQuantityColumn.MinimumWidth = 6;
            this.ProductQuantityColumn.Name = "ProductQuantityColumn";
            // 
            // TotalPriceColumn
            // 
            this.TotalPriceColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TotalPriceColumn.DataPropertyName = "total";
            this.TotalPriceColumn.HeaderText = "Product Total";
            this.TotalPriceColumn.MinimumWidth = 6;
            this.TotalPriceColumn.Name = "TotalPriceColumn";
            // 
            // DeleteColumn
            // 
            this.DeleteColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DeleteColumn.HeaderText = "Delete";
            this.DeleteColumn.MinimumWidth = 6;
            this.DeleteColumn.Name = "DeleteColumn";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label3.Location = new System.Drawing.Point(973, 496);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 29);
            this.label3.TabIndex = 23;
            this.label3.Text = "Product";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label2.Location = new System.Drawing.Point(959, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 29);
            this.label2.TabIndex = 22;
            this.label2.Text = "Category";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(108, 538);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(961, 390);
            this.flowLayoutPanel1.TabIndex = 16;
            // 
            // FLP
            // 
            this.FLP.AutoScroll = true;
            this.FLP.Location = new System.Drawing.Point(108, 93);
            this.FLP.Name = "FLP";
            this.FLP.Size = new System.Drawing.Size(961, 387);
            this.FLP.TabIndex = 15;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1691, 879);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(35, 49);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 79;
            this.pictureBox1.TabStop = false;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.MediumTurquoise;
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(202)))), ((int)(((byte)(99)))));
            this.label6.Location = new System.Drawing.Point(1225, 926);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(290, 2);
            this.label6.TabIndex = 77;
            // 
            // TotalBillBox
            // 
            this.TotalBillBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(39)))));
            this.TotalBillBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TotalBillBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalBillBox.ForeColor = System.Drawing.Color.MediumAquamarine;
            this.TotalBillBox.Location = new System.Drawing.Point(1228, 895);
            this.TotalBillBox.Margin = new System.Windows.Forms.Padding(4);
            this.TotalBillBox.Name = "TotalBillBox";
            this.TotalBillBox.Size = new System.Drawing.Size(235, 27);
            this.TotalBillBox.TabIndex = 76;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Location = new System.Drawing.Point(1101, 899);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 29);
            this.label1.TabIndex = 75;
            this.label1.Text = "Total Bill";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(1106, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(220, 151);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 80;
            this.pictureBox2.TabStop = false;
            // 
            // btnALL_P
            // 
            this.btnALL_P.FlatAppearance.BorderSize = 0;
            this.btnALL_P.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnALL_P.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnALL_P.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnALL_P.Location = new System.Drawing.Point(1162, 52);
            this.btnALL_P.Name = "btnALL_P";
            this.btnALL_P.Size = new System.Drawing.Size(107, 51);
            this.btnALL_P.TabIndex = 81;
            this.btnALL_P.Text = "ALL Product";
            this.btnALL_P.UseVisualStyleBackColor = true;
            this.btnALL_P.Click += new System.EventHandler(this.btnALL_P_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(1520, 3);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(191, 151);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 82;
            this.pictureBox3.TabStop = false;
            // 
            // btnAllSale
            // 
            this.btnAllSale.FlatAppearance.BorderSize = 0;
            this.btnAllSale.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAllSale.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAllSale.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnAllSale.Location = new System.Drawing.Point(1568, 52);
            this.btnAllSale.Name = "btnAllSale";
            this.btnAllSale.Size = new System.Drawing.Size(93, 51);
            this.btnAllSale.TabIndex = 83;
            this.btnAllSale.Text = "ALL Sales";
            this.btnAllSale.UseVisualStyleBackColor = true;
            this.btnAllSale.Click += new System.EventHandler(this.btnAllSale_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(108, 3);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(427, 84);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 84;
            this.pictureBox4.TabStop = false;
            // 
            // rjButton1
            // 
            this.rjButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(39)))));
            this.rjButton1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(39)))));
            this.rjButton1.BorderColor = System.Drawing.Color.MediumTurquoise;
            this.rjButton1.BorderRadius = 3;
            this.rjButton1.BorderSize = 1;
            this.rjButton1.FlatAppearance.BorderSize = 0;
            this.rjButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rjButton1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.rjButton1.Location = new System.Drawing.Point(1535, 888);
            this.rjButton1.Name = "rjButton1";
            this.rjButton1.Size = new System.Drawing.Size(150, 40);
            this.rjButton1.TabIndex = 78;
            this.rjButton1.Text = "Tính tiền";
            this.rjButton1.TextColor = System.Drawing.SystemColors.ActiveCaption;
            this.rjButton1.UseVisualStyleBackColor = false;
            this.rjButton1.Click += new System.EventHandler(this.CheckOutButton_Click);
            // 
            // btnAdd_P
            // 
            this.btnAdd_P.BackColor = System.Drawing.Color.Transparent;
            this.btnAdd_P.BackgroundColor = System.Drawing.Color.Transparent;
            this.btnAdd_P.BorderColor = System.Drawing.Color.CornflowerBlue;
            this.btnAdd_P.BorderRadius = 25;
            this.btnAdd_P.BorderSize = 0;
            this.btnAdd_P.FlatAppearance.BorderSize = 0;
            this.btnAdd_P.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnAdd_P.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnAdd_P.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd_P.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd_P.ForeColor = System.Drawing.Color.White;
            this.btnAdd_P.Location = new System.Drawing.Point(24, 556);
            this.btnAdd_P.Name = "btnAdd_P";
            this.btnAdd_P.Size = new System.Drawing.Size(64, 65);
            this.btnAdd_P.TabIndex = 74;
            this.btnAdd_P.Text = "P";
            this.btnAdd_P.TextColor = System.Drawing.Color.White;
            this.btnAdd_P.UseVisualStyleBackColor = false;
            this.btnAdd_P.Click += new System.EventHandler(this.btnAdd_P_Click);
            // 
            // rjPictureBox2
            // 
            this.rjPictureBox2.BorderCapStyle = System.Drawing.Drawing2D.DashCap.Triangle;
            this.rjPictureBox2.BorderColor = System.Drawing.Color.Crimson;
            this.rjPictureBox2.BorderColor2 = System.Drawing.Color.HotPink;
            this.rjPictureBox2.BorderLineStyle = System.Drawing.Drawing2D.DashStyle.DashDotDot;
            this.rjPictureBox2.BorderSize = 5;
            this.rjPictureBox2.GradientAngle = 100F;
            this.rjPictureBox2.Location = new System.Drawing.Point(2, 538);
            this.rjPictureBox2.Name = "rjPictureBox2";
            this.rjPictureBox2.Size = new System.Drawing.Size(105, 105);
            this.rjPictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.rjPictureBox2.TabIndex = 73;
            this.rjPictureBox2.TabStop = false;
            // 
            // rjButton2
            // 
            this.rjButton2.BackColor = System.Drawing.Color.Transparent;
            this.rjButton2.BackgroundColor = System.Drawing.Color.Transparent;
            this.rjButton2.BorderColor = System.Drawing.Color.CornflowerBlue;
            this.rjButton2.BorderRadius = 25;
            this.rjButton2.BorderSize = 0;
            this.rjButton2.FlatAppearance.BorderSize = 0;
            this.rjButton2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.rjButton2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.rjButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rjButton2.ForeColor = System.Drawing.Color.White;
            this.rjButton2.Location = new System.Drawing.Point(24, 110);
            this.rjButton2.Name = "rjButton2";
            this.rjButton2.Size = new System.Drawing.Size(64, 65);
            this.rjButton2.TabIndex = 72;
            this.rjButton2.Text = "C";
            this.rjButton2.TextColor = System.Drawing.Color.White;
            this.rjButton2.UseVisualStyleBackColor = false;
            this.rjButton2.Click += new System.EventHandler(this.ADD_C_Click);
            // 
            // rjPictureBox1
            // 
            this.rjPictureBox1.BorderCapStyle = System.Drawing.Drawing2D.DashCap.Triangle;
            this.rjPictureBox1.BorderColor = System.Drawing.Color.Gold;
            this.rjPictureBox1.BorderColor2 = System.Drawing.Color.HotPink;
            this.rjPictureBox1.BorderLineStyle = System.Drawing.Drawing2D.DashStyle.DashDotDot;
            this.rjPictureBox1.BorderSize = 5;
            this.rjPictureBox1.GradientAngle = 100F;
            this.rjPictureBox1.Location = new System.Drawing.Point(2, 93);
            this.rjPictureBox1.Name = "rjPictureBox1";
            this.rjPictureBox1.Size = new System.Drawing.Size(105, 105);
            this.rjPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.rjPictureBox1.TabIndex = 71;
            this.rjPictureBox1.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(526, 3);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(427, 84);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 85;
            this.pictureBox5.TabStop = false;
            // 
            // DSDV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(39)))));
            this.ClientSize = new System.Drawing.Size(1739, 940);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.btnAllSale);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.btnALL_P);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.rjButton1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.TotalBillBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAdd_P);
            this.Controls.Add(this.rjPictureBox2);
            this.Controls.Add(this.rjButton2);
            this.Controls.Add(this.rjPictureBox1);
            this.Controls.Add(this.ProductsGridView);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.FLP);
            this.Name = "DSDV";
            this.Text = "DSDV";
            ((System.ComponentModel.ISupportInitialize)(this.ProductsGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rjPictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rjPictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView ProductsGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductIDColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductNameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductPriceColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductQuantityColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalPriceColumn;
        private System.Windows.Forms.DataGridViewButtonColumn DeleteColumn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel FLP;
        private Custom.RJPictureBox rjPictureBox1;
        private Custom.RJButton rjButton2;
        private Custom.RJPictureBox rjPictureBox2;
        private Custom.RJButton btnAdd_P;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Custom.RJButton rjButton1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TotalBillBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnALL_P;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button btnAllSale;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
    }
}