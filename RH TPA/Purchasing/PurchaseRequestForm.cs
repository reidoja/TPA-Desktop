using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RH_TPA.Purchasing
{
    public partial class PurchaseRequestForm : Form
    {

        PurchaseRequestController prc = new PurchaseRequestController();

        public PurchaseRequestForm()
        {
            InitializeComponent();
            dataGridView1.DataSource = prc.loadRequest();
        }

        private void acceptBtn_Click(object sender, EventArgs e)
        {
            int itemId = int.Parse(itemIdLbl.Text);
            int itemPrice = int.Parse(itemPriceLbl.Text);
            int quantity = int.Parse(itemQuantityLbl.Text);
            prc.approveRequest(itemId, itemPrice, quantity);
            dataGridView1.DataSource = prc.loadRequest();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            itemIdLbl.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            itemNameLbl.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            itemPriceLbl.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            itemQuantityLbl.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
        }

        private void declineBtn_Click(object sender, EventArgs e)
        {
            int itemId = int.Parse(itemIdLbl.Text);
            string reason = reasonTxt.Text;
            prc.refuseRequest(itemId, reason);
            dataGridView1.DataSource = prc.loadRequest();

        }
    }
}
