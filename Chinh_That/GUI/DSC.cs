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

namespace Chinh_That
{
    public partial class DSC : Form
    {
        public DSC()
        {
            InitializeComponent();
            timer2.Start();
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            labelTime.Text = DateTime.Now.ToString("HH:mm:ss");
        }
        int month, year;
        
        private void displayDays()
        {
            DateTime now = DateTime.Now;

            month = now.Month;
            year = now.Year;

            string monthName = DateTimeFormatInfo.CurrentInfo.GetMonthName(month);
            lableHeader.Text = monthName + " " + year;

            DateTime startOfTheMonth = new DateTime(now.Year, month, 1);

            int days = DateTime.DaysInMonth(year, month);

            int dayOfTheWeek = Convert.ToInt32(startOfTheMonth.DayOfWeek.ToString("d"));

            for (int i = 1; i <= dayOfTheWeek; i++)
            {
                UserControlBlank userControlBlank = new UserControlBlank();
                dayContainer.Controls.Add(userControlBlank);
            }

            for (int i = 1; i <= days; i++)
            {

                UserControlDays userControlDays = new UserControlDays(i, month, year);
                dayContainer.Controls.Add(userControlDays);
            }

        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            labelTime.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            dayContainer.Controls.Clear();

            month++;
            if (month == 13)
            {
                year++;
                month = 1;
            }

            string monthName = DateTimeFormatInfo.CurrentInfo.GetMonthName(month);
            lableHeader.Text = monthName + "  " + year;

            DateTime startOfTheMonth = new DateTime(year, month, 1);

            int days = DateTime.DaysInMonth(year, month);

            int dayOfTheWeek = Convert.ToInt32(startOfTheMonth.DayOfWeek.ToString("d"));

            for (int i = 1; i <= dayOfTheWeek; i++)
            {
                UserControlBlank userControlBlank = new UserControlBlank();
                dayContainer.Controls.Add(userControlBlank);
            }

            for (int i = 1; i <= days; i++)
            {
                UserControlDays userControlDays = new UserControlDays(i, month, year);
                dayContainer.Controls.Add(userControlDays);
            }

        }

        private void DSC_Load(object sender, EventArgs e)
        {
            displayDays();        
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            dayContainer.Controls.Clear();

            month--;
            if (month == 0)
            {
                year--;
                month = 12;
            }

            string monthName = DateTimeFormatInfo.CurrentInfo.GetMonthName(month);
            lableHeader.Text = monthName + " " + year;

            DateTime startOfTheMonth = new DateTime(year, month, 1);

            int days = DateTime.DaysInMonth(year, month);

            int dayOfTheWeek = Convert.ToInt32(startOfTheMonth.DayOfWeek.ToString("d"));

            for (int i = 1; i <= dayOfTheWeek; i++)
            {
                UserControlBlank userControlBlank = new UserControlBlank();
                dayContainer.Controls.Add(userControlBlank);
            }

            for (int i = 1; i <= days; i++)
            {
                UserControlDays userControlDays = new UserControlDays(i, month, year);
                dayContainer.Controls.Add(userControlDays);
            }
        }
       
    }
}
