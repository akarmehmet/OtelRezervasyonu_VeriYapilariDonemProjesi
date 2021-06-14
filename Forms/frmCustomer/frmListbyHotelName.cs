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
    public partial class frmListbyHotelName : Form
    {

        private IDbCustomerAccomodationPlaceCrudOperations customerHotelCrudOperations;
        public frmListbyHotelName()
        {
            InitializeComponent();

            customerHotelCrudOperations = new CustomerHotelCrudOperations();
            GetAllHotelOrderByName();
        }


        private void GetAllHotelOrderByName()
        {

            List<AccommodationPlace> hotels = customerHotelCrudOperations.GetAccommodationPlacesOrderByName();

            if(hotels == null || hotels.Count < 0)
            {
                MessageBox.Show("There is no hotel in system. Please add first");
                return;
            }

            foreach (var hotel in hotels)
            {
                ListViewItem hotelItem = new ListViewItem
                {
                    Text = hotel.Name,
                    ToolTipText = $"Phone Number :{hotel.Adress.PhoneNumber}, City : {hotel.Adress.City}",
                    Tag = hotel
                };

                listViewHotel.Items.Add(hotelItem);
            }

            listViewHotel.ShowItemToolTips = true;
        }

        
    }
}
