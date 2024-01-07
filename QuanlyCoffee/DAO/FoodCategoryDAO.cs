using QuanlyCoffee.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanlyCoffee.DAO
{
    public class FoodCategoryDAO
    {
        private static FoodCategoryDAO instance;

        public static FoodCategoryDAO Instance 
        {
            get { if (instance == null) instance = new FoodCategoryDAO(); return instance; } 
            private set => instance = value; 
        }
        private FoodCategoryDAO() { }

        public FoodCategory GetById(int id) 
        {
            string sql = "SELECT * FROM FoodCategory WHERE category_id = " + id;
            DataTable data = DataProvider.GetInstance.ExecuteQuery(sql);
            if(data.Rows.Count > 0)
                return new FoodCategory(data.Rows[0]);
            return null;
        }

        public List<FoodCategory> getAllCategory() 
        {
            List<FoodCategory> list = new List<FoodCategory> ();
            string sql = "SELECT * FROM FoodCategory";
            DataTable data = DataProvider.GetInstance.ExecuteQuery(sql);
            foreach (DataRow row in data.Rows) 
            {
                FoodCategory category = new FoodCategory(row);
                list.Add(category);
            }
            return list;
        }
        
        public int addNewCategory(string category_name) 
        {
            string sql = "INSERT_NEW_CATE @category_name";

            int rowChenged = DataProvider.GetInstance.ExecuteUpdate(sql, new object[] { category_name });

            return rowChenged;
        }

        public int deleteCategory(FoodCategory category) 
        {
            string sql = "DEL_CATEGORY @category_id";

            int rowChanged = DataProvider.GetInstance.ExecuteUpdate(sql, new object[] {category.Category_id});

            return rowChanged;
        }

        public int updateCategory(string name, int id) 
        {
            string sql = "UPDATE FoodCategory SET category_name = N'" +name +"'" +
                                              "WHERE category_id = " + id;

            int rowChanged = DataProvider.GetInstance.ExecuteUpdate(sql);

            return rowChanged;
        }

    }
}
