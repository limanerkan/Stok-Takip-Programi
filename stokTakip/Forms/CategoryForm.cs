using stokTakip.Classes;
using System;
using System.Data;
using System.Windows.Forms;

namespace stokTakip.Forms
{
    public partial class CategoryForm : Form
    {
        public CategoryForm()
        {
            InitializeComponent();
            GetDataGrid();
            GetCbUser();
        }

        private void btnAddCategory_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(tbCategoryName.Text))
                MessageBox.Show("Kategori Adı boş bırakılamaz", "Hata");
            else
            {
                Category c1 = new Category();
                c1.CategoryName = tbCategoryName.Text;
                r1.Add(c1);
                GetDataGrid();
            }
        }

        CategoryRepository r1 = new CategoryRepository();
        void GetDataGrid()
        {
            dataGridView1.DataSource = r1.ListAll();
            dataGridView1.DataMember = "Category";
        }


        void GetCbUser()
        {

            DataSet result = r1.ListAll();
            cbCategory.DataSource = result.Tables[0];
            cbCategory.DisplayMember = "CategoryName";
            cbCategory.ValueMember = "ID";
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            r1.Delete((int)cbCategory.SelectedValue);
            GetDataGrid();
            GetCbUser();
        }
    }
}
