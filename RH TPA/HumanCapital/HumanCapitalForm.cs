using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RH_TPA.HumanCapital
{
    public partial class HumanCapitalForm : Form
    {
        public HumanCapitalForm()
        {
            InitializeComponent();
        }

        private void cRUDSalaryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SalaryForm sf = new SalaryForm();
            sf.MdiParent = this;
            sf.Show();
        }

        private void cRUDEmployeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EmployeeForm ef = new EmployeeForm();
            ef.MdiParent = this;
            ef.Show();
        }

        private void fireToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EvidenceForm ef = new EvidenceForm();
            ef.MdiParent = this;
            ef.Show();
        }

        private void sendPurchaseRequestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FundRequestForm frf = new FundRequestForm();
            frf.MdiParent = this;
            frf.Show();
        }

        private void hireFlowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HireForm hf = new HireForm();
            hf.MdiParent = this;
            hf.Show();
        }
    }
}
