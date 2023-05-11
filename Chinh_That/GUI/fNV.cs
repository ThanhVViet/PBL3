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
using static System.Net.WebRequestMethods;
using Chinh_That.DTO;
using Chinh_That.BLL;

namespace Chinh_That
{
    public delegate void NemDL(employee e);
    public partial class fNV : Form
    {
       
        public event NemDL nemdl;
        public int IDS;
        public fNV(int iDS)
        {
            InitializeComponent();
            IDS = iDS;
        }
        public fNV(int iDS, employee obj)
        {
            InitializeComponent();
            lbID.Text = obj.id.ToString();
            txtName.Text = obj.employee_name;
            dtpDOB.Value = (DateTime)obj.date_of_birth;
            txtPhone.Text = obj.phone;
            if (obj.image_nv != null)
            {
                MemoryStream ms = new MemoryStream(obj.image_nv);
                picNV.Image = Image.FromStream(ms);
            }
            txtEmail.Text = obj.email;
            IDS = iDS;
        }

        private void pic1_DoubleClick(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            if (open.ShowDialog() == DialogResult.OK)
            {
                picNV.ImageLocation = open.FileName;
            }
        }
        private void btnSaveNV_Click(object sender, EventArgs e)
        {
            if (IDS == 0)
            {
                employee ee = new employee();
                ee.employee_name = txtName.Text;
                ee.date_of_birth = dtpDOB.Value;
                ee.phone = txtPhone.Text;
                ee.image_nv = ImageToByArray(picNV);
                ee.email = txtEmail.Text;
                NhanVien_BLL.Instance.addNV(ee);
                if (nemdl != null)
                {
                    nemdl(ee);
                }
            }
            else
            {
                employee ee = new employee();
                ee.id = Convert.ToInt32(lbID.Text);
                ee.employee_name = txtName.Text;
                ee.date_of_birth = dtpDOB.Value;            
                ee.phone = txtPhone.Text;
                ee.image_nv = ImageToByArray(picNV);             
                ee.email = txtEmail.Text;
                NhanVien_BLL.Instance.editNV(ee);
                if (nemdl != null) nemdl(ee);
            }
        }
        private byte[] ImageToByArray(PictureBox pictureBox)
        {
            MemoryStream ms = new MemoryStream();
            picNV.Image.Save(ms, picNV.Image.RawFormat);
            return ms.ToArray();
        }
    }
}
