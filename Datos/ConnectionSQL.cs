using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using Org.BouncyCastle.Asn1.Ocsp;
namespace Datos
{
    public class ConnectionSQL
    {

        string server = "localhost"; //Nombre o ip del servidor de MySQL
        string db = "mysql"; //Nombre de la base de datos
        string user = "root"; //Usuario de acceso a MySQL
        string password = "password"; //Contraseña de usuario de acceso a MySQL
        string data = ""; //Variable para almacenar el resultado

        //Crearemos la cadena de conexión concatenando las variables
        //string cadenaConexion = "Database=" + bd + "; Data Source=" + servidor + "; User Id=" + usuario + "; Password=" + password + "";

        //Instancia para conexión a MySQL, recibe la cadena de conexión
        MySqlConnection connection = new MySqlConnection("server = 127.0.0.1; database=puntodeventa; Uid=root; pwd=;");

        public int querylogin(string User, string Password)
        {
            int count;
            connection.Open();
            string Query = $"SELECT COUNT(*) FROM person WHERE user = '{User}' AND password = '{Password}'";

            MySqlCommand cmd = new MySqlCommand(Query, connection);

            count = Convert.ToInt32(cmd.ExecuteScalar());
            connection.Close();
            return count;
        }

        //public int AddUser(string name, string lastName, int id, int phoneNumber, string user, string password)
        //{

        //    return 1;
        //}

        public DataTable usersQuery()
        {
            string query = "select * from person";

            MySqlCommand cmd = new MySqlCommand(query, connection);

            MySqlDataAdapter data = new MySqlDataAdapter(cmd);

            DataTable tabla = new DataTable();

            data.Fill(tabla);

            return tabla;
        }
    }
}
