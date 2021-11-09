using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using THIUWP.Model;

namespace THIUWP.ADO
{
    class UserController
    {
        SqlConnection conn;
        public UserController()
        {
            conn = new SqlConnection(@"Data Source=DESKTOP-K5RBMOI\MSSQLSERVER03;Initial Catalog=master;Persist Security Info=True;User ID=sa;Password=Congluat21092001");
        }
        public bool checkUserLogin(User user)
        {
            if (conn.State == System.Data.ConnectionState.Closed) conn.Open();
            SqlCommand sqlCommand = new SqlCommand("SELECT * FROM users WHERE username = '" + user.username + "' AND password = '" + user.password + "'", conn);
            SqlDataReader dataReader = sqlCommand.ExecuteReader();
            if (dataReader.HasRows)
            {
                dataReader.Close();
                return true;
            }
            dataReader.Close();
            return false;
        }
    }
}
