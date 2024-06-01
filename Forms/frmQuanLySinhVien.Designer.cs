namespace QuanLyPhongThi
{
	partial class frmQuanLySinhVien
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
			dgvSinhVien = new DataGridView();
			label1 = new Label();
			label2 = new Label();
			label3 = new Label();
			label4 = new Label();
			txtMaSinhVien = new TextBox();
			txtHoTen = new TextBox();
			dtpNgaySinh = new DateTimePicker();
			txtLop = new TextBox();
			btnThem = new Button();
			btnSua = new Button();
			btnXoa = new Button();
			btnClear = new Button();
			btnThoat = new Button();
			groupBox1 = new GroupBox();
			groupBox2 = new GroupBox();
			label5 = new Label();
			txtTimKiem = new TextBox();
			btnTimKiem = new Button();
			((System.ComponentModel.ISupportInitialize)dgvSinhVien).BeginInit();
			groupBox1.SuspendLayout();
			groupBox2.SuspendLayout();
			SuspendLayout();
			// 
			// dgvSinhVien
			// 
			dgvSinhVien.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dgvSinhVien.Dock = DockStyle.Fill;
			dgvSinhVien.Location = new Point(3, 27);
			dgvSinhVien.Margin = new Padding(3, 4, 3, 4);
			dgvSinhVien.Name = "dgvSinhVien";
			dgvSinhVien.RowHeadersWidth = 62;
			dgvSinhVien.RowTemplate.Height = 28;
			dgvSinhVien.Size = new Size(980, 282);
			dgvSinhVien.TabIndex = 0;
			dgvSinhVien.CellClick += dgvSinhVien_CellClick;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(48, 57);
			label1.Name = "label1";
			label1.Size = new Size(119, 25);
			label1.TabIndex = 1;
			label1.Text = "Mã Sinh Viên:";
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new Point(511, 59);
			label2.Name = "label2";
			label2.Size = new Size(71, 25);
			label2.TabIndex = 1;
			label2.Text = "Họ Tên:";
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Location = new Point(48, 121);
			label3.Name = "label3";
			label3.Size = new Size(97, 25);
			label3.TabIndex = 1;
			label3.Text = "Ngày Sinh:";
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Location = new Point(511, 121);
			label4.Name = "label4";
			label4.Size = new Size(46, 25);
			label4.TabIndex = 1;
			label4.Text = "Lớp:";
			// 
			// txtMaSinhVien
			// 
			txtMaSinhVien.Location = new Point(215, 53);
			txtMaSinhVien.Margin = new Padding(3, 4, 3, 4);
			txtMaSinhVien.Name = "txtMaSinhVien";
			txtMaSinhVien.Size = new Size(211, 31);
			txtMaSinhVien.TabIndex = 2;
			txtMaSinhVien.KeyPress += txtMaSinhVien_KeyPress;
			// 
			// txtHoTen
			// 
			txtHoTen.Location = new Point(678, 55);
			txtHoTen.Margin = new Padding(3, 4, 3, 4);
			txtHoTen.Name = "txtHoTen";
			txtHoTen.Size = new Size(211, 31);
			txtHoTen.TabIndex = 2;
			// 
			// dtpNgaySinh
			// 
			dtpNgaySinh.Location = new Point(215, 116);
			dtpNgaySinh.Margin = new Padding(3, 4, 3, 4);
			dtpNgaySinh.Name = "dtpNgaySinh";
			dtpNgaySinh.Size = new Size(211, 31);
			dtpNgaySinh.TabIndex = 3;
			// 
			// txtLop
			// 
			txtLop.Location = new Point(678, 117);
			txtLop.Margin = new Padding(3, 4, 3, 4);
			txtLop.Name = "txtLop";
			txtLop.Size = new Size(211, 31);
			txtLop.TabIndex = 2;
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
			groupBox1.Controls.Add(dgvSinhVien);
			groupBox1.Location = new Point(32, 64);
			groupBox1.Name = "groupBox1";
			groupBox1.Size = new Size(986, 312);
			groupBox1.TabIndex = 5;
			groupBox1.TabStop = false;
			groupBox1.Text = "Danh sách sinh viên";
			// 
			// groupBox2
			// 
			groupBox2.Controls.Add(label1);
			groupBox2.Controls.Add(label2);
			groupBox2.Controls.Add(label3);
			groupBox2.Controls.Add(label4);
			groupBox2.Controls.Add(txtMaSinhVien);
			groupBox2.Controls.Add(txtHoTen);
			groupBox2.Controls.Add(dtpNgaySinh);
			groupBox2.Controls.Add(txtLop);
			groupBox2.Location = new Point(32, 382);
			groupBox2.Name = "groupBox2";
			groupBox2.Size = new Size(986, 198);
			groupBox2.TabIndex = 6;
			groupBox2.TabStop = false;
			groupBox2.Text = "Thông tin chi tiết";
			// 
			// label5
			// 
			label5.AutoSize = true;
			label5.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
			label5.Location = new Point(283, 26);
			label5.Name = "label5";
			label5.Size = new Size(363, 48);
			label5.TabIndex = 7;
			label5.Text = "QUẢN LÝ SINH VIÊN";
			// 
			// txtTimKiem
			// 
			txtTimKiem.Location = new Point(750, 45);
			txtTimKiem.Margin = new Padding(3, 4, 3, 4);
			txtTimKiem.Name = "txtTimKiem";
			txtTimKiem.Size = new Size(155, 31);
			txtTimKiem.TabIndex = 8;
			// 
			// btnTimKiem
			// 
			btnTimKiem.Location = new Point(911, 43);
			btnTimKiem.Margin = new Padding(3, 4, 3, 4);
			btnTimKiem.Name = "btnTimKiem";
			btnTimKiem.Size = new Size(100, 34);
			btnTimKiem.TabIndex = 9;
			btnTimKiem.Text = "Tìm Kiếm";
			btnTimKiem.UseVisualStyleBackColor = true;
			btnTimKiem.Click += btnTimKiem_Click;
			// 
			// frmQuanLySinhVien
			// 
			AutoScaleDimensions = new SizeF(10F, 25F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(1060, 658);
			Controls.Add(txtTimKiem);
			Controls.Add(btnTimKiem);
			Controls.Add(label5);
			Controls.Add(groupBox2);
			Controls.Add(groupBox1);
			Controls.Add(btnThoat);
			Controls.Add(btnThem);
			Controls.Add(btnSua);
			Controls.Add(btnClear);
			Controls.Add(btnXoa);
			Margin = new Padding(3, 4, 3, 4);
			Name = "frmQuanLySinhVien";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "Quản Lý Sinh Viên";
			((System.ComponentModel.ISupportInitialize)dgvSinhVien).EndInit();
			groupBox1.ResumeLayout(false);
			groupBox2.ResumeLayout(false);
			groupBox2.PerformLayout();
			ResumeLayout(false);
			PerformLayout();
		}

		private System.Windows.Forms.DataGridView dgvSinhVien;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox txtMaSinhVien;
		private System.Windows.Forms.TextBox txtHoTen;
		private System.Windows.Forms.DateTimePicker dtpNgaySinh;
		private System.Windows.Forms.TextBox txtLop;
		private System.Windows.Forms.Button btnThem;
		private System.Windows.Forms.Button btnSua;
		private System.Windows.Forms.Button btnXoa;
		private System.Windows.Forms.Button btnClear;
		private System.Windows.Forms.Button btnThoat;
		private GroupBox groupBox1;
		private GroupBox groupBox2;
		private Label label5;
		private TextBox txtTimKiem; 
		private Button btnTimKiem; // Thêm Button tìm kiếm
	}
}

