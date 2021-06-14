using OtelRezervasyonu_VeriYapilariDonemProjesi.Scripts.ConcreteClass;
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
        private Reservation hotelReservation;
        private int numberrOfCustomers;
        public frmMakeReservation()
        {
            InitializeComponent();
            customerHotelCrudOperations = new CustomerHotelCrupOperations();
            hotelReservation = new HotelReservation();
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

            foreach (var room in selectedHotel.Rooms)
            {
                comboBoxRoomNo.Items.Add(room.RoomNumber);
            }
        }


        private void addPersonBtn_Click(object sender, EventArgs e)
        {

            if(hotelReservation.Customers.Count >= Convert.ToInt32(txtNumberOfPerson))
            {
                MessageBox.Show("You Can not more custmers to this reservation");
                return;
            } 


            if (!CheckIsAllTextFieldFull())
            {
                MessageBox.Show("Please Fill All Empty Fields");
                return;
            }

            


            Customer hotelCustomer = new HotelCustomer()
            {
                Name = txtName.Text,
                IdentificationNumber = txtTcNo.Text,
                Address = new HotelAdress()
                {
                    City = "",
                    District = "",
                    OpenAdress = txtAdress.Text,
                    PhoneNumber = txtPhone.Text,
                    Email = txtMail.Text,
                }
            };

            hotelReservation.Customers.Add(hotelCustomer);

            if (hotelReservation.Customers.Count == Convert.ToInt32(txtNumberOfPerson))
            {
                hotelReservation.ReservedPlaceName = txtHotelName.Text;
                hotelReservation.ReservedPlaceNo = Convert.ToInt32(comboBoxRoomNo.SelectedItem.ToString());
                hotelReservation.NumberOfDay = Convert.ToInt32(txtNumberOfDays.Text);
                hotelReservation.TotalPrice = GetReservationTotalPrice();
                btnMakeReservation.Visible = true;
            }

        }

        private float GetReservationTotalPrice()
        {
            float roomPrice = 0;
            foreach (var room in selectedHotel.Rooms)
            {
                if(room.RoomNumber == Convert.ToInt32(comboBoxRoomNo.SelectedItem.ToString()))
                {
                    roomPrice = room.Price;
                }   
            }

            return (roomPrice * Convert.ToInt32(txtNumberOfPerson.Text));
        }

        private bool CheckIsAllTextFieldFull()
        {
            if (
                txtAdress.Text == "" ||
                txtMail.Text == "" ||
                txtName.Text == "" ||
                txtNumberOfPerson.Text == "" ||
                txtPhone.Text == "" ||
                txtTcNo.Text == "" ||
                txtTotalPrice.Text == "" ||
                txtNumberOfDays.Text == "" ||
                txtReservationNo.Text == "" ||
                comboBoxRoomNo.SelectedItem == null)
                return false;
            else
                return true;


        }

        private void btnMakeReservation_Click(object sender, EventArgs e)
        {

        }
















        private void NumberofPersonsLbl_Click(object sender, EventArgs e)
        {

        }

        private void numberofPersonsTxtBx_TextChanged(object sender, EventArgs e)
        {
           
            numberrOfCustomers = Convert.ToInt32(txtNumberOfPerson.Text);
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void txtPhone_TextChanged(object sender, EventArgs e)
        {

        }

       
    }
}
