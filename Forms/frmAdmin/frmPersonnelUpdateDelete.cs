using OtelRezervasyonu_VeriYapilariDonemProjesi.Scripts.ConcreteClass;
using OtelRezervasyonu_VeriYapilariDonemProjesi.Scripts.DatabaseOperations;
using OtelRezervasyonu_VeriYapilariDonemProjesi.Scripts.Interfaces;
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
    public partial class frmPersonnelUpdateDelete : Form
    {
        private IDbAdminPersonelCrudOperations adminPersonelOperations;
        private IDbAdminAccomodationPlaceCrudOperations adminHotelCrudOperations;

        public frmPersonnelUpdateDelete()
        {
            InitializeComponent();
            
            adminPersonelOperations = new AdminHotelPersonelCrupOperations();
            adminHotelCrudOperations = new AdminHotelCrudOperations();
        }






        private void btnOtelPersoneli_Click(object sender, EventArgs e)
        {
            adminHotelCrudOperations.FindAccommodationPlace(txtHotelName.Text);
        }
        private bool CheckIsAllTextFull()
        {
            return false;
        }



























        #region ChechKeyPressFunction

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) || e.KeyChar == 8)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) || e.KeyChar == 8)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void hotelNameTxtBx_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar) || e.KeyChar == 8)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar) || e.KeyChar == 8)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }
        #endregion

        
    }
}
