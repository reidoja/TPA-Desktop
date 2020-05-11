namespace RH_TPA.Purchasing
{
    partial class PurchaseRequestForm
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
            this.itemIdLbl = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.reasonTxt = new System.Windows.Forms.RichTextBox();
            this.acceptBtn = new System.Windows.Forms.Button();
            this.declineBtn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.v = new System.Windows.Forms.Label();
            this.itemNameLbl = new System.Windows.Forms.Label();
            this.itemPriceLbl = new System.Windows.Forms.Label();
            this.itemQuantityLbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(191, 29);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(422, 209);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(122, 271);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Item ID";
            // 
            // itemIdLbl
            // 
            this.itemIdLbl.AutoSize = true;
            this.itemIdLbl.Location = new System.Drawing.Point(212, 271);
            this.itemIdLbl.Name = "itemIdLbl";
            this.itemIdLbl.Size = new System.Drawing.Size(10, 13);
            this.itemIdLbl.TabIndex = 2;
            this.itemIdLbl.Text = "-";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(122, 304);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Item Name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(122, 402);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Reason";
            // 
            // reasonTxt
            // 
            this.reasonTxt.Location = new System.Drawing.Point(215, 402);
            this.reasonTxt.Name = "reasonTxt";
            this.reasonTxt.Size = new System.Drawing.Size(198, 120);
            this.reasonTxt.TabIndex = 10;
            this.reasonTxt.Text = "";
            // 
            // acceptBtn
            // 
            this.acceptBtn.Location = new System.Drawing.Point(610, 288);
            this.acceptBtn.Name = "acceptBtn";
            this.acceptBtn.Size = new System.Drawing.Size(78, 44);
            this.acceptBtn.TabIndex = 11;
            this.acceptBtn.Text = "Approve";
            this.acceptBtn.UseVisualStyleBackColor = true;
            this.acceptBtn.Click += new System.EventHandler(this.acceptBtn_Click);
            // 
            // declineBtn
            // 
            this.declineBtn.Location = new System.Drawing.Point(610, 366);
            this.declineBtn.Name = "declineBtn";
            this.declineBtn.Size = new System.Drawing.Size(78, 44);
            this.declineBtn.TabIndex = 12;
            this.declineBtn.Text = "Reject";
            this.declineBtn.UseVisualStyleBackColor = true;
            this.declineBtn.Click += new System.EventHandler(this.declineBtn_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(122, 336);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Item Price";
            // 
            // v
            // 
            this.v.AutoSize = true;
            this.v.Location = new System.Drawing.Point(122, 369);
            this.v.Name = "v";
            this.v.Size = new System.Drawing.Size(69, 13);
            this.v.TabIndex = 5;
            this.v.Text = "Item Quantity";
            // 
            // itemNameLbl
            // 
            this.itemNameLbl.AutoSize = true;
            this.itemNameLbl.Location = new System.Drawing.Point(212, 304);
            this.itemNameLbl.Name = "itemNameLbl";
            this.itemNameLbl.Size = new System.Drawing.Size(10, 13);
            this.itemNameLbl.TabIndex = 13;
            this.itemNameLbl.Text = "-";
            // 
            // itemPriceLbl
            // 
            this.itemPriceLbl.AutoSize = true;
            this.itemPriceLbl.Location = new System.Drawing.Point(212, 336);
            this.itemPriceLbl.Name = "itemPriceLbl";
            this.itemPriceLbl.Size = new System.Drawing.Size(10, 13);
            this.itemPriceLbl.TabIndex = 14;
            this.itemPriceLbl.Text = "-";
            // 
            // itemQuantityLbl
            // 
            this.itemQuantityLbl.AutoSize = true;
            this.itemQuantityLbl.Location = new System.Drawing.Point(212, 369);
            this.itemQuantityLbl.Name = "itemQuantityLbl";
            this.itemQuantityLbl.Size = new System.Drawing.Size(10, 13);
            this.itemQuantityLbl.TabIndex = 15;
            this.itemQuantityLbl.Text = "-";
            // 
            // PurchaseRequestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(808, 557);
            this.Controls.Add(this.itemQuantityLbl);
            this.Controls.Add(this.itemPriceLbl);
            this.Controls.Add(this.itemNameLbl);
            this.Controls.Add(this.declineBtn);
            this.Controls.Add(this.acceptBtn);
            this.Controls.Add(this.reasonTxt);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.v);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.itemIdLbl);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "PurchaseRequestForm";
            this.Text = "PurchaseRequestForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label itemIdLbl;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RichTextBox reasonTxt;
        private System.Windows.Forms.Button acceptBtn;
        private System.Windows.Forms.Button declineBtn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label v;
        private System.Windows.Forms.Label itemNameLbl;
        private System.Windows.Forms.Label itemPriceLbl;
        private System.Windows.Forms.Label itemQuantityLbl;
    }
}