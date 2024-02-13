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

        public DataTable ShowCustomers()
        {
            return cn.customersQuery();
        }

        public DataTable ShowProducts()
        {
            return cn.productsQuery();
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

        public int AddCustomer(string name, string lastName, string email, string phoneNumber)
        {


            return cn.AddCustomer(name, lastName, email, phoneNumber);
        }

        public int UpdateCustomer(string code, string name, string lastName, string email, string phoneNumber) { 

            return cn.UpdateCustomer(code, name, lastName, email, phoneNumber);
        }

        public int DeleteCustomer(string code)
        {

            return cn.DeleteCustomer(code);
        }
        public string queryBill()
        {
            return cn.billQuery();
        }

        public Tuple<string, string> inventoryQuery(string code)
        {
            return cn.inventoryQuery(code);
        }

        public Tuple<string, double> customerQuery(string code)
        {
            return cn.customerQuery(code);
        }
    }
}
