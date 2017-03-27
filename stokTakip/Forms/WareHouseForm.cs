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
    public partial class WareHouseForm : Form
    {
        public WareHouseForm()
        {
            InitializeComponent();
            GetDataGrid();
            GetWareHouse();
        }
        WareHouseRepository w1 = new WareHouseRepository();
        void GetDataGrid()
        {
            dataGridView1.DataSource = w1.ListAll();
            dataGridView1.DataMember = "Warehouses";
        }


        void GetWareHouse()
        {
            DataSet result = w1.ListAll();
            comboBox1.DataSource = result.Tables[0];
            comboBox1.DisplayMember = "WareHouseName";
            comboBox1.ValueMember = "ID";
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            
            if (String.IsNullOrEmpty(tbAdress.Text) || String.IsNullOrEmpty(tbName.Text) || String.IsNullOrEmpty(tbPhoneNumber.Text))
                MessageBox.Show("Boş alan bırakamazsınız");
            else
            {
                Warehouse warehouse = new Warehouse();
                warehouse.Adress = tbAdress.Text;
                warehouse.PhoneNumber = tbPhoneNumber.Text;
                warehouse.WareHouseName = tbName.Text;
                w1.Add(warehouse);
                MessageBox.Show("Eklendi");
                GetDataGrid();
                GetWareHouse();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            w1.Delete((int)comboBox1.SelectedValue);
            GetDataGrid();
            GetWareHouse();
        }
    }
}
