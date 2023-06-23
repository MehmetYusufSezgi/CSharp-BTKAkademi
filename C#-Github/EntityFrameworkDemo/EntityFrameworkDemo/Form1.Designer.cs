namespace EntityFrameworkDemo
{
    partial class Form1
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.txbProductNameUpdate = new System.Windows.Forms.TextBox();
            this.txbStockAmountUpdate = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txbProductPriceUpdate = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txbProductName = new System.Windows.Forms.TextBox();
            this.txbStockAmount = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txbProductPrice = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dgwProducts = new System.Windows.Forms.DataGridView();
            this.buttonRemove = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.txbSearch = new System.Windows.Forms.TextBox();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwProducts)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.buttonUpdate);
            this.groupBox2.Controls.Add(this.txbProductNameUpdate);
            this.groupBox2.Controls.Add(this.txbStockAmountUpdate);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txbProductPriceUpdate);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Location = new System.Drawing.Point(302, 267);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(213, 155);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Update product";
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Location = new System.Drawing.Point(91, 121);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(100, 23);
            this.buttonUpdate.TabIndex = 10;
            this.buttonUpdate.Text = "Update";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // txbProductNameUpdate
            // 
            this.txbProductNameUpdate.Location = new System.Drawing.Point(91, 19);
            this.txbProductNameUpdate.Name = "txbProductNameUpdate";
            this.txbProductNameUpdate.Size = new System.Drawing.Size(100, 20);
            this.txbProductNameUpdate.TabIndex = 4;
            // 
            // txbStockAmountUpdate
            // 
            this.txbStockAmountUpdate.Location = new System.Drawing.Point(91, 71);
            this.txbStockAmountUpdate.Name = "txbStockAmountUpdate";
            this.txbStockAmountUpdate.Size = new System.Drawing.Size(100, 20);
            this.txbStockAmountUpdate.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(50, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Name";
            // 
            // txbProductPriceUpdate
            // 
            this.txbProductPriceUpdate.Location = new System.Drawing.Point(91, 45);
            this.txbProductPriceUpdate.Name = "txbProductPriceUpdate";
            this.txbProductPriceUpdate.Size = new System.Drawing.Size(100, 20);
            this.txbProductPriceUpdate.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(54, 48);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Price";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(11, 74);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "Stock Amount";
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(145, 388);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(87, 23);
            this.buttonAdd.TabIndex = 12;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txbProductName);
            this.groupBox1.Controls.Add(this.txbStockAmount);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txbProductPrice);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(54, 267);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(213, 155);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add new product";
            // 
            // txbProductName
            // 
            this.txbProductName.Location = new System.Drawing.Point(91, 19);
            this.txbProductName.Name = "txbProductName";
            this.txbProductName.Size = new System.Drawing.Size(100, 20);
            this.txbProductName.TabIndex = 4;
            // 
            // txbStockAmount
            // 
            this.txbStockAmount.Location = new System.Drawing.Point(91, 71);
            this.txbStockAmount.Name = "txbStockAmount";
            this.txbStockAmount.Size = new System.Drawing.Size(100, 20);
            this.txbStockAmount.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Name";
            // 
            // txbProductPrice
            // 
            this.txbProductPrice.Location = new System.Drawing.Point(91, 45);
            this.txbProductPrice.Name = "txbProductPrice";
            this.txbProductPrice.Size = new System.Drawing.Size(100, 20);
            this.txbProductPrice.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(54, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Price";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Stock Amount";
            // 
            // dgwProducts
            // 
            this.dgwProducts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgwProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwProducts.Location = new System.Drawing.Point(12, 48);
            this.dgwProducts.Name = "dgwProducts";
            this.dgwProducts.Size = new System.Drawing.Size(649, 189);
            this.dgwProducts.TabIndex = 10;
            this.dgwProducts.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwProducts_CellClick);
            // 
            // buttonRemove
            // 
            this.buttonRemove.Location = new System.Drawing.Point(571, 305);
            this.buttonRemove.Name = "buttonRemove";
            this.buttonRemove.Size = new System.Drawing.Size(80, 53);
            this.buttonRemove.TabIndex = 14;
            this.buttonRemove.Text = "Remove";
            this.buttonRemove.UseVisualStyleBackColor = true;
            this.buttonRemove.Click += new System.EventHandler(this.buttonRemove_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(465, 21);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Search : ";
            // 
            // txbSearch
            // 
            this.txbSearch.Location = new System.Drawing.Point(521, 18);
            this.txbSearch.Name = "txbSearch";
            this.txbSearch.Size = new System.Drawing.Size(100, 20);
            this.txbSearch.TabIndex = 16;
            this.txbSearch.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(691, 437);
            this.Controls.Add(this.txbSearch);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.buttonRemove);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgwProducts);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwProducts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.TextBox txbProductNameUpdate;
        private System.Windows.Forms.TextBox txbStockAmountUpdate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txbProductPriceUpdate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txbProductName;
        private System.Windows.Forms.TextBox txbStockAmount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbProductPrice;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgwProducts;
        private System.Windows.Forms.Button buttonRemove;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txbSearch;
    }
}

