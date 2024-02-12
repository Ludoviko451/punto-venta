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

        public int AddUser(string name, string lastName, string id, string phoneNumber, string user, string password)
        {

            int flag = 0;
            connection.Open();
            string query = $"insert into person (name, last_name, identity_card, user, password, phone_number) values ('{name}', '{lastName}', '{id}', '{user}', '{password}',  '{phoneNumber}')";

            MySqlCommand cmd = new MySqlCommand(query, connection);

            flag = cmd.ExecuteNonQuery();
            connection.Close();

            return flag;
        }


        public int UpdateUser(string id, string name, string lastName, string identification, string phoneNumber, string user, string password)
        {

            int flag = 0;
            connection.Open();
            string query = $"Update person set name = '{name}', last_name = '{lastName}', identity_card = '{identification}', user = '{user}', password = '{password}', phone_number = '{phoneNumber}' WHERE id = '{id}'";

            MySqlCommand cmd = new MySqlCommand(query, connection);

            flag = cmd.ExecuteNonQuery();
            connection.Close();

            return flag;
        }

        public int DeleteUser(string id) {

            int flag = 0;
            connection.Open();

            string query = $"Delete from person where id = '{id}'";

            MySqlCommand cmd = new MySqlCommand(query, connection);

            flag = cmd.ExecuteNonQuery();

            connection.Close();

            return flag;
        }


        public DataTable usersQuery()
        {
            string query = "select * from person";

            MySqlCommand cmd = new MySqlCommand(query, connection);

            MySqlDataAdapter data = new MySqlDataAdapter(cmd);

            DataTable tabla = new DataTable();

            data.Fill(tabla);

            return tabla;
        }

        public DataTable productsQuery()
        {
            string query = "select * from inventory";

            MySqlCommand cmd = new MySqlCommand(query, connection);

            MySqlDataAdapter data = new MySqlDataAdapter(cmd);

            DataTable tabla = new DataTable();

            data.Fill(tabla);

            return tabla;
        }

        public string billQuery()
        {
            connection.Open();

            string query = "SELECT MAX(bill_code) + 1 AS next_bill_code FROM billing";

            MySqlCommand cmd = new MySqlCommand(query, connection);


            object nextBillCode = cmd.ExecuteScalar();


            if (nextBillCode != DBNull.Value)
            {
                connection.Close();
                return nextBillCode.ToString();
                
            }
            else
            {
                connection.Close();
                return "1";
                
            }
           

        }


        public Tuple<string, string> inventoryQuery(string code)
        {
            connection.Open();

            string query = $"SELECT * from inventory where Code = '{code}'";

            MySqlCommand cmd = new MySqlCommand(query, connection);

            MySqlDataReader reg = cmd.ExecuteReader();

            if (reg.Read())
            {   
                var result = Tuple.Create(reg["product_name"].ToString(), reg["price"].ToString());
                connection.Close();
                return result;
               
            }

            else
            {
                connection.Close();
                return Tuple.Create("Null", "");
                
            }
           
        }

    }
}
