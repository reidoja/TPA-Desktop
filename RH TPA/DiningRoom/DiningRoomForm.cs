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
    public partial class DiningRoomForm : Form
    {
        public DiningRoomForm()
        {
            InitializeComponent();
        }

        private void cRUDDishesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RequestForm rf = new RequestForm();
            rf.MdiParent = this;
            rf.Show();
        }

        private void checkEligibilityToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
