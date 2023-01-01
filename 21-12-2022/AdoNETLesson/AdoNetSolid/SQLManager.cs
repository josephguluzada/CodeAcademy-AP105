using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdoNetSolid
{
    public static class SQLManager
    {
        static string connectionString = "Server=CATALYST\\SQLEXPRESS;Database=AB102WORLD;Trusted_Connection=True";
        static SqlConnection _sqlConnection = null;

        public static SqlConnection SqlConnection
        {
            get
            {
                if (_sqlConnection is null) _sqlConnection = new SqlConnection(connectionString);
                return _sqlConnection;
            }
        }

        public static int ExecuteQuery(string command)
        {
            int check = 0;
            SqlConnection.Open();

            using (SqlCommand sqlCommand = new SqlCommand(command, SqlConnection))
            {
                check =  sqlCommand.ExecuteNonQuery();
            }

            SqlConnection.Close();
            return check;
        }

        public static DataTable Reader(string query)
        {
            DataTable dataTable = new DataTable();
            SqlConnection.Open();

            using(SqlDataAdapter adapter = new SqlDataAdapter(query, SqlConnection))
            {
                adapter.Fill(dataTable);
            }

            SqlConnection.Close();
            return dataTable;
        }

    }
}
