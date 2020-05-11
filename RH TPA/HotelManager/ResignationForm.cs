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
    public partial class ResignationForm : Form
    {
        ResignationController rc = new ResignationController();
        public ResignationForm()
        {
            InitializeComponent();
            dataGridView1.DataSource = rc.loadData();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            resIdLbl.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
        }

        private void submitBtn_Click(object sender, EventArgs e)
        {
            int staffId = int.Parse(idTxt.Text);
            int resMonth = dateTimePicker1.Value.Month;
            int currMonth = DateTime.Today.Month - 3;

            if(currMonth < resMonth)
            {
                MessageBox.Show("Resignation Month Gagal");
                return;
            }

            rc.submit(staffId);
            dataGridView1.DataSource = rc.loadData();

        }

        private void approveBtn_Click(object sender, EventArgs e)
        {
            int resId = int.Parse(resIdLbl.Text);
            rc.approve(resId);
            dataGridView1.DataSource = rc.loadData();
        }

        private void rejectBtn_Click(object sender, EventArgs e)
        {
            int resId = int.Parse(resIdLbl.Text);
            rc.refuse(resId);
            dataGridView1.DataSource = rc.loadData();
        }
    }
}
