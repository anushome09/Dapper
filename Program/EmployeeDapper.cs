using Dapper;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dapper_Tutorial
{
    public class EmployeeDapper
    {
        string connectionString = "Server = (localdb)\\MSSQLLocalDB; Database = Local Database; Integrated Security = true";
        SqlConnection connection = null;

        public EmployeeDapper()
        {
            connection = new SqlConnection(connectionString);
        }

        // Query to insert data into the database using dapper
        public void insertQueryFunction(Employee employee)
        {
            // SQL Query to insert new elements
            string insertQuery = "INSERT INTO Employee(Id, Name, Age, Salary) VALUES(@Id, @Name, @Age, @Salary)";

            // executing the query
            connection.Query(insertQuery, employee);
        }

        // Query to fetch data from the database
        public List<Employee> fetchQueryFunction()
        {
            // SQL Query to fetch data
            string fetchQuery = "SELECT * FROM Employee";

            List<Employee> employees = connection.Query<Employee>(fetchQuery).ToList();

            return employees;
        }
    }
}
