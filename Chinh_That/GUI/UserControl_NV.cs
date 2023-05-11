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
using Chinh_That.BLL;
using Chinh_That.DTO;

namespace Chinh_That
{
    public partial class UserControl_NV : UserControl
    {
        public UserControl_NV(int id, string name, string phone, DateTime DOB, byte[] img, string email)
        {
            InitializeComponent();
            lbID.Text = id.ToString();
            lbN.Text = name;
            lbP.Text = phone.ToString();
            lbD.Text = DOB.ToShortDateString();
            if (img != null)
            {
                MemoryStream ms = new MemoryStream(img);
                pic1.Image = Image.FromStream(ms);
            }
            lbE.Text = email;
        } 
        private void btnDel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn xóa nhân viên này không ??", "Warning", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {            
                int lb = Convert.ToInt32(lbID.Text);             
                NhanVien_BLL.Instance.delNV(lb);
                this.Dispose();
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            employee ee = new employee();
            ee.id =Convert.ToInt32(lbID.Text);
            ee.employee_name = lbN.Text;
            ee.date_of_birth = DateTime.Parse(lbD.Text);
            ee.image_nv = ImageToByArray(pic1);
            ee.phone = lbP.Text;
            ee.email = lbE.Text;
            fNV k = new fNV(1, ee);
            k.nemdl += fKA_nemdl;
            k.ShowDialog();
        }
        private void fKA_nemdl(employee employee)
        {      
            lbN.Text = employee.employee_name;
            MemoryStream ms = new MemoryStream(employee.image_nv);
            pic1.Image = Image.FromStream(ms);
            lbE.Text = employee.email;
            lbP.Text = employee.phone;
            DateTime day = (DateTime)employee.date_of_birth;
            lbD.Text = day.ToShortDateString();
        }

        private byte[] ImageToByArray(PictureBox pictureBox)
        {
            MemoryStream ms = new MemoryStream();
            pic1.Image.Save(ms, pic1.Image.RawFormat);
            return ms.ToArray();
        }
    }
}
