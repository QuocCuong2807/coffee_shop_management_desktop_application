using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanlyCoffee.DAO
{
    internal class DataProvider
    {
        private string connectionString = "Data Source=ADMIN\\SQLEXPRESS;Initial Catalog=QL_KENBARCOFFEE;Integrated Security=True";

        private static DataProvider Instance;

        public static DataProvider GetInstance 
        { 
            get 
            { 
                if (Instance == null) Instance = new DataProvider(); return Instance; 
            } 
            private set => Instance = value; 
        }

        private DataProvider() { }

        //execute query
        public DataTable ExecuteQuery(string sql, object[] parameterValue = null) 
        {
            //create data table
            DataTable data = new DataTable();
            //create connection to db
            using (SqlConnection connection = new SqlConnection(connectionString)) 
            {
                //open connection
                connection.Open();

                //create SqlCommand and SqlDataAdapter
                SqlCommand cmd = new SqlCommand(sql, connection);

                //split parameter in sql stament if sql stament have parameter
                if(parameterValue != null)
                {
                    //split sql stament by whit space
                    string [] listSplit = sql.Split(' ');

                    int i = 0;

                    foreach (string splitItem in listSplit)
                    {
                        if (splitItem.Contains('@')) 
                        {
                            cmd.Parameters.AddWithValue(splitItem, parameterValue[i]);//add value to parameter
                            i++;
                        }
                        
                    }
                }

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);

                //fill data to data table
                adapter.Fill(data);

                //close connection
                connection.Close();
            }
            return data;
        }

        //execute update
        public int ExecuteUpdate(string sql, object[] parameterValue = null)
        {
            //create data table
            int rowNumber = 0;
            //create connection to db
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                //open connection
                connection.Open();

                //create SqlCommand and SqlDataAdapter
                SqlCommand cmd = new SqlCommand(sql, connection);

                //split parameter in sql stament
                if (parameterValue != null)
                {
                    //split sql stament by whit space
                    string[] listSplit = sql.Split(' ');

                    int i = 0;

                    foreach (string splitItem in listSplit)
                    {
                        if (splitItem.Contains('@'))
                        {
                            cmd.Parameters.AddWithValue(splitItem, parameterValue[i]);//add value to parameter
                            i++;
                        }
                    }
                }

                rowNumber = cmd.ExecuteNonQuery();

                //close connection
                connection.Close();
            }
            return rowNumber;
        }
    }
}
