namespace RH_TPA.SalesAndMarketing
{
    partial class SalesAndMarketingForm
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
            this.fundRequestToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sendRequestToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.guestReviewsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fundRequestToolStripMenuItem,
            this.reportToolStripMenuItem,
            this.logoutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fundRequestToolStripMenuItem
            // 
            this.fundRequestToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sendRequestToolStripMenuItem});
            this.fundRequestToolStripMenuItem.Name = "fundRequestToolStripMenuItem";
            this.fundRequestToolStripMenuItem.Size = new System.Drawing.Size(91, 20);
            this.fundRequestToolStripMenuItem.Text = "Fund Request";
            // 
            // sendRequestToolStripMenuItem
            // 
            this.sendRequestToolStripMenuItem.Name = "sendRequestToolStripMenuItem";
            this.sendRequestToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.sendRequestToolStripMenuItem.Text = "Send Request";
            // 
            // reportToolStripMenuItem
            // 
            this.reportToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.guestReviewsToolStripMenuItem});
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
            // guestReviewsToolStripMenuItem
            // 
            this.guestReviewsToolStripMenuItem.Name = "guestReviewsToolStripMenuItem";
            this.guestReviewsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.guestReviewsToolStripMenuItem.Text = "Guest Reviews";
            this.guestReviewsToolStripMenuItem.Click += new System.EventHandler(this.guestReviewsToolStripMenuItem_Click);
            // 
            // SalesAndMarketingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "SalesAndMarketingForm";
            this.Text = "SalesAndMarketingForm";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fundRequestToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sendRequestToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem guestReviewsToolStripMenuItem;
    }
}