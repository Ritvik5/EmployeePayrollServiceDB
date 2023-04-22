using System.Data.SqlClient;

namespace EmployeePayrollServiceDB
{
     class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to ADO.NET");


            EmployeeRepo emp = new EmployeeRepo();
            emp.CheckConnection();
        }
    }
}