using QuanLyPhongThi.Models;
using System.Data;
using Microsoft.Data.SqlClient;

namespace QuanLyPhongThi.DataAccessLayers
{
	public class MonHocDAL
	{
		private DataProvider dataProvider = new DataProvider();

		public DataTable GetAllMonHoc()
		{
			string query = "SELECT * FROM MonHoc";
			return dataProvider.ExecuteQuery(query);
		}
		public List<MonHoc> GetListMonHoc()
		{
			string query = "SELECT * FROM MonHoc";
			DataTable dt = dataProvider.ExecuteQuery(query);
			List<MonHoc> monHocs = new List<MonHoc>();

			foreach (DataRow row in dt.Rows)
			{
				MonHoc monHoc = new MonHoc
				{
					MaMonHoc = int.Parse(row["MaMonHoc"].ToString()),
					TenMonHoc = row["TenMonHoc"].ToString()
				};
				monHocs.Add(monHoc);
			}

			return monHocs;
		}
		public DataTable TimKiemMonHoc(int mamonhoc)
		{
			string query = "SELECT * FROM MonHoc WHERE MaMonHoc = @MaMonHoc";
			SqlParameter[] parameters = new SqlParameter[]
			{
			new SqlParameter("@MaMonHoc", SqlDbType.Int) { Value = mamonhoc }
			};
			return dataProvider.ExecuteQuery(query, parameters);
		}
		public int AddMonHoc(MonHoc monHoc)
		{
			string query = "INSERT INTO MonHoc (MaMonHoc, TenMonHoc, SoTinChi) VALUES (@MaMonHoc, @TenMonHoc, @SoTinChi)";
			SqlParameter[] parameters = new SqlParameter[]
			{
				new SqlParameter("@MaMonHoc", SqlDbType.Int) { Value = monHoc.MaMonHoc },
				new SqlParameter("@TenMonHoc", SqlDbType.NVarChar) { Value = monHoc.TenMonHoc },
				new SqlParameter("@SoTinChi", SqlDbType.Int) { Value = monHoc.SoTinChi }
			};
			return dataProvider.ExecuteNonQuery(query, parameters);
		}

		public int UpdateMonHoc(MonHoc monHoc)
		{
			string query = "UPDATE MonHoc SET TenMonHoc = @TenMonHoc, SoTinChi = @SoTinChi WHERE MaMonHoc = @MaMonHoc";
			SqlParameter[] parameters = new SqlParameter[]
			{
				new SqlParameter("@TenMonHoc", SqlDbType.NVarChar) { Value = monHoc.TenMonHoc },
				new SqlParameter("@SoTinChi", SqlDbType.Int) { Value = monHoc.SoTinChi },
				new SqlParameter("@MaMonHoc", SqlDbType.Int) { Value = monHoc.MaMonHoc }
			};
			return dataProvider.ExecuteNonQuery(query, parameters);
		}

		public int DeleteMonHoc(int maMonHoc)
		{
			string query = "DELETE FROM MonHoc WHERE MaMonHoc = @MaMonHoc";
			SqlParameter parameter = new SqlParameter("@MaMonHoc", SqlDbType.Int) { Value = maMonHoc };
			return dataProvider.ExecuteNonQuery(query, new SqlParameter[] { parameter });
		}
	}
}
