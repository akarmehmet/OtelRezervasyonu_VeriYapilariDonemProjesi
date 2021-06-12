
namespace OtelRezervasyonu_VeriYapilariDonemProjesi.Forms.frmAdmin
{
    partial class frmMDIAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMDIAdmin));
            this.adminLeftMDIPanel = new System.Windows.Forms.Panel();
            this.toolStripContainer1 = new System.Windows.Forms.ToolStripContainer();
            this.oneMenuScrip = new System.Windows.Forms.MenuStrip();
            this.hotelOperationsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newHotelCreateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hotelInfoUpdateDeleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addRoomToHotelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.personnelOperationsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateDeleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listByDepertmantToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hotelLogo = new System.Windows.Forms.PictureBox();
            this.adminTopMDIPanel = new System.Windows.Forms.Panel();
            this.exit = new System.Windows.Forms.PictureBox();
            this.adminLeftMDIPanel.SuspendLayout();
            this.toolStripContainer1.LeftToolStripPanel.SuspendLayout();
            this.toolStripContainer1.SuspendLayout();
            this.oneMenuScrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hotelLogo)).BeginInit();
            this.adminTopMDIPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.exit)).BeginInit();
            this.SuspendLayout();
            // 
            // adminLeftMDIPanel
            // 
            this.adminLeftMDIPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.adminLeftMDIPanel.Controls.Add(this.toolStripContainer1);
            this.adminLeftMDIPanel.Controls.Add(this.hotelLogo);
            this.adminLeftMDIPanel.Location = new System.Drawing.Point(-1, 0);
            this.adminLeftMDIPanel.Name = "adminLeftMDIPanel";
            this.adminLeftMDIPanel.Size = new System.Drawing.Size(294, 744);
            this.adminLeftMDIPanel.TabIndex = 7;
            // 
            // toolStripContainer1
            // 
            // 
            // toolStripContainer1.ContentPanel
            // 
            this.toolStripContainer1.ContentPanel.Size = new System.Drawing.Size(0, 122);
            // 
            // toolStripContainer1.LeftToolStripPanel
            // 
            this.toolStripContainer1.LeftToolStripPanel.Controls.Add(this.oneMenuScrip);
            this.toolStripContainer1.Location = new System.Drawing.Point(1, 245);
            this.toolStripContainer1.Name = "toolStripContainer1";
            // 
            // toolStripContainer1.RightToolStripPanel
            // 
            this.toolStripContainer1.RightToolStripPanel.Click += new System.EventHandler(this.toolStripContainer1_RightToolStripPanel_Click);
            this.toolStripContainer1.Size = new System.Drawing.Size(286, 147);
            this.toolStripContainer1.TabIndex = 4;
            this.toolStripContainer1.Text = "toolStripContainer1";
            // 
            // oneMenuScrip
            // 
            this.oneMenuScrip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.oneMenuScrip.Dock = System.Windows.Forms.DockStyle.None;
            this.oneMenuScrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hotelOperationsToolStripMenuItem,
            this.personnelOperationsToolStripMenuItem});
            this.oneMenuScrip.Location = new System.Drawing.Point(0, 0);
            this.oneMenuScrip.Name = "oneMenuScrip";
            this.oneMenuScrip.Size = new System.Drawing.Size(296, 122);
            this.oneMenuScrip.TabIndex = 1;
            this.oneMenuScrip.Text = "menuStrip1";
            // 
            // hotelOperationsToolStripMenuItem
            // 
            this.hotelOperationsToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.hotelOperationsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newHotelCreateToolStripMenuItem,
            this.hotelInfoUpdateDeleteToolStripMenuItem,
            this.addRoomToHotelToolStripMenuItem});
            this.hotelOperationsToolStripMenuItem.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.hotelOperationsToolStripMenuItem.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.hotelOperationsToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("hotelOperationsToolStripMenuItem.Image")));
            this.hotelOperationsToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.hotelOperationsToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.hotelOperationsToolStripMenuItem.Name = "hotelOperationsToolStripMenuItem";
            this.hotelOperationsToolStripMenuItem.Size = new System.Drawing.Size(289, 68);
            this.hotelOperationsToolStripMenuItem.Text = "    Hotel Operations";
            // 
            // newHotelCreateToolStripMenuItem
            // 
            this.newHotelCreateToolStripMenuItem.Name = "newHotelCreateToolStripMenuItem";
            this.newHotelCreateToolStripMenuItem.Size = new System.Drawing.Size(255, 26);
            this.newHotelCreateToolStripMenuItem.Text = "Create";
            this.newHotelCreateToolStripMenuItem.Click += new System.EventHandler(this.newHotelCreateToolStripMenuItem_Click);
            // 
            // hotelInfoUpdateDeleteToolStripMenuItem
            // 
            this.hotelInfoUpdateDeleteToolStripMenuItem.Name = "hotelInfoUpdateDeleteToolStripMenuItem";
            this.hotelInfoUpdateDeleteToolStripMenuItem.Size = new System.Drawing.Size(255, 26);
            this.hotelInfoUpdateDeleteToolStripMenuItem.Text = "Update - Delete";
            this.hotelInfoUpdateDeleteToolStripMenuItem.Click += new System.EventHandler(this.hotelInfoUpdateDeleteToolStripMenuItem_Click);
            // 
            // addRoomToHotelToolStripMenuItem
            // 
            this.addRoomToHotelToolStripMenuItem.Name = "addRoomToHotelToolStripMenuItem";
            this.addRoomToHotelToolStripMenuItem.Size = new System.Drawing.Size(255, 26);
            this.addRoomToHotelToolStripMenuItem.Text = "Add Room to Hotel";
            this.addRoomToHotelToolStripMenuItem.Click += new System.EventHandler(this.addRoomToHotelToolStripMenuItem_Click);
            // 
            // personnelOperationsToolStripMenuItem
            // 
            this.personnelOperationsToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.personnelOperationsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createToolStripMenuItem,
            this.updateDeleteToolStripMenuItem,
            this.listByDepertmantToolStripMenuItem});
            this.personnelOperationsToolStripMenuItem.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.personnelOperationsToolStripMenuItem.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.personnelOperationsToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("personnelOperationsToolStripMenuItem.Image")));
            this.personnelOperationsToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.personnelOperationsToolStripMenuItem.Name = "personnelOperationsToolStripMenuItem";
            this.personnelOperationsToolStripMenuItem.Size = new System.Drawing.Size(289, 68);
            this.personnelOperationsToolStripMenuItem.Text = "  Personnel Operations";
            // 
            // createToolStripMenuItem
            // 
            this.createToolStripMenuItem.Name = "createToolStripMenuItem";
            this.createToolStripMenuItem.Size = new System.Drawing.Size(252, 26);
            this.createToolStripMenuItem.Text = "Create";
            this.createToolStripMenuItem.Click += new System.EventHandler(this.createToolStripMenuItem_Click);
            // 
            // updateDeleteToolStripMenuItem
            // 
            this.updateDeleteToolStripMenuItem.Name = "updateDeleteToolStripMenuItem";
            this.updateDeleteToolStripMenuItem.Size = new System.Drawing.Size(252, 26);
            this.updateDeleteToolStripMenuItem.Text = "Update - Delete";
            this.updateDeleteToolStripMenuItem.Click += new System.EventHandler(this.updateDeleteToolStripMenuItem_Click);
            // 
            // listByDepertmantToolStripMenuItem
            // 
            this.listByDepertmantToolStripMenuItem.Name = "listByDepertmantToolStripMenuItem";
            this.listByDepertmantToolStripMenuItem.Size = new System.Drawing.Size(252, 26);
            this.listByDepertmantToolStripMenuItem.Text = "List By Departmant";
            this.listByDepertmantToolStripMenuItem.Click += new System.EventHandler(this.listByDepertmantToolStripMenuItem_Click);
            // 
            // hotelLogo
            // 
            this.hotelLogo.Image = ((System.Drawing.Image)(resources.GetObject("hotelLogo.Image")));
            this.hotelLogo.Location = new System.Drawing.Point(0, 12);
            this.hotelLogo.Name = "hotelLogo";
            this.hotelLogo.Size = new System.Drawing.Size(194, 179);
            this.hotelLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.hotelLogo.TabIndex = 0;
            this.hotelLogo.TabStop = false;
            // 
            // adminTopMDIPanel
            // 
            this.adminTopMDIPanel.BackColor = System.Drawing.SystemColors.HotTrack;
            this.adminTopMDIPanel.Controls.Add(this.exit);
            this.adminTopMDIPanel.Location = new System.Drawing.Point(292, 0);
            this.adminTopMDIPanel.Name = "adminTopMDIPanel";
            this.adminTopMDIPanel.Size = new System.Drawing.Size(863, 55);
            this.adminTopMDIPanel.TabIndex = 8;
            this.adminTopMDIPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.adminTopMDIPanel_MouseDown);
            this.adminTopMDIPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.adminTopMDIPanel_MouseMove);
            this.adminTopMDIPanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.adminTopMDIPanel_MouseUp);
            // 
            // exit
            // 
            this.exit.Image = ((System.Drawing.Image)(resources.GetObject("exit.Image")));
            this.exit.Location = new System.Drawing.Point(807, 12);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(42, 33);
            this.exit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.exit.TabIndex = 0;
            this.exit.TabStop = false;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // frmMDIAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1155, 745);
            this.Controls.Add(this.adminLeftMDIPanel);
            this.Controls.Add(this.adminTopMDIPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.IsMdiContainer = true;
            this.Name = "frmMDIAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmMDIAdmin";
            this.adminLeftMDIPanel.ResumeLayout(false);
            this.toolStripContainer1.LeftToolStripPanel.ResumeLayout(false);
            this.toolStripContainer1.LeftToolStripPanel.PerformLayout();
            this.toolStripContainer1.ResumeLayout(false);
            this.toolStripContainer1.PerformLayout();
            this.oneMenuScrip.ResumeLayout(false);
            this.oneMenuScrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hotelLogo)).EndInit();
            this.adminTopMDIPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.exit)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel adminLeftMDIPanel;
        private System.Windows.Forms.ToolStripContainer toolStripContainer1;
        private System.Windows.Forms.MenuStrip oneMenuScrip;
        private System.Windows.Forms.ToolStripMenuItem hotelOperationsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newHotelCreateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hotelInfoUpdateDeleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem personnelOperationsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateDeleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listByDepertmantToolStripMenuItem;
        private System.Windows.Forms.PictureBox hotelLogo;
        private System.Windows.Forms.Panel adminTopMDIPanel;
        private System.Windows.Forms.PictureBox exit;
        private System.Windows.Forms.ToolStripMenuItem addRoomToHotelToolStripMenuItem;
    }
}