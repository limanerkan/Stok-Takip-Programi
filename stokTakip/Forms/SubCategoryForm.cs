using stokTakip.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace stokTakip.Forms
{
    public partial class SubCategoryForm : Form
    {
        public SubCategoryForm()
        {
            InitializeComponent();
            GetCategory();
            GetSubCategory();
            GetDataGrid();
        }
        SubCategoryRepository s1 = new SubCategoryRepository();
        CategoryRepository c1 = new CategoryRepository();
        private void btnAddSubCategory_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(tbSubCategoryName.Text))
                MessageBox.Show("Alt Kategori adı boş bırakılamaz");
            else
            {
                SubCategory sc = new SubCategory();
                sc.CategoryId=((int)cbCategory.SelectedValue);
                sc.SubCategoryName = tbSubCategoryName.Text;
                s1.Add(sc);
                GetCategory();
                GetSubCategory();
                GetDataGrid();
            }
        }

        void GetCategory()
        {
            DataSet result = c1.ListAll();
            cbCategory.DataSource = result.Tables[0];
            cbCategory.DisplayMember = "CategoryName";
            cbCategory.ValueMember = "ID";
        }

        void GetSubCategory()
        {
            DataSet result = s1.ListAll();
            cbSubCategory.DataSource = result.Tables[0];
            cbSubCategory.DisplayMember = "SubCategoryName";
            cbSubCategory.ValueMember = "ID";
        }
        void GetDataGrid()
        {
            dataGridView1.DataSource = s1.ListAll();
            dataGridView1.DataMember = "SubCategory";
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            s1.Delete((int)cbSubCategory.SelectedValue);
            GetCategory();
            GetSubCategory();
            GetDataGrid();
        }
    }
}
