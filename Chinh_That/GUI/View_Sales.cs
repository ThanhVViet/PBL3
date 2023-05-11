using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Chinh_That.DTO;

namespace Chinh_That
{
    public partial class View_Sales : Form
    {
        QuanLiQuanNetEntities db = new QuanLiQuanNetEntities();
        public View_Sales()
        {
            InitializeComponent();
        }
        private void View_Sales_Load(object sender, EventArgs e)
        {
            List<payment> payments = db.payments.ToList();
            foreach (payment payment in payments)
            {
                SalesGridView.Rows.Add(payment.id, payment.payment_time, payment.cash_given, payment.cash_return);
            }
        }
        private void SalesGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (SalesGridView.Columns[e.ColumnIndex].Name == "ProductsColumn")
                {
                    //  int payment_id = Convert.ToInt32(SalesGridView.CurrentRow.Cells[0].Value);
                    int payment_id = Convert.ToInt32(SalesGridView.Rows[e.RowIndex].Cells["SaleIDColumn"].Value);
                    SaleProduct sp = new SaleProduct(payment_id);
                    sp.ShowDialog();
                }
            }
        }
    }
}
