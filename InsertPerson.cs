using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    public class InsertPerson
    {
        private DatabaseSingleton Database;
        public InsertPerson()
        {
            Database = DatabaseSingleton.Instance;
        }
        public void AddPerson(int id, string name, int age)
        {
            string query = "INSERT INTO Persons VALUES(" + id + ", 'Thomas', " + age + ")";
            Database.ExecuteQuery(query);
        }
    }
}
