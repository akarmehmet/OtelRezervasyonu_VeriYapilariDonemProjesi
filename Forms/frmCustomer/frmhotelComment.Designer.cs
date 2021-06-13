
namespace OtelRezervasyonu_VeriYapilariDonemProjesi.Forms.frmCustomer
{
    partial class frmhotelComment
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
            this.commentLbl = new System.Windows.Forms.Label();
            this.lblHotelName = new System.Windows.Forms.Label();
            this.txtHotelName = new System.Windows.Forms.TextBox();
            this.phoneLbl = new System.Windows.Forms.Label();
            this.txtSurname = new System.Windows.Forms.TextBox();
            this.mailLbl = new System.Windows.Forms.Label();
            this.txtMail = new System.Windows.Forms.TextBox();
            this.txtComment = new System.Windows.Forms.RichTextBox();
            this.commLbl = new System.Windows.Forms.Label();
            this.hotelScore = new System.Windows.Forms.Label();
            this.txtHotelScore = new System.Windows.Forms.TextBox();
            this.commentsBtn = new System.Windows.Forms.Button();
            this.comboBoxHotels = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // commentLbl
            // 
            this.commentLbl.AutoSize = true;
            this.commentLbl.Font = new System.Drawing.Font("Century Gothic", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.commentLbl.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.commentLbl.Location = new System.Drawing.Point(84, 37);
            this.commentLbl.Name = "commentLbl";
            this.commentLbl.Size = new System.Drawing.Size(196, 41);
            this.commentLbl.TabIndex = 26;
            this.commentLbl.Text = "Comment:";
            // 
            // lblHotelName
            // 
            this.lblHotelName.AutoSize = true;
            this.lblHotelName.Font = new System.Drawing.Font("Century Gothic", 14.25F);
            this.lblHotelName.Location = new System.Drawing.Point(12, 100);
            this.lblHotelName.Name = "lblHotelName";
            this.lblHotelName.Size = new System.Drawing.Size(125, 22);
            this.lblHotelName.TabIndex = 28;
            this.lblHotelName.Text = "Hotels Name";
            // 
            // txtHotelName
            // 
            this.txtHotelName.Font = new System.Drawing.Font("Century Gothic", 14.25F);
            this.txtHotelName.Location = new System.Drawing.Point(234, 141);
            this.txtHotelName.Name = "txtHotelName";
            this.txtHotelName.Size = new System.Drawing.Size(186, 31);
            this.txtHotelName.TabIndex = 27;
            this.txtHotelName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtHotelName_KeyPress);
            // 
            // phoneLbl
            // 
            this.phoneLbl.AutoSize = true;
            this.phoneLbl.Font = new System.Drawing.Font("Century Gothic", 14.25F);
            this.phoneLbl.Location = new System.Drawing.Point(495, 141);
            this.phoneLbl.Name = "phoneLbl";
            this.phoneLbl.Size = new System.Drawing.Size(96, 44);
            this.phoneLbl.TabIndex = 30;
            this.phoneLbl.Text = "  Name\r\nSurname:";
            // 
            // txtSurname
            // 
            this.txtSurname.Font = new System.Drawing.Font("Century Gothic", 14.25F);
            this.txtSurname.Location = new System.Drawing.Point(641, 141);
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.Size = new System.Drawing.Size(186, 31);
            this.txtSurname.TabIndex = 29;
            this.txtSurname.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSurname_KeyPress);
            // 
            // mailLbl
            // 
            this.mailLbl.AutoSize = true;
            this.mailLbl.Font = new System.Drawing.Font("Century Gothic", 14.25F);
            this.mailLbl.Location = new System.Drawing.Point(12, 228);
            this.mailLbl.Name = "mailLbl";
            this.mailLbl.Size = new System.Drawing.Size(51, 22);
            this.mailLbl.TabIndex = 32;
            this.mailLbl.Text = "Mail:";
            // 
            // txtMail
            // 
            this.txtMail.Font = new System.Drawing.Font("Century Gothic", 14.25F);
            this.txtMail.Location = new System.Drawing.Point(200, 225);
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(186, 31);
            this.txtMail.TabIndex = 31;
            this.txtMail.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMail_KeyPress);
            // 
            // txtComment
            // 
            this.txtComment.Font = new System.Drawing.Font("Century Gothic", 14.25F);
            this.txtComment.Location = new System.Drawing.Point(200, 317);
            this.txtComment.Name = "txtComment";
            this.txtComment.Size = new System.Drawing.Size(522, 155);
            this.txtComment.TabIndex = 34;
            this.txtComment.Text = "";
            // 
            // commLbl
            // 
            this.commLbl.AutoSize = true;
            this.commLbl.Font = new System.Drawing.Font("Century Gothic", 14.25F);
            this.commLbl.Location = new System.Drawing.Point(46, 388);
            this.commLbl.Name = "commLbl";
            this.commLbl.Size = new System.Drawing.Size(107, 22);
            this.commLbl.TabIndex = 33;
            this.commLbl.Text = "Comment:";
            // 
            // hotelScore
            // 
            this.hotelScore.AutoSize = true;
            this.hotelScore.Font = new System.Drawing.Font("Century Gothic", 14.25F);
            this.hotelScore.Location = new System.Drawing.Point(495, 234);
            this.hotelScore.Name = "hotelScore";
            this.hotelScore.Size = new System.Drawing.Size(118, 22);
            this.hotelScore.TabIndex = 38;
            this.hotelScore.Text = "Hotel Score:";
            // 
            // txtHotelScore
            // 
            this.txtHotelScore.Font = new System.Drawing.Font("Century Gothic", 14.25F);
            this.txtHotelScore.Location = new System.Drawing.Point(641, 228);
            this.txtHotelScore.Name = "txtHotelScore";
            this.txtHotelScore.Size = new System.Drawing.Size(186, 31);
            this.txtHotelScore.TabIndex = 37;
            this.txtHotelScore.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtHotelScore_KeyPress);
            // 
            // commentsBtn
            // 
            this.commentsBtn.BackColor = System.Drawing.SystemColors.HotTrack;
            this.commentsBtn.Font = new System.Drawing.Font("Century Gothic", 14.25F);
            this.commentsBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.commentsBtn.Location = new System.Drawing.Point(91, 521);
            this.commentsBtn.Name = "commentsBtn";
            this.commentsBtn.Size = new System.Drawing.Size(672, 62);
            this.commentsBtn.TabIndex = 47;
            this.commentsBtn.Text = "Comment";
            this.commentsBtn.UseVisualStyleBackColor = false;
            this.commentsBtn.Click += new System.EventHandler(this.commentsBtn_Click);
            // 
            // comboBoxHotels
            // 
            this.comboBoxHotels.FormattingEnabled = true;
            this.comboBoxHotels.Location = new System.Drawing.Point(234, 100);
            this.comboBoxHotels.Name = "comboBoxHotels";
            this.comboBoxHotels.Size = new System.Drawing.Size(121, 21);
            this.comboBoxHotels.TabIndex = 48;
            this.comboBoxHotels.SelectedIndexChanged += new System.EventHandler(this.comboBoxHotels_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F);
            this.label1.Location = new System.Drawing.Point(12, 150);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(203, 22);
            this.label1.TabIndex = 28;
            this.label1.Text = "Selected Hotel Name";
            // 
            // frmhotelComment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(839, 641);
            this.Controls.Add(this.comboBoxHotels);
            this.Controls.Add(this.commentsBtn);
            this.Controls.Add(this.hotelScore);
            this.Controls.Add(this.txtHotelScore);
            this.Controls.Add(this.txtComment);
            this.Controls.Add(this.commLbl);
            this.Controls.Add(this.mailLbl);
            this.Controls.Add(this.txtMail);
            this.Controls.Add(this.phoneLbl);
            this.Controls.Add(this.txtSurname);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblHotelName);
            this.Controls.Add(this.txtHotelName);
            this.Controls.Add(this.commentLbl);
            this.Location = new System.Drawing.Point(294, 54);
            this.Name = "frmhotelComment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "hotelComment";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label commentLbl;
        private System.Windows.Forms.Label lblHotelName;
        private System.Windows.Forms.TextBox txtHotelName;
        private System.Windows.Forms.Label phoneLbl;
        private System.Windows.Forms.TextBox txtSurname;
        private System.Windows.Forms.Label mailLbl;
        private System.Windows.Forms.TextBox txtMail;
        private System.Windows.Forms.RichTextBox txtComment;
        private System.Windows.Forms.Label commLbl;
        private System.Windows.Forms.Label hotelScore;
        private System.Windows.Forms.TextBox txtHotelScore;
        private System.Windows.Forms.Button commentsBtn;
        private System.Windows.Forms.ComboBox comboBoxHotels;
        private System.Windows.Forms.Label label1;
    }
}