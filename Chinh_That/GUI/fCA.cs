using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using Chinh_That.BLL;
using Chinh_That.DTO;

namespace Chinh_That
{
    public delegate void NemDLW(worktime w);

    public partial class fCA : Form
    {
        int Day, Month, Year;
        public event NemDLW nemdl;
        public int IDS;
        private void btnSAve_Click(object sender, EventArgs e)
        {
            if (IDS == 0)
            {
                worktime W = new worktime();
                W.employee_name = txtName.Text;
                W.start_time = dtp1.Text;
                W.end_time = dtp2.Text;
                W.daywork = (DateTime)dtpDDay.Value;
                CaLam_BLL.Instance.addCa(W);
            }
            else
            {
                worktime W = new worktime();
                W.id = Convert.ToInt32(lbIDCa.Text);
                W.employee_name = txtName.Text;
                W.start_time = dtp1.Text;
                W.end_time = dtp2.Text;
                W.daywork = (DateTime)dtpDDay.Value;
                CaLam_BLL.Instance.editCa(W);
                if (nemdl != null) nemdl(W);
            }
        }
        public fCA(int day, int month, int year)
        {
            InitializeComponent();
            Day = day;
            Month = month;
            Year = year;
            string dayName = new DateTime(Year, Month, Day).DayOfWeek.ToString();
            string monthName = DateTimeFormatInfo.CurrentInfo.GetMonthName(Month);
            string Title = $"{dayName}, {Day} {monthName} {Year}";
            this.Text = Title;
        }
   
        public fCA(int iDS,worktime obj)
        {
            InitializeComponent();
            lbIDCa.Text = obj.id.ToString();
            txtName.Text = obj.employee_name;
            dtpDDay.Value = (DateTime)obj.daywork;
            dtp1.Text = obj.start_time;
            dtp2.Text = obj.end_time;
            IDS = iDS;
        }
        public fCA(int iDS)
        {
            InitializeComponent();
            IDS = iDS;
        }
       private void fCA_Load(object sender, EventArgs e)
        {
            dtp6.Format =DateTimePickerFormat.Time;
            dtp6.ShowUpDown = true;
        }

  
    }
}
