using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Chinh_That.BLL;
using Chinh_That.DTO;

namespace Chinh_That
{
    public partial class View_P : Form
    {
        QuanLiQuanNetEntities db;
        public View_P()
        {
            InitializeComponent();

        }

        private void View_P_Load(object sender, EventArgs e)
        {
            db = new QuanLiQuanNetEntities();
            ProductCategoryComboBox.Items.Add("All Categories");
            foreach (category c in db.categories)
            {
                ProductCategoryComboBox.Items.Add(c.product_category_name);
            }
            ProductCategoryComboBox.SelectedIndex = 0;

        }

        private void ProductCategoryComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
           
            ProductsGridView.Rows.Clear();

            if (ProductCategoryComboBox.SelectedIndex == 0)
            {
                QuanLiQuanNetEntities db = new QuanLiQuanNetEntities();
                List<product> products = db.products.ToList();
                foreach (product product in products)
                {
                    category category = db.categories.Where(p => p.id == product.id_product_category).FirstOrDefault();
                    ProductsGridView.Rows.Add(product.id, product.product_name, product.prices, category.product_category_name, product.image_url);
                }
            }

            else if (ProductCategoryComboBox.SelectedIndex > 0)
            {
                string CategoryName = ProductCategoryComboBox.SelectedItem.ToString();
                QuanLiQuanNetEntities db = new QuanLiQuanNetEntities();
                category category = db.categories.Where(p => p.product_category_name == CategoryName).FirstOrDefault();
                int CategoryID = category.id;
                List<product> products = db.products.Where(p => p.id_product_category == CategoryID).ToList();
                foreach (product product in products)
                {
                    ProductsGridView.Rows.Add(product.id, product.product_name, product.prices, category.product_category_name, product.image_url);
                }

            }

        }
        private void ProductsGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (ProductsGridView.Columns[e.ColumnIndex].Name == "DeleteProductColumn")
                {
                    if (MessageBox.Show("Bạn có chắc là muốn xóa sản phẩm không ?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        QuanLiQuanNetEntities db = new QuanLiQuanNetEntities();
                        int ProductID = Convert.ToInt32(ProductsGridView.Rows[e.RowIndex].Cells[0].Value);
                        DichVu_BLL.Instance.delP(ProductID);
                        LoadData();
                    }
                }
                else if (ProductsGridView.Columns[e.ColumnIndex].Name == "EditProductColumn")
                {
                    int ProductID = Convert.ToInt32(ProductsGridView.Rows[e.RowIndex].Cells["ProductIDColumn"].Value);
                    QuanLiQuanNetEntities db = new QuanLiQuanNetEntities();
                    product product = db.products.Where(p => p.id == ProductID).FirstOrDefault();
                    UpdateProduct update = new UpdateProduct(product);
                    update.ShowDialog();
                    LoadData();
                }
            }
        }
        public void LoadData()
        {
            ProductsGridView.Rows.Clear();
            db = new QuanLiQuanNetEntities();
            List<product> products = db.products.ToList();
            foreach (product product in products)
            {
                category category = db.categories.Where(p => p.id == product.id_product_category).FirstOrDefault();
                ProductsGridView.Rows.Add(product.id, product.product_name, product.prices, category.product_category_name, product.image_url);
            }
        }
    }
}
