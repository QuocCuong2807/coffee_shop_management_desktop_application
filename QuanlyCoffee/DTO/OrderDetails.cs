using QuanlyCoffee.DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanlyCoffee.DTO
{
    public class OrderDetails
    {
        private int id;
        private Order order;
        private Food food;
        private int food_quantity;

        public OrderDetails(int id, Order order, Food foods, int food_quantity) 
        {
            this.id = id;
            this.order = order;
            this.food = foods;
            this.food_quantity = food_quantity;
        }

        public OrderDetails(DataRow row) 
        {
            this.id = (int)row["id"];
            this.order = OrderDAO.getInstance.GetOrderById(row["orders_id"].ToString());
            this.food = FoodDAO.getInstance.getFoodById((int)row["food_id"]);
            this.food_quantity = (int)row["food_quntity"];
        }

        public int Id { get => id; set => id = value; }
        public Order Order { get => order; set => order = value; }
        public Food Food { get => food; set => food = value; }
        public int Food_quantity { get => food_quantity; set => food_quantity = value; }
    }
}
