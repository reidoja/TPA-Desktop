using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RH_TPA.Kitchen
{
    public partial class CookRequestForm : Form
    {

        CookRequestController crc = new CookRequestController();

        public CookRequestForm()
        {
            InitializeComponent();
            dataGridView1.DataSource = crc.loadDishesRequest();
            dataGridView2.DataSource = crc.loadOrderHeaderRequest();
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int orderId = int.Parse(dataGridView2.CurrentRow.Cells[0].Value.ToString());
            dataGridView3.DataSource = crc.loadOrderDetailRequest(orderId);
        }

        private void updateDish_Click(object sender, EventArgs e)
        {
            int dishRequestId = int.Parse(dishRequestIdLbl.Text);
            string dishName = dishNameTxt.Text;
            int dishQuantity = int.Parse(dishQuantityTxt.Text);
            crc.updateDishesRequest(dishRequestId, dishName, dishQuantity);
            dataGridView1.DataSource = crc.loadDishesRequest();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dishRequestIdLbl.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            dishNameTxt.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            dishQuantityTxt.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
        }

        private void deleteDish_Click(object sender, EventArgs e)
        {
            int dishRequestId = int.Parse(dishRequestIdLbl.Text);
            crc.deleteDishesRequest(dishRequestId);
            dataGridView1.DataSource = crc.loadDishesRequest();
        }

        private void deleteOrderRequest_Click(object sender, EventArgs e)
        {
            int orderRequestId = int.Parse(orderRequestIdlLbl.Text);
            crc.deleteOrderRequest(orderRequestId);
            dataGridView2.DataSource = crc.loadOrderHeaderRequest();
        }
    }
}
