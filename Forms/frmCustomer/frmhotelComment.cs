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
    public partial class frmhotelComment : Form
    {

        private IDbCustomerAccomodationPlaceCrudOperations customerDbOperations;
        private IDbAdminAccomodationPlaceCrudOperations adminDbOperations;
        public frmhotelComment()
        {
            InitializeComponent();

            customerDbOperations = new CustomerHotelCrupOperations();
            adminDbOperations = new AdminHotelCrudOperations();
            FillComboBox();
        }

        private void FillComboBox()
        {
            List<AccommodationPlace> hotels = adminDbOperations.GetAccommodationPlacesByInOrder();

            if (hotels == null)
                return;

            foreach (var hotel in hotels)
            {
                comboBoxHotels.Items.Add(hotel.Name);
            }
        }

        private void commentsBtn_Click(object sender, EventArgs e)
        {
            MakeComment();
        }

        private void MakeComment()
        {
            if (!CheckIsAllTextFieldFull())
            {
                MessageBox.Show("Please Fill All Empty Fields");
                return;
            }

            if(customerDbOperations.FindAccommodationPlace(txtHotelName.Text) == null)
            {
                MessageBox.Show("Hotel is not found please try again");
                return;
            }

            Comment comment = new HotelCommet()
            {
                CommenterName = txtSurname.Text,
                CommenterEmail = txtMail.Text,
                CommentContent =  txtComment.Text,
                GivenScore = float.Parse(txtHotelScore.Text)
            };

            if(customerDbOperations.MakeCommentAndGiveScoreAccommodationPlace(txtHotelName.Text, comment))
            {
                MessageBox.Show("Comment added");
            }
            else
            {
                MessageBox.Show("You commented this hotel before");
            }
        }

        private bool CheckIsAllTextFieldFull()
        {
            if (
                txtComment.Text == "" ||
                txtHotelName.Text == "" ||
                txtHotelScore.Text == "" ||
                txtMail.Text == "" ||
                txtSurname.Text == "")
            {
                return false;
            }
            else
                return true;

        }













        private void txtHotelName_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtSurname_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtMail_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtHotelScore_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar) || e.KeyChar == 8)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void comboBoxHotels_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtHotelName.Text = comboBoxHotels.SelectedItem.ToString();
        }
    }
}
