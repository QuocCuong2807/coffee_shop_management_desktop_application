using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanlyCoffee.DTO
{
    public class FoodCategory
    {
        private int category_id;

        private string category_name;

        //constructor using field
        public FoodCategory(int category_id, string category_name) 
        {
            this.category_id = category_id;
            this.category_name = category_name;
        }

        //constructor with data from database
        public FoodCategory(DataRow row) 
        {
            this.Category_id = (int)row["category_id"];
            this.category_name = row["category_name"].ToString();
        }

        public int Category_id { get => category_id; set => category_id = value; }
        public string Category_name { get => category_name; set => category_name = value; }
    }
}
