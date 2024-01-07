using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanlyCoffee.DTO
{
    public class Staff
    {
        private string staff_username;
        private string staff_password;
        private string staff_fullName;
        private bool isManager;

        public Staff(string staff_username, string staff_password, string staff_fullname, bool isManager) 
        {
            this.staff_username = staff_username;
            this.staff_password = staff_password;
            this.staff_fullName = staff_fullname;
            this.isManager = isManager;
        }

        public Staff(DataRow row) 
        {
            this.staff_username = row["staff_username"].ToString();
            this.staff_password = row["staff_password"].ToString();
            this.staff_fullName = row["staff_fullName"].ToString();
            this.isManager = (bool)row["isManager"];
        }

        public string Staff_username { get => staff_username; set => staff_username = value; }
        public string Staff_password { get => staff_password; set => staff_password = value; }
        public string Staff_fullName { get => staff_fullName; set => staff_fullName = value; }
        public bool IsManager { get => isManager; set => isManager = value; }
    }
}
