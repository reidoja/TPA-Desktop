using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RH_TPA.HouseKeeping
{
    public partial class PurchaseRequestForm : Form
    {

        PurchaseRequestController prc = new PurchaseRequestController();

        public PurchaseRequestForm()
        {
            InitializeComponent();
            dataGridView1.DataSource = prc.loadReachMinimum();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string itemName = itemNameLbl.Text;
            int price = int.Parse(dataGridView1.CurrentRow.Cells[3].Value.ToString());
            int quantity = int.Parse(textBox1.Text);
           

            prc.addPurchaseRequest(itemName, price, quantity);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            itemNameLbl.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
        }
    }
}
