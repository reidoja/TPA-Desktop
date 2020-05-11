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
    public partial class GuestForm : Form
    {
        GuestController gc = new GuestController();


        public GuestForm()
        {
            InitializeComponent();
            dataGridView1.DataSource = gc.loadData();
            dataGridView2.DataSource = gc.loadRoom();
            button1.Visible = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int reservationId = int.Parse(textBox1.Text);
            if(gc.searchReservation(reservationId) != "nihil")
            {
                button1.Visible = true;
                textBox2.Text = gc.searchReservation(reservationId);
                MessageBox.Show("Reservation ID found");
            }
            else
            {
                MessageBox.Show("Reservation Id not found");
                return;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            string guestName = textBox2.Text;
            string documentId = textBox3.Text;
            string roomNumber = textBox4.Text;
            int paymentTotal = int.Parse(textBox7.Text);
            int deposit = int.Parse(textBox8.Text);
            int reservationId = int.Parse(textBox1.Text);
            gc.addGuest(guestName, documentId, roomNumber, reservationId, paymentTotal, deposit);
            dataGridView1.DataSource = gc.loadData();
            dataGridView2.DataSource = gc.loadRoom();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            guestIdLbl.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            textBox2.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            textBox3.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            textBox4.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Patrick_Hotel_DatabaseEntities db = new Patrick_Hotel_DatabaseEntities();
            int oldRoomId = int.Parse(dataGridView1.CurrentRow.Cells[3].Value.ToString());
            var oldRoomNumber = (from x in db.Room where x.RoomId == oldRoomId select x.RoomNumber).FirstOrDefault();
            int guestId = int.Parse(guestIdLbl.Text);
            string guestName = textBox2.Text;
            string documentId = textBox3.Text;
            string newRoomNumber = textBox4.Text;
            int paymentTotal = int.Parse(textBox7.Text);
            int deposit = int.Parse(textBox8.Text);
            gc.updateGuest(guestId, guestName, documentId, oldRoomNumber, newRoomNumber, paymentTotal, deposit);
            dataGridView1.DataSource = gc.loadData();
            dataGridView2.DataSource = gc.loadRoom();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int guestId = int.Parse(guestIdLbl.Text);
            string review = richTextBox1.Text;
            gc.deleteGuest(guestId, review);
            dataGridView1.DataSource = gc.loadData();
            dataGridView2.DataSource = gc.loadRoom();
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            guestIdLbl.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
        }
    }
}
