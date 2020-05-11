namespace RH_TPA.Kitchen
{
    partial class IngredientForm
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.ingredientIdLbl = new System.Windows.Forms.Label();
            this.ingredientNameTxt = new System.Windows.Forms.TextBox();
            this.ingredientStockTxt = new System.Windows.Forms.TextBox();
            this.ingredientPriceTxt = new System.Windows.Forms.TextBox();
            this.ingredientMinimumStockTxt = new System.Windows.Forms.TextBox();
            this.addBtn = new System.Windows.Forms.Button();
            this.updateBtn = new System.Windows.Forms.Button();
            this.deleteBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(194, 49);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(477, 216);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(108, 294);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ingredient ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(108, 322);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ingredient Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(108, 350);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Ingredient Stock";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(108, 377);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Ingredient Price";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(108, 403);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(129, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Ingredient Minimum Stock";
            // 
            // ingredientIdLbl
            // 
            this.ingredientIdLbl.AutoSize = true;
            this.ingredientIdLbl.Location = new System.Drawing.Point(268, 294);
            this.ingredientIdLbl.Name = "ingredientIdLbl";
            this.ingredientIdLbl.Size = new System.Drawing.Size(10, 13);
            this.ingredientIdLbl.TabIndex = 6;
            this.ingredientIdLbl.Text = "-";
            // 
            // ingredientNameTxt
            // 
            this.ingredientNameTxt.Location = new System.Drawing.Point(271, 319);
            this.ingredientNameTxt.Name = "ingredientNameTxt";
            this.ingredientNameTxt.Size = new System.Drawing.Size(100, 20);
            this.ingredientNameTxt.TabIndex = 7;
            // 
            // ingredientStockTxt
            // 
            this.ingredientStockTxt.Location = new System.Drawing.Point(271, 347);
            this.ingredientStockTxt.Name = "ingredientStockTxt";
            this.ingredientStockTxt.Size = new System.Drawing.Size(100, 20);
            this.ingredientStockTxt.TabIndex = 8;
            // 
            // ingredientPriceTxt
            // 
            this.ingredientPriceTxt.Location = new System.Drawing.Point(271, 374);
            this.ingredientPriceTxt.Name = "ingredientPriceTxt";
            this.ingredientPriceTxt.Size = new System.Drawing.Size(100, 20);
            this.ingredientPriceTxt.TabIndex = 9;
            // 
            // ingredientMinimumStockTxt
            // 
            this.ingredientMinimumStockTxt.Location = new System.Drawing.Point(271, 400);
            this.ingredientMinimumStockTxt.Name = "ingredientMinimumStockTxt";
            this.ingredientMinimumStockTxt.Size = new System.Drawing.Size(100, 20);
            this.ingredientMinimumStockTxt.TabIndex = 10;
            // 
            // addBtn
            // 
            this.addBtn.Location = new System.Drawing.Point(610, 289);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(76, 27);
            this.addBtn.TabIndex = 11;
            this.addBtn.Text = "Add";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // updateBtn
            // 
            this.updateBtn.Location = new System.Drawing.Point(610, 340);
            this.updateBtn.Name = "updateBtn";
            this.updateBtn.Size = new System.Drawing.Size(76, 27);
            this.updateBtn.TabIndex = 12;
            this.updateBtn.Text = "Update";
            this.updateBtn.UseVisualStyleBackColor = true;
            this.updateBtn.Click += new System.EventHandler(this.updateBtn_Click);
            // 
            // deleteBtn
            // 
            this.deleteBtn.Location = new System.Drawing.Point(610, 393);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(76, 27);
            this.deleteBtn.TabIndex = 13;
            this.deleteBtn.Text = "Delete";
            this.deleteBtn.UseVisualStyleBackColor = true;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // IngredientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.deleteBtn);
            this.Controls.Add(this.updateBtn);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.ingredientMinimumStockTxt);
            this.Controls.Add(this.ingredientPriceTxt);
            this.Controls.Add(this.ingredientStockTxt);
            this.Controls.Add(this.ingredientNameTxt);
            this.Controls.Add(this.ingredientIdLbl);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "IngredientForm";
            this.Text = "IngredientForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label ingredientIdLbl;
        private System.Windows.Forms.TextBox ingredientNameTxt;
        private System.Windows.Forms.TextBox ingredientStockTxt;
        private System.Windows.Forms.TextBox ingredientPriceTxt;
        private System.Windows.Forms.TextBox ingredientMinimumStockTxt;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.Button updateBtn;
        private System.Windows.Forms.Button deleteBtn;
    }
}