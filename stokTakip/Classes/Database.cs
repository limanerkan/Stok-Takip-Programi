using System.Data.SqlClient;
using System.Windows.Forms;

namespace stokTakip.Classes
{
    class Database
    {
        public static SqlConnection GetConnection()
        {
          



           
            string connLocal=@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + Application.StartupPath + "\\stokTakip.mdf;Integrated Security=True;Connect Timeout=30";
            return new SqlConnection(connLocal);
        }
    }
}
