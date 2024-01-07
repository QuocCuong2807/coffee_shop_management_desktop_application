using QuanlyCoffee.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanlyCoffee.DAO
{
    public class StaffDAO
    {
        private static StaffDAO Instance;

        public static StaffDAO getInstance
        {
            get { 
                if (Instance == null) Instance = new StaffDAO(); 
                return Instance; 
            }  
            private set => Instance = value; 
        }

        private StaffDAO() { }

        public Staff logIn(string userName, string passWord) 
        {
            string sql = "proc_logIn @staff_username , @staff_password";

            DataTable data = DataProvider.GetInstance.ExecuteQuery(sql, new object []{ userName , passWord});
            
            if(data.Rows.Count >0 )
                return new Staff(data.Rows[0]);
            else
                return null;
        }

       public Staff getStaffByUserName(string userName) 
        {
            string sql = "GET_STAFF_BY_USERNAME @staff_username";

            DataTable data = DataProvider.GetInstance.ExecuteQuery(sql, new object[] {userName});

            return new Staff(data.Rows[0]);
        }
        
        // lấy ra tên nhân viên
        public string getStaffName(string userName) 
        {
            string sql = "select * from Staff Where staff_username = '" +userName+ "'";
            DataTable data = DataProvider.GetInstance.ExecuteQuery(sql);

            if (data.Rows.Count > 0)
                return new Staff(data.Rows[0]).Staff_fullName;
            return "";
        }

        //lấy tên chức vụ

        public string getStaffRole(string userName)
        {
            string sql = "select * from Staff Where staff_username = '" + userName + "'";
            DataTable data = DataProvider.GetInstance.ExecuteQuery(sql);
            if(data.Rows.Count > 0)
            {
                Staff staff = new Staff(data.Rows[0]);
                if (staff.IsManager)
                    return "Admin";
                return "Staff";
            }    
            return "";
            
        }
    }
}

