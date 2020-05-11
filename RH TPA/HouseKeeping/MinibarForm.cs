using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace RH_TPA.HouseKeeping
{
    public partial class MinibarForm : Form
    {
        MinibarController mc = new MinibarController();
        public MinibarForm()
        {
            InitializeComponent();
            dataGridView1.DataSource = mc.loadData();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string itemName = textBox1.Text;
            int itemStock = int.Parse(textBox2.Text);
            int itemPrice = int.Parse(textBox3.Text);
            int itemMinimumStock = int.Parse(textBox4.Text);
            mc.addItem(itemName, itemStock, itemMinimumStock, itemPrice);
            dataGridView1.DataSource = mc.loadData();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            label5.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            textBox1.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            textBox2.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            textBox3.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            textBox4.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int itemId = int.Parse(label5.Text);
            string itemName = textBox1.Text;
            int itemStock = int.Parse(textBox2.Text);
            int itemPrice = int.Parse(textBox3.Text);
            int itemMinimumStock = int.Parse(textBox4.Text);
            mc.updateItem(itemId, itemName, itemStock, itemMinimumStock, itemPrice);
            dataGridView1.DataSource = mc.loadData();
            if(itemStock <= itemMinimumStock)
            {
                MessageBox.Show(itemName +" reached minimum stock");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int itemId = int.Parse(label5.Text);
            mc.deleteItem(itemId);
            dataGridView1.DataSource = mc.loadData();
        }

        private void deductionBtn_Click(object sender, EventArgs e)
        {
            string roomNumber = roomNumberTxt.Text;
            int deduction = int.Parse(deductionTxt.Text);
            mc.deduction(roomNumber, deduction);

        }
    }
}
