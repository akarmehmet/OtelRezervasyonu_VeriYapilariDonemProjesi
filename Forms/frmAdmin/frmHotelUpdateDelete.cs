using OtelRezervasyonu_VeriYapilariDonemProjesi.Scripts.ConcreteClass;
using OtelRezervasyonu_VeriYapilariDonemProjesi.Scripts.Models;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace OtelRezervasyonu_VeriYapilariDonemProjesi.Forms.frmAdmin
{
    public partial class frmHotelUpdateDelete : Form
    {

        private AdminHotelCrudOperations adminHotelCrudOperations;
        private ListViewItem selectedHotel;
        public frmHotelUpdateDelete()
        {
            InitializeComponent();

            InitializeParametre();
            GetHotelAndFillListBox();
        }

        private void InitializeParametre()
        {
            adminHotelCrudOperations = new AdminHotelCrudOperations();
        }

        private void GetHotelAndFillListBox()
        {
            List<AccommodationPlace> hotels = adminHotelCrudOperations.GetAccommodationPlacesByInOrder();
            listViewHotels.ShowItemToolTips = true;

            foreach (var hotel in hotels)
            {
                ListViewItem listViewItem = new ListViewItem();
                listViewItem.Tag = hotel;
                listViewItem.Text = hotel.Name;
                listViewItem.ToolTipText = $"Name:{hotel.Name} , Adress:{hotel.Adress.City}/{hotel.Adress.District},Phone Number : {hotel.Adress.PhoneNumber} ";
                listViewHotels.Items.Add(listViewItem);
            }
        }



        private void deleteHotelBtn_Click(object sender, EventArgs e)
        {
            DeleteHote();
        }
        private void DeleteHote()
        {
            AccommodationPlace updatedHotel = ((AccommodationPlace)selectedHotel.Tag);

            if (adminHotelCrudOperations.DeleteAccommodationPlace(updatedHotel.Name))
            {

                MessageBox.Show("Hotel is deleted successfully");
                listViewHotels.Items.Remove(selectedHotel);
                txtHotelMail.Text = "";
                txtHotelMail.Text = "";
                txtDistrict.Text = "";
                txtHotelPhone.Text = "";
                txtNumberOfStar.Text = "";
                richTextBoxAdress.Text = "";
                cityTxtBx.Text = "";
            }
            else
            {
                MessageBox.Show("Hotel Is Not Found Please Try Again!!");
                return;
            }
        }



        private void createHotelBtn_Click(object sender, EventArgs e)
        {
            UpdateHotel();
        }
        private void UpdateHotel()
        {
            if (CheckAllTextIsNotEmpty())
            {
                AccommodationPlace updatedHotel = ((AccommodationPlace)selectedHotel.Tag);

                updatedHotel.Adress.OpenAdress = richTextBoxAdress.Text;
                updatedHotel.Adress.Email = txtHotelMail.Text;
                updatedHotel.Adress.PhoneNumber = txtHotelPhone.Text;
                updatedHotel.Adress.City = cityTxtBx.Text;
                updatedHotel.Adress.District = txtDistrict.Text;
                updatedHotel.StarCount =Convert.ToInt32( txtNumberOfStar.Text);
               

                if (adminHotelCrudOperations.UpdateAccommodationPlace(updatedHotel))
                {
                    MessageBox.Show("Hotel is updated successfully");
                }
                else
                {
                    MessageBox.Show("Hotel Is Not Found Please Try Again!!");
                    return;
                }
            }
            else
            {
                MessageBox.Show("Please Fill All Emtpy Text!!");
                return;
            }
        }

        private bool CheckAllTextIsNotEmpty()
        {
            if (
                txtHotelMail.Text == "" ||
                txtHotelMail.Text == "" ||
                txtDistrict.Text == "" ||
                txtHotelPhone.Text == "" ||
                txtNumberOfStar.Text == "" ||
                richTextBoxAdress.Text == "" ||
                cityTxtBx.Text == "")
            {
                return false;
            }
            else
                return true;
        }


        private void listViewHotels_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            selectedHotel = listViewHotels.SelectedItems[0];
            FillTextAccordingToSelection();

        }
        private void FillTextAccordingToSelection()
        {
            AccommodationPlace hotel = ((AccommodationPlace)selectedHotel.Tag);

            lblHotelName.Text = hotel.Name;
            txtHotelMail.Text = hotel.Adress.Email;
            txtDistrict.Text = hotel.Adress.District;
            txtHotelPhone.Text = hotel.Adress.PhoneNumber;
            txtNumberOfStar.Text = hotel.StarCount.ToString();
            richTextBoxAdress.Text = hotel.Adress.OpenAdress;
            cityTxtBx.Text = hotel.Adress.City;

        }





        private void addressLbl_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }


    }
}
