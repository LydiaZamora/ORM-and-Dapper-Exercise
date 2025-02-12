using System.Data;
using Dapper;
using ORM_Dapper;
using ORM_Dapper.Data;

namespace ORM_Dapper
{
    public class DapperDepartmentRepository : IDepartmentRepository
    {
        private readonly IDbConnection _connection;

        public DapperDepartmentRepository(IDbConnection connection)
        {
            _connection = connection;
        }

        public void AddDepartment(string name)
        {
            _connection.Execute(sql: "INSERT INTO departments (Name) Values (@name);", param: new {name});
        }

        public IEnumerable<Department> GetAllDepartments()
        {
            return _connection.Query<Department>(sql: "SELECT * FROM departments;");
        }
    }
}

