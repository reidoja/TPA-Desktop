using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RH_TPA.Kitchen
{
    class PurchaseRequestController
    {
        Patrick_Hotel_DatabaseEntities db = new Patrick_Hotel_DatabaseEntities();

        public object loadReachMinimum()
        {
            var result = (from x in db.Ingredient
                          where x.IngredientStock <= x.IngredientMinimumStock
                          select new
                          {
                              IngredientName = x.IngredientName,
                              IngredientStock = x.IngredientStock,
                              IngredientMinimumStock = x.IngredientMinimumStock,
                              IngredientPrice = x.IngredientPrice
                          }).ToList();
            return result;
        }
        
        public void addPurchaseRequest(string name, int price, int quantity)
        {
            PurchaseRequest pr = new PurchaseRequest();
            pr.ItemName = name;
            pr.ItemPrice = price;
            pr.ItemQuantity = quantity;
            pr.Deleted = 0;
            db.PurchaseRequest.Add(pr);
            db.SaveChanges();
        }
    }
}
