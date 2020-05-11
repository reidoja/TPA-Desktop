using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RH_TPA.HumanCapital
{
    public partial class SalaryForm : Form
    {

        SalaryController sc = new SalaryController();

        public SalaryForm()
        {
            InitializeComponent();
            dataGridView1.DataSource = sc.loadSalary();
            dataGridView2.DataSource = sc.loadApproval();
            button2.Enabled = false;
        }

        private void staffIdLbl_TextChanged(object sender, EventArgs e)
        {
            int staffId = int.Parse(staffIdLbl.Text);
            button2.Enabled = sc.checkApproval(staffId);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            staffIdLbl.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            staffNameLbl.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            salaryLbl.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int staffId = int.Parse(staffIdLbl.Text);
            int raiseTotal = int.Parse(raiseTxt.Text);

            sc.requestRaise(staffId, raiseTotal);
            MessageBox.Show("Success");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int staffId = int.Parse(staffIdLbl.Text);
            int raiseTotal = int.Parse(raiseTxt.Text);

            sc.update(staffId, raiseTotal);
            dataGridView1.DataSource = sc.loadSalary();
            dataGridView2.DataSource = sc.loadApproval();
        }
    }
}
