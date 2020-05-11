using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RH_TPA.DiningRoom
{
    public partial class CheckTicketForm : Form
    {
        CheckTicketController ctc = new CheckTicketController();

        public CheckTicketForm()
        {
            InitializeComponent();
            dataGridView1.DataSource = ctc.loadData();
            button1.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int guestId = int.Parse(textBox1.Text);
            int remaining = int.Parse(textBox2.Text);
            ctc.updateRemaining(guestId, remaining);
            dataGridView1.DataSource = ctc.loadData();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int guestId = int.Parse(textBox1.Text);
            if (ctc.checkEligibility(guestId))
            {
                MessageBox.Show("Guest Found");
                button1.Enabled = true;
            }
            else if (!ctc.checkEligibility(guestId))
            {
                MessageBox.Show("Guest Not Found");
                return;
            }
        }
    }
}
