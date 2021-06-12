using OtelRezervasyonu_VeriYapilariDonemProjesi.Scripts.ConcreteClass;
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
    public partial class frmAddRoomtoHotel : Form
    {

        private AdminHotelCrudOperations adminHotelCrudOperations;
        public frmAddRoomtoHotel()
        {
            InitializeComponent();
            InitializeFields();
        }

        private void InitializeFields()
        {
            adminHotelCrudOperations = new AdminHotelCrudOperations();
        }

        private void btnAddRoom_Click(object sender, EventArgs e)
        {
            AddNewRoomToHotel();
        }

        private void AddNewRoomToHotel()
        {
            if (CheckIsAllTextFiilFull())
            {
               
                if(adminHotelCrudOperations.AddNewRoomToAccommodationPlace( txtCapacity.Text,
                                                                            txtHotelName.Text,
                                                                            txtLandscapeInfo.Text,
                                                                            txtPhone.Text,
                                                                            txtPrice.Text,
                                                                            txtRoomNo.Text))
                {

                    MessageBox.Show("Room Added to Hote!");

                }
                else
                {
                    MessageBox.Show("Room Cannot Added to Hotel. Because Hotel not Found Or the same room number exist in Hotel. Please try again");
                }
            }
            else
            {
                MessageBox.Show("Please Fill All Empty Fields");
            }

        }

        private bool CheckIsAllTextFiilFull()
        {
            if (
                txtCapacity.Text == "" ||
                txtHotelName.Text == "" ||
                txtLandscapeInfo.Text == "" ||
                txtPhone.Text == "" ||
                txtPrice.Text == "" ||
                txtRoomNo.Text == ""
                )
                return false;
            else
                return true;
        }
    }
}
