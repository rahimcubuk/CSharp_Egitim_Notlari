namespace AdoNetDemo
{
    partial class ProductManager
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgwProducts = new System.Windows.Forms.DataGridView();
            this.chbInsertStatus = new System.Windows.Forms.CheckBox();
            this.btnInsert = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cmbInsertCategory = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtInsertStock = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtInsertPrice = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtInsertName = new System.Windows.Forms.TextBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.cmbUpdateCategory = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtUpdateStock = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtUpdatePrice = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtUpdateName = new System.Windows.Forms.TextBox();
            this.chbUpdateStatus = new System.Windows.Forms.CheckBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwProducts)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgwProducts);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(758, 220);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Product List";
            // 
            // dgwProducts
            // 
            this.dgwProducts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgwProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwProducts.Location = new System.Drawing.Point(6, 21);
            this.dgwProducts.Name = "dgwProducts";
            this.dgwProducts.RowTemplate.Height = 24;
            this.dgwProducts.Size = new System.Drawing.Size(746, 193);
            this.dgwProducts.TabIndex = 3;
            this.dgwProducts.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwProducts_CellClick);
            // 
            // chbInsertStatus
            // 
            this.chbInsertStatus.AutoSize = true;
            this.chbInsertStatus.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chbInsertStatus.Location = new System.Drawing.Point(106, 145);
            this.chbInsertStatus.Name = "chbInsertStatus";
            this.chbInsertStatus.Size = new System.Drawing.Size(74, 21);
            this.chbInsertStatus.TabIndex = 5;
            this.chbInsertStatus.Text = "Status:";
            this.chbInsertStatus.UseVisualStyleBackColor = true;
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(221, 174);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(84, 31);
            this.btnInsert.TabIndex = 6;
            this.btnInsert.Text = "INSERT";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnDelete);
            this.groupBox2.Controls.Add(this.btnUpdate);
            this.groupBox2.Controls.Add(this.cmbUpdateCategory);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txtUpdateStock);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.txtUpdatePrice);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.txtUpdateName);
            this.groupBox2.Controls.Add(this.chbUpdateStatus);
            this.groupBox2.Controls.Add(this.cmbInsertCategory);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txtInsertStock);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txtInsertPrice);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.txtInsertName);
            this.groupBox2.Controls.Add(this.btnInsert);
            this.groupBox2.Controls.Add(this.chbInsertStatus);
            this.groupBox2.Location = new System.Drawing.Point(12, 238);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(758, 213);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Product Manage";
            // 
            // cmbInsertCategory
            // 
            this.cmbInsertCategory.FormattingEnabled = true;
            this.cmbInsertCategory.Items.AddRange(new object[] {
            "Glass",
            "HardDisk",
            "Mouse",
            "Coffee",
            "Laptop"});
            this.cmbInsertCategory.Location = new System.Drawing.Point(163, 61);
            this.cmbInsertCategory.Name = "cmbInsertCategory";
            this.cmbInsertCategory.Size = new System.Drawing.Size(142, 24);
            this.cmbInsertCategory.TabIndex = 15;
            this.cmbInsertCategory.Text = "Categories";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(50, 119);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 17);
            this.label4.TabIndex = 13;
            this.label4.Text = "  Stock Amount:";
            // 
            // txtInsertStock
            // 
            this.txtInsertStock.Location = new System.Drawing.Point(163, 117);
            this.txtInsertStock.Name = "txtInsertStock";
            this.txtInsertStock.Size = new System.Drawing.Size(142, 22);
            this.txtInsertStock.TabIndex = 14;
            this.txtInsertStock.Text = "Stock Amount";
            this.txtInsertStock.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtStock_MouseClick);
            this.txtInsertStock.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtStock_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(56, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 17);
            this.label3.TabIndex = 11;
            this.label3.Text = "       Unit Price: ";
            // 
            // txtInsertPrice
            // 
            this.txtInsertPrice.Location = new System.Drawing.Point(163, 89);
            this.txtInsertPrice.Name = "txtInsertPrice";
            this.txtInsertPrice.Size = new System.Drawing.Size(142, 22);
            this.txtInsertPrice.TabIndex = 12;
            this.txtInsertPrice.Text = "Unit Price";
            this.txtInsertPrice.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtUnitPrice_MouseClick);
            this.txtInsertPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtUnitPrice_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 17);
            this.label1.TabIndex = 9;
            this.label1.Text = "         Category:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(55, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Product Name: ";
            // 
            // txtInsertName
            // 
            this.txtInsertName.Location = new System.Drawing.Point(163, 33);
            this.txtInsertName.Name = "txtInsertName";
            this.txtInsertName.Size = new System.Drawing.Size(142, 22);
            this.txtInsertName.TabIndex = 8;
            this.txtInsertName.Text = "ProductName";
            this.txtInsertName.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtProductName_MouseClick);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(575, 174);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(84, 31);
            this.btnUpdate.TabIndex = 27;
            this.btnUpdate.Text = "UPDATE";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // cmbUpdateCategory
            // 
            this.cmbUpdateCategory.FormattingEnabled = true;
            this.cmbUpdateCategory.Items.AddRange(new object[] {
            "Glass",
            "HardDisk",
            "Mouse",
            "Coffee",
            "Laptop"});
            this.cmbUpdateCategory.Location = new System.Drawing.Point(517, 59);
            this.cmbUpdateCategory.Name = "cmbUpdateCategory";
            this.cmbUpdateCategory.Size = new System.Drawing.Size(142, 24);
            this.cmbUpdateCategory.TabIndex = 26;
            this.cmbUpdateCategory.Text = "Categories";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(404, 117);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 17);
            this.label5.TabIndex = 24;
            this.label5.Text = "  Stock Amount:";
            // 
            // txtUpdateStock
            // 
            this.txtUpdateStock.Location = new System.Drawing.Point(517, 115);
            this.txtUpdateStock.Name = "txtUpdateStock";
            this.txtUpdateStock.Size = new System.Drawing.Size(142, 22);
            this.txtUpdateStock.TabIndex = 25;
            this.txtUpdateStock.Text = "Stock Amount";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(410, 89);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(105, 17);
            this.label6.TabIndex = 22;
            this.label6.Text = "       Unit Price: ";
            // 
            // txtUpdatePrice
            // 
            this.txtUpdatePrice.Location = new System.Drawing.Point(517, 87);
            this.txtUpdatePrice.Name = "txtUpdatePrice";
            this.txtUpdatePrice.Size = new System.Drawing.Size(142, 22);
            this.txtUpdatePrice.TabIndex = 23;
            this.txtUpdatePrice.Text = "Unit Price";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(406, 62);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(105, 17);
            this.label7.TabIndex = 21;
            this.label7.Text = "         Category:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(409, 33);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(106, 17);
            this.label8.TabIndex = 19;
            this.label8.Text = "Product Name: ";
            // 
            // txtUpdateName
            // 
            this.txtUpdateName.Location = new System.Drawing.Point(517, 31);
            this.txtUpdateName.Name = "txtUpdateName";
            this.txtUpdateName.Size = new System.Drawing.Size(142, 22);
            this.txtUpdateName.TabIndex = 20;
            this.txtUpdateName.Text = "ProductName";
            // 
            // chbUpdateStatus
            // 
            this.chbUpdateStatus.AutoSize = true;
            this.chbUpdateStatus.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chbUpdateStatus.Location = new System.Drawing.Point(460, 143);
            this.chbUpdateStatus.Name = "chbUpdateStatus";
            this.chbUpdateStatus.Size = new System.Drawing.Size(74, 21);
            this.chbUpdateStatus.TabIndex = 17;
            this.chbUpdateStatus.Text = "Status:";
            this.chbUpdateStatus.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(485, 174);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(84, 31);
            this.btnDelete.TabIndex = 28;
            this.btnDelete.Text = "DELETE";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // ProductManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 463);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "ProductManager";
            this.Text = "ProductManager";
            this.Load += new System.EventHandler(this.ProductManager_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgwProducts)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgwProducts;
        private System.Windows.Forms.CheckBox chbInsertStatus;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtInsertName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtInsertPrice;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbInsertCategory;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtInsertStock;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.ComboBox cmbUpdateCategory;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtUpdateStock;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtUpdatePrice;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtUpdateName;
        private System.Windows.Forms.CheckBox chbUpdateStatus;
        private System.Windows.Forms.Button btnDelete;
    }
}

