using OtelRezervasyonu_VeriYapilariDonemProjesi.Scripts.DatabaseOperations;
using OtelRezervasyonu_VeriYapilariDonemProjesi.Scripts.FactoryClasses;
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
    public partial class frmPersonnelCreate : Form
    {

        private IDbAdminPersonelCrudOperations adminHotelPersonelCrupOperations;
        public frmPersonnelCreate()
        {
            InitializeComponent();
        }

        private void InitializeClassFields()
        {

            adminHotelPersonelCrupOperations = new AdminHotelPersonelCrupOperations();
        }




        private void addPersonelBtn_Click(object sender, EventArgs e)
        {

        }


        private void AddPersonelToHotel()
        {

            if (CheckIsAllTextFull())
            {
                if (adminHotelPersonelCrupOperations.AddNewPersonelToDb(
                        PersonelFactory.GetPersonel(

                            txtAdress.Text,
                            txtMail.Text,
                             txtSurname.Text,
                             txtPhone.Text,
                             txtTcNo.Text,
                             comboBoxDepartment.SelectedItem.ToString(),
                             comboBoxPosition.SelectedItem.ToString()
                        ),txtHotelName.Text)
                )
                {

                }
               
            }
            else
                MessageBox.Show("Please Fill All Empty Text Fields");

        }



        private bool CheckIsAllTextFull()
        {

            if (
                txtAdress.Text == "" ||
                txtMail.Text == "" ||
                txtPhone.Text == "" ||
                txtSurname.Text == "" ||
                txtTcNo.Text == "" ||
                txtHotelName.Text == "" ||
                txtPhoneNumber.Text == "" ||
                comboBoxDepartment.SelectedItem == null ||
                comboBoxPosition.SelectedItem == null)
            {
                return false;
            }

            return true;

        }

        private void txtMail_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtSurname_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtHotelName_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtTcNo_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtPhone_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtPhoneNumber_KeyPress(object sender, KeyPressEventArgs e)
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
    }
}
