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
    public partial class MeasurementUnitForm : Form
    {
        public MeasurementUnitForm()
        {
            InitializeComponent();
            GetMeasurementUnit();
            GetDataGrid();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(tbName.Text))
                MessageBox.Show("Boş alan bırakamazsınız");
            else
            {
                MeasurementUnit m = new MeasurementUnit();
                m.Measurement = tbName.Text;
                m1.Add(m);
                GetMeasurementUnit();
                GetDataGrid();
            }
        }


        void GetMeasurementUnit()
        {
            DataSet result = m1.ListAll();
            comboBox1.DataSource = result.Tables[0];
            comboBox1.DisplayMember = "MeasurementName";
            comboBox1.ValueMember = "ID";
        }

        MeasurementUnitRepository m1 = new MeasurementUnitRepository();
        void GetDataGrid()
        {
            dataGridView1.DataSource = m1.ListAll();
            dataGridView1.DataMember = "MeasurementUnit";
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            m1.Delete((int)comboBox1.SelectedValue);
            GetMeasurementUnit();
            GetDataGrid();
        }
    }
}
