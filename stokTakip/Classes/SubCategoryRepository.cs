using dernekProje.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using dernekProje.Classes;

namespace stokTakip.Classes
{
    class SubCategoryRepository : IRepository<SubCategory>
    {
        public void Add(SubCategory something)
        {
            bool result = ContainsSubCategory(something.SubCategoryName);

            if (result == true)
                MessageBox.Show("alt kategori zaten var");
            else
            {
                string commandText = "insert into SubCategory values(@pCategoryId,@pSubCategoryName,@pCreationDate,@pState)";
                List<string> parameter = new List<string>() {
                   "@pCategoryId","@pSubCategoryName","@pCreationDate","@pState",
                            };

                DataAccess dataAccess = new DataAccess();
                dataAccess.InsertExecuteNonQuery(commandText, parameter, something.CategoryId, something.SubCategoryName, DateTime.Now, 1);
            }
        }

        public void Delete(int id)
        {
            string commandText = "update SubCategory set State=@pState where ID=" + id;
            List<string> parameter = new List<string>() {
                    "pState",

                            };
            DataAccess dataAccess = new DataAccess();
            dataAccess.InsertExecuteNonQuery(commandText, parameter, 0); ;
        }

        public DataSet ListAll()
        {
            string commandText = "select * from SubCategory where State=1";
            DataAccess dataAccess = new DataAccess();
            return dataAccess.ListExecuteNonQuery(commandText, "SubCategory");
        }

        public DataSet ListForCategory(int categoryId)
        {
            string commandText = "select * from SubCategory where State=1 and CategoryId="+categoryId;
            DataAccess dataAccess = new DataAccess();
            return dataAccess.ListExecuteNonQuery(commandText, "SubCategory");
        }

        public void Update(SubCategory something, int id)
        {
            throw new NotImplementedException();
        }

        private bool ContainsSubCategory(string subCategoryName)
        {
            bool result = false;
            SqlConnection baglanti = Database.GetConnection();
            SqlCommand komut = new SqlCommand();
            komut.Connection = baglanti;
            komut.CommandType = CommandType.Text;
            komut.CommandText = "select * from SubCategory where SubCategoryName=@pSubCategoryName";
            SqlParameter param1 = new SqlParameter("@pSubCategoryName", subCategoryName);
            komut.Parameters.Add(param1);
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(komut);
            da.Fill(dt);
            if (dt.Rows.Count > 0)
                result = true;

            return result;
        }


    }
}
