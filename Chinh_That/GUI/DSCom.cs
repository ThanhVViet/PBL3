using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.WebRequestMethods;
using Chinh_That.DTO;

namespace Chinh_That
{
    public partial class DSCom : Form
    {
        QuanLiQuanNetEntities db;
        public DSCom()
        {
            InitializeComponent();
            
        }
        private void btnAdd_Com_Click(object sender, EventArgs e)
        {
            db = new QuanLiQuanNetEntities();
            fCOM fc = new fCOM(0);              
            fc.nemdl += K_nemdl;
            fc.ShowDialog();
            
        }
        public void Retrieve()
        {
            db = new QuanLiQuanNetEntities();
            List<computer> computers = db.computers.ToList();
            foreach (computer cp in computers)
            {
                UserControl_COM us = new UserControl_COM(
                    cp.num_com, cp.id,cp.manufacturer,cp.warranty,cp.ip);
                FLPCom.Controls.Add(us);
            }
        }
        private void K_nemdl(computer w)
        {
            UserControl_COM us = new UserControl_COM(w.num_com,w.id, w.manufacturer, w.warranty,w.ip.ToString());
            FLPCom.Controls.Add(us);
        }

        private void DSCom_Load(object sender, EventArgs e)
        {
            Retrieve();
        }
    }
}
