using OtelRezervasyonu_VeriYapilariDonemProjesi.Scripts.ConcreteClass;
using OtelRezervasyonu_VeriYapilariDonemProjesi.Scripts.DatabaseOperations;
using OtelRezervasyonu_VeriYapilariDonemProjesi.Scripts.Enums;
using OtelRezervasyonu_VeriYapilariDonemProjesi.Scripts.Interfaces;
using OtelRezervasyonu_VeriYapilariDonemProjesi.Scripts.Models;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace OtelRezervasyonu_VeriYapilariDonemProjesi.Forms.frmAdmin
{

    public partial class frmListbyDepartment : Form
    {

        private IDbAdminPersonelCrudOperations adminPersonelOperations;
        private IDbAdminAccomodationPlaceCrudOperations adminHotelCrudOperations;
        private List<Personel> hotelPersonels;
        private Department selectedDepartment;


        public frmListbyDepartment()
        {
            InitializeComponent();

            adminPersonelOperations = new AdminHotelPersonelCrudOperations();
            adminHotelCrudOperations = new AdminHotelCrudOperations();
            hotelPersonels = new List<Personel>();
            panelPersonel.Visible = false;
        }

        private void btnFindHotel_Click_1(object sender, EventArgs e)
        {
            SearchHotelAndFindPersonel();
        }

        

        private void SearchHotelAndFindPersonel()
        {
            if (txtHotelName.Text == "")
            {
                MessageBox.Show("Please Enter Hotel Name ");
                return;
            }
            AccommodationPlace hotel = adminHotelCrudOperations.FindAccommodationPlace(txtHotelName.Text);

            if (hotel == null)
            {
                MessageBox.Show("Hotel cannot find please try again");
                return;
            }

            hotelPersonels = hotel.Personels;
            panelPersonel.Visible = true;
        }

        private void listbyDepartmentBtn_Click(object sender, EventArgs e)
        {
           selectedDepartment =  (Department)Enum.Parse(typeof(Department), comboboxDepartment.SelectedItem.ToString(), true);
            if(comboboxDepartment.SelectedItem == null)
            {
                MessageBox.Show("Please choose a Department");
                return;
            }

            if (hotelPersonels.Count < 0)
            {
                MessageBox.Show($"{txtHotelName.Text} has no Personel. Please first add Personel to hotel");
                return;
            }

            ListPersonelByPosition();
        }
        private void ListPersonelByPosition()
        {
            listViewPersonel.Items.Clear();
            foreach (var personel in hotelPersonels)
            {
                if(personel.Department == selectedDepartment)
                {
                    ListViewItem personelItem = new ListViewItem
                    {
                        Text = personel.Name,
                        ToolTipText = $"Phone Number :{personel.Address.PhoneNumber}, Department : {personel.Department}",
                        Tag = personel
                    };
                    listViewPersonel.Items.Add(personelItem);
                }
            }

            if (listViewPersonel.Items.Count > 0)
            {
                panelPersonel.Visible = true;
                listViewPersonel.ShowItemToolTips = true;
            }
            else
            {
                MessageBox.Show($"{txtHotelName.Text} has no Personel in {selectedDepartment}. Please first add Personel to department");
            }

        }

        private void txtHotelName_KeyPress(object sender, KeyPressEventArgs e)
        {
            //if (char.IsLetter(e.KeyChar) || e.KeyChar == 8)
            //{
            //    e.Handled = false;
            //}
            //else
            //{
            //    e.Handled = true;
            //}
        }

        
    }
}
