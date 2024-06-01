namespace QuanLyPhongThi
{
	partial class frmQuanLyMonHoc
	{
		private System.ComponentModel.IContainer components = null;

		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		private void InitializeComponent()
		{
			dgvMonHoc = new DataGridView();
			label1 = new Label();
			label2 = new Label();
			txtMaMonHoc = new TextBox();
			txtTenMonHoc = new TextBox();
			btnThem = new Button();
			btnSua = new Button();
			btnXoa = new Button();
			btnClear = new Button();
			btnThoat = new Button();
			groupBox1 = new GroupBox();
			groupBox2 = new GroupBox();
			txtSoTinChi = new TextBox();
			label4 = new Label();
			label3 = new Label();
			txtTimKiem = new TextBox();
			btnTimKiem = new Button();
			label5 = new Label();
			((System.ComponentModel.ISupportInitialize)dgvMonHoc).BeginInit();
			groupBox1.SuspendLayout();
			groupBox2.SuspendLayout();
			SuspendLayout();
			// 
			// dgvMonHoc
			// 
			dgvMonHoc.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dgvMonHoc.Dock = DockStyle.Fill;
			dgvMonHoc.Location = new Point(3, 27);
			dgvMonHoc.Margin = new Padding(3, 4, 3, 4);
			dgvMonHoc.Name = "dgvMonHoc";
			dgvMonHoc.RowHeadersWidth = 62;
			dgvMonHoc.RowTemplate.Height = 28;
			dgvMonHoc.Size = new Size(980, 282);
			dgvMonHoc.TabIndex = 0;
			dgvMonHoc.CellClick += dgvMonHoc_CellClick;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(48, 57);
			label1.Name = "label1";
			label1.Size = new Size(120, 25);
			label1.TabIndex = 1;
			label1.Text = "Mã Môn Học:";
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new Point(48, 121);
			label2.Name = "label2";
			label2.Size = new Size(121, 25);
			label2.TabIndex = 1;
			label2.Text = "Tên Môn Học:";
			// 
			// txtMaMonHoc
			// 
			txtMaMonHoc.Location = new Point(215, 53);
			txtMaMonHoc.Margin = new Padding(3, 4, 3, 4);
			txtMaMonHoc.Name = "txtMaMonHoc";
			txtMaMonHoc.Size = new Size(211, 31);
			txtMaMonHoc.TabIndex = 2;
			// 
			// txtTenMonHoc
			// 
			txtTenMonHoc.Location = new Point(215, 117);
			txtTenMonHoc.Margin = new Padding(3, 4, 3, 4);
			txtTenMonHoc.Name = "txtTenMonHoc";
			txtTenMonHoc.Size = new Size(211, 31);
			txtTenMonHoc.TabIndex = 2;
			// 
			// btnThem
			// 
			btnThem.Location = new Point(38, 611);
			btnThem.Margin = new Padding(3, 4, 3, 4);
			btnThem.Name = "btnThem";
			btnThem.Size = new Size(91, 34);
			btnThem.TabIndex = 4;
			btnThem.Text = "Thêm";
			btnThem.UseVisualStyleBackColor = true;
			btnThem.Click += btnThem_Click;
			// 
			// btnSua
			// 
			btnSua.Location = new Point(153, 611);
			btnSua.Margin = new Padding(3, 4, 3, 4);
			btnSua.Name = "btnSua";
			btnSua.Size = new Size(91, 34);
			btnSua.TabIndex = 4;
			btnSua.Text = "Sửa";
			btnSua.UseVisualStyleBackColor = true;
			btnSua.Click += btnSua_Click;
			// 
			// btnXoa
			// 
			btnXoa.Location = new Point(262, 611);
			btnXoa.Margin = new Padding(3, 4, 3, 4);
			btnXoa.Name = "btnXoa";
			btnXoa.Size = new Size(91, 34);
			btnXoa.TabIndex = 4;
			btnXoa.Text = "Xoá";
			btnXoa.UseVisualStyleBackColor = true;
			btnXoa.Click += btnXoa_Click;
			// 
			// btnClear
			// 
			btnClear.Location = new Point(821, 611);
			btnClear.Margin = new Padding(3, 4, 3, 4);
			btnClear.Name = "btnClear";
			btnClear.Size = new Size(91, 34);
			btnClear.TabIndex = 4;
			btnClear.Text = "Clear";
			btnClear.UseVisualStyleBackColor = true;
			btnClear.Click += btnClear_Click;
			// 
			// btnThoat
			// 
			btnThoat.Location = new Point(918, 611);
			btnThoat.Margin = new Padding(3, 4, 3, 4);
			btnThoat.Name = "btnThoat";
			btnThoat.Size = new Size(100, 34);
			btnThoat.TabIndex = 4;
			btnThoat.Text = "Thoát";
			btnThoat.UseVisualStyleBackColor = true;
			btnThoat.Click += btnThoat_Click;
			// 
			// groupBox1
			// 
			groupBox1.Controls.Add(dgvMonHoc);
			groupBox1.Location = new Point(32, 64);
			groupBox1.Name = "groupBox1";
			groupBox1.Size = new Size(986, 312);
			groupBox1.TabIndex = 5;
			groupBox1.TabStop = false;
			groupBox1.Text = "Danh sách môn học";
			// 
			// groupBox2
			// 
			groupBox2.Controls.Add(txtSoTinChi);
			groupBox2.Controls.Add(txtTenMonHoc);
			groupBox2.Controls.Add(label4);
			groupBox2.Controls.Add(txtMaMonHoc);
			groupBox2.Controls.Add(label2);
			groupBox2.Controls.Add(label1);
			groupBox2.Location = new Point(32, 382);
			groupBox2.Name = "groupBox2";
			groupBox2.Size = new Size(986, 198);
			groupBox2.TabIndex = 6;
			groupBox2.TabStop = false;
			groupBox2.Text = "Thông tin chi tiết";
			// 
			// txtSoTinChi
			// 
			txtSoTinChi.Location = new Point(636, 57);
			txtSoTinChi.Margin = new Padding(3, 4, 3, 4);
			txtSoTinChi.Name = "txtSoTinChi";
			txtSoTinChi.Size = new Size(211, 31);
			txtSoTinChi.TabIndex = 2;
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Location = new Point(469, 61);
			label4.Name = "label4";
			label4.Size = new Size(89, 25);
			label4.TabIndex = 1;
			label4.Text = "Số tín chỉ:";
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Location = new Point(649, 37);
			label3.Name = "label3";
			label3.Size = new Size(118, 25);
			label3.TabIndex = 1;
			label3.Text = "Tìm kiếm Mã:";
			// 
			// txtTimKiem
			// 
			txtTimKiem.Location = new Point(773, 34);
			txtTimKiem.Margin = new Padding(3, 4, 3, 4);
			txtTimKiem.Name = "txtTimKiem";
			txtTimKiem.Size = new Size(129, 31);
			txtTimKiem.TabIndex = 7;
			// 
			// btnTimKiem
			// 
			btnTimKiem.Location = new Point(908, 32);
			btnTimKiem.Margin = new Padding(3, 4, 3, 4);
			btnTimKiem.Name = "btnTimKiem";
			btnTimKiem.Size = new Size(100, 34);
			btnTimKiem.TabIndex = 8;
			btnTimKiem.Text = "Tìm Kiếm";
			btnTimKiem.UseVisualStyleBackColor = true;
			btnTimKiem.Click += btnTimKiem_Click;
			// 
			// label5
			// 
			label5.AutoSize = true;
			label5.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
			label5.Location = new Point(262, 13);
			label5.Name = "label5";
			label5.Size = new Size(360, 48);
			label5.TabIndex = 9;
			label5.Text = "QUẢN LÝ MÔN HỌC";
			// 
			// frmQuanLyMonHoc
			// 
			AutoScaleDimensions = new SizeF(10F, 25F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(1060, 658);
			Controls.Add(label5);
			Controls.Add(btnTimKiem);
			Controls.Add(txtTimKiem);
			Controls.Add(label3);
			Controls.Add(groupBox2);
			Controls.Add(groupBox1);
			Controls.Add(btnThoat);
			Controls.Add(btnThem);
			Controls.Add(btnSua);
			Controls.Add(btnClear);
			Controls.Add(btnXoa);
			Margin = new Padding(3, 4, 3, 4);
			Name = "frmQuanLyMonHoc";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "Quản Lý Môn Học";
			((System.ComponentModel.ISupportInitialize)dgvMonHoc).EndInit();
			groupBox1.ResumeLayout(false);
			groupBox2.ResumeLayout(false);
			groupBox2.PerformLayout();
			ResumeLayout(false);
			PerformLayout();
		}

		private System.Windows.Forms.DataGridView dgvMonHoc;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtMaMonHoc;
		private System.Windows.Forms.TextBox txtTenMonHoc;
		private System.Windows.Forms.Button btnThem;
		private System.Windows.Forms.Button btnSua;
		private System.Windows.Forms.Button btnXoa;
		private System.Windows.Forms.Button btnClear;
		private System.Windows.Forms.Button btnThoat;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txtTimKiem;
		private System.Windows.Forms.Button btnTimKiem;
		private TextBox txtSoTinChi;
		private Label label4;
		private Label label5;
	}
}

