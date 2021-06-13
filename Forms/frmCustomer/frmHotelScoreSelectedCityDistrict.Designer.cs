
namespace OtelRezervasyonu_VeriYapilariDonemProjesi.Forms.frmCustomer
{
    partial class frmHotelScoreSelectedCityDistrict
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
            this.btnhotelScoreSelected = new System.Windows.Forms.Button();
            this.listViewhotelScoreSelected = new System.Windows.Forms.ListView();
            this.CityNameLbl = new System.Windows.Forms.Label();
            this.hotelScoreSelectedLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // districtLbl
            // 
            this.districtLbl.AutoSize = true;
            this.districtLbl.Font = new System.Drawing.Font("Century Gothic", 14.25F);
            this.districtLbl.Location = new System.Drawing.Point(420, 133);
            this.districtLbl.Name = "districtLbl";
            this.districtLbl.Size = new System.Drawing.Size(74, 22);
            this.districtLbl.TabIndex = 56;
            this.districtLbl.Text = "District:";
            // 
            // txtDistrict
            // 
            this.txtDistrict.Font = new System.Drawing.Font("Century Gothic", 14.25F);
            this.txtDistrict.Location = new System.Drawing.Point(500, 130);
            this.txtDistrict.Name = "txtDistrict";
            this.txtDistrict.Size = new System.Drawing.Size(232, 31);
            this.txtDistrict.TabIndex = 55;
            // 
            // txtCity
            // 
            this.txtCity.Font = new System.Drawing.Font("Century Gothic", 14.25F);
            this.txtCity.Location = new System.Drawing.Point(146, 130);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(213, 31);
            this.txtCity.TabIndex = 54;
            // 
            // btnhotelScoreSelected
            // 
            this.btnhotelScoreSelected.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnhotelScoreSelected.Font = new System.Drawing.Font("Century Gothic", 14.25F);
            this.btnhotelScoreSelected.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnhotelScoreSelected.Location = new System.Drawing.Point(87, 199);
            this.btnhotelScoreSelected.Name = "btnhotelScoreSelected";
            this.btnhotelScoreSelected.Size = new System.Drawing.Size(672, 62);
            this.btnhotelScoreSelected.TabIndex = 53;
            this.btnhotelScoreSelected.Text = "List by Hotel Score";
            this.btnhotelScoreSelected.UseVisualStyleBackColor = false;
            // 
            // listViewhotelScoreSelected
            // 
            this.listViewhotelScoreSelected.HideSelection = false;
            this.listViewhotelScoreSelected.Location = new System.Drawing.Point(34, 285);
            this.listViewhotelScoreSelected.Name = "listViewhotelScoreSelected";
            this.listViewhotelScoreSelected.Size = new System.Drawing.Size(770, 330);
            this.listViewhotelScoreSelected.TabIndex = 52;
            this.listViewhotelScoreSelected.UseCompatibleStateImageBehavior = false;
            // 
            // CityNameLbl
            // 
            this.CityNameLbl.AutoSize = true;
            this.CityNameLbl.Font = new System.Drawing.Font("Century Gothic", 14.25F);
            this.CityNameLbl.Location = new System.Drawing.Point(89, 133);
            this.CityNameLbl.Name = "CityNameLbl";
            this.CityNameLbl.Size = new System.Drawing.Size(51, 22);
            this.CityNameLbl.TabIndex = 51;
            this.CityNameLbl.Text = "City:";
            // 
            // hotelScoreSelectedLbl
            // 
            this.hotelScoreSelectedLbl.AutoSize = true;
            this.hotelScoreSelectedLbl.Font = new System.Drawing.Font("Century Gothic", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hotelScoreSelectedLbl.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.hotelScoreSelectedLbl.Location = new System.Drawing.Point(36, 21);
            this.hotelScoreSelectedLbl.Name = "hotelScoreSelectedLbl";
            this.hotelScoreSelectedLbl.Size = new System.Drawing.Size(696, 82);
            this.hotelScoreSelectedLbl.TabIndex = 50;
            this.hotelScoreSelectedLbl.Text = "List by Hotel Score Selected City - District\r\n (Hotel Score From Highest to Lowes" +
    "t):";
            // 
            // frmHotelScoreSelectedCityDistrict
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(839, 641);
            this.Controls.Add(this.districtLbl);
            this.Controls.Add(this.txtDistrict);
            this.Controls.Add(this.txtCity);
            this.Controls.Add(this.btnhotelScoreSelected);
            this.Controls.Add(this.listViewhotelScoreSelected);
            this.Controls.Add(this.CityNameLbl);
            this.Controls.Add(this.hotelScoreSelectedLbl);
            this.Location = new System.Drawing.Point(294, 54);
            this.Name = "frmHotelScoreSelectedCityDistrict";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Hotel Score Selected City - District";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label districtLbl;
        private System.Windows.Forms.TextBox txtDistrict;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.Button btnhotelScoreSelected;
        private System.Windows.Forms.ListView listViewhotelScoreSelected;
        private System.Windows.Forms.Label CityNameLbl;
        private System.Windows.Forms.Label hotelScoreSelectedLbl;
    }
}