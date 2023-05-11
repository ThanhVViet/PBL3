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
    public partial class UserControl_P : UserControl
    {
         public UserControl_P(string nameFood, byte[] image_p, int id, decimal price)
        {
            InitializeComponent();
            lbNamePRO.Text = nameFood;
            lbPrice.Text = price.ToString();
            lbIDP.Text = id.ToString();
            if (image_p != null)
            {
                MemoryStream ms = new MemoryStream(image_p);
                picP.Image = System.Drawing.Image.FromStream(ms);
            }
        }
        private void Delete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn xóa sản phẩm không ??", "Warning", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {            
                int lb = Convert.ToInt32(lbIDP.Text);
                DichVu_BLL.Instance.delP(lb);
                this.Dispose();
            }
        }
       
    }
}

