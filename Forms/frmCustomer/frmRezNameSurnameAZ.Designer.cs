
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
            this.rezervationTxtBx = new System.Windows.Forms.TextBox();
            this.rezervationsLbl = new System.Windows.Forms.Label();
            this.AZNameSurnameLbl = new System.Windows.Forms.Label();
            this.findPersonel = new System.Windows.Forms.Button();
            this.listViewPersonel = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // rezervationTxtBx
            // 
            this.rezervationTxtBx.Font = new System.Drawing.Font("Century Gothic", 14.25F);
            this.rezervationTxtBx.Location = new System.Drawing.Point(211, 130);
            this.rezervationTxtBx.Name = "rezervationTxtBx";
            this.rezervationTxtBx.Size = new System.Drawing.Size(186, 31);
            this.rezervationTxtBx.TabIndex = 108;
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
            // findPersonel
            // 
            this.findPersonel.BackColor = System.Drawing.SystemColors.HotTrack;
            this.findPersonel.Font = new System.Drawing.Font("Century Gothic", 14.25F);
            this.findPersonel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.findPersonel.Location = new System.Drawing.Point(473, 122);
            this.findPersonel.Name = "findPersonel";
            this.findPersonel.Size = new System.Drawing.Size(232, 44);
            this.findPersonel.TabIndex = 111;
            this.findPersonel.Text = "List";
            this.findPersonel.UseVisualStyleBackColor = false;
            // 
            // listViewPersonel
            // 
            this.listViewPersonel.HideSelection = false;
            this.listViewPersonel.Location = new System.Drawing.Point(47, 209);
            this.listViewPersonel.Name = "listViewPersonel";
            this.listViewPersonel.Size = new System.Drawing.Size(763, 404);
            this.listViewPersonel.TabIndex = 112;
            this.listViewPersonel.UseCompatibleStateImageBehavior = false;
            // 
            // frmRezNameSurnameAZ
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(839, 641);
            this.Controls.Add(this.listViewPersonel);
            this.Controls.Add(this.findPersonel);
            this.Controls.Add(this.AZNameSurnameLbl);
            this.Controls.Add(this.rezervationTxtBx);
            this.Controls.Add(this.rezervationsLbl);
            this.Location = new System.Drawing.Point(294, 54);
            this.Name = "frmRezNameSurnameAZ";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Rez Name Surname AZ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox rezervationTxtBx;
        private System.Windows.Forms.Label rezervationsLbl;
        private System.Windows.Forms.Label AZNameSurnameLbl;
        private System.Windows.Forms.Button findPersonel;
        private System.Windows.Forms.ListView listViewPersonel;
    }
}