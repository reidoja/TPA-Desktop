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
    public partial class EmployeeForm : Form
    {

        EmployeeController ec = new EmployeeController();

        public EmployeeForm()
        {
            InitializeComponent();
            dataGridView1.DataSource = ec.loadData();
            dataGridView2.DataSource = ec.loadCandidate();
            dataGridView3.DataSource = ec.loadFire();
            dataGridView4.DataSource = ec.loadResignation();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            idLbl.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            nameTxt.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            passwordTxt.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            salaryTxt.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            comboBox1.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int canId = int.Parse(canIdLbl.Text);
            int id = int.Parse(idLbl.Text);
            string name = nameTxt.Text;
            string pass = passwordTxt.Text;
            int salary = int.Parse(salaryTxt.Text);
            string pos = comboBox1.Text;

            ec.addEmployee(canId, name, pass, salary, pos);
            dataGridView2.DataSource = ec.loadCandidate();
            dataGridView1.DataSource = ec.loadData();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int id = int.Parse(idLbl.Text);
            string name = nameTxt.Text;
            string pass = passwordTxt.Text;
            int salary = int.Parse(salaryTxt.Text);
            string pos = comboBox1.Text;

            ec.updateEmployee(id, name, pass, salary, pos);
            dataGridView1.DataSource = ec.loadData();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if(evIdLbl.Text == "-")
            {
                int id = int.Parse(idLbl.Text);
                int resID = int.Parse(resignationIdLbl.Text);
                ec.deleteResign(id, resID);
            }
            else if(resignationIdLbl.Text == "-")
            {
                int id = int.Parse(idLbl.Text);
                int evId = int.Parse(evIdLbl.Text);
                ec.deleteEmployee(id, evId);
            }
 
            dataGridView3.DataSource = ec.loadFire();
            dataGridView1.DataSource = ec.loadData();
            dataGridView4.DataSource = ec.loadResignation();
            resignationIdLbl.Text = "-";
            evIdLbl.Text = "-";
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            canIdLbl.Text = dataGridView2.CurrentRow.Cells[0].Value.ToString();
            nameTxt.Text = dataGridView2.CurrentRow.Cells[1].Value.ToString();
        }

        private void dataGridView3_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            evIdLbl.Text = dataGridView3.CurrentRow.Cells[0].Value.ToString();
            idLbl.Text = dataGridView3.CurrentRow.Cells[1].Value.ToString();
            nameTxt.Text = dataGridView3.CurrentRow.Cells[2].Value.ToString();
            
        }
    }
}
