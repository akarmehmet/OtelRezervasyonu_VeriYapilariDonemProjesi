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
    public partial class frmHotelScoreSelectedCityDistrict : Form
    {

        private IDbCustomerAccomodationPlaceCrudOperations customerHotelCrudOperations;

        public frmHotelScoreSelectedCityDistrict()
        {
            InitializeComponent();
            customerHotelCrudOperations = new CustomerHotelCrupOperations();
        }

        private void btnListHotel_Click(object sender, EventArgs e)
        {
            if (txtDistrict.Text == "" || txtCity.Text == "")
            {
                MessageBox.Show("Please fill empty text fields.");
                return;
            }

            GetAllHotelOrderByName();
        }


        private void GetAllHotelOrderByName()
        {

            List<AccommodationPlace> hotels = customerHotelCrudOperations.GetAccommodationPlacesInProvinceAndDistrictOrderByScore(txtCity.Text, txtDistrict.Text);

            if (hotels == null || hotels.Count < 0)
            {
                MessageBox.Show("There is no hotel in system. Please add first");
                return;
            }




            foreach (var hotel in hotels)
            {

                if (hotel.Adress.City == txtCity.Text && hotel.Adress.District == txtDistrict.Text)
                {
                    ListViewItem hotelItem = new ListViewItem
                    {
                        Text = hotel.Name,
                        ToolTipText = $"Score : {hotel.Rating} Phone Number :{hotel.Adress.PhoneNumber}, City : {hotel.Adress.City}",
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
    }
}
