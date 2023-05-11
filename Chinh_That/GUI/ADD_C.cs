using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Chinh_That.BLL;
using Chinh_That.DAL;
using Chinh_That.DTO;

namespace Chinh_That
{
    public delegate void NemDL_C(category cy);
    public partial class ADD_C : Form
    {
        public event NemDL_C nemdl;
      
        public int IDS;
        public ADD_C(int iDS)
        {
            InitializeComponent();
            IDS = iDS;
        }
        public ADD_C(int iDS, category cy)
        {
            InitializeComponent();
            lbID.Text = cy.id.ToString();
            txtCY.Text = cy.product_category_name;
            if (cy.image_category != null)
            {
                MemoryStream ms = new MemoryStream(cy.image_category);
                picCY.Image = Image.FromStream(ms);
            }
           
            IDS = iDS;
        }
        private void AddCategoryButton_Click(object sender, EventArgs e)
        {
            if (IDS == 0)
            {
                QuanLiQuanNetEntities db = new QuanLiQuanNetEntities();
                category cy = new category();
                cy.product_category_name = txtCY.Text;
                MemoryStream ms = new MemoryStream();
                picCY.Image.Save(ms, picCY.Image.RawFormat);
                byte[] CategoryPic = ms.GetBuffer();
                ms.Close();
                cy.image_category = CategoryPic;
                DichVu_BLL.Instance.addCY(cy);
            }
            else
            {
                QuanLiQuanNetEntities db = new QuanLiQuanNetEntities();
                category cy = new category();
                cy.id = Convert.ToInt32(lbID.Text);
                cy.product_category_name = txtCY.Text;
                MemoryStream ms = new MemoryStream();
                picCY.Image.Save(ms, picCY.Image.RawFormat);
                byte[] CategoryPic = ms.GetBuffer();
                ms.Close();
                cy.image_category = CategoryPic;
                DichVu_BLL.Instance.editCY(cy);
                if (nemdl != null) nemdl(cy);
            }
        }
        private void CategoryPictureBox_DoubleClick(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            if (open.ShowDialog() == DialogResult.OK)
            {
                picCY.ImageLocation = open.FileName;
            }
        }
    }
}
