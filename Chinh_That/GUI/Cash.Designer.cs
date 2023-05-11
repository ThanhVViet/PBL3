namespace Chinh_That
{
    partial class Cash
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cash));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.rjButton1 = new Chinh_That.Custom.RJButton();
            this.label3 = new System.Windows.Forms.Label();
            this.CashGivenBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TotalBillBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.CashReturnBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Black;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(550, 401);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.MediumTurquoise;
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(202)))), ((int)(((byte)(99)))));
            this.label5.Location = new System.Drawing.Point(175, 258);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(265, 2);
            this.label5.TabIndex = 79;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.MediumTurquoise;
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(202)))), ((int)(((byte)(99)))));
            this.label4.Location = new System.Drawing.Point(175, 194);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(265, 2);
            this.label4.TabIndex = 78;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.MediumTurquoise;
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(202)))), ((int)(((byte)(99)))));
            this.label6.Location = new System.Drawing.Point(175, 121);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(265, 2);
            this.label6.TabIndex = 77;
            // 
            // rjButton1
            // 
            this.rjButton1.BackColor = System.Drawing.Color.Black;
            this.rjButton1.BackgroundColor = System.Drawing.Color.Black;
            this.rjButton1.BorderColor = System.Drawing.Color.MediumTurquoise;
            this.rjButton1.BorderRadius = 0;
            this.rjButton1.BorderSize = 1;
            this.rjButton1.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.rjButton1.FlatAppearance.BorderSize = 0;
            this.rjButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjButton1.ForeColor = System.Drawing.Color.White;
            this.rjButton1.Location = new System.Drawing.Point(159, 306);
            this.rjButton1.Name = "rjButton1";
            this.rjButton1.Size = new System.Drawing.Size(233, 40);
            this.rjButton1.TabIndex = 76;
            this.rjButton1.Text = "Xác nhận";
            this.rjButton1.TextColor = System.Drawing.Color.White;
            this.rjButton1.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Black;
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label3.Location = new System.Drawing.Point(55, 237);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 25);
            this.label3.TabIndex = 74;
            this.label3.Text = "Trả lại";
            // 
            // CashGivenBox
            // 
            this.CashGivenBox.BackColor = System.Drawing.Color.Black;
            this.CashGivenBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CashGivenBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CashGivenBox.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.CashGivenBox.Location = new System.Drawing.Point(178, 164);
            this.CashGivenBox.Margin = new System.Windows.Forms.Padding(6);
            this.CashGivenBox.Name = "CashGivenBox";
            this.CashGivenBox.Size = new System.Drawing.Size(261, 27);
            this.CashGivenBox.TabIndex = 73;
            this.CashGivenBox.TextChanged += new System.EventHandler(this.CashGivenBox_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Black;
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label2.Location = new System.Drawing.Point(55, 171);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 25);
            this.label2.TabIndex = 72;
            this.label2.Text = "Số tiền đưa";
            // 
            // TotalBillBox
            // 
            this.TotalBillBox.BackColor = System.Drawing.Color.Black;
            this.TotalBillBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TotalBillBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalBillBox.ForeColor = System.Drawing.Color.White;
            this.TotalBillBox.Location = new System.Drawing.Point(178, 95);
            this.TotalBillBox.Margin = new System.Windows.Forms.Padding(6);
            this.TotalBillBox.Name = "TotalBillBox";
            this.TotalBillBox.Size = new System.Drawing.Size(261, 27);
            this.TotalBillBox.TabIndex = 71;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Location = new System.Drawing.Point(55, 98);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 25);
            this.label1.TabIndex = 70;
            this.label1.Text = "Tổng tiền";
            // 
            // CashReturnBox
            // 
            this.CashReturnBox.BackColor = System.Drawing.Color.Black;
            this.CashReturnBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CashReturnBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CashReturnBox.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.CashReturnBox.Location = new System.Drawing.Point(178, 225);
            this.CashReturnBox.Margin = new System.Windows.Forms.Padding(6);
            this.CashReturnBox.Name = "CashReturnBox";
            this.CashReturnBox.Size = new System.Drawing.Size(261, 27);
            this.CashReturnBox.TabIndex = 80;
            // 
            // Cash
            // 
            this.AcceptButton = this.rjButton1;
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(39)))));
            this.ClientSize = new System.Drawing.Size(550, 401);
            this.Controls.Add(this.CashReturnBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.rjButton1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.CashGivenBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TotalBillBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Cash";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cash";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private Custom.RJButton rjButton1;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox CashGivenBox;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox TotalBillBox;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox CashReturnBox;
    }
}