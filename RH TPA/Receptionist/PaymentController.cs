using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RH_TPA.Receptionist
{
    
    class PaymentController
    {
        Patrick_Hotel_DatabaseEntities db = new Patrick_Hotel_DatabaseEntities();
        

        public void addPayment(int guestId, int paymentTotal, int deposit)
        {
            PaymentDetail p = new PaymentDetail();
            p.GuestId = guestId;
            p.PaymentTotal = paymentTotal;
            p.DepositMoney = deposit;
            db.PaymentDetail.Add(p);
            db.SaveChanges();
        }
        public void updatePayment(int guestId, int paymentTotal, int deposit)
        {
            var obj = (from x in db.Guest
                       join y in db.PaymentDetail
    on x.GuestId equals y.GuestId
                       where x.GuestId == guestId
                       select y).FirstOrDefault();
            obj.PaymentTotal = paymentTotal;
            obj.DepositMoney = deposit;
            db.SaveChanges();
        }

        public void deletePayment(int paymentId)
        {
            var obj = (from x in db.PaymentDetail
                       where x.PaymentId == paymentId
                       select x).FirstOrDefault();
            db.PaymentDetail.Remove(obj);
            db.SaveChanges();
        }
    }
}
