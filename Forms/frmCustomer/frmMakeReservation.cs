using OtelRezervasyonu_VeriYapilariDonemProjesi.Scripts.DatabaseOperations;
using OtelRezervasyonu_VeriYapilariDonemProjesi.Scripts.Interfaces;
using OtelRezervasyonu_VeriYapilariDonemProjesi.Scripts.Models;
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
    public partial class frmMakeReservation : Form
    {

        private IDbCustomerAccomodationPlaceCrudOperations customerHotelCrudOperations;
        private AccommodationPlace selectedHotel;
        private List<Customer> revervationCustomer;
        public frmMakeReservation()
        {
            InitializeComponent();
            customerHotelCrudOperations = new CustomerHotelCrupOperations();
            revervationCustomer = new List<Customer>();
        }


        private void findPersonel_Click(object sender, EventArgs e)
        {
            FindHotel();
        }


        private void FindHotel()
        {
            if(txtHotelName.Text == "")
            {
                MessageBox.Show("Hotel not found please try again!");
                MessageBox.Show("Please type a hotel name!");
                return;
            }

            selectedHotel = customerHotelCrudOperations.FindAccommodationPlace(txtHotelName.Text);

            if(selectedHotel == null)
            {
                MessageBox.Show("Hotel not found please try again!");
                return;
            }

            panelReservationInfo.Visible = true;
            panelCustomerInfo.Visible = true;
        }



















        private void NumberofPersonsLbl_Click(object sender, EventArgs e)
        {

        }

        private void numberofPersonsTxtBx_TextChanged(object sender, EventArgs e)
        {
            lblEnteredNumberOfPerson.Text = txtNumberOfPerson.Text;
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void txtPhone_TextChanged(object sender, EventArgs e)
        {

        }

        
    }
}
