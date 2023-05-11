namespace Chinh_That
{
    partial class UserControl_P
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserControl_P));
            this.picBtnA = new System.Windows.Forms.PictureBox();
            this.lbPrice = new System.Windows.Forms.Label();
            this.lbIDP = new System.Windows.Forms.Label();
            this.Delete = new System.Windows.Forms.Button();
            this.lbNamePRO = new System.Windows.Forms.Label();
            this.picP = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picBtnA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picP)).BeginInit();
            this.SuspendLayout();
            // 
            // picBtnA
            // 
            this.picBtnA.Location = new System.Drawing.Point(161, 184);
            this.picBtnA.Name = "picBtnA";
            this.picBtnA.Size = new System.Drawing.Size(100, 38);
            this.picBtnA.TabIndex = 22;
            this.picBtnA.TabStop = false;
            // 
            // lbPrice
            // 
            this.lbPrice.AutoSize = true;
            this.lbPrice.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPrice.Location = new System.Drawing.Point(9, 277);
            this.lbPrice.Name = "lbPrice";
            this.lbPrice.Size = new System.Drawing.Size(80, 27);
            this.lbPrice.TabIndex = 21;
            this.lbPrice.Text = "lbPrice";
            // 
            // lbIDP
            // 
            this.lbIDP.AutoSize = true;
            this.lbIDP.Location = new System.Drawing.Point(11, 188);
            this.lbIDP.Name = "lbIDP";
            this.lbIDP.Size = new System.Drawing.Size(31, 16);
            this.lbIDP.TabIndex = 20;
            this.lbIDP.Text = "lbID";
            this.lbIDP.Visible = false;
            // 
            // Delete
            // 
            this.Delete.FlatAppearance.BorderSize = 0;
            this.Delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Delete.Image = ((System.Drawing.Image)(resources.GetObject("Delete.Image")));
            this.Delete.Location = new System.Drawing.Point(187, 257);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(71, 70);
            this.Delete.TabIndex = 19;
            this.Delete.UseVisualStyleBackColor = true;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // lbNamePRO
            // 
            this.lbNamePRO.AutoSize = true;
            this.lbNamePRO.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNamePRO.Location = new System.Drawing.Point(9, 237);
            this.lbNamePRO.Name = "lbNamePRO";
            this.lbNamePRO.Size = new System.Drawing.Size(136, 27);
            this.lbNamePRO.TabIndex = 18;
            this.lbNamePRO.Text = "lbNameFood";
            // 
            // picP
            // 
            this.picP.Dock = System.Windows.Forms.DockStyle.Top;
            this.picP.Location = new System.Drawing.Point(0, 0);
            this.picP.Name = "picP";
            this.picP.Size = new System.Drawing.Size(257, 178);
            this.picP.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picP.TabIndex = 17;
            this.picP.TabStop = false;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.MediumTurquoise;
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(202)))), ((int)(((byte)(99)))));
            this.label6.Location = new System.Drawing.Point(11, 304);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 2);
            this.label6.TabIndex = 78;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.MediumTurquoise;
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(202)))), ((int)(((byte)(99)))));
            this.label1.Location = new System.Drawing.Point(11, 264);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 2);
            this.label1.TabIndex = 79;
            // 
            // UserControl_P
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(39)))));
            this.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.picBtnA);
            this.Controls.Add(this.lbPrice);
            this.Controls.Add(this.lbIDP);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.lbNamePRO);
            this.Controls.Add(this.picP);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.Name = "UserControl_P";
            this.Size = new System.Drawing.Size(257, 325);
            ((System.ComponentModel.ISupportInitialize)(this.picBtnA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picP)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.PictureBox picBtnA;
        public System.Windows.Forms.Label lbPrice;
        public System.Windows.Forms.Label lbIDP;
        private System.Windows.Forms.Button Delete;
        public System.Windows.Forms.Label lbNamePRO;
        public System.Windows.Forms.PictureBox picP;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
    }
}
