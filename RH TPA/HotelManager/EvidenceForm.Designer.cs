namespace RH_TPA.HotelManager
{
    partial class EvidenceForm
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
            this.staffIdLbl = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.approveBtn = new System.Windows.Forms.Button();
            this.refuseBtn = new System.Windows.Forms.Button();
            this.evIdLbl = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(228, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(368, 219);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(135, 286);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Staff ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(135, 323);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Evidence Text";
            // 
            // staffIdLbl
            // 
            this.staffIdLbl.AutoSize = true;
            this.staffIdLbl.Location = new System.Drawing.Point(235, 286);
            this.staffIdLbl.Name = "staffIdLbl";
            this.staffIdLbl.Size = new System.Drawing.Size(10, 13);
            this.staffIdLbl.TabIndex = 3;
            this.staffIdLbl.Text = "-";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(238, 320);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(197, 96);
            this.richTextBox1.TabIndex = 4;
            this.richTextBox1.Text = "";
            // 
            // approveBtn
            // 
            this.approveBtn.Location = new System.Drawing.Point(521, 297);
            this.approveBtn.Name = "approveBtn";
            this.approveBtn.Size = new System.Drawing.Size(75, 39);
            this.approveBtn.TabIndex = 5;
            this.approveBtn.Text = "Approve";
            this.approveBtn.UseVisualStyleBackColor = true;
            this.approveBtn.Click += new System.EventHandler(this.approveBtn_Click);
            // 
            // refuseBtn
            // 
            this.refuseBtn.Location = new System.Drawing.Point(521, 360);
            this.refuseBtn.Name = "refuseBtn";
            this.refuseBtn.Size = new System.Drawing.Size(75, 39);
            this.refuseBtn.TabIndex = 6;
            this.refuseBtn.Text = "Refuse";
            this.refuseBtn.UseVisualStyleBackColor = true;
            this.refuseBtn.Click += new System.EventHandler(this.refuseBtn_Click);
            // 
            // evIdLbl
            // 
            this.evIdLbl.AutoSize = true;
            this.evIdLbl.Location = new System.Drawing.Point(235, 253);
            this.evIdLbl.Name = "evIdLbl";
            this.evIdLbl.Size = new System.Drawing.Size(10, 13);
            this.evIdLbl.TabIndex = 8;
            this.evIdLbl.Text = "-";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(135, 253);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Evidence ID";
            // 
            // EvidenceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.evIdLbl);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.refuseBtn);
            this.Controls.Add(this.approveBtn);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.staffIdLbl);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "EvidenceForm";
            this.Text = "EvidenceForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label staffIdLbl;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button approveBtn;
        private System.Windows.Forms.Button refuseBtn;
        private System.Windows.Forms.Label evIdLbl;
        private System.Windows.Forms.Label label4;
    }
}