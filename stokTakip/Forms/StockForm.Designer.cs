namespace stokTakip.Forms
{
    partial class StockForm
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
            this.tbUserStockCode = new System.Windows.Forms.MaskedTextBox();
            this.tbbarcode = new System.Windows.Forms.MaskedTextBox();
            this.tbstockName = new System.Windows.Forms.MaskedTextBox();
            this.cbmeasurementUnit = new System.Windows.Forms.ComboBox();
            this.cbwarehouse = new System.Windows.Forms.ComboBox();
            this.cbexchangeRate = new System.Windows.Forms.ComboBox();
            this.tbpiece = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.cbCategory = new System.Windows.Forms.ComboBox();
            this.cbSubCategory = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.tbexchangeRateValue = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.tbunitPrice = new System.Windows.Forms.TextBox();
            this.tbtotalPrice = new System.Windows.Forms.TextBox();
            this.tbkdv = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbUserStockCode
            // 
            this.tbUserStockCode.Location = new System.Drawing.Point(108, 32);
            this.tbUserStockCode.Mask = "0000000000";
            this.tbUserStockCode.Name = "tbUserStockCode";
            this.tbUserStockCode.Size = new System.Drawing.Size(225, 22);
            this.tbUserStockCode.TabIndex = 1;
            // 
            // tbbarcode
            // 
            this.tbbarcode.Location = new System.Drawing.Point(108, 82);
            this.tbbarcode.Mask = "0000000000";
            this.tbbarcode.Name = "tbbarcode";
            this.tbbarcode.Size = new System.Drawing.Size(225, 22);
            this.tbbarcode.TabIndex = 2;
            // 
            // tbstockName
            // 
            this.tbstockName.Location = new System.Drawing.Point(108, 134);
            this.tbstockName.Mask = "LLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLL";
            this.tbstockName.Name = "tbstockName";
            this.tbstockName.Size = new System.Drawing.Size(225, 22);
            this.tbstockName.TabIndex = 3;
            // 
            // cbmeasurementUnit
            // 
            this.cbmeasurementUnit.FormattingEnabled = true;
            this.cbmeasurementUnit.Location = new System.Drawing.Point(450, 131);
            this.cbmeasurementUnit.Name = "cbmeasurementUnit";
            this.cbmeasurementUnit.Size = new System.Drawing.Size(225, 24);
            this.cbmeasurementUnit.TabIndex = 4;
            // 
            // cbwarehouse
            // 
            this.cbwarehouse.FormattingEnabled = true;
            this.cbwarehouse.Location = new System.Drawing.Point(450, 31);
            this.cbwarehouse.Name = "cbwarehouse";
            this.cbwarehouse.Size = new System.Drawing.Size(225, 24);
            this.cbwarehouse.TabIndex = 5;
            // 
            // cbexchangeRate
            // 
            this.cbexchangeRate.FormattingEnabled = true;
            this.cbexchangeRate.Location = new System.Drawing.Point(17, 35);
            this.cbexchangeRate.Name = "cbexchangeRate";
            this.cbexchangeRate.Size = new System.Drawing.Size(225, 24);
            this.cbexchangeRate.TabIndex = 7;
            this.cbexchangeRate.SelectedIndexChanged += new System.EventHandler(this.cbexchangeRate_SelectedIndexChanged);
            // 
            // tbpiece
            // 
            this.tbpiece.Location = new System.Drawing.Point(450, 81);
            this.tbpiece.Name = "tbpiece";
            this.tbpiece.Size = new System.Drawing.Size(225, 22);
            this.tbpiece.TabIndex = 10;
            this.tbpiece.TextChanged += new System.EventHandler(this.tbunitPrice_TextChanged_1);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(13, 537);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(1152, 47);
            this.button1.TabIndex = 11;
            this.button1.Text = "Stok Ekle";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cbCategory
            // 
            this.cbCategory.FormattingEnabled = true;
            this.cbCategory.Location = new System.Drawing.Point(60, 51);
            this.cbCategory.Name = "cbCategory";
            this.cbCategory.Size = new System.Drawing.Size(193, 24);
            this.cbCategory.TabIndex = 12;
            this.cbCategory.SelectedIndexChanged += new System.EventHandler(this.cbCategory_SelectedIndexChanged);
            // 
            // cbSubCategory
            // 
            this.cbSubCategory.FormattingEnabled = true;
            this.cbSubCategory.Location = new System.Drawing.Point(60, 105);
            this.cbSubCategory.Name = "cbSubCategory";
            this.cbSubCategory.Size = new System.Drawing.Size(193, 24);
            this.cbSubCategory.TabIndex = 13;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbCategory);
            this.groupBox1.Controls.Add(this.cbSubCategory);
            this.groupBox1.Location = new System.Drawing.Point(853, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(310, 178);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kategori";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.tbUserStockCode);
            this.groupBox2.Controls.Add(this.tbbarcode);
            this.groupBox2.Controls.Add(this.tbstockName);
            this.groupBox2.Controls.Add(this.tbpiece);
            this.groupBox2.Controls.Add(this.cbwarehouse);
            this.groupBox2.Controls.Add(this.cbmeasurementUnit);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(835, 178);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.tbexchangeRateValue);
            this.groupBox3.Controls.Add(this.cbexchangeRate);
            this.groupBox3.Location = new System.Drawing.Point(13, 209);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1150, 129);
            this.groupBox3.TabIndex = 16;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Döviz";
            // 
            // tbexchangeRateValue
            // 
            this.tbexchangeRateValue.Location = new System.Drawing.Point(17, 89);
            this.tbexchangeRateValue.Name = "tbexchangeRateValue";
            this.tbexchangeRateValue.Size = new System.Drawing.Size(100, 22);
            this.tbexchangeRateValue.TabIndex = 8;
            this.tbexchangeRateValue.TextChanged += new System.EventHandler(this.tbunitPrice_TextChanged_1);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.tbkdv);
            this.groupBox4.Controls.Add(this.tbtotalPrice);
            this.groupBox4.Controls.Add(this.tbunitPrice);
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Location = new System.Drawing.Point(13, 345);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(1152, 163);
            this.groupBox4.TabIndex = 17;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "groupBox4";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 17);
            this.label1.TabIndex = 11;
            this.label1.Text = "Stok kodu";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 17);
            this.label2.TabIndex = 12;
            this.label2.Text = "Barkod";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 17);
            this.label3.TabIndex = 13;
            this.label3.Text = "Stok Adı";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(357, 38);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 17);
            this.label4.TabIndex = 14;
            this.label4.Text = "Depo";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(360, 86);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 17);
            this.label5.TabIndex = 15;
            this.label5.Text = "Adet";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(360, 138);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 17);
            this.label6.TabIndex = 16;
            this.label6.Text = "Ölçü Birimi";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(23, 42);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(32, 17);
            this.label7.TabIndex = 10;
            this.label7.Text = "Kdv";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(23, 82);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(73, 17);
            this.label8.TabIndex = 11;
            this.label8.Text = "Birim Fiyat";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(26, 120);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(89, 17);
            this.label9.TabIndex = 12;
            this.label9.Text = "Toplam Fiyat";
            // 
            // tbunitPrice
            // 
            this.tbunitPrice.Location = new System.Drawing.Point(122, 79);
            this.tbunitPrice.Name = "tbunitPrice";
            this.tbunitPrice.Size = new System.Drawing.Size(225, 22);
            this.tbunitPrice.TabIndex = 13;
            this.tbunitPrice.TextChanged += new System.EventHandler(this.tbunitPrice_TextChanged_1);
            // 
            // tbtotalPrice
            // 
            this.tbtotalPrice.Location = new System.Drawing.Point(122, 120);
            this.tbtotalPrice.Name = "tbtotalPrice";
            this.tbtotalPrice.Size = new System.Drawing.Size(225, 22);
            this.tbtotalPrice.TabIndex = 14;
            // 
            // tbkdv
            // 
            this.tbkdv.Location = new System.Drawing.Point(122, 36);
            this.tbkdv.Name = "tbkdv";
            this.tbkdv.Size = new System.Drawing.Size(225, 22);
            this.tbkdv.TabIndex = 15;
            this.tbkdv.TextChanged += new System.EventHandler(this.tbunitPrice_TextChanged_1);
            // 
            // StockForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1182, 611);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "StockForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StockForm";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.MaskedTextBox tbUserStockCode;
        private System.Windows.Forms.MaskedTextBox tbbarcode;
        private System.Windows.Forms.MaskedTextBox tbstockName;
        private System.Windows.Forms.ComboBox cbmeasurementUnit;
        private System.Windows.Forms.ComboBox cbwarehouse;
        private System.Windows.Forms.ComboBox cbexchangeRate;
        private System.Windows.Forms.TextBox tbpiece;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox cbCategory;
        private System.Windows.Forms.ComboBox cbSubCategory;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox tbexchangeRateValue;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbunitPrice;
        private System.Windows.Forms.TextBox tbtotalPrice;
        private System.Windows.Forms.TextBox tbkdv;
    }
}