using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RH_TPA.RoomService
{
    class OrderController
    {
        Patrick_Hotel_DatabaseEntities db = new Patrick_Hotel_DatabaseEntities();
        

        public object loadHeader()
        {
            var result = (from x in db.OrderHeader where x.Deleted == 0 select new
            {
                OrderId = x.OrderId,
                OrderPriority = x.OrderPriority,
                RoomNumber = x.RoomNumber
            }).ToList();
            return result;
        }

        public object loadDetail(int orderId)
        {
            var result = (from x in db.OrderDetail join y in db.Food on x.FoodId equals y.FoodId
                          where x.OrderId == orderId
                          select new
                          {
                              FoodName = y.FoodName,
                              FoodPrice = y.FoodPrice,
                              Quantity = x.Quantity,
                              SubTotal = x.Quantity * y.FoodPrice               
                          }).ToList();
            return result;
        }

        public object loadFood()
        {

            var result = (from x in db.Food
                          select new
                          {
                              FoodId = x.FoodId,
                              FoodName = x.FoodName,
                              FoodPrice = x.FoodPrice,
                              Deleted = x.Deleted
                          }).ToList();
            return result;

        }

        public void addDetail(int orderId, string foodName, int quantity)
        {
            int foodId = (from x in db.Food where x.FoodName.Equals(foodName) select x.FoodId).ToList().FirstOrDefault();
            OrderDetail od = new OrderDetail();
            od.OrderId = orderId;
            od.FoodId = foodId;
            od.Quantity = quantity;
            db.OrderDetail.Add(od);
            db.SaveChanges();
        }

        public void deleteDetail(int orderId, string foodName)
        {
            var foodId = (from x in db.Food where x.FoodName.Equals(foodName) select x.FoodId).FirstOrDefault();
            var obj = (from x in db.OrderDetail where x.OrderId == orderId && x.FoodId == foodId select x).FirstOrDefault();
            db.OrderDetail.Remove(obj);
            db.SaveChanges();
        }

        public void addHeader(int priority, string roomNumber)
        {
            OrderHeader oh = new OrderHeader();
            oh.OrderPriority = priority;
            oh.RoomNumber = roomNumber;
            oh.Deleted = 0;
            db.OrderHeader.Add(oh);
            db.SaveChanges();
        }

        public int currOrderId()
        {
            var orderId = (from x in db.OrderHeader select x).ToList().LastOrDefault();
            return orderId.OrderId;
        }


        public void updateHeader(int orderId, int priority, string roomNumber)
        {
            var obj = (from x in db.OrderHeader where x.OrderId == orderId select x).FirstOrDefault();
            obj.OrderPriority = priority;
            obj.RoomNumber = roomNumber;
            db.SaveChanges();

        }

        public void deleteHeader(int orderId)
        {
            var obj = (from x in db.OrderHeader where x.OrderId == orderId select x).FirstOrDefault();
            obj.Deleted = 1;
            db.SaveChanges();
        }
    }
}
