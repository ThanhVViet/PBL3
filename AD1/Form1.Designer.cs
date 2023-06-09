namespace AD1
{
    partial class Form1
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
            this.dtgNV = new System.Windows.Forms.DataGridView();
            this.cid_employee = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cphone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cemployee_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cdate_of_birth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cimage_url = new System.Windows.Forms.DataGridViewImageColumn();
            this.btnDeleteNV = new System.Windows.Forms.Button();
            this.btnEditNV = new System.Windows.Forms.Button();
            this.btnAddNV = new System.Windows.Forms.Button();
            this.txtFind = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtgNV)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgNV
            // 
            this.dtgNV.AllowUserToAddRows = false;
            this.dtgNV.AllowUserToDeleteRows = false;
            this.dtgNV.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgNV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgNV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cid_employee,
            this.cphone,
            this.cemployee_name,
            this.cdate_of_birth,
            this.cimage_url});
            this.dtgNV.Location = new System.Drawing.Point(-4, 93);
            this.dtgNV.Name = "dtgNV";
            this.dtgNV.RowHeadersWidth = 51;
            this.dtgNV.RowTemplate.Height = 24;
            this.dtgNV.Size = new System.Drawing.Size(991, 432);
            this.dtgNV.TabIndex = 44;
            this.dtgNV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgNV_CellContentClick);
            // 
            // cid_employee
            // 
            this.cid_employee.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cid_employee.DataPropertyName = "id_employee";
            this.cid_employee.HeaderText = "ID";
            this.cid_employee.MinimumWidth = 6;
            this.cid_employee.Name = "cid_employee";
            // 
            // cphone
            // 
            this.cphone.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cphone.DataPropertyName = "phone";
            this.cphone.HeaderText = "So Dien Thoai";
            this.cphone.MinimumWidth = 6;
            this.cphone.Name = "cphone";
            // 
            // cemployee_name
            // 
            this.cemployee_name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cemployee_name.DataPropertyName = "employee_name";
            this.cemployee_name.HeaderText = "Ten Nhan Vien";
            this.cemployee_name.MinimumWidth = 6;
            this.cemployee_name.Name = "cemployee_name";
            // 
            // cdate_of_birth
            // 
            this.cdate_of_birth.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cdate_of_birth.DataPropertyName = "date_of_birth";
            this.cdate_of_birth.HeaderText = "Ngay Sinh";
            this.cdate_of_birth.MinimumWidth = 6;
            this.cdate_of_birth.Name = "cdate_of_birth";
            // 
            // cimage_url
            // 
            this.cimage_url.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cimage_url.DataPropertyName = "image_url";
            this.cimage_url.HeaderText = "Ảnh";
            this.cimage_url.MinimumWidth = 6;
            this.cimage_url.Name = "cimage_url";
            // 
            // btnDeleteNV
            // 
            this.btnDeleteNV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(43)))), ((int)(((byte)(60)))));
            this.btnDeleteNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteNV.ForeColor = System.Drawing.Color.MediumTurquoise;
            this.btnDeleteNV.Location = new System.Drawing.Point(679, 585);
            this.btnDeleteNV.Name = "btnDeleteNV";
            this.btnDeleteNV.Size = new System.Drawing.Size(126, 45);
            this.btnDeleteNV.TabIndex = 41;
            this.btnDeleteNV.Text = "DELETE";
            this.btnDeleteNV.UseVisualStyleBackColor = false;
            this.btnDeleteNV.Click += new System.EventHandler(this.btnDeleteNV_Click);
            // 
            // btnEditNV
            // 
            this.btnEditNV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(43)))), ((int)(((byte)(60)))));
            this.btnEditNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditNV.ForeColor = System.Drawing.Color.MediumTurquoise;
            this.btnEditNV.Location = new System.Drawing.Point(410, 585);
            this.btnEditNV.Name = "btnEditNV";
            this.btnEditNV.Size = new System.Drawing.Size(93, 45);
            this.btnEditNV.TabIndex = 42;
            this.btnEditNV.Text = "EDIT";
            this.btnEditNV.UseVisualStyleBackColor = false;
            this.btnEditNV.Click += new System.EventHandler(this.btnEditNV_Click);
            // 
            // btnAddNV
            // 
            this.btnAddNV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(43)))), ((int)(((byte)(60)))));
            this.btnAddNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddNV.ForeColor = System.Drawing.Color.MediumTurquoise;
            this.btnAddNV.Location = new System.Drawing.Point(125, 585);
            this.btnAddNV.Name = "btnAddNV";
            this.btnAddNV.Size = new System.Drawing.Size(93, 45);
            this.btnAddNV.TabIndex = 43;
            this.btnAddNV.Text = "ADD";
            this.btnAddNV.UseVisualStyleBackColor = false;
            this.btnAddNV.Click += new System.EventHandler(this.btnAddNV_Click);
            // 
            // txtFind
            // 
            this.txtFind.Location = new System.Drawing.Point(679, 24);
            this.txtFind.Multiline = true;
            this.txtFind.Name = "txtFind";
            this.txtFind.Size = new System.Drawing.Size(222, 37);
            this.txtFind.TabIndex = 45;
            this.txtFind.TextChanged += new System.EventHandler(this.txtFind_TextChange);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(988, 639);
            this.Controls.Add(this.txtFind);
            this.Controls.Add(this.dtgNV);
            this.Controls.Add(this.btnDeleteNV);
            this.Controls.Add(this.btnEditNV);
            this.Controls.Add(this.btnAddNV);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgNV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgNV;
        private System.Windows.Forms.Button btnDeleteNV;
        private System.Windows.Forms.Button btnEditNV;
        private System.Windows.Forms.Button btnAddNV;
        private System.Windows.Forms.TextBox txtFind;
        private System.Windows.Forms.DataGridViewTextBoxColumn cid_employee;
        private System.Windows.Forms.DataGridViewTextBoxColumn cphone;
        private System.Windows.Forms.DataGridViewTextBoxColumn cemployee_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn cdate_of_birth;
        private System.Windows.Forms.DataGridViewImageColumn cimage_url;
    }
}

