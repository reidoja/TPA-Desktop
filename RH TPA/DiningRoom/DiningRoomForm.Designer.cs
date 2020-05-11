namespace RH_TPA.DiningRoom
{
    partial class DiningRoomForm
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
            this.dishesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cRUDDishesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.checkEligibilityToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dishesToolStripMenuItem,
            this.reportToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // dishesToolStripMenuItem
            // 
            this.dishesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cRUDDishesToolStripMenuItem});
            this.dishesToolStripMenuItem.Name = "dishesToolStripMenuItem";
            this.dishesToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.dishesToolStripMenuItem.Text = "Dishes";
            // 
            // cRUDDishesToolStripMenuItem
            // 
            this.cRUDDishesToolStripMenuItem.Name = "cRUDDishesToolStripMenuItem";
            this.cRUDDishesToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.cRUDDishesToolStripMenuItem.Text = "CRUD Request";
            this.cRUDDishesToolStripMenuItem.Click += new System.EventHandler(this.cRUDDishesToolStripMenuItem_Click);
            // 
            // reportToolStripMenuItem
            // 
            this.reportToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.checkEligibilityToolStripMenuItem});
            this.reportToolStripMenuItem.Name = "reportToolStripMenuItem";
            this.reportToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.reportToolStripMenuItem.Text = "Guest";
            // 
            // checkEligibilityToolStripMenuItem
            // 
            this.checkEligibilityToolStripMenuItem.Name = "checkEligibilityToolStripMenuItem";
            this.checkEligibilityToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.checkEligibilityToolStripMenuItem.Text = "Check Eligibility";
            this.checkEligibilityToolStripMenuItem.Click += new System.EventHandler(this.checkEligibilityToolStripMenuItem_Click);
            // 
            // DiningRoomForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "DiningRoomForm";
            this.Text = "DiningRoomForm";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem dishesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cRUDDishesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem checkEligibilityToolStripMenuItem;
    }
}