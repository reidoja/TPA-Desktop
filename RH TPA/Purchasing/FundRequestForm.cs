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
    public partial class FundRequestForm : Form
    {

        Patrick_Hotel_DatabaseEntities db = new Patrick_Hotel_DatabaseEntities();

        public FundRequestForm()
        {
            InitializeComponent();
            dataGridView1.DataSource = loadData();
            totalLbl.Text = calculateTotal().ToString();
        }

        public object loadData()
        {
            var result = (from x in db.PurchaseRequest
                          where x.Deleted == 2
                          select new
                          {
                              ItemId = x.ItemId,
                              ItemName = x.ItemName,
                              ItemPrice = x.ItemPrice,
                              itemQuantity = x.ItemQuantity,
                              ItemTotalPrice = x.ItemPrice * x.ItemQuantity
                          }).ToList();
            return result;
        }

        public int calculateTotal()
        {
            int total = (from DataGridViewRow x in dataGridView1.Rows select Convert.ToInt32(x.Cells[4].FormattedValue)).Sum();
    
            return total;
        }
        

        private void button1_Click(object sender, EventArgs e)
        {
            int count = (from x in db.PurchaseRequest where x.Deleted == 0 select x).Count();
            for(int i = 0; i< count; i++)
            {
                FundRequest fr = new FundRequest();
                fr.ItemName = dataGridView1.SelectedRows[i].Cells[1].Value.ToString();
                fr.Total = int.Parse(dataGridView1.SelectedRows[i].Cells[4].Value.ToString());
                fr.Deleted = 0;
            }
            MessageBox.Show("Success");
        }
    }
}
