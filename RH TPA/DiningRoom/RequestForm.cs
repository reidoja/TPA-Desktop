using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RH_TPA.DiningRoom
{
    public partial class RequestForm : Form
    {

        DishesRequestController drc = new DishesRequestController();

        public RequestForm()
        {
            InitializeComponent();
            dataGridView1.DataSource = drc.loadData();
            dataGridView2.DataSource = drc.loadAvailable();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string dishName = textBox1.Text;
            int quantity = int.Parse(textBox2.Text);
            drc.addRequest(dishName, quantity);
            dataGridView1.DataSource = drc.loadData();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int requestId = int.Parse(reqIdLbl.Text);
            string dishName = textBox1.Text;
            int quantity = int.Parse(textBox2.Text);
            drc.updateRequest(requestId, dishName, quantity);
            dataGridView1.DataSource = drc.loadData();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int requestId = int.Parse(reqIdLbl.Text);
            drc.deleteRequest(requestId);
            dataGridView1.DataSource = drc.loadData();

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            reqIdLbl.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            textBox1.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            textBox2.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
        }
    }
}
