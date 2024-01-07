using QuanlyCoffee.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanlyCoffee.DAO
{
    public class TablePlaceDAO
    {
        private static TablePlaceDAO instance;

        public static TablePlaceDAO Instance
        {
            get { if (instance == null) instance = new TablePlaceDAO(); return instance; }
            private set => instance = value;
        }
        
        private TablePlaceDAO() { }

        public List<TablePlace> GetAllTablePlaces() 
        {
            List<TablePlace> tablePlacesList = new List<TablePlace>();

            string sql = "SELECT * FROM TablePlace";
            DataTable data = DataProvider.GetInstance.ExecuteQuery(sql);
            
            //add data from data table to list table
            foreach (DataRow row in data.Rows) 
            {
                //initialize table by data row
                TablePlace table = new TablePlace(row);
                tablePlacesList.Add(table);
            }

            return tablePlacesList;
        }

        //get table by id

        public TablePlace GetTablePlaceById(int id) 
        {
            string sql = "SELECT * FORM TablePlace WHERE table_id = " + id;
            DataTable data = DataProvider.GetInstance.ExecuteQuery(sql);
            
            return new TablePlace(data.Rows[0]);
        }

        //cập nhật trạng thái có người cho bàn
        public bool updateCheckInTableStatus(TablePlace tablePlace) 
        {
            string sql = "UPDATE TablePlace SET STAT = N'"+"Có người"+"' WHERE table_id = " + tablePlace.Table_id;

            int rowChanged = DataProvider.GetInstance.ExecuteUpdate(sql);

            if(rowChanged > 0)
                return true;
            return false;
        }

        //cập nhật trạng thái trống cho bàn
        public bool updateCheckOutTableStatus(TablePlace tablePlace) 
        {
            string sql = "UPDATE TablePlace SET STAT = N'" + "Trống" + "' WHERE table_id = " + tablePlace.Table_id;
            int rowChanged = DataProvider.GetInstance.ExecuteUpdate(sql);

            if (rowChanged > 0)
                return true;
            return false;
        }

        // thêm bàn mới
        public int insertNewTable(string name) 
        {
            string sql = "INSERT_TABLE @table_name , @stat";
            return DataProvider.GetInstance.ExecuteUpdate(sql, new object[] { name, "Trống" });
        }

        //xoá bàn 
        public int deleteTable(int id) 
        {
            string sql = "DELETE FROM TablePlace WHERE table_id = " + id;
            return DataProvider.GetInstance.ExecuteUpdate(sql);
        }

        //cập nhật bàn ăn
        public int updataTable(TablePlace tablePlace) 
        {
            string sql = "UPDATE TablePlace SET table_name = N'" + tablePlace.Table_name+ "'" +
                                             ", stat = N'" + tablePlace.Stat + "' " +
                                             "Where table_id = " + tablePlace.Table_id;

            return DataProvider.GetInstance.ExecuteUpdate(sql);
        }
    }
}
