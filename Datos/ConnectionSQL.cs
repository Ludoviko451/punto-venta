using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using Org.BouncyCastle.Asn1.Ocsp;
using Entidades;
using System.Data.SqlClient;
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

        public int AddCustomer(string name, string lastName, string email, string phoneNumber)
        {

            int flag = 0;
            connection.Open();


            string query2 = "SELECT MAX(id) + 1 AS next_id FROM customers";
            MySqlCommand cmd2 = new MySqlCommand(query2, connection);


            object nextId = cmd2.ExecuteScalar();


            if (nextId == DBNull.Value)
            {
                nextId = 1;

            }

            string query = $"insert into customers (customer_name, customer_lastName, customer_phoneNumber, customer_email, customerCode, discount, purchase_quantity) values ('{name}', '{lastName}', '{email}', '{phoneNumber}', 'AED{nextId}', '0', '0')";
            MySqlCommand cmd = new MySqlCommand(query, connection);
            flag = cmd.ExecuteNonQuery();
            connection.Close();

            return flag;
        }


        public int UpdateCustomer(string code, string name, string lastName, string email, string phoneNumber)
        {

            int flag = 0;
            connection.Open();
            string query = $"Update customers set customer_name = '{name}', customer_lastName = '{lastName}', customer_phoneNumber = '{phoneNumber}', customer_email = '{email}' WHERE customerCode = '{code}'";

            MySqlCommand cmd = new MySqlCommand(query, connection);

            flag = cmd.ExecuteNonQuery();
            connection.Close();

            return flag;
        }

        public int DeleteCustomer(string code)
        {

            int flag = 0;
            connection.Open();

            string query = $"Delete from customers where customerCode = '{code}'";

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

        public DataTable customersQuery()
        {
            string query = "select * from customers";

            MySqlCommand cmd = new MySqlCommand(query, connection);

            MySqlDataAdapter data = new MySqlDataAdapter(cmd);

            DataTable table = new DataTable();

            data.Fill(table);

            return table;
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

        public Tuple<string, double> customerQuery(string code)
        {
            connection.Open();

            string query = $"SELECT CONCAT(customer_name, '', customer_lastName) as Name, discount from customers where customerCode = '{code}'";

            MySqlCommand cmd = new MySqlCommand(query, connection);

            MySqlDataReader reg = cmd.ExecuteReader();

            if (reg.Read())
            {
                var result = Tuple.Create(reg["Name"].ToString(), double.Parse(reg["discount"].ToString()));
                connection.Close();
                return result;

            }

            else
            {
                connection.Close();
                return Tuple.Create("Null", 0.0);

            }

        }


        public void InsertBill(List<Bill> F)
        {
            connection.Open();

            foreach(Bill bill in F)
            {

                string query = @"INSERT INTO billing (bill_code, product, price_byUnit, quantity, total_price, customer, customerDiscount, total_amount) 
                             VALUES (@bill_code, @product, @price_byUnit, @quantity, @total_price, @customer, @customerDiscount, @total_amount)";
                MySqlCommand cmd = new MySqlCommand(query, connection);

                cmd.Parameters.AddWithValue("@bill_code", bill.BillCode);
                cmd.Parameters.AddWithValue("@product", bill.Product);
                cmd.Parameters.AddWithValue("@price_byUnit", bill.Pricexunit);
                cmd.Parameters.AddWithValue("@quantity", bill.Quantity);
                cmd.Parameters.AddWithValue("@total_price", bill.TotalPrice);
                cmd.Parameters.AddWithValue("@customer", bill.Customer);
                cmd.Parameters.AddWithValue("@customerDiscount", bill.Discount);
                cmd.Parameters.AddWithValue("@total_amount", bill.Total);

                cmd.ExecuteNonQuery();
            }

            connection.Close();
        }
    }
}
