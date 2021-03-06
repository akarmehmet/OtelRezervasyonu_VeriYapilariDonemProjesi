
namespace OtelRezervasyonu_VeriYapilariDonemProjesi.Forms.frmCustomer
{
    partial class frmRezNameSurnameAZ
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
            this.txtReservationNo = new System.Windows.Forms.TextBox();
            this.rezervationsLbl = new System.Windows.Forms.Label();
            this.AZNameSurnameLbl = new System.Windows.Forms.Label();
            this.btnFindReservation = new System.Windows.Forms.Button();
            this.txtCustomers = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // txtReservationNo
            // 
            this.txtReservationNo.Font = new System.Drawing.Font("Century Gothic", 14.25F);
            this.txtReservationNo.Location = new System.Drawing.Point(211, 130);
            this.txtReservationNo.Name = "txtReservationNo";
            this.txtReservationNo.Size = new System.Drawing.Size(186, 31);
            this.txtReservationNo.TabIndex = 108;
            // 
            // rezervationsLbl
            // 
            this.rezervationsLbl.AutoSize = true;
            this.rezervationsLbl.Font = new System.Drawing.Font("Century Gothic", 14.25F);
            this.rezervationsLbl.Location = new System.Drawing.Point(85, 118);
            this.rezervationsLbl.Name = "rezervationsLbl";
            this.rezervationsLbl.Size = new System.Drawing.Size(125, 44);
            this.rezervationsLbl.TabIndex = 109;
            this.rezervationsLbl.Text = "Rezervation \r\n      No:";
            // 
            // AZNameSurnameLbl
            // 
            this.AZNameSurnameLbl.AutoSize = true;
            this.AZNameSurnameLbl.Font = new System.Drawing.Font("Century Gothic", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AZNameSurnameLbl.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.AZNameSurnameLbl.Location = new System.Drawing.Point(72, 38);
            this.AZNameSurnameLbl.Name = "AZNameSurnameLbl";
            this.AZNameSurnameLbl.Size = new System.Drawing.Size(698, 41);
            this.AZNameSurnameLbl.TabIndex = 110;
            this.AZNameSurnameLbl.Text = "AZ of Reservation Names and Surnames:";
            // 
            // btnFindReservation
            // 
            this.btnFindReservation.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnFindReservation.Font = new System.Drawing.Font("Century Gothic", 14.25F);
            this.btnFindReservation.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnFindReservation.Location = new System.Drawing.Point(473, 122);
            this.btnFindReservation.Name = "btnFindReservation";
            this.btnFindReservation.Size = new System.Drawing.Size(232, 44);
            this.btnFindReservation.TabIndex = 111;
            this.btnFindReservation.Text = "List";
            this.btnFindReservation.UseVisualStyleBackColor = false;
            this.btnFindReservation.Click += new System.EventHandler(this.btnFindReservation_Click);
            // 
            // txtCustomers
            // 
            this.txtCustomers.Location = new System.Drawing.Point(25, 270);
            this.txtCustomers.Name = "txtCustomers";
            this.txtCustomers.Size = new System.Drawing.Size(785, 359);
            this.txtCustomers.TabIndex = 113;
            this.txtCustomers.Text = "";
            // 
            // frmRezNameSurnameAZ
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(839, 641);
            this.Controls.Add(this.txtCustomers);
            this.Controls.Add(this.btnFindReservation);
            this.Controls.Add(this.AZNameSurnameLbl);
            this.Controls.Add(this.txtReservationNo);
            this.Controls.Add(this.rezervationsLbl);
            this.Location = new System.Drawing.Point(294, 54);
            this.Name = "frmRezNameSurnameAZ";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Rez Name Surname AZ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtReservationNo;
        private System.Windows.Forms.Label rezervationsLbl;
        private System.Windows.Forms.Label AZNameSurnameLbl;
        private System.Windows.Forms.Button btnFindReservation;
        private System.Windows.Forms.RichTextBox txtCustomers;
    }
}