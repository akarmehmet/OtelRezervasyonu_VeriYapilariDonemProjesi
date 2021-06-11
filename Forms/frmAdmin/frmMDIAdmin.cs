using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace OtelRezervasyonu_VeriYapilariDonemProjesi.Forms.frmAdmin
{
    public partial class frmMDIAdmin : Form
    {
        public frmMDIAdmin()
        {
            InitializeComponent();
        }

        private void toolStripContainer1_RightToolStripPanel_Click(object sender, EventArgs e)
        {

        }

        private void newHotelCreateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.MdiChildren.Count() == 0)
            {
                frmHotelCreate frmHotelCreate = new frmHotelCreate();
                frmHotelCreate.MdiParent = this;
                frmHotelCreate.Show();
            }
            else
            {
                MessageBox.Show("YOU CAN ONLY OPEN 1 PAGE AT THE SAME TIME");
            }
        }

        bool take;
        int mouseX, mouseY;

        private void adminTopMDIPanel_MouseDown(object sender, MouseEventArgs e)
        {
            take = true;
            mouseX = Cursor.Position.X - this.Left;
            mouseY = Cursor.Position.Y - this.Top;
        }

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

        private void exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void addRoomToHotelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.MdiChildren.Count() == 0)
            {
                frmAddRoomtoHotel frmAddRoomtoHotel = new frmAddRoomtoHotel();
                frmAddRoomtoHotel.MdiParent = this;
                frmAddRoomtoHotel.Show();
            }
            else
            {
                MessageBox.Show("YOU CAN ONLY OPEN 1 PAGE AT THE SAME TIME");
            }
        }

        private void createToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.MdiChildren.Count() == 0)
            {
                frmCustomer.frmPersonnelCreate frmPersonnelCreate = new frmCustomer.frmPersonnelCreate();
                frmPersonnelCreate.MdiParent = this;
                frmPersonnelCreate.Show();
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
                frmHotelUpdateDelete frmHotelUpdateDelete = new frmHotelUpdateDelete();
                frmHotelUpdateDelete.MdiParent = this;
                frmHotelUpdateDelete.Show();
            }
            else
            {
                MessageBox.Show("YOU CAN ONLY OPEN 1 PAGE AT THE SAME TIME");
            }
        }


    }
}
