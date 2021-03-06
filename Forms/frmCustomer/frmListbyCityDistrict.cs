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
    public partial class frmListbyCityDistrict : Form
    {

        private IDbCustomerAccomodationPlaceCrudOperations customerHotelCrudOperations;
        public frmListbyCityDistrict()
        {
            InitializeComponent();
            customerHotelCrudOperations = new CustomerHotelCrudOperations();
            //GetAllHotelOrderByName();
        }



        private void listbyCityDistrictBtn_Click(object sender, EventArgs e)
        {
            if(txtdistrict.Text =="" || txtCity.Text == "")
            {
                MessageBox.Show("Please fill empty text fields.");
                return;
            }

            GetAllHotelOrderByName();
        }


        private void GetAllHotelOrderByName()
        {

            List<AccommodationPlace> hotels = customerHotelCrudOperations.GetAccommodationPlacesOrderByName();

            if (hotels == null || hotels.Count < 0)
            {
                MessageBox.Show("There is no hotel in system. Please add first");
                return;
            }

            foreach (var hotel in hotels)
            {

                if(hotel.Adress.City == txtCity.Text && hotel.Adress.District == txtdistrict.Text)
                {
                    ListViewItem hotelItem = new ListViewItem
                    {
                        Text = hotel.Name,
                        ToolTipText = $"Phone Number :{hotel.Adress.PhoneNumber}, City : {hotel.Adress.City}",
                        Tag = hotel
                    };

                    listViewHotel.Items.Add(hotelItem);
                }
            }

            if (listViewHotel.Items.Count == 0)
            {
                MessageBox.Show("There is no hotel in selected city.");
                return;
            }

            listViewHotel.ShowItemToolTips = true;
        }


        private void hotelNameTxtBx_KeyPress(object sender, KeyPressEventArgs e)
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

        private void districtTxtBx_KeyPress(object sender, KeyPressEventArgs e)
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

        
    }
}
