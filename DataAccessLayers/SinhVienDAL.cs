using QuanLyPhongThi.Models;
using System.Data;
using Microsoft.Data.SqlClient;

namespace QuanLyPhongThi.DataAccessLayers
{
	public class SinhVienDAL
	{
		private DataProvider dataProvider = new DataProvider();

		public DataTable GetAllSinhVien()
		{
			string query = "SELECT * FROM SinhVien";
			return dataProvider.ExecuteQuery(query);
		}

		public DataTable TimKiemSinhVien(int masv)
		{
			string query = "SELECT * FROM SinhVien WHERE MaSinhVien = @MaSinhVien";
			SqlParameter[] parameters = new SqlParameter[]
			{
			new SqlParameter("@MaSinhVien", SqlDbType.Int) { Value = masv }
			};
			return dataProvider.ExecuteQuery(query, parameters);
		}

		public int AddSinhVien(SinhVien sinhVien)
		{
			string query = "INSERT INTO SinhVien (MaSinhVien, HoTen, NgaySinh, Lop) VALUES (@MaSinhVien, @HoTen, @NgaySinh, @Lop)";
			SqlParameter[] parameters = new SqlParameter[]
			{
				new SqlParameter("@MaSinhVien", SqlDbType.Int) { Value = sinhVien.MaSinhVien },
				new SqlParameter("@HoTen", SqlDbType.NVarChar) { Value = sinhVien.HoTen },
				new SqlParameter("@NgaySinh", SqlDbType.DateTime) { Value = sinhVien.NgaySinh },
				new SqlParameter("@Lop", SqlDbType.NVarChar) { Value = sinhVien.Lop }
			};
			return dataProvider.ExecuteNonQuery(query, parameters);
		}

		public int UpdateSinhVien(SinhVien sinhVien)
		{
			string query = "UPDATE SinhVien SET HoTen = @HoTen, NgaySinh = @NgaySinh, Lop = @Lop WHERE MaSinhVien = @MaSinhVien";
			SqlParameter[] parameters = new SqlParameter[]
			{
				new SqlParameter("@HoTen", SqlDbType.NVarChar) { Value = sinhVien.HoTen },
				new SqlParameter("@NgaySinh", SqlDbType.DateTime) { Value = sinhVien.NgaySinh },
				new SqlParameter("@Lop", SqlDbType.NVarChar) { Value = sinhVien.Lop },
				new SqlParameter("@MaSinhVien", SqlDbType.Int) { Value = sinhVien.MaSinhVien }
			};
			return dataProvider.ExecuteNonQuery(query, parameters);
		}

		public int DeleteSinhVien(int maSinhVien)
		{
			string query = "DELETE FROM SinhVien WHERE MaSinhVien = @MaSinhVien";
			SqlParameter parameter = new SqlParameter("@MaSinhVien", SqlDbType.Int) { Value = maSinhVien };
			return dataProvider.ExecuteNonQuery(query, new SqlParameter[] { parameter });
		}
	}
}
