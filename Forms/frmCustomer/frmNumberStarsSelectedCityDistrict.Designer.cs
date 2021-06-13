
namespace OtelRezervasyonu_VeriYapilariDonemProjesi.Forms.frmCustomer
{
    partial class frmNumberStarsSelectedCityDistrict
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
            this.districtLbl = new System.Windows.Forms.Label();
            this.txtDistrict = new System.Windows.Forms.TextBox();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.btnListHotel = new System.Windows.Forms.Button();
            this.listViewHotel = new System.Windows.Forms.ListView();
            this.CityNameLbl = new System.Windows.Forms.Label();
            this.numberStarsSelectedLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // districtLbl
            // 
            this.districtLbl.AutoSize = true;
            this.districtLbl.Font = new System.Drawing.Font("Century Gothic", 14.25F);
            this.districtLbl.Location = new System.Drawing.Point(420, 117);
            this.districtLbl.Name = "districtLbl";
            this.districtLbl.Size = new System.Drawing.Size(74, 22);
            this.districtLbl.TabIndex = 49;
            this.districtLbl.Text = "District:";
            // 
            // txtDistrict
            // 
            this.txtDistrict.Font = new System.Drawing.Font("Century Gothic", 14.25F);
            this.txtDistrict.Location = new System.Drawing.Point(500, 114);
            this.txtDistrict.Name = "txtDistrict";
            this.txtDistrict.Size = new System.Drawing.Size(232, 31);
            this.txtDistrict.TabIndex = 48;
            this.txtDistrict.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.districtTxtBx_KeyPress);
            // 
            // txtCity
            // 
            this.txtCity.Font = new System.Drawing.Font("Century Gothic", 14.25F);
            this.txtCity.Location = new System.Drawing.Point(146, 114);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(213, 31);
            this.txtCity.TabIndex = 47;
            this.txtCity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cityTxtBx_KeyPress);
            // 
            // btnListHotel
            // 
            this.btnListHotel.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnListHotel.Font = new System.Drawing.Font("Century Gothic", 14.25F);
            this.btnListHotel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnListHotel.Location = new System.Drawing.Point(87, 183);
            this.btnListHotel.Name = "btnListHotel";
            this.btnListHotel.Size = new System.Drawing.Size(672, 62);
            this.btnListHotel.TabIndex = 46;
            this.btnListHotel.Text = "List by Number of Stars";
            this.btnListHotel.UseVisualStyleBackColor = false;
            this.btnListHotel.Click += new System.EventHandler(this.btnListHotel_Click);
            // 
            // listViewHotel
            // 
            this.listViewHotel.HideSelection = false;
            this.listViewHotel.Location = new System.Drawing.Point(34, 269);
            this.listViewHotel.Name = "listViewHotel";
            this.listViewHotel.Size = new System.Drawing.Size(770, 330);
            this.listViewHotel.TabIndex = 45;
            this.listViewHotel.UseCompatibleStateImageBehavior = false;
            // 
            // CityNameLbl
            // 
            this.CityNameLbl.AutoSize = true;
            this.CityNameLbl.Font = new System.Drawing.Font("Century Gothic", 14.25F);
            this.CityNameLbl.Location = new System.Drawing.Point(89, 117);
            this.CityNameLbl.Name = "CityNameLbl";
            this.CityNameLbl.Size = new System.Drawing.Size(51, 22);
            this.CityNameLbl.TabIndex = 44;
            this.CityNameLbl.Text = "City:";
            // 
            // numberStarsSelectedLbl
            // 
            this.numberStarsSelectedLbl.AutoSize = true;
            this.numberStarsSelectedLbl.Font = new System.Drawing.Font("Century Gothic", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numberStarsSelectedLbl.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.numberStarsSelectedLbl.Location = new System.Drawing.Point(41, 9);
            this.numberStarsSelectedLbl.Name = "numberStarsSelectedLbl";
            this.numberStarsSelectedLbl.Size = new System.Drawing.Size(738, 41);
            this.numberStarsSelectedLbl.TabIndex = 43;
            this.numberStarsSelectedLbl.Text = "List by Number Stars Selected City - District:";
            // 
            // frmNumberStarsSelectedCityDistrict
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(839, 641);
            this.Controls.Add(this.districtLbl);
            this.Controls.Add(this.txtDistrict);
            this.Controls.Add(this.txtCity);
            this.Controls.Add(this.btnListHotel);
            this.Controls.Add(this.listViewHotel);
            this.Controls.Add(this.CityNameLbl);
            this.Controls.Add(this.numberStarsSelectedLbl);
            this.Location = new System.Drawing.Point(294, 54);
            this.Name = "frmNumberStarsSelectedCityDistrict";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Number Stars Selected City - District";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label districtLbl;
        private System.Windows.Forms.TextBox txtDistrict;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.Button btnListHotel;
        private System.Windows.Forms.ListView listViewHotel;
        private System.Windows.Forms.Label CityNameLbl;
        private System.Windows.Forms.Label numberStarsSelectedLbl;
    }
}