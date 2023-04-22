using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace EmployeePayrollServiceDB
{
    public class EmployeeRepo
    {
        public static string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Payroll;Integrated Security=true";

        public bool CheckConnection()
        {
            bool result = false;

            SqlConnection connection = new SqlConnection(connectionString);
            try
            {
                connection.Open();

                result = true;
                Console.WriteLine("Connection Established");
                connection.Close();
            }
            catch
            {
                result = false;
            }
            return result;
        }
    }
}
