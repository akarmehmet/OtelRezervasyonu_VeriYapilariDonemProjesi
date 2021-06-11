using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OtelRezervasyonu_VeriYapilariDonemProjesi.Forms
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        bool take;
        int mouseX, mouseY;

        private void loginTopMDIPanel_MouseUp(object sender, MouseEventArgs e)
        {
            take = false;
            mouseX = 0;
            mouseY = 0;
        }

        private void loginTopMDIPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (take == true)
            {
                this.Left = Cursor.Position.X - mouseX;
                this.Top = Cursor.Position.Y - mouseY;
            }
        }

        private void exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Admin_Click(object sender, EventArgs e)
        {
            Forms.frmAdmin.frmMDIAdmin frmMDIAdmin = new Forms.frmAdmin.frmMDIAdmin();
            frmMDIAdmin.Show();
        }

        private void customer_Click(object sender, EventArgs e)
        {
            Forms.frmCustomer.frmMDICustomer frmCustomer = new Forms.frmCustomer.frmMDICustomer();
            frmCustomer.Show();
        }

        private void loginTopMDIPanel_MouseDown(object sender, MouseEventArgs e)
        {
            take = true;
            mouseX = Cursor.Position.X - this.Left;
            mouseY = Cursor.Position.Y - this.Top;
        }
    }
}
