using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RH_TPA.Kitchen
{
    class IngredientController
    {
        Patrick_Hotel_DatabaseEntities db = new Patrick_Hotel_DatabaseEntities();
        
        public object loadData()
        {
            var result = (from x in db.Ingredient where x.Deleted == 0 select new
            {
                IngredientId = x.IngredientId,
                IngredientName = x.IngredientName,
                IngredientStock = x.IngredientStock,
                IngredientMinStock = x.IngredientMinimumStock,
                IngredientPrice = x.IngredientPrice
            }).ToList();
            return result;
        }

        public void addData(string name, int stock, int minStock, int price)
        {
            Ingredient i = new Ingredient();
            i.IngredientName = name;
            i.IngredientStock = stock;
            i.IngredientMinimumStock = minStock;
            i.IngredientPrice = price;
            i.Deleted = 0;
            db.Ingredient.Add(i);
            db.SaveChanges();
        }
        public void updateData(int id, string name, int stock, int minStock, int price)
        {
            var obj = (from x in db.Ingredient where x.IngredientId == id select x).FirstOrDefault();
            obj.IngredientName = name;
            obj.IngredientStock = stock;
            obj.IngredientMinimumStock = minStock;
            obj.IngredientPrice = price;
            db.SaveChanges();
        }
        public void deleteData(int id)
        {
            var obj = (from x in db.Ingredient where x.IngredientId == id select x).FirstOrDefault();
            obj.Deleted = 1;
            db.SaveChanges();
        }
    }
}
