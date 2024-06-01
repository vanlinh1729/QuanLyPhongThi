using QuanLyPhongThi.Models;
using QuanLyPhongThi.DataAccessLayers;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace QuanLyPhongThi
{
	public partial class frmQuanLyLichThi : Form
	{
		private LichThiDAL lichThiDAL = new LichThiDAL();
		private PhongHocDAL phongHocDAL = new PhongHocDAL();
		private MonHocDAL monHocDAL = new MonHocDAL();

		public frmQuanLyLichThi()
		{
			InitializeComponent();
		}

		private void frmQuanLyLichThi_Load(object sender, EventArgs e)
		{
			LoadData();
			LoadComboBoxData();
		}

		private void LoadComboBoxData()
		{
			// Load data into ComboBox for Phong and MonHoc
			List<PhongHoc> phongs = phongHocDAL.GetListPhongHoc();
			List<MonHoc> monHocs = monHocDAL.GetListMonHoc();

			// Clear ComboBox items
			cmbPhong.Items.Clear();
			cmbMonHoc.Items.Clear();

			// Add items to ComboBox Phong
			foreach (PhongHoc phong in phongs)
			{
				cmbPhong.Items.Add(new ComboBoxItem(phong.TenPhong, phong.MaPhong));
			}

			// Add items to ComboBox MonHoc
			foreach (MonHoc monHoc in monHocs)
			{
				cmbMonHoc.Items.Add(new ComboBoxItem(monHoc.TenMonHoc, monHoc.MaMonHoc));
			}

			// Select first item by default
			if (cmbPhong.Items.Count > 0)
			{
				cmbPhong.SelectedIndex = 0;
			}

			if (cmbMonHoc.Items.Count > 0)
			{
				cmbMonHoc.SelectedIndex = 0;
			}
		}

		private void LoadData()
		{
			dgvLichThi.DataSource = lichThiDAL.GetAllLichThi();
		}

		private void btnThem_Click(object sender, EventArgs e)
		{
			try
			{
				LichThi lichThi = new LichThi()
				{
					MaLichThi = int.Parse(txtMaLichThi.Text),
					MaPhong = ((ComboBoxItem)cmbPhong.SelectedItem).Value,
					MaMonHoc = ((ComboBoxItem)cmbMonHoc.SelectedItem).Value,
					NgayThi = dtpNgayThi.Value,
					ThoiGianBatDau = dtpThoiGianBatDau.Value.TimeOfDay,
					ThoiGianKetThuc = dtpThoiGianKetThuc.Value.TimeOfDay
				};
				if (lichThiDAL.AddLichThi(lichThi) != -1 && lichThiDAL.AddLichThi(lichThi) != -2)
				{
					MessageBox.Show("Thêm thành công!", "OK", MessageBoxButtons.OK);
				}
				else
				{
					MessageBox.Show("Lịch đã bị trùng hoặc phòng học hiện đang bảo trì, vui lòng kiểm tra lại", "Error", MessageBoxButtons.OK);
				}
				LoadData();

				ClearFields();
			}
			catch (Exception ex)
			{
				MessageBox.Show("Xảy ra lỗi khi thêm: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void btnSua_Click(object sender, EventArgs e)
		{
			try
			{
				LichThi lichThi = new LichThi()
				{
					MaLichThi = int.Parse(txtMaLichThi.Text),
					MaPhong = ((ComboBoxItem)cmbPhong.SelectedItem).Value,
					MaMonHoc = ((ComboBoxItem)cmbMonHoc.SelectedItem).Value,
					NgayThi = dtpNgayThi.Value,
					ThoiGianBatDau = dtpThoiGianBatDau.Value.TimeOfDay,
					ThoiGianKetThuc = dtpThoiGianKetThuc.Value.TimeOfDay
				};
				if (lichThiDAL.UpdateLichThi(lichThi) != -1 && lichThiDAL.UpdateLichThi(lichThi) != -2)
				{
					MessageBox.Show("Sửa thành công!", "OK", MessageBoxButtons.OK);
				}
				else
				{
					MessageBox.Show("Lịch đã bị trùng hoặc phòng học hiện đang bảo trì, vui lòng kiểm tra lại", "Error", MessageBoxButtons.OK);
				}
				LoadData();

				ClearFields();
			}
			catch (Exception ex)
			{
				MessageBox.Show("Xảy ra lỗi khi thêm: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void btnXoa_Click(object sender, EventArgs e)
		{
			try
			{
				int maLichThi = int.Parse(txtMaLichThi.Text);
				lichThiDAL.DeleteLichThi(maLichThi);
				LoadData();
				ClearFields();
			}
			catch (Exception ex)
			{
				MessageBox.Show("Xảy ra lỗi khi xóa: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void btnClear_Click(object sender, EventArgs e)
		{
			ClearFields();
		}

		private void btnThoat_Click(object sender, EventArgs e)
		{
			DialogResult result = MessageBox.Show("Bạn có muốn thoát?", "Exit", MessageBoxButtons.OKCancel);
			if (result == DialogResult.OK)
			{
				this.Close();
			}
		}

		private void ClearFields()
		{
			LoadData();
			txtMaLichThi.Text = "";
			cmbPhong.SelectedIndex = 0;
			cmbMonHoc.SelectedIndex = 0;
			dtpNgayThi.Value = DateTime.Now;
			dtpThoiGianBatDau.Value = DateTime.Now;
			dtpThoiGianKetThuc.Value = DateTime.Now;
			txtMaLichThi.Enabled = true;
		}

		private void dgvLichThi_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			if (e.RowIndex >= 0)
			{
				DataGridViewRow row = dgvLichThi.Rows[e.RowIndex];
				txtMaLichThi.Text = row.Cells["MaLichThi"].Value.ToString();
				txtMaLichThi.Enabled = false;

				// Set selected item for Phong ComboBox
				int maPhong = 0;
				if (int.TryParse(row.Cells["MaPhong"].Value.ToString(), out maPhong))
				{
					cmbPhong.SelectedItem = cmbPhong.Items.Cast<ComboBoxItem>().FirstOrDefault(item => item.Value == maPhong);
				}

				// Set selected item for MonHoc ComboBox
				int maMonHoc = 0;
				if (int.TryParse(row.Cells["MaMonHoc"].Value.ToString(), out maMonHoc))
				{
					cmbMonHoc.SelectedItem = cmbMonHoc.Items.Cast<ComboBoxItem>().FirstOrDefault(item => item.Value == maMonHoc);
				}

				// Set DateTimePicker values
				DateTime ngayThi;
				if (DateTime.TryParse(row.Cells["NgayThi"].Value.ToString(), out ngayThi))
				{
					dtpNgayThi.Value = ngayThi;
				}

				TimeSpan thoiGianBatDau;
				if (TimeSpan.TryParse(row.Cells["ThoiGianBatDau"].Value.ToString(), out thoiGianBatDau))
				{
					dtpThoiGianBatDau.Value = DateTime.Today.Add(thoiGianBatDau);
				}

				TimeSpan thoiGianKetThuc;
				if (TimeSpan.TryParse(row.Cells["ThoiGianKetThuc"].Value.ToString(), out thoiGianKetThuc))
				{
					dtpThoiGianKetThuc.Value = DateTime.Today.Add(thoiGianKetThuc);
				}
			}
		}


		private void btnTimKiem_Click(object sender, EventArgs e)
		{
			int malichthi = int.Parse(txtTimKiem.Text);
			DataTable dt = lichThiDAL.SearchLichThi(malichthi);
			dgvLichThi.DataSource = dt;
		}
	}

	// Helper class for ComboBox items
	public class ComboBoxItem
	{
		public string Text { get; set; }
		public int Value { get; set; }

		public ComboBoxItem(string text, int value)
		{
			Text = text;
			Value = value;
		}

		public override string ToString()
		{
			return Text;
		}
	}
}
