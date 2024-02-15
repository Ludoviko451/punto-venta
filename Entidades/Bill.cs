using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Bill
    {
        //    row["Code"]
        //row["Product"] = 
        //row["Quantity"] = 
        //row["Price By Unit"] =
        //row["Discount"] = 
        //row["Total Price"] = 

        private string billCode = "";
        private string code = "";

        private string product = "";

        private string quantity = "";

        private string pricexunit = "";

        private string discount = "";

        private string subTotal = "";

        private string totalPrice = "";

        private string customer = "";


        private string subtotal = "";
        private string total = "";


        public string Code { get => code; set => code = value; }
        public string Product { get => product; set => product = value; }
        public string Quantity { get => quantity; set => quantity = value; }
        public string Pricexunit { get => pricexunit; set => pricexunit = value; }
        public string Discount { get => discount; set => discount = value; }
        public string SubTotal { get => subTotal; set => subTotal = value; }
        public string Subtotal { get => subtotal; set => subtotal = value; }
        public string TotalPrice { get => totalPrice; set => totalPrice = value; }
        public string Customer { get => customer; set => customer = value; }
        public string Total { get => total; set => total = value; }
        public string BillCode { get => billCode; set => billCode = value; }
    }
}
