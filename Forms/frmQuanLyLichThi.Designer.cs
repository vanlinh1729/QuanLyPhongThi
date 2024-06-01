namespace QuanLyPhongThi
{
	partial class frmQuanLyLichThi
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
			dgvLichThi = new DataGridView();
			label1 = new Label();
			label2 = new Label();
			label3 = new Label();
			label4 = new Label();
			label5 = new Label();
			txtMaLichThi = new TextBox();
			cmbPhong = new ComboBox();
			cmbMonHoc = new ComboBox();
			dtpNgayThi = new DateTimePicker();
			dtpThoiGianBatDau = new DateTimePicker();
			dtpThoiGianKetThuc = new DateTimePicker();
			btnThem = new Button();
			btnSua = new Button();
			btnXoa = new Button();
			btnClear = new Button();
			btnThoat = new Button();
			groupBox1 = new GroupBox();
			label6 = new Label();
			txtTimKiem = new TextBox();
			btnTimKiem = new Button();
			groupBox3 = new GroupBox();
			label7 = new Label();
			label8 = new Label();
			((System.ComponentModel.ISupportInitialize)dgvLichThi).BeginInit();
			groupBox1.SuspendLayout();
			groupBox3.SuspendLayout();
			SuspendLayout();
			// 
			// dgvLichThi
			// 
			dgvLichThi.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dgvLichThi.Dock = DockStyle.Fill;
			dgvLichThi.Location = new Point(3, 28);
			dgvLichThi.Margin = new Padding(3, 4, 3, 4);
			dgvLichThi.Name = "dgvLichThi";
			dgvLichThi.RowHeadersWidth = 62;
			dgvLichThi.RowTemplate.Height = 28;
			dgvLichThi.Size = new Size(1176, 377);
			dgvLichThi.TabIndex = 0;
			dgvLichThi.CellClick += dgvLichThi_CellClick;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(131, 51);
			label1.Name = "label1";
			label1.Size = new Size(100, 25);
			label1.TabIndex = 1;
			label1.Text = "Mã Lịch Thi";
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new Point(131, 101);
			label2.Name = "label2";
			label2.Size = new Size(92, 25);
			label2.TabIndex = 2;
			label2.Text = "Phòng Thi";
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Location = new Point(131, 151);
			label3.Name = "label3";
			label3.Size = new Size(86, 25);
			label3.TabIndex = 3;
			label3.Text = "Môn Học";
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Location = new Point(592, 51);
			label4.Name = "label4";
			label4.Size = new Size(82, 25);
			label4.TabIndex = 4;
			label4.Text = "Ngày Thi";
			// 
			// label5
			// 
			label5.AutoSize = true;
			label5.Location = new Point(592, 101);
			label5.Name = "label5";
			label5.Size = new Size(153, 25);
			label5.TabIndex = 5;
			label5.Text = "Thời Gian Bắt Đầu";
			// 
			// txtMaLichThi
			// 
			txtMaLichThi.Location = new Point(281, 51);
			txtMaLichThi.Margin = new Padding(3, 4, 3, 4);
			txtMaLichThi.Name = "txtMaLichThi";
			txtMaLichThi.Size = new Size(222, 31);
			txtMaLichThi.TabIndex = 6;
			// 
			// cmbPhong
			// 
			cmbPhong.DropDownStyle = ComboBoxStyle.DropDownList;
			cmbPhong.FormattingEnabled = true;
			cmbPhong.Location = new Point(281, 101);
			cmbPhong.Margin = new Padding(3, 4, 3, 4);
			cmbPhong.Name = "cmbPhong";
			cmbPhong.Size = new Size(222, 33);
			cmbPhong.TabIndex = 7;
			// 
			// cmbMonHoc
			// 
			cmbMonHoc.DropDownStyle = ComboBoxStyle.DropDownList;
			cmbMonHoc.FormattingEnabled = true;
			cmbMonHoc.Location = new Point(281, 151);
			cmbMonHoc.Margin = new Padding(3, 4, 3, 4);
			cmbMonHoc.Name = "cmbMonHoc";
			cmbMonHoc.Size = new Size(222, 33);
			cmbMonHoc.TabIndex = 8;
			// 
			// dtpNgayThi
			// 
			dtpNgayThi.Format = DateTimePickerFormat.Short;
			dtpNgayThi.Location = new Point(742, 51);
			dtpNgayThi.Margin = new Padding(3, 4, 3, 4);
			dtpNgayThi.Name = "dtpNgayThi";
			dtpNgayThi.Size = new Size(222, 31);
			dtpNgayThi.TabIndex = 9;
			// 
			// dtpThoiGianBatDau
			// 
			dtpThoiGianBatDau.Format = DateTimePickerFormat.Time;
			dtpThoiGianBatDau.Location = new Point(742, 101);
			dtpThoiGianBatDau.Margin = new Padding(3, 4, 3, 4);
			dtpThoiGianBatDau.Name = "dtpThoiGianBatDau";
			dtpThoiGianBatDau.ShowUpDown = true;
			dtpThoiGianBatDau.Size = new Size(222, 31);
			dtpThoiGianBatDau.TabIndex = 10;
			// 
			// dtpThoiGianKetThuc
			// 
			dtpThoiGianKetThuc.Format = DateTimePickerFormat.Time;
			dtpThoiGianKetThuc.Location = new Point(742, 151);
			dtpThoiGianKetThuc.Margin = new Padding(3, 4, 3, 4);
			dtpThoiGianKetThuc.Name = "dtpThoiGianKetThuc";
			dtpThoiGianKetThuc.ShowUpDown = true;
			dtpThoiGianKetThuc.Size = new Size(222, 31);
			dtpThoiGianKetThuc.TabIndex = 11;
			// 
			// btnThem
			// 
			btnThem.Location = new Point(38, 745);
			btnThem.Margin = new Padding(3, 4, 3, 4);
			btnThem.Name = "btnThem";
			btnThem.Size = new Size(111, 50);
			btnThem.TabIndex = 12;
			btnThem.Text = "Thêm";
			btnThem.UseVisualStyleBackColor = true;
			btnThem.Click += btnThem_Click;
			// 
			// btnSua
			// 
			btnSua.Location = new Point(169, 745);
			btnSua.Margin = new Padding(3, 4, 3, 4);
			btnSua.Name = "btnSua";
			btnSua.Size = new Size(111, 50);
			btnSua.TabIndex = 13;
			btnSua.Text = "Sửa";
			btnSua.UseVisualStyleBackColor = true;
			btnSua.Click += btnSua_Click;
			// 
			// btnXoa
			// 
			btnXoa.Location = new Point(299, 745);
			btnXoa.Margin = new Padding(3, 4, 3, 4);
			btnXoa.Name = "btnXoa";
			btnXoa.Size = new Size(111, 50);
			btnXoa.TabIndex = 14;
			btnXoa.Text = "Xóa";
			btnXoa.UseVisualStyleBackColor = true;
			btnXoa.Click += btnXoa_Click;
			// 
			// btnClear
			// 
			btnClear.Location = new Point(954, 745);
			btnClear.Margin = new Padding(3, 4, 3, 4);
			btnClear.Name = "btnClear";
			btnClear.Size = new Size(111, 50);
			btnClear.TabIndex = 15;
			btnClear.Text = "Clear";
			btnClear.UseVisualStyleBackColor = true;
			btnClear.Click += btnClear_Click;
			// 
			// btnThoat
			// 
			btnThoat.Location = new Point(1093, 745);
			btnThoat.Margin = new Padding(3, 4, 3, 4);
			btnThoat.Name = "btnThoat";
			btnThoat.Size = new Size(111, 50);
			btnThoat.TabIndex = 16;
			btnThoat.Text = "Thoát";
			btnThoat.UseVisualStyleBackColor = true;
			btnThoat.Click += btnThoat_Click;
			// 
			// groupBox1
			// 
			groupBox1.Controls.Add(dgvLichThi);
			groupBox1.Location = new Point(33, 86);
			groupBox1.Margin = new Padding(3, 4, 3, 4);
			groupBox1.Name = "groupBox1";
			groupBox1.Padding = new Padding(3, 4, 3, 4);
			groupBox1.Size = new Size(1182, 409);
			groupBox1.TabIndex = 17;
			groupBox1.TabStop = false;
			groupBox1.Text = "Danh Sách Lịch Thi";
			// 
			// label6
			// 
			label6.AutoSize = true;
			label6.Location = new Point(847, 66);
			label6.Name = "label6";
			label6.Size = new Size(85, 25);
			label6.TabIndex = 0;
			label6.Text = "Tìm Kiếm";
			// 
			// txtTimKiem
			// 
			txtTimKiem.Location = new Point(938, 63);
			txtTimKiem.Margin = new Padding(3, 4, 3, 4);
			txtTimKiem.Name = "txtTimKiem";
			txtTimKiem.Size = new Size(143, 31);
			txtTimKiem.TabIndex = 1;
			// 
			// btnTimKiem
			// 
			btnTimKiem.Location = new Point(1101, 59);
			btnTimKiem.Margin = new Padding(3, 4, 3, 4);
			btnTimKiem.Name = "btnTimKiem";
			btnTimKiem.Size = new Size(111, 38);
			btnTimKiem.TabIndex = 2;
			btnTimKiem.Text = "Tìm Kiếm";
			btnTimKiem.UseVisualStyleBackColor = true;
			btnTimKiem.Click += btnTimKiem_Click;
			// 
			// groupBox3
			// 
			groupBox3.Controls.Add(label1);
			groupBox3.Controls.Add(label2);
			groupBox3.Controls.Add(label3);
			groupBox3.Controls.Add(label4);
			groupBox3.Controls.Add(label7);
			groupBox3.Controls.Add(label5);
			groupBox3.Controls.Add(txtMaLichThi);
			groupBox3.Controls.Add(cmbPhong);
			groupBox3.Controls.Add(cmbMonHoc);
			groupBox3.Controls.Add(dtpThoiGianKetThuc);
			groupBox3.Controls.Add(dtpNgayThi);
			groupBox3.Controls.Add(dtpThoiGianBatDau);
			groupBox3.Location = new Point(33, 502);
			groupBox3.Name = "groupBox3";
			groupBox3.Size = new Size(1182, 214);
			groupBox3.TabIndex = 19;
			groupBox3.TabStop = false;
			groupBox3.Text = "Thông tin chi tiết";
			// 
			// label7
			// 
			label7.AutoSize = true;
			label7.Location = new Point(592, 151);
			label7.Name = "label7";
			label7.Size = new Size(158, 25);
			label7.TabIndex = 5;
			label7.Text = "Thời Gian Kết Thúc";
			// 
			// label8
			// 
			label8.AutoSize = true;
			label8.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
			label8.Location = new Point(416, 23);
			label8.Name = "label8";
			label8.Size = new Size(333, 48);
			label8.TabIndex = 1;
			label8.Text = "QUẢN LÝ LỊCH THI";
			// 
			// frmQuanLyLichThi
			// 
			AutoScaleDimensions = new SizeF(10F, 25F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(1239, 820);
			Controls.Add(label6);
			Controls.Add(txtTimKiem);
			Controls.Add(label8);
			Controls.Add(btnTimKiem);
			Controls.Add(groupBox3);
			Controls.Add(groupBox1);
			Controls.Add(btnThoat);
			Controls.Add(btnClear);
			Controls.Add(btnXoa);
			Controls.Add(btnSua);
			Controls.Add(btnThem);
			Margin = new Padding(3, 4, 3, 4);
			Name = "frmQuanLyLichThi";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "Quản Lý Lịch Thi";
			Load += frmQuanLyLichThi_Load;
			((System.ComponentModel.ISupportInitialize)dgvLichThi).EndInit();
			groupBox1.ResumeLayout(false);
			groupBox3.ResumeLayout(false);
			groupBox3.PerformLayout();
			ResumeLayout(false);
			PerformLayout();
		}

		private System.Windows.Forms.DataGridView dgvLichThi;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox txtMaLichThi;
		private System.Windows.Forms.ComboBox cmbPhong;
		private System.Windows.Forms.ComboBox cmbMonHoc;
		private System.Windows.Forms.DateTimePicker dtpNgayThi;
		private System.Windows.Forms.DateTimePicker dtpThoiGianBatDau;
		private System.Windows.Forms.DateTimePicker dtpThoiGianKetThuc;
		private System.Windows.Forms.Button btnThem;
		private System.Windows.Forms.Button btnSua;
		private System.Windows.Forms.Button btnXoa;
		private System.Windows.Forms.Button btnClear;
		private System.Windows.Forms.Button btnThoat;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox txtTimKiem;
		private System.Windows.Forms.Button btnTimKiem;
		private GroupBox groupBox3;
		private Label label7;
		private Label label8;
	}
}

