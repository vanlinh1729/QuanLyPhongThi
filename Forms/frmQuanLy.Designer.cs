namespace QuanLyPhongThi.Forms
{
	partial class frmQuanLy
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
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
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			menuStrip1 = new MenuStrip();
			hệThốngToolStripMenuItem = new ToolStripMenuItem();
			thoátToolStripMenuItem = new ToolStripMenuItem();
			quảnLýToolStripMenuItem = new ToolStripMenuItem();
			sinhViênToolStripMenuItem = new ToolStripMenuItem();
			toolStripMenuItem1 = new ToolStripMenuItem();
			mônHọcToolStripMenuItem = new ToolStripMenuItem();
			lịchThiToolStripMenuItem1 = new ToolStripMenuItem();
			lịchThiToolStripMenuItem2 = new ToolStripMenuItem();
			lịchThiSinhViênToolStripMenuItem1 = new ToolStripMenuItem();
			menuStrip1.SuspendLayout();
			SuspendLayout();
			// 
			// menuStrip1
			// 
			menuStrip1.ImageScalingSize = new Size(24, 24);
			menuStrip1.Items.AddRange(new ToolStripItem[] { hệThốngToolStripMenuItem, quảnLýToolStripMenuItem, lịchThiToolStripMenuItem1 });
			menuStrip1.Location = new Point(0, 0);
			menuStrip1.Name = "menuStrip1";
			menuStrip1.Size = new Size(1468, 33);
			menuStrip1.TabIndex = 0;
			menuStrip1.Text = "menuStrip1";
			// 
			// hệThốngToolStripMenuItem
			// 
			hệThốngToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { thoátToolStripMenuItem });
			hệThốngToolStripMenuItem.Name = "hệThốngToolStripMenuItem";
			hệThốngToolStripMenuItem.Size = new Size(103, 29);
			hệThốngToolStripMenuItem.Text = "Hệ thống";
			// 
			// thoátToolStripMenuItem
			// 
			thoátToolStripMenuItem.Name = "thoátToolStripMenuItem";
			thoátToolStripMenuItem.Size = new Size(159, 34);
			thoátToolStripMenuItem.Text = "Thoát";
			thoátToolStripMenuItem.Click += thoátToolStripMenuItem_Click;
			// 
			// quảnLýToolStripMenuItem
			// 
			quảnLýToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { sinhViênToolStripMenuItem, toolStripMenuItem1, mônHọcToolStripMenuItem });
			quảnLýToolStripMenuItem.Name = "quảnLýToolStripMenuItem";
			quảnLýToolStripMenuItem.Size = new Size(167, 29);
			quảnLýToolStripMenuItem.Text = "Quản lý thông tin";
			// 
			// sinhViênToolStripMenuItem
			// 
			sinhViênToolStripMenuItem.Name = "sinhViênToolStripMenuItem";
			sinhViênToolStripMenuItem.Size = new Size(270, 34);
			sinhViênToolStripMenuItem.Text = "Sinh viên";
			sinhViênToolStripMenuItem.Click += sinhViênToolStripMenuItem_Click;
			// 
			// toolStripMenuItem1
			// 
			toolStripMenuItem1.Name = "toolStripMenuItem1";
			toolStripMenuItem1.Size = new Size(270, 34);
			toolStripMenuItem1.Text = "Phòng học";
			toolStripMenuItem1.Click += toolStripMenuItem1_Click;
			// 
			// mônHọcToolStripMenuItem
			// 
			mônHọcToolStripMenuItem.Name = "mônHọcToolStripMenuItem";
			mônHọcToolStripMenuItem.Size = new Size(270, 34);
			mônHọcToolStripMenuItem.Text = "Môn học";
			mônHọcToolStripMenuItem.Click += mônHọcToolStripMenuItem_Click;
			// 
			// lịchThiToolStripMenuItem1
			// 
			lịchThiToolStripMenuItem1.DropDownItems.AddRange(new ToolStripItem[] { lịchThiToolStripMenuItem2, lịchThiSinhViênToolStripMenuItem1 });
			lịchThiToolStripMenuItem1.Name = "lịchThiToolStripMenuItem1";
			lịchThiToolStripMenuItem1.Size = new Size(83, 29);
			lịchThiToolStripMenuItem1.Text = "Lịch thi";
			// 
			// lịchThiToolStripMenuItem2
			// 
			lịchThiToolStripMenuItem2.Name = "lịchThiToolStripMenuItem2";
			lịchThiToolStripMenuItem2.Size = new Size(270, 34);
			lịchThiToolStripMenuItem2.Text = "Lịch thi";
			lịchThiToolStripMenuItem2.Click += lịchThiToolStripMenuItem2_Click;
			// 
			// lịchThiSinhViênToolStripMenuItem1
			// 
			lịchThiSinhViênToolStripMenuItem1.Name = "lịchThiSinhViênToolStripMenuItem1";
			lịchThiSinhViênToolStripMenuItem1.Size = new Size(270, 34);
			lịchThiSinhViênToolStripMenuItem1.Text = "Lịch thi Sinh viên";
			lịchThiSinhViênToolStripMenuItem1.Click += lịchThiSinhViênToolStripMenuItem1_Click;
			// 
			// frmQuanLy
			// 
			AutoScaleDimensions = new SizeF(10F, 25F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(1468, 742);
			Controls.Add(menuStrip1);
			MainMenuStrip = menuStrip1;
			Name = "frmQuanLy";
			StartPosition = FormStartPosition.Manual;
			Text = "Quản lý phòng thi";
			WindowState = FormWindowState.Maximized;
			Load += frmQuanLy_Load;
			menuStrip1.ResumeLayout(false);
			menuStrip1.PerformLayout();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private MenuStrip menuStrip1;
		private ToolStripMenuItem hệThốngToolStripMenuItem;
		private ToolStripMenuItem quảnLýToolStripMenuItem;
		private ToolStripMenuItem toolStripMenuItem1;
		private ToolStripMenuItem thoátToolStripMenuItem;
		private ToolStripMenuItem sinhViênToolStripMenuItem;
		private ToolStripMenuItem mônHọcToolStripMenuItem;
		private ToolStripMenuItem lịchThiToolStripMenuItem1;
		private ToolStripMenuItem lịchThiToolStripMenuItem2;
		private ToolStripMenuItem lịchThiSinhViênToolStripMenuItem1;
	}
}