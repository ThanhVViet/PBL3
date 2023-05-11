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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;
using Chinh_That.DTO;

namespace Chinh_That
{
    public partial class UpdateProduct : Form
    {
        product product;
        public UpdateProduct(product product)
        {
            InitializeComponent();
            this.product = product;
            SetCBB();
        }

        private void Update_Products_Load(object sender, EventArgs e)
        {
            ProductIDBox.Text = product.id.ToString();
            ProductNameBox.Text = product.product_name;
            ProductPriceBox.Text = product.prices.ToString();
            ProductCategoryComboBox.Text = product.category.product_category_name;
            MemoryStream ms = new MemoryStream(product.image_url);
            ProductPictureBox.Image = Image.FromStream(ms);
        }
        private void UpdateProductButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thay đổi thông tin không ?", "Warning", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                MemoryStream ms = new MemoryStream();
                ProductPictureBox.Image.Save(ms, ProductPictureBox.Image.RawFormat);
                byte[] PP = ms.GetBuffer();
                ms.Close();
                QuanLiQuanNetEntities db = new QuanLiQuanNetEntities();
                int ProductID = Convert.ToInt32(ProductIDBox.Text);
                product pd = db.products.Where(p => p.id == ProductID).FirstOrDefault();
                pd.product_name = ProductNameBox.Text;
                pd.prices = Convert.ToInt32(ProductPriceBox.Text);
                pd.id_product_category = ((CBBItem)ProductCategoryComboBox.SelectedItem).Value;
                pd.image_url = PP;
                db.SaveChanges();
            }
        }
        public void SetCBB()
        {
            QuanLiQuanNetEntities db = new QuanLiQuanNetEntities();
            foreach (category i in db.categories)
            {
                ProductCategoryComboBox.Items.Add(new CBBItem
                {
                    Value = i.id,
                    Text = i.product_category_name
                });
            }

        }
        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    } 
}
