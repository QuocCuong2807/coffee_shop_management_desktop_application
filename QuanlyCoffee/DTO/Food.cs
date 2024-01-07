using QuanlyCoffee.DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.VisualStyles;

namespace QuanlyCoffee.DTO
{
    public class Food
    {
        //attribute
        private int food_id;
        private string food_name;
        private int price;
        private int categoryId;

        //constructor using field
        public Food(int food_id, string food_name, int price, int categoryId) 
        {
            this.food_id = food_id;
            this.food_name = food_name;
            this.price = price;
            this.CategoryId = categoryId;
        }

        public Food (string food_name, int price, int categoryId)
        {
            this.food_name = food_name;
            this.price = price;
            this.categoryId = categoryId;
        }

        //constructor using data from database
        public Food(DataRow row) 
        {
            this.food_id = (int)row["food_id"];
            this.food_name = row["food_name"].ToString();
            this.price = (int)row["price"];
            this.CategoryId = (int)row["category_id"];
        }

        //getter setter
        public int Food_id { get => food_id; set => food_id = value; }
        public string Food_name { get => food_name; set => food_name = value; }
        public int Price { get => price; set => price = value; }
        public int CategoryId { get => categoryId; set => categoryId = value; }
    }
}
