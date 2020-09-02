using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace Zadanie1
{
    public class Connect
    {
        public SqlConnection ConnectToDatabase()
        {
            string path = @"Data Source =LAPTOP-B3NUU40G\KUBASQL;Initial Catalog = BazadoAsp;User Id = gosc1; password = gosc123";
            var sqlConnection = new SqlConnection(path);
            // LUB SqlConnection sqlConnection = new SqlConnection(path);
            sqlConnection.Open();
            return sqlConnection;

        }
    }
}