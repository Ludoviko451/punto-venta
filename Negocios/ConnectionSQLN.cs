using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;
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
    }
}
