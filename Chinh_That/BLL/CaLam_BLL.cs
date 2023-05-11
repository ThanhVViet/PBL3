using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Chinh_That.DAL;
using Chinh_That.DTO;

namespace Chinh_That.BLL
{
    internal class CaLam_BLL
    {
        private static CaLam_BLL instance;
        public static CaLam_BLL Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new CaLam_BLL();
                }
                return instance;
            }
        }
        public void delCa(int idCa)
        {
            CaLam_DAL.Instance.del(idCa);
        }
        public void addCa(worktime w)
        {         
             CaLam_DAL.Instance.add(w);
        }
        public void editCa(worktime w)
        {           
              CaLam_DAL.Instance.edit(w);        
        }
    }
}
