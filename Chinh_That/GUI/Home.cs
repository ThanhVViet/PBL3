using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chinh_That
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }
        private Form activeForm = null;
        private void openChildFormInPanel(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            pContainer.Controls.Add(childForm);
            pContainer.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
    
        private void btnNV_Click(object sender, EventArgs e)
        {
            openChildFormInPanel(new DSNV());
        }
        private int imageNumber = 1;
        private void LoadNextImage()
        {
            if (imageNumber == 5)
            {
                imageNumber = 1;
            }
         //   slidePic.ImageLocation = string.Format(@"Images\{0}.jpg", imageNumber);
            imageNumber++;
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            LoadNextImage();
        }

        private void btnCa_Click(object sender, EventArgs e)
        {
            openChildFormInPanel(new DSC());
        }

        private void rjButton2_Click(object sender, EventArgs e)
        {
            openChildFormInPanel(new DSDV());
        }

        private void rjButton3_Click(object sender, EventArgs e)
        {
            openChildFormInPanel(new DSCom());
        }

       
    }
}
