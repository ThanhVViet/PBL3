using Chinh_That.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chinh_That.DAL
{
    internal class MayTinh_DAL
    {
        private static MayTinh_DAL instance;
        public static MayTinh_DAL Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new MayTinh_DAL();
                }
                return instance;
            }
            private set { }
        }
        public void delCom(int idCom)
        {
            using (QuanLiQuanNetEntities db = new QuanLiQuanNetEntities())
            {
                computer com = db.computers.Find(idCom);
                db.computers.Remove(com);
                db.SaveChanges();
            }
        }
        public void addCom(computer com)
        {
            using (QuanLiQuanNetEntities db = new QuanLiQuanNetEntities())
            {
                db.computers.Add(com);
                db.SaveChanges();
                MessageBox.Show("Đã thêm thành công máy mới !!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        public void editCom(computer computer)
        {
            using (QuanLiQuanNetEntities db = new QuanLiQuanNetEntities())
            {
                int cs = Convert.ToInt32(computer.id);
                computer cp = new computer();
                cp = db.computers.Find(cs);
                cp.num_com = computer.num_com;
                cp.ip = computer.ip;
                cp.manufacturer = computer.manufacturer;
                cp.warranty = computer.warranty;
                db.SaveChanges();
                MessageBox.Show("Đã cập nhật thành công thông tin của máy !!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
