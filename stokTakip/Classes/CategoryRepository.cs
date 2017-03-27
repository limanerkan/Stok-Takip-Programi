using dernekProje.Interface;
using System;
using System.Collections.Generic;
using System.Data;
using dernekProje.Classes;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace stokTakip.Classes
{
    class CategoryRepository : IRepository<Category>
    {
        public void Add(Category something)
        {
            bool result = ContainsCategory(something.CategoryName);

            if (result == true)
                MessageBox.Show("Kategori zaten var");
            else
            {
                string commandText = "insert into Category values(@pCategoryName,@pCreationDate,@pUserId,@pState)";
                List<string> parameter = new List<string>() {
                    "@pCategoryName","@pCreationDate","@pUserId","@pState",
                            };

                DataAccess dataAccess = new DataAccess();
                dataAccess.InsertExecuteNonQuery(commandText, parameter, something.CategoryName, DateTime.Now, UserRepository.user.Id, 1);

            }
        }

        private bool ContainsCategory(string categoryName)
        {
            bool result = false;
            SqlConnection baglanti = Database.GetConnection();
            SqlCommand komut = new SqlCommand();
            komut.Connection = baglanti;
            komut.CommandType = CommandType.Text;
            komut.CommandText = "select * from Category where CategoryName=@pCategoryName";
            SqlParameter param1 = new SqlParameter("@pCategoryName", categoryName);
            komut.Parameters.Add(param1);
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(komut);
            da.Fill(dt);
            if (dt.Rows.Count > 0)
                result = true;

            return result;
        }
        public void Delete(int id)
        {
            string commandText = "update Category set State=@pState where ID=" + id;
            List<string> parameter = new List<string>() {
                    "pState",

                            };
            DataAccess dataAccess = new DataAccess();
            dataAccess.InsertExecuteNonQuery(commandText, parameter, 0);
        }

        public DataSet ListAll()
        {
            string commandText = "select * from Category where State=1";
            DataAccess dataAccess = new DataAccess();
            return dataAccess.ListExecuteNonQuery(commandText, "Category");
        }

        public void Update(Category something, int id)
        {
            throw new NotImplementedException();
        }
    }
}
