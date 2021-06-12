﻿using OtelRezervasyonu_VeriYapilariDonemProjesi.Scripts.DatabaseOperations;
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
            InitializeClassFields();
        }

        private void InitializeClassFields()
        {

            adminHotelPersonelCrupOperations = new AdminHotelPersonelCrupOperations();
        }




        private void addPersonelBtn_Click(object sender, EventArgs e)
        {
            AddPersonelToHotel();
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
                    MessageBox.Show("Personel Added");
                }
                else
                {
                    MessageBox.Show("Error Occured. Please Try Again");
                }
               
            }
            else
                MessageBox.Show("Please Fill All Empty Text Fields");

            CleanText();

        }

        private void CleanText()
        {
            txtAdress.Text = "";
                            txtMail.Text = "";
            txtSurname.Text = "";
            txtPhone.Text = "";
            txtTcNo.Text = "";
            comboBoxDepartment.SelectedItem = comboBoxDepartment.Items[0];
            comboBoxPosition.SelectedItem = comboBoxPosition.Items[0];
                            
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
    }
}
