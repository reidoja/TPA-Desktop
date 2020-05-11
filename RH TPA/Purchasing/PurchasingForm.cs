using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RH_TPA.Purchasing
{
    public partial class PurchasingForm : Form
    {
        public PurchasingForm()
        {
            InitializeComponent();
        }

        private void cRUDRequestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PurchaseRequestForm prf = new PurchaseRequestForm();
            prf.MdiParent = this;
            prf.Show();
        }

        private void cRUDRequestToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FundRequestForm frr = new FundRequestForm();
            frr.MdiParent = this;
            frr.Show();
        }

        private void purchaseReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PurchaseReportForm prf = new PurchaseReportForm();
            prf.MdiParent = this;
            prf.Show();
        }
    }
}
