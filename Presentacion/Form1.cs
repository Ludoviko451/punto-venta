using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Negocios;
namespace Presentacion
{
    public partial class Login : Form
    {



        ConnectionSQLN cn = new ConnectionSQLN();
        public Login()
        {
            InitializeComponent();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            if (cn.conSQL(txt_user.Text, txt_password.Text) == 1)
            {
                MessageBox.Show("User Found");


                this.Hide();

                VentanaPrincipal v1 = new VentanaPrincipal();

                v1.Show();
            }
            else
            {
                MessageBox.Show("User not found");
            }
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
