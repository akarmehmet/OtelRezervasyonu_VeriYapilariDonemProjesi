
namespace OtelRezervasyonu_VeriYapilariDonemProjesi.Forms.frmAdmin
{
    partial class frmListbyDepartment
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
            this.listbyDepartment = new System.Windows.Forms.Label();
            this.panelPersonel = new System.Windows.Forms.Panel();
            this.listbyDepartmentBtn = new System.Windows.Forms.Button();
            this.listViewPersonel = new System.Windows.Forms.ListView();
            this.comboboxDepartment = new System.Windows.Forms.ComboBox();
            this.lblDepartment = new System.Windows.Forms.Label();
            this.lblHotelName = new System.Windows.Forms.Label();
            this.txtHotelName = new System.Windows.Forms.TextBox();
            this.btnFindHotel = new System.Windows.Forms.Button();
            this.panelPersonel.SuspendLayout();
            this.SuspendLayout();
            // 
            // listbyDepartment
            // 
            this.listbyDepartment.AutoSize = true;
            this.listbyDepartment.Font = new System.Drawing.Font("Century Gothic", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listbyDepartment.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.listbyDepartment.Location = new System.Drawing.Point(94, 18);
            this.listbyDepartment.Name = "listbyDepartment";
            this.listbyDepartment.Size = new System.Drawing.Size(339, 41);
            this.listbyDepartment.TabIndex = 26;
            this.listbyDepartment.Text = "List by Department:";
            // 
            // panelPersonel
            // 
            this.panelPersonel.Controls.Add(this.listbyDepartmentBtn);
            this.panelPersonel.Controls.Add(this.listViewPersonel);
            this.panelPersonel.Controls.Add(this.comboboxDepartment);
            this.panelPersonel.Controls.Add(this.lblDepartment);
            this.panelPersonel.Location = new System.Drawing.Point(6, 143);
            this.panelPersonel.Name = "panelPersonel";
            this.panelPersonel.Size = new System.Drawing.Size(821, 497);
            this.panelPersonel.TabIndex = 31;
            this.panelPersonel.Visible = false;
            // 
            // listbyDepartmentBtn
            // 
            this.listbyDepartmentBtn.BackColor = System.Drawing.SystemColors.HotTrack;
            this.listbyDepartmentBtn.Font = new System.Drawing.Font("Century Gothic", 14.25F);
            this.listbyDepartmentBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.listbyDepartmentBtn.Location = new System.Drawing.Point(127, 91);
            this.listbyDepartmentBtn.Name = "listbyDepartmentBtn";
            this.listbyDepartmentBtn.Size = new System.Drawing.Size(567, 62);
            this.listbyDepartmentBtn.TabIndex = 34;
            this.listbyDepartmentBtn.Text = "List by Department";
            this.listbyDepartmentBtn.UseVisualStyleBackColor = false;
            this.listbyDepartmentBtn.Click += new System.EventHandler(this.listbyDepartmentBtn_Click);
            // 
            // listViewPersonel
            // 
            this.listViewPersonel.HideSelection = false;
            this.listViewPersonel.Location = new System.Drawing.Point(33, 164);
            this.listViewPersonel.Name = "listViewPersonel";
            this.listViewPersonel.Size = new System.Drawing.Size(770, 330);
            this.listViewPersonel.TabIndex = 33;
            this.listViewPersonel.UseCompatibleStateImageBehavior = false;
            // 
            // comboboxDepartment
            // 
            this.comboboxDepartment.Font = new System.Drawing.Font("Century Gothic", 14.25F);
            this.comboboxDepartment.FormattingEnabled = true;
            this.comboboxDepartment.Items.AddRange(new object[] {
            "FrontOffice",
            "FoodAndBeverage",
            "Housekeeping",
            "Marketing",
            "Accounting",
            "HumanResources",
            "Security",
            "Computing",
            "Staff",
            "TechnicalService"});
            this.comboboxDepartment.Location = new System.Drawing.Point(365, 30);
            this.comboboxDepartment.Name = "comboboxDepartment";
            this.comboboxDepartment.Size = new System.Drawing.Size(239, 30);
            this.comboboxDepartment.TabIndex = 32;
            // 
            // lblDepartment
            // 
            this.lblDepartment.AutoSize = true;
            this.lblDepartment.Font = new System.Drawing.Font("Century Gothic", 14.25F);
            this.lblDepartment.Location = new System.Drawing.Point(197, 29);
            this.lblDepartment.Name = "lblDepartment";
            this.lblDepartment.Size = new System.Drawing.Size(123, 22);
            this.lblDepartment.TabIndex = 31;
            this.lblDepartment.Text = "Department";
            // 
            // lblHotelName
            // 
            this.lblHotelName.AutoSize = true;
            this.lblHotelName.Font = new System.Drawing.Font("Century Gothic", 14.25F);
            this.lblHotelName.Location = new System.Drawing.Point(146, 81);
            this.lblHotelName.Name = "lblHotelName";
            this.lblHotelName.Size = new System.Drawing.Size(118, 22);
            this.lblHotelName.TabIndex = 32;
            this.lblHotelName.Text = "Hotel Name";
            // 
            // txtHotelName
            // 
            this.txtHotelName.Font = new System.Drawing.Font("Century Gothic", 14.25F);
            this.txtHotelName.Location = new System.Drawing.Point(270, 78);
            this.txtHotelName.Name = "txtHotelName";
            this.txtHotelName.Size = new System.Drawing.Size(163, 31);
            this.txtHotelName.TabIndex = 33;
            this.txtHotelName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtHotelName_KeyPress);
            // 
            // btnFindHotel
            // 
            this.btnFindHotel.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnFindHotel.Font = new System.Drawing.Font("Century Gothic", 14.25F);
            this.btnFindHotel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnFindHotel.Location = new System.Drawing.Point(515, 72);
            this.btnFindHotel.Name = "btnFindHotel";
            this.btnFindHotel.Size = new System.Drawing.Size(185, 40);
            this.btnFindHotel.TabIndex = 34;
            this.btnFindHotel.Text = "Find Hotel";
            this.btnFindHotel.UseVisualStyleBackColor = true;
            this.btnFindHotel.Click += new System.EventHandler(this.btnFindHotel_Click_1);
            // 
            // frmListbyDepartment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(839, 641);
            this.Controls.Add(this.btnFindHotel);
            this.Controls.Add(this.txtHotelName);
            this.Controls.Add(this.lblHotelName);
            this.Controls.Add(this.panelPersonel);
            this.Controls.Add(this.listbyDepartment);
            this.Location = new System.Drawing.Point(294, 54);
            this.Name = "frmListbyDepartment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "List by Department";
            this.panelPersonel.ResumeLayout(false);
            this.panelPersonel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label listbyDepartment;
        private System.Windows.Forms.Panel panelPersonel;
        private System.Windows.Forms.Button listbyDepartmentBtn;
        private System.Windows.Forms.ListView listViewPersonel;
        private System.Windows.Forms.ComboBox comboboxDepartment;
        private System.Windows.Forms.Label lblDepartment;
        private System.Windows.Forms.Label lblHotelName;
        private System.Windows.Forms.TextBox txtHotelName;
        private System.Windows.Forms.Button btnFindHotel;
    }
}