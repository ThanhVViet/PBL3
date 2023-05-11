using Chinh_That.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chinh_That.DAL
{
    internal class CaLam_DAL
    {
        private static CaLam_DAL instance;
        public static CaLam_DAL Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new CaLam_DAL();
                }
                return instance;
            }
            private set { }
        }
        public void del(int idCA)
        {
            using (QuanLiQuanNetEntities db = new QuanLiQuanNetEntities())
            {
                worktime w = db.worktimes.Find(idCA);
                db.worktimes.Remove(w);
                db.SaveChanges();              
            }
        }
        public void add(worktime w)
        {
            using (QuanLiQuanNetEntities db = new QuanLiQuanNetEntities())
            {
                db.worktimes.Add(w);
                db.SaveChanges();
                MessageBox.Show("Đã thêm thành công ca làm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        public void edit(worktime w)
        {
            using (QuanLiQuanNetEntities db = new QuanLiQuanNetEntities())
            {
                int cs = Convert.ToInt32(w.id);
                worktime ww = new worktime();
                ww = db.worktimes.Find(cs);
                ww.employee_name = w.employee_name;
                ww.start_time = w.start_time;
                ww.end_time = w.end_time;           
                db.SaveChanges();
                MessageBox.Show("Đã cập nhật thành công ca làm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
