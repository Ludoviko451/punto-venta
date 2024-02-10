namespace Presentacion
{
    partial class Inventory
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btn_addProduct = new System.Windows.Forms.Button();
            this.btn_updateProduct = new System.Windows.Forms.Button();
            this.btn_deleteProduct = new System.Windows.Forms.Button();
            this.lbl_productName = new System.Windows.Forms.Label();
            this.lbl_category = new System.Windows.Forms.Label();
            this.lbl_price = new System.Windows.Forms.Label();
            this.lbl_quantity = new System.Windows.Forms.Label();
            this.txt_productName = new System.Windows.Forms.TextBox();
            this.txt_category = new System.Windows.Forms.TextBox();
            this.txt_price = new System.Windows.Forms.TextBox();
            this.txt_quantity = new System.Windows.Forms.TextBox();
            this.txt_productId = new System.Windows.Forms.TextBox();
            this.lbl_id = new System.Windows.Forms.Label();
            this.btn_showProducts = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Presentacion.Properties.Resources.store;
            this.pictureBox1.Location = new System.Drawing.Point(815, 23);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(146, 123);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(88, 23);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(663, 368);
            this.dataGridView1.TabIndex = 1;
            // 
            // btn_addProduct
            // 
            this.btn_addProduct.Location = new System.Drawing.Point(134, 548);
            this.btn_addProduct.Name = "btn_addProduct";
            this.btn_addProduct.Size = new System.Drawing.Size(151, 65);
            this.btn_addProduct.TabIndex = 2;
            this.btn_addProduct.Text = "ADD PRODUCT";
            this.btn_addProduct.UseVisualStyleBackColor = true;
            // 
            // btn_updateProduct
            // 
            this.btn_updateProduct.Location = new System.Drawing.Point(351, 548);
            this.btn_updateProduct.Name = "btn_updateProduct";
            this.btn_updateProduct.Size = new System.Drawing.Size(151, 65);
            this.btn_updateProduct.TabIndex = 3;
            this.btn_updateProduct.Text = "UPDATE PRODUCT";
            this.btn_updateProduct.UseVisualStyleBackColor = true;
            // 
            // btn_deleteProduct
            // 
            this.btn_deleteProduct.Location = new System.Drawing.Point(578, 548);
            this.btn_deleteProduct.Name = "btn_deleteProduct";
            this.btn_deleteProduct.Size = new System.Drawing.Size(151, 65);
            this.btn_deleteProduct.TabIndex = 4;
            this.btn_deleteProduct.Text = "DELETE PRODUCT";
            this.btn_deleteProduct.UseVisualStyleBackColor = true;
            // 
            // lbl_productName
            // 
            this.lbl_productName.AutoSize = true;
            this.lbl_productName.Location = new System.Drawing.Point(108, 436);
            this.lbl_productName.Name = "lbl_productName";
            this.lbl_productName.Size = new System.Drawing.Size(75, 13);
            this.lbl_productName.TabIndex = 5;
            this.lbl_productName.Text = "Product Name";
            // 
            // lbl_category
            // 
            this.lbl_category.AutoSize = true;
            this.lbl_category.Location = new System.Drawing.Point(288, 436);
            this.lbl_category.Name = "lbl_category";
            this.lbl_category.Size = new System.Drawing.Size(49, 13);
            this.lbl_category.TabIndex = 6;
            this.lbl_category.Text = "Category";
            // 
            // lbl_price
            // 
            this.lbl_price.AutoSize = true;
            this.lbl_price.Location = new System.Drawing.Point(484, 436);
            this.lbl_price.Name = "lbl_price";
            this.lbl_price.Size = new System.Drawing.Size(31, 13);
            this.lbl_price.TabIndex = 7;
            this.lbl_price.Text = "Price";
            // 
            // lbl_quantity
            // 
            this.lbl_quantity.AutoSize = true;
            this.lbl_quantity.Location = new System.Drawing.Point(637, 436);
            this.lbl_quantity.Name = "lbl_quantity";
            this.lbl_quantity.Size = new System.Drawing.Size(46, 13);
            this.lbl_quantity.TabIndex = 8;
            this.lbl_quantity.Text = "Quantity";
            // 
            // txt_productName
            // 
            this.txt_productName.Location = new System.Drawing.Point(111, 460);
            this.txt_productName.Name = "txt_productName";
            this.txt_productName.Size = new System.Drawing.Size(100, 20);
            this.txt_productName.TabIndex = 9;
            // 
            // txt_category
            // 
            this.txt_category.Location = new System.Drawing.Point(291, 460);
            this.txt_category.Name = "txt_category";
            this.txt_category.Size = new System.Drawing.Size(100, 20);
            this.txt_category.TabIndex = 10;
            // 
            // txt_price
            // 
            this.txt_price.Location = new System.Drawing.Point(487, 460);
            this.txt_price.Name = "txt_price";
            this.txt_price.Size = new System.Drawing.Size(100, 20);
            this.txt_price.TabIndex = 11;
            // 
            // txt_quantity
            // 
            this.txt_quantity.Location = new System.Drawing.Point(640, 460);
            this.txt_quantity.Name = "txt_quantity";
            this.txt_quantity.Size = new System.Drawing.Size(100, 20);
            this.txt_quantity.TabIndex = 12;
            // 
            // txt_productId
            // 
            this.txt_productId.Location = new System.Drawing.Point(765, 571);
            this.txt_productId.Name = "txt_productId";
            this.txt_productId.Size = new System.Drawing.Size(100, 20);
            this.txt_productId.TabIndex = 14;
            // 
            // lbl_id
            // 
            this.lbl_id.AutoSize = true;
            this.lbl_id.Location = new System.Drawing.Point(762, 547);
            this.lbl_id.Name = "lbl_id";
            this.lbl_id.Size = new System.Drawing.Size(21, 13);
            this.lbl_id.TabIndex = 13;
            this.lbl_id.Text = "ID:";
            // 
            // btn_showProducts
            // 
            this.btn_showProducts.Location = new System.Drawing.Point(777, 206);
            this.btn_showProducts.Name = "btn_showProducts";
            this.btn_showProducts.Size = new System.Drawing.Size(151, 65);
            this.btn_showProducts.TabIndex = 15;
            this.btn_showProducts.Text = "SHOW PRODUCTS";
            this.btn_showProducts.UseVisualStyleBackColor = true;
            this.btn_showProducts.Click += new System.EventHandler(this.btn_showProducts_Click);
            // 
            // Inventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(973, 625);
            this.Controls.Add(this.btn_showProducts);
            this.Controls.Add(this.txt_productId);
            this.Controls.Add(this.lbl_id);
            this.Controls.Add(this.txt_quantity);
            this.Controls.Add(this.txt_price);
            this.Controls.Add(this.txt_category);
            this.Controls.Add(this.txt_productName);
            this.Controls.Add(this.lbl_quantity);
            this.Controls.Add(this.lbl_price);
            this.Controls.Add(this.lbl_category);
            this.Controls.Add(this.lbl_productName);
            this.Controls.Add(this.btn_deleteProduct);
            this.Controls.Add(this.btn_updateProduct);
            this.Controls.Add(this.btn_addProduct);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Inventory";
            this.Text = "Inventory";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_addProduct;
        private System.Windows.Forms.Button btn_updateProduct;
        private System.Windows.Forms.Button btn_deleteProduct;
        private System.Windows.Forms.Label lbl_productName;
        private System.Windows.Forms.Label lbl_category;
        private System.Windows.Forms.Label lbl_price;
        private System.Windows.Forms.Label lbl_quantity;
        private System.Windows.Forms.TextBox txt_productName;
        private System.Windows.Forms.TextBox txt_category;
        private System.Windows.Forms.TextBox txt_price;
        private System.Windows.Forms.TextBox txt_quantity;
        private System.Windows.Forms.TextBox txt_productId;
        private System.Windows.Forms.Label lbl_id;
        private System.Windows.Forms.Button btn_showProducts;
    }
}