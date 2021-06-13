
namespace OtelRezervasyonu_VeriYapilariDonemProjesi.Forms.frmCustomer
{
    partial class frmListbyCityDistrict
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
            this.listbyCity = new System.Windows.Forms.Label();
            this.listbyCityDistrictBtn = new System.Windows.Forms.Button();
            this.listViewHotel = new System.Windows.Forms.ListView();
            this.CityNameLbl = new System.Windows.Forms.Label();
            this.txtdistrict = new System.Windows.Forms.TextBox();
            this.districtLbl = new System.Windows.Forms.Label();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // listbyCity
            // 
            this.listbyCity.AutoSize = true;
            this.listbyCity.Font = new System.Drawing.Font("Century Gothic", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listbyCity.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.listbyCity.Location = new System.Drawing.Point(78, 41);
            this.listbyCity.Name = "listbyCity";
            this.listbyCity.Size = new System.Drawing.Size(348, 41);
            this.listbyCity.TabIndex = 32;
            this.listbyCity.Text = "List by City - District:";
            // 
            // listbyCityDistrictBtn
            // 
            this.listbyCityDistrictBtn.BackColor = System.Drawing.SystemColors.HotTrack;
            this.listbyCityDistrictBtn.Font = new System.Drawing.Font("Century Gothic", 14.25F);
            this.listbyCityDistrictBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.listbyCityDistrictBtn.Location = new System.Drawing.Point(85, 183);
            this.listbyCityDistrictBtn.Name = "listbyCityDistrictBtn";
            this.listbyCityDistrictBtn.Size = new System.Drawing.Size(672, 62);
            this.listbyCityDistrictBtn.TabIndex = 39;
            this.listbyCityDistrictBtn.Text = "List by City - District";
            this.listbyCityDistrictBtn.UseVisualStyleBackColor = false;
            this.listbyCityDistrictBtn.Click += new System.EventHandler(this.listbyCityDistrictBtn_Click);
            // 
            // listViewHotel
            // 
            this.listViewHotel.HideSelection = false;
            this.listViewHotel.Location = new System.Drawing.Point(32, 269);
            this.listViewHotel.Name = "listViewHotel";
            this.listViewHotel.Size = new System.Drawing.Size(770, 330);
            this.listViewHotel.TabIndex = 38;
            this.listViewHotel.UseCompatibleStateImageBehavior = false;
            // 
            // CityNameLbl
            // 
            this.CityNameLbl.AutoSize = true;
            this.CityNameLbl.Font = new System.Drawing.Font("Century Gothic", 14.25F);
            this.CityNameLbl.Location = new System.Drawing.Point(114, 125);
            this.CityNameLbl.Name = "CityNameLbl";
            this.CityNameLbl.Size = new System.Drawing.Size(51, 22);
            this.CityNameLbl.TabIndex = 37;
            this.CityNameLbl.Text = "City:";
            // 
            // txtdistrict
            // 
            this.txtdistrict.Font = new System.Drawing.Font("Century Gothic", 14.25F);
            this.txtdistrict.Location = new System.Drawing.Point(525, 122);
            this.txtdistrict.Name = "txtdistrict";
            this.txtdistrict.Size = new System.Drawing.Size(232, 31);
            this.txtdistrict.TabIndex = 41;
            this.txtdistrict.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.districtTxtBx_KeyPress);
            // 
            // districtLbl
            // 
            this.districtLbl.AutoSize = true;
            this.districtLbl.Font = new System.Drawing.Font("Century Gothic", 14.25F);
            this.districtLbl.Location = new System.Drawing.Point(445, 125);
            this.districtLbl.Name = "districtLbl";
            this.districtLbl.Size = new System.Drawing.Size(74, 22);
            this.districtLbl.TabIndex = 42;
            this.districtLbl.Text = "District:";
            // 
            // txtCity
            // 
            this.txtCity.Font = new System.Drawing.Font("Century Gothic", 14.25F);
            this.txtCity.Location = new System.Drawing.Point(171, 122);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(213, 31);
            this.txtCity.TabIndex = 40;
            this.txtCity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.hotelNameTxtBx_KeyPress);
            // 
            // frmListbyCityDistrict
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(839, 641);
            this.Controls.Add(this.districtLbl);
            this.Controls.Add(this.txtdistrict);
            this.Controls.Add(this.txtCity);
            this.Controls.Add(this.listbyCityDistrictBtn);
            this.Controls.Add(this.listViewHotel);
            this.Controls.Add(this.CityNameLbl);
            this.Controls.Add(this.listbyCity);
            this.Location = new System.Drawing.Point(294, 54);
            this.Name = "frmListbyCityDistrict";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "List by City - District";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label listbyCity;
        private System.Windows.Forms.Button listbyCityDistrictBtn;
        private System.Windows.Forms.ListView listViewHotel;
        private System.Windows.Forms.Label CityNameLbl;
        private System.Windows.Forms.TextBox txtdistrict;
        private System.Windows.Forms.Label districtLbl;
        private System.Windows.Forms.TextBox txtCity;
    }
}