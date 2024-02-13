using Negocios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class FormCustomers : Form
    {

        ConnectionSQLN cn = new ConnectionSQLN();
        public FormCustomers()
        {
            InitializeComponent();
        }

        private void btn_showCustomers_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = cn.ShowCustomers();
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_newcustomer_Click(object sender, EventArgs e)
        {
            cn.AddCustomer(txt_name.Text, txt_lastName.Text, txt_Email.Text, txt_phoneNumber.Text);
            dataGridView1.DataSource = cn.ShowCustomers();
        }

        private void btn_deletecustomer_Click(object sender, EventArgs e)
        {
            cn.DeleteCustomer(txt_customerCode.Text);
            dataGridView1.DataSource = cn.ShowCustomers();

        }

        private void btn_updatecustomer_Click(object sender, EventArgs e)
        {
            cn.UpdateCustomer(txt_customerCode.Text, txt_name.Text, txt_lastName.Text, txt_Email.Text, txt_phoneNumber.Text);
            dataGridView1.DataSource = cn.ShowCustomers();
        }
    }
}
