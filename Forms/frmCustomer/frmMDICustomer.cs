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

        private void numberOfStarsOfTheHotelsInTheProvinceDistrictToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.MdiChildren.Count() == 0)
            {
                frmCustomer.frmNumberStarsSelectedCityDistrict frmNumberStarsSelectedCityDistrict = new frmNumberStarsSelectedCityDistrict();
                frmNumberStarsSelectedCityDistrict.MdiParent = this;
                frmNumberStarsSelectedCityDistrict.Show();
            }
            else
            {
                MessageBox.Show("YOU CAN ONLY OPEN 1 PAGE AT THE SAME TIME");
            }
        }

        private void hotelInfoUpdateDeleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.MdiChildren.Count() == 0)
            {
                frmCustomer.frmhotelComment frmhotelComment = new frmhotelComment();
                frmhotelComment.MdiParent = this;
                frmhotelComment.Show();
            }
            else
            {
                MessageBox.Show("YOU CAN ONLY OPEN 1 PAGE AT THE SAME TIME");
            }
        }

        private void exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        bool take;
        int mouseX, mouseY;

        private void adminTopMDIPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (take == true)
            {
                this.Left = Cursor.Position.X - mouseX;
                this.Top = Cursor.Position.Y - mouseY;
            }
        }

        private void adminTopMDIPanel_MouseUp(object sender, MouseEventArgs e)
        {
            take = false;
            mouseX = 0;
            mouseY = 0;
        }

        private void makeReservationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.MdiChildren.Count() == 0)
            {
                frmCustomer.frmMakeReservation frmMakeReservation = new frmMakeReservation();
                frmMakeReservation.MdiParent = this;
                frmMakeReservation.Show();
            }
            else
            {
                MessageBox.Show("YOU CAN ONLY OPEN 1 PAGE AT THE SAME TIME");
            }
        }

        private void aZOfReservationNamesAndSurnamesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.MdiChildren.Count() == 0)
            {
                frmCustomer.frmRezNameSurnameAZ frmRezNameSurnameAZ = new frmRezNameSurnameAZ();
                frmRezNameSurnameAZ.MdiParent = this;
                frmRezNameSurnameAZ.Show();
            }
            else
            {
                MessageBox.Show("YOU CAN ONLY OPEN 1 PAGE AT THE SAME TIME");
            }
        }

        private void adminTopMDIPanel_MouseDown(object sender, MouseEventArgs e)
        {
            take = true;
            mouseX = Cursor.Position.X - this.Left;
            mouseY = Cursor.Position.Y - this.Top;
        }
    }
}
