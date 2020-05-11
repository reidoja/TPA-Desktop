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
    public partial class HireForm : Form
    {
        HireController hc = new HireController();

        int currStep = HireController.step;
        

        public HireForm()
        {
            InitializeComponent();
            dataGridView1.DataSource = hc.loadStep1();
            dataGridView2.DataSource = hc.loadStep2();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            canIdLbl.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            canNameLbl.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
        }

        private void regBtn_Click(object sender, EventArgs e)
        {
            string name = nameTxt.Text;
            hc.addCandidate(name);
            dataGridView1.DataSource = hc.loadStep1();
            dataGridView2.DataSource = hc.loadStep2();
        }

        private void gs1Btn_Click(object sender, EventArgs e)
        {
            hc.currStep(currStep);
            groupBox1.Enabled = false;
            groupBox2.Enabled = true;
        }

        private void update1Btn_Click(object sender, EventArgs e)
        {
            int canId = int.Parse(canIdLbl.Text);
            hc.updateStep1(canId);
            dataGridView1.DataSource = hc.loadStep1();
            dataGridView2.DataSource = hc.loadStep2();
        }

        private void gs2Btn_Click(object sender, EventArgs e)
        {
            hc.currStep(currStep);
            groupBox2.Enabled = false;
            groupBox3.Enabled = true;
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            canIdLbl1.Text = dataGridView2.CurrentRow.Cells[0].Value.ToString();
            canNameLbl1.Text = dataGridView2.CurrentRow.Cells[1].Value.ToString();
        }

        private void update2Btn_Click(object sender, EventArgs e)
        {
            int canId = int.Parse(canIdLbl1.Text);
            hc.updateStep2(canId);
            dataGridView1.DataSource = hc.loadStep1();
            dataGridView2.DataSource = hc.loadStep2();
        }

        private void finBtn_Click(object sender, EventArgs e)
        {
            hc.currStep(currStep);
            groupBox3.Enabled = false;
            groupBox1.Enabled = true;
        }

        private void HireForm_Load(object sender, EventArgs e)
        {
            if(currStep == 1)
            {
                groupBox1.Enabled = true;
                groupBox2.Enabled = false;
                groupBox2.Enabled = false;
            }
            else if (currStep == 2)
            {
                groupBox1.Enabled = false;
                groupBox2.Enabled = true;
                groupBox2.Enabled = false;
            }
            else if (currStep == 3)
            {
                groupBox1.Enabled = false;
                groupBox2.Enabled = false;
                groupBox2.Enabled = true;
            }
        }
    }
}
