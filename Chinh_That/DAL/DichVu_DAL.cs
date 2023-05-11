using Chinh_That.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chinh_That.DAL
{
    internal class DichVu_DAL
    {
        private static DichVu_DAL instance;
        public static DichVu_DAL Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new DichVu_DAL();
                }
                return instance;
            }
            private set { }
        }
        public void delCY(int idCY)
        {
            using (QuanLiQuanNetEntities db = new QuanLiQuanNetEntities())
            {
                category cy = db.categories.Find(idCY);
                db.categories.Remove(cy);
                db.SaveChanges();
            }
        }
        public void addCY(category cy)
        {
            using (QuanLiQuanNetEntities db = new QuanLiQuanNetEntities())
            {
                db.categories.Add(cy);
                db.SaveChanges();
                MessageBox.Show("Đã thêm thành công loại mới !!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        public void editCY(category category)
        {
            using (QuanLiQuanNetEntities db = new QuanLiQuanNetEntities())
            {
                int cs = Convert.ToInt32(category.id);
                category cy = new category();
                cy = db.categories.Find(cs);
                cy.product_category_name = category.product_category_name;
                cy.image_category = category.image_category;
                db.SaveChanges();
                MessageBox.Show("Đã cập nhật thành công thông tin !!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        public void delP(int idP)
        {
            using (QuanLiQuanNetEntities db = new QuanLiQuanNetEntities())
            {
                product p = db.products.Find(idP);
                db.products.Remove(p);
                db.SaveChanges();
            }
        }
        public void addP(product p)
        {
            using (QuanLiQuanNetEntities db = new QuanLiQuanNetEntities())
            {
                db.products.Add(p);
                db.SaveChanges();
                MessageBox.Show("Đã thêm thành công sản phẩm mới !!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
       /* public void editP(product product)
        {
            using (QuanLiQuanNetEntities db = new QuanLiQuanNetEntities())
            {
                int cs = Convert.ToInt32(product.id);
                product cy = new product();
                cy = db.products.Find(cs);
                cy.product_category_name = category.product_category_name;
                cy.image_category = category.image_category;
                db.SaveChanges();
                MessageBox.Show("Đã cập nhật thành công thông tin sản phẩm !!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
       */
    }
}
