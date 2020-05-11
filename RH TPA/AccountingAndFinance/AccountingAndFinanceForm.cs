using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RH_TPA.AccountingAndFinance
{
    public partial class AccountingAndFinanceForm : Form
    {
        public AccountingAndFinanceForm()
        {
            InitializeComponent();
        }

        private void cRUDRequestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FundRequestForm frr = new FundRequestForm();
            frr.MdiParent = this;
            frr.Show();
        }

        private void accountingReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AccountingReportForm arf = new AccountingReportForm();
            arf.MdiParent = this;
            arf.Show();
        }
    }
}
