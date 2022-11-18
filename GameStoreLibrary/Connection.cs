using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameStoreLibrary
{
    public class Connection
    {
        public SqlConnection cnnDatabase;

        public Connection()
        {
            cnnDatabase = new SqlConnection("Data Source=DESKTOP-C67RUF1\\SQLEXPRESS;Initial Catalog=GameStoreDatabase;Integrated Security=True;Connect Timeout=60;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        }
    }
}
