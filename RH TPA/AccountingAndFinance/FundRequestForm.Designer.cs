namespace RH_TPA.AccountingAndFinance
{
    partial class FundRequestForm
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
            this.fundIdLbl = new System.Windows.Forms.Label();
            this.itemNameLbl = new System.Windows.Forms.Label();
            this.priceLbl = new System.Windows.Forms.Label();
            this.approveBtn = new System.Windows.Forms.Button();
            this.refuseBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(199, 41);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(388, 187);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(114, 275);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Fund ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(114, 310);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Item Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(114, 348);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Price";
            // 
            // fundIdLbl
            // 
            this.fundIdLbl.AutoSize = true;
            this.fundIdLbl.Location = new System.Drawing.Point(255, 275);
            this.fundIdLbl.Name = "fundIdLbl";
            this.fundIdLbl.Size = new System.Drawing.Size(10, 13);
            this.fundIdLbl.TabIndex = 4;
            this.fundIdLbl.Text = "-";
            // 
            // itemNameLbl
            // 
            this.itemNameLbl.AutoSize = true;
            this.itemNameLbl.Location = new System.Drawing.Point(255, 310);
            this.itemNameLbl.Name = "itemNameLbl";
            this.itemNameLbl.Size = new System.Drawing.Size(10, 13);
            this.itemNameLbl.TabIndex = 5;
            this.itemNameLbl.Text = "-";
            // 
            // priceLbl
            // 
            this.priceLbl.AutoSize = true;
            this.priceLbl.Location = new System.Drawing.Point(255, 348);
            this.priceLbl.Name = "priceLbl";
            this.priceLbl.Size = new System.Drawing.Size(10, 13);
            this.priceLbl.TabIndex = 6;
            this.priceLbl.Text = "-";
            // 
            // approveBtn
            // 
            this.approveBtn.Location = new System.Drawing.Point(538, 270);
            this.approveBtn.Name = "approveBtn";
            this.approveBtn.Size = new System.Drawing.Size(70, 42);
            this.approveBtn.TabIndex = 7;
            this.approveBtn.Text = "Approve";
            this.approveBtn.UseVisualStyleBackColor = true;
            this.approveBtn.Click += new System.EventHandler(this.approveBtn_Click);
            // 
            // refuseBtn
            // 
            this.refuseBtn.Location = new System.Drawing.Point(538, 338);
            this.refuseBtn.Name = "refuseBtn";
            this.refuseBtn.Size = new System.Drawing.Size(70, 41);
            this.refuseBtn.TabIndex = 8;
            this.refuseBtn.Text = "Refuse";
            this.refuseBtn.UseVisualStyleBackColor = true;
            this.refuseBtn.Click += new System.EventHandler(this.refuseBtn_Click);
            // 
            // FundRequestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.refuseBtn);
            this.Controls.Add(this.approveBtn);
            this.Controls.Add(this.priceLbl);
            this.Controls.Add(this.itemNameLbl);
            this.Controls.Add(this.fundIdLbl);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FundRequestForm";
            this.Text = "FundRequestForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label fundIdLbl;
        private System.Windows.Forms.Label itemNameLbl;
        private System.Windows.Forms.Label priceLbl;
        private System.Windows.Forms.Button approveBtn;
        private System.Windows.Forms.Button refuseBtn;
    }
}