using THIUWPB1.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace THIUWPB1.ADO
{
    class EmployeeController
    {
        SqlConnection connnect;

        public EmployeeController()
        {
            connnect = new SqlConnection(@"Data Source=DESKTOP-K5RBMOI\MSSQLSERVER03;Initial Catalog=master;Persist Security Info=True;User ID=sa;Password=Congluat21092001");
        }
        public List<Employee> GetAllEmployee()
        {
            if (connnect.State == System.Data.ConnectionState.Closed)
                connnect.Open();


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


                }
                dataReader.Close();
                sqlCommand.Dispose();
            }

            return listEmployee;
        }
    }
}
