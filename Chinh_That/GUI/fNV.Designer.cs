namespace Chinh_That
{
    partial class fNV
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fNV));
            this.btnSaveNV = new System.Windows.Forms.Button();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.picNV = new Chinh_That.Custom.RJPictureBox();
            this.dtpDOB = new Chinh_That.Custom.RJDatePicker();
            this.lbID = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picNV)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSaveNV
            // 
            this.btnSaveNV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(43)))), ((int)(((byte)(60)))));
            this.btnSaveNV.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnSaveNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveNV.ForeColor = System.Drawing.Color.MediumTurquoise;
            this.btnSaveNV.Location = new System.Drawing.Point(221, 692);
            this.btnSaveNV.Name = "btnSaveNV";
            this.btnSaveNV.Size = new System.Drawing.Size(120, 45);
            this.btnSaveNV.TabIndex = 57;
            this.btnSaveNV.Text = "SAVE";
            this.btnSaveNV.UseVisualStyleBackColor = false;
            this.btnSaveNV.Click += new System.EventHandler(this.btnSaveNV_Click);
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(258, 40);
            this.txtName.Multiline = true;
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(278, 39);
            this.txtName.TabIndex = 54;
            // 
            // txtPhone
            // 
            this.txtPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPhone.Location = new System.Drawing.Point(258, 227);
            this.txtPhone.Multiline = true;
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(278, 38);
            this.txtPhone.TabIndex = 55;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(25, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(164, 29);
            this.label3.TabIndex = 60;
            this.label3.Text = "Tên nhân viên";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(25, 143);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(119, 29);
            this.label4.TabIndex = 59;
            this.label4.Text = "Ngày sinh";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(25, 236);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(154, 29);
            this.label5.TabIndex = 58;
            this.label5.Text = "Số điện thoại";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(25, 531);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(158, 25);
            this.label2.TabIndex = 61;
            this.label2.Text = "Ảnh Chân Dung ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(25, 344);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 29);
            this.label1.TabIndex = 64;
            this.label1.Text = "Email";
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(258, 335);
            this.txtEmail.Multiline = true;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(278, 38);
            this.txtEmail.TabIndex = 65;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-1, 597);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(201, 175);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 66;
            this.pictureBox1.TabStop = false;
            // 
            // picNV
            // 
            this.picNV.BorderCapStyle = System.Drawing.Drawing2D.DashCap.Flat;
            this.picNV.BorderColor = System.Drawing.Color.RoyalBlue;
            this.picNV.BorderColor2 = System.Drawing.Color.HotPink;
            this.picNV.BorderLineStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            this.picNV.BorderSize = 2;
            this.picNV.GradientAngle = 50F;
            this.picNV.Location = new System.Drawing.Point(258, 402);
            this.picNV.Name = "picNV";
            this.picNV.Size = new System.Drawing.Size(268, 268);
            this.picNV.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picNV.TabIndex = 63;
            this.picNV.TabStop = false;
            this.picNV.DoubleClick += new System.EventHandler(this.pic1_DoubleClick);
            // 
            // dtpDOB
            // 
            this.dtpDOB.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.dtpDOB.BorderSize = 0;
            this.dtpDOB.CustomFormat = "yyyy-MM-dd";
            this.dtpDOB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDOB.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDOB.Location = new System.Drawing.Point(258, 139);
            this.dtpDOB.MinimumSize = new System.Drawing.Size(4, 35);
            this.dtpDOB.Name = "dtpDOB";
            this.dtpDOB.Size = new System.Drawing.Size(278, 35);
            this.dtpDOB.SkinColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(202)))), ((int)(((byte)(99)))));
            this.dtpDOB.TabIndex = 62;
            this.dtpDOB.TextColor = System.Drawing.Color.White;
            // 
            // lbID
            // 
            this.lbID.AutoSize = true;
            this.lbID.Location = new System.Drawing.Point(30, 13);
            this.lbID.Name = "lbID";
            this.lbID.Size = new System.Drawing.Size(44, 16);
            this.lbID.TabIndex = 67;
            this.lbID.Text = "label6";
            this.lbID.Visible = false;
            // 
            // fNV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(39)))));
            this.ClientSize = new System.Drawing.Size(577, 770);
            this.Controls.Add(this.lbID);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.picNV);
            this.Controls.Add(this.dtpDOB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.btnSaveNV);
            this.Name = "fNV";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "fNV";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picNV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSaveNV;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private Custom.RJDatePicker dtpDOB;
        private Custom.RJPictureBox picNV;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.Label lbID;
    }
}