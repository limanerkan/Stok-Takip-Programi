namespace stokTakip.Classes
{
    class Stock
    {
        private int userId;
        private int stockCode;
        private int barcode;
        private string stockName;
        private string measurementUnit;
        private string warehouse;
        private int kdv;
        private string exchangeRate;
        private decimal exchangeRateValue;
        private decimal unitPrice;
        private decimal totalPrice;
        private int piece;
        private bool state;
        private int category;
        private int subCategory;
        public int UserId
        {
            get
            {
                return userId;
            }

            set
            {
                userId = value;
            }
        }

        public int StockCode
        {
            get
            {
                return stockCode;
            }

            set
            {
                stockCode = value;
            }
        }

        public int Barcode
        {
            get
            {
                return barcode;
            }

            set
            {
                barcode = value;
            }
        }

        public string StockName
        {
            get
            {
                return stockName;
            }

            set
            {
                stockName = value;
            }
        }

        public string MeasurementUnit
        {
            get
            {
                return measurementUnit;
            }

            set
            {
                measurementUnit = value;
            }
        }

        public string Warehouse
        {
            get
            {
                return warehouse;
            }

            set
            {
                warehouse = value;
            }
        }

        public int Kdv
        {
            get
            {
                return kdv;
            }

            set
            {
                kdv = value;
            }
        }

        public string ExchangeRate
        {
            get
            {
                return exchangeRate;
            }

            set
            {
                exchangeRate = value;
            }
        }

        public decimal ExchangeRateValue
        {
            get
            {
                return exchangeRateValue;
            }

            set
            {
                exchangeRateValue = value;
            }
        }

        public decimal UnitPrice
        {
            get
            {
                return unitPrice;
            }

            set
            {
                unitPrice = value;
            }
        }

        public decimal TotalPrice
        {
            get
            {
                return totalPrice;
            }

            set
            {
                totalPrice = value;
            }
        }

        public int Piece
        {
            get
            {
                return piece;
            }

            set
            {
                piece = value;
            }
        }

        public bool State
        {
            get
            {
                return state;
            }

            set
            {
                state = value;
            }
        }

        public int Category
        {
            get
            {
                return category;
            }

            set
            {
                category = value;
            }
        }

        public int SubCategory
        {
            get
            {
                return subCategory;
            }

            set
            {
                subCategory = value;
            }
        }
    }
}
