using QuanlyCoffee.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanlyCoffee.DAO
{
    public class CustomerOrderDAO
    {
        private static CustomerOrderDAO instance;

        public static CustomerOrderDAO getInstance 
        {
            get { if (instance == null) instance = new CustomerOrderDAO(); return instance; } 
            private set => instance = value; 
        }

        public List<CustomerOrder> GetUnPayCustomerOrders(TablePlace table) 
        {
            List<CustomerOrder> list = new List<CustomerOrder>();

            string sql = "select f.food_name , f.price , od.food_quntity , f.price * od.food_quntity as totalPrice " +
                         "from Orders o join OrderDetais od on o.orders_id = od.orders_id " +
                                       "join Food f on f.food_id = od.food_id " +
                                       "where o.table_id = " + table.Table_id + " and o.order_status = 0 ";

            DataTable data = DataProvider.GetInstance.ExecuteQuery(sql);
            foreach (DataRow row in data.Rows) 
            {
                CustomerOrder order = new CustomerOrder(row);
                list.Add(order);
            }

            return list;
        }
    }
}
