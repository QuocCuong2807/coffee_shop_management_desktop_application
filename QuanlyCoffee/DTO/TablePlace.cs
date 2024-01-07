using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanlyCoffee.DTO
{
    public class TablePlace
    {
        public static int width = 100;
        public static int height = 100;

        private int table_id;

        private string table_name;

        private string stat;
        public int Table_id { get => table_id; set => table_id = value; }
        public string Table_name { get => table_name; set => table_name = value; }
        public string Stat { get => stat; set => stat = value; }

        public TablePlace(int table_id, string table_name, string stat) 
        {
            Table_id = table_id;
            Table_name = table_name;
            Stat = stat;
        }

        //initialize Table from data row
        public TablePlace(DataRow row) 
        {
            Table_id = (int)row["table_id"];
            Table_name = row["table_name"].ToString();
            Stat = row["stat"].ToString();
        }
    }
}
