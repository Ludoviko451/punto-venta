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
    public partial class MainWindow : Form
    {   
       
        public MainWindow()
        {
            InitializeComponent();
            

            txt_discount.Text = menutxt_discount.Text;

            txt_salesTax.Text = menutxt_salesTax.Text;
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void usersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormUsers v1 = new FormUsers();
            this.Hide();
            v1.ShowDialog();
            this.Show();
        }

        private void inventoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Inventory v1 = new Inventory();
            this.Hide();
            v1.ShowDialog();
            this.Show();
        }

        private void taxAndDiscountChanged(object sender, EventArgs e)
        {
            txt_discount.Text = menutxt_discount.Text;

            txt_salesTax.Text = menutxt_salesTax.Text;
        }
    }
}
