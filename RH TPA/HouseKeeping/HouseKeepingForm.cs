using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RH_TPA.HouseKeeping
{
    public partial class HouseKeepingForm : Form
    {
        LoginForm loginForm;
        public HouseKeepingForm()
        {
            InitializeComponent();
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            loginForm = new LoginForm();
            loginForm.Show();
        }

        private void cRUDItemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MinibarForm minibarForm = new MinibarForm();
            minibarForm.MdiParent = this;
            minibarForm.Show();
        }

        private void makeUpRoomToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RoomForm roomform = new RoomForm();
            roomform.MdiParent = this;
            roomform.Show();
        }

        private void guestToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void sendPurchaseRequestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PurchaseRequestForm prf = new PurchaseRequestForm();
            prf.MdiParent = this;
            prf.Show();
        }
    }
}
