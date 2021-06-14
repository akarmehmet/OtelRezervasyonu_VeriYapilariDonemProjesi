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
    public partial class BinarySearchTreeofHotels : Form
    {

        enum Order
        {
            PREORDER,
            INORDER,
            POSTORDER

        }
        private IDbCustomerAccomodationPlaceCrudOperations customerHotelCrudOperations;
        private Order hotelOrder;
        public BinarySearchTreeofHotels()
        {
            InitializeComponent();
            customerHotelCrudOperations = new CustomerHotelCrupOperations();
        }

        private void btnInorder_Click(object sender, EventArgs e)
        {
            hotelOrder = Order.INORDER;

            GetAllHotelByOrder();
        }

        private void btnPostorder_Click(object sender, EventArgs e)
        {
            hotelOrder = Order.POSTORDER;

            GetAllHotelByOrder();
        }

        private void btnPreorder_Click(object sender, EventArgs e)
        {
            hotelOrder = Order.PREORDER;

            GetAllHotelByOrder();
        }


        private void GetAllHotelByOrder()
        {
            listViewHotel.Items.Clear();
            List<AccommodationPlace> hotels = null;
            switch (hotelOrder)
            {
                case Order.INORDER:
                    hotels = customerHotelCrudOperations.GetAccommodationPlacesByInOrder();
                    break;
                case Order.POSTORDER:
                    hotels = customerHotelCrudOperations.GetAccommodationPlacesByPostOrder();
                    break;
                case Order.PREORDER:
                    hotels = customerHotelCrudOperations.GetAccommodationPlacesByPreOrder();
                    break;

                default:
                    hotels = customerHotelCrudOperations.GetAccommodationPlacesByInOrder();
                    break;
            }


            if (hotels == null || hotels.Count < 0)
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

        private void btnTreeDepth_Click(object sender, EventArgs e)
        {
            txtTreeDepth.Text = customerHotelCrudOperations.GetAccommodationPlacesDepth().ToString();
        }

        private void btnNumberOFElements_Click(object sender, EventArgs e)
        {
            txtNumberOfElements.Text = customerHotelCrudOperations.GetAccommodationPlacesCount().ToString();
        }
    }
}
