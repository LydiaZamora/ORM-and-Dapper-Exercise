using System;
using System.Collections.Generic;
using System.Data;
namespace ORM_Dapper
{
	public class DapperDepartmentRepository : IDepartmentRepository
	{

        private readonly IDbConnection_connection;

		public DapperDepartmentRepository()
		{
		}

        public IEnumerable<Department> GetAllDepartments()
		{

		}
	}
}

