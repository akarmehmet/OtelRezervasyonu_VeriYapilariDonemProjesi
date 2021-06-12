using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OtelRezervasyonu_VeriYapilariDonemProjesi.Forms.frmCustomer
{
    public partial class frmMDICustomer : Form
    {
        public frmMDICustomer()
        {
            InitializeComponent();
        }

        private void toolStripContainer1_RightToolStripPanel_Click(object sender, EventArgs e)
        {

        }

        private void hotelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.MdiChildren.Count() == 0)
            {
                frmCustomer.frmListbyHotelName frmListbyHotelName = new frmListbyHotelName();
                frmListbyHotelName.MdiParent = this;
                frmListbyHotelName.Show();
            }
            else
            {
                MessageBox.Show("YOU CAN ONLY OPEN 1 PAGE AT THE SAME TIME");
            }
        }

        private void cityDistrictToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.MdiChildren.Count() == 0)
            {
                frmCustomer.frmListbyCityDistrict listbyCityDistrict = new frmListbyCityDistrict();
                listbyCityDistrict.MdiParent = this;
                listbyCityDistrict.Show();
            }
            else
            {
                MessageBox.Show("YOU CAN ONLY OPEN 1 PAGE AT THE SAME TIME");
            }
        }

        private void hotelToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            if (this.MdiChildren.Count() == 0)
            {
                frmCustomer.frmListbyHotelName frmListbyHotelName = new frmListbyHotelName();
                frmListbyHotelName.MdiParent = this;
                frmListbyHotelName.Show();
            }
            else
            {
                MessageBox.Show("YOU CAN ONLY OPEN 1 PAGE AT THE SAME TIME");
            }
        }

        private void cityDistrictToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            if (this.MdiChildren.Count() == 0)
            {
                frmCustomer.frmListbyCityDistrict frmListbyCityDistrict= new frmListbyCityDistrict();
                frmListbyCityDistrict.MdiParent = this;
                frmListbyCityDistrict.Show();
            }
            else
            {
                MessageBox.Show("YOU CAN ONLY OPEN 1 PAGE AT THE SAME TIME");
            }
        }
    }
}
