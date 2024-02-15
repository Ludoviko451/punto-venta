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
using Entidades;
namespace Presentacion
{
    public partial class MainWindow : Form
    {

        private DataTable dt;
        private double subtotal = 0;
        private double total = 0;
        private double discount = 0;
        private string customer = "";

        ConnectionSQLN cn = new ConnectionSQLN();
        public MainWindow()
        {
            InitializeComponent();


            txt_discount.Text = menutxt_discount.Text;

            txt_salesTax.Text = menutxt_salesTax.Text;

            dt = new DataTable();

            dt.Columns.Add("Code");
            dt.Columns.Add("Product");
            dt.Columns.Add("Price by unit");
            dt.Columns.Add("Quantity");
            dt.Columns.Add("Discount");
            dt.Columns.Add("Total Price");

            dtg_billing.DataSource = dt;

            txt_billNumber.Text = cn.queryBill();
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
        private void btn_addProduct_Click(object sender, EventArgs e)
        {
            var result = cn.inventoryQuery(txt_productCode.Text);
            DataRow row = dt.NewRow();

            row["Code"] = txt_productCode.Text;
            row["Product"] = result.Item1;
            row["Quantity"] = txt_productQuantity.Text;
            // Convertir la representación entera del precio a double y dividir por 100
            double precio = double.Parse(result.Item2) / 100.0;
            row["Price By Unit"] = precio.ToString("0.00"); // Formatear a dos decimales
            row["Discount"] = txt_discount.Text;
            row["Total Price"] = Int32.Parse(txt_productQuantity.Text) * precio;

            subtotal = subtotal + (Int32.Parse(txt_productQuantity.Text) * precio);
            dt.Rows.Add(row);


            discount = double.Parse(menutxt_discount.Text);
            if (discount == 0)
            {
                total = subtotal + (subtotal * (double.Parse(txt_salesTax.Text) / 100));
            } else
            {
                total = subtotal + (subtotal * (double.Parse(txt_salesTax.Text) / 100));
                total = total - (total * (discount / 100));
            }


            lbl_subTotal.Text = subtotal.ToString("0.00"); // Formatear subtotal a dos decimales

            lbl_total.Text = total.ToString("0.00"); // Formatear total a dos decimales
        }

        private void btn_searchClient_Click(object sender, EventArgs e) {

            var result = cn.customerQuery(txt_clientCode.Text);

            txt_customerName.Text = result.Item1;

            customer = result.Item1;

            menutxt_discount.Text = result.Item2.ToString();
    
        }

        private void customersMenu_Click(object sender, EventArgs e)
        {
            FormCustomers v1 = new FormCustomers();
            this.Hide();
            v1.ShowDialog();
            this.Show();
        }

        private void btn_bill_Click(object sender, EventArgs e)
        {
          
            List < Bill > billList = new List<Bill>();
            foreach (DataRow row in dt.Rows)
            {
                Bill bill = new Bill();

                bill.Code = row["Code"].ToString();
                bill.Product = row["Product"].ToString();
                bill.Pricexunit = row["Price By Unit"].ToString();
                bill.Quantity = row["Quantity"].ToString();
                bill.Discount = row["Discount"].ToString();
                bill.SubTotal = subtotal.ToString();
                bill.TotalPrice = row["Total Price"].ToString();
                bill.Customer = customer;
                bill.Subtotal = subtotal.ToString("0.00");
                bill.BillCode = txt_billNumber.Text;

                bill.Total = total.ToString("0.00");
                billList.Add(bill);

            }

            cn.InsertBill(billList);
        }
    }
}
