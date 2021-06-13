using OtelRezervasyonu_VeriYapilariDonemProjesi.Scripts.ConcreteClass;
using OtelRezervasyonu_VeriYapilariDonemProjesi.Scripts.DatabaseOperations;
using OtelRezervasyonu_VeriYapilariDonemProjesi.Scripts.Enums;
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

namespace OtelRezervasyonu_VeriYapilariDonemProjesi.Forms.frmAdmin
{

    public partial class frmListbyDepartment : Form
    {

        private IDbAdminPersonelCrudOperations adminPersonelOperations;
        private IDbAdminAccomodationPlaceCrudOperations adminHotelCrudOperations;
        private List<Personel> hotelPersonels;
        private Position selectedPosition;


        public frmListbyDepartment()
        {
            InitializeComponent();

            adminPersonelOperations = new AdminHotelPersonelCrupOperations();
            adminHotelCrudOperations = new AdminHotelCrudOperations();
            hotelPersonels = new List<Personel>();
            panelPersonel.Visible = false;
        }

        private void btnFindHotel_Click(object sender, EventArgs e)
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

           
            foreach (var personel in hotel.Personels)
            {
                ListViewItem personelItem = new ListViewItem();
                personelItem.Text = personel.Name;
                personelItem.ToolTipText = $"Phone Number :{personel.Address.PhoneNumber}, Department : {personel.Department}";
                personelItem.Tag = personel;
                listViewPersonel.Items.Add(personelItem);
            }

            if (listViewPersonel.Items.Count > 0)
            {
                panelPersonel.Visible = true;
            }
            else
            {
                MessageBox.Show($"{txtHotelName.Text} has no Personel. Please first add Personel to hotel");
            }
        }

        private void listbyDepartmentBtn_Click(object sender, EventArgs e)
        {
           selectedPosition =  (Position)Enum.Parse(typeof(Position), comboboxDepartment.SelectedItem.ToString(), true);
            if(comboboxDepartment.SelectedItem == null)
            {
                MessageBox.Show("Please choose a Department");
            }
        }
        private void ListPersonelByPosition()
        {

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
    }
}
