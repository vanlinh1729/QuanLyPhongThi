namespace QuanLyPhongThi
{
	partial class frmQuanLyPhongHoc
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			dgvPhongHoc = new DataGridView();
			txtTrangThietBi = new TextBox();
			btnThem = new Button();
			label1 = new Label();
			txtMaPhong = new TextBox();
			label2 = new Label();
			btnSua = new Button();
			btnXoa = new Button();
			txtTenPhong = new TextBox();
			label3 = new Label();
			label4 = new Label();
			txtSucChua = new TextBox();
			label5 = new Label();
			groupBox1 = new GroupBox();
			groupBox2 = new GroupBox();
			cmbTinhTrang = new ComboBox();
			label6 = new Label();
			btnClear = new Button();
			btnThoat = new Button();
			((System.ComponentModel.ISupportInitialize)dgvPhongHoc).BeginInit();
			groupBox1.SuspendLayout();
			groupBox2.SuspendLayout();
			SuspendLayout();
			// 
			// dgvPhongHoc
			// 
			dgvPhongHoc.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dgvPhongHoc.Location = new Point(23, 30);
			dgvPhongHoc.Name = "dgvPhongHoc";
			dgvPhongHoc.RowHeadersWidth = 62;
			dgvPhongHoc.Size = new Size(794, 285);
			dgvPhongHoc.TabIndex = 0;
			dgvPhongHoc.CellClick += dgvPhongHoc_CellClick;
			// 
			// txtTrangThietBi
			// 
			txtTrangThietBi.Location = new Point(135, 102);
			txtTrangThietBi.Name = "txtTrangThietBi";
			txtTrangThietBi.Size = new Size(150, 31);
			txtTrangThietBi.TabIndex = 1;
			// 
			// btnThem
			// 
			btnThem.ImageAlign = ContentAlignment.TopLeft;
			btnThem.Location = new Point(142, 589);
			btnThem.Name = "btnThem";
			btnThem.Size = new Size(96, 34);
			btnThem.TabIndex = 2;
			btnThem.Text = "Thêm";
			btnThem.UseVisualStyleBackColor = true;
			btnThem.Click += btnThem_Click;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(17, 105);
			label1.Name = "label1";
			label1.Size = new Size(115, 25);
			label1.TabIndex = 3;
			label1.Text = "Trang thiết bị";
			// 
			// txtMaPhong
			// 
			txtMaPhong.Enabled = false;
			txtMaPhong.Location = new Point(135, 43);
			txtMaPhong.Name = "txtMaPhong";
			txtMaPhong.Size = new Size(150, 31);
			txtMaPhong.TabIndex = 1;
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new Point(17, 43);
			label2.Name = "label2";
			label2.Size = new Size(99, 25);
			label2.TabIndex = 3;
			label2.Text = "Mã phòng:";
			// 
			// btnSua
			// 
			btnSua.Location = new Point(277, 589);
			btnSua.Name = "btnSua";
			btnSua.Size = new Size(112, 34);
			btnSua.TabIndex = 2;
			btnSua.Text = "Sửa";
			btnSua.UseVisualStyleBackColor = true;
			btnSua.Click += btnSua_Click;
			// 
			// btnXoa
			// 
			btnXoa.Location = new Point(412, 589);
			btnXoa.Name = "btnXoa";
			btnXoa.Size = new Size(112, 34);
			btnXoa.TabIndex = 2;
			btnXoa.Text = "Xoá";
			btnXoa.UseVisualStyleBackColor = true;
			btnXoa.Click += btnXoa_Click;
			// 
			// txtTenPhong
			// 
			txtTenPhong.Location = new Point(397, 43);
			txtTenPhong.Name = "txtTenPhong";
			txtTenPhong.Size = new Size(150, 31);
			txtTenPhong.TabIndex = 1;
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Location = new Point(299, 105);
			label3.Name = "label3";
			label3.Size = new Size(92, 25);
			label3.TabIndex = 3;
			label3.Text = "Tình trạng";
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Location = new Point(291, 46);
			label4.Name = "label4";
			label4.Size = new Size(100, 25);
			label4.TabIndex = 3;
			label4.Text = "Tên phòng:";
			// 
			// txtSucChua
			// 
			txtSucChua.Location = new Point(661, 43);
			txtSucChua.Name = "txtSucChua";
			txtSucChua.Size = new Size(150, 31);
			txtSucChua.TabIndex = 1;
			// 
			// label5
			// 
			label5.AutoSize = true;
			label5.Location = new Point(571, 46);
			label5.Name = "label5";
			label5.Size = new Size(84, 25);
			label5.TabIndex = 3;
			label5.Text = "Sức chứa";
			// 
			// groupBox1
			// 
			groupBox1.Controls.Add(dgvPhongHoc);
			groupBox1.Location = new Point(136, 57);
			groupBox1.Name = "groupBox1";
			groupBox1.Size = new Size(836, 334);
			groupBox1.TabIndex = 5;
			groupBox1.TabStop = false;
			groupBox1.Text = "Danh sách phòng học";
			// 
			// groupBox2
			// 
			groupBox2.BackColor = SystemColors.Control;
			groupBox2.Controls.Add(cmbTinhTrang);
			groupBox2.Controls.Add(label2);
			groupBox2.Controls.Add(txtSucChua);
			groupBox2.Controls.Add(label5);
			groupBox2.Controls.Add(label1);
			groupBox2.Controls.Add(label3);
			groupBox2.Controls.Add(txtTrangThietBi);
			groupBox2.Controls.Add(txtTenPhong);
			groupBox2.Controls.Add(txtMaPhong);
			groupBox2.Controls.Add(label4);
			groupBox2.Location = new Point(142, 397);
			groupBox2.Name = "groupBox2";
			groupBox2.Size = new Size(830, 169);
			groupBox2.TabIndex = 6;
			groupBox2.TabStop = false;
			groupBox2.Text = "Thông tin chi tiết";
			// 
			// cmbTinhTrang
			// 
			cmbTinhTrang.FormattingEnabled = true;
			cmbTinhTrang.Items.AddRange(new object[] { "Hoạt động", "Bảo trì" });
			cmbTinhTrang.Location = new Point(397, 102);
			cmbTinhTrang.Name = "cmbTinhTrang";
			cmbTinhTrang.Size = new Size(150, 33);
			cmbTinhTrang.TabIndex = 4;
			// 
			// label6
			// 
			label6.AutoSize = true;
			label6.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
			label6.Location = new Point(412, 9);
			label6.Name = "label6";
			label6.Size = new Size(361, 45);
			label6.TabIndex = 7;
			label6.Text = "QUẢN LÝ PHÒNG HỌC";
			// 
			// btnClear
			// 
			btnClear.Location = new Point(724, 589);
			btnClear.Name = "btnClear";
			btnClear.Size = new Size(112, 34);
			btnClear.TabIndex = 2;
			btnClear.Text = "Clear";
			btnClear.UseVisualStyleBackColor = true;
			btnClear.Click += btnClear_Click;
			// 
			// btnThoat
			// 
			btnThoat.Location = new Point(851, 589);
			btnThoat.Name = "btnThoat";
			btnThoat.Size = new Size(112, 34);
			btnThoat.TabIndex = 2;
			btnThoat.Text = "Thoát";
			btnThoat.UseVisualStyleBackColor = true;
			btnThoat.Click += btnThoat_Click;
			// 
			// frmQuanLyPhongHoc
			// 
			AutoScaleDimensions = new SizeF(10F, 25F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(1151, 652);
			Controls.Add(label6);
			Controls.Add(btnThoat);
			Controls.Add(btnClear);
			Controls.Add(btnXoa);
			Controls.Add(groupBox2);
			Controls.Add(groupBox1);
			Controls.Add(btnThem);
			Controls.Add(btnSua);
			Name = "frmQuanLyPhongHoc";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "Phòng học";
			((System.ComponentModel.ISupportInitialize)dgvPhongHoc).EndInit();
			groupBox1.ResumeLayout(false);
			groupBox2.ResumeLayout(false);
			groupBox2.PerformLayout();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private DataGridView dgvPhongHoc;
		private TextBox txtTrangThietBi;
		private Button btnThem;
		private Label label1;
		private TextBox txtMaPhong;
		private Label label2;
		private Button btnSua;
		private Button btnXoa;
		private TextBox txtTenPhong;
		private Label label3;
		private Label label4;
		private TextBox txtSucChua;
		private Label label5;
		private GroupBox groupBox1;
		private GroupBox groupBox2;
		private Label label6;
		private ComboBox cmbTinhTrang;
		private Button btnClear;
		private Button btnThoat;
	}
}
