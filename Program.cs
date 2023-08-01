using Singleton;
using System.Data;

public class Program
{
    public static void Main(string[] args)
    {
        InsertPerson insertperson = new InsertPerson();
        insertperson.AddPerson(4, "Thomas", 47);

        GetPerson personmanager = new GetPerson();
        DataTable datatable = personmanager.GetAllPersons();
        foreach(DataRow row in datatable.Rows)
        {
            Console.WriteLine($"Name: {row["Name"]}, Age: {row["Age"]}");
        }
    }
}