using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    public class DatabaseSingleton
    {
        //static = only one copy of the instance field, regardless of how many instances of DatabaseSingleton are created
        private static DatabaseSingleton instance;
        private readonly string connectionString;
        private DatabaseSingleton()
        {
            connectionString = "Data Source=LOCALHOST\\SQLEXPRESS;Initial Catalog=Singleton;Integrated Security=True;Encrypt=True;TrustServerCertificate=True";
        }
        public static DatabaseSingleton Instance
        {
            get
            {
                if(instance == null)
                    instance = new DatabaseSingleton();
                return instance;
            }
        }

        public DataTable ExecuteQuery(string query) { 
            using(SqlConnection connection = new SqlConnection(connectionString))
            {
                DataTable datatable = new DataTable();
                try
                {
                    connection.Open();
                    using(SqlCommand command = new SqlCommand(query, connection))
                    {
                        SqlDataAdapter adapter = new SqlDataAdapter(command);
                        adapter.Fill(datatable);
                        /*
                         using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {

                            }
                        }*/
                    }
                }
                catch(Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                return datatable;
            }
        }
    }
}
