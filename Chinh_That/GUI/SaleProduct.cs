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
    public partial class SaleProduct : Form
    {
        public SaleProduct(int payment_id)
        {
            InitializeComponent();
            this.payment_id = payment_id;
        
        }
        int payment_id = 0;
        
        private void SaleProduct_Load(object sender, EventArgs e)
        {
            QuanLiQuanNetEntities db = new QuanLiQuanNetEntities();
            List<payment_detail> payment = db.payment_detail.Where(p => p.payment_id == payment_id).ToList();
            foreach (payment_detail pm in payment)
            {            
                product pd = db.products.Where(p => p.id == pm.product_id).FirstOrDefault();
                if (pd != null)
                {
                    SaleItemsGridView.Rows.Add(pd.product_name, pd.prices, pm.product_quantity, pm.total);
                }
            }
        }
    }
}
