namespace Presentacion
{
    partial class FormCustomers
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
            this.btn_showCustomers = new System.Windows.Forms.Button();
            this.lbl_customerCode = new System.Windows.Forms.Label();
            this.txt_customerCode = new System.Windows.Forms.TextBox();
            this.btn_close = new System.Windows.Forms.Button();
            this.txt_phoneNumber = new System.Windows.Forms.TextBox();
            this.txt_lastName = new System.Windows.Forms.TextBox();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.txt_Email = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lbl_email = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_deletecustomer = new System.Windows.Forms.Button();
            this.btn_updatecustomer = new System.Windows.Forms.Button();
            this.btn_newcustomer = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_showCustomers
            // 
            this.btn_showCustomers.Location = new System.Drawing.Point(495, 433);
            this.btn_showCustomers.Name = "btn_showCustomers";
            this.btn_showCustomers.Size = new System.Drawing.Size(75, 23);
            this.btn_showCustomers.TabIndex = 38;
            this.btn_showCustomers.Text = "Show Customers";
            this.btn_showCustomers.UseVisualStyleBackColor = true;
            this.btn_showCustomers.Click += new System.EventHandler(this.btn_showCustomers_Click);
            // 
            // lbl_customerCode
            // 
            this.lbl_customerCode.AutoSize = true;
            this.lbl_customerCode.Location = new System.Drawing.Point(656, 638);
            this.lbl_customerCode.Name = "lbl_customerCode";
            this.lbl_customerCode.Size = new System.Drawing.Size(35, 13);
            this.lbl_customerCode.TabIndex = 37;
            this.lbl_customerCode.Text = "Code:";
            // 
            // txt_customerCode
            // 
            this.txt_customerCode.Location = new System.Drawing.Point(659, 673);
            this.txt_customerCode.Name = "txt_customerCode";
            this.txt_customerCode.Size = new System.Drawing.Size(50, 20);
            this.txt_customerCode.TabIndex = 36;
            // 
            // btn_close
            // 
            this.btn_close.Location = new System.Drawing.Point(778, 638);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(130, 51);
            this.btn_close.TabIndex = 35;
            this.btn_close.Text = "Close";
            this.btn_close.UseVisualStyleBackColor = true;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // txt_phoneNumber
            // 
            this.txt_phoneNumber.Location = new System.Drawing.Point(778, 543);
            this.txt_phoneNumber.Name = "txt_phoneNumber";
            this.txt_phoneNumber.Size = new System.Drawing.Size(190, 20);
            this.txt_phoneNumber.TabIndex = 32;
            // 
            // txt_lastName
            // 
            this.txt_lastName.Location = new System.Drawing.Point(307, 543);
            this.txt_lastName.Name = "txt_lastName";
            this.txt_lastName.Size = new System.Drawing.Size(163, 20);
            this.txt_lastName.TabIndex = 31;
            // 
            // txt_name
            // 
            this.txt_name.Location = new System.Drawing.Point(91, 543);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(155, 20);
            this.txt_name.TabIndex = 30;
            // 
            // txt_Email
            // 
            this.txt_Email.Location = new System.Drawing.Point(551, 543);
            this.txt_Email.Name = "txt_Email";
            this.txt_Email.Size = new System.Drawing.Size(169, 20);
            this.txt_Email.TabIndex = 29;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(775, 505);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 13);
            this.label4.TabIndex = 26;
            this.label4.Text = "Phone Number:";
            // 
            // lbl_email
            // 
            this.lbl_email.AutoSize = true;
            this.lbl_email.Location = new System.Drawing.Point(548, 505);
            this.lbl_email.Name = "lbl_email";
            this.lbl_email.Size = new System.Drawing.Size(35, 13);
            this.lbl_email.TabIndex = 25;
            this.lbl_email.Text = "Email:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(304, 505);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 24;
            this.label2.Text = "Last Name:";
            // 
            // btn_deletecustomer
            // 
            this.btn_deletecustomer.Location = new System.Drawing.Point(430, 638);
            this.btn_deletecustomer.Name = "btn_deletecustomer";
            this.btn_deletecustomer.Size = new System.Drawing.Size(130, 59);
            this.btn_deletecustomer.TabIndex = 23;
            this.btn_deletecustomer.Text = "Delete Customer";
            this.btn_deletecustomer.UseVisualStyleBackColor = true;
            this.btn_deletecustomer.Click += new System.EventHandler(this.btn_deletecustomer_Click);
            // 
            // btn_updatecustomer
            // 
            this.btn_updatecustomer.Location = new System.Drawing.Point(259, 638);
            this.btn_updatecustomer.Name = "btn_updatecustomer";
            this.btn_updatecustomer.Size = new System.Drawing.Size(130, 59);
            this.btn_updatecustomer.TabIndex = 22;
            this.btn_updatecustomer.Text = "Update Customer";
            this.btn_updatecustomer.UseVisualStyleBackColor = true;
            this.btn_updatecustomer.Click += new System.EventHandler(this.btn_updatecustomer_Click);
            // 
            // btn_newcustomer
            // 
            this.btn_newcustomer.Location = new System.Drawing.Point(87, 638);
            this.btn_newcustomer.Name = "btn_newcustomer";
            this.btn_newcustomer.Size = new System.Drawing.Size(130, 59);
            this.btn_newcustomer.TabIndex = 21;
            this.btn_newcustomer.Text = "New Customer";
            this.btn_newcustomer.UseVisualStyleBackColor = true;
            this.btn_newcustomer.Click += new System.EventHandler(this.btn_newcustomer_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(170, 59);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(738, 332);
            this.dataGridView1.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(88, 505);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 39;
            this.label1.Text = "Name:";
            // 
            // FormCustomers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1029, 756);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_showCustomers);
            this.Controls.Add(this.lbl_customerCode);
            this.Controls.Add(this.txt_customerCode);
            this.Controls.Add(this.btn_close);
            this.Controls.Add(this.txt_phoneNumber);
            this.Controls.Add(this.txt_lastName);
            this.Controls.Add(this.txt_name);
            this.Controls.Add(this.txt_Email);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lbl_email);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_deletecustomer);
            this.Controls.Add(this.btn_updatecustomer);
            this.Controls.Add(this.btn_newcustomer);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FormCustomers";
            this.Text = "FormCustomers";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_showCustomers;
        private System.Windows.Forms.Label lbl_customerCode;
        private System.Windows.Forms.TextBox txt_customerCode;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.TextBox txt_phoneNumber;
        private System.Windows.Forms.TextBox txt_lastName;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.TextBox txt_Email;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbl_email;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_deletecustomer;
        private System.Windows.Forms.Button btn_updatecustomer;
        private System.Windows.Forms.Button btn_newcustomer;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
    }
}