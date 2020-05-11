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
    public partial class AccountingReportForm : Form
    {
        Patrick_Hotel_DatabaseEntities db = new Patrick_Hotel_DatabaseEntities();
        public AccountingReportForm()
        {
            InitializeComponent();
        }

    }
}
