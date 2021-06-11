
namespace OtelRezervasyonu_VeriYapilariDonemProjesi.Forms
{
    partial class frmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            this.welcomeLabel = new System.Windows.Forms.Label();
            this.customer = new System.Windows.Forms.Button();
            this.Admin = new System.Windows.Forms.Button();
            this.loginHotelLogo = new System.Windows.Forms.PictureBox();
            this.exit = new System.Windows.Forms.PictureBox();
            this.loginTopMDIPanel = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.loginHotelLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.exit)).BeginInit();
            this.loginTopMDIPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // welcomeLabel
            // 
            this.welcomeLabel.AutoSize = true;
            this.welcomeLabel.BackColor = System.Drawing.SystemColors.HotTrack;
            this.welcomeLabel.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.welcomeLabel.ForeColor = System.Drawing.Color.White;
            this.welcomeLabel.Location = new System.Drawing.Point(38, 81);
            this.welcomeLabel.Name = "welcomeLabel";
            this.welcomeLabel.Size = new System.Drawing.Size(430, 60);
            this.welcomeLabel.TabIndex = 19;
            this.welcomeLabel.Text = "Welcome to the Hotel Reservation \r\nSystem";
            this.welcomeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // customer
            // 
            this.customer.BackColor = System.Drawing.SystemColors.HotTrack;
            this.customer.FlatAppearance.BorderSize = 0;
            this.customer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.customer.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.customer.ForeColor = System.Drawing.SystemColors.Info;
            this.customer.Location = new System.Drawing.Point(290, 381);
            this.customer.Name = "customer";
            this.customer.Size = new System.Drawing.Size(158, 78);
            this.customer.TabIndex = 18;
            this.customer.Text = "CUSTOMER";
            this.customer.UseVisualStyleBackColor = false;
            this.customer.Click += new System.EventHandler(this.customer_Click);
            // 
            // Admin
            // 
            this.Admin.BackColor = System.Drawing.SystemColors.HotTrack;
            this.Admin.FlatAppearance.BorderSize = 0;
            this.Admin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Admin.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Admin.ForeColor = System.Drawing.SystemColors.Info;
            this.Admin.Location = new System.Drawing.Point(61, 381);
            this.Admin.Name = "Admin";
            this.Admin.Size = new System.Drawing.Size(158, 78);
            this.Admin.TabIndex = 17;
            this.Admin.Text = "ADMIN";
            this.Admin.UseVisualStyleBackColor = false;
            this.Admin.Click += new System.EventHandler(this.Admin_Click);
            // 
            // loginHotelLogo
            // 
            this.loginHotelLogo.Image = ((System.Drawing.Image)(resources.GetObject("loginHotelLogo.Image")));
            this.loginHotelLogo.Location = new System.Drawing.Point(157, 167);
            this.loginHotelLogo.Name = "loginHotelLogo";
            this.loginHotelLogo.Size = new System.Drawing.Size(194, 179);
            this.loginHotelLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.loginHotelLogo.TabIndex = 15;
            this.loginHotelLogo.TabStop = false;
            // 
            // exit
            // 
            this.exit.Image = ((System.Drawing.Image)(resources.GetObject("exit.Image")));
            this.exit.Location = new System.Drawing.Point(455, 9);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(42, 33);
            this.exit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.exit.TabIndex = 0;
            this.exit.TabStop = false;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // loginTopMDIPanel
            // 
            this.loginTopMDIPanel.BackColor = System.Drawing.SystemColors.HotTrack;
            this.loginTopMDIPanel.Controls.Add(this.exit);
            this.loginTopMDIPanel.Location = new System.Drawing.Point(-9, 0);
            this.loginTopMDIPanel.Name = "loginTopMDIPanel";
            this.loginTopMDIPanel.Size = new System.Drawing.Size(518, 55);
            this.loginTopMDIPanel.TabIndex = 16;
            this.loginTopMDIPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.loginTopMDIPanel_MouseDown);
            this.loginTopMDIPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.loginTopMDIPanel_MouseMove);
            this.loginTopMDIPanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.loginTopMDIPanel_MouseUp);
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(510, 482);
            this.Controls.Add(this.welcomeLabel);
            this.Controls.Add(this.customer);
            this.Controls.Add(this.Admin);
            this.Controls.Add(this.loginHotelLogo);
            this.Controls.Add(this.loginTopMDIPanel);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmLogin";
            ((System.ComponentModel.ISupportInitialize)(this.loginHotelLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.exit)).EndInit();
            this.loginTopMDIPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label welcomeLabel;
        private System.Windows.Forms.Button customer;
        private System.Windows.Forms.Button Admin;
        private System.Windows.Forms.PictureBox loginHotelLogo;
        private System.Windows.Forms.PictureBox exit;
        private System.Windows.Forms.Panel loginTopMDIPanel;
    }
}