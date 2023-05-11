namespace Chinh_That
{
    partial class View_P
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.ProductCategoryComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ProductsGridView = new System.Windows.Forms.DataGridView();
            this.ProductIDColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductPriceColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductCategoryColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductImageColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.EditProductColumn = new System.Windows.Forms.DataGridViewButtonColumn();
            this.DeleteProductColumn = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.ProductsGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // ProductCategoryComboBox
            // 
            this.ProductCategoryComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.ProductCategoryComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.ProductCategoryComboBox.FormattingEnabled = true;
            this.ProductCategoryComboBox.Location = new System.Drawing.Point(124, 11);
            this.ProductCategoryComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.ProductCategoryComboBox.Name = "ProductCategoryComboBox";
            this.ProductCategoryComboBox.Size = new System.Drawing.Size(664, 24);
            this.ProductCategoryComboBox.Sorted = true;
            this.ProductCategoryComboBox.TabIndex = 8;
            this.ProductCategoryComboBox.SelectedIndexChanged += new System.EventHandler(this.ProductCategoryComboBox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Location = new System.Drawing.Point(7, 14);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 16);
            this.label1.TabIndex = 7;
            this.label1.Text = "Select Category";
            // 
            // ProductsGridView
            // 
            this.ProductsGridView.AllowUserToAddRows = false;
            this.ProductsGridView.AllowUserToDeleteRows = false;
            this.ProductsGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ProductsGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ProductsGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.ProductsGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ProductsGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ProductIDColumn,
            this.ProductNameColumn,
            this.ProductPriceColumn,
            this.ProductCategoryColumn,
            this.ProductImageColumn,
            this.EditProductColumn,
            this.DeleteProductColumn});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.ProductsGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.ProductsGridView.Location = new System.Drawing.Point(10, 60);
            this.ProductsGridView.Margin = new System.Windows.Forms.Padding(4);
            this.ProductsGridView.Name = "ProductsGridView";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ProductsGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.ProductsGridView.RowHeadersWidth = 51;
            this.ProductsGridView.Size = new System.Drawing.Size(782, 377);
            this.ProductsGridView.TabIndex = 11;
            this.ProductsGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ProductsGridView_CellContentClick);
            // 
            // ProductIDColumn
            // 
            this.ProductIDColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ProductIDColumn.DataPropertyName = "id";
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
            // ProductCategoryColumn
            // 
            this.ProductCategoryColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ProductCategoryColumn.DataPropertyName = " product_category_name";
            this.ProductCategoryColumn.HeaderText = "Category";
            this.ProductCategoryColumn.MinimumWidth = 6;
            this.ProductCategoryColumn.Name = "ProductCategoryColumn";
            // 
            // ProductImageColumn
            // 
            this.ProductImageColumn.DataPropertyName = "image_url";
            this.ProductImageColumn.HeaderText = "Image";
            this.ProductImageColumn.MinimumWidth = 6;
            this.ProductImageColumn.Name = "ProductImageColumn";
            this.ProductImageColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ProductImageColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // EditProductColumn
            // 
            this.EditProductColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.EditProductColumn.HeaderText = "Edit";
            this.EditProductColumn.MinimumWidth = 6;
            this.EditProductColumn.Name = "EditProductColumn";
            this.EditProductColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.EditProductColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // DeleteProductColumn
            // 
            this.DeleteProductColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DeleteProductColumn.HeaderText = "Delete";
            this.DeleteProductColumn.MinimumWidth = 6;
            this.DeleteProductColumn.Name = "DeleteProductColumn";
            // 
            // View_P
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(39)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ProductsGridView);
            this.Controls.Add(this.ProductCategoryComboBox);
            this.Controls.Add(this.label1);
            this.Name = "View_P";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "View_P";
            this.Load += new System.EventHandler(this.View_P_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ProductsGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox ProductCategoryComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView ProductsGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductIDColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductNameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductPriceColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductCategoryColumn;
        private System.Windows.Forms.DataGridViewImageColumn ProductImageColumn;
        private System.Windows.Forms.DataGridViewButtonColumn EditProductColumn;
        private System.Windows.Forms.DataGridViewButtonColumn DeleteProductColumn;
    }
}