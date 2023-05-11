namespace Chinh_That
{
    partial class ADD_C
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ADD_C));
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCY = new System.Windows.Forms.TextBox();
            this.picCY = new System.Windows.Forms.PictureBox();
            this.AddCategoryButton = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbID = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picCY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Location = new System.Drawing.Point(13, 46);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 25);
            this.label1.TabIndex = 16;
            this.label1.Text = "Category Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label3.Location = new System.Drawing.Point(13, 132);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(157, 25);
            this.label3.TabIndex = 17;
            this.label3.Text = "Category Picture";
            // 
            // txtCY
            // 
            this.txtCY.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(39)))));
            this.txtCY.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCY.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCY.ForeColor = System.Drawing.Color.Honeydew;
            this.txtCY.Location = new System.Drawing.Point(193, 41);
            this.txtCY.Margin = new System.Windows.Forms.Padding(4);
            this.txtCY.Name = "txtCY";
            this.txtCY.Size = new System.Drawing.Size(287, 23);
            this.txtCY.TabIndex = 18;
            // 
            // picCY
            // 
            this.picCY.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picCY.Location = new System.Drawing.Point(193, 132);
            this.picCY.Margin = new System.Windows.Forms.Padding(4);
            this.picCY.Name = "picCY";
            this.picCY.Size = new System.Drawing.Size(287, 221);
            this.picCY.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picCY.TabIndex = 19;
            this.picCY.TabStop = false;
            this.picCY.DoubleClick += new System.EventHandler(this.CategoryPictureBox_DoubleClick);
            // 
            // AddCategoryButton
            // 
            this.AddCategoryButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.AddCategoryButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddCategoryButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddCategoryButton.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.AddCategoryButton.Location = new System.Drawing.Point(164, 416);
            this.AddCategoryButton.Margin = new System.Windows.Forms.Padding(4);
            this.AddCategoryButton.Name = "AddCategoryButton";
            this.AddCategoryButton.Size = new System.Drawing.Size(173, 41);
            this.AddCategoryButton.TabIndex = 21;
            this.AddCategoryButton.Text = "SAVE";
            this.AddCategoryButton.UseVisualStyleBackColor = true;
            this.AddCategoryButton.Click += new System.EventHandler(this.AddCategoryButton_Click);
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.MediumTurquoise;
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(202)))), ((int)(((byte)(99)))));
            this.label6.Location = new System.Drawing.Point(190, 69);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(290, 2);
            this.label6.TabIndex = 67;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-8, 307);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(152, 110);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 68;
            this.pictureBox1.TabStop = false;
            // 
            // lbID
            // 
            this.lbID.AutoSize = true;
            this.lbID.Location = new System.Drawing.Point(52, 13);
            this.lbID.Name = "lbID";
            this.lbID.Size = new System.Drawing.Size(44, 16);
            this.lbID.TabIndex = 69;
            this.lbID.Text = "label2";
            this.lbID.Visible = false;
            // 
            // ADD_C
            // 
            this.AcceptButton = this.AddCategoryButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(39)))));
            this.ClientSize = new System.Drawing.Size(503, 482);
            this.Controls.Add(this.lbID);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.AddCategoryButton);
            this.Controls.Add(this.picCY);
            this.Controls.Add(this.txtCY);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "ADD_C";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ADD_C";
            ((System.ComponentModel.ISupportInitialize)(this.picCY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCY;
        private System.Windows.Forms.PictureBox picCY;
        private System.Windows.Forms.Button AddCategoryButton;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.Label lbID;
    }
}