using stokTakip.Classes;
using System;
using System.Data;
using System.Windows.Forms;

namespace stokTakip.Forms
{
    public partial class StockForm : Form
    {
        public StockForm()
        {
            InitializeComponent();
            GetWareHouse();
            GetMeasurementUnit();
            GetExchangeRate();
            GetCategory();
        }


        void GetWareHouse()
        {
            WareHouseRepository w1 = new WareHouseRepository();
            DataSet result = w1.ListAll();
            cbwarehouse.DataSource = result.Tables[0];
            cbwarehouse.DisplayMember = "WareHouseName";
            cbwarehouse.ValueMember = "ID";
        }

        void GetMeasurementUnit()
        {
            MeasurementUnitRepository m1 = new MeasurementUnitRepository();
            DataSet result = m1.ListAll();
            cbmeasurementUnit.DataSource = result.Tables[0];
            cbmeasurementUnit.DisplayMember = "MeasurementName";
            cbmeasurementUnit.ValueMember = "ID";
        }
        void GetCategory()
        {
            CategoryRepository c1 = new CategoryRepository();
            DataSet result = c1.ListAll();
            cbCategory.DataSource = result.Tables[0];
            cbCategory.DisplayMember = "CategoryName";
            cbCategory.ValueMember = "ID";
        }
        void GetExchangeRate()
        {
            ExchangeRate e1 = new ExchangeRate();
            DataSet result = e1.ListAll();
            cbexchangeRate.DataSource = result.Tables[0];
            cbexchangeRate.DisplayMember = "Currency";
            cbexchangeRate.ValueMember = "ForexBuying";
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Stock stock = new Stock();
            stock.Barcode = Convert.ToInt32(tbbarcode.Text);
            stock.Category = (int)cbCategory.SelectedValue;
            if (cbexchangeRate.SelectedIndex == 0)
                stock.ExchangeRate = "USD";
            if (cbexchangeRate.SelectedIndex == 1)
                stock.ExchangeRate = "EUR";

            stock.ExchangeRateValue = Convert.ToDecimal(tbexchangeRateValue.Text);
            stock.Kdv = Convert.ToInt32(tbkdv.Text);
            stock.MeasurementUnit = cbmeasurementUnit.SelectedValue.ToString();
            stock.Piece = Convert.ToInt32(tbpiece.Text);
            stock.StockCode = 3;
            stock.StockName = tbstockName.Text;
            stock.SubCategory = (int)cbSubCategory.SelectedValue;
            stock.TotalPrice = Convert.ToDecimal(tbtotalPrice.Text);
            stock.UnitPrice = Convert.ToDecimal(tbunitPrice.Text);
            stock.Warehouse = cbwarehouse.SelectedValue.ToString();
            StockRepository r1 = new StockRepository();
            r1.Add(stock);
            MessageBox.Show("Stok Eklendi");
        }

        private void cbexchangeRate_SelectedIndexChanged(object sender, EventArgs e)
        {
            tbexchangeRateValue.Text = Convert.ToString(cbexchangeRate.SelectedValue);
        }

        private void cbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                SubCategoryRepository r1 = new SubCategoryRepository();
                DataSet result = r1.ListForCategory((int)cbCategory.SelectedValue);
                cbSubCategory.DataSource = result.Tables[0];
                cbSubCategory.DisplayMember = "SubCategoryName";
                cbSubCategory.ValueMember = "Id";
            }
            catch (Exception)
            {



            }
        }

        

        private void tbunitPrice_TextChanged_1(object sender, EventArgs e)
        {
            try
            {
                int adet = Convert.ToInt32(tbpiece.Text);
                decimal doviz = Convert.ToDecimal(tbexchangeRateValue.Text);
                decimal kdv = Convert.ToDecimal(tbkdv.Text);
                kdv = kdv / 100;
                decimal birimFiyat = Convert.ToDecimal(tbunitPrice.Text);

                decimal kdvliFiyat = (birimFiyat * kdv) + birimFiyat;
                decimal toplamFiyat = adet * kdvliFiyat * doviz;

                tbtotalPrice.Text = toplamFiyat.ToString();
            }
            catch (Exception)
            {


            }
        }
    }
}
