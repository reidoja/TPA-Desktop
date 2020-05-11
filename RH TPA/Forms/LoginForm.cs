using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RH_TPA.Forms;
using RH_TPA.Receptionist;
using RH_TPA.HouseKeeping;
using RH_TPA.DiningRoom;
using RH_TPA.RoomService;
using RH_TPA.Kitchen;
using RH_TPA.Purchasing;
using RH_TPA.AccountingAndFinance;
using RH_TPA.SalesAndMarketing;
using RH_TPA.HumanCapital;
using RH_TPA.HotelManager;

namespace RH_TPA
{
    public partial class LoginForm : Form
    {
        Patrick_Hotel_DatabaseEntities db = new Patrick_Hotel_DatabaseEntities();

        ReceptionistForm rForm;
        HouseKeepingForm hkForm;
        DiningRoomForm drForm;
        RoomServiceForm rsForm;
        KitchenForm kForm;
        PurchasingForm pForm;
        AccountingAndFinanceForm aafForm;
        SalesAndMarketingForm samForm;
        HumanCapitalForm hcForm;
        HotelManagerForm hmForm;

        public LoginForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            staffIdTxt.Text = "";
            passTxt.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int id = int.Parse(staffIdTxt.Text);

            var search = (from x in db.Staff
                          where x.StaffId == id &&
                          x.StaffPassword.Equals(passTxt.Text)
                          select x.StaffPosition).FirstOrDefault();

            if(search != null)
            {
                if (search.Equals("Receptionist"))
                {

                    rForm = new ReceptionistForm();
                    rForm.Show();
                }
                else if (search.Equals("HouseKeeping"))
                {
                    hkForm = new HouseKeepingForm();
                    hkForm.Show();
                }
                else if (search.Equals("DiningRoom"))
                {
                    drForm = new DiningRoomForm();
                    drForm.Show();
                }
                else if (search.Equals("RoomService"))
                {
                    rsForm = new RoomServiceForm();
                    rsForm.Show();
                }
                else if (search.Equals("Kitchen"))
                {
                    kForm = new KitchenForm();
                    kForm.Show();
                }
                else if (search.Equals("Purchasing"))
                {
                    pForm = new PurchasingForm();
                    pForm.Show();
                }
                else if (search.Equals("AccountingAndFinance"))
                {
                    aafForm = new AccountingAndFinanceForm();
                    aafForm.Show();
                }
                else if(search.Equals("SalesAndMarketing"))
                {
                    samForm = new SalesAndMarketingForm();
                    samForm.Show();
                }
                else if (search.Equals("HumanCapital"))
                {
                    hcForm = new HumanCapitalForm();
                    hcForm.Show();
                }
                else if (search.Equals("HotelManager"))
                {
                    hmForm = new HotelManagerForm();
                    hmForm.Show();
                }
            }
            else
            {
                MessageBox.Show("Invalid Id or Password");
            }


        }
       
    }
}
