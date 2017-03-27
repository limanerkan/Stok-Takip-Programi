namespace stokTakip.Classes
{
    class Warehouse
    {
        private int userID;
        private string wareHouseName;
        private string adress;
        private string phoneNumber;

        public int UserID
        {
            get
            {
                return userID;
            }

            set
            {
                userID = value;
            }
        }

        public string WareHouseName
        {
            get
            {
                return wareHouseName;
            }

            set
            {
                wareHouseName = value;
            }
        }

        public string Adress
        {
            get
            {
                return adress;
            }

            set
            {
                adress = value;
            }
        }

        public string PhoneNumber
        {
            get
            {
                return phoneNumber;
            }

            set
            {
                phoneNumber = value;
            }
        }
    }
}
