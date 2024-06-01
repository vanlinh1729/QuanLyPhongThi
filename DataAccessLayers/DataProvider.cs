using System.Data;
using Microsoft.Data.SqlClient; // Đảm bảo sử dụng đúng namespace

public class DataProvider
{
	private string connectionString = "Data Source=DESKTOP-JLVRD36;Initial Catalog=QuanLyPhongThi;Encrypt=false;Trusted_Connection=true;TrustServerCertificate=False;";

	public DataTable ExecuteQuery(string query, SqlParameter[] parameters = null)
	{
		using (SqlConnection connection = new SqlConnection(connectionString))
		{
			using (SqlCommand command = new SqlCommand(query, connection))
			{
				if (parameters != null)
				{
					command.Parameters.AddRange(parameters);
				}

				SqlDataAdapter adapter = new SqlDataAdapter(command);
				DataTable dataTable = new DataTable();
				adapter.Fill(dataTable);
				return dataTable;
			}
		}
	}

	public int ExecuteNonQuery(string query, SqlParameter[] parameters = null)
	{
		using (SqlConnection connection = new SqlConnection(connectionString))
		{
			using (SqlCommand command = new SqlCommand(query, connection))
			{
				if (parameters != null)
				{
					command.Parameters.AddRange(parameters);
				}

				connection.Open();
				int result = command.ExecuteNonQuery();
				connection.Close();
				return result;
			}
		}
	}
}
