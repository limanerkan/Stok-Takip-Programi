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
    class StockRepository : IRepository<Stock>
    {
        public void Add(Stock something)
        {
            string commandText = "insert into Stocks values(@pUserId,@pStockCode,@pBarcode,@pStockName,@pCategory,@pSubCategory,@pMeasurementUnit,@pWarehouse,@pKdv,@pExhangeRate,@pExhangeRateValue,@pUnitPrice,@pTotalPrice,@pPiece,@pState)";
            List<string> parameter = new List<string>() {"@pUserId","@pStockCode","@pBarcode","@pStockName","@pCategory","@pSubCategory","@pMeasurementUnit","@pWarehouse","@pKdv","@pExhangeRate","@pExhangeRateValue","@pUnitPrice","@pTotalPrice","@pPiece","@pState",
                            };

            DataAccess dataAccess = new DataAccess();
            dataAccess.InsertExecuteNonQuery(commandText, parameter, UserRepository.user.Id,something.StockCode,something.Barcode,something.StockName,something.Category,something.SubCategory,something.MeasurementUnit,something.Warehouse,something.Kdv,something.ExchangeRate,something.ExchangeRateValue,something.UnitPrice,something.TotalPrice,something.Piece,1);
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public DataSet ListAll()
        {
            throw new NotImplementedException();
        }

        public void Update(Stock something, int id)
        {
            throw new NotImplementedException();
        }
    }
}
