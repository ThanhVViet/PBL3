using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Chinh_That.BLL;
using Chinh_That.DTO;

namespace Chinh_That
{
    public partial class UserControlDisplay : UserControl
    {
        public UserControlDisplay(int id, string name, string timeStart, string timeEnd, DateTime daywork)
        {
            InitializeComponent();
            labelID.Text = id.ToString();
            labelName.Text = name;
            labelDay.Text = daywork.ToShortDateString();
            labelStartTime.Text = timeStart;
            labelTimeEnd.Text = timeEnd;
        }
        private void btnDel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn xóa ca làm này không ??", "Warning", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                int lb = Convert.ToInt32(labelID.Text);
                CaLam_BLL.Instance.delCa(lb);
                this.Dispose();
            }
        }

        private void btnEdit_Ca_Click(object sender, EventArgs e)
        {         
            worktime ww = new worktime();
            ww.id = Convert.ToInt32(labelID.Text);
            ww.employee_name = labelName.Text;
            ww.daywork = DateTime.Parse(labelDay.Text);
            ww.start_time = labelStartTime.Text;
            ww.end_time = labelTimeEnd.Text;         
            fCA k = new fCA(1, ww);          
            k.nemdl += fCA_nemdl;
            k.ShowDialog();
        }
        private void fCA_nemdl(worktime w)
        {
            labelName.Text = w.employee_name;
            labelStartTime.Text = w.start_time;
            labelTimeEnd.Text = w.end_time;
        }
    }
}
