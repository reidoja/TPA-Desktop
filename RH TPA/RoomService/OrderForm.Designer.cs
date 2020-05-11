namespace RH_TPA.RoomService
{
    partial class OrderForm
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.guestRoomTxt = new System.Windows.Forms.TextBox();
            this.foodNameTxt = new System.Windows.Forms.TextBox();
            this.quantityTxt = new System.Windows.Forms.TextBox();
            this.priorityTxt = new System.Windows.Forms.TextBox();
            this.insertDetailBtn = new System.Windows.Forms.Button();
            this.deleteDetailBtn = new System.Windows.Forms.Button();
            this.insertHeaderBtn = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.notifyBtn = new System.Windows.Forms.Button();
            this.updateHeaderBtn = new System.Windows.Forms.Button();
            this.deleteHeaderBtn = new System.Windows.Forms.Button();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.orderIdLbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 47);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(353, 172);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(474, 462);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Food Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(79, 528);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Guest Room";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(474, 488);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Quantity";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(78, 500);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Priority";
            // 
            // guestRoomTxt
            // 
            this.guestRoomTxt.Location = new System.Drawing.Point(192, 525);
            this.guestRoomTxt.Name = "guestRoomTxt";
            this.guestRoomTxt.Size = new System.Drawing.Size(100, 20);
            this.guestRoomTxt.TabIndex = 7;
            // 
            // foodNameTxt
            // 
            this.foodNameTxt.Location = new System.Drawing.Point(587, 459);
            this.foodNameTxt.Name = "foodNameTxt";
            this.foodNameTxt.Size = new System.Drawing.Size(100, 20);
            this.foodNameTxt.TabIndex = 8;
            // 
            // quantityTxt
            // 
            this.quantityTxt.Location = new System.Drawing.Point(587, 485);
            this.quantityTxt.Name = "quantityTxt";
            this.quantityTxt.Size = new System.Drawing.Size(100, 20);
            this.quantityTxt.TabIndex = 9;
            // 
            // priorityTxt
            // 
            this.priorityTxt.Location = new System.Drawing.Point(192, 497);
            this.priorityTxt.Name = "priorityTxt";
            this.priorityTxt.Size = new System.Drawing.Size(100, 20);
            this.priorityTxt.TabIndex = 10;
            // 
            // insertDetailBtn
            // 
            this.insertDetailBtn.Location = new System.Drawing.Point(477, 525);
            this.insertDetailBtn.Name = "insertDetailBtn";
            this.insertDetailBtn.Size = new System.Drawing.Size(86, 26);
            this.insertDetailBtn.TabIndex = 11;
            this.insertDetailBtn.Text = "Insert Detail";
            this.insertDetailBtn.UseVisualStyleBackColor = true;
            this.insertDetailBtn.Click += new System.EventHandler(this.insertDetailBtn_Click);
            // 
            // deleteDetailBtn
            // 
            this.deleteDetailBtn.Location = new System.Drawing.Point(601, 525);
            this.deleteDetailBtn.Name = "deleteDetailBtn";
            this.deleteDetailBtn.Size = new System.Drawing.Size(86, 26);
            this.deleteDetailBtn.TabIndex = 13;
            this.deleteDetailBtn.Text = "Delete Detail";
            this.deleteDetailBtn.UseVisualStyleBackColor = true;
            this.deleteDetailBtn.Click += new System.EventHandler(this.deleteDetailBtn_Click);
            // 
            // insertHeaderBtn
            // 
            this.insertHeaderBtn.Location = new System.Drawing.Point(57, 578);
            this.insertHeaderBtn.Name = "insertHeaderBtn";
            this.insertHeaderBtn.Size = new System.Drawing.Size(101, 26);
            this.insertHeaderBtn.TabIndex = 14;
            this.insertHeaderBtn.Text = "Insert Header";
            this.insertHeaderBtn.UseVisualStyleBackColor = true;
            this.insertHeaderBtn.Click += new System.EventHandler(this.insertHeaderBtn_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(389, 47);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(353, 172);
            this.dataGridView2.TabIndex = 15;
            this.dataGridView2.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellClick);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(25, 21);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(101, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Header Transaction";
            // 
            // notifyBtn
            // 
            this.notifyBtn.Location = new System.Drawing.Point(465, 578);
            this.notifyBtn.Name = "notifyBtn";
            this.notifyBtn.Size = new System.Drawing.Size(222, 26);
            this.notifyBtn.TabIndex = 17;
            this.notifyBtn.Text = "Notify Kitchen";
            this.notifyBtn.UseVisualStyleBackColor = true;
            this.notifyBtn.Click += new System.EventHandler(this.notifyBtn_Click);
            // 
            // updateHeaderBtn
            // 
            this.updateHeaderBtn.Location = new System.Drawing.Point(174, 578);
            this.updateHeaderBtn.Name = "updateHeaderBtn";
            this.updateHeaderBtn.Size = new System.Drawing.Size(101, 26);
            this.updateHeaderBtn.TabIndex = 18;
            this.updateHeaderBtn.Text = "Update Header";
            this.updateHeaderBtn.UseVisualStyleBackColor = true;
            this.updateHeaderBtn.Click += new System.EventHandler(this.updateHeaderBtn_Click);
            // 
            // deleteHeaderBtn
            // 
            this.deleteHeaderBtn.Location = new System.Drawing.Point(292, 578);
            this.deleteHeaderBtn.Name = "deleteHeaderBtn";
            this.deleteHeaderBtn.Size = new System.Drawing.Size(101, 26);
            this.deleteHeaderBtn.TabIndex = 19;
            this.deleteHeaderBtn.Text = "Delete Header";
            this.deleteHeaderBtn.UseVisualStyleBackColor = true;
            this.deleteHeaderBtn.Click += new System.EventHandler(this.deleteHeaderBtn_Click);
            // 
            // dataGridView3
            // 
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Location = new System.Drawing.Point(229, 267);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.Size = new System.Drawing.Size(324, 170);
            this.dataGridView3.TabIndex = 20;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(355, 242);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 13);
            this.label7.TabIndex = 21;
            this.label7.Text = "List Food";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(386, 24);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(45, 13);
            this.label8.TabIndex = 22;
            this.label8.Text = "Order Id";
            // 
            // orderIdLbl
            // 
            this.orderIdLbl.AutoSize = true;
            this.orderIdLbl.Location = new System.Drawing.Point(496, 21);
            this.orderIdLbl.Name = "orderIdLbl";
            this.orderIdLbl.Size = new System.Drawing.Size(10, 13);
            this.orderIdLbl.TabIndex = 25;
            this.orderIdLbl.Text = "-";
            // 
            // OrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(773, 647);
            this.Controls.Add(this.orderIdLbl);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dataGridView3);
            this.Controls.Add(this.deleteHeaderBtn);
            this.Controls.Add(this.updateHeaderBtn);
            this.Controls.Add(this.notifyBtn);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.insertHeaderBtn);
            this.Controls.Add(this.deleteDetailBtn);
            this.Controls.Add(this.insertDetailBtn);
            this.Controls.Add(this.priorityTxt);
            this.Controls.Add(this.quantityTxt);
            this.Controls.Add(this.foodNameTxt);
            this.Controls.Add(this.guestRoomTxt);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView1);
            this.Name = "OrderForm";
            this.Text = "OrderForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox guestRoomTxt;
        private System.Windows.Forms.TextBox foodNameTxt;
        private System.Windows.Forms.TextBox quantityTxt;
        private System.Windows.Forms.TextBox priorityTxt;
        private System.Windows.Forms.Button insertDetailBtn;
        private System.Windows.Forms.Button deleteDetailBtn;
        private System.Windows.Forms.Button insertHeaderBtn;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button notifyBtn;
        private System.Windows.Forms.Button updateHeaderBtn;
        private System.Windows.Forms.Button deleteHeaderBtn;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label orderIdLbl;
    }
}