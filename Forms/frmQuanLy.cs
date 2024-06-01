using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyPhongThi.Forms
{
	public partial class frmQuanLy : Form
	{
		public frmQuanLy()
		{
			InitializeComponent();
		}

		private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
		{
			DialogResult result = MessageBox.Show("Bạn có muốn thoát ứng dụng?", "Exit", MessageBoxButtons.OKCancel);

			if (result == DialogResult.OK)
			{
				Application.Exit();
			}
		}

		private void toolStripMenuItem1_Click(object sender, EventArgs e)
		{
			frmQuanLyPhongHoc frmQuanLyPhongHoc = new frmQuanLyPhongHoc();
			frmQuanLyPhongHoc.MdiParent = this;
			frmQuanLyPhongHoc.Show();
		}

		private void frmQuanLy_Load(object sender, EventArgs e)
		{
			this.IsMdiContainer = true;
			this.WindowState = FormWindowState.Maximized;
		}

		private void sinhViênToolStripMenuItem_Click(object sender, EventArgs e)
		{
			frmQuanLySinhVien frmQuanLySinhVien = new frmQuanLySinhVien();
			frmQuanLySinhVien.MdiParent = this;
			frmQuanLySinhVien.Show();
		}

		private void mônHọcToolStripMenuItem_Click(object sender, EventArgs e)
		{
			frmQuanLyMonHoc frmQuanLyMonHoc = new frmQuanLyMonHoc();
			frmQuanLyMonHoc.MdiParent = this;
			frmQuanLyMonHoc.Show();
		}

		private void lịchThiToolStripMenuItem_Click(object sender, EventArgs e)
		{
			frmQuanLyLichThi frmQuanLyLichThi = new frmQuanLyLichThi();
			frmQuanLyLichThi.MdiParent = this;
			frmQuanLyLichThi.Show();
		}

		private void lịchThiSinhViênToolStripMenuItem_Click(object sender, EventArgs e)
		{
			frmQuanLyLichThiSinhVien frmQuanLyLichThiSinhVien = new frmQuanLyLichThiSinhVien();
			frmQuanLyLichThiSinhVien.MdiParent = this;
			frmQuanLyLichThiSinhVien.Show();
		}

		private void lịchThiToolStripMenuItem2_Click(object sender, EventArgs e)
		{
			frmQuanLyLichThi frmQuanLyLichThi = new frmQuanLyLichThi();
			frmQuanLyLichThi.MdiParent = this;
			frmQuanLyLichThi.Show();
		}

		private void lịchThiSinhViênToolStripMenuItem1_Click(object sender, EventArgs e)
		{
			frmQuanLyLichThiSinhVien frmQuanLyLichThiSinhVien = new frmQuanLyLichThiSinhVien();
			frmQuanLyLichThiSinhVien.MdiParent = this;
			frmQuanLyLichThiSinhVien.Show();
		}
	}
}
