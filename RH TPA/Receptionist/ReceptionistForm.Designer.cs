namespace RH_TPA.Forms
{
    partial class ReceptionistForm
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
            this.reservationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addReservationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.guestToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addGuestToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.checkEligibilityToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.qRCodeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.monthlyReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reviewsAndComplaintsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.menuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // reservationToolStripMenuItem
            // 
            this.reservationToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addReservationToolStripMenuItem});
            this.reservationToolStripMenuItem.Name = "reservationToolStripMenuItem";
            this.reservationToolStripMenuItem.Size = new System.Drawing.Size(80, 20);
            this.reservationToolStripMenuItem.Text = "Reservation";
            // 
            // addReservationToolStripMenuItem
            // 
            this.addReservationToolStripMenuItem.Name = "addReservationToolStripMenuItem";
            this.addReservationToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.addReservationToolStripMenuItem.Text = "CRUD Reservation";
            this.addReservationToolStripMenuItem.Click += new System.EventHandler(this.addReservationToolStripMenuItem_Click);
            // 
            // guestToolStripMenuItem
            // 
            this.guestToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addGuestToolStripMenuItem,
            this.checkEligibilityToolStripMenuItem,
            this.qRCodeToolStripMenuItem});
            this.guestToolStripMenuItem.Name = "guestToolStripMenuItem";
            this.guestToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.guestToolStripMenuItem.Text = "Guest";
            // 
            // addGuestToolStripMenuItem
            // 
            this.addGuestToolStripMenuItem.Name = "addGuestToolStripMenuItem";
            this.addGuestToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.addGuestToolStripMenuItem.Text = "CRUD Guest";
            this.addGuestToolStripMenuItem.Click += new System.EventHandler(this.addGuestToolStripMenuItem_Click);
            // 
            // checkEligibilityToolStripMenuItem
            // 
            this.checkEligibilityToolStripMenuItem.Name = "checkEligibilityToolStripMenuItem";
            this.checkEligibilityToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.checkEligibilityToolStripMenuItem.Text = "Check Eligibility";
            this.checkEligibilityToolStripMenuItem.Click += new System.EventHandler(this.checkEligibilityToolStripMenuItem_Click);
            // 
            // qRCodeToolStripMenuItem
            // 
            this.qRCodeToolStripMenuItem.Name = "qRCodeToolStripMenuItem";
            this.qRCodeToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.qRCodeToolStripMenuItem.Text = "QRCode";
            this.qRCodeToolStripMenuItem.Click += new System.EventHandler(this.qRCodeToolStripMenuItem_Click);
            // 
            // reportToolStripMenuItem
            // 
            this.reportToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.monthlyReportToolStripMenuItem,
            this.reviewsAndComplaintsToolStripMenuItem});
            this.reportToolStripMenuItem.Name = "reportToolStripMenuItem";
            this.reportToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.reportToolStripMenuItem.Text = "Report";
            // 
            // monthlyReportToolStripMenuItem
            // 
            this.monthlyReportToolStripMenuItem.Name = "monthlyReportToolStripMenuItem";
            this.monthlyReportToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.monthlyReportToolStripMenuItem.Text = "Sales Report";
            this.monthlyReportToolStripMenuItem.Click += new System.EventHandler(this.monthlyReportToolStripMenuItem_Click);
            // 
            // reviewsAndComplaintsToolStripMenuItem
            // 
            this.reviewsAndComplaintsToolStripMenuItem.Name = "reviewsAndComplaintsToolStripMenuItem";
            this.reviewsAndComplaintsToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.reviewsAndComplaintsToolStripMenuItem.Text = "Reviews and Complaints";
            // 
            // logoutToolStripMenuItem
            // 
            this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            this.logoutToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.logoutToolStripMenuItem.Text = "Logout";
            this.logoutToolStripMenuItem.Click += new System.EventHandler(this.logoutToolStripMenuItem_Click);
            // 
            // menuStrip2
            // 
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.reservationToolStripMenuItem,
            this.guestToolStripMenuItem,
            this.reportToolStripMenuItem,
            this.logoutToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(598, 24);
            this.menuStrip2.TabIndex = 1;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // ReceptionistForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(598, 383);
            this.Controls.Add(this.menuStrip2);
            this.IsMdiContainer = true;
            this.Name = "ReceptionistForm";
            this.Text = "ReceptionistForm";
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStripMenuItem reservationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addReservationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem guestToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addGuestToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem checkEligibilityToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem monthlyReportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reviewsAndComplaintsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem qRCodeToolStripMenuItem;
    }
}