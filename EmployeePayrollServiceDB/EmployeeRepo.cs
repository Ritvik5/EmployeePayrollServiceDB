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
        SqlConnection connection = new SqlConnection(connectionString);
    }

}
