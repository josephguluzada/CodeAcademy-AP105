using System.Data.SqlClient;

namespace AdoNETLesson
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //GetData(18);
            //GetAllDatas();
            //Create();
            Delete(12);
        }



        public static void GetData(int id)
        {
            string connectionString = "Server=CATALYST\\SQLEXPRESS;Database=AB102WORLD;Trusted_Connection=True";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                SqlCommand cmd = new SqlCommand($"SELECT Name FROM Countries WHERE Id = {id}", conn);

                string name = (string)cmd.ExecuteScalar();

                Console.WriteLine(name);
            }
        }

        public static void GetAllDatas()
        {
            string connectionString = "Server=CATALYST\\SQLEXPRESS;Database=AB102WORLD;Trusted_Connection=True";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                SqlCommand sqlCommand = new SqlCommand("SELECT * FROM Countries",conn);

                SqlDataReader reader =  sqlCommand.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        Console.WriteLine($"{reader.GetInt32(0)} - {reader.GetString(1)} {reader.GetDecimal(2)}" );
                    }
                }
            }
        }

        public static void Create()
        {
            string connectionString = "Server=CATALYST\\SQLEXPRESS;Database=AB102WORLD;Trusted_Connection=True";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                SqlCommand sqlCommand = new SqlCommand("INSERT INTO Regions VALUES ('KAMIL')", conn);

                int check = sqlCommand.ExecuteNonQuery();

                if (check > 0) Console.WriteLine("Inserted");
                else Console.WriteLine("Kamil");
            }
        }

        public static void Delete(int id)
        {
            string connectionString = "Server=CATALYST\\SQLEXPRESS;Database=AB102WORLD;Trusted_Connection=True";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                SqlCommand sqlCommand = new SqlCommand($"DELETE FROM Regions WHERE Id = {id}", conn);

                int check = sqlCommand.ExecuteNonQuery();

                if (check > 0) Console.WriteLine("Deleted!");
                else Console.WriteLine("Kamil");

            }
        }

    }
}