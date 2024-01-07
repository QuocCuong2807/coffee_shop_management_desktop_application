using QuanlyCoffee.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanlyCoffee.DAO
{
    public class FoodDAO
    {
        private static FoodDAO instance;

        public static FoodDAO getInstance 
        { 
            get { if(instance == null) instance = new FoodDAO(); return instance; } 
            private set => instance = value; 
        }

        private FoodDAO() { }

        public List<Food> getFoodListByCategory(FoodCategory category) 
        {
            List<Food> foodList = new List<Food>();

            string sql = "SELECT * FROM Food Where category_id = " + category.Category_id;

            DataTable data = DataProvider.GetInstance.ExecuteQuery(sql);

            foreach (DataRow row in data.Rows) 
            {
                Food food = new Food(row);
                foodList.Add(food);
            }

            return foodList;
        }

        public Food getFoodById(int id) 
        {
            string sql = "SELECT * FROM Food WHERE food_id = " + id;
            DataTable data = DataProvider.GetInstance.ExecuteQuery(sql);
            return new Food(data.Rows[0]);
        }

        public List<Food> getAllFood() 
        {
            List<Food> foodList = new List<Food>();

            string sql = "SELECT * FROM Food ";

            DataTable data = DataProvider.GetInstance.ExecuteQuery(sql);

            foreach (DataRow row in data.Rows)
            {
                Food food = new Food(row);
                foodList.Add(food);
            }

            return foodList;
        }

        public int insertFood(Food food) 
        {
            string sql = "INSERT_FOOD @food_name , @price , @category_id";
            int rowChanged = DataProvider.GetInstance.ExecuteUpdate(sql , new object[] {food.Food_name , food.Price , food.CategoryId});
            return rowChanged;
        }

        public int deleteFood(Food food) 
        {
            string sql = "delete from Food where food_id = " + food.Food_id;
            int rowChanged = DataProvider.GetInstance.ExecuteUpdate(sql);

            return rowChanged;
        }

        public int updateFood(Food food)
        {
            string sql = "UPDATE FOOD SET food_name = N'" + food.Food_name + "'" +
                                        ", price = " + food.Price+ "" +
                                        ", category_id = " + food.CategoryId + "" +
                                     " WHERE food_id = " + food.Food_id + "";
            int rowChanged = DataProvider.GetInstance.ExecuteUpdate(sql);   
            return rowChanged;
        }
    }
}
