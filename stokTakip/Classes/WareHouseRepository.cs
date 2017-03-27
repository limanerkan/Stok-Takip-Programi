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
    class WareHouseRepository : IRepository<Warehouse>
    {
        public void Add(Warehouse something)
        {
            bool result = ContainsWarehouse(something.WareHouseName);
            if (result == true)
                MessageBox.Show("Bu isimde bir depo var");
            else
            {
                string commandText = "insert into Warehouses values(@pUserID,@pWareHouseName,@pAdress,@pPhoneNumber,@pCreationDate,@pState)";
                List<string> parameter = new List<string>() {
                    "@pUserID",
                    "@pWareHouseName",
                    "@pAdress",
                    "@pPhoneNumber",
                    "@pCreationDate",
                    "@pState",
                            };

                DataAccess dataAccess = new DataAccess();
                dataAccess.InsertExecuteNonQuery(commandText, parameter, UserRepository.user.Id, something.WareHouseName, something.Adress, something.PhoneNumber, DateTime.Now, 1);
            }
        }

        private bool ContainsWarehouse(string wareHouseName)
        {
            bool result = false;
            SqlConnection baglanti = Database.GetConnection();
            SqlCommand komut = new SqlCommand();
            komut.Connection = baglanti;
            komut.CommandType = CommandType.Text;
            komut.CommandText = "select * from Warehouses where WarehouseName=@pWarehouseName";
            SqlParameter param1 = new SqlParameter("@pWarehouseName", wareHouseName);
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
            string commandText = "update Warehouses set State=@pState where Id=" + id;
            List<string> parameter = new List<string>() {
                    "pState",

                            };
            DataAccess dataAccess = new DataAccess();
            dataAccess.InsertExecuteNonQuery(commandText, parameter, 0);
        }

        public DataSet ListAll()
        {
            string commandText = "select * from Warehouses where State=1";
            DataAccess dataAccess = new DataAccess();
            return dataAccess.ListExecuteNonQuery(commandText, "Warehouses");
        }

        public void Update(Warehouse something, int id)
        {
            throw new NotImplementedException();
        }
    }
}
