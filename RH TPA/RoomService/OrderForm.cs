using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RH_TPA.RoomService
{
    public partial class OrderForm : Form
    {
        OrderController oc = new OrderController();
        public OrderForm()
        {
            InitializeComponent();
            dataGridView1.DataSource = oc.loadHeader();
            dataGridView3.DataSource = oc.loadFood();
        }

        private void insertHeaderBtn_Click(object sender, EventArgs e)
        {
            int priority = int.Parse(priorityTxt.Text);
            string guestRoom = guestRoomTxt.Text;
            oc.addHeader(priority, guestRoom);
            orderIdLbl.Text = oc.currOrderId().ToString();
            dataGridView1.DataSource = oc.loadHeader();
        }

        private void insertDetailBtn_Click(object sender, EventArgs e)
        {
            int orderId = int.Parse(orderIdLbl.Text);
            string foodName = foodNameTxt.Text;
            int quantity = int.Parse(quantityTxt.Text);
            oc.addDetail(orderId, foodName, quantity);
            dataGridView2.DataSource = oc.loadDetail(orderId);
        }

        private void updateHeaderBtn_Click(object sender, EventArgs e)
        {
            int orderId = int.Parse(orderIdLbl.Text);
            int priority = int.Parse(priorityTxt.Text);
            string guestRoom = guestRoomTxt.Text;
            oc.updateHeader(orderId, priority, guestRoom);
            dataGridView1.DataSource = oc.loadHeader();
        }

        private void deleteHeaderBtn_Click(object sender, EventArgs e)
        {
            int orderId = int.Parse(orderIdLbl.Text);
            oc.deleteHeader(orderId);
            dataGridView1.DataSource = oc.loadHeader();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            orderIdLbl.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            priorityTxt.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            guestRoomTxt.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            dataGridView2.DataSource = oc.loadDetail(int.Parse(orderIdLbl.Text));
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            foodNameTxt.Text = dataGridView2.CurrentRow.Cells[0].Value.ToString();
            quantityTxt.Text = dataGridView2.CurrentRow.Cells[2].Value.ToString();
        }

        private void deleteDetailBtn_Click(object sender, EventArgs e)
        {
            int orderId = int.Parse(orderIdLbl.Text);
            string foodName = foodNameTxt.Text;
            oc.deleteDetail(orderId, foodName);
            dataGridView2.DataSource = oc.loadDetail(orderId);
        }

        private void notifyBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Success");
            dataGridView2.DataSource = null;
            orderIdLbl.Text = "-";
            priorityTxt.Text = "";
            guestRoomTxt.Text = "";
            foodNameTxt.Text = "";
            quantityTxt.Text = "";
        }
    }
}
