using dernekProje.Classes;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Xml;

namespace stokTakip.Classes
{
    class ExchangeRate
    {

        private string USD_DA;
        private string USD_DS;
        private string USD_EA;
        private string USD_ES;

        private string EURO_DA;
        private string EURO_DS;
        private string EURO_EA;
        private string EURO_ES;
        public ExchangeRate()
        {
            var xmlDoc = new XmlDocument();
            xmlDoc.Load("http://www.tcmb.gov.tr/kurlar/today.xml");


            // Xml içinden tarihi alma – gerekli olabilir
            DateTime exchangeDate = Convert.ToDateTime(xmlDoc.SelectSingleNode("//Tarih_Date").Attributes["Tarih"].Value);

            //Döviz Alış – Forex Buying
            //Döviz Satış – Forex Selling
            //Efektif Alış – Banknote Buying
            //Efektif Satış – Banknote Selling



            //Döviz Alış – ForexBuying
            USD_DA = xmlDoc.SelectSingleNode("Tarih_Date / Currency[@Kod ='USD'] / ForexBuying").InnerXml;
            USD_DA = USD_DA.Replace(".", ",");
            EURO_DA = xmlDoc.SelectSingleNode("Tarih_Date / Currency[@Kod ='EUR'] / ForexBuying").InnerXml;
            EURO_DA = EURO_DA.Replace(".", ",");
            //POUND = xmlDoc.SelectSingleNode("Tarih_Date/Currency[@Kod='GBP']/ForexBuying").InnerXml; //ingiliz sterlini

            //Döviz Satış – ForexSelling
            USD_DS = xmlDoc.SelectSingleNode("Tarih_Date / Currency[@Kod ='USD'] / ForexSelling").InnerXml;
            USD_DS = USD_DS.Replace(".", ",");
            EURO_DS = xmlDoc.SelectSingleNode("Tarih_Date / Currency[@Kod ='EUR'] / ForexSelling").InnerXml;
            EURO_DS = EURO_DS.Replace(".", ",");

            //Efektif Alış – BanknoteBuying
            USD_EA = xmlDoc.SelectSingleNode("Tarih_Date / Currency[@Kod ='USD'] / BanknoteBuying").InnerXml;
            USD_EA = USD_EA.Replace(".", ",");
            EURO_EA = xmlDoc.SelectSingleNode("Tarih_Date / Currency[@Kod ='EUR'] / BanknoteBuying").InnerXml;
            EURO_EA = EURO_EA.Replace(".", ",");

            //Efektif Satış – BanknoteSelling
            USD_ES = xmlDoc.SelectSingleNode("Tarih_Date / Currency[@Kod ='USD'] / BanknoteSelling").InnerXml;
            USD_ES = USD_ES.Replace(".", ",");
            EURO_ES = xmlDoc.SelectSingleNode("Tarih_Date / Currency[@Kod ='EUR'] / BanknoteSelling").InnerXml;
            EURO_ES = EURO_ES.Replace(".", ",");


            int result = CurrencyCount();
            if (result >= 2)
                DeleteAllCurrencyData();

            AddCurrency("USD", Convert.ToDateTime(DateTime.Now), Convert.ToDecimal(USD_DA), Convert.ToDecimal(USD_DS), Convert.ToDecimal(USD_EA), Convert.ToDecimal(USD_ES));
            AddCurrency("EUR", Convert.ToDateTime(DateTime.Now),
Convert.ToDecimal(EURO_DA), Convert.ToDecimal(EURO_DS),
Convert.ToDecimal(EURO_EA), Convert.ToDecimal(EURO_ES));
        }

        private void AddCurrency(string currency, DateTime date, decimal forexbuying, decimal forexselling, decimal banknoteBuying, decimal banknoteSelling)
        {
            
            string commandText = "insert into Currency values(@pcurrency,@pdate,@pforexbuying,@pforexselling,@pbanknoteBuying,@pbanknoteSelling)";
            List<string> parameter = new List<string>() {
                    "@pcurrency","@pdate","@pforexbuying","@pforexselling","@pbanknoteBuying","@pbanknoteSelling",
                            };

            DataAccess dataAccess = new DataAccess();
            dataAccess.InsertExecuteNonQuery(commandText, parameter, currency, date, forexbuying, forexselling, banknoteBuying, banknoteSelling);

        }

        private int CurrencyCount()
        {
            SqlConnection baglanti = Database.GetConnection();
            SqlCommand komut = new SqlCommand();
            komut.Connection = baglanti;
            komut.CommandType = CommandType.Text;
            komut.CommandText = "select * from Currency";
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(komut);
            da.Fill(dt);
            return dt.Rows.Count;
        }
        public DataSet ListAll()
        {
            string commandText = "select * from Currency";
            DataAccess dataAccess = new DataAccess();
            return dataAccess.ListExecuteNonQuery(commandText, "Currency");
        }

        private void DeleteAllCurrencyData()
        {
            string commandText = "delete from Currency";
            DataAccess dataAccess = new DataAccess();
            dataAccess.DeleteExecuteNonQuery(commandText);
        }
    }
}