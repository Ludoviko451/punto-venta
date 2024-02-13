namespace Presentacion
{
    partial class MainWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_close = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.taxesandDiscount = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_salesTax = new System.Windows.Forms.ToolStripMenuItem();
            this.menutxt_salesTax = new System.Windows.Forms.ToolStripTextBox();
            this.menu_discount = new System.Windows.Forms.ToolStripMenuItem();
            this.menutxt_discount = new System.Windows.Forms.ToolStripTextBox();
            this.usersMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.inventoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dtg_billing = new System.Windows.Forms.DataGridView();
            this.lbl_clientCode = new System.Windows.Forms.Label();
            this.txt_clientCode = new System.Windows.Forms.TextBox();
            this.btn_searchClient = new System.Windows.Forms.Button();
            this.lbl_billNumber = new System.Windows.Forms.Label();
            this.lbl_client = new System.Windows.Forms.Label();
            this.txt_billNumber = new System.Windows.Forms.TextBox();
            this.txt_customerName = new System.Windows.Forms.TextBox();
            this.lbl_total = new System.Windows.Forms.Label();
            this.lbl_subTotal = new System.Windows.Forms.Label();
            this.lbl_subTotalprice = new System.Windows.Forms.Label();
            this.lbl_totalPrice = new System.Windows.Forms.Label();
            this.lbl_salesTax = new System.Windows.Forms.Label();
            this.lbl_discount = new System.Windows.Forms.Label();
            this.txt_discount = new System.Windows.Forms.TextBox();
            this.txt_salesTax = new System.Windows.Forms.TextBox();
            this.txt_productCode = new System.Windows.Forms.TextBox();
            this.lbl_productCode = new System.Windows.Forms.Label();
            this.txt_productQuantity = new System.Windows.Forms.TextBox();
            this.lbl_productQuantity = new System.Windows.Forms.Label();
            this.btn_addProduct = new System.Windows.Forms.Button();
            this.btn_bill = new System.Windows.Forms.Button();
            this.customersMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_billing)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_close
            // 
            this.btn_close.Location = new System.Drawing.Point(695, 403);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(88, 35);
            this.btn_close.TabIndex = 0;
            this.btn_close.Text = "Close";
            this.btn_close.UseVisualStyleBackColor = true;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(482, 65);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(8, 8);
            this.button2.TabIndex = 1;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.usersMenu,
            this.inventoryToolStripMenuItem,
            this.customersMenu});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(851, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.taxesandDiscount});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(59, 20);
            this.toolStripMenuItem1.Text = "Archive";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // taxesandDiscount
            // 
            this.taxesandDiscount.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu_salesTax,
            this.menu_discount});
            this.taxesandDiscount.Name = "taxesandDiscount";
            this.taxesandDiscount.Size = new System.Drawing.Size(177, 22);
            this.taxesandDiscount.Text = "Taxes And Discount";
            // 
            // menu_salesTax
            // 
            this.menu_salesTax.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menutxt_salesTax});
            this.menu_salesTax.Name = "menu_salesTax";
            this.menu_salesTax.Size = new System.Drawing.Size(121, 22);
            this.menu_salesTax.Text = "Sales Tax";
            // 
            // menutxt_salesTax
            // 
            this.menutxt_salesTax.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.menutxt_salesTax.Name = "menutxt_salesTax";
            this.menutxt_salesTax.Size = new System.Drawing.Size(100, 23);
            this.menutxt_salesTax.Text = "21";
            this.menutxt_salesTax.TextChanged += new System.EventHandler(this.taxAndDiscountChanged);
            // 
            // menu_discount
            // 
            this.menu_discount.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menutxt_discount});
            this.menu_discount.Name = "menu_discount";
            this.menu_discount.Size = new System.Drawing.Size(121, 22);
            this.menu_discount.Text = "Discount";
            // 
            // menutxt_discount
            // 
            this.menutxt_discount.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.menutxt_discount.Name = "menutxt_discount";
            this.menutxt_discount.Size = new System.Drawing.Size(100, 23);
            this.menutxt_discount.Text = "0";
            this.menutxt_discount.TextChanged += new System.EventHandler(this.taxAndDiscountChanged);
            // 
            // usersMenu
            // 
            this.usersMenu.Name = "usersMenu";
            this.usersMenu.Size = new System.Drawing.Size(47, 20);
            this.usersMenu.Text = "Users";
            this.usersMenu.Click += new System.EventHandler(this.usersToolStripMenuItem_Click);
            // 
            // inventoryToolStripMenuItem
            // 
            this.inventoryToolStripMenuItem.Name = "inventoryToolStripMenuItem";
            this.inventoryToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.inventoryToolStripMenuItem.Text = "Inventory";
            this.inventoryToolStripMenuItem.Click += new System.EventHandler(this.inventoryToolStripMenuItem_Click);
            // 
            // dtg_billing
            // 
            this.dtg_billing.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_billing.Location = new System.Drawing.Point(316, 56);
            this.dtg_billing.Name = "dtg_billing";
            this.dtg_billing.Size = new System.Drawing.Size(467, 214);
            this.dtg_billing.TabIndex = 4;
            // 
            // lbl_clientCode
            // 
            this.lbl_clientCode.AutoSize = true;
            this.lbl_clientCode.Location = new System.Drawing.Point(116, 200);
            this.lbl_clientCode.Name = "lbl_clientCode";
            this.lbl_clientCode.Size = new System.Drawing.Size(64, 13);
            this.lbl_clientCode.TabIndex = 5;
            this.lbl_clientCode.Text = "Client Code:";
            // 
            // txt_clientCode
            // 
            this.txt_clientCode.Location = new System.Drawing.Point(84, 235);
            this.txt_clientCode.Name = "txt_clientCode";
            this.txt_clientCode.Size = new System.Drawing.Size(115, 20);
            this.txt_clientCode.TabIndex = 6;
            // 
            // btn_searchClient
            // 
            this.btn_searchClient.Location = new System.Drawing.Point(105, 261);
            this.btn_searchClient.Name = "btn_searchClient";
            this.btn_searchClient.Size = new System.Drawing.Size(75, 23);
            this.btn_searchClient.TabIndex = 7;
            this.btn_searchClient.Text = "Search";
            this.btn_searchClient.UseVisualStyleBackColor = true;
            this.btn_searchClient.Click += new System.EventHandler(this.btn_searchClient_Click);
            // 
            // lbl_billNumber
            // 
            this.lbl_billNumber.AutoSize = true;
            this.lbl_billNumber.Location = new System.Drawing.Point(312, 33);
            this.lbl_billNumber.Name = "lbl_billNumber";
            this.lbl_billNumber.Size = new System.Drawing.Size(63, 13);
            this.lbl_billNumber.TabIndex = 8;
            this.lbl_billNumber.Text = "Bill Number:";
            // 
            // lbl_client
            // 
            this.lbl_client.AutoSize = true;
            this.lbl_client.Location = new System.Drawing.Point(516, 33);
            this.lbl_client.Name = "lbl_client";
            this.lbl_client.Size = new System.Drawing.Size(36, 13);
            this.lbl_client.TabIndex = 9;
            this.lbl_client.Text = "Client:";
            // 
            // txt_billNumber
            // 
            this.txt_billNumber.Location = new System.Drawing.Point(381, 30);
            this.txt_billNumber.Name = "txt_billNumber";
            this.txt_billNumber.ReadOnly = true;
            this.txt_billNumber.Size = new System.Drawing.Size(69, 20);
            this.txt_billNumber.TabIndex = 10;
            // 
            // txt_customerName
            // 
            this.txt_customerName.Location = new System.Drawing.Point(558, 30);
            this.txt_customerName.Name = "txt_customerName";
            this.txt_customerName.ReadOnly = true;
            this.txt_customerName.Size = new System.Drawing.Size(224, 20);
            this.txt_customerName.TabIndex = 11;
            // 
            // lbl_total
            // 
            this.lbl_total.AutoSize = true;
            this.lbl_total.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_total.Location = new System.Drawing.Point(248, 383);
            this.lbl_total.Name = "lbl_total";
            this.lbl_total.Size = new System.Drawing.Size(75, 31);
            this.lbl_total.TabIndex = 12;
            this.lbl_total.Text = "Total";
            // 
            // lbl_subTotal
            // 
            this.lbl_subTotal.AutoSize = true;
            this.lbl_subTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_subTotal.Location = new System.Drawing.Point(38, 385);
            this.lbl_subTotal.Name = "lbl_subTotal";
            this.lbl_subTotal.Size = new System.Drawing.Size(130, 31);
            this.lbl_subTotal.TabIndex = 13;
            this.lbl_subTotal.Text = "Sub Total";
            // 
            // lbl_subTotalprice
            // 
            this.lbl_subTotalprice.AutoSize = true;
            this.lbl_subTotalprice.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_subTotalprice.Location = new System.Drawing.Point(38, 422);
            this.lbl_subTotalprice.Name = "lbl_subTotalprice";
            this.lbl_subTotalprice.Size = new System.Drawing.Size(67, 31);
            this.lbl_subTotalprice.TabIndex = 14;
            this.lbl_subTotalprice.Text = "0.00";
            // 
            // lbl_totalPrice
            // 
            this.lbl_totalPrice.AutoSize = true;
            this.lbl_totalPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_totalPrice.Location = new System.Drawing.Point(249, 420);
            this.lbl_totalPrice.Name = "lbl_totalPrice";
            this.lbl_totalPrice.Size = new System.Drawing.Size(67, 31);
            this.lbl_totalPrice.TabIndex = 15;
            this.lbl_totalPrice.Text = "0.00";
            // 
            // lbl_salesTax
            // 
            this.lbl_salesTax.AutoSize = true;
            this.lbl_salesTax.Location = new System.Drawing.Point(269, 328);
            this.lbl_salesTax.Name = "lbl_salesTax";
            this.lbl_salesTax.Size = new System.Drawing.Size(57, 13);
            this.lbl_salesTax.TabIndex = 16;
            this.lbl_salesTax.Text = "Sales Tax:";
            // 
            // lbl_discount
            // 
            this.lbl_discount.AutoSize = true;
            this.lbl_discount.Location = new System.Drawing.Point(269, 355);
            this.lbl_discount.Name = "lbl_discount";
            this.lbl_discount.Size = new System.Drawing.Size(49, 13);
            this.lbl_discount.TabIndex = 17;
            this.lbl_discount.Text = "Discount";
            // 
            // txt_discount
            // 
            this.txt_discount.Location = new System.Drawing.Point(355, 351);
            this.txt_discount.Name = "txt_discount";
            this.txt_discount.ReadOnly = true;
            this.txt_discount.Size = new System.Drawing.Size(34, 20);
            this.txt_discount.TabIndex = 18;
            // 
            // txt_salesTax
            // 
            this.txt_salesTax.Location = new System.Drawing.Point(355, 325);
            this.txt_salesTax.Name = "txt_salesTax";
            this.txt_salesTax.ReadOnly = true;
            this.txt_salesTax.Size = new System.Drawing.Size(34, 20);
            this.txt_salesTax.TabIndex = 19;
            // 
            // txt_productCode
            // 
            this.txt_productCode.Location = new System.Drawing.Point(441, 351);
            this.txt_productCode.Name = "txt_productCode";
            this.txt_productCode.Size = new System.Drawing.Size(92, 20);
            this.txt_productCode.TabIndex = 21;
            // 
            // lbl_productCode
            // 
            this.lbl_productCode.AutoSize = true;
            this.lbl_productCode.Location = new System.Drawing.Point(438, 326);
            this.lbl_productCode.Name = "lbl_productCode";
            this.lbl_productCode.Size = new System.Drawing.Size(75, 13);
            this.lbl_productCode.TabIndex = 20;
            this.lbl_productCode.Text = "Product Code:";
            // 
            // txt_productQuantity
            // 
            this.txt_productQuantity.Location = new System.Drawing.Point(560, 351);
            this.txt_productQuantity.Name = "txt_productQuantity";
            this.txt_productQuantity.Size = new System.Drawing.Size(92, 20);
            this.txt_productQuantity.TabIndex = 23;
            // 
            // lbl_productQuantity
            // 
            this.lbl_productQuantity.AutoSize = true;
            this.lbl_productQuantity.Location = new System.Drawing.Point(557, 326);
            this.lbl_productQuantity.Name = "lbl_productQuantity";
            this.lbl_productQuantity.Size = new System.Drawing.Size(49, 13);
            this.lbl_productQuantity.TabIndex = 22;
            this.lbl_productQuantity.Text = "Quantity:";
            // 
            // btn_addProduct
            // 
            this.btn_addProduct.Location = new System.Drawing.Point(441, 381);
            this.btn_addProduct.Name = "btn_addProduct";
            this.btn_addProduct.Size = new System.Drawing.Size(211, 35);
            this.btn_addProduct.TabIndex = 24;
            this.btn_addProduct.Text = "Add Product";
            this.btn_addProduct.UseVisualStyleBackColor = true;
            this.btn_addProduct.Click += new System.EventHandler(this.btn_addProduct_Click);
            // 
            // btn_bill
            // 
            this.btn_bill.Location = new System.Drawing.Point(695, 313);
            this.btn_bill.Name = "btn_bill";
            this.btn_bill.Size = new System.Drawing.Size(88, 68);
            this.btn_bill.TabIndex = 25;
            this.btn_bill.Text = "Bill";
            this.btn_bill.UseVisualStyleBackColor = true;
            this.btn_bill.Click += new System.EventHandler(this.btn_bill_Click);
            // 
            // customersMenu
            // 
            this.customersMenu.Name = "customersMenu";
            this.customersMenu.Size = new System.Drawing.Size(76, 20);
            this.customersMenu.Text = "Customers";
            this.customersMenu.Click += new System.EventHandler(this.customersMenu_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Presentacion.Properties.Resources.cash_register;
            this.pictureBox1.Location = new System.Drawing.Point(84, 56);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(125, 122);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(851, 465);
            this.Controls.Add(this.btn_bill);
            this.Controls.Add(this.btn_addProduct);
            this.Controls.Add(this.txt_productQuantity);
            this.Controls.Add(this.lbl_productQuantity);
            this.Controls.Add(this.txt_productCode);
            this.Controls.Add(this.lbl_productCode);
            this.Controls.Add(this.txt_salesTax);
            this.Controls.Add(this.txt_discount);
            this.Controls.Add(this.lbl_discount);
            this.Controls.Add(this.lbl_salesTax);
            this.Controls.Add(this.lbl_totalPrice);
            this.Controls.Add(this.lbl_subTotalprice);
            this.Controls.Add(this.lbl_subTotal);
            this.Controls.Add(this.lbl_total);
            this.Controls.Add(this.txt_customerName);
            this.Controls.Add(this.txt_billNumber);
            this.Controls.Add(this.lbl_client);
            this.Controls.Add(this.lbl_billNumber);
            this.Controls.Add(this.btn_searchClient);
            this.Controls.Add(this.txt_clientCode);
            this.Controls.Add(this.lbl_clientCode);
            this.Controls.Add(this.dtg_billing);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btn_close);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainWindow";
            this.Text = "Point of sale";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_billing)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem taxesandDiscount;
        private System.Windows.Forms.ToolStripMenuItem usersMenu;
        private System.Windows.Forms.ToolStripMenuItem inventoryToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dtg_billing;
        private System.Windows.Forms.Label lbl_clientCode;
        private System.Windows.Forms.TextBox txt_clientCode;
        private System.Windows.Forms.Button btn_searchClient;
        private System.Windows.Forms.Label lbl_billNumber;
        private System.Windows.Forms.Label lbl_client;
        private System.Windows.Forms.TextBox txt_billNumber;
        private System.Windows.Forms.TextBox txt_customerName;
        private System.Windows.Forms.Label lbl_total;
        private System.Windows.Forms.Label lbl_subTotal;
        private System.Windows.Forms.Label lbl_subTotalprice;
        private System.Windows.Forms.Label lbl_totalPrice;
        private System.Windows.Forms.Label lbl_salesTax;
        private System.Windows.Forms.Label lbl_discount;
        private System.Windows.Forms.TextBox txt_discount;
        private System.Windows.Forms.TextBox txt_salesTax;
        private System.Windows.Forms.TextBox txt_productCode;
        private System.Windows.Forms.Label lbl_productCode;
        private System.Windows.Forms.TextBox txt_productQuantity;
        private System.Windows.Forms.Label lbl_productQuantity;
        private System.Windows.Forms.Button btn_addProduct;
        private System.Windows.Forms.Button btn_bill;
        private System.Windows.Forms.ToolStripMenuItem menu_salesTax;
        private System.Windows.Forms.ToolStripMenuItem menu_discount;
        private System.Windows.Forms.ToolStripTextBox menutxt_salesTax;
        private System.Windows.Forms.ToolStripTextBox menutxt_discount;
        private System.Windows.Forms.ToolStripMenuItem customersMenu;
    }
}