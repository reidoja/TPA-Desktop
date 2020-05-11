namespace RH_TPA.Kitchen
{
    partial class KitchenForm
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
            this.requestToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cRUDRequestToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.recipeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cRUDRecipeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ingredientsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cRUDIngredientsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.purchaseRequestToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sendPurchaseRequestToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.requestToolStripMenuItem,
            this.recipeToolStripMenuItem,
            this.ingredientsToolStripMenuItem,
            this.purchaseRequestToolStripMenuItem,
            this.logoutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // requestToolStripMenuItem
            // 
            this.requestToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cRUDRequestToolStripMenuItem});
            this.requestToolStripMenuItem.Name = "requestToolStripMenuItem";
            this.requestToolStripMenuItem.Size = new System.Drawing.Size(92, 20);
            this.requestToolStripMenuItem.Text = "Cook Request";
            // 
            // cRUDRequestToolStripMenuItem
            // 
            this.cRUDRequestToolStripMenuItem.Name = "cRUDRequestToolStripMenuItem";
            this.cRUDRequestToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.cRUDRequestToolStripMenuItem.Text = "CRUD Request";
            this.cRUDRequestToolStripMenuItem.Click += new System.EventHandler(this.cRUDRequestToolStripMenuItem_Click);
            // 
            // recipeToolStripMenuItem
            // 
            this.recipeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cRUDRecipeToolStripMenuItem});
            this.recipeToolStripMenuItem.Name = "recipeToolStripMenuItem";
            this.recipeToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.recipeToolStripMenuItem.Text = "Recipe";
            // 
            // cRUDRecipeToolStripMenuItem
            // 
            this.cRUDRecipeToolStripMenuItem.Name = "cRUDRecipeToolStripMenuItem";
            this.cRUDRecipeToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.cRUDRecipeToolStripMenuItem.Text = "CRUD Recipe";
            this.cRUDRecipeToolStripMenuItem.Click += new System.EventHandler(this.cRUDRecipeToolStripMenuItem_Click);
            // 
            // ingredientsToolStripMenuItem
            // 
            this.ingredientsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cRUDIngredientsToolStripMenuItem,
            this.sendPurchaseRequestToolStripMenuItem});
            this.ingredientsToolStripMenuItem.Name = "ingredientsToolStripMenuItem";
            this.ingredientsToolStripMenuItem.Size = new System.Drawing.Size(78, 20);
            this.ingredientsToolStripMenuItem.Text = "Ingredients";
            // 
            // cRUDIngredientsToolStripMenuItem
            // 
            this.cRUDIngredientsToolStripMenuItem.Name = "cRUDIngredientsToolStripMenuItem";
            this.cRUDIngredientsToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.cRUDIngredientsToolStripMenuItem.Text = "CRUD Ingredients";
            this.cRUDIngredientsToolStripMenuItem.Click += new System.EventHandler(this.cRUDIngredientsToolStripMenuItem_Click);
            // 
            // purchaseRequestToolStripMenuItem
            // 
            this.purchaseRequestToolStripMenuItem.Name = "purchaseRequestToolStripMenuItem";
            this.purchaseRequestToolStripMenuItem.Size = new System.Drawing.Size(112, 20);
            this.purchaseRequestToolStripMenuItem.Text = "Purchase Request";
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
            this.sendPurchaseRequestToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.sendPurchaseRequestToolStripMenuItem.Text = "Send Purchase Request";
            this.sendPurchaseRequestToolStripMenuItem.Click += new System.EventHandler(this.sendPurchaseRequestToolStripMenuItem_Click);
            // 
            // KitchenForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "KitchenForm";
            this.Text = "KitchenForm";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem requestToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cRUDRequestToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem purchaseRequestToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem recipeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cRUDRecipeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ingredientsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cRUDIngredientsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sendPurchaseRequestToolStripMenuItem;
    }
}