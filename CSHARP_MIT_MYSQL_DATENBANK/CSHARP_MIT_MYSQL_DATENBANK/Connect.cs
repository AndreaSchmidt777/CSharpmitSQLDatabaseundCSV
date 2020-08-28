using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MySql.Data.MySqlClient;

namespace CSHARP_MIT_MYSQL_DATENBANK
{
    class Connect
    {
        public MySqlConnection con;


        public void connection()
        {
            con = new MySqlConnection("datasource= localhost; database=world; port= 3306; username=root; password=avatar123");
            con.Open();
        }
        
    }
}
