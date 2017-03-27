using stokTakip.Classes;
using stokTakip.Forms;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace stokTakip
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            //ExchangeRate e1 = new ExchangeRate();

            List<bool> a = new List<bool>();
            Authority a1 = new Authority();
            a = a1.AouthorityList(UserRepository.user.Id);

            try
            {
                addUserMenu.Enabled = a[0];
                changePwd.Enabled = a[1];
                deleteUser.Enabled = a[2];
                MenuCategory.Enabled = a[3];
                MenuSubCategory.Enabled = a[4];
                MenuCompany.Enabled = a[5];
                MenuMeasurement.Enabled = a[6];
                MenuExchange.Enabled = a[7];
                MenuRepository.Enabled = a[8];
                MenuStock.Enabled = a[9];
                MenuAuthority.Enabled=a[10];
                ReportMenu.Enabled = a[11];
            }
            catch (Exception)
            {

               
            }
        }

        private void addUserMenu_Click(object sender, EventArgs e)
        {
            AddUserForm frm = new AddUserForm();
            frm.MdiParent = this;
            frm.Show();
        }

        private void şifreDeğiştirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChangePassword frm = new ChangePassword();
            frm.MdiParent = this;
            frm.Show();
        }

        private void kullanıcıSilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DeleteUserForm frm = new DeleteUserForm();
            frm.MdiParent = this;
            frm.Show();
        }

        private void kategoriİşlemleriToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            CategoryForm frm = new CategoryForm();
            frm.MdiParent = this;
            frm.Show();
        }

        private void altKategoriİşlemleriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SubCategoryForm frm = new SubCategoryForm();
            frm.MdiParent = this;
            frm.Show();
        }

        private void şirketİşlemleriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CompanyForm frm = new CompanyForm();
            frm.MdiParent = this;
            frm.Show();
        }

        private void ölçüBirimleriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MeasurementUnitForm frm = new MeasurementUnitForm();
            frm.MdiParent = this;
            frm.Show();
        }

        private void dövizKurlarıToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ExhangeRateForm frm = new ExhangeRateForm();
            frm.MdiParent = this;
            frm.Show();
        }

        private void depoİşlemleriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            WareHouseForm frm = new WareHouseForm();
            frm.MdiParent = this;
            frm.Show();
        }

        private void stokToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StockForm frm = new StockForm();
            frm.MdiParent = this;
            frm.Show();
        }

        private void yetkilerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AuthorityForm frm = new AuthorityForm();
            frm.MdiParent = this;
            frm.Show();
        }

        private void raporToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReportForm frm = new ReportForm();
            frm.MdiParent = this;
            frm.Show();
        }
    }
}
