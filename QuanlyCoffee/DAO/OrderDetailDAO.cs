using QuanlyCoffee.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanlyCoffee.DAO
{
    public class OrderDetailDAO
    {
        private static OrderDetailDAO instance;

        public static OrderDetailDAO getInstance 
        { 
            get { if(instance == null) instance = new OrderDetailDAO(); return instance; } 
            private set => instance = value; }

        private OrderDetailDAO() { }

        public bool insertOrderDetailsByOrder(Order order, Food food, int food_quantity) 
        {
            string sql = "PROC_INSERT_ORDERDETAIL @orders_id , @food_id , @food_quantity";
            int rowChanged = DataProvider.GetInstance.ExecuteUpdate(sql, new object[] { order.Orders_id, food.Food_id, food_quantity });
            if(rowChanged > 0)
                return true;
            return false;
        }

        //get orderdetails by food id and order id
        public OrderDetails GetOrderDetailsByFoodAndOrderID(Food food, Order order) 
        {
            string sql = "GetOrderDetailsByFoodAndOrderID @food_id , @orders_id";

            DataTable data = DataProvider.GetInstance.ExecuteQuery(sql, new object[] {food.Food_id , order.Orders_id});

            if (data.Rows.Count > 0)
                return new OrderDetails(data.Rows[0]);
            return null;
        }

        //cập nhật lại số lượng món dựa trên order details id
        public bool updateFoodQuantityByOrderDetailsID(OrderDetails orderDetails, int quantity) 
        {
            int oldQuantity = orderDetails.Food_quantity;
            int newQuantity = oldQuantity + quantity;

            string sql = "UPDATE OrderDetais SET food_quntity = " + newQuantity + " WHERE id = '" + orderDetails.Id + "'";

            int rowChanged = DataProvider.GetInstance.ExecuteUpdate(sql);

            if (rowChanged > 0)
                return true;
            return false;
        } 

    }
}
