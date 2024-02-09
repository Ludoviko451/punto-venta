using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Negocios;
namespace Presentacion
{
    public partial class FormUsers : Form
    {

        ConnectionSQLN cn = new ConnectionSQLN();
        public FormUsers()
        {
            InitializeComponent();
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_newuser_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = cn.QueryDT();
        }

        private void btn_updateuser_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = cn.QueryDT();
        }

        private void btn_deleteuser_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = cn.QueryDT();
        }
    }
}
