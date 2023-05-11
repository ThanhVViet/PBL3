using Chinh_That.DAL;
using Chinh_That.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chinh_That.BLL
{
    internal class MayTinh_BLL
    {
        private static MayTinh_BLL instance;
        public static MayTinh_BLL Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new MayTinh_BLL();
                }
                return instance;
            }
        }
        public void delCom(int idCom)
        {
            MayTinh_DAL.Instance.delCom(idCom);
        }
        public void addCom(computer com)
        {
            MayTinh_DAL.Instance.addCom(com);
        }
        public void editCom(computer com)
        {
            MayTinh_DAL.Instance.editCom(com);
        }
    }
}
