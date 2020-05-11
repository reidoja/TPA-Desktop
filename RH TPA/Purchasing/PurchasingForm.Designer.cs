namespace RH_TPA.Purchasing
{
    partial class PurchasingForm
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
            this.purchaseRequestToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cRUDRequestToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fundToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cRUDRequestToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.reportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.purchaseReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.purchaseRequestToolStripMenuItem,
            this.fundToolStripMenuItem,
            this.reportToolStripMenuItem,
            this.logoutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // purchaseRequestToolStripMenuItem
            // 
            this.purchaseRequestToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cRUDRequestToolStripMenuItem});
            this.purchaseRequestToolStripMenuItem.Name = "purchaseRequestToolStripMenuItem";
            this.purchaseRequestToolStripMenuItem.Size = new System.Drawing.Size(112, 20);
            this.purchaseRequestToolStripMenuItem.Text = "Purchase Request";
            // 
            // cRUDRequestToolStripMenuItem
            // 
            this.cRUDRequestToolStripMenuItem.Name = "cRUDRequestToolStripMenuItem";
            this.cRUDRequestToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.cRUDRequestToolStripMenuItem.Text = "CRUD Request";
            this.cRUDRequestToolStripMenuItem.Click += new System.EventHandler(this.cRUDRequestToolStripMenuItem_Click);
            // 
            // fundToolStripMenuItem
            // 
            this.fundToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cRUDRequestToolStripMenuItem1});
            this.fundToolStripMenuItem.Name = "fundToolStripMenuItem";
            this.fundToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.fundToolStripMenuItem.Text = "Fund";
            // 
            // cRUDRequestToolStripMenuItem1
            // 
            this.cRUDRequestToolStripMenuItem1.Name = "cRUDRequestToolStripMenuItem1";
            this.cRUDRequestToolStripMenuItem1.Size = new System.Drawing.Size(145, 22);
            this.cRUDRequestToolStripMenuItem1.Text = "Send Request";
            this.cRUDRequestToolStripMenuItem1.Click += new System.EventHandler(this.cRUDRequestToolStripMenuItem1_Click);
            // 
            // reportToolStripMenuItem
            // 
            this.reportToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.purchaseReportToolStripMenuItem});
            this.reportToolStripMenuItem.Name = "reportToolStripMenuItem";
            this.reportToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.reportToolStripMenuItem.Text = "Report";
            // 
            // logoutToolStripMenuItem
            // 
            this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            this.logoutToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.logoutToolStripMenuItem.Text = "Logout";
            // 
            // purchaseReportToolStripMenuItem
            // 
            this.purchaseReportToolStripMenuItem.Name = "purchaseReportToolStripMenuItem";
            this.purchaseReportToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.purchaseReportToolStripMenuItem.Text = "Purchase Report";
            this.purchaseReportToolStripMenuItem.Click += new System.EventHandler(this.purchaseReportToolStripMenuItem_Click);
            // 
            // PurchasingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "PurchasingForm";
            this.Text = "PurchasingForm";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem purchaseRequestToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cRUDRequestToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fundToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cRUDRequestToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem purchaseReportToolStripMenuItem;
    }
}