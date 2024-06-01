using QuanLyPhongThi.DataAccessLayers;
using QuanLyPhongThi.Models;
using System;
using System.Windows.Forms;

namespace QuanLyPhongThi
{
	public partial class frmQuanLySinhVien : Form
	{
		private SinhVienDAL sinhVienDAL = new SinhVienDAL();

		public frmQuanLySinhVien()
		{
			InitializeComponent();
			LoadData();
		}

		private void LoadData()
		{
			dgvSinhVien.DataSource = sinhVienDAL.GetAllSinhVien();
		}

		private void btnThem_Click(object sender, EventArgs e)
		{
			try
			{
				SinhVien sinhVien = new SinhVien();
				sinhVien.MaSinhVien = int.Parse(txtMaSinhVien.Text);
				sinhVien.HoTen = txtHoTen.Text;
				sinhVien.NgaySinh = dtpNgaySinh.Value;
				sinhVien.Lop = txtLop.Text;
				sinhVienDAL.AddSinhVien(sinhVien);
				LoadData();
				btnClear_Click(sender, e);
				MessageBox.Show("Thêm thành công!", "OK", MessageBoxButtons.OK);
			}
			catch (Exception ex)
			{
				MessageBox.Show("Xảy ra lỗi khi thêm: ( " + ex.Message + "). Vui lòng kiểm tra lại.", "Error", MessageBoxButtons.OK);
			}
		}

		private void btnSua_Click(object sender, EventArgs e)
		{
			try
			{
				SinhVien sinhVien = new SinhVien();
				sinhVien.MaSinhVien = int.Parse(txtMaSinhVien.Text);
				sinhVien.HoTen = txtHoTen.Text;
				sinhVien.NgaySinh = dtpNgaySinh.Value;
				sinhVien.Lop = txtLop.Text;

				sinhVienDAL.UpdateSinhVien(sinhVien);
				LoadData();
				btnClear_Click(sender, e);
				MessageBox.Show("Sửa thành công!", "OK", MessageBoxButtons.OK);

			}
			catch (Exception ex)
			{
				MessageBox.Show("Xảy ra lỗi khi sửa: ( " + ex.Message + "). Vui lòng kiểm tra lại.", "Error", MessageBoxButtons.OK);
			}
		}


		private void btnXoa_Click(object sender, EventArgs e)
		{
			try
			{
				int maSinhVien = int.Parse(txtMaSinhVien.Text);
				sinhVienDAL.DeleteSinhVien(maSinhVien);
				LoadData();
				btnClear_Click(sender, e);
				MessageBox.Show("Xoá thành công!", "OK", MessageBoxButtons.OK);
			}
			catch (Exception ex)
			{
				MessageBox.Show("Xảy ra lỗi khi xoá: ( " + ex.Message + "). Vui lòng kiểm tra lại.", "Error", MessageBoxButtons.OK);
			}
		}

		private void dgvSinhVien_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			if (e.RowIndex >= 0)
			{
				DataGridViewRow row = dgvSinhVien.Rows[e.RowIndex];
				txtMaSinhVien.Text = row.Cells["MaSinhVien"].Value.ToString();
				txtHoTen.Text = row.Cells["HoTen"].Value.ToString();
				// Kiểm tra nếu giá trị của cột "NgaySinh" không phải là DBNull thì mới chuyển đổi sang kiểu DateTime
				if (!Convert.IsDBNull(row.Cells["NgaySinh"].Value))
				{
					dtpNgaySinh.Value = Convert.ToDateTime(row.Cells["NgaySinh"].Value);
				}
				else
				{
					// Nếu giá trị là DBNull, gán ngày hiện tại cho dtpNgaySinh
					dtpNgaySinh.Value = DateTime.Now;
				};
				txtLop.Text = row.Cells["Lop"].Value.ToString();
				txtMaSinhVien.Enabled = false;
			}
		}

		private void btnClear_Click(object sender, EventArgs e)
		{
			LoadData();
			txtMaSinhVien.Clear();
			txtHoTen.Clear();
			txtLop.Clear();
			dtpNgaySinh.Value = DateTime.Now;

			// Kích hoạt lại trường nhập liệu Mã Sinh Viên
			txtMaSinhVien.Enabled = true;
		}

		private void btnThoat_Click(object sender, EventArgs e)
		{
			DialogResult result = MessageBox.Show("Bạn có muốn thoát?", "Exit", MessageBoxButtons.OKCancel);
			if (result == DialogResult.OK)
			{
				this.Close();
			}
		}
		private void btnTimKiem_Click(object sender, EventArgs e)
		{
			if (!string.IsNullOrEmpty(txtTimKiem.Text))
			{
				int maSinhVien = int.Parse(txtTimKiem.Text);
				dgvSinhVien.DataSource = sinhVienDAL.TimKiemSinhVien(maSinhVien);
			}
			else
			{
				MessageBox.Show("Vui lòng nhập mã sinh viên cần tìm kiếm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
		}


		private void txtMaSinhVien_KeyPress(object sender, KeyPressEventArgs e)
		{
			// Chỉ cho phép nhập số vào TextBox của mã sinh viên
			if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
			{
				e.Handled = true;
			}
		}
	}
}
