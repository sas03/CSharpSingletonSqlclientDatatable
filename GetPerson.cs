using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    public class GetPerson
    {
        private DatabaseSingleton Database;
        public GetPerson()
        {
            Database = DatabaseSingleton.Instance;
        }

        public DataTable GetAllPersons()
        {
            string query = "SELECT * FROM Persons";
            //string query = "INSERT INTO Persons VALUES(3, 'Marthe', 33)";
            return Database.ExecuteQuery(query);
        }
    }
}
