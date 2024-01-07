using QuanlyCoffee.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanlyCoffee.DAO
{
    public class OrderDAO
    {
        //singleton
        private static OrderDAO instance;

        public static OrderDAO getInstance
        {
            get { if (instance == null) instance = new OrderDAO(); return instance; }
            private set => instance = value;
        }


        private OrderDAO() { }

        //get order by order id
        public Order GetOrderById(string id)
        {
            string sql = "GET_ORDER_BY_ID @order_id" ;

            DataTable data = DataProvider.GetInstance.ExecuteQuery(sql, new object[] {id});

            return new Order(data.Rows[0]);
        }

        // get unpay order by table
        public Order getUnpayOrderByTable(TablePlace tablePlace) 
        {
            string sql = "SELECT * FROM Orders WHERE table_id = " + tablePlace.Table_id + " and order_status = 0 ";

            DataTable data = DataProvider.GetInstance.ExecuteQuery(sql);

            if(data.Rows.Count > 0)
                return new Order(data.Rows[0]);
            return null;
        }
        
        //thêm và trả về hoá đơn vừa thêm
        public string insertAndReturnOrderID(string staff_username, TablePlace tablePlace) 
        {
            string order_id = GenerateID.getRanDomId();
            staff_username = IsWorkingStaff.staff_id;
            DateTime CheckIn_Date = DateTime.Now;

            string sql = "PROC_INSERT_ORDER @orders_id , @staff_username , @CheckIn_Date , @table_id";

            int rowChanged = DataProvider.GetInstance.ExecuteUpdate(sql, new object[] 
                                                                    { order_id, staff_username, CheckIn_Date, tablePlace.Table_id });

            if (rowChanged > 0)
                return order_id;
            return "";
        }

        //update Order status
        public bool updateOrderStatusAndCheckOutDate(Order order) 
        {
            order.CheckOut_Date1 = DateTime.Now;

            string sql = "UPDATECHECKOUTORDER @checkout_date , @orders_id";
            int rowChanged = DataProvider.GetInstance.ExecuteUpdate(sql , new object[] {order.CheckOut_Date1 , order.Orders_id});
            if (rowChanged > 0)
                return true;
            return false;
        }
    }
}
