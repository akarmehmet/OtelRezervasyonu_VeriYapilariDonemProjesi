
namespace OtelRezervasyonu_VeriYapilariDonemProjesi.Forms.frmCustomer
{
    partial class frmListbyHotelName
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
            this.listbyHotelNameBtn = new System.Windows.Forms.Button();
            this.HotelsLstVw = new System.Windows.Forms.ListView();
            this.HotelNameLbl = new System.Windows.Forms.Label();
            this.listbyHotelName = new System.Windows.Forms.Label();
            this.hotelNameTxtBx = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // listbyHotelNameBtn
            // 
            this.listbyHotelNameBtn.BackColor = System.Drawing.SystemColors.HotTrack;
            this.listbyHotelNameBtn.Font = new System.Drawing.Font("Century Gothic", 14.25F);
            this.listbyHotelNameBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.listbyHotelNameBtn.Location = new System.Drawing.Point(142, 185);
            this.listbyHotelNameBtn.Name = "listbyHotelNameBtn";
            this.listbyHotelNameBtn.Size = new System.Drawing.Size(567, 62);
            this.listbyHotelNameBtn.TabIndex = 35;
            this.listbyHotelNameBtn.Text = "List by Hotel Name";
            this.listbyHotelNameBtn.UseVisualStyleBackColor = false;
            // 
            // HotelsLstVw
            // 
            this.HotelsLstVw.HideSelection = false;
            this.HotelsLstVw.Location = new System.Drawing.Point(34, 278);
            this.HotelsLstVw.Name = "HotelsLstVw";
            this.HotelsLstVw.Size = new System.Drawing.Size(770, 330);
            this.HotelsLstVw.TabIndex = 34;
            this.HotelsLstVw.UseCompatibleStateImageBehavior = false;
            // 
            // HotelNameLbl
            // 
            this.HotelNameLbl.AutoSize = true;
            this.HotelNameLbl.Font = new System.Drawing.Font("Century Gothic", 14.25F);
            this.HotelNameLbl.Location = new System.Drawing.Point(229, 116);
            this.HotelNameLbl.Name = "HotelNameLbl";
            this.HotelNameLbl.Size = new System.Drawing.Size(123, 22);
            this.HotelNameLbl.TabIndex = 32;
            this.HotelNameLbl.Text = "Hotel Name:";
            // 
            // listbyHotelName
            // 
            this.listbyHotelName.AutoSize = true;
            this.listbyHotelName.Font = new System.Drawing.Font("Century Gothic", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listbyHotelName.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.listbyHotelName.Location = new System.Drawing.Point(69, 32);
            this.listbyHotelName.Name = "listbyHotelName";
            this.listbyHotelName.Size = new System.Drawing.Size(339, 41);
            this.listbyHotelName.TabIndex = 31;
            this.listbyHotelName.Text = "List by Hotel Name:";
            // 
            // hotelNameTxtBx
            // 
            this.hotelNameTxtBx.Font = new System.Drawing.Font("Century Gothic", 14.25F);
            this.hotelNameTxtBx.Location = new System.Drawing.Point(358, 113);
            this.hotelNameTxtBx.Name = "hotelNameTxtBx";
            this.hotelNameTxtBx.Size = new System.Drawing.Size(265, 31);
            this.hotelNameTxtBx.TabIndex = 36;
            this.hotelNameTxtBx.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.hotelNameTxtBx_KeyPress);
            // 
            // frmListbyHotelName
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(839, 641);
            this.Controls.Add(this.hotelNameTxtBx);
            this.Controls.Add(this.listbyHotelNameBtn);
            this.Controls.Add(this.HotelsLstVw);
            this.Controls.Add(this.HotelNameLbl);
            this.Controls.Add(this.listbyHotelName);
            this.Location = new System.Drawing.Point(294, 54);
            this.Name = "frmListbyHotelName";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "List by Hotel Name";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button listbyHotelNameBtn;
        private System.Windows.Forms.ListView HotelsLstVw;
        private System.Windows.Forms.Label HotelNameLbl;
        private System.Windows.Forms.Label listbyHotelName;
        private System.Windows.Forms.TextBox hotelNameTxtBx;
    }
}