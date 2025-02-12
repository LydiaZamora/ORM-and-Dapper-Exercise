using MySql.Data.MySqlClient;
using System.Collections.Generic; 
using System.Data;
using Microsoft.Extensions.Configuration;

namespace ORM_Dapper
{
    public class Program
    {
        static void Main(string[] args)
        {

            var config = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();

            string connString = config.GetConnectionString("DefaultConnection");

            IDbConnection conn = new MySqlConnection(connString);

            var departmentRepo = new DapperDepartmentRepository(conn);

            //departmentRepo.AddDepartment("CSharp - 51");

            var departments = departmentRepo.GetAllDepartments();

            foreach(var department in departments)
            {
                Console.WriteLine
                    ($"ID: {department.DepartmentID} " +
                    $"| Name: {department.Name}");
            }
        }
    }
}
