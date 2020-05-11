using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RH_TPA.Receptionist
{
    public partial class QRCodeForm : Form
    {
        
        Patrick_Hotel_DatabaseEntities db = new Patrick_Hotel_DatabaseEntities();

        public QRCodeForm()
        {
            InitializeComponent();
            var result = (from x in db.BrunchTicket select x.GuestId).ToList();
            comboBox1.DataSource = result;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int guestId = int.Parse(comboBox1.Text);
            var guestName = (from x in db.Guest where x.GuestId == guestId select x.GuestName).FirstOrDefault();
            string test = guestId.ToString() +" " + guestName;
            Zen.Barcode.CodeQrBarcodeDraw qrcode = Zen.Barcode.BarcodeDrawFactory.CodeQr;
            pictureBox1.Image = qrcode.Draw(test, 50);
        }
    }
}
