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
    public partial class CompanyForm : Form
    {
        public CompanyForm()
        {
            InitializeComponent();
            GetCompany();
            GetDataGrid();
        }

        private void btnAddCompany_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(tbAdress.Text) || String.IsNullOrEmpty(tbCompanyName.Text) || String.IsNullOrEmpty(tbPhoneNumber.Text))
                MessageBox.Show("Boş alan bırakmazsınız");
            else
            {
                Company c = new Company();
                c.Adress = tbAdress.Text;
                c.CompanyName = tbCompanyName.Text;
                c.PhoneNumber = tbPhoneNumber.Text;
                c1.Add(c);
                GetCompany();
                GetDataGrid();
            }
        }

        CompanyRepository c1 = new CompanyRepository();
        void GetCompany()
        {
            DataSet result = c1.ListAll();
            comboBox1.DataSource = result.Tables[0];
            comboBox1.DisplayMember = "CompanyName";
            comboBox1.ValueMember = "ID";
        }
        void GetDataGrid()
        {
            dataGridView1.DataSource = c1.ListAll();
            dataGridView1.DataMember = "Companies";
        }

        private void btnDeleteCompany_Click(object sender, EventArgs e)
        {
            c1.Delete((int)comboBox1.SelectedValue);
            GetCompany();
            GetDataGrid();
        }
    }
}
