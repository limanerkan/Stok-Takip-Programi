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
    public partial class ReportForm : Form
    {
        public ReportForm()
        {
            InitializeComponent();
        }

        private void ReportForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'stokTakipDataSet1.Stocks' table. You can move, or remove it, as needed.
            this.stocksTableAdapter.Fill(this.stokTakipDataSet1.Stocks);

            this.reportViewer1.RefreshReport();
        }
    }
}
