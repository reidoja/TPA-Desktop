using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RH_TPA.RoomService
{
    public partial class RoomServiceForm : Form
    {
        public RoomServiceForm()
        {
            InitializeComponent();
        }

        private void cRUDRequestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OrderForm of = new OrderForm();
            of.MdiParent = this;
            of.Show();
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoginForm lf = new LoginForm();
            Dispose();
            lf.Show();
            
        }
    }
}
