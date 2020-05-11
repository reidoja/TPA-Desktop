namespace RH_TPA.Kitchen
{
    partial class CookRequestForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dishRequestIdLbl = new System.Windows.Forms.Label();
            this.dishNameTxt = new System.Windows.Forms.TextBox();
            this.dishQuantityTxt = new System.Windows.Forms.TextBox();
            this.updateDish = new System.Windows.Forms.Button();
            this.deleteDish = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.orderRequestIdlLbl = new System.Windows.Forms.Label();
            this.deleteOrderRequest = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(137, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Dishes Request";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(447, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Food Request";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(66, 69);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(268, 226);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(386, 79);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(320, 100);
            this.dataGridView2.TabIndex = 3;
            this.dataGridView2.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellClick);
            // 
            // dataGridView3
            // 
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Location = new System.Drawing.Point(386, 211);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.Size = new System.Drawing.Size(320, 101);
            this.dataGridView3.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(63, 332);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Dish Request Id";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(63, 365);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Dish Name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(63, 401);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Dish Quantity";
            // 
            // dishRequestIdLbl
            // 
            this.dishRequestIdLbl.AutoSize = true;
            this.dishRequestIdLbl.Location = new System.Drawing.Point(207, 332);
            this.dishRequestIdLbl.Name = "dishRequestIdLbl";
            this.dishRequestIdLbl.Size = new System.Drawing.Size(10, 13);
            this.dishRequestIdLbl.TabIndex = 8;
            this.dishRequestIdLbl.Text = "-";
            // 
            // dishNameTxt
            // 
            this.dishNameTxt.Location = new System.Drawing.Point(210, 362);
            this.dishNameTxt.Name = "dishNameTxt";
            this.dishNameTxt.Size = new System.Drawing.Size(100, 20);
            this.dishNameTxt.TabIndex = 9;
            // 
            // dishQuantityTxt
            // 
            this.dishQuantityTxt.Location = new System.Drawing.Point(210, 398);
            this.dishQuantityTxt.Name = "dishQuantityTxt";
            this.dishQuantityTxt.Size = new System.Drawing.Size(100, 20);
            this.dishQuantityTxt.TabIndex = 10;
            // 
            // updateDish
            // 
            this.updateDish.Location = new System.Drawing.Point(71, 463);
            this.updateDish.Name = "updateDish";
            this.updateDish.Size = new System.Drawing.Size(75, 23);
            this.updateDish.TabIndex = 11;
            this.updateDish.Text = "Update";
            this.updateDish.UseVisualStyleBackColor = true;
            this.updateDish.Click += new System.EventHandler(this.updateDish_Click);
            // 
            // deleteDish
            // 
            this.deleteDish.Location = new System.Drawing.Point(210, 463);
            this.deleteDish.Name = "deleteDish";
            this.deleteDish.Size = new System.Drawing.Size(75, 23);
            this.deleteDish.TabIndex = 12;
            this.deleteDish.Text = "Delete";
            this.deleteDish.UseVisualStyleBackColor = true;
            this.deleteDish.Click += new System.EventHandler(this.deleteDish_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(447, 352);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Order Request Id";
            // 
            // orderRequestIdlLbl
            // 
            this.orderRequestIdlLbl.AutoSize = true;
            this.orderRequestIdlLbl.Location = new System.Drawing.Point(568, 352);
            this.orderRequestIdlLbl.Name = "orderRequestIdlLbl";
            this.orderRequestIdlLbl.Size = new System.Drawing.Size(10, 13);
            this.orderRequestIdlLbl.TabIndex = 14;
            this.orderRequestIdlLbl.Text = "-";
            // 
            // deleteOrderRequest
            // 
            this.deleteOrderRequest.Location = new System.Drawing.Point(490, 401);
            this.deleteOrderRequest.Name = "deleteOrderRequest";
            this.deleteOrderRequest.Size = new System.Drawing.Size(75, 23);
            this.deleteOrderRequest.TabIndex = 15;
            this.deleteOrderRequest.Text = "Delete";
            this.deleteOrderRequest.UseVisualStyleBackColor = true;
            this.deleteOrderRequest.Click += new System.EventHandler(this.deleteOrderRequest_Click);
            // 
            // CookRequestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(793, 515);
            this.Controls.Add(this.deleteOrderRequest);
            this.Controls.Add(this.orderRequestIdlLbl);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.deleteDish);
            this.Controls.Add(this.updateDish);
            this.Controls.Add(this.dishQuantityTxt);
            this.Controls.Add(this.dishNameTxt);
            this.Controls.Add(this.dishRequestIdLbl);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dataGridView3);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "CookRequestForm";
            this.Text = "CookRequestForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label dishRequestIdLbl;
        private System.Windows.Forms.TextBox dishNameTxt;
        private System.Windows.Forms.TextBox dishQuantityTxt;
        private System.Windows.Forms.Button updateDish;
        private System.Windows.Forms.Button deleteDish;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label orderRequestIdlLbl;
        private System.Windows.Forms.Button deleteOrderRequest;
    }
}