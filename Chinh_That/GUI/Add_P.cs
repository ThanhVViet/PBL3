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
   
    public partial class Add_P : Form
    {      
        public Add_P()
        {
            InitializeComponent();
            SetCBB();
           
        }
        private void AddProductButton_Click(object sender, EventArgs e)
        {           
                product pc = new product
                {
                    product_name = txtP_Name.Text,
                    prices = Convert.ToInt32(txtP_P.Text),
                    id_product_category = ((CBBItem)cbbP.SelectedItem).Value
                };

                MemoryStream ms = new MemoryStream();
                picP.Image.Save(ms, picP.Image.RawFormat);
                byte[] PPic = ms.GetBuffer();
                ms.Close();
                pc.image_url = PPic;
                DichVu_BLL.Instance.addP(pc);        
        }
        public void SetCBB()
        {
            QuanLiQuanNetEntities db = new QuanLiQuanNetEntities();
            foreach (category i in db.categories)
            {
                cbbP.Items.Add(new CBBItem
                {
                    Value = i.id,
                    Text = i.product_category_name
                });
            }

        }
        private void ProductPictureBox_DoubleClick(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            if (open.ShowDialog() == DialogResult.OK)
            {
                picP.ImageLocation = open.FileName;
            }
        }
    }
}
