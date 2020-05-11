namespace RH_TPA.HumanCapital
{
    partial class HumanCapitalForm
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
            this.salaryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cRUDSalaryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.employeeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cRUDEmployeeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hireToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fireToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sendPurchaseRequestToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hireFlowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salaryToolStripMenuItem,
            this.employeeToolStripMenuItem,
            this.logoutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // salaryToolStripMenuItem
            // 
            this.salaryToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cRUDSalaryToolStripMenuItem});
            this.salaryToolStripMenuItem.Name = "salaryToolStripMenuItem";
            this.salaryToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.salaryToolStripMenuItem.Text = "Salary";
            // 
            // cRUDSalaryToolStripMenuItem
            // 
            this.cRUDSalaryToolStripMenuItem.Name = "cRUDSalaryToolStripMenuItem";
            this.cRUDSalaryToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.cRUDSalaryToolStripMenuItem.Text = "CRUD Salary";
            this.cRUDSalaryToolStripMenuItem.Click += new System.EventHandler(this.cRUDSalaryToolStripMenuItem_Click);
            // 
            // employeeToolStripMenuItem
            // 
            this.employeeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cRUDEmployeeToolStripMenuItem,
            this.hireToolStripMenuItem,
            this.fireToolStripMenuItem});
            this.employeeToolStripMenuItem.Name = "employeeToolStripMenuItem";
            this.employeeToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.employeeToolStripMenuItem.Text = "Employee";
            // 
            // cRUDEmployeeToolStripMenuItem
            // 
            this.cRUDEmployeeToolStripMenuItem.Name = "cRUDEmployeeToolStripMenuItem";
            this.cRUDEmployeeToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.cRUDEmployeeToolStripMenuItem.Text = "CRUD Employee";
            this.cRUDEmployeeToolStripMenuItem.Click += new System.EventHandler(this.cRUDEmployeeToolStripMenuItem_Click);
            // 
            // hireToolStripMenuItem
            // 
            this.hireToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sendPurchaseRequestToolStripMenuItem,
            this.hireFlowToolStripMenuItem});
            this.hireToolStripMenuItem.Name = "hireToolStripMenuItem";
            this.hireToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.hireToolStripMenuItem.Text = "Hire";
            // 
            // fireToolStripMenuItem
            // 
            this.fireToolStripMenuItem.Name = "fireToolStripMenuItem";
            this.fireToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.fireToolStripMenuItem.Text = "Fire";
            this.fireToolStripMenuItem.Click += new System.EventHandler(this.fireToolStripMenuItem_Click);
            // 
            // logoutToolStripMenuItem
            // 
            this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            this.logoutToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.logoutToolStripMenuItem.Text = "Logout";
            // 
            // sendPurchaseRequestToolStripMenuItem
            // 
            this.sendPurchaseRequestToolStripMenuItem.Name = "sendPurchaseRequestToolStripMenuItem";
            this.sendPurchaseRequestToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.sendPurchaseRequestToolStripMenuItem.Text = "Send Fund Request";
            this.sendPurchaseRequestToolStripMenuItem.Click += new System.EventHandler(this.sendPurchaseRequestToolStripMenuItem_Click);
            // 
            // hireFlowToolStripMenuItem
            // 
            this.hireFlowToolStripMenuItem.Name = "hireFlowToolStripMenuItem";
            this.hireFlowToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.hireFlowToolStripMenuItem.Text = "Hire Flow";
            this.hireFlowToolStripMenuItem.Click += new System.EventHandler(this.hireFlowToolStripMenuItem_Click);
            // 
            // HumanCapitalForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "HumanCapitalForm";
            this.Text = "HumanCapitalForm";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem salaryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cRUDSalaryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem employeeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cRUDEmployeeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hireToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fireToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sendPurchaseRequestToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hireFlowToolStripMenuItem;
    }
}