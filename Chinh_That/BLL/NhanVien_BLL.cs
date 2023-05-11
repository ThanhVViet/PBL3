using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Chinh_That.DAL;
using Chinh_That.DTO;

namespace Chinh_That.BLL
{
    internal class NhanVien_BLL
    {
        private static NhanVien_BLL instance;
        public static NhanVien_BLL Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new NhanVien_BLL();
                }
                return instance;
            }
        }
        public void delNV(int idNV)
        {
            NhanVien_DAL.Instance.delNV(idNV);
        }
        public void addNV(employee e)
        {
            NhanVien_DAL.Instance.addNV(e);
        }
        public void editNV(employee e)
        {
            NhanVien_DAL.Instance.editNV(e);
        }
    }
}
