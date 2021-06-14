
namespace OtelRezervasyonu_VeriYapilariDonemProjesi.Forms.frmCustomer
{
    partial class frmMakeReservation
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.rezervationLbl = new System.Windows.Forms.Label();
            this.findPersonel = new System.Windows.Forms.Button();
            this.lblHotelName = new System.Windows.Forms.Label();
            this.txtHotelName = new System.Windows.Forms.TextBox();
            this.panelCustomerInfo = new System.Windows.Forms.Panel();
            this.lblEnteredNumberOfPerson = new System.Windows.Forms.Label();
            this.lblNumberOfPerson = new System.Windows.Forms.Label();
            this.txtAdress = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.addPersonBtn = new System.Windows.Forms.Button();
            this.mailLbl = new System.Windows.Forms.Label();
            this.txtMail = new System.Windows.Forms.TextBox();
            this.totalPriceLbl = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTcNo = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.nameLbl = new System.Windows.Forms.Label();
            this.phoneLbl = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtReservationNo = new System.Windows.Forms.TextBox();
            this.rezervationsLbl = new System.Windows.Forms.Label();
            this.roomLbl = new System.Windows.Forms.Label();
            this.txtNumberOfPerson = new System.Windows.Forms.TextBox();
            this.NumberofPersonsLbl = new System.Windows.Forms.Label();
            this.txtNumberOfDays = new System.Windows.Forms.TextBox();
            this.numberofDaysLbl = new System.Windows.Forms.Label();
            this.panelReservationInfo = new System.Windows.Forms.Panel();
            this.comboBoxRoomNo = new System.Windows.Forms.ComboBox();
            this.btnMakeReservation = new System.Windows.Forms.Button();
            this.lblTotalPrice = new System.Windows.Forms.Label();
            this.panelCustomerInfo.SuspendLayout();
            this.panelReservationInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // rezervationLbl
            // 
            this.rezervationLbl.AutoSize = true;
            this.rezervationLbl.Font = new System.Drawing.Font("Century Gothic", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rezervationLbl.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.rezervationLbl.Location = new System.Drawing.Point(67, 28);
            this.rezervationLbl.Name = "rezervationLbl";
            this.rezervationLbl.Size = new System.Drawing.Size(223, 41);
            this.rezervationLbl.TabIndex = 27;
            this.rezervationLbl.Text = "Rezervation:";
            // 
            // findPersonel
            // 
            this.findPersonel.BackColor = System.Drawing.SystemColors.HotTrack;
            this.findPersonel.Font = new System.Drawing.Font("Century Gothic", 14.25F);
            this.findPersonel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.findPersonel.Location = new System.Drawing.Point(471, 80);
            this.findPersonel.Name = "findPersonel";
            this.findPersonel.Size = new System.Drawing.Size(232, 44);
            this.findPersonel.TabIndex = 87;
            this.findPersonel.Text = "Find Hotel";
            this.findPersonel.UseVisualStyleBackColor = false;
            this.findPersonel.Click += new System.EventHandler(this.findPersonel_Click);
            // 
            // lblHotelName
            // 
            this.lblHotelName.AutoSize = true;
            this.lblHotelName.Font = new System.Drawing.Font("Century Gothic", 14.25F);
            this.lblHotelName.Location = new System.Drawing.Point(63, 91);
            this.lblHotelName.Name = "lblHotelName";
            this.lblHotelName.Size = new System.Drawing.Size(118, 22);
            this.lblHotelName.TabIndex = 86;
            this.lblHotelName.Text = "Hotel Name";
            // 
            // txtHotelName
            // 
            this.txtHotelName.Font = new System.Drawing.Font("Century Gothic", 14.25F);
            this.txtHotelName.Location = new System.Drawing.Point(187, 88);
            this.txtHotelName.Name = "txtHotelName";
            this.txtHotelName.Size = new System.Drawing.Size(186, 31);
            this.txtHotelName.TabIndex = 85;
            // 
            // panelCustomerInfo
            // 
            this.panelCustomerInfo.Controls.Add(this.lblEnteredNumberOfPerson);
            this.panelCustomerInfo.Controls.Add(this.lblNumberOfPerson);
            this.panelCustomerInfo.Controls.Add(this.txtAdress);
            this.panelCustomerInfo.Controls.Add(this.label1);
            this.panelCustomerInfo.Controls.Add(this.addPersonBtn);
            this.panelCustomerInfo.Controls.Add(this.mailLbl);
            this.panelCustomerInfo.Controls.Add(this.txtMail);
            this.panelCustomerInfo.Controls.Add(this.label4);
            this.panelCustomerInfo.Controls.Add(this.txtTcNo);
            this.panelCustomerInfo.Controls.Add(this.txtPhone);
            this.panelCustomerInfo.Controls.Add(this.nameLbl);
            this.panelCustomerInfo.Controls.Add(this.phoneLbl);
            this.panelCustomerInfo.Controls.Add(this.txtName);
            this.panelCustomerInfo.Location = new System.Drawing.Point(12, 326);
            this.panelCustomerInfo.Name = "panelCustomerInfo";
            this.panelCustomerInfo.Size = new System.Drawing.Size(815, 327);
            this.panelCustomerInfo.TabIndex = 88;
            this.panelCustomerInfo.Visible = false;
            // 
            // lblEnteredNumberOfPerson
            // 
            this.lblEnteredNumberOfPerson.AutoSize = true;
            this.lblEnteredNumberOfPerson.Location = new System.Drawing.Point(155, 285);
            this.lblEnteredNumberOfPerson.Name = "lblEnteredNumberOfPerson";
            this.lblEnteredNumberOfPerson.Size = new System.Drawing.Size(0, 13);
            this.lblEnteredNumberOfPerson.TabIndex = 119;
            // 
            // lblNumberOfPerson
            // 
            this.lblNumberOfPerson.AutoSize = true;
            this.lblNumberOfPerson.Location = new System.Drawing.Point(39, 285);
            this.lblNumberOfPerson.Name = "lblNumberOfPerson";
            this.lblNumberOfPerson.Size = new System.Drawing.Size(133, 13);
            this.lblNumberOfPerson.TabIndex = 119;
            this.lblNumberOfPerson.Text = "Number Of Added Persons";
            // 
            // txtAdress
            // 
            this.txtAdress.Font = new System.Drawing.Font("Century Gothic", 14.25F);
            this.txtAdress.Location = new System.Drawing.Point(163, 89);
            this.txtAdress.Name = "txtAdress";
            this.txtAdress.Size = new System.Drawing.Size(186, 116);
            this.txtAdress.TabIndex = 118;
            this.txtAdress.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F);
            this.label1.Location = new System.Drawing.Point(69, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 22);
            this.label1.TabIndex = 117;
            this.label1.Text = "Address:";
            // 
            // addPersonBtn
            // 
            this.addPersonBtn.BackColor = System.Drawing.SystemColors.HotTrack;
            this.addPersonBtn.Font = new System.Drawing.Font("Century Gothic", 14.25F);
            this.addPersonBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.addPersonBtn.Location = new System.Drawing.Point(525, 273);
            this.addPersonBtn.Name = "addPersonBtn";
            this.addPersonBtn.Size = new System.Drawing.Size(257, 45);
            this.addPersonBtn.TabIndex = 89;
            this.addPersonBtn.Text = "Add Person";
            this.addPersonBtn.UseVisualStyleBackColor = false;
            this.addPersonBtn.Click += new System.EventHandler(this.addPersonBtn_Click);
            // 
            // mailLbl
            // 
            this.mailLbl.AutoSize = true;
            this.mailLbl.Font = new System.Drawing.Font("Century Gothic", 14.25F);
            this.mailLbl.Location = new System.Drawing.Point(453, 58);
            this.mailLbl.Name = "mailLbl";
            this.mailLbl.Size = new System.Drawing.Size(51, 22);
            this.mailLbl.TabIndex = 105;
            this.mailLbl.Text = "Mail:";
            // 
            // txtMail
            // 
            this.txtMail.Font = new System.Drawing.Font("Century Gothic", 14.25F);
            this.txtMail.Location = new System.Drawing.Point(505, 55);
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(186, 31);
            this.txtMail.TabIndex = 104;
            // 
            // totalPriceLbl
            // 
            this.totalPriceLbl.AutoSize = true;
            this.totalPriceLbl.Font = new System.Drawing.Font("Century Gothic", 14.25F);
            this.totalPriceLbl.Location = new System.Drawing.Point(57, 680);
            this.totalPriceLbl.Name = "totalPriceLbl";
            this.totalPriceLbl.Size = new System.Drawing.Size(107, 22);
            this.totalPriceLbl.TabIndex = 116;
            this.totalPriceLbl.Text = "Total Price:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 14.25F);
            this.label4.Location = new System.Drawing.Point(86, 55);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 22);
            this.label4.TabIndex = 101;
            this.label4.Text = "Phone:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // txtTcNo
            // 
            this.txtTcNo.Font = new System.Drawing.Font("Century Gothic", 14.25F);
            this.txtTcNo.Location = new System.Drawing.Point(161, 10);
            this.txtTcNo.Name = "txtTcNo";
            this.txtTcNo.Size = new System.Drawing.Size(186, 31);
            this.txtTcNo.TabIndex = 96;
            // 
            // txtPhone
            // 
            this.txtPhone.Font = new System.Drawing.Font("Century Gothic", 14.25F);
            this.txtPhone.Location = new System.Drawing.Point(161, 52);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(186, 31);
            this.txtPhone.TabIndex = 100;
            this.txtPhone.TextChanged += new System.EventHandler(this.txtPhone_TextChanged);
            // 
            // nameLbl
            // 
            this.nameLbl.AutoSize = true;
            this.nameLbl.Font = new System.Drawing.Font("Century Gothic", 14.25F);
            this.nameLbl.Location = new System.Drawing.Point(86, 13);
            this.nameLbl.Name = "nameLbl";
            this.nameLbl.Size = new System.Drawing.Size(69, 22);
            this.nameLbl.TabIndex = 97;
            this.nameLbl.Text = "TC No:";
            // 
            // phoneLbl
            // 
            this.phoneLbl.AutoSize = true;
            this.phoneLbl.Font = new System.Drawing.Font("Century Gothic", 14.25F);
            this.phoneLbl.Location = new System.Drawing.Point(403, 13);
            this.phoneLbl.Name = "phoneLbl";
            this.phoneLbl.Size = new System.Drawing.Size(96, 44);
            this.phoneLbl.TabIndex = 99;
            this.phoneLbl.Text = "  Name\r\nSurname:";
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Century Gothic", 14.25F);
            this.txtName.Location = new System.Drawing.Point(505, 13);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(186, 31);
            this.txtName.TabIndex = 98;
            // 
            // txtReservationNo
            // 
            this.txtReservationNo.Font = new System.Drawing.Font("Century Gothic", 14.25F);
            this.txtReservationNo.Location = new System.Drawing.Point(161, 47);
            this.txtReservationNo.Name = "txtReservationNo";
            this.txtReservationNo.Size = new System.Drawing.Size(186, 31);
            this.txtReservationNo.TabIndex = 106;
            // 
            // rezervationsLbl
            // 
            this.rezervationsLbl.AutoSize = true;
            this.rezervationsLbl.Font = new System.Drawing.Font("Century Gothic", 14.25F);
            this.rezervationsLbl.Location = new System.Drawing.Point(35, 35);
            this.rezervationsLbl.Name = "rezervationsLbl";
            this.rezervationsLbl.Size = new System.Drawing.Size(125, 44);
            this.rezervationsLbl.TabIndex = 107;
            this.rezervationsLbl.Text = "Rezervation \r\n      No:";
            // 
            // roomLbl
            // 
            this.roomLbl.AutoSize = true;
            this.roomLbl.Font = new System.Drawing.Font("Century Gothic", 14.25F);
            this.roomLbl.Location = new System.Drawing.Point(401, 103);
            this.roomLbl.Name = "roomLbl";
            this.roomLbl.Size = new System.Drawing.Size(99, 22);
            this.roomLbl.TabIndex = 109;
            this.roomLbl.Text = "Room No:";
            // 
            // txtNumberOfPerson
            // 
            this.txtNumberOfPerson.Font = new System.Drawing.Font("Century Gothic", 14.25F);
            this.txtNumberOfPerson.Location = new System.Drawing.Point(505, 58);
            this.txtNumberOfPerson.Name = "txtNumberOfPerson";
            this.txtNumberOfPerson.Size = new System.Drawing.Size(186, 31);
            this.txtNumberOfPerson.TabIndex = 111;
            this.txtNumberOfPerson.TextChanged += new System.EventHandler(this.numberofPersonsTxtBx_TextChanged);
            // 
            // NumberofPersonsLbl
            // 
            this.NumberofPersonsLbl.AutoSize = true;
            this.NumberofPersonsLbl.Font = new System.Drawing.Font("Century Gothic", 14.25F);
            this.NumberofPersonsLbl.Location = new System.Drawing.Point(401, 49);
            this.NumberofPersonsLbl.Name = "NumberofPersonsLbl";
            this.NumberofPersonsLbl.Size = new System.Drawing.Size(107, 44);
            this.NumberofPersonsLbl.TabIndex = 112;
            this.NumberofPersonsLbl.Text = "Number of\r\n  Persons:";
            this.NumberofPersonsLbl.Click += new System.EventHandler(this.NumberofPersonsLbl_Click);
            // 
            // txtNumberOfDays
            // 
            this.txtNumberOfDays.Font = new System.Drawing.Font("Century Gothic", 14.25F);
            this.txtNumberOfDays.Location = new System.Drawing.Point(158, 103);
            this.txtNumberOfDays.Name = "txtNumberOfDays";
            this.txtNumberOfDays.Size = new System.Drawing.Size(186, 31);
            this.txtNumberOfDays.TabIndex = 113;
            // 
            // numberofDaysLbl
            // 
            this.numberofDaysLbl.AutoSize = true;
            this.numberofDaysLbl.Font = new System.Drawing.Font("Century Gothic", 14.25F);
            this.numberofDaysLbl.Location = new System.Drawing.Point(43, 103);
            this.numberofDaysLbl.Name = "numberofDaysLbl";
            this.numberofDaysLbl.Size = new System.Drawing.Size(112, 44);
            this.numberofDaysLbl.TabIndex = 114;
            this.numberofDaysLbl.Text = "Number of \r\n    Days:";
            // 
            // panelReservationInfo
            // 
            this.panelReservationInfo.Controls.Add(this.txtReservationNo);
            this.panelReservationInfo.Controls.Add(this.roomLbl);
            this.panelReservationInfo.Controls.Add(this.comboBoxRoomNo);
            this.panelReservationInfo.Controls.Add(this.numberofDaysLbl);
            this.panelReservationInfo.Controls.Add(this.txtNumberOfDays);
            this.panelReservationInfo.Controls.Add(this.txtNumberOfPerson);
            this.panelReservationInfo.Controls.Add(this.NumberofPersonsLbl);
            this.panelReservationInfo.Controls.Add(this.rezervationsLbl);
            this.panelReservationInfo.Location = new System.Drawing.Point(11, 140);
            this.panelReservationInfo.Name = "panelReservationInfo";
            this.panelReservationInfo.Size = new System.Drawing.Size(815, 156);
            this.panelReservationInfo.TabIndex = 115;
            this.panelReservationInfo.Visible = false;
            // 
            // comboBoxRoomNo
            // 
            this.comboBoxRoomNo.Font = new System.Drawing.Font("Century Gothic", 14.25F);
            this.comboBoxRoomNo.FormattingEnabled = true;
            this.comboBoxRoomNo.Location = new System.Drawing.Point(505, 100);
            this.comboBoxRoomNo.Name = "comboBoxRoomNo";
            this.comboBoxRoomNo.Size = new System.Drawing.Size(186, 30);
            this.comboBoxRoomNo.TabIndex = 110;
            // 
            // btnMakeReservation
            // 
            this.btnMakeReservation.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnMakeReservation.Font = new System.Drawing.Font("Century Gothic", 14.25F);
            this.btnMakeReservation.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnMakeReservation.Location = new System.Drawing.Point(173, 734);
            this.btnMakeReservation.Name = "btnMakeReservation";
            this.btnMakeReservation.Size = new System.Drawing.Size(493, 45);
            this.btnMakeReservation.TabIndex = 89;
            this.btnMakeReservation.Text = "Make Reservation";
            this.btnMakeReservation.UseVisualStyleBackColor = false;
            this.btnMakeReservation.Visible = false;
            this.btnMakeReservation.Click += new System.EventHandler(this.btnMakeReservation_Click);
            // 
            // lblTotalPrice
            // 
            this.lblTotalPrice.AutoSize = true;
            this.lblTotalPrice.Font = new System.Drawing.Font("Century Gothic", 14.25F);
            this.lblTotalPrice.Location = new System.Drawing.Point(192, 680);
            this.lblTotalPrice.Name = "lblTotalPrice";
            this.lblTotalPrice.Size = new System.Drawing.Size(0, 22);
            this.lblTotalPrice.TabIndex = 116;
            // 
            // frmMakeReservation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(839, 791);
            this.Controls.Add(this.panelReservationInfo);
            this.Controls.Add(this.panelCustomerInfo);
            this.Controls.Add(this.findPersonel);
            this.Controls.Add(this.lblHotelName);
            this.Controls.Add(this.btnMakeReservation);
            this.Controls.Add(this.txtHotelName);
            this.Controls.Add(this.rezervationLbl);
            this.Controls.Add(this.lblTotalPrice);
            this.Controls.Add(this.totalPriceLbl);
            this.Location = new System.Drawing.Point(294, 54);
            this.Name = "frmMakeReservation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Make Reservation";
            this.panelCustomerInfo.ResumeLayout(false);
            this.panelCustomerInfo.PerformLayout();
            this.panelReservationInfo.ResumeLayout(false);
            this.panelReservationInfo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label rezervationLbl;
        private System.Windows.Forms.Button findPersonel;
        private System.Windows.Forms.Label lblHotelName;
        private System.Windows.Forms.TextBox txtHotelName;
        private System.Windows.Forms.Panel panelCustomerInfo;
        private System.Windows.Forms.Button addPersonBtn;
        private System.Windows.Forms.Label mailLbl;
        private System.Windows.Forms.TextBox txtMail;
        private System.Windows.Forms.Label totalPriceLbl;
        private System.Windows.Forms.TextBox txtNumberOfDays;
        private System.Windows.Forms.Label numberofDaysLbl;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTcNo;
        private System.Windows.Forms.TextBox txtNumberOfPerson;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label nameLbl;
        private System.Windows.Forms.Label NumberofPersonsLbl;
        private System.Windows.Forms.Label phoneLbl;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtReservationNo;
        private System.Windows.Forms.Label rezervationsLbl;
        private System.Windows.Forms.Label roomLbl;
        private System.Windows.Forms.RichTextBox txtAdress;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelReservationInfo;
        private System.Windows.Forms.Label lblEnteredNumberOfPerson;
        private System.Windows.Forms.Label lblNumberOfPerson;
        private System.Windows.Forms.Button btnMakeReservation;
        private System.Windows.Forms.ComboBox comboBoxRoomNo;
        private System.Windows.Forms.Label lblTotalPrice;
    }
}