using OtelRezervasyonu_VeriYapilariDonemProjesi.Forms.FactoryClasses;
using OtelRezervasyonu_VeriYapilariDonemProjesi.Scripts.ConcreteClass;
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

namespace OtelRezervasyonu_VeriYapilariDonemProjesi.Forms.frmAdmin
{
    public partial class frmHotelCreate : Form
    {
        private AdminHotelCrudOperations adminHotelCrudOperations;


        public frmHotelCreate()
        {
            InitializeComponent();
            adminHotelCrudOperations = new AdminHotelCrudOperations();
        }


        private void AddHotel()
        {
            adminHotelCrudOperations.SaveNewAccomodationPlace(

                  AccommodationFactory.CreateAccommodationPlace(hotelNameTxtBx.Text, hotelMailTxtBx.Text, hotelRoomsNumberTxtBx.Text,
                                   hotelAdressTxtBx.Text, hotelPhoneTxtBx.Text, hotelStarNumberTxtBx.Text, hotelcityTxtBx.Text, hotelDisctrictTxtBx.Text)

                  );


        }

        private void CleanTextFill()
        {
            hotelNameTxtBx.Text = "";
            hotelMailTxtBx.Text = "";
            hotelRoomsNumberTxtBx.Text = "";
            hotelAdressTxtBx.Text = "";
            hotelPhoneTxtBx.Text = "";
            hotelStarNumberTxtBx.Text = "";
            hotelcityTxtBx.Text = "";
            hotelDisctrictTxtBx.Text = "";
        }

        private void createHotelBtn_Click(object sender, EventArgs e)
        {
            AddHotel();
        }
    }
}
