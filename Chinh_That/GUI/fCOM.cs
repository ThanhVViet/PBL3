using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.WebRequestMethods;
using Chinh_That.DTO;
using Chinh_That.BLL;

namespace Chinh_That
{
    public delegate void NemDL1(computer cp);
    public partial class fCOM : Form
    {
        public event NemDL1 nemdl;
        QuanLiQuanNetEntities db;      
        public int IDS;
     
        public fCOM(int iDS)
        {
            InitializeComponent();
            IDS = iDS;
        }
        public fCOM(int iDS, computer cp)
        {
             InitializeComponent(); 
             lbIDCOM.Text = cp.id.ToString();
             txtIP.Text = cp.ip;
             txtCom.Text = cp.num_com;
             txtNSX.Text = cp.manufacturer;
             txtWa.Text = cp.warranty;          
             IDS = iDS;
        }
    
        private void btnSaveCom_Click(object sender, EventArgs e)
        {
            if (IDS == 0)
            {
                computer cp = new computer();
                cp.ip = txtIP.Text;
                cp.num_com = txtCom.Text;
                cp.manufacturer = txtNSX.Text;
                cp.warranty = txtWa.Text;
                MayTinh_BLL.Instance.addCom(cp);
                if (nemdl != null)
                {
                    nemdl(cp);
                }
            }
            else
            {
                computer cp = new computer();
                cp.id = Convert.ToInt32(lbIDCOM.Text);
                cp.ip = txtIP.Text;
                cp.num_com =txtCom.Text;
                cp.manufacturer = txtNSX.Text;
                cp.warranty = txtWa.Text;
                MayTinh_BLL.Instance.editCom(cp);            
                if (nemdl != null)
                {
                    nemdl(cp);
                }
            }
        }

       
    }
}
