using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AD1
{
   
    public partial class Form2 : Form
    {
        QuanLyEntities db;
        public int IDS;
        public Form2(int iDS)
        {
            InitializeComponent();
            IDS = iDS;
        }
       
        public event NemDL nemdl = null;


        public Form2(int iDS, employee obj)
        {
            InitializeComponent();
            dtp.Value = (DateTime)obj.date_of_birth;
            txtNVADD.Text = obj.employee_name;
            MemoryStream ms = new MemoryStream(obj.image_url);
            pictureBox1.Image = Image.FromStream(ms);
            txtPhoneADD.Text = obj.phone;
            IDS = iDS;
        }
        private void btnSaveNV_Click(object sender, EventArgs e)
        {
            if (IDS == 0)
            {
                employee NV = new employee();
                NV.employee_name = txtNVADD.Text;
                NV.date_of_birth = dtp.Value;
                NV.phone = txtPhoneADD.Text;
                MemoryStream ms = new MemoryStream();
                pictureBox1.Image.Save(ms, pictureBox1.Image.RawFormat);
                byte[] NVpic  = ms.GetBuffer();
                ms.Close();
                NV.image_url = NVpic;
                db = new QuanLyEntities();
                db.employees.Add(NV);
                db.SaveChanges();
            }
            else
            {
                employee NV = new employee();
                NV.employee_name = txtNVADD.Text;
                NV.date_of_birth = dtp.Value;
                NV.phone = txtPhoneADD.Text;
                MemoryStream ms = new MemoryStream();
                pictureBox1.Image.Save(ms, pictureBox1.Image.RawFormat);
                byte[] NVpic = ms.GetBuffer();
                ms.Close();
                NV.image_url = NVpic;
                if (nemdl != null) nemdl(NV);
            }
        }
    
        private void btnUpload_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Please choose a picture";
            ofd.Filter = "JPG|*.jpg|PNG|*.png|GIF|*gif";
            ofd.Multiselect = false;
            if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                this.pictureBox1.ImageLocation = ofd.FileName;

            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {
           
        }
    }
}
