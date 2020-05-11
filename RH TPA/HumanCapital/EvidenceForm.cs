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
    public partial class EvidenceForm : Form
    {
        EvidenceController ec = new EvidenceController();

        public EvidenceForm()
        {
            InitializeComponent();
            dataGridView1.DataSource = ec.loadData();
        }

        private void insertBtn_Click(object sender, EventArgs e)
        {
            int id = int.Parse(staffIdTxt.Text);
            string text = richTextBox1.Text;

            ec.add(id, text);
            dataGridView1.DataSource = ec.loadData();

        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            int id = int.Parse(staffIdTxt.Text);
            string text = richTextBox1.Text;

            ec.update(id, text);
            dataGridView1.DataSource = ec.loadData();
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            int id = int.Parse(staffIdTxt.Text);

            ec.delete(id);
            dataGridView1.DataSource = ec.loadData();
        }
    }
}
