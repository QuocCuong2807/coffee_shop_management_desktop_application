using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanlyCoffee.DTO
{
    public class CustomerOrder
    {
        private string foodName;

        private float price;

        private int quantity;

        private int totalPrice;

        //constructor using field
        public CustomerOrder(string foodName, float price, int quantity, int totalPrice) 
        {
            this.foodName = foodName;
            this.price = price;
            this.quantity = quantity;
            this.totalPrice = totalPrice;
        }

        //constructor with data from database
        public CustomerOrder(DataRow row) 
        {
            this.foodName = row["food_name"].ToString();
            this.price = (float)Convert.ToDouble(row["price"].ToString());
            this.quantity = (int)row["food_quntity"];
            this.totalPrice = Int32.Parse(row["totalPrice"].ToString());
        }

        public string FoodName { get => foodName; set => foodName = value; }
        public float Price { get => price; set => price = value; }
        public int Quantity { get => quantity; set => quantity = value; }
        public int TotalPrice { get => totalPrice; set => totalPrice = value; }
    }
}
