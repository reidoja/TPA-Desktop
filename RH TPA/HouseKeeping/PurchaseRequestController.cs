using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RH_TPA.HouseKeeping
{
    class PurchaseRequestController
    {
        Patrick_Hotel_DatabaseEntities db = new Patrick_Hotel_DatabaseEntities();

        public object loadReachMinimum()
        {
            var result = (from x in db.MinibarItems
                          where x.ItemStock <= x.ItemMinimumStock && x.Deleted == 0
                          select new
                          {
                              ItemName = x.ItemName,
                              ItemStock= x.ItemStock,
                              ItemMinimumStock = x.ItemMinimumStock,
                              ItemPrice = x.ItemPrice
                          }).ToList();
            return result;
        }

        public void addPurchaseRequest(string itemName, int price, int quantity)
        {
            PurchaseRequest pr = new PurchaseRequest();
            pr.ItemName = itemName;
            pr.ItemPrice = price;
            pr.ItemQuantity = quantity;
            pr.Deleted = 0;
            db.PurchaseRequest.Add(pr);
            db.SaveChanges();
        }
    }
}
