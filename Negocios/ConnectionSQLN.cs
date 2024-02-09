using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;
using MySql.Data.MySqlClient;
namespace Negocios
{
    public class ConnectionSQLN
    {

        ConnectionSQL cn = new ConnectionSQL();

        public int conSQL(string user, string pass)
        {

            return cn.querylogin(user, pass);
        }

        public DataTable QueryDT()
        {
            return cn.usersQuery();
        }

        public int AddUser(string name, string lastName, string id, string phoneNumber, string user, string password)
        {


            return cn.AddUser(name, lastName, id, phoneNumber, user, password);
        }

        public int UpdateUser(string id, string name, string lastName, string identification, string phoneNumber, string user, string password)
        {

           return cn.UpdateUser(id, name, lastName, identification, phoneNumber, user, password);
        }

        public int DeleteUser(string id)
        {

            return cn.DeleteUser(id);
        }
    }
}
