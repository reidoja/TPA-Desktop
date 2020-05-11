using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RH_TPA.Purchasing
{
    class PurchaseRequestController
    {
        Patrick_Hotel_DatabaseEntities db = new Patrick_Hotel_DatabaseEntities();

        public object loadRequest()
        {
            var result = (from x in db.PurchaseRequest where x.Deleted == 0 select new
            {
                ItemId = x.ItemId,
                ItemName = x.ItemName,
                ItemPrice = x.ItemPrice,
                ItemQuantity = x.ItemQuantity
            }).ToList();
            return result;
        }


        public void refuseRequest(int itemId, string reason)
        {
            PurchaseRequestReason prr = new PurchaseRequestReason();
            prr.ItemId = itemId;
            prr.Reason = reason;
            db.PurchaseRequestReason.Add(prr);
            db.SaveChanges();
            var obj = (from x in db.PurchaseRequest where x.ItemId == itemId select x).FirstOrDefault();
            obj.Deleted = 1;
            db.SaveChanges();
        }

        public void approveRequest(int itemId, int itemPrice, int itemQuantity)
        {
            var itemName = (from x in db.PurchaseRequest where x.ItemId == itemId select x.ItemName).FirstOrDefault();
            PurchaseReport pr = new PurchaseReport();
            pr.PurchaseItem = itemName;
            pr.PurchaseTotal = itemPrice;
            pr.Deleted = 0;
            db.PurchaseReport.Add(pr);
            db.SaveChanges();
            var obj = (from x in db.PurchaseRequest where x.ItemId == itemId select x).FirstOrDefault();
            obj.Deleted = 2;
            db.SaveChanges();
            
        }
    }
}
