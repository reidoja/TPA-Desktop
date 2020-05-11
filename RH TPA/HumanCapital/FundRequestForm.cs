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
    public partial class FundRequestForm : Form
    {
        Patrick_Hotel_DatabaseEntities db = new Patrick_Hotel_DatabaseEntities();

        public FundRequestForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = textBox1.Text;
            int price = int.Parse(textBox2.Text);

            FundRequest fr = new FundRequest();
            fr.ItemName = name;
            fr.Total = price;
            fr.Deleted = 0;
            db.FundRequest.Add(fr);
            db.SaveChanges();
        }
    }
}
