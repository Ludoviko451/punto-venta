﻿using System;
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
            cn.AddUser(txt_name.Text, txt_lastName.Text, txt_identityCard.Text, txt_phoneNumber.Text, txt_user.Text, txt_password.Text);
            dataGridView1.DataSource = cn.QueryDT();
        }

        private void btn_updateuser_Click(object sender, EventArgs e)
        {
            cn.UpdateUser(txt_userId.Text, txt_name.Text, txt_lastName.Text, txt_identityCard.Text, txt_phoneNumber.Text, txt_user.Text, txt_password.Text);
            dataGridView1.DataSource = cn.QueryDT();
        }

        private void btn_deleteuser_Click(object sender, EventArgs e)
        {
            cn.DeleteUser(txt_userId.Text);
            dataGridView1.DataSource = cn.QueryDT();
        }   

        private void btn_showUsers_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = cn.QueryDT();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void txt_userId_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_password_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_user_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_phoneNumber_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_lastName_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_name_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_identityCard_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
