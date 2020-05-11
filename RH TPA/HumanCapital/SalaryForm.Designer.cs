namespace RH_TPA.HumanCapital
{
    partial class SalaryForm
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
            this.staffIdLbl = new System.Windows.Forms.Label();
            this.raiseTxt = new System.Windows.Forms.TextBox();
            this.staffNameLbl = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.salaryLbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(54, 53);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(278, 181);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(58, 283);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Staff ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(59, 316);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Staff Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(58, 350);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Staff Salary";
            // 
            // staffIdLbl
            // 
            this.staffIdLbl.AutoSize = true;
            this.staffIdLbl.Location = new System.Drawing.Point(151, 283);
            this.staffIdLbl.Name = "staffIdLbl";
            this.staffIdLbl.Size = new System.Drawing.Size(10, 13);
            this.staffIdLbl.TabIndex = 4;
            this.staffIdLbl.Text = "-";
            this.staffIdLbl.TextChanged += new System.EventHandler(this.staffIdLbl_TextChanged);
            // 
            // raiseTxt
            // 
            this.raiseTxt.Location = new System.Drawing.Point(154, 379);
            this.raiseTxt.Name = "raiseTxt";
            this.raiseTxt.Size = new System.Drawing.Size(100, 20);
            this.raiseTxt.TabIndex = 6;
            // 
            // staffNameLbl
            // 
            this.staffNameLbl.AutoSize = true;
            this.staffNameLbl.Location = new System.Drawing.Point(151, 316);
            this.staffNameLbl.Name = "staffNameLbl";
            this.staffNameLbl.Size = new System.Drawing.Size(10, 13);
            this.staffNameLbl.TabIndex = 7;
            this.staffNameLbl.Text = "-";
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(405, 53);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(278, 181);
            this.dataGridView2.TabIndex = 8;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(405, 283);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(85, 67);
            this.button1.TabIndex = 9;
            this.button1.Text = "Request Raise";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(550, 283);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(85, 67);
            this.button2.TabIndex = 10;
            this.button2.Text = "Update and Send Fund Request";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(402, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Approval Raise ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(59, 386);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Raise";
            // 
            // salaryLbl
            // 
            this.salaryLbl.AutoSize = true;
            this.salaryLbl.Location = new System.Drawing.Point(151, 350);
            this.salaryLbl.Name = "salaryLbl";
            this.salaryLbl.Size = new System.Drawing.Size(10, 13);
            this.salaryLbl.TabIndex = 13;
            this.salaryLbl.Text = "-";
            // 
            // SalaryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.salaryLbl);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.staffNameLbl);
            this.Controls.Add(this.raiseTxt);
            this.Controls.Add(this.staffIdLbl);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "SalaryForm";
            this.Text = "SalaryForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label staffIdLbl;
        private System.Windows.Forms.TextBox raiseTxt;
        private System.Windows.Forms.Label staffNameLbl;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label salaryLbl;
    }
}