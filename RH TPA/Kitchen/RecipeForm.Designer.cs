namespace RH_TPA.Kitchen
{
    partial class RecipeForm
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
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dishQuantityTxt = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.foodQuantityTxt = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.dishNameCombo = new System.Windows.Forms.ComboBox();
            this.foodNameCombo = new System.Windows.Forms.ComboBox();
            this.ingredientCombo = new System.Windows.Forms.ComboBox();
            this.ingredientCombo1 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(61, 111);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(292, 178);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(446, 111);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(292, 178);
            this.dataGridView2.TabIndex = 1;
            this.dataGridView2.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(58, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Dish Recipe";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(443, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Food Recipe";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(57, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Dish Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(58, 334);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Ingredient Name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(58, 363);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Quantity";
            // 
            // dishQuantityTxt
            // 
            this.dishQuantityTxt.Location = new System.Drawing.Point(201, 360);
            this.dishQuantityTxt.Name = "dishQuantityTxt";
            this.dishQuantityTxt.Size = new System.Drawing.Size(121, 20);
            this.dishQuantityTxt.TabIndex = 9;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(452, 363);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Quantity";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(452, 334);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(85, 13);
            this.label8.TabIndex = 11;
            this.label8.Text = "Ingredient Name";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(443, 48);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(62, 13);
            this.label9.TabIndex = 10;
            this.label9.Text = "Food Name";
            // 
            // foodQuantityTxt
            // 
            this.foodQuantityTxt.Location = new System.Drawing.Point(595, 360);
            this.foodQuantityTxt.Name = "foodQuantityTxt";
            this.foodQuantityTxt.Size = new System.Drawing.Size(121, 20);
            this.foodQuantityTxt.TabIndex = 17;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(29, 404);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(88, 34);
            this.button1.TabIndex = 18;
            this.button1.Text = "Add Dish Recipe";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(124, 404);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(83, 34);
            this.button2.TabIndex = 19;
            this.button2.Text = "Update Dish Recipe";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(226, 404);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(85, 34);
            this.button3.TabIndex = 20;
            this.button3.Text = "Delete Dish Recipe";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(653, 404);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(85, 34);
            this.button4.TabIndex = 23;
            this.button4.Text = "Delete Food Recipe";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(551, 404);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(86, 34);
            this.button5.TabIndex = 22;
            this.button5.Text = "Update Food Recipe";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(456, 404);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(81, 34);
            this.button6.TabIndex = 21;
            this.button6.Text = "Add Food Recipe";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // dishNameCombo
            // 
            this.dishNameCombo.FormattingEnabled = true;
            this.dishNameCombo.Location = new System.Drawing.Point(200, 45);
            this.dishNameCombo.Name = "dishNameCombo";
            this.dishNameCombo.Size = new System.Drawing.Size(121, 21);
            this.dishNameCombo.TabIndex = 24;
            this.dishNameCombo.TextChanged += new System.EventHandler(this.dishNameCombo_TextChanged);
            // 
            // foodNameCombo
            // 
            this.foodNameCombo.FormattingEnabled = true;
            this.foodNameCombo.Location = new System.Drawing.Point(579, 45);
            this.foodNameCombo.Name = "foodNameCombo";
            this.foodNameCombo.Size = new System.Drawing.Size(121, 21);
            this.foodNameCombo.TabIndex = 25;
            this.foodNameCombo.TextChanged += new System.EventHandler(this.foodNameCombo_TextChanged);
            // 
            // ingredientCombo
            // 
            this.ingredientCombo.FormattingEnabled = true;
            this.ingredientCombo.Location = new System.Drawing.Point(201, 331);
            this.ingredientCombo.Name = "ingredientCombo";
            this.ingredientCombo.Size = new System.Drawing.Size(121, 21);
            this.ingredientCombo.TabIndex = 26;
            // 
            // ingredientCombo1
            // 
            this.ingredientCombo1.FormattingEnabled = true;
            this.ingredientCombo1.Location = new System.Drawing.Point(595, 331);
            this.ingredientCombo1.Name = "ingredientCombo1";
            this.ingredientCombo1.Size = new System.Drawing.Size(121, 21);
            this.ingredientCombo1.TabIndex = 27;
            // 
            // RecipeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ingredientCombo1);
            this.Controls.Add(this.ingredientCombo);
            this.Controls.Add(this.foodNameCombo);
            this.Controls.Add(this.dishNameCombo);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.foodQuantityTxt);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.dishQuantityTxt);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Name = "RecipeForm";
            this.Text = "RecipeForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox dishQuantityTxt;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox foodQuantityTxt;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.ComboBox dishNameCombo;
        private System.Windows.Forms.ComboBox foodNameCombo;
        private System.Windows.Forms.ComboBox ingredientCombo;
        private System.Windows.Forms.ComboBox ingredientCombo1;
    }
}