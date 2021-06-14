using OtelRezervasyonu_VeriYapilariDonemProjesi.Scripts.DatabaseOperations;
using OtelRezervasyonu_VeriYapilariDonemProjesi.Scripts.HashTable;
using OtelRezervasyonu_VeriYapilariDonemProjesi.Scripts.Interfaces;
using OtelRezervasyonu_VeriYapilariDonemProjesi.Scripts.Models;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace OtelRezervasyonu_VeriYapilariDonemProjesi.Forms.frmCustomer
{
    public partial class frmRezNameSurnameAZ : Form
    {

        private IDbCustomerAccomodationPlaceCrudOperations customerHotelCrudOperations;
        public frmRezNameSurnameAZ()
        {
            InitializeComponent();
            customerHotelCrudOperations = new CustomerHotelCrupOperations();
        }

        private void btnFindReservation_Click(object sender, EventArgs e)
        {
            GetCustomersInReservation();
        }

        private void GetCustomersInReservation()
        {
            if(txtReservationNo.Text == "")
            {
                MessageBox.Show("Please fill empty text fields.");
                return;
            }

            ReservationHashNode reservationNode = customerHotelCrudOperations.GetReservation(Convert.ToInt32(txtReservationNo.Text));

            if(reservationNode == null)
            {
                MessageBox.Show("Reservation can not found try again.");
                return;
            }

            //List<Customer> customers = reservationNode.ReservationHeapTrees.


            //ListViewItem customerItem = new ListViewItem
            //{
            //    Text = personel.Name,
            //    ToolTipText = $"Phone Number :{personel.Address.PhoneNumber}, Department : {personel.Department}",
            //    Tag = personel
            //};
            //listViewPersonel.Items.Add(customerItem);


          txtCustomers.Text =  reservationNode.ReservationHeapTrees.GetCustomersName();

        }
    }
}
