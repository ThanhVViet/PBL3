
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AD1
{
    public partial class Form1 : Form
    {
        QuanLyEntities db;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAddNV_Click(object sender, EventArgs e)
        {
            db = new QuanLyEntities();
            using (Form2 _fNV = new Form2(0))
            {
                if (_fNV.ShowDialog() == DialogResult.OK)
                {
                    dtgNV.DataSource = db.employees.ToList();
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            QuanLyEntities db = new QuanLyEntities();
            dtgNV.DataSource = db.employees.Select(p => new { p.id_employee, p.employee_name,p.date_of_birth, p.phone,p.image_url}).ToList();

        }

        private void btnDeleteNV_Click(object sender, EventArgs e)
        {
            db = new QuanLyEntities();
            foreach (DataGridViewRow i in dtgNV.SelectedRows)
            {
                if (dtgNV.SelectedRows.Count > 0)
                {
                
                    using (QuanLyEntities db = new QuanLyEntities())
                    {
                        int id = Convert.ToInt32(i.Cells[0].Value.ToString());
                        employee nv = db.employees.Find(id);
                        db.employees.Remove(nv);
                        db.SaveChanges();
                    }
                }            
            }
            MessageBox.Show("Đã xóa thành công ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            dtgNV.DataSource = db.employees.ToList();

        }

        private void txtFind_TextChange(object sender, EventArgs e)
        {
            QuanLyEntities db = new QuanLyEntities();
            if (txtFind.Text == "")
            {
                dtgNV.DataSource = db.employees.ToList();
            }
            else
            {
                dtgNV.DataSource = db.employees.Where
                (
                    p => p.employee_name.ToUpper().Contains(txtFind.Text.ToUpper()) || p.phone.ToUpper().Contains(txtFind.Text.ToUpper())
                )
                .Select(p => new { p.id_employee, p.employee_name,p.date_of_birth, p.phone,p.image_url}).ToList();
            }
        }

        private void btnEditNV_Click(object sender, EventArgs e)
        {
            employee ee = new employee();
            ee.id_employee = Convert.ToInt32(dtgNV.CurrentRow.Cells[0].Value.ToString());
            ee.date_of_birth = DateTime.Parse(dtgNV.CurrentRow.Cells[2].Value.ToString());
            ee.employee_name = dtgNV.CurrentRow.Cells[1].Value.ToString();
            ee.phone = dtgNV.CurrentRow.Cells[3].Value.ToString();
            ee.image_url = (byte[])dtgNV.CurrentRow.Cells[4].Value;
            db = new QuanLyEntities();
            Form2 _fNV = new Form2(1,ee);
            _fNV.nemdl += _fNV_nemdl;         
            _fNV.ShowDialog();
        }

        private void _fNV_nemdl(employee e)
        {
            db = new QuanLyEntities();
            int cs = Convert.ToInt32(dtgNV.CurrentRow.Cells[0].Value.ToString());
            employee NV = new employee();
            NV = db.employees.Find(cs);
            NV.employee_name = e.employee_name;
            NV.date_of_birth = e.date_of_birth;
            NV.phone = e.phone;
            NV.image_url = e.image_url;
            db.SaveChanges();
            dtgNV.DataSource = db.employees.ToList();
        }
     
    }
}
