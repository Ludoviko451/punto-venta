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
    public partial class Inventory : Form
    {
        ConnectionSQLN cn = new ConnectionSQLN();
        public Inventory()
        {
            InitializeComponent();
        }

        private void btn_showProducts_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = cn.ShowProducts();
        }
    }
}
