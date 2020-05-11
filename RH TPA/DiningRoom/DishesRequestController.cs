using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RH_TPA.DiningRoom
{
    class DishesRequestController
    {
        Patrick_Hotel_DatabaseEntities db = new Patrick_Hotel_DatabaseEntities();

        public object loadData()
        {
            var result = (from x in db.DishesRequest
                          join y in db.Dishes on
                           x.DishId equals y.DishId
                          where x.Deleted == 0
                          select new
                          {
                              RequestId = x.RequestId,
                              DishesName = y.DishName,
                              Quantity = x.Quantity
                          }).ToList();
            return result;
        }

        public object loadAvailable()
        {
            var result = (from x in db.Dishes where x.Deleted == 0 select new
            {
                DishId = x.DishId,
                DishName = x.DishName,
                DishStock = x.DishStock
            }).ToList();
            return result;
        }

        public void addRequest(string dishName, int quantity)
        {
            var dishId = (from x in db.Dishes where x.DishName.Equals(dishName) select x.DishId).FirstOrDefault();
            DishesRequest dr = new DishesRequest();
            dr.DishId = dishId;
            dr.Quantity = quantity;
            dr.Deleted = 0;
            db.DishesRequest.Add(dr);
            db.SaveChanges();
        }

        public void updateRequest(int requestId,  string dishName, int quantity)
        {
            var dishId = (from x in db.Dishes where x.DishName.Equals(dishName) select x.DishId).FirstOrDefault();
            var obj = (from x in db.DishesRequest where x.RequestId == requestId select x).FirstOrDefault();
            obj.DishId = dishId;
            obj.Quantity = quantity;
            db.SaveChanges();
        }

        public void deleteRequest(int requestId)
        {
            var obj = (from x in db.DishesRequest where x.RequestId == requestId select x).FirstOrDefault();
            obj.Deleted = 1;
            db.SaveChanges();
        }
    }
}
