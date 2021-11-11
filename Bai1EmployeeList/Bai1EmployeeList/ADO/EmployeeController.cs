using Bai1EmployeeList.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai1EmployeeList.ADO
{
    class EmployeeController
    {
        SqlConnection conn;
        public EmployeeController()
        {
            conn = new SqlConnection(@"Data Source=DESKTOP-K5RBMOI\MSSQLSERVER03;Initial Catalog=master;Persist Security Info=True;User ID=sa;Password=Congluat21092001");
        }
        public List<Employee> GetAllEmployee()
        {
            if (conn.State == System.Data.ConnectionState.Closed)
                conn.Open();
            List<Employee> listEmployee = new List<Employee>();
            SqlCommand sqlCommand = new SqlCommand("SELECT id, name, role, birthyear FROM [Employee]", conn);
            SqlDataReader dataReader = sqlCommand.ExecuteReader();

            if (dataReader.HasRows)
            {
                while (dataReader.Read())
                {
                    Employee employee = new Employee();

                    employee.Id = Convert.ToInt32(dataReader["id"]);
                    employee.Name = dataReader["name"].ToString();
                    employee.Role = dataReader["role"].ToString();
                    employee.Birthyear = Convert.ToInt32(dataReader["birthyear"]);

                    listEmployee.Add(employee);
                }
                dataReader.Close();
                sqlCommand.Dispose();
            }

            return listEmployee;
        }
    }

}
