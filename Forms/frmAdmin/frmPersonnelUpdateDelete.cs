using OtelRezervasyonu_VeriYapilariDonemProjesi.Scripts.ConcreteClass;
using OtelRezervasyonu_VeriYapilariDonemProjesi.Scripts.DatabaseOperations;
using OtelRezervasyonu_VeriYapilariDonemProjesi.Scripts.Enums;
using OtelRezervasyonu_VeriYapilariDonemProjesi.Scripts.Interfaces;
using OtelRezervasyonu_VeriYapilariDonemProjesi.Scripts.Models;
using System;
using System.Windows.Forms;

namespace OtelRezervasyonu_VeriYapilariDonemProjesi.Forms.frmCustomer
{
    public partial class frmPersonnelUpdateDelete : Form
    {
        private IDbAdminPersonelCrudOperations adminPersonelOperations;
        private IDbAdminAccomodationPlaceCrudOperations adminHotelCrudOperations;
        private ListViewItem selectedPersonel;

        public frmPersonnelUpdateDelete()
        {
            InitializeComponent();

            adminPersonelOperations = new AdminHotelPersonelCrupOperations();
            adminHotelCrudOperations = new AdminHotelCrudOperations();
            panelPersonel.Visible = false;
        }






        private void btnOtelPersoneli_Click(object sender, EventArgs e)
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

            if (hotel != null)
            {
                listViewHotel.ShowItemToolTips = true;
                foreach (var personel in hotel.Personels)
                {
                    ListViewItem personelItem = new ListViewItem();
                    personelItem.Text = personel.Name;
                    personelItem.ToolTipText = $"Phone Number :{personel.Address.PhoneNumber}, Department : {personel.Department}";
                    personelItem.Tag = personel;
                    listViewHotel.Items.Add(personelItem);
                }

                if (listViewHotel.Items.Count > 0)
                {
                    listViewHotel.Visible = true;
                }
                else
                {
                    MessageBox.Show($"{txtHotelName.Text} has no Personel. Please first add Personel to hotel");
                }


            }

        }


        private void listViewHotel_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            selectedPersonel = listViewHotel.SelectedItems[0];
            FillTextAccordingToSelection();

        }
        private void FillTextAccordingToSelection()
        {
            Personel sPersonel = ((Personel)selectedPersonel.Tag);

            txtAdress.Text = sPersonel.Address.OpenAdress;
            txtMail.Text = sPersonel.Address.Email;
            txtPhone.Text = sPersonel.Address.PhoneNumber;
            txtName.Text = sPersonel.Name;
            txtTcNo.Text = sPersonel.IdentificationNumber;
            comboBoxDepartment.SelectedIndex = comboBoxDepartment.FindStringExact(sPersonel.Department.ToString());
            comboBoxPosition.SelectedIndex = comboBoxPosition.FindStringExact(sPersonel.Position.ToString());
        }


        private void DeletePersonelButton_Click(object sender, EventArgs e)
        {
            DeletePersonel();
        }

        private void DeletePersonel()
        {

            if (!CheckIsAllTextFull())
            {
                MessageBox.Show("Please fill all emtpy text");
                return;
            }
            if (!adminPersonelOperations.DeletePersonelFormDb(txtTcNo.Text, txtHotelName.Text))
            {
                MessageBox.Show("Personel or Hotel is not found. Please try again");
                return;
            }

            MessageBox.Show("Personel is deleted.");
            CleanAllText();
            panelPersonel.Visible = false;

        }

        private void UpdatePersonelButton_Click(object sender, EventArgs e)
        {
            if (!CheckIsAllTextFull())
            {
                MessageBox.Show("Please fill all emtpy text");
                return;
            }

            Personel updatedPersonel = (Personel)selectedPersonel.Tag;

            updatedPersonel.Address.OpenAdress = txtAdress.Text;
            updatedPersonel.Address.Email = txtMail.Text;
            updatedPersonel.Address.PhoneNumber = txtPhone.Text;
            updatedPersonel.Name = txtName.Text;
            updatedPersonel.Department = (Department)Enum.Parse(typeof(Department), comboBoxDepartment.SelectedItem.ToString(), true);
            updatedPersonel.Position = (Position)Enum.Parse(typeof(Position), comboBoxPosition.SelectedItem.ToString(), true);




            if (!adminPersonelOperations.UpdatePersonelInfo(updatedPersonel,txtHotelName.Text))
            {
                MessageBox.Show("Personel or Hotel is not found. Please try again");
                return;
            }

            MessageBox.Show("Personel is deleted.");
            CleanAllText();
            panelPersonel.Visible = false;
        }


        private bool CheckIsAllTextFull()
        {
            if (
                 txtAdress.Text == "" ||
            txtMail.Text == "" ||
            txtPhone.Text == "" ||
            txtName.Text == "" ||
            txtTcNo.Text == "" ||
            comboBoxDepartment.SelectedItem == null ||
            comboBoxPosition.SelectedItem == null)
                return false;
            else
                return true;
        }
        private void CleanAllText()
        {
            txtAdress.Text = "";
            txtMail.Text = "";
            txtPhone.Text = "";
            txtName.Text = "";
            txtTcNo.Text = "";
            comboBoxDepartment.SelectedItem = null;
            comboBoxPosition.SelectedItem = null;
        }




















        #region ChechKeyPressFunction

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
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

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
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

        

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
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





        #endregion

    }
}
