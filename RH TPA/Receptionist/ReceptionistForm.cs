using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RH_TPA.Receptionist;
using RH_TPA.Forms;

namespace RH_TPA.Forms
{
    public partial class ReceptionistForm : Form
    {
        LoginForm loginForm;
        public ReceptionistForm()
        {
            InitializeComponent();
        }

        private void addReservationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReservationForm reservForm = new ReservationForm();
            reservForm.MdiParent = this;
            reservForm.Show();
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            loginForm = new LoginForm();
            loginForm.Show();
        }

        private void addGuestToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
            GuestForm guestForm = new GuestForm();
            guestForm.MdiParent = this;
            guestForm.Show();
        }

        private void checkEligibilityToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void qRCodeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            QRCodeForm qrcf = new QRCodeForm();
            qrcf.MdiParent = this;
            qrcf.Show();
        }

        private void monthlyReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SalesReportForm srf = new SalesReportForm();
            srf.MdiParent = this;
            srf.Show();
        }
    }
}
