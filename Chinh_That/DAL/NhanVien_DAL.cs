using Chinh_That.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chinh_That.DAL
{
    internal class NhanVien_DAL
    {
        private static NhanVien_DAL instance;
        public static NhanVien_DAL Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new NhanVien_DAL();
                }
                return instance;
            }
            private set { }
        }
        public void delNV(int idNV)
        {
            using (QuanLiQuanNetEntities db = new QuanLiQuanNetEntities())
            {
                employee e = db.employees.Find(idNV);
                db.employees.Remove(e);
                db.SaveChanges();
            }
        }
        public void addNV(employee e)
        {
            using (QuanLiQuanNetEntities db = new QuanLiQuanNetEntities())
            {
                db.employees.Add(e);
                db.SaveChanges();
                MessageBox.Show("Đã thêm thành công nhân viên !!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        public void editNV(employee employee)
        {
            using (QuanLiQuanNetEntities db = new QuanLiQuanNetEntities())
            {             
                int cs = Convert.ToInt32(employee.id);
                employee e = new employee();
                e = db.employees.Find(cs);
                e.employee_name = employee.employee_name;
                e.date_of_birth = employee.date_of_birth;
                e.phone = employee.phone;
                e.image_nv = employee.image_nv;
                e.email = employee.email;
                db.SaveChanges();
                MessageBox.Show("Đã cập nhật thành công thông tin nhân viên !!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

    }
}
