
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
            this.listViewHotel = new System.Windows.Forms.ListView();
            this.listbyHotelName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listViewHotel
            // 
            this.listViewHotel.HideSelection = false;
            this.listViewHotel.Location = new System.Drawing.Point(34, 83);
            this.listViewHotel.Name = "listViewHotel";
            this.listViewHotel.Size = new System.Drawing.Size(770, 525);
            this.listViewHotel.TabIndex = 34;
            this.listViewHotel.UseCompatibleStateImageBehavior = false;
            // 
            // listbyHotelName
            // 
            this.listbyHotelName.AutoSize = true;
            this.listbyHotelName.Font = new System.Drawing.Font("Century Gothic", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listbyHotelName.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.listbyHotelName.Location = new System.Drawing.Point(254, 24);
            this.listbyHotelName.Name = "listbyHotelName";
            this.listbyHotelName.Size = new System.Drawing.Size(339, 41);
            this.listbyHotelName.TabIndex = 31;
            this.listbyHotelName.Text = "List by Hotel Name:";
            // 
            // frmListbyHotelName
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(839, 641);
            this.Controls.Add(this.listViewHotel);
            this.Controls.Add(this.listbyHotelName);
            this.Location = new System.Drawing.Point(294, 54);
            this.Name = "frmListbyHotelName";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "List by Hotel Name";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListView listViewHotel;
        private System.Windows.Forms.Label listbyHotelName;
    }
}