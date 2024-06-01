using QuanLyPhongThi.DataAccessLayers;
using QuanLyPhongThi.Models;

namespace QuanLyPhongThi
{
	public partial class frmQuanLyPhongHoc : Form
	{
		private PhongHocDAL phongHocDAL = new PhongHocDAL();

		public frmQuanLyPhongHoc()
		{
			InitializeComponent();
			LoadData();
		}

		private void LoadData()
		{
			dgvPhongHoc.DataSource = phongHocDAL.GetAllPhongHoc();
		}

		/*private void dgvPhongHoc_SelectionChanged(object sender, EventArgs e)
		{
			if (dgvPhongHoc.SelectedRows.Count > 0)
			{
				DataGridViewRow row = dgvPhongHoc.SelectedRows[0];
				txtMaPhong.Text = row.Cells["MaPhong"].Value.ToString();
				txtTenPhong.Text = row.Cells["TenPhong"].Value.ToString();
				txtSucChua.Text = row.Cells["SucChua"].Value.ToString();
				txtTrangThietBi.Text = row.Cells["TrangThietBi"].Value.ToString();
				cmbTinhTrang.Text = row.Cells["TinhTrang"].Value.ToString();
			}
		}
*/
		private void btnThem_Click(object sender, EventArgs e)
		{
			try
			{
				PhongHoc phongHoc = new PhongHoc();
				phongHoc.TenPhong = txtTenPhong.Text;
				phongHoc.SucChua = int.Parse(txtSucChua.Text);
				phongHoc.TrangThietBi = txtTrangThietBi.Text;
				phongHoc.TinhTrang = cmbTinhTrang.Text;
				phongHocDAL.AddPhongHoc(phongHoc);
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
				PhongHoc phongHoc = new PhongHoc();
				phongHoc.MaPhong = int.Parse(txtMaPhong.Text);
				phongHoc.TenPhong = txtTenPhong.Text;
				phongHoc.SucChua = int.Parse(txtSucChua.Text);
				phongHoc.TrangThietBi = txtTrangThietBi.Text;
				phongHoc.TinhTrang = cmbTinhTrang.Text;

				phongHocDAL.UpdatePhongHoc(phongHoc);
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
			try {
				int maPhong = int.Parse(txtMaPhong.Text);
				phongHocDAL.DeletePhongHoc(maPhong);
				LoadData();
				btnClear_Click(sender, e);
				MessageBox.Show("Xoá thành công!", "OK", MessageBoxButtons.OK);

			}
			catch (Exception ex)
			{
				MessageBox.Show("Xảy ra lỗi khi xoá: ( " + ex.Message + "). Vui lòng kiểm tra lại.", "Error", MessageBoxButtons.OK);

			}

		}
		private void dgvPhongHoc_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			// Kiểm tra nếu người dùng nhấp vào một ô hợp lệ
			if (e.RowIndex >= 0)
			{
				// Lấy hàng được nhấp vào
				DataGridViewRow row = dgvPhongHoc.Rows[e.RowIndex];

				// Điền thông tin từ hàng vào các TextBox
				txtMaPhong.Text = row.Cells["MaPhong"].Value.ToString();
				txtTenPhong.Text = row.Cells["TenPhong"].Value.ToString();
				txtSucChua.Text = row.Cells["SucChua"].Value.ToString();
				txtTrangThietBi.Text = row.Cells["TrangThietBi"].Value.ToString();
				cmbTinhTrang.Text = row.Cells["TinhTrang"].Value.ToString();
			}
		}

		private void btnClear_Click(object sender, EventArgs e)
		{
			txtMaPhong.Clear();
			txtTenPhong.Clear();
			txtSucChua.Clear();
			txtTrangThietBi.Clear();
			cmbTinhTrang.Text = "";
		}

		private void btnThoat_Click(object sender, EventArgs e)
		{
			DialogResult result = MessageBox.Show("Bạn có muốn thoát?", "Exit", MessageBoxButtons.OKCancel);

			if (result == DialogResult.OK)
			{
				this.Close(); 
			}
		}
	}
}
