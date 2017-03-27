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
    public partial class ExhangeRateForm : Form
    {
        public ExhangeRateForm()
        {
            InitializeComponent();
            GetDataGrid();
        }
        ExchangeRate r1 = new ExchangeRate();
        void GetDataGrid()
        {
            dataGridView1.DataSource = r1.ListAll();
            dataGridView1.DataMember = "Currency";
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            ExchangeRate r1 = new ExchangeRate();
            GetDataGrid();
        }
    }
}
