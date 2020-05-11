using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RH_TPA.HouseKeeping
{
    public partial class RoomForm : Form
    {

        Patrick_Hotel_DatabaseEntities db = new Patrick_Hotel_DatabaseEntities();

        public RoomForm()
        {
            InitializeComponent();
            loadData();
        }
        private void loadData()
        {
            var result = (from x in db.Room
                          select new
                          {
                              RoomNumber = x.RoomNumber,
                              MakeUpRoom = x.MakeUp
                          }).ToList();
            dataGridView1.DataSource = result;
        }
    }
}
