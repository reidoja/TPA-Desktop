using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RH_TPA.Kitchen
{
    class RecipeController
    {
        Patrick_Hotel_DatabaseEntities db = new Patrick_Hotel_DatabaseEntities();

        public object loadDishRecipe(string dishName)
        {
            var result = (from x in db.RecipeDish
                          join y in db.Dishes on x.DishId equals
                          y.DishId
                          join z in db.Ingredient on x.IngredientId equals z.IngredientId
                          where x.Deleted == 0 &&
                          y.DishName.Equals(dishName)
                          select new
                          {
                              DishName = y.DishName,
                              IngredientName = z.IngredientName,
                              Quantity = x.Quantity
                          }).ToList();
            return result;
        }

        public object loadFoodRecipe(string foodName)
        {
            var result = (from x in db.RecipeFood
                          join y in db.Food on x.FoodId equals
                          y.FoodId
                          join z in db.Ingredient on x.IngredientId equals z.IngredientId
                          where x.Deleted == 0 && 
                          y.FoodName.Equals(foodName)
                          select new
                          {
                              DishName = y.FoodName,
                              IngredientName = z.IngredientName,
                              Quantity = x.Quantity
                          }).ToList();
            return result;
        }

        public object loadDishName()
        {
            var result = (from x in db.Dishes where x.Deleted == 0 select x.DishName).ToList();
            return result;
        }

        public object loadFoodName()
        {
            var result = (from x in db.Food where x.Deleted == 0 select x.FoodName).ToList();
            return result;
        }

        public object loadIngredient()
        {
            var result = (from x in db.Ingredient where x.Deleted == 0 select x.IngredientName).ToList();
            return result;
        }

        public void addDishRecipe(string dishName, string ingredientName, int quantity)
        {
            var dishId = (from x in db.Dishes where x.DishName.Equals(dishName) select x.DishId).FirstOrDefault();
            var ingredientId = (from x in db.Ingredient where x.IngredientName.Equals(ingredientName) select x.IngredientId).FirstOrDefault();
            RecipeDish rd = new RecipeDish();
            rd.DishId = dishId;
            rd.IngredientId = ingredientId;
            rd.Quantity = quantity;
            rd.Deleted = 0;
            db.RecipeDish.Add(rd);
            db.SaveChanges();
        }
        
        public void addFoodRecipe(string foodName, string ingredientName, int quantity)
        {
            var foodId = (from x in db.Food where x.FoodName.Equals(foodName) select x.FoodId).FirstOrDefault();
            var ingredientId = (from x in db.Ingredient where x.IngredientName.Equals(ingredientName) select x.IngredientId).FirstOrDefault();
            RecipeFood rf = new RecipeFood();
            rf.FoodId = foodId;
            rf.IngredientId = ingredientId;
            rf.Quantity = quantity;
            rf.Deleted = 0;
            db.RecipeFood.Add(rf);
            db.SaveChanges();
        }

        public void updateDishRecipe(string dishName, string ingredientName, int quantity)
        {
            var dishId = (from x in db.Dishes where x.DishName.Equals(dishName) select x.DishId).FirstOrDefault();
            var ingredientId = (from x in db.Ingredient where x.IngredientName.Equals(ingredientName) select x.IngredientId).FirstOrDefault();
            var obj = (from x in db.RecipeDish where x.DishId == dishId && x.IngredientId == ingredientId select x).FirstOrDefault();
            obj.Quantity = quantity;
            db.SaveChanges();
        }

        public void updateFoodRecipe(string foodName, string ingredientName, int quantity)
        {
            var foodId = (from x in db.Food where x.FoodName.Equals(foodName) select x.FoodId).FirstOrDefault();
            var ingredientId = (from x in db.Ingredient where x.IngredientName.Equals(ingredientName) select x.IngredientId).FirstOrDefault();
            var obj = (from x in db.RecipeFood where x.FoodId == foodId && x.IngredientId == ingredientId select x).FirstOrDefault();
            obj.Quantity = quantity;
            db.SaveChanges();
        }

        public void deleteDishRecipe(string dishName, string ingredientName)
        {
            var dishId = (from x in db.Dishes where x.DishName.Equals(dishName) select x.DishId).FirstOrDefault();
            var ingredientId = (from x in db.Ingredient where x.IngredientName.Equals(ingredientName) select x.IngredientId).FirstOrDefault();
            var obj = (from x in db.RecipeDish where x.DishId == dishId && x.IngredientId == ingredientId select x).FirstOrDefault();
            obj.Deleted = 1;
            db.SaveChanges();
        }

        public void deleteFoodRecipe(string foodName, string ingredientName)
        {
            var foodId = (from x in db.Food where x.FoodName.Equals(foodName) select x.FoodId).FirstOrDefault();
            var ingredientId = (from x in db.Ingredient where x.IngredientName.Equals(ingredientName) select x.IngredientId).FirstOrDefault();
            var obj = (from x in db.RecipeFood where x.FoodId == foodId && x.IngredientId == ingredientId select x).FirstOrDefault();
            obj.Deleted = 1;
            db.SaveChanges();
        }
    }
}
