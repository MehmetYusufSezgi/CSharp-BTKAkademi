namespace LINQ_EntityFrameworkDemo
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
            this.dgwUrunler = new System.Windows.Forms.DataGridView();
            this.buttonListele = new System.Windows.Forms.Button();
            this.buttonEkle = new System.Windows.Forms.Button();
            this.txtbAd = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtbFiyat = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtbAdet = new System.Windows.Forms.TextBox();
            this.buttonSil = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtbAdetUpdate = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtbFiyatUpdate = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtbAdUpdate = new System.Windows.Forms.TextBox();
            this.buttonDuzenle = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgwUrunler)).BeginInit();
            this.SuspendLayout();
            // 
            // dgwUrunler
            // 
            this.dgwUrunler.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgwUrunler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwUrunler.Location = new System.Drawing.Point(12, 12);
            this.dgwUrunler.Name = "dgwUrunler";
            this.dgwUrunler.Size = new System.Drawing.Size(480, 366);
            this.dgwUrunler.TabIndex = 0;
            this.dgwUrunler.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwUrunler_CellClick);
            this.dgwUrunler.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwUrunler_CellContentClick);
            // 
            // buttonListele
            // 
            this.buttonListele.Location = new System.Drawing.Point(498, 12);
            this.buttonListele.Name = "buttonListele";
            this.buttonListele.Size = new System.Drawing.Size(332, 80);
            this.buttonListele.TabIndex = 1;
            this.buttonListele.Text = "ÜRÜNLERİ LİSTELE";
            this.buttonListele.UseVisualStyleBackColor = true;
            this.buttonListele.Click += new System.EventHandler(this.buttonListele_Click);
            // 
            // buttonEkle
            // 
            this.buttonEkle.Location = new System.Drawing.Point(498, 98);
            this.buttonEkle.Name = "buttonEkle";
            this.buttonEkle.Size = new System.Drawing.Size(98, 91);
            this.buttonEkle.TabIndex = 2;
            this.buttonEkle.Text = "ÜRÜN EKLE";
            this.buttonEkle.UseVisualStyleBackColor = true;
            this.buttonEkle.Click += new System.EventHandler(this.buttonEkle_Click);
            // 
            // txtbAd
            // 
            this.txtbAd.Location = new System.Drawing.Point(673, 98);
            this.txtbAd.Name = "txtbAd";
            this.txtbAd.Size = new System.Drawing.Size(157, 20);
            this.txtbAd.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(602, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "ÜRÜN ADI : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(618, 137);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "FİYATI : ";
            // 
            // txtbFiyat
            // 
            this.txtbFiyat.Location = new System.Drawing.Point(673, 134);
            this.txtbFiyat.Name = "txtbFiyat";
            this.txtbFiyat.Size = new System.Drawing.Size(157, 20);
            this.txtbFiyat.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(618, 172);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "ADEDİ : ";
            // 
            // txtbAdet
            // 
            this.txtbAdet.Location = new System.Drawing.Point(673, 169);
            this.txtbAdet.Name = "txtbAdet";
            this.txtbAdet.Size = new System.Drawing.Size(157, 20);
            this.txtbAdet.TabIndex = 7;
            // 
            // buttonSil
            // 
            this.buttonSil.Location = new System.Drawing.Point(498, 202);
            this.buttonSil.Name = "buttonSil";
            this.buttonSil.Size = new System.Drawing.Size(332, 82);
            this.buttonSil.TabIndex = 9;
            this.buttonSil.Text = "ÜRÜN SİL";
            this.buttonSil.UseVisualStyleBackColor = true;
            this.buttonSil.Click += new System.EventHandler(this.buttonSil_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(622, 364);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "ADEDİ : ";
            // 
            // txtbAdetUpdate
            // 
            this.txtbAdetUpdate.Location = new System.Drawing.Point(677, 361);
            this.txtbAdetUpdate.Name = "txtbAdetUpdate";
            this.txtbAdetUpdate.Size = new System.Drawing.Size(157, 20);
            this.txtbAdetUpdate.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(622, 329);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "FİYATI : ";
            // 
            // txtbFiyatUpdate
            // 
            this.txtbFiyatUpdate.Location = new System.Drawing.Point(677, 326);
            this.txtbFiyatUpdate.Name = "txtbFiyatUpdate";
            this.txtbFiyatUpdate.Size = new System.Drawing.Size(157, 20);
            this.txtbFiyatUpdate.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(606, 293);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "ÜRÜN ADI : ";
            // 
            // txtbAdUpdate
            // 
            this.txtbAdUpdate.Location = new System.Drawing.Point(677, 290);
            this.txtbAdUpdate.Name = "txtbAdUpdate";
            this.txtbAdUpdate.Size = new System.Drawing.Size(157, 20);
            this.txtbAdUpdate.TabIndex = 11;
            // 
            // buttonDuzenle
            // 
            this.buttonDuzenle.Location = new System.Drawing.Point(502, 290);
            this.buttonDuzenle.Name = "buttonDuzenle";
            this.buttonDuzenle.Size = new System.Drawing.Size(98, 91);
            this.buttonDuzenle.TabIndex = 10;
            this.buttonDuzenle.Text = "ÜRÜN DÜZENLE";
            this.buttonDuzenle.UseVisualStyleBackColor = true;
            this.buttonDuzenle.Click += new System.EventHandler(this.buttonDuzenle_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(842, 390);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtbAdetUpdate);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtbFiyatUpdate);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtbAdUpdate);
            this.Controls.Add(this.buttonDuzenle);
            this.Controls.Add(this.buttonSil);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtbAdet);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtbFiyat);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtbAd);
            this.Controls.Add(this.buttonEkle);
            this.Controls.Add(this.buttonListele);
            this.Controls.Add(this.dgwUrunler);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwUrunler)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgwUrunler;
        private System.Windows.Forms.Button buttonListele;
        private System.Windows.Forms.Button buttonEkle;
        private System.Windows.Forms.TextBox txtbAd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtbFiyat;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtbAdet;
        private System.Windows.Forms.Button buttonSil;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtbAdetUpdate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtbFiyatUpdate;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtbAdUpdate;
        private System.Windows.Forms.Button buttonDuzenle;
    }
}

