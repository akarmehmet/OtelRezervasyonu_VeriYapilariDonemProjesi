
namespace OtelRezervasyonu_VeriYapilariDonemProjesi.Forms.frmAdmin
{
    partial class frmHotelUpdateDelete
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
            this.listViewHotels = new System.Windows.Forms.ListView();
            this.UpdateHotelBtn = new System.Windows.Forms.Button();
            this.richTextBoxAdress = new System.Windows.Forms.RichTextBox();
            this.addressLbl = new System.Windows.Forms.Label();
            this.startLbl = new System.Windows.Forms.Label();
            this.txtNumberOfStar = new System.Windows.Forms.TextBox();
            this.mailLbl = new System.Windows.Forms.Label();
            this.phoneLbl = new System.Windows.Forms.Label();
            this.txtHotelPhone = new System.Windows.Forms.TextBox();
            this.districtLbl = new System.Windows.Forms.Label();
            this.txtDistrict = new System.Windows.Forms.TextBox();
            this.cityLbl = new System.Windows.Forms.Label();
            this.cityTxtBx = new System.Windows.Forms.TextBox();
            this.nameLbl = new System.Windows.Forms.Label();
            this.txtHotelMail = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblHotelName = new System.Windows.Forms.Label();
            this.btnDeleteHotel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listViewHotels
            // 
            this.listViewHotels.HideSelection = false;
            this.listViewHotels.Location = new System.Drawing.Point(44, 71);
            this.listViewHotels.Name = "listViewHotels";
            this.listViewHotels.Size = new System.Drawing.Size(763, 209);
            this.listViewHotels.TabIndex = 0;
            this.listViewHotels.UseCompatibleStateImageBehavior = false;
            this.listViewHotels.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listViewHotels_MouseDoubleClick);
            // 
            // UpdateHotelBtn
            // 
            this.UpdateHotelBtn.BackColor = System.Drawing.SystemColors.HotTrack;
            this.UpdateHotelBtn.Font = new System.Drawing.Font("Century Gothic", 14.25F);
            this.UpdateHotelBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.UpdateHotelBtn.Location = new System.Drawing.Point(492, 585);
            this.UpdateHotelBtn.Name = "UpdateHotelBtn";
            this.UpdateHotelBtn.Size = new System.Drawing.Size(222, 44);
            this.UpdateHotelBtn.TabIndex = 33;
            this.UpdateHotelBtn.Text = "Update Hotel";
            this.UpdateHotelBtn.UseVisualStyleBackColor = false;
            this.UpdateHotelBtn.Click += new System.EventHandler(this.createHotelBtn_Click);
            // 
            // richTextBoxAdress
            // 
            this.richTextBoxAdress.Font = new System.Drawing.Font("Century Gothic", 14.25F);
            this.richTextBoxAdress.Location = new System.Drawing.Point(181, 459);
            this.richTextBoxAdress.Name = "richTextBoxAdress";
            this.richTextBoxAdress.Size = new System.Drawing.Size(186, 96);
            this.richTextBoxAdress.TabIndex = 32;
            this.richTextBoxAdress.Text = "";
            this.richTextBoxAdress.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // addressLbl
            // 
            this.addressLbl.AutoSize = true;
            this.addressLbl.Font = new System.Drawing.Font("Century Gothic", 14.25F);
            this.addressLbl.Location = new System.Drawing.Point(87, 462);
            this.addressLbl.Name = "addressLbl";
            this.addressLbl.Size = new System.Drawing.Size(88, 22);
            this.addressLbl.TabIndex = 31;
            this.addressLbl.Text = "Address:";
            this.addressLbl.Click += new System.EventHandler(this.addressLbl_Click);
            // 
            // startLbl
            // 
            this.startLbl.AutoSize = true;
            this.startLbl.Font = new System.Drawing.Font("Century Gothic", 14.25F);
            this.startLbl.Location = new System.Drawing.Point(392, 379);
            this.startLbl.Name = "startLbl";
            this.startLbl.Size = new System.Drawing.Size(129, 22);
            this.startLbl.TabIndex = 28;
            this.startLbl.Text = "Star Number:";
            // 
            // txtNumberOfStar
            // 
            this.txtNumberOfStar.Font = new System.Drawing.Font("Century Gothic", 14.25F);
            this.txtNumberOfStar.Location = new System.Drawing.Point(534, 373);
            this.txtNumberOfStar.Name = "txtNumberOfStar";
            this.txtNumberOfStar.Size = new System.Drawing.Size(170, 31);
            this.txtNumberOfStar.TabIndex = 27;
            // 
            // mailLbl
            // 
            this.mailLbl.AutoSize = true;
            this.mailLbl.Font = new System.Drawing.Font("Century Gothic", 14.25F);
            this.mailLbl.Location = new System.Drawing.Point(124, 361);
            this.mailLbl.Name = "mailLbl";
            this.mailLbl.Size = new System.Drawing.Size(51, 22);
            this.mailLbl.TabIndex = 26;
            this.mailLbl.Text = "Mail:";
            // 
            // phoneLbl
            // 
            this.phoneLbl.AutoSize = true;
            this.phoneLbl.Font = new System.Drawing.Font("Century Gothic", 14.25F);
            this.phoneLbl.Location = new System.Drawing.Point(454, 307);
            this.phoneLbl.Name = "phoneLbl";
            this.phoneLbl.Size = new System.Drawing.Size(74, 22);
            this.phoneLbl.TabIndex = 24;
            this.phoneLbl.Text = "Phone:";
            // 
            // txtHotelPhone
            // 
            this.txtHotelPhone.Font = new System.Drawing.Font("Century Gothic", 14.25F);
            this.txtHotelPhone.Location = new System.Drawing.Point(534, 304);
            this.txtHotelPhone.Name = "txtHotelPhone";
            this.txtHotelPhone.Size = new System.Drawing.Size(170, 31);
            this.txtHotelPhone.TabIndex = 23;
            // 
            // districtLbl
            // 
            this.districtLbl.AutoSize = true;
            this.districtLbl.Font = new System.Drawing.Font("Century Gothic", 14.25F);
            this.districtLbl.Location = new System.Drawing.Point(454, 527);
            this.districtLbl.Name = "districtLbl";
            this.districtLbl.Size = new System.Drawing.Size(74, 22);
            this.districtLbl.TabIndex = 22;
            this.districtLbl.Text = "District:";
            // 
            // txtDistrict
            // 
            this.txtDistrict.Font = new System.Drawing.Font("Century Gothic", 14.25F);
            this.txtDistrict.Location = new System.Drawing.Point(534, 524);
            this.txtDistrict.Name = "txtDistrict";
            this.txtDistrict.Size = new System.Drawing.Size(170, 31);
            this.txtDistrict.TabIndex = 21;
            // 
            // cityLbl
            // 
            this.cityLbl.AutoSize = true;
            this.cityLbl.Font = new System.Drawing.Font("Century Gothic", 14.25F);
            this.cityLbl.Location = new System.Drawing.Point(477, 447);
            this.cityLbl.Name = "cityLbl";
            this.cityLbl.Size = new System.Drawing.Size(51, 22);
            this.cityLbl.TabIndex = 20;
            this.cityLbl.Text = "City:";
            // 
            // cityTxtBx
            // 
            this.cityTxtBx.Font = new System.Drawing.Font("Century Gothic", 14.25F);
            this.cityTxtBx.Location = new System.Drawing.Point(534, 444);
            this.cityTxtBx.Name = "cityTxtBx";
            this.cityTxtBx.Size = new System.Drawing.Size(170, 31);
            this.cityTxtBx.TabIndex = 19;
            // 
            // nameLbl
            // 
            this.nameLbl.AutoSize = true;
            this.nameLbl.Font = new System.Drawing.Font("Century Gothic", 14.25F);
            this.nameLbl.Location = new System.Drawing.Point(104, 313);
            this.nameLbl.Name = "nameLbl";
            this.nameLbl.Size = new System.Drawing.Size(71, 22);
            this.nameLbl.TabIndex = 18;
            this.nameLbl.Text = "Name:";
            // 
            // txtHotelMail
            // 
            this.txtHotelMail.Font = new System.Drawing.Font("Century Gothic", 14.25F);
            this.txtHotelMail.Location = new System.Drawing.Point(181, 358);
            this.txtHotelMail.Name = "txtHotelMail";
            this.txtHotelMail.Size = new System.Drawing.Size(186, 31);
            this.txtHotelMail.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(46, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(392, 41);
            this.label1.TabIndex = 34;
            this.label1.Text = "Update / Delete Hotel:";
            // 
            // lblHotelName
            // 
            this.lblHotelName.AutoSize = true;
            this.lblHotelName.Font = new System.Drawing.Font("Century Gothic", 14.25F);
            this.lblHotelName.Location = new System.Drawing.Point(228, 313);
            this.lblHotelName.Name = "lblHotelName";
            this.lblHotelName.Size = new System.Drawing.Size(0, 22);
            this.lblHotelName.TabIndex = 18;
            // 
            // btnDeleteHotel
            // 
            this.btnDeleteHotel.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnDeleteHotel.Font = new System.Drawing.Font("Century Gothic", 14.25F);
            this.btnDeleteHotel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDeleteHotel.Location = new System.Drawing.Point(145, 585);
            this.btnDeleteHotel.Name = "btnDeleteHotel";
            this.btnDeleteHotel.Size = new System.Drawing.Size(222, 44);
            this.btnDeleteHotel.TabIndex = 33;
            this.btnDeleteHotel.Text = "Delete Hotel";
            this.btnDeleteHotel.UseVisualStyleBackColor = false;
            this.btnDeleteHotel.Click += new System.EventHandler(this.deleteHotelBtn_Click);
            // 
            // frmHotelUpdateDelete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(839, 641);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.richTextBoxAdress);
            this.Controls.Add(this.mailLbl);
            this.Controls.Add(this.lblHotelName);
            this.Controls.Add(this.nameLbl);
            this.Controls.Add(this.txtHotelMail);
            this.Controls.Add(this.btnDeleteHotel);
            this.Controls.Add(this.UpdateHotelBtn);
            this.Controls.Add(this.addressLbl);
            this.Controls.Add(this.startLbl);
            this.Controls.Add(this.txtNumberOfStar);
            this.Controls.Add(this.phoneLbl);
            this.Controls.Add(this.txtHotelPhone);
            this.Controls.Add(this.districtLbl);
            this.Controls.Add(this.txtDistrict);
            this.Controls.Add(this.cityLbl);
            this.Controls.Add(this.cityTxtBx);
            this.Controls.Add(this.listViewHotels);
            this.Location = new System.Drawing.Point(294, 54);
            this.Name = "frmHotelUpdateDelete";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Hotel Update Delete";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listViewHotels;
        private System.Windows.Forms.Button UpdateHotelBtn;
        private System.Windows.Forms.RichTextBox richTextBoxAdress;
        private System.Windows.Forms.Label addressLbl;
        private System.Windows.Forms.Label startLbl;
        private System.Windows.Forms.TextBox txtNumberOfStar;
        private System.Windows.Forms.Label mailLbl;
        private System.Windows.Forms.Label phoneLbl;
        private System.Windows.Forms.TextBox txtHotelPhone;
        private System.Windows.Forms.Label districtLbl;
        private System.Windows.Forms.TextBox txtDistrict;
        private System.Windows.Forms.Label cityLbl;
        private System.Windows.Forms.TextBox cityTxtBx;
        private System.Windows.Forms.Label nameLbl;
        private System.Windows.Forms.TextBox txtHotelMail;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblHotelName;
        private System.Windows.Forms.Button btnDeleteHotel;
    }
}