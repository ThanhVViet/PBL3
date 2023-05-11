using Chinh_That.DAL;
using Chinh_That.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chinh_That.BLL
{
    internal class DichVu_BLL
    {
        private static DichVu_BLL instance;
        public static DichVu_BLL Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new DichVu_BLL();
                }
                return instance;
            }
        }
        public void delCY(int idCY)
        {
            DichVu_DAL.Instance.delCY(idCY);
        }
        public void addCY (category cy)
        {
            DichVu_DAL.Instance.addCY(cy);
        }
        public void editCY(category cy)
        {
            DichVu_DAL.Instance.editCY(cy);
        }
        public void delP(int idP)
        {
            DichVu_DAL.Instance.delP(idP);
        }
        public void addP(product p)
        {
            DichVu_DAL.Instance.addP(p);
        }
    }
}
