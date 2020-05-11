using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RH_TPA.SalesAndMarketing
{
    public partial class SalesAndMarketingForm : Form
    {
        public SalesAndMarketingForm()
        {
            InitializeComponent();
        }

        private void guestReviewsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GuestReportForm grf = new GuestReportForm();
            grf.MdiParent = this;
            grf.Show();
        }
    }
}
