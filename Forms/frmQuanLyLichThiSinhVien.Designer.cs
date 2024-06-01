namespace QuanLyPhongThi
{
	partial class frmQuanLyLichThiSinhVien
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
			cmbMaLichThi = new ComboBox();
			label1 = new Label();
			dgvLichThiSinhVien = new DataGridView();
			btnThem = new Button();
			txtMaSinhVien = new TextBox();
			label2 = new Label();
			groupBox1 = new GroupBox();
			groupBox2 = new GroupBox();
			btnXoa = new Button();
			btnSua = new Button();
			btnClear = new Button();
			btnThoat = new Button();
			label3 = new Label();
			txtTimKiem = new TextBox();
			label4 = new Label();
			btnTimKiem = new Button();
			((System.ComponentModel.ISupportInitialize)dgvLichThiSinhVien).BeginInit();
			groupBox1.SuspendLayout();
			groupBox2.SuspendLayout();
			SuspendLayout();
			// 
			// cmbMaLichThi
			// 
			cmbMaLichThi.FormattingEnabled = true;
			cmbMaLichThi.Location = new Point(143, 55);
			cmbMaLichThi.Margin = new Padding(5, 6, 5, 6);
			cmbMaLichThi.Name = "cmbMaLichThi";
			cmbMaLichThi.Size = new Size(199, 33);
			cmbMaLichThi.TabIndex = 0;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(18, 55);
			label1.Margin = new Padding(5, 0, 5, 0);
			label1.Name = "label1";
			label1.Size = new Size(97, 25);
			label1.TabIndex = 1;
			label1.Text = "Mã lịch thi:";
			// 
			// dgvLichThiSinhVien
			// 
			dgvLichThiSinhVien.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dgvLichThiSinhVien.Dock = DockStyle.Fill;
			dgvLichThiSinhVien.Location = new Point(3, 27);
			dgvLichThiSinhVien.Margin = new Padding(5, 6, 5, 6);
			dgvLichThiSinhVien.Name = "dgvLichThiSinhVien";
			dgvLichThiSinhVien.RowHeadersWidth = 62;
			dgvLichThiSinhVien.Size = new Size(940, 319);
			dgvLichThiSinhVien.TabIndex = 2;
			dgvLichThiSinhVien.CellClick += dgvLichThiSinhVien_CellClick;
			// 
			// btnThem
			// 
			btnThem.Location = new Point(33, 599);
			btnThem.Margin = new Padding(5, 6, 5, 6);
			btnThem.Name = "btnThem";
			btnThem.Size = new Size(125, 44);
			btnThem.TabIndex = 3;
			btnThem.Text = "Thêm";
			btnThem.UseVisualStyleBackColor = true;
			btnThem.Click += btnThem_Click;
			// 
			// txtMaSinhVien
			// 
			txtMaSinhVien.Location = new Point(143, 101);
			txtMaSinhVien.Margin = new Padding(5, 6, 5, 6);
			txtMaSinhVien.Name = "txtMaSinhVien";
			txtMaSinhVien.Size = new Size(199, 31);
			txtMaSinhVien.TabIndex = 4;
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new Point(18, 104);
			label2.Margin = new Padding(5, 0, 5, 0);
			label2.Name = "label2";
			label2.Size = new Size(115, 25);
			label2.TabIndex = 5;
			label2.Text = "Mã sinh viên:";
			// 
			// groupBox1
			// 
			groupBox1.Controls.Add(dgvLichThiSinhVien);
			groupBox1.Location = new Point(30, 62);
			groupBox1.Name = "groupBox1";
			groupBox1.Size = new Size(946, 349);
			groupBox1.TabIndex = 6;
			groupBox1.TabStop = false;
			groupBox1.Text = "Lịch thi sinh viên";
			// 
			// groupBox2
			// 
			groupBox2.Controls.Add(label1);
			groupBox2.Controls.Add(cmbMaLichThi);
			groupBox2.Controls.Add(label2);
			groupBox2.Controls.Add(txtMaSinhVien);
			groupBox2.Location = new Point(33, 417);
			groupBox2.Name = "groupBox2";
			groupBox2.Size = new Size(452, 173);
			groupBox2.TabIndex = 7;
			groupBox2.TabStop = false;
			groupBox2.Text = "Chi tiết";
			// 
			// btnXoa
			// 
			btnXoa.Location = new Point(176, 599);
			btnXoa.Margin = new Padding(5, 6, 5, 6);
			btnXoa.Name = "btnXoa";
			btnXoa.Size = new Size(125, 44);
			btnXoa.TabIndex = 3;
			btnXoa.Text = "Xoá";
			btnXoa.UseVisualStyleBackColor = true;
			btnXoa.Click += btnXoa_Click;
			// 
			// btnSua
			// 
			btnSua.Location = new Point(322, 599);
			btnSua.Margin = new Padding(5, 6, 5, 6);
			btnSua.Name = "btnSua";
			btnSua.Size = new Size(125, 44);
			btnSua.TabIndex = 3;
			btnSua.Text = "Sửa";
			btnSua.UseVisualStyleBackColor = true;
			btnSua.Click += btnSua_Click;
			// 
			// btnClear
			// 
			btnClear.Location = new Point(705, 599);
			btnClear.Margin = new Padding(5, 6, 5, 6);
			btnClear.Name = "btnClear";
			btnClear.Size = new Size(125, 44);
			btnClear.TabIndex = 3;
			btnClear.Text = "Clear";
			btnClear.UseVisualStyleBackColor = true;
			btnClear.Click += btnClear_Click;
			// 
			// btnThoat
			// 
			btnThoat.Location = new Point(851, 599);
			btnThoat.Margin = new Padding(5, 6, 5, 6);
			btnThoat.Name = "btnThoat";
			btnThoat.Size = new Size(125, 44);
			btnThoat.TabIndex = 3;
			btnThoat.Text = "Thoát";
			btnThoat.UseVisualStyleBackColor = true;
			btnThoat.Click += btnThoat_Click;
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
			label3.Location = new Point(82, 11);
			label3.Margin = new Padding(5, 0, 5, 0);
			label3.Name = "label3";
			label3.Size = new Size(522, 48);
			label3.TabIndex = 1;
			label3.Text = "QUẢN LÝ LỊCH THI SINH VIÊN";
			// 
			// txtTimKiem
			// 
			txtTimKiem.Location = new Point(739, 22);
			txtTimKiem.Margin = new Padding(5, 6, 5, 6);
			txtTimKiem.Name = "txtTimKiem";
			txtTimKiem.Size = new Size(122, 31);
			txtTimKiem.TabIndex = 4;
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Location = new Point(614, 25);
			label4.Margin = new Padding(5, 0, 5, 0);
			label4.Name = "label4";
			label4.Size = new Size(115, 25);
			label4.TabIndex = 5;
			label4.Text = "Mã sinh viên:";
			// 
			// btnTimKiem
			// 
			btnTimKiem.Location = new Point(871, 21);
			btnTimKiem.Margin = new Padding(5, 6, 5, 6);
			btnTimKiem.Name = "btnTimKiem";
			btnTimKiem.Size = new Size(102, 32);
			btnTimKiem.TabIndex = 3;
			btnTimKiem.Text = "Tìm Kiếm";
			btnTimKiem.UseVisualStyleBackColor = true;
			btnTimKiem.Click += btnTimKiem_Click;
			// 
			// frmQuanLyLichThiSinhVien
			// 
			AutoScaleDimensions = new SizeF(10F, 25F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(1028, 649);
			Controls.Add(label3);
			Controls.Add(label4);
			Controls.Add(txtTimKiem);
			Controls.Add(groupBox2);
			Controls.Add(btnTimKiem);
			Controls.Add(groupBox1);
			Controls.Add(btnThoat);
			Controls.Add(btnClear);
			Controls.Add(btnSua);
			Controls.Add(btnXoa);
			Controls.Add(btnThem);
			Margin = new Padding(5, 6, 5, 6);
			Name = "frmQuanLyLichThiSinhVien";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "Quản Lý Lịch Thi Sinh Viên";
			Load += frmQuanLyLichThiSinhVien_Load;
			((System.ComponentModel.ISupportInitialize)dgvLichThiSinhVien).EndInit();
			groupBox1.ResumeLayout(false);
			groupBox2.ResumeLayout(false);
			groupBox2.PerformLayout();
			ResumeLayout(false);
			PerformLayout();
		}

		private System.Windows.Forms.ComboBox cmbMaLichThi;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.DataGridView dgvLichThiSinhVien;
		private System.Windows.Forms.Button btnThem;
		private System.Windows.Forms.TextBox txtMaSinhVien;
		private System.Windows.Forms.Label label2;
		private GroupBox groupBox1;
		private GroupBox groupBox2;
		private Button btnXoa;
		private Button btnSua;
		private Button btnClear;
		private Button btnThoat;
		private Label label3;
		private TextBox txtTimKiem;
		private Label label4;
		private Button btnTimKiem;
	}
}
