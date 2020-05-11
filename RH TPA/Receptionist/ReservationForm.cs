using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RH_TPA.Receptionist
{
    public partial class ReservationForm : Form
    {
        
        ReservationController rc = new ReservationController();

        public ReservationForm()
        {
            InitializeComponent();
            dataGridView1.DataSource = rc.loadData();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string guestName = textBox1.Text;
            string checkindate = textBox2.Text;
            int nights = int.Parse(textBox3.Text);
            rc.addReservation(guestName, checkindate, nights);
            dataGridView1.DataSource = rc.loadData();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int reservationId = int.Parse(reservationIdLbl.Text);
            string guestName = textBox1.Text;
            string checkindate = textBox2.Text;
            int nights = int.Parse(textBox3.Text);
            rc.updateReservation(reservationId, guestName, checkindate, nights);
            dataGridView1.DataSource = rc.loadData();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            reservationIdLbl.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            textBox1.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            textBox2.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            textBox3.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int reservationId = int.Parse(reservationIdLbl.Text);
            rc.deleteReservation(reservationId);
            dataGridView1.DataSource = rc.loadData();
        }
    }
}
