using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RH_TPA.Kitchen
{
    class CookRequestController
    {
        Patrick_Hotel_DatabaseEntities db = new Patrick_Hotel_DatabaseEntities();
        public object loadDishesRequest()
        {
            var result = (from x in db.DishesRequest
                          join y in db.Dishes
                          on x.DishId equals y.DishId
                          where x.Deleted == 0
                          select new
                          {
                              RequestId = x.RequestId,
                              DishName = y.DishName,
                              Quantity = x.Quantity
                          }).ToList();
            return result;
        }
        public object loadOrderHeaderRequest()
        {
            var result = (from x in db.OrderHeader where x.Deleted == 0
                          orderby x.OrderPriority ascending
                          select new
            {
                OrderId = x.OrderId,
                OrderPriority = x.OrderPriority,
                RoomNumber = x.RoomNumber
            }).ToList();
            return result;
        }
        public object loadOrderDetailRequest(int orderId)
        {
            var result = (from x in db.OrderDetail
                          join y in db.Food
                          on x.FoodId equals y.FoodId
                          where x.OrderId == orderId && y.Deleted == 0
                          select new
                          {
                              OrderId = x.OrderId,
                              FoodName = y.FoodName,
                              Quantity = x.Quantity
                          }).ToList();
            return result;
        }

        public void updateDishesRequest(int requestId, string dishName, int quantity)
        {
            var dishId = (from x in db.Dishes where x.DishName.Equals(dishName) select x.DishId).FirstOrDefault();
            var obj = (from x in db.DishesRequest where x.RequestId == requestId select x).FirstOrDefault();
            obj.DishId = dishId;
            obj.Quantity = quantity;
            db.SaveChanges();
        }
        public void deleteDishesRequest(int requestId)
        {
            var obj = (from x in db.DishesRequest where x.RequestId == requestId select x).FirstOrDefault();
            obj.Deleted = 1;
            db.SaveChanges();
        }
        public void deleteOrderRequest(int orderRequestId)
        {
            var obj = (from x in db.OrderHeader where x.OrderId == orderRequestId select x).FirstOrDefault();
            obj.Deleted = 1;
            db.SaveChanges();
        }
    }
}
