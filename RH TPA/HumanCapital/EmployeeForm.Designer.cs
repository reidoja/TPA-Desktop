namespace RH_TPA.HumanCapital
{
    partial class EmployeeForm
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
            this.nameTxt = new System.Windows.Forms.TextBox();
            this.passwordTxt = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.idLbl = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.salaryTxt = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.label8 = new System.Windows.Forms.Label();
            this.canIdLbl = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.evIdLbl = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.dataGridView4 = new System.Windows.Forms.DataGridView();
            this.label9 = new System.Windows.Forms.Label();
            this.resignationIdLbl = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(30, 52);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(323, 180);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 270);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Staff ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 297);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Staff Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 329);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Staff Password";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 364);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Staff Salary";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 398);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Staff Position";
            // 
            // nameTxt
            // 
            this.nameTxt.Location = new System.Drawing.Point(132, 294);
            this.nameTxt.Name = "nameTxt";
            this.nameTxt.Size = new System.Drawing.Size(121, 20);
            this.nameTxt.TabIndex = 6;
            // 
            // passwordTxt
            // 
            this.passwordTxt.Location = new System.Drawing.Point(132, 326);
            this.passwordTxt.Name = "passwordTxt";
            this.passwordTxt.Size = new System.Drawing.Size(121, 20);
            this.passwordTxt.TabIndex = 7;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Receptionist",
            "HouseKeeping",
            "DiningRoom",
            "Kitchen",
            "Purchasing",
            "AccountingAndFinance",
            "SalesAndMarketing",
            "HumanCapital",
            "HotelManager"});
            this.comboBox1.Location = new System.Drawing.Point(132, 395);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 8;
            // 
            // idLbl
            // 
            this.idLbl.AutoSize = true;
            this.idLbl.Location = new System.Drawing.Point(129, 270);
            this.idLbl.Name = "idLbl";
            this.idLbl.Size = new System.Drawing.Size(10, 13);
            this.idLbl.TabIndex = 9;
            this.idLbl.Text = "-";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(299, 283);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(69, 40);
            this.button1.TabIndex = 11;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(299, 338);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(69, 40);
            this.button2.TabIndex = 12;
            this.button2.Text = "Update";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(299, 393);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(69, 40);
            this.button3.TabIndex = 13;
            this.button3.Text = "Delete";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // salaryTxt
            // 
            this.salaryTxt.Location = new System.Drawing.Point(132, 361);
            this.salaryTxt.Name = "salaryTxt";
            this.salaryTxt.Size = new System.Drawing.Size(121, 20);
            this.salaryTxt.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(27, 21);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Staff";
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(371, 52);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(220, 180);
            this.dataGridView2.TabIndex = 16;
            this.dataGridView2.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellClick);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(368, 21);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(93, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "Passed Candidate";
            // 
            // dataGridView3
            // 
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Location = new System.Drawing.Point(610, 52);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.Size = new System.Drawing.Size(220, 180);
            this.dataGridView3.TabIndex = 18;
            this.dataGridView3.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView3_CellClick);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(607, 21);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(73, 13);
            this.label8.TabIndex = 19;
            this.label8.Text = "Approved Fire";
            // 
            // canIdLbl
            // 
            this.canIdLbl.AutoSize = true;
            this.canIdLbl.Location = new System.Drawing.Point(528, 265);
            this.canIdLbl.Name = "canIdLbl";
            this.canIdLbl.Size = new System.Drawing.Size(10, 13);
            this.canIdLbl.TabIndex = 21;
            this.canIdLbl.Text = "-";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(418, 265);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(69, 13);
            this.label10.TabIndex = 20;
            this.label10.Text = "Candidate ID";
            // 
            // evIdLbl
            // 
            this.evIdLbl.AutoSize = true;
            this.evIdLbl.Location = new System.Drawing.Point(768, 265);
            this.evIdLbl.Name = "evIdLbl";
            this.evIdLbl.Size = new System.Drawing.Size(10, 13);
            this.evIdLbl.TabIndex = 23;
            this.evIdLbl.Text = "-";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(658, 265);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(66, 13);
            this.label11.TabIndex = 22;
            this.label11.Text = "Evidence ID";
            // 
            // dataGridView4
            // 
            this.dataGridView4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView4.Location = new System.Drawing.Point(856, 52);
            this.dataGridView4.Name = "dataGridView4";
            this.dataGridView4.Size = new System.Drawing.Size(220, 180);
            this.dataGridView4.TabIndex = 24;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(853, 21);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(112, 13);
            this.label9.TabIndex = 25;
            this.label9.Text = "Approved Resignation";
            // 
            // resignationIdLbl
            // 
            this.resignationIdLbl.AutoSize = true;
            this.resignationIdLbl.Location = new System.Drawing.Point(979, 265);
            this.resignationIdLbl.Name = "resignationIdLbl";
            this.resignationIdLbl.Size = new System.Drawing.Size(10, 13);
            this.resignationIdLbl.TabIndex = 27;
            this.resignationIdLbl.Text = "-";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(869, 265);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(77, 13);
            this.label13.TabIndex = 26;
            this.label13.Text = "Resignation ID";
            // 
            // EmployeeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1110, 450);
            this.Controls.Add(this.resignationIdLbl);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.dataGridView4);
            this.Controls.Add(this.evIdLbl);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.canIdLbl);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dataGridView3);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.salaryTxt);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.idLbl);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.passwordTxt);
            this.Controls.Add(this.nameTxt);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "EmployeeForm";
            this.Text = "EmployeeForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).EndInit();
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
        private System.Windows.Forms.TextBox nameTxt;
        private System.Windows.Forms.TextBox passwordTxt;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label idLbl;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox salaryTxt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label canIdLbl;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label evIdLbl;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DataGridView dataGridView4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label resignationIdLbl;
        private System.Windows.Forms.Label label13;
    }
}