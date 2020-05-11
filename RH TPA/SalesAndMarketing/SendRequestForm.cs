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
    public partial class SendRequestForm : Form
    {

        Patrick_Hotel_DatabaseEntities db = new Patrick_Hotel_DatabaseEntities();

        public SendRequestForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string itemName = textBox1.Text;
            int total = int.Parse(textBox2.Text);
            FundRequest fr = new FundRequest();
            fr.ItemName = itemName;
            fr.Total = total;
            db.FundRequest.Add(fr);
            db.SaveChanges();
        }
    }
}
