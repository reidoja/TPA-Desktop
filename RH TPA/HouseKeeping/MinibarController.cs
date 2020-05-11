using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RH_TPA.HouseKeeping
{
    class MinibarController
    {
        Patrick_Hotel_DatabaseEntities db = new Patrick_Hotel_DatabaseEntities();

        public object loadData()
        {
            var result = (from x in db.MinibarItems where x.Deleted == 0 select new
            {
                ItemID = x.ItemId,
                ItemName = x.ItemName,
                ItemMinimumStock = x.ItemMinimumStock,
                ItemStock = x.ItemStock,
                ItemPrice = x.ItemPrice
            }).ToList();
            return result;
        }

        public void addItem(string itemName, int itemStock, int itemMinimumStock, int itemPrice)
        {
            MinibarItems mi = new MinibarItems();
            mi.ItemName = itemName;
            mi.ItemStock = itemStock;
            mi.ItemMinimumStock = itemMinimumStock;
            mi.ItemPrice = itemPrice;
            mi.Deleted = 0;
            db.MinibarItems.Add(mi);
            db.SaveChanges();
        }

        public void updateItem(int itemId,string itemName, int itemStock, int itemMinimumStock, int itemPrice)
        {
            var obj = (from x in db.MinibarItems
                       where x.ItemId == itemId
                       select x).FirstOrDefault();
            obj.ItemName = itemName;
            obj.ItemStock = itemStock;
            obj.ItemMinimumStock = itemMinimumStock;
            obj.ItemPrice = itemPrice;
            db.SaveChanges();
        }

        public void deleteItem(int itemId)
        {
            var obj = (from x in db.MinibarItems
                       where x.ItemId == itemId
                       select x).FirstOrDefault();
            obj.ItemStock = 0;
            obj.ItemPrice = 0;
            obj.Deleted = 1;
            db.SaveChanges();
        }

        public void deduction(string roomNumber, int price)
        {
            var room = (from x in db.Room where x.RoomNumber.Equals(roomNumber) select x.RoomId).FirstOrDefault();
            var guestId = (from x in db.Guest where x.RoomId == room select x.GuestId).FirstOrDefault();
            var obj = (from x in db.PaymentDetail where x.GuestId == guestId select x).FirstOrDefault();
            obj.DepositMoney -= price;
            obj.PaymentTotal += price;
            db.SaveChanges();
        }
    }
}
