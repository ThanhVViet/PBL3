namespace Chinh_That
{
    partial class SaleProduct
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
            this.SaleItemsGridView = new System.Windows.Forms.DataGridView();
            this.ProductNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductPriceColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductQuantityColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductTotalColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.SaleItemsGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // SaleItemsGridView
            // 
            this.SaleItemsGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.SaleItemsGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.SaleItemsGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SaleItemsGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ProductNameColumn,
            this.ProductPriceColumn,
            this.ProductQuantityColumn,
            this.ProductTotalColumn});
            this.SaleItemsGridView.Location = new System.Drawing.Point(3, 22);
            this.SaleItemsGridView.Margin = new System.Windows.Forms.Padding(4);
            this.SaleItemsGridView.Name = "SaleItemsGridView";
            this.SaleItemsGridView.RowHeadersWidth = 51;
            this.SaleItemsGridView.Size = new System.Drawing.Size(795, 446);
            this.SaleItemsGridView.TabIndex = 1;
            // 
            // ProductNameColumn
            // 
            this.ProductNameColumn.HeaderText = "Name";
            this.ProductNameColumn.MinimumWidth = 6;
            this.ProductNameColumn.Name = "ProductNameColumn";
            // 
            // ProductPriceColumn
            // 
            this.ProductPriceColumn.HeaderText = "Price";
            this.ProductPriceColumn.MinimumWidth = 6;
            this.ProductPriceColumn.Name = "ProductPriceColumn";
            // 
            // ProductQuantityColumn
            // 
            this.ProductQuantityColumn.HeaderText = "Quantity";
            this.ProductQuantityColumn.MinimumWidth = 6;
            this.ProductQuantityColumn.Name = "ProductQuantityColumn";
            // 
            // ProductTotalColumn
            // 
            this.ProductTotalColumn.HeaderText = "Total Price";
            this.ProductTotalColumn.MinimumWidth = 6;
            this.ProductTotalColumn.Name = "ProductTotalColumn";
            this.ProductTotalColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // SaleProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(39)))));
            this.ClientSize = new System.Drawing.Size(800, 472);
            this.Controls.Add(this.SaleItemsGridView);
            this.Name = "SaleProduct";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "SaleProduct";
            this.Load += new System.EventHandler(this.SaleProduct_Load);
            ((System.ComponentModel.ISupportInitialize)(this.SaleItemsGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView SaleItemsGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductNameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductPriceColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductQuantityColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductTotalColumn;
    }
}