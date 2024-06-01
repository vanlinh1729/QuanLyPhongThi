using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyPhongThi.Models
{
	public class LichThi
	{
		public int MaLichThi { get; set; }
		public int MaPhong { get; set; }
		public int MaMonHoc { get; set; }
		public DateTime NgayThi { get; set; }
		public TimeSpan ThoiGianBatDau { get; set; }
		public TimeSpan ThoiGianKetThuc { get; set; }
	}
}
