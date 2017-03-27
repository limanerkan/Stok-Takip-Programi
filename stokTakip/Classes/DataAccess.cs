using stokTakip.Classes;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace dernekProje.Classes
{
    public class DataAccess
    {
        private SqlConnection conn = null;

        public DataAccess()
        {
            conn = Database.GetConnection();
        }

        private SqlCommand CreateCommand(string commandText)
        {
            SqlCommand komut = conn.CreateCommand();
            komut.CommandText = commandText;
            return komut;
        }

        private void komutParametreEkle(SqlCommand command, List<string> parametreIslemleri, params object[] parameterValue)
        {
            if (parameterValue.Length == parametreIslemleri.Count)
            {
                for (int i = 0; i < parametreIslemleri.Count; i++)
                {
                    command.Parameters.AddWithValue(parametreIslemleri[i], parameterValue[i]);
                }
            }
        }


        public int InsertExecuteNonQuery(string command, List<string> parametreIslemleri, params object[] parameterValue)
        {
            SqlCommand komut = CreateCommand(command);
            komutParametreEkle(komut, parametreIslemleri, parameterValue);
            komut.Connection.Open();
            int etkilenenSatirSayisi = komut.ExecuteNonQuery();
            komut.Connection.Close();
            return etkilenenSatirSayisi;
        }



        //public int yeniExecuteNonQuery(string komutMetni, ArrayList parametreIslemleri, params object[] parametreDegerleri)
        //{
        //    SqlCommand komut = komutOlustur(komutMetni);
        //    yenikomutParametreEkle(komut, parametreIslemleri, parametreDegerleri);
        //    komut.Connection.Open();
        //    int etkilenenSatirSayisi = komut.ExecuteNonQuery();
        //    komut.Connection.Close();
        //    return etkilenenSatirSayisi;
        //}


        //private void yenikomutParametreEkle(SqlCommand komut, ArrayList parametreIslemleri, params object[] parametreDegerleri)
        //{
        //    if (parametreDegerleri.Length == parametreIslemleri.Count)
        //    {
        //        for (int i = 0; i < parametreIslemleri.Count; i++)
        //        {
        //            komut.Parameters.AddWithValue(parametreIslemleri[i].ToString(), parametreDegerleri[i]);
        //        }
        //    }
        //}

        public void DeleteExecuteNonQuery(string commandText)
        {
            SqlCommand komut = CreateCommand(commandText);
            komut.Connection.Open();
            komut.ExecuteNonQuery();
            komut.Connection.Close();
        }

        public DataSet ListExecuteNonQuery(string commandText, string adaptorName)
        {
            SqlCommand command = CreateCommand(commandText);
            SqlDataAdapter adaptor = new SqlDataAdapter();
            adaptor.SelectCommand = command;
            DataSet sonuc = new DataSet();
            command.Connection.Open();
            adaptor.Fill(sonuc, adaptorName);
            command.Connection.Close();
            return sonuc;
        }
    }
}
