namespace stokTakip
{
    partial class MainForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.kullaniciIslemleri = new System.Windows.Forms.ToolStripMenuItem();
            this.addUserMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.changePwd = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteUser = new System.Windows.Forms.ToolStripMenuItem();
            this.kategoriİşlemleriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuCategory = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuSubCategory = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuCompany = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuMeasurement = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuExchange = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuRepository = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuStock = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuAuthority = new System.Windows.Forms.ToolStripMenuItem();
            this.ReportMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kullaniciIslemleri,
            this.kategoriİşlemleriToolStripMenuItem,
            this.MenuCompany,
            this.MenuMeasurement,
            this.MenuExchange,
            this.MenuRepository,
            this.MenuStock,
            this.MenuAuthority,
            this.ReportMenu});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1435, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // kullaniciIslemleri
            // 
            this.kullaniciIslemleri.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addUserMenu,
            this.changePwd,
            this.deleteUser});
            this.kullaniciIslemleri.Name = "kullaniciIslemleri";
            this.kullaniciIslemleri.Size = new System.Drawing.Size(137, 24);
            this.kullaniciIslemleri.Text = "Kullanıcı İşlemleri";
            // 
            // addUserMenu
            // 
            this.addUserMenu.Name = "addUserMenu";
            this.addUserMenu.Size = new System.Drawing.Size(171, 26);
            this.addUserMenu.Text = "Kullanıcı Ekle";
            this.addUserMenu.Click += new System.EventHandler(this.addUserMenu_Click);
            // 
            // changePwd
            // 
            this.changePwd.Name = "changePwd";
            this.changePwd.Size = new System.Drawing.Size(171, 26);
            this.changePwd.Text = "Şifre Değiştir";
            this.changePwd.Click += new System.EventHandler(this.şifreDeğiştirToolStripMenuItem_Click);
            // 
            // deleteUser
            // 
            this.deleteUser.Name = "deleteUser";
            this.deleteUser.Size = new System.Drawing.Size(171, 26);
            this.deleteUser.Text = "Kullanıcı Sil";
            this.deleteUser.Click += new System.EventHandler(this.kullanıcıSilToolStripMenuItem_Click);
            // 
            // kategoriİşlemleriToolStripMenuItem
            // 
            this.kategoriİşlemleriToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuCategory,
            this.MenuSubCategory});
            this.kategoriİşlemleriToolStripMenuItem.Name = "kategoriİşlemleriToolStripMenuItem";
            this.kategoriİşlemleriToolStripMenuItem.Size = new System.Drawing.Size(241, 24);
            this.kategoriİşlemleriToolStripMenuItem.Text = "Kategori ve Alt Kategori İşlemleri";
            // 
            // MenuCategory
            // 
            this.MenuCategory.Name = "MenuCategory";
            this.MenuCategory.Size = new System.Drawing.Size(224, 26);
            this.MenuCategory.Text = "Kategori İşlemleri";
            this.MenuCategory.Click += new System.EventHandler(this.kategoriİşlemleriToolStripMenuItem1_Click);
            // 
            // MenuSubCategory
            // 
            this.MenuSubCategory.Name = "MenuSubCategory";
            this.MenuSubCategory.Size = new System.Drawing.Size(224, 26);
            this.MenuSubCategory.Text = "Alt Kategori İşlemleri";
            this.MenuSubCategory.Click += new System.EventHandler(this.altKategoriİşlemleriToolStripMenuItem_Click);
            // 
            // MenuCompany
            // 
            this.MenuCompany.Name = "MenuCompany";
            this.MenuCompany.Size = new System.Drawing.Size(118, 24);
            this.MenuCompany.Text = "Şirket İşlemleri";
            this.MenuCompany.Click += new System.EventHandler(this.şirketİşlemleriToolStripMenuItem_Click);
            // 
            // MenuMeasurement
            // 
            this.MenuMeasurement.Name = "MenuMeasurement";
            this.MenuMeasurement.Size = new System.Drawing.Size(111, 24);
            this.MenuMeasurement.Text = "Ölçü Birimleri";
            this.MenuMeasurement.Click += new System.EventHandler(this.ölçüBirimleriToolStripMenuItem_Click);
            // 
            // MenuExchange
            // 
            this.MenuExchange.Name = "MenuExchange";
            this.MenuExchange.Size = new System.Drawing.Size(106, 24);
            this.MenuExchange.Text = "Döviz Kurları";
            this.MenuExchange.Click += new System.EventHandler(this.dövizKurlarıToolStripMenuItem_Click);
            // 
            // MenuRepository
            // 
            this.MenuRepository.Name = "MenuRepository";
            this.MenuRepository.Size = new System.Drawing.Size(118, 24);
            this.MenuRepository.Text = "Depo İşlemleri";
            this.MenuRepository.Click += new System.EventHandler(this.depoİşlemleriToolStripMenuItem_Click);
            // 
            // MenuStock
            // 
            this.MenuStock.Name = "MenuStock";
            this.MenuStock.Size = new System.Drawing.Size(50, 24);
            this.MenuStock.Text = "Stok";
            this.MenuStock.Click += new System.EventHandler(this.stokToolStripMenuItem_Click);
            // 
            // MenuAuthority
            // 
            this.MenuAuthority.Name = "MenuAuthority";
            this.MenuAuthority.Size = new System.Drawing.Size(69, 24);
            this.MenuAuthority.Text = "Yetkiler";
            this.MenuAuthority.Click += new System.EventHandler(this.yetkilerToolStripMenuItem_Click);
            // 
            // ReportMenu
            // 
            this.ReportMenu.Name = "ReportMenu";
            this.ReportMenu.Size = new System.Drawing.Size(61, 24);
            this.ReportMenu.Text = "Rapor";
            this.ReportMenu.Click += new System.EventHandler(this.raporToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1435, 719);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.Text = "Ana Menü";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form2_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem kullaniciIslemleri;
        private System.Windows.Forms.ToolStripMenuItem addUserMenu;
        private System.Windows.Forms.ToolStripMenuItem changePwd;
        private System.Windows.Forms.ToolStripMenuItem deleteUser;
        private System.Windows.Forms.ToolStripMenuItem kategoriİşlemleriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MenuCategory;
        private System.Windows.Forms.ToolStripMenuItem MenuSubCategory;
        private System.Windows.Forms.ToolStripMenuItem MenuCompany;
        private System.Windows.Forms.ToolStripMenuItem MenuMeasurement;
        private System.Windows.Forms.ToolStripMenuItem MenuExchange;
        private System.Windows.Forms.ToolStripMenuItem MenuRepository;
        private System.Windows.Forms.ToolStripMenuItem MenuStock;
        private System.Windows.Forms.ToolStripMenuItem MenuAuthority;
        private System.Windows.Forms.ToolStripMenuItem ReportMenu;
    }
}