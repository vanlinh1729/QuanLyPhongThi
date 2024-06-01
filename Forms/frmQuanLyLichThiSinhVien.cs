using QuanLyPhongThi.DataAccessLayers;
using QuanLyPhongThi.Models;
using System;
using System.Data;
using System.Windows.Forms;

namespace QuanLyPhongThi
{
	public partial class frmQuanLyLichThiSinhVien : Form
	{
		private LichThiSinhVienDAL lichThiSinhVienDAL = new LichThiSinhVienDAL();
		private LichThiDAL lichThiDAL = new LichThiDAL();


		public frmQuanLyLichThiSinhVien()
		{
			InitializeComponent();
		}

		private void frmQuanLyLichThiSinhVien_Load(object sender, EventArgs e)
		{
			LoadData();
			LoadComboBoxData();
		}

		private void LoadData()
		{
			dgvLichThiSinhVien.DataSource = lichThiSinhVienDAL.GetAllLichThiSinhVien();
		}

		private void LoadComboBoxData()
		{
			cmbMaLichThi.DataSource = lichThiDAL.GetAllLichThi();
			cmbMaLichThi.DisplayMember = "MaLichThi";
			cmbMaLichThi.ValueMember = "MaLichThi";
		}

		private void btnThem_Click(object sender, EventArgs e)
		{
			try
			{
				int maLichThi = Convert.ToInt32(cmbMaLichThi.SelectedValue);
				int maSinhVien = Convert.ToInt32(txtMaSinhVien.Text);
				var lichthisinhvien = new LichThiSinhVien()
				{
					MaLichThi = maLichThi,
					MaSinhVien = maSinhVien
				};
				lichThiSinhVienDAL.AddLichThiSinhVien(lichthisinhvien);
				LoadData();
				MessageBox.Show("Thêm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);


			}
			catch (Exception ex)
			{
				MessageBox.Show("Thêm thất bại! (" + ex.Message + "). Hãy kiểm tra lại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);

			}

		}

		private void btnXoa_Click(object sender, EventArgs e)
		{
			try
			{
				int maLichThi = Convert.ToInt32(cmbMaLichThi.SelectedValue);
				int maSinhVien = Convert.ToInt32(txtMaSinhVien.Text);
				lichThiSinhVienDAL.DeleteLichThiSinhVien(maLichThi, maSinhVien);
				LoadData();
				MessageBox.Show("Xoá thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
			catch (Exception ex)
			{
				MessageBox.Show("Xoá thất bại! (" + ex.Message + "). Hãy kiểm tra lại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);

			}

		}

		private void btnSua_Click(object sender, EventArgs e)
		{
			try
			{
				int maLichThi = Convert.ToInt32(cmbMaLichThi.SelectedValue);
				int maSinhVien = Convert.ToInt32(txtMaSinhVien.Text);
				var lichthisinhvien = new LichThiSinhVien()
				{
					MaLichThi = maLichThi,
					MaSinhVien = maSinhVien
				};
				lichThiSinhVienDAL.UpdateLichThiSinhVien(lichthisinhvien);
				LoadData();
				MessageBox.Show("Sửa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

			}
			catch (Exception ex)
			{
				MessageBox.Show("Sửa thất bại! (" + ex.Message + "). Hãy kiểm tra lại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);

			}
		
		}

		private void btnClear_Click(object sender, EventArgs e)
		{
			ClearFields();
		}

		private void btnThoat_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void btnTimKiem_Click(object sender, EventArgs e)
		{
			if (!string.IsNullOrEmpty(txtTimKiem.Text))
			{
				int maSinhVien = int.Parse(txtTimKiem.Text);
				dgvLichThiSinhVien.DataSource = lichThiSinhVienDAL.GetLichThiSinhVienByMaSinhVien(maSinhVien);
			}
			else
			{
				MessageBox.Show("Vui lòng nhập mã sinh viên cần tìm kiếm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
		}

		private void ClearFields()
		{
			txtMaSinhVien.Clear();
		}

		private void dgvLichThiSinhVien_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			if (e.RowIndex >= 0)
			{
				DataGridViewRow row = dgvLichThiSinhVien.Rows[e.RowIndex];

				// Điền dữ liệu từ DataGridView vào các controls tương ứng
				cmbMaLichThi.SelectedValue = row.Cells["MaLichThi"].Value;
				txtMaSinhVien.Text = row.Cells["MaSinhVien"].Value.ToString();
			}
		}
	}
}
