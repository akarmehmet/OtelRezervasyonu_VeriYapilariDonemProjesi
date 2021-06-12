
namespace OtelRezervasyonu_VeriYapilariDonemProjesi.Forms.frmCustomer
{
    partial class frmPersonnelUpdateDelete
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtHotelName = new System.Windows.Forms.TextBox();
            this.lblHotelName = new System.Windows.Forms.Label();
            this.btnOtelPersoneli = new System.Windows.Forms.Button();
            this.listViewHotel = new System.Windows.Forms.ListView();
            this.createHotelBtn = new System.Windows.Forms.Button();
            this.hotelNameTxtBx = new System.Windows.Forms.TextBox();
            this.nameLbl = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.phoneLbl = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.addressLbl = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.mailLbl = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panelPersonel = new System.Windows.Forms.Panel();
            this.panelPersonel.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(179, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(447, 41);
            this.label1.TabIndex = 53;
            this.label1.Text = "Update / Delete Personel:";
            // 
            // txtHotelName
            // 
            this.txtHotelName.Font = new System.Drawing.Font("Century Gothic", 14.25F);
            this.txtHotelName.Location = new System.Drawing.Point(231, 76);
            this.txtHotelName.Name = "txtHotelName";
            this.txtHotelName.Size = new System.Drawing.Size(186, 31);
            this.txtHotelName.TabIndex = 54;
            this.txtHotelName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.hotelNameTxtBx_KeyPress);
            // 
            // lblHotelName
            // 
            this.lblHotelName.AutoSize = true;
            this.lblHotelName.Font = new System.Drawing.Font("Century Gothic", 14.25F);
            this.lblHotelName.Location = new System.Drawing.Point(65, 79);
            this.lblHotelName.Name = "lblHotelName";
            this.lblHotelName.Size = new System.Drawing.Size(118, 22);
            this.lblHotelName.TabIndex = 55;
            this.lblHotelName.Text = "Hotel Name";
            // 
            // btnOtelPersoneli
            // 
            this.btnOtelPersoneli.Location = new System.Drawing.Point(584, 61);
            this.btnOtelPersoneli.Name = "btnOtelPersoneli";
            this.btnOtelPersoneli.Size = new System.Drawing.Size(201, 51);
            this.btnOtelPersoneli.TabIndex = 68;
            this.btnOtelPersoneli.Text = "Otel Personelini Getir";
            this.btnOtelPersoneli.UseVisualStyleBackColor = true;
            this.btnOtelPersoneli.Click += new System.EventHandler(this.btnOtelPersoneli_Click);
            // 
            // listViewHotel
            // 
            this.listViewHotel.HideSelection = false;
            this.listViewHotel.Location = new System.Drawing.Point(28, 8);
            this.listViewHotel.Name = "listViewHotel";
            this.listViewHotel.Size = new System.Drawing.Size(763, 209);
            this.listViewHotel.TabIndex = 68;
            this.listViewHotel.UseCompatibleStateImageBehavior = false;
            // 
            // createHotelBtn
            // 
            this.createHotelBtn.BackColor = System.Drawing.SystemColors.HotTrack;
            this.createHotelBtn.Font = new System.Drawing.Font("Century Gothic", 14.25F);
            this.createHotelBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.createHotelBtn.Location = new System.Drawing.Point(121, 562);
            this.createHotelBtn.Name = "createHotelBtn";
            this.createHotelBtn.Size = new System.Drawing.Size(567, 44);
            this.createHotelBtn.TabIndex = 69;
            this.createHotelBtn.Text = "Update / Delete Hotel";
            this.createHotelBtn.UseVisualStyleBackColor = false;
            // 
            // hotelNameTxtBx
            // 
            this.hotelNameTxtBx.Font = new System.Drawing.Font("Century Gothic", 14.25F);
            this.hotelNameTxtBx.Location = new System.Drawing.Point(121, 288);
            this.hotelNameTxtBx.Name = "hotelNameTxtBx";
            this.hotelNameTxtBx.Size = new System.Drawing.Size(186, 31);
            this.hotelNameTxtBx.TabIndex = 70;
            // 
            // nameLbl
            // 
            this.nameLbl.AutoSize = true;
            this.nameLbl.Font = new System.Drawing.Font("Century Gothic", 14.25F);
            this.nameLbl.Location = new System.Drawing.Point(51, 291);
            this.nameLbl.Name = "nameLbl";
            this.nameLbl.Size = new System.Drawing.Size(69, 22);
            this.nameLbl.TabIndex = 71;
            this.nameLbl.Text = "TC No:";
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Century Gothic", 14.25F);
            this.textBox2.Location = new System.Drawing.Point(121, 498);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(186, 31);
            this.textBox2.TabIndex = 72;
            // 
            // phoneLbl
            // 
            this.phoneLbl.AutoSize = true;
            this.phoneLbl.Font = new System.Drawing.Font("Century Gothic", 14.25F);
            this.phoneLbl.Location = new System.Drawing.Point(24, 485);
            this.phoneLbl.Name = "phoneLbl";
            this.phoneLbl.Size = new System.Drawing.Size(96, 44);
            this.phoneLbl.TabIndex = 73;
            this.phoneLbl.Text = "  Name\r\nSurname:";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Century Gothic", 14.25F);
            this.textBox1.Location = new System.Drawing.Point(121, 356);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(186, 31);
            this.textBox1.TabIndex = 74;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 14.25F);
            this.label4.Location = new System.Drawing.Point(46, 359);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 22);
            this.label4.TabIndex = 75;
            this.label4.Text = "Phone:";
            // 
            // addressLbl
            // 
            this.addressLbl.AutoSize = true;
            this.addressLbl.Font = new System.Drawing.Font("Century Gothic", 14.25F);
            this.addressLbl.Location = new System.Drawing.Point(408, 426);
            this.addressLbl.Name = "addressLbl";
            this.addressLbl.Size = new System.Drawing.Size(88, 22);
            this.addressLbl.TabIndex = 76;
            this.addressLbl.Text = "Address:";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Font = new System.Drawing.Font("Century Gothic", 14.25F);
            this.richTextBox1.Location = new System.Drawing.Point(502, 423);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(186, 116);
            this.richTextBox1.TabIndex = 77;
            this.richTextBox1.Text = "";
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("Century Gothic", 14.25F);
            this.textBox3.Location = new System.Drawing.Point(121, 426);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(186, 31);
            this.textBox3.TabIndex = 78;
            // 
            // mailLbl
            // 
            this.mailLbl.AutoSize = true;
            this.mailLbl.Font = new System.Drawing.Font("Century Gothic", 14.25F);
            this.mailLbl.Location = new System.Drawing.Point(69, 429);
            this.mailLbl.Name = "mailLbl";
            this.mailLbl.Size = new System.Drawing.Size(51, 22);
            this.mailLbl.TabIndex = 79;
            this.mailLbl.Text = "Mail:";
            // 
            // textBox4
            // 
            this.textBox4.Font = new System.Drawing.Font("Century Gothic", 14.25F);
            this.textBox4.Location = new System.Drawing.Point(502, 282);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(186, 31);
            this.textBox4.TabIndex = 80;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 14.25F);
            this.label2.Location = new System.Drawing.Point(368, 288);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 22);
            this.label2.TabIndex = 81;
            this.label2.Text = "Department:";
            // 
            // textBox5
            // 
            this.textBox5.Font = new System.Drawing.Font("Century Gothic", 14.25F);
            this.textBox5.Location = new System.Drawing.Point(502, 356);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(186, 31);
            this.textBox5.TabIndex = 82;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 14.25F);
            this.label3.Location = new System.Drawing.Point(414, 359);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 22);
            this.label3.TabIndex = 83;
            this.label3.Text = "Position:";
            // 
            // panelPersonel
            // 
            this.panelPersonel.Controls.Add(this.label3);
            this.panelPersonel.Controls.Add(this.textBox5);
            this.panelPersonel.Controls.Add(this.label2);
            this.panelPersonel.Controls.Add(this.textBox4);
            this.panelPersonel.Controls.Add(this.mailLbl);
            this.panelPersonel.Controls.Add(this.textBox3);
            this.panelPersonel.Controls.Add(this.richTextBox1);
            this.panelPersonel.Controls.Add(this.addressLbl);
            this.panelPersonel.Controls.Add(this.label4);
            this.panelPersonel.Controls.Add(this.textBox1);
            this.panelPersonel.Controls.Add(this.phoneLbl);
            this.panelPersonel.Controls.Add(this.textBox2);
            this.panelPersonel.Controls.Add(this.nameLbl);
            this.panelPersonel.Controls.Add(this.hotelNameTxtBx);
            this.panelPersonel.Controls.Add(this.createHotelBtn);
            this.panelPersonel.Controls.Add(this.listViewHotel);
            this.panelPersonel.Enabled = false;
            this.panelPersonel.Location = new System.Drawing.Point(12, 174);
            this.panelPersonel.Name = "panelPersonel";
            this.panelPersonel.Size = new System.Drawing.Size(815, 614);
            this.panelPersonel.TabIndex = 69;
            this.panelPersonel.Visible = false;
            // 
            // frmPersonnelUpdateDelete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(839, 800);
            this.Controls.Add(this.panelPersonel);
            this.Controls.Add(this.btnOtelPersoneli);
            this.Controls.Add(this.lblHotelName);
            this.Controls.Add(this.txtHotelName);
            this.Controls.Add(this.label1);
            this.Location = new System.Drawing.Point(294, 54);
            this.Name = "frmPersonnelUpdateDelete";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Personnel Update Delete";
            this.panelPersonel.ResumeLayout(false);
            this.panelPersonel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtHotelName;
        private System.Windows.Forms.Label lblHotelName;
        private System.Windows.Forms.Button btnOtelPersoneli;
        private System.Windows.Forms.ListView listViewHotel;
        private System.Windows.Forms.Button createHotelBtn;
        private System.Windows.Forms.TextBox hotelNameTxtBx;
        private System.Windows.Forms.Label nameLbl;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label phoneLbl;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label addressLbl;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label mailLbl;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panelPersonel;
    }
}