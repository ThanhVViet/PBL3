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
    public partial class UserControl_C : UserControl
    {
        public UserControl_C(string name, byte[] image_c, int id)
        {
            InitializeComponent();
            lbNameFood.Text = name;          
            if (image_c != null)
            {
                MemoryStream ms = new MemoryStream(image_c);
                picC.Image = Image.FromStream(ms);
            }
            lbID.Text = id.ToString();
        }
        private void Delete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn xóa không ??", "Warning", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                int lb = Convert.ToInt32(lbID.Text);
                DichVu_BLL.Instance.delCY(lb);
                this.Dispose();
            }
        }
        private void btnEdit_NV_Click(object sender, EventArgs e)
        {
            category cy = new category();
            cy.id = Convert.ToInt32(lbID.Text);
            cy.product_category_name = lbNameFood.Text;
            cy.image_category = ImageToByArray(picC);
            ADD_C ac = new ADD_C(1, cy);
            ac.nemdl += fCY_nemdl;
            ac.ShowDialog();
        }
        private void fCY_nemdl(category category)
        {
            lbNameFood.Text = category.product_category_name;
            MemoryStream ms = new MemoryStream(category.image_category);
            picC.Image = Image.FromStream(ms);
        }
        private byte[] ImageToByArray(PictureBox pictureBox)
        {
            MemoryStream ms = new MemoryStream();
            picC.Image.Save(ms, picC.Image.RawFormat);
            return ms.ToArray();
        }
    }
}
