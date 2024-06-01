using QuanLyPhongThi.DataAccessLayers;
using QuanLyPhongThi.Models;
using System;
using System.Data;
using System.Windows.Forms;

namespace QuanLyPhongThi
{
	public partial class frmQuanLyMonHoc : Form
	{
		private MonHocDAL monHocDAL = new MonHocDAL();

		public frmQuanLyMonHoc()
		{
			InitializeComponent();
			LoadData();
		}

		private void LoadData()
		{
			dgvMonHoc.DataSource = monHocDAL.GetAllMonHoc();
		}

		private void btnThem_Click(object sender, EventArgs e)
		{
			try
			{
				MonHoc monHoc = new MonHoc();
				monHoc.MaMonHoc = int.Parse(txtMaMonHoc.Text);
				monHoc.TenMonHoc = txtTenMonHoc.Text;
				monHoc.SoTinChi = int.Parse(txtSoTinChi.Text);

				monHocDAL.AddMonHoc(monHoc);
				LoadData();
				btnClear_Click(sender, e);
				MessageBox.Show("Thêm môn học thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
			catch (Exception ex)
			{
				MessageBox.Show("Lỗi khi thêm môn học: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void btnSua_Click(object sender, EventArgs e)
		{
			try
			{
				MonHoc monHoc = new MonHoc();
				monHoc.MaMonHoc = int.Parse(txtMaMonHoc.Text);
				monHoc.TenMonHoc = txtTenMonHoc.Text;
				monHoc.SoTinChi = int.Parse(txtSoTinChi.Text);

				monHocDAL.UpdateMonHoc(monHoc);
				LoadData();
				btnClear_Click(sender, e);
				MessageBox.Show("Sửa môn học thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
			catch (Exception ex)
			{
				MessageBox.Show("Lỗi khi sửa môn học: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void btnXoa_Click(object sender, EventArgs e)
		{
			try
			{
				int maMonHoc = int.Parse(txtMaMonHoc.Text);
				monHocDAL.DeleteMonHoc(maMonHoc);
				LoadData();
				btnClear_Click(sender, e);
				MessageBox.Show("Xoá môn học thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
			catch (Exception ex)
			{
				MessageBox.Show("Lỗi khi xoá môn học: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void btnTimKiem_Click(object sender, EventArgs e)
		{
			if (!string.IsNullOrEmpty(txtTimKiem.Text))
			{
				int maMonHoc = int.Parse(txtTimKiem.Text);
				dgvMonHoc.DataSource = monHocDAL.TimKiemMonHoc(maMonHoc);
			}
			else
			{
				MessageBox.Show("Vui lòng nhập mã môn học cần tìm kiếm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
		}

		private void dgvMonHoc_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			if (e.RowIndex >= 0)
			{
				DataGridViewRow row = dgvMonHoc.Rows[e.RowIndex];
				txtMaMonHoc.Text = row.Cells["MaMonHoc"].Value.ToString();
				txtTenMonHoc.Text = row.Cells["TenMonHoc"].Value.ToString();
				txtSoTinChi.Text = row.Cells["SoTinChi"].Value.ToString();
				txtMaMonHoc.Enabled = false;

			}
		}

		private void btnClear_Click(object sender, EventArgs e)
		{
			txtMaMonHoc.Clear();
			txtTenMonHoc.Clear();
			txtSoTinChi.Clear();
			LoadData();
			txtMaMonHoc.Enabled = true;
		}

		private void btnThoat_Click(object sender, EventArgs e)
		{
			DialogResult result = MessageBox.Show("Bạn có muốn thoát?", "Thoát", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
			if (result == DialogResult.OK)
			{
				this.Close();
			}
		}
	}
}
