using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stokTakip.Classes
{
    class SubCategory
    {
        private int categoryId;
        private string subCategoryName;

        public int CategoryId
        {
            get
            {
                return categoryId;
            }

            set
            {
                categoryId = value;
            }
        }

        public string SubCategoryName
        {
            get
            {
                return subCategoryName;
            }

            set
            {
                subCategoryName = value;
            }
        }
    }
}
