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
using Chinh_That.DTO;

namespace Chinh_That
{
    public partial class Detail : Form
    {
        int Day, Month, Year;

        public Detail(int day, int month, int year)
        {
            InitializeComponent();

            Day = day;
            Month = month;
            Year = year;
            string dayName = new DateTime(Year, Month, Day).DayOfWeek.ToString();
            string monthName = DateTimeFormatInfo.CurrentInfo.GetMonthName(Month);
            string Title = $"{dayName}, {Day} {monthName} {Year}";
            this.Text = Title;
            detailAppointment();

        }
        private void detailAppointment()
        {
            QuanLiQuanNetEntities db = new QuanLiQuanNetEntities();
            List<worktime> worktimes = db.worktimes.Where(s => s.daywork == new DateTime(Year, Month, Day)).ToList();
            foreach (worktime w in worktimes)
            {
                UserControlDisplay us = new UserControlDisplay(w.id, w.employee_name, w.start_time, w.end_time, (DateTime)w.daywork);
                flowLayoutPanel1.Controls.Add(us);
            }
        }
    }
}
