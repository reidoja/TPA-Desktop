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
    public partial class PurchaseReportForm : Form
    {

        Patrick_Hotel_DatabaseEntities db = new Patrick_Hotel_DatabaseEntities();
        public PurchaseReportForm()
        {
            InitializeComponent();
            dataGridView1.DataSource = loadData();
        }

        public object loadData()
        {
            var result = (from x in db.PurchaseReport
                          where x.Deleted == 0
                          select new
                          {
                              PurchaseReportId = x.PusrchaseReportId,
                              PurchaseItem = x.PurchaseItem,
                              PurchaseTotal = x.PurchaseTotal
                          }).ToList();
            return result;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int total = (from DataGridViewRow x in dataGridView1.Rows select Convert.ToInt32(x.Cells[2].FormattedValue)).Sum();
            string[] arrMonth = new string[12] { "January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December" };

            int month = dateTimePicker1.Value.Month;
            Microsoft.Office.Interop.Excel._Application app = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel._Workbook workbook = app.Workbooks.Add(Type.Missing);
            Microsoft.Office.Interop.Excel._Worksheet worksheet = null;
            worksheet = workbook.Sheets["Sheet1"];
            worksheet = workbook.ActiveSheet;
            worksheet.Name = month.ToString();

            for (int i = 1; i <= dataGridView1.Columns.Count; i++)
            {
                worksheet.Cells[1, i] = dataGridView1.Columns[i - 1].HeaderText;
            }
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                for (int j = 0; j < dataGridView1.Columns.Count; j++)
                {
                    worksheet.Cells[i + 2, j + 1] = dataGridView1.Rows[i].Cells[j].Value.ToString();
                }
                int id = int.Parse(dataGridView1.Rows[i].Cells[0].Value.ToString());
                var obj = (from x in db.PurchaseReport where x.PusrchaseReportId == id select x).FirstOrDefault();
                obj.Deleted = 1;
                db.SaveChanges();
            }
            worksheet.Cells[dataGridView1.Rows.Count + 2, 1] = "Total Payment " + arrMonth[month - 1] + " : Rp." + total;

            var saveFile = new SaveFileDialog();
            saveFile.FileName = "PurchaseReport" + arrMonth[month];
            saveFile.DefaultExt = ".xlsx";
            if (saveFile.ShowDialog() == DialogResult.OK)
            {
                workbook.SaveAs(saveFile.FileName, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlExclusive, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing);

            }

            app.Quit();
        }
    }
}
