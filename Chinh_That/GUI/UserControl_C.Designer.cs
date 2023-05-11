namespace Chinh_That
{
    partial class UserControl_C
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserControl_C));
            this.picC = new System.Windows.Forms.PictureBox();
            this.picBtn = new System.Windows.Forms.PictureBox();
            this.lbID = new System.Windows.Forms.Label();
            this.Delete = new System.Windows.Forms.Button();
            this.lbNameFood = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnEdit_C = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBtn)).BeginInit();
            this.SuspendLayout();
            // 
            // picC
            // 
            this.picC.Dock = System.Windows.Forms.DockStyle.Top;
            this.picC.Location = new System.Drawing.Point(0, 0);
            this.picC.Name = "picC";
            this.picC.Size = new System.Drawing.Size(242, 207);
            this.picC.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picC.TabIndex = 8;
            this.picC.TabStop = false;
            // 
            // picBtn
            // 
            this.picBtn.Location = new System.Drawing.Point(136, 213);
            this.picBtn.Name = "picBtn";
            this.picBtn.Size = new System.Drawing.Size(100, 30);
            this.picBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBtn.TabIndex = 16;
            this.picBtn.TabStop = false;
            // 
            // lbID
            // 
            this.lbID.AutoSize = true;
            this.lbID.Location = new System.Drawing.Point(5, 213);
            this.lbID.Name = "lbID";
            this.lbID.Size = new System.Drawing.Size(31, 16);
            this.lbID.TabIndex = 15;
            this.lbID.Text = "lbID";
            this.lbID.Visible = false;
            // 
            // Delete
            // 
            this.Delete.FlatAppearance.BorderSize = 0;
            this.Delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Delete.Image = ((System.Drawing.Image)(resources.GetObject("Delete.Image")));
            this.Delete.Location = new System.Drawing.Point(164, 252);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(75, 69);
            this.Delete.TabIndex = 14;
            this.Delete.UseVisualStyleBackColor = true;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // lbNameFood
            // 
            this.lbNameFood.AutoSize = true;
            this.lbNameFood.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNameFood.Location = new System.Drawing.Point(3, 284);
            this.lbNameFood.Name = "lbNameFood";
            this.lbNameFood.Size = new System.Drawing.Size(136, 27);
            this.lbNameFood.TabIndex = 13;
            this.lbNameFood.Text = "lbNameFood";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.MediumTurquoise;
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(202)))), ((int)(((byte)(99)))));
            this.label1.Location = new System.Drawing.Point(5, 311);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 2);
            this.label1.TabIndex = 80;
            // 
            // btnEdit_C
            // 
            this.btnEdit_C.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit_C.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit_C.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnEdit_C.Location = new System.Drawing.Point(3, 213);
            this.btnEdit_C.Name = "btnEdit_C";
            this.btnEdit_C.Size = new System.Drawing.Size(74, 34);
            this.btnEdit_C.TabIndex = 81;
            this.btnEdit_C.Text = "Edit";
            this.btnEdit_C.UseVisualStyleBackColor = true;
            this.btnEdit_C.Click += new System.EventHandler(this.btnEdit_NV_Click);
            // 
            // UserControl_C
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(39)))));
            this.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Controls.Add(this.btnEdit_C);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.picBtn);
            this.Controls.Add(this.lbID);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.lbNameFood);
            this.Controls.Add(this.picC);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.Name = "UserControl_C";
            this.Size = new System.Drawing.Size(242, 324);
            ((System.ComponentModel.ISupportInitialize)(this.picC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBtn)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.PictureBox picC;
        public System.Windows.Forms.PictureBox picBtn;
        public System.Windows.Forms.Label lbID;
        private System.Windows.Forms.Button Delete;
        public System.Windows.Forms.Label lbNameFood;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnEdit_C;
    }
}
