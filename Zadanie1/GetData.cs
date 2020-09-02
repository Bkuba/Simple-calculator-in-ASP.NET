using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace Zadanie1
{
    public class GetData
    {
        public int GetValue()
        {
            var connect = new Connect();
            var connection = connect.ConnectToDatabase();

            SqlCommand command = new SqlCommand("select count(*) from Wyniki;", connection);
            string result = command.ExecuteScalar().ToString();

            return Convert.ToInt32(result);
        }

        //public List<string> GetLastValue()
        //{
        //    List<string> results = new List<string>();

        //    var connect = new Connect();
        //    var connection = connect.ConnectToDatabase();

        //    string query = "SELECT TOP1* FROM Wyniki ORDER BY ID DESC;";

        //    using (SqlCommand sc = new SqlCommand(query, connection))
        //    {
        //        sc.CommandType = CommandType.Text;
        //        using (SqlDataReader dr = sc.ExecuteReader())
        //        {
        //            while (dr.Read())
        //            {
        //                results.Add(dr["id"].ToString());
        //                results.Add(dr["wynik"].ToString());
        //                results.Add(dr["dataiczas"].ToString());
        //            }
        //        }
        //    }
        //    return results;

        //}

        public List<string> GetMany()
        {
            List<string> results = new List<string>();

            var connect = new Connect();
            var connection = connect.ConnectToDatabase();

            string query = "select id, wynik, dataiczas from Wyniki;";

            using(SqlCommand sc = new SqlCommand(query, connection))
            {
                sc.CommandType = CommandType.Text;
                using(SqlDataReader dr = sc.ExecuteReader())
                {
                    while(dr.Read())
                    {
                        results.Add(dr["id"].ToString());
                        results.Add(dr["wynik"].ToString());
                        results.Add(dr["dataiczas"].ToString());
                    }
                }
            }
            return results;
        }
    }
}