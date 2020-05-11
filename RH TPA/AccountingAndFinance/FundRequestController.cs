using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RH_TPA.AccountingAndFinance
{
    class FundRequestController
    {
        Patrick_Hotel_DatabaseEntities db = new Patrick_Hotel_DatabaseEntities();

        public object loadData()
        {
            var result = (from x in db.FundRequest
                          where x.Deleted == 0
                          select new
                          {
                             FundId = x.FundId,
                             ItemName = x.ItemName,
                             Total = x.Total
                          }).ToList();
            return result;
        }

        public void approve(int fundId)
        {
            var obj = (from x in db.FundRequest where x.FundId == fundId select x).FirstOrDefault();
            obj.Deleted = 2;
            db.SaveChanges();
        }

        public void refuse(int fundId)
        {
            var obj = (from x in db.FundRequest where x.FundId == fundId select x).FirstOrDefault();
            obj.Deleted = 1;
            db.SaveChanges();
        }

    }
}
