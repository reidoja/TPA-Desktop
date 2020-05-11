using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RH_TPA.AccountingAndFinance
{
    public partial class FundRequestForm : Form
    {

        FundRequestController frc = new FundRequestController();

        public FundRequestForm()
        {
            InitializeComponent();
            dataGridView1.DataSource = frc.loadData();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            fundIdLbl.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            itemNameLbl.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            priceLbl.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
        }

        private void approveBtn_Click(object sender, EventArgs e)
        {
            int fundId = int.Parse(fundIdLbl.Text);
            frc.approve(fundId);
            dataGridView1.DataSource = frc.loadData();
        }

        private void refuseBtn_Click(object sender, EventArgs e)
        {
            int fundId = int.Parse(fundIdLbl.Text);
            frc.refuse(fundId);
            dataGridView1.DataSource = frc.loadData();
        }
    }
}
