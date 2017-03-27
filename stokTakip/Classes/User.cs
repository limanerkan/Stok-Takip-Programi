using System;

namespace stokTakip.Classes
{
    class User
    {
        private int id;
        private string name;
        private string surName;
        private string email;
        private string userName;
        private string password;
        private DateTime creationDate;
        private DateTime lastLoginDate;
        private DateTime modifyDate;
        private bool state;

        public int Id
        {
            get
            {
                return id;
            }

            set
            {
                id = value;
            }
        }

        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
            }
        }

        public string SurName
        {
            get
            {
                return surName;
            }

            set
            {
                surName = value;
            }
        }

        public string Email
        {
            get
            {
                return email;
            }

            set
            {
                email = value;
            }
        }

        public string UserName
        {
            get
            {
                return userName;
            }

            set
            {
                userName = value;
            }
        }

        public string Password
        {
            get
            {
                return password;
            }

            set
            {
                password = value;
            }
        }

        public DateTime CreationDate
        {
            get
            {
                return creationDate;
            }

            set
            {
                creationDate = value;
            }
        }

        public DateTime LastLoginDate
        {
            get
            {
                return lastLoginDate;
            }

            set
            {
                lastLoginDate = value;
            }
        }

        public DateTime ModifyDate
        {
            get
            {
                return modifyDate;
            }

            set
            {
                modifyDate = value;
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
    }
}
