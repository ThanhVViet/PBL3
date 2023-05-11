namespace Chinh_That
{
    partial class View_Sales
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
            this.SalesGridView = new System.Windows.Forms.DataGridView();
            this.SaleIDColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TimeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SalesmanColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalBillColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductsColumn = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.SalesGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // SalesGridView
            // 
            this.SalesGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.SalesGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.SalesGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SalesGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SaleIDColumn,
            this.TimeColumn,
            this.SalesmanColumn,
            this.TotalBillColumn,
            this.ProductsColumn});
            this.SalesGridView.Location = new System.Drawing.Point(13, 32);
            this.SalesGridView.Margin = new System.Windows.Forms.Padding(4);
            this.SalesGridView.Name = "SalesGridView";
            this.SalesGridView.RowHeadersWidth = 51;
            this.SalesGridView.Size = new System.Drawing.Size(779, 405);
            this.SalesGridView.TabIndex = 1;
            this.SalesGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.SalesGridView_CellContentClick);
            // 
            // SaleIDColumn
            // 
            this.SaleIDColumn.HeaderText = "ID";
            this.SaleIDColumn.MinimumWidth = 6;
            this.SaleIDColumn.Name = "SaleIDColumn";
            // 
            // TimeColumn
            // 
            this.TimeColumn.HeaderText = "Time";
            this.TimeColumn.MinimumWidth = 6;
            this.TimeColumn.Name = "TimeColumn";
            // 
            // SalesmanColumn
            // 
            this.SalesmanColumn.HeaderText = "Cash Given";
            this.SalesmanColumn.MinimumWidth = 6;
            this.SalesmanColumn.Name = "SalesmanColumn";
            // 
            // TotalBillColumn
            // 
            this.TotalBillColumn.HeaderText = "Cash Return";
            this.TotalBillColumn.MinimumWidth = 6;
            this.TotalBillColumn.Name = "TotalBillColumn";
            // 
            // ProductsColumn
            // 
            this.ProductsColumn.HeaderText = "Products";
            this.ProductsColumn.MinimumWidth = 6;
            this.ProductsColumn.Name = "ProductsColumn";
            this.ProductsColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ProductsColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // View_Sales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(39)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.SalesGridView);
            this.Name = "View_Sales";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "View_Sales";
            this.Load += new System.EventHandler(this.View_Sales_Load);
            ((System.ComponentModel.ISupportInitialize)(this.SalesGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView SalesGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn SaleIDColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn TimeColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn SalesmanColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalBillColumn;
        private System.Windows.Forms.DataGridViewButtonColumn ProductsColumn;
    }
}