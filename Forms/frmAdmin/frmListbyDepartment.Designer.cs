
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
            this.positionCmbBx = new System.Windows.Forms.ComboBox();
            this.positionLbl = new System.Windows.Forms.Label();
            this.departmentLstVw = new System.Windows.Forms.ListView();
            this.listbyDepartmentBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listbyDepartment
            // 
            this.listbyDepartment.AutoSize = true;
            this.listbyDepartment.Font = new System.Drawing.Font("Century Gothic", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listbyDepartment.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.listbyDepartment.Location = new System.Drawing.Point(66, 34);
            this.listbyDepartment.Name = "listbyDepartment";
            this.listbyDepartment.Size = new System.Drawing.Size(339, 41);
            this.listbyDepartment.TabIndex = 26;
            this.listbyDepartment.Text = "List by Department:";
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
            this.positionCmbBx.Location = new System.Drawing.Point(373, 115);
            this.positionCmbBx.Name = "positionCmbBx";
            this.positionCmbBx.Size = new System.Drawing.Size(239, 30);
            this.positionCmbBx.TabIndex = 28;
            // 
            // positionLbl
            // 
            this.positionLbl.AutoSize = true;
            this.positionLbl.Font = new System.Drawing.Font("Century Gothic", 14.25F);
            this.positionLbl.Location = new System.Drawing.Point(205, 114);
            this.positionLbl.Name = "positionLbl";
            this.positionLbl.Size = new System.Drawing.Size(82, 22);
            this.positionLbl.TabIndex = 27;
            this.positionLbl.Text = "Position:";
            // 
            // departmentLstVw
            // 
            this.departmentLstVw.HideSelection = false;
            this.departmentLstVw.Location = new System.Drawing.Point(31, 280);
            this.departmentLstVw.Name = "departmentLstVw";
            this.departmentLstVw.Size = new System.Drawing.Size(770, 330);
            this.departmentLstVw.TabIndex = 29;
            this.departmentLstVw.UseCompatibleStateImageBehavior = false;
            // 
            // listbyDepartmentBtn
            // 
            this.listbyDepartmentBtn.BackColor = System.Drawing.SystemColors.HotTrack;
            this.listbyDepartmentBtn.Font = new System.Drawing.Font("Century Gothic", 14.25F);
            this.listbyDepartmentBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.listbyDepartmentBtn.Location = new System.Drawing.Point(139, 187);
            this.listbyDepartmentBtn.Name = "listbyDepartmentBtn";
            this.listbyDepartmentBtn.Size = new System.Drawing.Size(567, 62);
            this.listbyDepartmentBtn.TabIndex = 30;
            this.listbyDepartmentBtn.Text = "List by Department";
            this.listbyDepartmentBtn.UseVisualStyleBackColor = false;
            // 
            // frmListbyDepartment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(839, 641);
            this.Controls.Add(this.listbyDepartmentBtn);
            this.Controls.Add(this.departmentLstVw);
            this.Controls.Add(this.positionCmbBx);
            this.Controls.Add(this.positionLbl);
            this.Controls.Add(this.listbyDepartment);
            this.Location = new System.Drawing.Point(294, 54);
            this.Name = "frmListbyDepartment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "List by Department";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label listbyDepartment;
        private System.Windows.Forms.ComboBox positionCmbBx;
        private System.Windows.Forms.Label positionLbl;
        private System.Windows.Forms.ListView departmentLstVw;
        private System.Windows.Forms.Button listbyDepartmentBtn;
    }
}