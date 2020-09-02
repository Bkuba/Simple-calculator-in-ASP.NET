using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Windows.Forms;

namespace Zadanie1
{
    public class AddResultsToBase
    {
        public bool SaveToBase(ModelBazy result)
        {
			try
			{
				var connect = new Connect();
				var connection = connect.ConnectToDatabase();

				using(var command = new SqlCommand())
				{
					string query = "INSERT INTO Wyniki VALUES (@wynik, current_timestamp);";
					command.CommandType = CommandType.Text;
					command.Connection = connection;
					command.CommandText = query;

					command.Parameters.AddWithValue("@wynik", result.Wynik);

					command.ExecuteNonQuery();
					command.Parameters.Clear();
				}

				connection.Close();
				return true;
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
				return false;
			}
        }
    }
}