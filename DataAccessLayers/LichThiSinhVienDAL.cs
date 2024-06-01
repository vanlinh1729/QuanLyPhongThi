using QuanLyPhongThi.Models;
using System.Data;
using Microsoft.Data.SqlClient;

namespace QuanLyPhongThi.DataAccessLayers
{
	public class LichThiSinhVienDAL
	{
		private DataProvider dataProvider = new DataProvider();
		public DataTable GetLichThiSinhVienByMaSinhVien(int msv)
		{
			string query = @"SELECT lt.MaMonHoc, mh.TenMonHoc, lt.NgayThi, lt.ThoiGianBatDau, lt.ThoiGianKetThuc, 
                             lt.MaPhong, ph.TenPhong, ltsv.MaSinhVien, sv.HoTen
                     FROM LichThi_SinhVien ltsv
                     INNER JOIN LichThi lt ON ltsv.MaLichThi = lt.MaLichThi
                     INNER JOIN MonHoc mh ON lt.MaMonHoc = mh.MaMonHoc
                     INNER JOIN PhongHoc ph ON lt.MaPhong = ph.MaPhong
                     INNER JOIN SinhVien sv ON ltsv.MaSinhVien = sv.MaSinhVien
					WHERE ltsv.MaSinhVien = @MaSinhVien";
			SqlParameter[] parameters = new SqlParameter[]
			{
				new SqlParameter("@MaSinhVien", SqlDbType.Int) { Value = msv }
			};
			return dataProvider.ExecuteQuery(query, parameters);
		}
		public DataTable GetAllLichThiSinhVien()
		{
			string query = @"SELECT lt.MaMonHoc, ltsv.MaLichThi, mh.TenMonHoc, lt.NgayThi, lt.ThoiGianBatDau, lt.ThoiGianKetThuc, 
                             lt.MaPhong, ph.TenPhong, ltsv.MaSinhVien, sv.HoTen
                     FROM LichThi_SinhVien ltsv
                     INNER JOIN LichThi lt ON ltsv.MaLichThi = lt.MaLichThi
                     INNER JOIN MonHoc mh ON lt.MaMonHoc = mh.MaMonHoc
                     INNER JOIN PhongHoc ph ON lt.MaPhong = ph.MaPhong
                     INNER JOIN SinhVien sv ON ltsv.MaSinhVien = sv.MaSinhVien";
			return dataProvider.ExecuteQuery(query);
		}


		public int AddLichThiSinhVien(LichThiSinhVien lichThi_SinhVien)
		{
			string query = "INSERT INTO LichThi_SinhVien (MaLichThi, MaSinhVien) VALUES (@MaLichThi, @MaSinhVien)";
			SqlParameter[] parameters = new SqlParameter[]
			{
				new SqlParameter("@MaLichThi", SqlDbType.Int) { Value = lichThi_SinhVien.MaLichThi },
				new SqlParameter("@MaSinhVien", SqlDbType.Int) { Value = lichThi_SinhVien.MaSinhVien }
			};
			return dataProvider.ExecuteNonQuery(query, parameters);
		}

		public int UpdateLichThiSinhVien(LichThiSinhVien lichThi_SinhVien)
		{
			string query = "UPDATE LichThi_SinhVien SET MaSinhVien = @MaSinhVien WHERE MaLichThi = @MaLichThi";
			SqlParameter[] parameters = new SqlParameter[]
			{
				new SqlParameter("@MaSinhVien", SqlDbType.Int) { Value = lichThi_SinhVien.MaSinhVien },
				new SqlParameter("@MaLichThi", SqlDbType.Int) { Value = lichThi_SinhVien.MaLichThi }
			};
			return dataProvider.ExecuteNonQuery(query, parameters);
		}

		public int DeleteLichThiSinhVien(int maLichThi, int maSinhVien)
		{
			string query = "DELETE FROM LichThi_SinhVien WHERE MaLichThi = @MaLichThi AND MaSinhVien = @MaSinhVien";
			SqlParameter[] parameters = new SqlParameter[]
			{
				new SqlParameter("@MaLichThi", SqlDbType.Int) { Value = maLichThi },
				new SqlParameter("@MaSinhVien", SqlDbType.Int) { Value = maSinhVien }
			};
			return dataProvider.ExecuteNonQuery(query, parameters);
		}
	}
}
