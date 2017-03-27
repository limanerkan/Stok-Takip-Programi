using dernekProje.Classes;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace stokTakip.Classes
{
    class Authority
    {

        private List<bool> yetki = new List<bool>();
        
        public List<bool> AouthorityList(int userId)
        {
            SqlConnection cnn = new SqlConnection();
            //cnn.ConnectionString = @"Data Source=52.164.242.14;Initial Catalog=stokTakip;Integrated Security=False;User ID=limanerkan;Password=Masterwarior@;Pooling=False";

            cnn.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + Application.StartupPath + "\\stokTakip.mdf;Integrated Security=True;Connect Timeout=30";
            cnn.Open();

            DataSet ds = new DataSet();
            string commandText = "select AuthorityNo, IsAccess from Permission where UserId =" + userId + "order by AuthorityNo";
            //SqlDataAdapter sda = new SqlDataAdapter("select AuthorityNo, IsAccess from Permission where UserId = '" + userId + "'", cnn);
            SqlDataAdapter sda = new SqlDataAdapter(commandText, cnn);
            sda.Fill(ds);

            if ((ds.Tables.Count == 0))
            {
                MessageBox.Show("Yetkiler Yüklenemiyor.", "Otomasyon", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            for (int i = 0; i < ds.Tables[0].Rows.Count; ++i)
            {
                int yetkiIndis = (int)ds.Tables[0].Rows[i][0];
                bool a = (bool)ds.Tables[0].Rows[i][1];
                yetki.Add(a);
            }


            return yetki;

        }

        public void DeleteAuthority(int userId)
        {
            string commandText = "delete  from Permission where UserId=" + userId;
            DataAccess dataAccess = new DataAccess();
            dataAccess.DeleteExecuteNonQuery(commandText);
        }

        public void AddAuthority(int userId, int outhorityNo, bool isAccess)
        {
            string commandText = "insert into Permission values(@pUserId,@pouthorityNo,@pIsAccess)";
            List<string> parameter = new List<string>() {
                    "@pUserId","@pouthorityNo","@pIsAccess",
                            };

            DataAccess dataAccess = new DataAccess();
            dataAccess.InsertExecuteNonQuery(commandText, parameter, userId, outhorityNo, isAccess);
        }

    }
}
