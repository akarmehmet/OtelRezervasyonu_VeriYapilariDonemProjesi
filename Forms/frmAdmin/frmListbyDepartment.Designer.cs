
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
            this.personelPanel = new System.Windows.Forms.Panel();
            this.listbyDepartmentBtn = new System.Windows.Forms.Button();
            this.departmentLstVw = new System.Windows.Forms.ListView();
            this.positionCmbBx = new System.Windows.Forms.ComboBox();
            this.positionLbl = new System.Windows.Forms.Label();
            this.lblHotelName = new System.Windows.Forms.Label();
            this.txtHotelName = new System.Windows.Forms.TextBox();
            this.btnFindHotel = new System.Windows.Forms.Button();
            this.personelPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // listbyDepartment
            // 
            this.listbyDepartment.AutoSize = true;
            this.listbyDepartment.Font = new System.Drawing.Font("Century Gothic", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listbyDepartment.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.listbyDepartment.Location = new System.Drawing.Point(200, 9);
            this.listbyDepartment.Name = "listbyDepartment";
            this.listbyDepartment.Size = new System.Drawing.Size(339, 41);
            this.listbyDepartment.TabIndex = 26;
            this.listbyDepartment.Text = "List by Department:";
            // 
            // personelPanel
            // 
            this.personelPanel.Controls.Add(this.listbyDepartmentBtn);
            this.personelPanel.Controls.Add(this.departmentLstVw);
            this.personelPanel.Controls.Add(this.positionCmbBx);
            this.personelPanel.Controls.Add(this.positionLbl);
            this.personelPanel.Location = new System.Drawing.Point(6, 143);
            this.personelPanel.Name = "personelPanel";
            this.personelPanel.Size = new System.Drawing.Size(821, 497);
            this.personelPanel.TabIndex = 31;
            this.personelPanel.Visible = false;
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
            // 
            // departmentLstVw
            // 
            this.departmentLstVw.HideSelection = false;
            this.departmentLstVw.Location = new System.Drawing.Point(33, 164);
            this.departmentLstVw.Name = "departmentLstVw";
            this.departmentLstVw.Size = new System.Drawing.Size(770, 330);
            this.departmentLstVw.TabIndex = 33;
            this.departmentLstVw.UseCompatibleStateImageBehavior = false;
            // 
            // positionCmbBx
            // 
            this.positionCmbBx.Font = new System.Drawing.Font("Century Gothic", 14.25F);
            this.positionCmbBx.FormattingEnabled = true;
            this.positionCmbBx.Items.AddRange(new object[] {
            "Manager",
            "AssistantDirector",
            "Chef",
            "SecurityGuard",
            "ReceptionChief",
            "WarehouseSupervisor",
            "Dishwasher",
            "ITStaff",
            "PurchasingManager"});
            this.positionCmbBx.Location = new System.Drawing.Point(365, 30);
            this.positionCmbBx.Name = "positionCmbBx";
            this.positionCmbBx.Size = new System.Drawing.Size(239, 30);
            this.positionCmbBx.TabIndex = 32;
            // 
            // positionLbl
            // 
            this.positionLbl.AutoSize = true;
            this.positionLbl.Font = new System.Drawing.Font("Century Gothic", 14.25F);
            this.positionLbl.Location = new System.Drawing.Point(197, 29);
            this.positionLbl.Name = "positionLbl";
            this.positionLbl.Size = new System.Drawing.Size(82, 22);
            this.positionLbl.TabIndex = 31;
            this.positionLbl.Text = "Position:";
            // 
            // lblHotelName
            // 
            this.lblHotelName.AutoSize = true;
            this.lblHotelName.Location = new System.Drawing.Point(62, 89);
            this.lblHotelName.Name = "lblHotelName";
            this.lblHotelName.Size = new System.Drawing.Size(63, 13);
            this.lblHotelName.TabIndex = 32;
            this.lblHotelName.Text = "Hotel Name";
            // 
            // txtHotelName
            // 
            this.txtHotelName.Location = new System.Drawing.Point(185, 83);
            this.txtHotelName.Name = "txtHotelName";
            this.txtHotelName.Size = new System.Drawing.Size(100, 20);
            this.txtHotelName.TabIndex = 33;
            // 
            // btnFindHotel
            // 
            this.btnFindHotel.Location = new System.Drawing.Point(425, 80);
            this.btnFindHotel.Name = "btnFindHotel";
            this.btnFindHotel.Size = new System.Drawing.Size(75, 23);
            this.btnFindHotel.TabIndex = 34;
            this.btnFindHotel.Text = "Find Hotel";
            this.btnFindHotel.UseVisualStyleBackColor = true;
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
            this.Controls.Add(this.personelPanel);
            this.Controls.Add(this.listbyDepartment);
            this.Location = new System.Drawing.Point(294, 54);
            this.Name = "frmListbyDepartment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "List by Department";
            this.personelPanel.ResumeLayout(false);
            this.personelPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label listbyDepartment;
        private System.Windows.Forms.Panel personelPanel;
        private System.Windows.Forms.Button listbyDepartmentBtn;
        private System.Windows.Forms.ListView departmentLstVw;
        private System.Windows.Forms.ComboBox positionCmbBx;
        private System.Windows.Forms.Label positionLbl;
        private System.Windows.Forms.Label lblHotelName;
        private System.Windows.Forms.TextBox txtHotelName;
        private System.Windows.Forms.Button btnFindHotel;
    }
}