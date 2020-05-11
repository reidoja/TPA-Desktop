namespace RH_TPA.HouseKeeping
{
    partial class HouseKeepingForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.minibarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cRUDItemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.guestToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.makeUpRoomToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sendReportToReceptionistToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sendPurchaseReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sendPurchaseRequestToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.minibarToolStripMenuItem,
            this.guestToolStripMenuItem,
            this.reportToolStripMenuItem,
            this.logoutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // minibarToolStripMenuItem
            // 
            this.minibarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cRUDItemToolStripMenuItem,
            this.sendPurchaseRequestToolStripMenuItem});
            this.minibarToolStripMenuItem.Name = "minibarToolStripMenuItem";
            this.minibarToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.minibarToolStripMenuItem.Text = "Minibar";
            // 
            // cRUDItemToolStripMenuItem
            // 
            this.cRUDItemToolStripMenuItem.Name = "cRUDItemToolStripMenuItem";
            this.cRUDItemToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.cRUDItemToolStripMenuItem.Text = "CRUD Item";
            this.cRUDItemToolStripMenuItem.Click += new System.EventHandler(this.cRUDItemToolStripMenuItem_Click);
            // 
            // guestToolStripMenuItem
            // 
            this.guestToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.makeUpRoomToolStripMenuItem});
            this.guestToolStripMenuItem.Name = "guestToolStripMenuItem";
            this.guestToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.guestToolStripMenuItem.Text = "Guest";
            this.guestToolStripMenuItem.Click += new System.EventHandler(this.guestToolStripMenuItem_Click);
            // 
            // makeUpRoomToolStripMenuItem
            // 
            this.makeUpRoomToolStripMenuItem.Name = "makeUpRoomToolStripMenuItem";
            this.makeUpRoomToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.makeUpRoomToolStripMenuItem.Text = "Make Up Room";
            this.makeUpRoomToolStripMenuItem.Click += new System.EventHandler(this.makeUpRoomToolStripMenuItem_Click);
            // 
            // reportToolStripMenuItem
            // 
            this.reportToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sendReportToReceptionistToolStripMenuItem,
            this.sendPurchaseReportToolStripMenuItem});
            this.reportToolStripMenuItem.Name = "reportToolStripMenuItem";
            this.reportToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.reportToolStripMenuItem.Text = "Report";
            // 
            // sendReportToReceptionistToolStripMenuItem
            // 
            this.sendReportToReceptionistToolStripMenuItem.Name = "sendReportToReceptionistToolStripMenuItem";
            this.sendReportToReceptionistToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.sendReportToReceptionistToolStripMenuItem.Text = "Minibar Items Report";
            // 
            // sendPurchaseReportToolStripMenuItem
            // 
            this.sendPurchaseReportToolStripMenuItem.Name = "sendPurchaseReportToolStripMenuItem";
            this.sendPurchaseReportToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.sendPurchaseReportToolStripMenuItem.Text = "Purchase Report";
            // 
            // logoutToolStripMenuItem
            // 
            this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            this.logoutToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.logoutToolStripMenuItem.Text = "Logout";
            this.logoutToolStripMenuItem.Click += new System.EventHandler(this.logoutToolStripMenuItem_Click);
            // 
            // sendPurchaseRequestToolStripMenuItem
            // 
            this.sendPurchaseRequestToolStripMenuItem.Name = "sendPurchaseRequestToolStripMenuItem";
            this.sendPurchaseRequestToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.sendPurchaseRequestToolStripMenuItem.Text = "Send Purchase Request";
            this.sendPurchaseRequestToolStripMenuItem.Click += new System.EventHandler(this.sendPurchaseRequestToolStripMenuItem_Click);
            // 
            // HouseKeepingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "HouseKeepingForm";
            this.Text = "HouseKeepingForm";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem minibarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cRUDItemToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sendReportToReceptionistToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sendPurchaseReportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem guestToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem makeUpRoomToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sendPurchaseRequestToolStripMenuItem;
    }
}