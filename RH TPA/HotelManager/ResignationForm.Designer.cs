namespace RH_TPA.HotelManager
{
    partial class ResignationForm
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
            this.submitBtn = new System.Windows.Forms.Button();
            this.idTxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rejectBtn = new System.Windows.Forms.Button();
            this.approveBtn = new System.Windows.Forms.Button();
            this.resIdLbl = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.submitBtn);
            this.groupBox1.Controls.Add(this.idTxt);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(41, 33);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(371, 384);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Submit Resignation";
            // 
            // submitBtn
            // 
            this.submitBtn.Location = new System.Drawing.Point(146, 290);
            this.submitBtn.Name = "submitBtn";
            this.submitBtn.Size = new System.Drawing.Size(87, 38);
            this.submitBtn.TabIndex = 4;
            this.submitBtn.Text = "Submit";
            this.submitBtn.UseVisualStyleBackColor = true;
            this.submitBtn.Click += new System.EventHandler(this.submitBtn_Click);
            // 
            // idTxt
            // 
            this.idTxt.Location = new System.Drawing.Point(155, 168);
            this.idTxt.Name = "idTxt";
            this.idTxt.Size = new System.Drawing.Size(115, 20);
            this.idTxt.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 214);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Resignation Date";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 168);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Staff ID";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rejectBtn);
            this.groupBox2.Controls.Add(this.approveBtn);
            this.groupBox2.Controls.Add(this.resIdLbl);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Location = new System.Drawing.Point(418, 33);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(371, 384);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Approve/Reject";
            // 
            // rejectBtn
            // 
            this.rejectBtn.Location = new System.Drawing.Point(185, 288);
            this.rejectBtn.Name = "rejectBtn";
            this.rejectBtn.Size = new System.Drawing.Size(88, 43);
            this.rejectBtn.TabIndex = 5;
            this.rejectBtn.Text = "Reject";
            this.rejectBtn.UseVisualStyleBackColor = true;
            this.rejectBtn.Click += new System.EventHandler(this.rejectBtn_Click);
            // 
            // approveBtn
            // 
            this.approveBtn.Location = new System.Drawing.Point(63, 288);
            this.approveBtn.Name = "approveBtn";
            this.approveBtn.Size = new System.Drawing.Size(88, 43);
            this.approveBtn.TabIndex = 4;
            this.approveBtn.Text = "Approve";
            this.approveBtn.UseVisualStyleBackColor = true;
            this.approveBtn.Click += new System.EventHandler(this.approveBtn_Click);
            // 
            // resIdLbl
            // 
            this.resIdLbl.AutoSize = true;
            this.resIdLbl.Location = new System.Drawing.Point(215, 215);
            this.resIdLbl.Name = "resIdLbl";
            this.resIdLbl.Size = new System.Drawing.Size(10, 13);
            this.resIdLbl.TabIndex = 3;
            this.resIdLbl.Text = "-";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(110, 215);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Resignation ID";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(56, 19);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(262, 174);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(155, 215);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(184, 20);
            this.dateTimePicker1.TabIndex = 5;
            // 
            // ResignationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "ResignationForm";
            this.Text = "ResignationForm";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button submitBtn;
        private System.Windows.Forms.TextBox idTxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label resIdLbl;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button rejectBtn;
        private System.Windows.Forms.Button approveBtn;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}