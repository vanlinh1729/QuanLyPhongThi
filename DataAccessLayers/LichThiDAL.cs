	using System.Data;
	using Microsoft.Data.SqlClient;
	using QuanLyPhongThi.Models;

	namespace QuanLyPhongThi.DataAccessLayers
	{
		public class LichThiDAL
		{
			private DataProvider dataProvider = new DataProvider();

			public DataTable GetAllLichThi()
			{
				string query = @"
			SELECT LT.MaLichThi, LT.MaPhong, PH.TenPhong,LT.MaMonHoc, MH.TenMonHoc, LT.NgayThi, LT.ThoiGianBatDau, LT.ThoiGianKetThuc
			FROM LichThi LT
			JOIN PhongHoc PH ON LT.MaPhong = PH.MaPhong
			JOIN MonHoc MH ON LT.MaMonHoc = MH.MaMonHoc";
				return dataProvider.ExecuteQuery(query);
			}

			public DataTable SearchLichThi(int malichthi)
			{
				string query = @"
			SELECT LT.MaLichThi, LT.MaPhong, PH.TenPhong,LT.MaMonHoc, MH.TenMonHoc, LT.NgayThi, LT.ThoiGianBatDau, LT.ThoiGianKetThuc
			FROM LichThi LT
			JOIN PhongHoc PH ON LT.MaPhong = PH.MaPhong
			JOIN MonHoc MH ON LT.MaMonHoc = MH.MaMonHoc WHERE MaLichThi = @MaLichThi";
				SqlParameter[] parameters = new SqlParameter[]
				{
				new SqlParameter("@MaLichThi", SqlDbType.Int) { Value = malichthi }
				};
				return dataProvider.ExecuteQuery(query, parameters);
			}

			public int AddLichThi(LichThi lichThi)
			{
				// Kiểm tra xem có lịch thi trùng lặp không
				string queryCheckOverlap = @"
			SELECT COUNT(*) 
			FROM LichThi 
			WHERE MaPhong = @MaPhong AND 
				  ((NgayThi = @NgayThi AND @ThoiGianBatDau BETWEEN ThoiGianBatDau AND ThoiGianKetThuc) 
				   OR (NgayThi = @NgayThi AND @ThoiGianKetThuc BETWEEN ThoiGianBatDau AND ThoiGianKetThuc))";

				// Thực hiện truy vấn để kiểm tra lịch trùng lặp
				SqlParameter[] parametersCheckOverlap = new SqlParameter[]
				{
			new SqlParameter("@MaPhong", SqlDbType.Int) { Value = lichThi.MaPhong },
			new SqlParameter("@NgayThi", SqlDbType.Date) { Value = lichThi.NgayThi },
			new SqlParameter("@ThoiGianBatDau", SqlDbType.Time) { Value = lichThi.ThoiGianBatDau },
			new SqlParameter("@ThoiGianKetThuc", SqlDbType.Time) { Value = lichThi.ThoiGianKetThuc }
				};

				// Thực hiện truy vấn và lấy số lượng lịch thi trùng lặp
				DataTable result = dataProvider.ExecuteQuery(queryCheckOverlap, parametersCheckOverlap);

				// Lấy số lượng lịch trùng lặp từ dòng kết quả
				int numberOfOverlappingSchedules = Convert.ToInt32(result.Rows[0][0]);

				// Nếu có lịch trùng lặp, trả về mã lỗi
				if (numberOfOverlappingSchedules > 0)
				{
					return -1;
				}

				// Kiểm tra tình trạng của phòng
				string queryCheckRoomStatus = "SELECT TinhTrang FROM PhongHoc WHERE MaPhong = @MaPhong";

				// Thực hiện truy vấn để lấy tình trạng của phòng
				SqlParameter[] parametersCheckRoomStatus = new SqlParameter[]
				{
					new SqlParameter("@MaPhong", SqlDbType.Int) { Value = lichThi.MaPhong }
				};

				// Thực hiện truy vấn và lấy tình trạng của phòng
				DataTable resultRoomStatus = dataProvider.ExecuteQuery(queryCheckRoomStatus, parametersCheckRoomStatus);

				// Kiểm tra tình trạng của phòng
				if (resultRoomStatus.Rows.Count > 0)
				{
					string roomStatus = resultRoomStatus.Rows[0]["TinhTrang"].ToString();

					// Nếu phòng có tình trạng là "hoạt động"
					if (roomStatus == "Hoạt động")
					{
						string queryAddLichThi = "INSERT INTO LichThi (MaLichThi, MaPhong, MaMonHoc, NgayThi, ThoiGianBatDau, ThoiGianKetThuc) VALUES (@MaLichThi, @MaPhong, @MaMonHoc, @NgayThi, @ThoiGianBatDau, @ThoiGianKetThuc)";
						SqlParameter[] parametersAddLichThi = new SqlParameter[]
						{
							new SqlParameter("@MaLichThi", SqlDbType.Int) { Value = lichThi.MaLichThi },
							new SqlParameter("@MaPhong", SqlDbType.Int) { Value = lichThi.MaPhong },
							new SqlParameter("@MaMonHoc", SqlDbType.Int) { Value = lichThi.MaMonHoc },
							new SqlParameter("@NgayThi", SqlDbType.DateTime) { Value = lichThi.NgayThi },
							new SqlParameter("@ThoiGianBatDau", SqlDbType.Time) { Value = lichThi.ThoiGianBatDau },
							new SqlParameter("@ThoiGianKetThuc", SqlDbType.Time) { Value = lichThi.ThoiGianKetThuc }
						};

						// Thực hiện thêm mới lịch thi
						return dataProvider.ExecuteNonQuery(queryAddLichThi, parametersAddLichThi);
					}
					else
					{
						// Nếu phòng không có tình trạng là "hoạt động", trả về mã lỗi
						return -2;
					}
				}
				return 0; 
			}

			public int UpdateLichThi(LichThi lichThi)
			{
				// Kiểm tra xem có lịch thi trùng lặp không
				string queryCheckOverlap = @"
			SELECT COUNT(*) 
			FROM LichThi 
			WHERE MaPhong = @MaPhong AND 
				  ((NgayThi = @NgayThi AND @ThoiGianBatDau BETWEEN ThoiGianBatDau AND ThoiGianKetThuc) 
				   OR (NgayThi = @NgayThi AND @ThoiGianKetThuc BETWEEN ThoiGianBatDau AND ThoiGianKetThuc))";

				// Thực hiện truy vấn để kiểm tra lịch trùng lặp
				SqlParameter[] parametersCheckOverlap = new SqlParameter[]
				{
			new SqlParameter("@MaPhong", SqlDbType.Int) { Value = lichThi.MaPhong },
			new SqlParameter("@NgayThi", SqlDbType.Date) { Value = lichThi.NgayThi },
			new SqlParameter("@ThoiGianBatDau", SqlDbType.Time) { Value = lichThi.ThoiGianBatDau },
			new SqlParameter("@ThoiGianKetThuc", SqlDbType.Time) { Value = lichThi.ThoiGianKetThuc }
				};

				// Thực hiện truy vấn và lấy số lượng lịch thi trùng lặp
				DataTable result = dataProvider.ExecuteQuery(queryCheckOverlap, parametersCheckOverlap);

				// Lấy số lượng lịch trùng lặp từ dòng kết quả
				int numberOfOverlappingSchedules = Convert.ToInt32(result.Rows[0][0]);

				// Nếu có lịch trùng lặp, trả về mã lỗi
				if (numberOfOverlappingSchedules > 0)
				{
					return -1;
				}

				// Kiểm tra tình trạng của phòng
				string queryCheckRoomStatus = "SELECT TinhTrang FROM PhongHoc WHERE MaPhong = @MaPhong";

				// Thực hiện truy vấn để lấy tình trạng của phòng
				SqlParameter[] parametersCheckRoomStatus = new SqlParameter[]
				{
					new SqlParameter("@MaPhong", SqlDbType.Int) { Value = lichThi.MaPhong }
				};

				// Thực hiện truy vấn và lấy tình trạng của phòng
				DataTable resultRoomStatus = dataProvider.ExecuteQuery(queryCheckRoomStatus, parametersCheckRoomStatus);

				// Kiểm tra tình trạng của phòng
				if (resultRoomStatus.Rows.Count > 0)
				{
					string roomStatus = resultRoomStatus.Rows[0]["TinhTrang"].ToString();

					// Nếu phòng có tình trạng là "hoạt động"
					if (roomStatus == "Hoạt động")
					{
						// Nếu không có sự trùng lặp, thực hiện cập nhật lịch thi
						string queryUpdateLichThi = "UPDATE LichThi SET MaPhong = @MaPhong, MaMonHoc = @MaMonHoc, NgayThi = @NgayThi, ThoiGianBatDau = @ThoiGianBatDau, ThoiGianKetThuc = @ThoiGianKetThuc WHERE MaLichThi = @MaLichThi";
						SqlParameter[] parametersUpdateLichThi = new SqlParameter[]
						{
			new SqlParameter("@MaPhong", SqlDbType.Int) { Value = lichThi.MaPhong },
			new SqlParameter("@MaMonHoc", SqlDbType.Int) { Value = lichThi.MaMonHoc },
			new SqlParameter("@NgayThi", SqlDbType.DateTime) { Value = lichThi.NgayThi },
			new SqlParameter("@ThoiGianBatDau", SqlDbType.Time) { Value = lichThi.ThoiGianBatDau },
			new SqlParameter("@ThoiGianKetThuc", SqlDbType.Time) { Value = lichThi.ThoiGianKetThuc },
			new SqlParameter("@MaLichThi", SqlDbType.Int) { Value = lichThi.MaLichThi }
						};

						// Thực hiện cập nhật lịch thi
						return dataProvider.ExecuteNonQuery(queryUpdateLichThi, parametersUpdateLichThi);
					}
					else
					{
						// Nếu phòng không có tình trạng là "hoạt động", trả về mã lỗi
						return -2;
					}
				}
				return 0;
			
			}


			public int DeleteLichThi(int maLichThi)
			{
				string query = "DELETE FROM LichThi WHERE MaLichThi = @MaLichThi";
				SqlParameter[] parameters = new SqlParameter[]
				{
					new SqlParameter("@MaLichThi", SqlDbType.Int) { Value = maLichThi }
				};
				return dataProvider.ExecuteNonQuery(query, parameters);
			}
		}
	}
