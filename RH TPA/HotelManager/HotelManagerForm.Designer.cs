namespace RH_TPA.HotelManager
{
    partial class HotelManagerForm
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
            this.evidenceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cRUDEvidenceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resignationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cRUDResignationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.evidenceToolStripMenuItem,
            this.resignationToolStripMenuItem,
            this.logoutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // evidenceToolStripMenuItem
            // 
            this.evidenceToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cRUDEvidenceToolStripMenuItem});
            this.evidenceToolStripMenuItem.Name = "evidenceToolStripMenuItem";
            this.evidenceToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.evidenceToolStripMenuItem.Text = "Evidence";
            // 
            // cRUDEvidenceToolStripMenuItem
            // 
            this.cRUDEvidenceToolStripMenuItem.Name = "cRUDEvidenceToolStripMenuItem";
            this.cRUDEvidenceToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.cRUDEvidenceToolStripMenuItem.Text = "CRUD Evidence";
            this.cRUDEvidenceToolStripMenuItem.Click += new System.EventHandler(this.cRUDEvidenceToolStripMenuItem_Click);
            // 
            // resignationToolStripMenuItem
            // 
            this.resignationToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cRUDResignationToolStripMenuItem});
            this.resignationToolStripMenuItem.Name = "resignationToolStripMenuItem";
            this.resignationToolStripMenuItem.Size = new System.Drawing.Size(81, 20);
            this.resignationToolStripMenuItem.Text = "Resignation";
            // 
            // cRUDResignationToolStripMenuItem
            // 
            this.cRUDResignationToolStripMenuItem.Name = "cRUDResignationToolStripMenuItem";
            this.cRUDResignationToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.cRUDResignationToolStripMenuItem.Text = "CRUD Resignation";
            this.cRUDResignationToolStripMenuItem.Click += new System.EventHandler(this.cRUDResignationToolStripMenuItem_Click);
            // 
            // logoutToolStripMenuItem
            // 
            this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            this.logoutToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.logoutToolStripMenuItem.Text = "Logout";
            // 
            // HotelManagerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "HotelManagerForm";
            this.Text = "HotelManagerForm";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem evidenceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cRUDEvidenceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem resignationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cRUDResignationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
    }
}