using SQLite.Net.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace THIUWP.Model
{
    
    public class Users
    {
        [PrimaryKey, AutoIncrement]
        public int id { get; set; }
        public string fullname { get; set; }
        public string username { get; set; }

        public string password { get; set; }
    }
}


