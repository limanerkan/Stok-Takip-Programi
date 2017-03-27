using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Security.Cryptography;
using dernekProje.Classes;
using System.Windows.Forms;

namespace stokTakip.Classes
{
    class UserRepository
    {
        public static User user = null;

        public void AddUser(User u1)
        {
            bool result = ContainsUser(u1.UserName);
            if (result == true)
                MessageBox.Show("Bu kullanıcı adını kullanamazsınız");
            else
            {
                string commandText = "insert into users values(@pName,@pSurname,@pEmail,@pUserName,@pPassword,@pCreationDate,@pLastLoginDate,@pModifyDate,@pState)";
                List<string> parameter = new List<string>() {
                    "@pName",
                    "@pSurname",
                    "@pEmail",
                    "@pUserName",
                    "@pPassword",
                    "@pCreationDate",
                    "pLastLoginDate",
                    "pModifyDate",
                    "pState",
                };
                u1.Password = HashMD5(u1.Password);
                DataAccess dataAccess = new DataAccess();
                dataAccess.InsertExecuteNonQuery(commandText, parameter, u1.Name, u1.SurName, u1.Email, u1.UserName, u1.Password, DateTime.Now, DBNull.Value, DBNull.Value, 1);
                MessageBox.Show("Kullanıcı başarıyla eklendi");
            }
        }

        private bool ContainsUser(string userName)
        {
            bool result = false;
            SqlConnection baglanti = Database.GetConnection();
            SqlCommand komut = new SqlCommand();
            komut.Connection = baglanti;
            komut.CommandType = CommandType.Text;
            komut.CommandText = "select * from users where UserName=@pUserName and State=1";
            SqlParameter param1 = new SqlParameter("@pUserName", userName);
            komut.Parameters.Add(param1);
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(komut);
            da.Fill(dt);
            if (dt.Rows.Count > 0)
                result = true;

            return result;
        }
        public void UpdatePassword(int userId, string lastPassword, string newPassword)
        {
            bool result = LastPasswordIsTrue(userId, lastPassword);
            if (result == true)
            {
                newPassword = HashMD5(newPassword);
                string commandText = "update users set Password=@pPassword,ModifyDate=@pModifyDate where Id=" + userId;
                List<string> parametreler = new List<string>() {
                "@pPassword","pModifyDate",
                };
                DataAccess dataAccess = new DataAccess();
                dataAccess.InsertExecuteNonQuery(commandText, parametreler, newPassword, DateTime.Now);
            }
            else
            {
                MessageBox.Show("Eski şifreniz yanlış.");
            }
        }

        private bool LastPasswordIsTrue(int id, string lastPassword)
        {
            bool result = false;
            lastPassword = HashMD5(lastPassword);
            SqlConnection baglanti = Database.GetConnection();
            SqlCommand komut = new SqlCommand();
            komut.Connection = baglanti;
            komut.CommandType = CommandType.Text;
            komut.CommandText= "select * from users where Password=@pPassword and State=1 and ID=" + id;
            SqlParameter param1 = new SqlParameter("@pPassword", lastPassword);
            komut.Parameters.Add(param1);
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(komut);
            da.Fill(dt);
            if (dt.Rows.Count > 0)
                result = true;

            return result;
        }

        private void UpdateLastLoginDate(int userId)
        {
            string commandText = "update users set LastLoginDate=@pLastLoginDate where Id=" + userId;
            List<string> parametreler = new List<string>() {
                "@pLastLoginDate",
                };
            DataAccess dataAccess = new DataAccess();
            dataAccess.InsertExecuteNonQuery(commandText, parametreler, DateTime.Now);
        }

        public void DeleteUser(int userId)
        {
            string commandText = "update users set State=@pState, ModifyDate=@pModifyDate where Id=" + userId;
            List<string> parameter = new List<string>() {
                "@pState","pModifyDate",
                };
            DataAccess dataAccess = new DataAccess();
            dataAccess.InsertExecuteNonQuery(commandText, parameter, false, DateTime.Now);
            MessageBox.Show("Kullanıcı başarıyla silindi.");
        }
        public int LoginControl(string userName, string password)
        {
            password = HashMD5(password);
            int sonuc = 0;
            SqlConnection baglanti = Database.GetConnection();
            SqlCommand komut = new SqlCommand();
            komut.Connection = baglanti;
            komut.CommandType = CommandType.Text;
            komut.CommandText = "select * from users where UserName=@username and Password=@pass and State=1";
            SqlParameter param1 = new SqlParameter("@username", userName);
            SqlParameter param2 = new SqlParameter("@pass", password);
            komut.Parameters.Add(param1);
            komut.Parameters.Add(param2);
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(komut);
            da.Fill(dt);
            if (dt.Rows.Count > 0)
                sonuc = 1;
            baglanti.Close();
            if (sonuc == 1)
            {
                GetUser(userName, password);
                UpdateLastLoginDate(UserRepository.user.Id);
            }
            return sonuc;
        }



        private User GetUser(string name, string password)
        {

            using (var connection = Database.GetConnection())
            {

                var command = new SqlCommand("SELECT *FROM users WHERE UserName='" + name + "' and Password='" + password + "'");
                command.Connection = connection;
                connection.Open();
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        try
                        {
                            user = new User();
                            user.Id = reader.GetInt32(0);
                            user.Name = reader.GetString(1);
                            user.SurName = reader.GetString(2);
                            user.Email = reader.GetString(3);
                            user.UserName = reader.GetString(4);
                            user.Password = reader.GetString(5);
                            user.CreationDate = reader.GetDateTime(6);
                            user.LastLoginDate = reader.GetDateTime(7);
                            user.ModifyDate = reader.GetDateTime(8);
                            user.State = reader.GetBoolean(9);
                        }
                        catch (Exception)
                        {

                           
                        }
                    }
                }
                connection.Close();
            }
            return user;
        }

        public DataSet ListAll()
        {
            string commandText = "select * from users where State=1";
            DataAccess dataAccess = new DataAccess();
            return dataAccess.ListExecuteNonQuery(commandText, "users");
        }
        private string HashMD5(string password)
        {
            MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider();
            byte[] btr = Encoding.UTF8.GetBytes(password);
            btr = md5.ComputeHash(btr);

            StringBuilder sb = new StringBuilder();

            foreach (byte ba in btr)
            {
                sb.Append(ba.ToString("x2").ToLower());
            }
            return sb.ToString();
        }
    }
}
