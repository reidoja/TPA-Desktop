using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RH_TPA.HotelManager
{
    public partial class EvidenceForm : Form
    {
        EvidenceController ec = new EvidenceController();
        public EvidenceForm()
        {
            InitializeComponent();
            dataGridView1.DataSource = ec.loadData();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            evIdLbl.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            staffIdLbl.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            richTextBox1.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
        }

        private void approveBtn_Click(object sender, EventArgs e)
        {
            int evId = int.Parse(evIdLbl.Text);
            ec.approve(evId);
            dataGridView1.DataSource = ec.loadData();
        }

        private void refuseBtn_Click(object sender, EventArgs e)
        {
            int evId = int.Parse(evIdLbl.Text);
            ec.refuse(evId);
            dataGridView1.DataSource = ec.loadData();
        }
    }
}
