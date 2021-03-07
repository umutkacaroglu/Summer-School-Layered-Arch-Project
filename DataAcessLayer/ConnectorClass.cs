using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DataAccessLayer
{
    class ConnectorClass
    {
        //SQL Bağlantısını public olarak tanımlanan nesne ile istedğimiz yerde sağlayacağız.
        public static SqlConnection connector = new SqlConnection("Data Source=DESKTOP-2IQELU5\\UMUTKACAROGLU271;Initial Catalog=Dbo_YazOkulu;Integrated Security=True");

    }
}
