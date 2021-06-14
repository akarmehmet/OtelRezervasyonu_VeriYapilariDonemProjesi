
namespace OtelRezervasyonu_VeriYapilariDonemProjesi.Forms.frmCustomer
{
    partial class BinarySearchTreeofHotels
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
            this.BinarySearchTreeofHotelsLbl = new System.Windows.Forms.Label();
            this.btnInorder = new System.Windows.Forms.Button();
            this.btnPostorder = new System.Windows.Forms.Button();
            this.btnPreorder = new System.Windows.Forms.Button();
            this.listViewHotel = new System.Windows.Forms.ListView();
            this.TreeDepthLbl = new System.Windows.Forms.Label();
            this.txtTreeDepth = new System.Windows.Forms.TextBox();
            this.btnTreeDepth = new System.Windows.Forms.Button();
            this.btnNumberOFElements = new System.Windows.Forms.Button();
            this.txtNumberOfElements = new System.Windows.Forms.TextBox();
            this.numberofElementsLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BinarySearchTreeofHotelsLbl
            // 
            this.BinarySearchTreeofHotelsLbl.AutoSize = true;
            this.BinarySearchTreeofHotelsLbl.Font = new System.Drawing.Font("Century Gothic", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BinarySearchTreeofHotelsLbl.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.BinarySearchTreeofHotelsLbl.Location = new System.Drawing.Point(53, 42);
            this.BinarySearchTreeofHotelsLbl.Name = "BinarySearchTreeofHotelsLbl";
            this.BinarySearchTreeofHotelsLbl.Size = new System.Drawing.Size(491, 41);
            this.BinarySearchTreeofHotelsLbl.TabIndex = 111;
            this.BinarySearchTreeofHotelsLbl.Text = "Binary Search Tree of Hotels:";
            // 
            // btnInorder
            // 
            this.btnInorder.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnInorder.Font = new System.Drawing.Font("Century Gothic", 14.25F);
            this.btnInorder.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnInorder.Location = new System.Drawing.Point(50, 108);
            this.btnInorder.Name = "btnInorder";
            this.btnInorder.Size = new System.Drawing.Size(232, 44);
            this.btnInorder.TabIndex = 112;
            this.btnInorder.Text = "Inorder";
            this.btnInorder.UseVisualStyleBackColor = false;
            this.btnInorder.Click += new System.EventHandler(this.btnInorder_Click);
            // 
            // btnPostorder
            // 
            this.btnPostorder.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnPostorder.Font = new System.Drawing.Font("Century Gothic", 14.25F);
            this.btnPostorder.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnPostorder.Location = new System.Drawing.Point(313, 108);
            this.btnPostorder.Name = "btnPostorder";
            this.btnPostorder.Size = new System.Drawing.Size(232, 44);
            this.btnPostorder.TabIndex = 113;
            this.btnPostorder.Text = "Postorder";
            this.btnPostorder.UseVisualStyleBackColor = false;
            this.btnPostorder.Click += new System.EventHandler(this.btnPostorder_Click);
            // 
            // btnPreorder
            // 
            this.btnPreorder.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnPreorder.Font = new System.Drawing.Font("Century Gothic", 14.25F);
            this.btnPreorder.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnPreorder.Location = new System.Drawing.Point(571, 108);
            this.btnPreorder.Name = "btnPreorder";
            this.btnPreorder.Size = new System.Drawing.Size(232, 44);
            this.btnPreorder.TabIndex = 114;
            this.btnPreorder.Text = "Preorder";
            this.btnPreorder.UseVisualStyleBackColor = false;
            this.btnPreorder.Click += new System.EventHandler(this.btnPreorder_Click);
            // 
            // listViewHotel
            // 
            this.listViewHotel.HideSelection = false;
            this.listViewHotel.Location = new System.Drawing.Point(40, 171);
            this.listViewHotel.Name = "listViewHotel";
            this.listViewHotel.Size = new System.Drawing.Size(763, 222);
            this.listViewHotel.TabIndex = 115;
            this.listViewHotel.UseCompatibleStateImageBehavior = false;
            // 
            // TreeDepthLbl
            // 
            this.TreeDepthLbl.AutoSize = true;
            this.TreeDepthLbl.Font = new System.Drawing.Font("Century Gothic", 14.25F);
            this.TreeDepthLbl.Location = new System.Drawing.Point(185, 443);
            this.TreeDepthLbl.Name = "TreeDepthLbl";
            this.TreeDepthLbl.Size = new System.Drawing.Size(116, 22);
            this.TreeDepthLbl.TabIndex = 116;
            this.TreeDepthLbl.Text = "Tree Depth:";
            // 
            // txtTreeDepth
            // 
            this.txtTreeDepth.Font = new System.Drawing.Font("Century Gothic", 14.25F);
            this.txtTreeDepth.Location = new System.Drawing.Point(152, 494);
            this.txtTreeDepth.Name = "txtTreeDepth";
            this.txtTreeDepth.Size = new System.Drawing.Size(186, 31);
            this.txtTreeDepth.TabIndex = 117;
            // 
            // btnTreeDepth
            // 
            this.btnTreeDepth.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnTreeDepth.Font = new System.Drawing.Font("Century Gothic", 14.25F);
            this.btnTreeDepth.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnTreeDepth.Location = new System.Drawing.Point(125, 547);
            this.btnTreeDepth.Name = "btnTreeDepth";
            this.btnTreeDepth.Size = new System.Drawing.Size(232, 44);
            this.btnTreeDepth.TabIndex = 118;
            this.btnTreeDepth.Text = "Get Tree Depth";
            this.btnTreeDepth.UseVisualStyleBackColor = false;
            this.btnTreeDepth.Click += new System.EventHandler(this.btnTreeDepth_Click);
            // 
            // btnNumberOFElements
            // 
            this.btnNumberOFElements.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnNumberOFElements.Font = new System.Drawing.Font("Century Gothic", 14.25F);
            this.btnNumberOFElements.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnNumberOFElements.Location = new System.Drawing.Point(447, 547);
            this.btnNumberOFElements.Name = "btnNumberOFElements";
            this.btnNumberOFElements.Size = new System.Drawing.Size(232, 44);
            this.btnNumberOFElements.TabIndex = 121;
            this.btnNumberOFElements.Text = "Get Element Count";
            this.btnNumberOFElements.UseVisualStyleBackColor = false;
            this.btnNumberOFElements.Click += new System.EventHandler(this.btnNumberOFElements_Click);
            // 
            // txtNumberOfElements
            // 
            this.txtNumberOfElements.Font = new System.Drawing.Font("Century Gothic", 14.25F);
            this.txtNumberOfElements.Location = new System.Drawing.Point(471, 494);
            this.txtNumberOfElements.Name = "txtNumberOfElements";
            this.txtNumberOfElements.Size = new System.Drawing.Size(186, 31);
            this.txtNumberOfElements.TabIndex = 120;
            // 
            // numberofElementsLbl
            // 
            this.numberofElementsLbl.AutoSize = true;
            this.numberofElementsLbl.Font = new System.Drawing.Font("Century Gothic", 14.25F);
            this.numberofElementsLbl.Location = new System.Drawing.Point(467, 443);
            this.numberofElementsLbl.Name = "numberofElementsLbl";
            this.numberofElementsLbl.Size = new System.Drawing.Size(197, 22);
            this.numberofElementsLbl.TabIndex = 119;
            this.numberofElementsLbl.Text = "Number of Elements:";
            // 
            // BinarySearchTreeofHotels
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(839, 641);
            this.Controls.Add(this.btnNumberOFElements);
            this.Controls.Add(this.txtNumberOfElements);
            this.Controls.Add(this.numberofElementsLbl);
            this.Controls.Add(this.btnTreeDepth);
            this.Controls.Add(this.txtTreeDepth);
            this.Controls.Add(this.TreeDepthLbl);
            this.Controls.Add(this.listViewHotel);
            this.Controls.Add(this.btnPreorder);
            this.Controls.Add(this.btnPostorder);
            this.Controls.Add(this.btnInorder);
            this.Controls.Add(this.BinarySearchTreeofHotelsLbl);
            this.Location = new System.Drawing.Point(294, 54);
            this.Name = "BinarySearchTreeofHotels";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "BinarySearchTreeofHotels";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label BinarySearchTreeofHotelsLbl;
        private System.Windows.Forms.Button btnInorder;
        private System.Windows.Forms.Button btnPostorder;
        private System.Windows.Forms.Button btnPreorder;
        private System.Windows.Forms.ListView listViewHotel;
        private System.Windows.Forms.Label TreeDepthLbl;
        private System.Windows.Forms.TextBox txtTreeDepth;
        private System.Windows.Forms.Button btnTreeDepth;
        private System.Windows.Forms.Button btnNumberOFElements;
        private System.Windows.Forms.TextBox txtNumberOfElements;
        private System.Windows.Forms.Label numberofElementsLbl;
    }
}