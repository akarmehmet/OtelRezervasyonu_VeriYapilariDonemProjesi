
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
            this.hotelNameTxtBx = new System.Windows.Forms.TextBox();
            this.listbyCityDistrictBtn = new System.Windows.Forms.Button();
            this.HotelsLstVw = new System.Windows.Forms.ListView();
            this.CityNameLbl = new System.Windows.Forms.Label();
            this.districtTxtBx = new System.Windows.Forms.TextBox();
            this.districtLbl = new System.Windows.Forms.Label();
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
            // hotelNameTxtBx
            // 
            this.hotelNameTxtBx.Font = new System.Drawing.Font("Century Gothic", 14.25F);
            this.hotelNameTxtBx.Location = new System.Drawing.Point(171, 122);
            this.hotelNameTxtBx.Name = "hotelNameTxtBx";
            this.hotelNameTxtBx.Size = new System.Drawing.Size(213, 31);
            this.hotelNameTxtBx.TabIndex = 40;
            this.hotelNameTxtBx.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.hotelNameTxtBx_KeyPress);
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
            // 
            // HotelsLstVw
            // 
            this.HotelsLstVw.HideSelection = false;
            this.HotelsLstVw.Location = new System.Drawing.Point(32, 269);
            this.HotelsLstVw.Name = "HotelsLstVw";
            this.HotelsLstVw.Size = new System.Drawing.Size(770, 330);
            this.HotelsLstVw.TabIndex = 38;
            this.HotelsLstVw.UseCompatibleStateImageBehavior = false;
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
            // districtTxtBx
            // 
            this.districtTxtBx.Font = new System.Drawing.Font("Century Gothic", 14.25F);
            this.districtTxtBx.Location = new System.Drawing.Point(525, 122);
            this.districtTxtBx.Name = "districtTxtBx";
            this.districtTxtBx.Size = new System.Drawing.Size(232, 31);
            this.districtTxtBx.TabIndex = 41;
            this.districtTxtBx.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.districtTxtBx_KeyPress);
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
            // frmListbyCityDistrict
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(839, 641);
            this.Controls.Add(this.districtLbl);
            this.Controls.Add(this.districtTxtBx);
            this.Controls.Add(this.hotelNameTxtBx);
            this.Controls.Add(this.listbyCityDistrictBtn);
            this.Controls.Add(this.HotelsLstVw);
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
        private System.Windows.Forms.TextBox hotelNameTxtBx;
        private System.Windows.Forms.Button listbyCityDistrictBtn;
        private System.Windows.Forms.ListView HotelsLstVw;
        private System.Windows.Forms.Label CityNameLbl;
        private System.Windows.Forms.TextBox districtTxtBx;
        private System.Windows.Forms.Label districtLbl;
    }
}