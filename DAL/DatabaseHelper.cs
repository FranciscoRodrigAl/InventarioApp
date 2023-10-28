using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    internal class DatabaseHelper
    {
        private static DatabaseHelper instance = new DatabaseHelper();

        public static DatabaseHelper Instance
        {
            get { return instance; }
        }

        private static string CONNECTION_STRING = "Data Source=DESKTOP-CHERF4D\\SQLEXPRESS; Initial Catalog=Productos;Integrated Security=True";

        public int ExecuteNonQuery(string query)
        {
            SqlConnection sqlConnection = new SqlConnection(CONNECTION_STRING);
            sqlConnection.Open();
            SqlCommand cmd = new SqlCommand(query, sqlConnection);
            return cmd.ExecuteNonQuery();
        }

        public object ExecuteQuery(string query)
        {
            SqlConnection sqlConnection = new SqlConnection(CONNECTION_STRING);
            sqlConnection.Open();
            SqlCommand cmd = new SqlCommand(query, sqlConnection);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable datatable = new DataTable();
            adapter.Fill(datatable);
            return datatable;

        }
    }
}
