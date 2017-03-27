using System;
using System.Data;
using dernekProje.Interface;
using System.Collections.Generic;
using dernekProje.Classes;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace stokTakip.Classes
{
    class MeasurementUnitRepository : IRepository<MeasurementUnit>
    {
        public void Add(MeasurementUnit something)
        {
            bool result = ContainsMeasurement(something.Measurement);
            if (result == true)
                MessageBox.Show("Bu ölçü birimi vardır");
            else
            {
                string commandText = "insert into MeasurementUnit values(@pMeasurementName,@puserID,@pCreationDate,@pModifyDate,@pDeleteDate,@pState)";
                List<string> parameter = new List<string>() {
                    "@pMeasurementName",
                    "puserID",
                    "@pCreationDate",
                    "@pModifyDate",
                    "@pDeleteDate",
                    "@pState"
                            };

                DataAccess dataAccess = new DataAccess();
                dataAccess.InsertExecuteNonQuery(commandText, parameter, UserRepository.user.Id, something.Measurement, DateTime.Now, DBNull.Value, DBNull.Value, 1);
            }

        }

        private bool ContainsMeasurement(string measurement)
        {
            bool result = false;
            SqlConnection baglanti = Database.GetConnection();
            SqlCommand komut = new SqlCommand();
            komut.Connection = baglanti;
            komut.CommandType = CommandType.Text;
            komut.CommandText = "select * from MeasurementUnit where MeasurementName=@pMeasurementName";
            SqlParameter param1 = new SqlParameter("@pMeasurementName", measurement);
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
            string commandText = "update MeasurementUnit set State=@pState, DeleteDate=@pDeleteDate where Id=" + id;
            List<string> parameter = new List<string>() {
                    "pState",
                    "pDeleteDate",
                            };
            DataAccess dataAccess = new DataAccess();
            dataAccess.InsertExecuteNonQuery(commandText, parameter, 0, DateTime.Now);
        }

        public DataSet ListAll()
        {
            string commandText = "select * from MeasurementUnit where State=1";
            DataAccess dataAccess = new DataAccess();
            return dataAccess.ListExecuteNonQuery(commandText, "MeasurementUnit");
        }

        public void Update(MeasurementUnit something, int id)
        {
            throw new NotImplementedException();
        }
    }
}
