using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Chinh_That.DTO;

namespace Chinh_That
{
    public partial class DSDV : Form
    {
        public int RowIndex = 0;
        public DSDV()
        {
            InitializeComponent();
            Retrive();
        }
        public void Retrive()
        {
            QuanLiQuanNetEntities db = new QuanLiQuanNetEntities();
            List<category> categories = db.categories.ToList();
            foreach (category category in categories)
            {
                UserControl_C us = new UserControl_C(
                    category.product_category_name,
                    category.image_category,
                    category.id
                    );
                Button btn = new Button();
                btn.Text = "SHOW";
                btn.Tag = category.id;
                btn.Click += CategoryButtonClick;
                us.picBtn.Controls.Add(btn);
                FLP.Controls.Add(us);
            }

        }
        private void ADD_C_Click(object sender, EventArgs e)
        {
            ADD_C ac = new ADD_C(0);         
            if (ac.ShowDialog() == DialogResult.OK)
            {
                FLP.Controls.Clear();
                Retrive();
            }
        } 
        void CategoryButtonClick(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();
            Button btn = (Button)sender;        
            int CategoryID = Convert.ToInt32(btn.Tag);
            R_P(CategoryID);
        }
        public void R_P(int CategoryID)
        {
            QuanLiQuanNetEntities db = new QuanLiQuanNetEntities();
            List<product> products = db.products.Where(p => p.id_product_category == CategoryID).ToList();
            foreach (product product in products)
            {
                UserControl_P us = new UserControl_P(
                    product.product_name,
                    product.image_url,
                      product.id,
                   (Int32)product.prices
                    );
                Button btn = new Button();
                btn.Text = "Thêm";
                us.picBtnA.Controls.Add(btn);
                btn.Tag = product.id;
                flowLayoutPanel1.Controls.Add(us);
                btn.Click += ProductButtonClick;
            }
        }
        void ProductButtonClick(object sender, EventArgs e)
        {
            QuanLiQuanNetEntities db = new QuanLiQuanNetEntities();
            Button btn = (Button)sender;
            int ProductID = Convert.ToInt32(btn.Tag);
            product product = db.products.Where(p => p.id == ProductID).FirstOrDefault();

            if (CheckProductAlreadyAdded(ProductID))
            {
                int Quantity = Convert.ToInt32(ProductsGridView.Rows[RowIndex].Cells["ProductQuantityColumn"].Value);
                decimal Price = Convert.ToInt32(ProductsGridView.Rows[RowIndex].Cells["ProductPriceColumn"].Value);
                Quantity++;
                decimal TotalPrice = Convert.ToDecimal(Quantity * product.prices);
                ProductsGridView.Rows[RowIndex].Cells["ProductQuantityColumn"].Value = Quantity;
                ProductsGridView.Rows[RowIndex].Cells["TotalPriceColumn"].Value = TotalPrice;
                TotalBillBox.Text = CalculateTotalBill(ProductsGridView).ToString();
            }
            else
            {
                ProductsGridView.Rows.Add(ProductID, product.product_name, product.prices, 1, product.prices * 1);
                TotalBillBox.Text = CalculateTotalBill(ProductsGridView).ToString();
            }
        }

        private void btnALL_P_Click(object sender, EventArgs e)
        {
            View_P view_P = new View_P();
            view_P.ShowDialog();
        }

        private void btnAllSale_Click(object sender, EventArgs e)
        {
            View_Sales vs = new View_Sales();
            vs.ShowDialog();
        }
        public bool CheckProductAlreadyAdded(int ProductID)
        {
            foreach (DataGridViewRow Row in ProductsGridView.Rows)
            {
                if (Convert.ToInt32(Row.Cells["ProductIDColumn"].Value) == ProductID)
                {
                    RowIndex = Row.Index;
                    return true;
                }
            }
            return false;
        }
        public decimal CalculateTotalBill(DataGridView ProductsGridView)
        {
            decimal TotalBill = 0;

            foreach (DataGridViewRow Row in ProductsGridView.Rows)
            {
                int ProductTotal = Convert.ToInt32(Row.Cells["TotalPriceColumn"].Value);
                TotalBill = TotalBill + ProductTotal;
            }

            return TotalBill;
        }

        private void CheckOutButton_Click(object sender, EventArgs e)
        {
            Cash cash = new Cash();

            cash.TotalBillBox.Text = TotalBillBox.Text;

            if (cash.ShowDialog() == DialogResult.OK)
            {
                payment pay = new payment();
                pay.cash_given = Convert.ToInt32(cash.CashGivenBox.Text);
                pay.cash_return = Convert.ToInt32(cash.CashReturnBox.Text);
                pay.payment_time = DateTime.Now;
                pay.total_bill = Convert.ToInt32(cash.TotalBillBox.Text);

                List<payment_detail> details = new List<payment_detail>();
                foreach (DataGridViewRow Row in ProductsGridView.Rows)
                {
                    string ProductName = Convert.ToString(Row.Cells[1].Value);
                    QuanLiQuanNetEntities db = new QuanLiQuanNetEntities();
                    product product = db.products.Where(p => p.product_name == ProductName).FirstOrDefault();
                    payment_detail p_d = new payment_detail();
                    if (product != null)
                    {
                        p_d.product_id = product.id;
                        p_d.product_quantity = Convert.ToInt32(Row.Cells[3].Value);
                        p_d.total = (Convert.ToInt32(Row.Cells[3].Value)) * (product.prices);
                        details.Add(p_d);
                    }

                }
                RecordSale(pay, details);
                ProductsGridView.Rows.Clear();
                ProductsGridView.Refresh();
                TotalBillBox.Text = " ";
            }
           
        }
        public void RecordSale(payment pay, List<payment_detail> details)
        {
            QuanLiQuanNetEntities db = new QuanLiQuanNetEntities();
            db.payments.Add(pay);
            db.SaveChanges();
            foreach (payment_detail detail in details)
            {
                QuanLiQuanNetEntities db1 = new QuanLiQuanNetEntities();
                detail.payment_id = pay.id;
                db1.payment_detail.Add(detail);
                db1.SaveChanges();
            }
        }

        private void ProductsGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (ProductsGridView.Columns[e.ColumnIndex].Name == "DeleteColumn")
                {
                    if (MessageBox.Show("Bạn có muốn xóa không ??", "Warning", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        int DeletedProductTotal = Convert.ToInt32(ProductsGridView.Rows[e.RowIndex].Cells["TotalPriceColumn"].Value);
                        int CurrentTotalBill = Convert.ToInt32(TotalBillBox.Text);
                        CurrentTotalBill = CurrentTotalBill - DeletedProductTotal;
                        ProductsGridView.Rows.RemoveAt(e.RowIndex);
                        TotalBillBox.Text = CurrentTotalBill.ToString();
                    }
                }
            }
        }
        private void btnAdd_P_Click(object sender, EventArgs e)
        {
            Add_P ap = new Add_P();
            ap.ShowDialog();
        }
    }
}
