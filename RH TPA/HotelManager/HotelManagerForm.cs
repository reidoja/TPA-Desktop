using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RH_TPA.HotelManager
{
    public partial class HotelManagerForm : Form
    {
        public HotelManagerForm()
        {
            InitializeComponent();
        }

        private void cRUDEvidenceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EvidenceForm ef = new EvidenceForm();
            ef.MdiParent = this;
            ef.Show();
        }

        private void cRUDResignationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ResignationForm rf = new ResignationForm();
            rf.MdiParent = this;
            rf.Show();
        }
    }
}
