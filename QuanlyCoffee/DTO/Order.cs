using QuanlyCoffee.DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanlyCoffee.DTO
{
    public class Order
    {
        private string orders_id;
        private DateTime? CheckIn_Date;
        private DateTime? CheckOut_Date;
        private TablePlace table;
        private Staff staff;
        private int order_status;

        //constructor with fields
        public Order(string orders_id, DateTime? CheckIn_Date, DateTime? CheckOut_Date, TablePlace table, Staff staff, int order_status) 
        {
            this.orders_id = orders_id;
            this.CheckIn_Date = CheckIn_Date;
            this.CheckOut_Date = CheckOut_Date;
            this.table = table;
            this.staff = staff;
            this.order_status = order_status;
        }

        //constructor with data from database

        public Order(DataRow row) 
        {
            this.orders_id = row["orders_id"].ToString();
            this.CheckIn_Date = (DateTime)row["CheckIn_Date"];

            if(row["CheckOut_Date"].ToString() != "")
                this.CheckOut_Date = (DateTime?)row["CheckOut_Date"];
            else 
                this.CheckIn_Date = null;
            this.staff = StaffDAO.getInstance.getStaffByUserName(row["staff_username"].ToString());
            this.order_status = (int)row["order_status"];

        }

        public string Orders_id { get => orders_id; set => orders_id = value; }
        public DateTime? CheckIn_Date1 { get => CheckIn_Date; set => CheckIn_Date = value; }
        public DateTime? CheckOut_Date1 { get => CheckOut_Date; set => CheckOut_Date = value; }
        public TablePlace Table { get => table; set => table = value; }
        public Staff Staff { get => staff; set => staff = value; }
        public int Order_status { get => order_status; set => order_status = value; }
    }
}
