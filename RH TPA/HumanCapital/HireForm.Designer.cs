namespace RH_TPA.HumanCapital
{
    partial class HireForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.nameTxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gs1Btn = new System.Windows.Forms.Button();
            this.regBtn = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.canNameLbl = new System.Windows.Forms.Label();
            this.canIdLbl = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.gs2Btn = new System.Windows.Forms.Button();
            this.update1Btn = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.finBtn = new System.Windows.Forms.Button();
            this.update2Btn = new System.Windows.Forms.Button();
            this.canNameLbl1 = new System.Windows.Forms.Label();
            this.canIdLbl1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.nameTxt);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.gs1Btn);
            this.groupBox1.Controls.Add(this.regBtn);
            this.groupBox1.Location = new System.Drawing.Point(27, 38);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(236, 384);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Register Candidate";
            // 
            // nameTxt
            // 
            this.nameTxt.Location = new System.Drawing.Point(112, 150);
            this.nameTxt.Name = "nameTxt";
            this.nameTxt.Size = new System.Drawing.Size(100, 20);
            this.nameTxt.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 153);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Name";
            // 
            // gs1Btn
            // 
            this.gs1Btn.Location = new System.Drawing.Point(133, 331);
            this.gs1Btn.Name = "gs1Btn";
            this.gs1Btn.Size = new System.Drawing.Size(79, 30);
            this.gs1Btn.TabIndex = 1;
            this.gs1Btn.Text = "Goto Step 1";
            this.gs1Btn.UseVisualStyleBackColor = true;
            this.gs1Btn.Click += new System.EventHandler(this.gs1Btn_Click);
            // 
            // regBtn
            // 
            this.regBtn.Location = new System.Drawing.Point(31, 331);
            this.regBtn.Name = "regBtn";
            this.regBtn.Size = new System.Drawing.Size(79, 30);
            this.regBtn.TabIndex = 0;
            this.regBtn.Text = "Register";
            this.regBtn.UseVisualStyleBackColor = true;
            this.regBtn.Click += new System.EventHandler(this.regBtn_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.canNameLbl);
            this.groupBox2.Controls.Add(this.canIdLbl);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Controls.Add(this.gs2Btn);
            this.groupBox2.Controls.Add(this.update1Btn);
            this.groupBox2.Location = new System.Drawing.Point(292, 38);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(314, 384);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Step 1";
            // 
            // canNameLbl
            // 
            this.canNameLbl.AutoSize = true;
            this.canNameLbl.Location = new System.Drawing.Point(140, 241);
            this.canNameLbl.Name = "canNameLbl";
            this.canNameLbl.Size = new System.Drawing.Size(10, 13);
            this.canNameLbl.TabIndex = 7;
            this.canNameLbl.Text = "-";
            // 
            // canIdLbl
            // 
            this.canIdLbl.AutoSize = true;
            this.canIdLbl.Location = new System.Drawing.Point(140, 209);
            this.canIdLbl.Name = "canIdLbl";
            this.canIdLbl.Size = new System.Drawing.Size(10, 13);
            this.canIdLbl.TabIndex = 6;
            this.canIdLbl.Text = "-";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(39, 241);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Candidate Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 209);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Candidate ID";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(42, 20);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(240, 150);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // gs2Btn
            // 
            this.gs2Btn.Location = new System.Drawing.Point(180, 331);
            this.gs2Btn.Name = "gs2Btn";
            this.gs2Btn.Size = new System.Drawing.Size(79, 30);
            this.gs2Btn.TabIndex = 2;
            this.gs2Btn.Text = "Goto Step 2";
            this.gs2Btn.UseVisualStyleBackColor = true;
            this.gs2Btn.Click += new System.EventHandler(this.gs2Btn_Click);
            // 
            // update1Btn
            // 
            this.update1Btn.Location = new System.Drawing.Point(29, 331);
            this.update1Btn.Name = "update1Btn";
            this.update1Btn.Size = new System.Drawing.Size(79, 30);
            this.update1Btn.TabIndex = 2;
            this.update1Btn.Text = "Update";
            this.update1Btn.UseVisualStyleBackColor = true;
            this.update1Btn.Click += new System.EventHandler(this.update1Btn_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.canNameLbl1);
            this.groupBox3.Controls.Add(this.canIdLbl1);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.dataGridView2);
            this.groupBox3.Controls.Add(this.finBtn);
            this.groupBox3.Controls.Add(this.update2Btn);
            this.groupBox3.Location = new System.Drawing.Point(630, 38);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(314, 384);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Step 2";
            // 
            // finBtn
            // 
            this.finBtn.Location = new System.Drawing.Point(186, 331);
            this.finBtn.Name = "finBtn";
            this.finBtn.Size = new System.Drawing.Size(79, 30);
            this.finBtn.TabIndex = 3;
            this.finBtn.Text = "Finalize";
            this.finBtn.UseVisualStyleBackColor = true;
            this.finBtn.Click += new System.EventHandler(this.finBtn_Click);
            // 
            // update2Btn
            // 
            this.update2Btn.Location = new System.Drawing.Point(43, 331);
            this.update2Btn.Name = "update2Btn";
            this.update2Btn.Size = new System.Drawing.Size(79, 30);
            this.update2Btn.TabIndex = 2;
            this.update2Btn.Text = "Update";
            this.update2Btn.UseVisualStyleBackColor = true;
            this.update2Btn.Click += new System.EventHandler(this.update2Btn_Click);
            // 
            // canNameLbl1
            // 
            this.canNameLbl1.AutoSize = true;
            this.canNameLbl1.Location = new System.Drawing.Point(141, 241);
            this.canNameLbl1.Name = "canNameLbl1";
            this.canNameLbl1.Size = new System.Drawing.Size(10, 13);
            this.canNameLbl1.TabIndex = 12;
            this.canNameLbl1.Text = "-";
            // 
            // canIdLbl1
            // 
            this.canIdLbl1.AutoSize = true;
            this.canIdLbl1.Location = new System.Drawing.Point(141, 209);
            this.canIdLbl1.Name = "canIdLbl1";
            this.canIdLbl1.Size = new System.Drawing.Size(10, 13);
            this.canIdLbl1.TabIndex = 11;
            this.canIdLbl1.Text = "-";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(40, 241);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Candidate Name";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(40, 209);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "Candidate ID";
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(43, 20);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(240, 150);
            this.dataGridView2.TabIndex = 8;
            this.dataGridView2.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellClick);
            // 
            // HireForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(979, 450);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "HireForm";
            this.Text = "HireForm";
            this.Load += new System.EventHandler(this.HireForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button regBtn;
        private System.Windows.Forms.Button gs1Btn;
        private System.Windows.Forms.Button gs2Btn;
        private System.Windows.Forms.Button update1Btn;
        private System.Windows.Forms.Button finBtn;
        private System.Windows.Forms.Button update2Btn;
        private System.Windows.Forms.TextBox nameTxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label canIdLbl;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label canNameLbl;
        private System.Windows.Forms.Label canNameLbl1;
        private System.Windows.Forms.Label canIdLbl1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dataGridView2;
    }
}