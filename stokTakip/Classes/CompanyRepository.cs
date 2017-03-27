using dernekProje.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using dernekProje.Classes;

namespace stokTakip.Classes
{
    class CompanyRepository : IRepository<Company>
    {
        public void Add(Company something)
        {
            string commandText = "insert into Companies values(@pUserID,@pCompanyName,@pAdress,@pPhoneNumber,@pCreationDate,@pState)";
            List<string> parameter = new List<string>() {
                    "@pUserID","@pCompanyName","@pAdress","@pPhoneNumber","@pCreationDate","@pState",
                            };

            DataAccess dataAccess = new DataAccess();
            dataAccess.InsertExecuteNonQuery(commandText, parameter, UserRepository.user.Id, something.CompanyName,something.Adress,something.PhoneNumber,DateTime.Now,1);
        }

        public void Delete(int id)
        {
            string commandText = "update Companies set State=@pState where Id=" + id;
            List<string> parameter = new List<string>() {
                    "pState",

                            };
            DataAccess dataAccess = new DataAccess();
            dataAccess.InsertExecuteNonQuery(commandText, parameter, 0);
        }

        public DataSet ListAll()
        {
            string commandText = "select * from Companies where State=1";
            DataAccess dataAccess = new DataAccess();
            return dataAccess.ListExecuteNonQuery(commandText, "Companies");
        }

        public void Update(Company something, int id)
        {
            throw new NotImplementedException();
        }
    }
}
