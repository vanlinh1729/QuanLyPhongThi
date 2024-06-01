using QuanLyPhongThi.Models;
using System.Data;
using Microsoft.Data.SqlClient; // Đảm bảo sử dụng đúng namespace

namespace QuanLyPhongThi.DataAccessLayers
{
	public class PhongHocDAL
	{
		private DataProvider dataProvider = new DataProvider();

		public DataTable GetAllPhongHoc()
		{
			string query = "SELECT * FROM PhongHoc";
			return dataProvider.ExecuteQuery(query);
		}
		public List<PhongHoc> GetListPhongHoc()
		{
			string query = "SELECT * FROM PhongHoc";
			DataTable dt = dataProvider.ExecuteQuery(query);
			List<PhongHoc> phongHocs = new List<PhongHoc>();

			foreach (DataRow row in dt.Rows)
			{
				PhongHoc phongHoc = new PhongHoc
				{
					MaPhong = int.Parse(row["MaPhong"].ToString()),
					TenPhong = row["TenPhong"].ToString()
				};
				phongHocs.Add(phongHoc);
			}

			return phongHocs;
		}
		public int AddPhongHoc(PhongHoc phongHoc)
		{
			string query = "INSERT INTO PhongHoc (TenPhong, SucChua, TrangThietBi, TinhTrang) VALUES (@TenPhong, @SucChua, @TrangThietBi, @TinhTrang)";
			SqlParameter[] parameters = new SqlParameter[]
			{
				new SqlParameter("@TenPhong", SqlDbType.NVarChar) { Value = phongHoc.TenPhong },
				new SqlParameter("@SucChua", SqlDbType.Int) { Value = phongHoc.SucChua },
				new SqlParameter("@TrangThietBi", SqlDbType.NVarChar) { Value = phongHoc.TrangThietBi },
				new SqlParameter("@TinhTrang", SqlDbType.NVarChar) { Value = phongHoc.TinhTrang }
			};
			return dataProvider.ExecuteNonQuery(query, parameters);
		}

		public int UpdatePhongHoc(PhongHoc phongHoc)
		{
			string query = "UPDATE PhongHoc SET TenPhong = @TenPhong, SucChua = @SucChua, TrangThietBi = @TrangThietBi, TinhTrang = @TinhTrang WHERE MaPhong = @MaPhong";
			SqlParameter[] parameters = new SqlParameter[]
			{
				new SqlParameter("@TenPhong", SqlDbType.NVarChar) { Value = phongHoc.TenPhong },
				new SqlParameter("@SucChua", SqlDbType.Int) { Value = phongHoc.SucChua },
				new SqlParameter("@TrangThietBi", SqlDbType.NVarChar) { Value = phongHoc.TrangThietBi },
				new SqlParameter("@TinhTrang", SqlDbType.NVarChar) { Value = phongHoc.TinhTrang },
				new SqlParameter("@MaPhong", SqlDbType.Int) { Value = phongHoc.MaPhong }
			};
			return dataProvider.ExecuteNonQuery(query, parameters);
		}

		public int DeletePhongHoc(int maPhong)
		{
			string query = "DELETE FROM PhongHoc WHERE MaPhong = @MaPhong";
			SqlParameter parameter = new SqlParameter("@MaPhong", SqlDbType.Int) { Value = maPhong };
			return dataProvider.ExecuteNonQuery(query, new SqlParameter[] { parameter });
		}
	}
}
