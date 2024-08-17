using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.SqlClient;
using Dapper;

namespace Dapper_Tutorial
{
    internal class Program
    {
        static void Main(string[] args)
        {
            EmployeeDapper dapper = new EmployeeDapper();

            // An object of employee containing the data
            Employee objEmployee = new Employee
            {
                Id = 128734,
                Name = "Jane Doe",
                Age = 25,
                Salary = 900000
            };

            // Insert data into the table
            dapper.insertQueryFunction(objEmployee);

            // Fetch Data from the database
            var EmployeeList = dapper.fetchQueryFunction();
        }
    }
}
