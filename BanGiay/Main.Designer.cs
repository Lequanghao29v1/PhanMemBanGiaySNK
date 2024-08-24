namespace BanGiay
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            panel1 = new Panel();
            panel2 = new Panel();
            label1 = new Label();
            txtTenTaiKhoan = new Label();
            btnDangXuat = new Button();
            btnGiaoCa = new Button();
            btnLuong = new Button();
            btnThongKe = new Button();
            btnKhachHang = new Button();
            btnNhanVien = new Button();
            benKhuyenMai = new Button();
            btnHoaDon = new Button();
            btnSanPham = new Button();
            btnBanHang = new Button();
            ptbLOGO = new PictureBox();
            panel_US = new Panel();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ptbLOGO).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(64, 64, 64);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(btnDangXuat);
            panel1.Controls.Add(btnGiaoCa);
            panel1.Controls.Add(btnLuong);
            panel1.Controls.Add(btnThongKe);
            panel1.Controls.Add(btnKhachHang);
            panel1.Controls.Add(btnNhanVien);
            panel1.Controls.Add(benKhuyenMai);
            panel1.Controls.Add(btnHoaDon);
            panel1.Controls.Add(btnSanPham);
            panel1.Controls.Add(btnBanHang);
            panel1.Controls.Add(ptbLOGO);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(220, 733);
            panel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(64, 64, 64);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(txtTenTaiKhoan);
            panel2.Dock = DockStyle.Bottom;
            panel2.ForeColor = Color.Yellow;
            panel2.Location = new Point(0, 620);
            panel2.Name = "panel2";
            panel2.Size = new Size(220, 49);
            panel2.TabIndex = 14;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.Yellow;
            label1.Location = new Point(12, 14);
            label1.Name = "label1";
            label1.Size = new Size(56, 15);
            label1.TabIndex = 12;
            label1.Text = "Xin chào:";
            // 
            // txtTenTaiKhoan
            // 
            txtTenTaiKhoan.AutoSize = true;
            txtTenTaiKhoan.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            txtTenTaiKhoan.ForeColor = Color.FromArgb(0, 192, 0);
            txtTenTaiKhoan.Location = new Point(74, 14);
            txtTenTaiKhoan.Name = "txtTenTaiKhoan";
            txtTenTaiKhoan.Size = new Size(16, 17);
            txtTenTaiKhoan.TabIndex = 13;
            txtTenTaiKhoan.Text = "#";
            // 
            // btnDangXuat
            // 
            btnDangXuat.BackColor = Color.FromArgb(64, 64, 64);
            btnDangXuat.Dock = DockStyle.Bottom;
            btnDangXuat.FlatAppearance.BorderSize = 0;
            btnDangXuat.FlatStyle = FlatStyle.Flat;
            btnDangXuat.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnDangXuat.ForeColor = Color.Yellow;
            btnDangXuat.Location = new Point(0, 669);
            btnDangXuat.Name = "btnDangXuat";
            btnDangXuat.Size = new Size(220, 64);
            btnDangXuat.TabIndex = 11;
            btnDangXuat.Text = "Đăng xuất";
            btnDangXuat.UseVisualStyleBackColor = false;
            btnDangXuat.Click += btnDangXuat_Click;
            // 
            // btnGiaoCa
            // 
            btnGiaoCa.BackColor = Color.FromArgb(64, 64, 64);
            btnGiaoCa.Dock = DockStyle.Top;
            btnGiaoCa.FlatAppearance.BorderSize = 0;
            btnGiaoCa.FlatAppearance.CheckedBackColor = Color.FromArgb(0, 130, 173);
            btnGiaoCa.FlatAppearance.MouseDownBackColor = Color.FromArgb(46, 93, 157);
            btnGiaoCa.FlatStyle = FlatStyle.Flat;
            btnGiaoCa.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnGiaoCa.ForeColor = Color.Yellow;
            btnGiaoCa.Location = new Point(0, 534);
            btnGiaoCa.Name = "btnGiaoCa";
            btnGiaoCa.Size = new Size(220, 49);
            btnGiaoCa.TabIndex = 9;
            btnGiaoCa.Text = "Giao ca";
            btnGiaoCa.UseVisualStyleBackColor = false;
            btnGiaoCa.Visible = false;
            btnGiaoCa.Click += btnGiaoCa_Click;
            // 
            // btnLuong
            // 
            btnLuong.BackColor = Color.FromArgb(64, 64, 64);
            btnLuong.Dock = DockStyle.Top;
            btnLuong.FlatAppearance.BorderSize = 0;
            btnLuong.FlatAppearance.CheckedBackColor = Color.FromArgb(0, 130, 173);
            btnLuong.FlatAppearance.MouseDownBackColor = Color.FromArgb(46, 93, 157);
            btnLuong.FlatStyle = FlatStyle.Flat;
            btnLuong.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnLuong.ForeColor = Color.Yellow;
            btnLuong.Location = new Point(0, 485);
            btnLuong.Name = "btnLuong";
            btnLuong.Size = new Size(220, 49);
            btnLuong.TabIndex = 8;
            btnLuong.Text = "Lương";
            btnLuong.UseVisualStyleBackColor = false;
            btnLuong.Click += btnLuong_Click;
            // 
            // btnThongKe
            // 
            btnThongKe.BackColor = Color.FromArgb(64, 64, 64);
            btnThongKe.Dock = DockStyle.Top;
            btnThongKe.FlatAppearance.BorderSize = 0;
            btnThongKe.FlatAppearance.CheckedBackColor = Color.FromArgb(0, 130, 173);
            btnThongKe.FlatAppearance.MouseDownBackColor = Color.FromArgb(46, 93, 157);
            btnThongKe.FlatStyle = FlatStyle.Flat;
            btnThongKe.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnThongKe.ForeColor = Color.Yellow;
            btnThongKe.Location = new Point(0, 436);
            btnThongKe.Name = "btnThongKe";
            btnThongKe.Size = new Size(220, 49);
            btnThongKe.TabIndex = 7;
            btnThongKe.Text = "Thống kê";
            btnThongKe.UseVisualStyleBackColor = false;
            btnThongKe.Click += btnThongKe_Click;
            // 
            // btnKhachHang
            // 
            btnKhachHang.BackColor = Color.FromArgb(64, 64, 64);
            btnKhachHang.Dock = DockStyle.Top;
            btnKhachHang.FlatAppearance.BorderSize = 0;
            btnKhachHang.FlatAppearance.CheckedBackColor = Color.FromArgb(0, 130, 173);
            btnKhachHang.FlatAppearance.MouseDownBackColor = Color.FromArgb(46, 93, 157);
            btnKhachHang.FlatStyle = FlatStyle.Flat;
            btnKhachHang.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnKhachHang.ForeColor = Color.Yellow;
            btnKhachHang.Location = new Point(0, 387);
            btnKhachHang.Name = "btnKhachHang";
            btnKhachHang.Size = new Size(220, 49);
            btnKhachHang.TabIndex = 6;
            btnKhachHang.Text = "Khách hàng";
            btnKhachHang.UseVisualStyleBackColor = false;
            btnKhachHang.Click += btnKhachHang_Click;
            // 
            // btnNhanVien
            // 
            btnNhanVien.BackColor = Color.FromArgb(64, 64, 64);
            btnNhanVien.Dock = DockStyle.Top;
            btnNhanVien.FlatAppearance.BorderSize = 0;
            btnNhanVien.FlatAppearance.CheckedBackColor = Color.FromArgb(0, 130, 173);
            btnNhanVien.FlatAppearance.MouseDownBackColor = Color.FromArgb(46, 93, 157);
            btnNhanVien.FlatStyle = FlatStyle.Flat;
            btnNhanVien.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnNhanVien.ForeColor = Color.Yellow;
            btnNhanVien.Location = new Point(0, 338);
            btnNhanVien.Name = "btnNhanVien";
            btnNhanVien.Size = new Size(220, 49);
            btnNhanVien.TabIndex = 5;
            btnNhanVien.Text = "Nhân viên";
            btnNhanVien.UseVisualStyleBackColor = false;
            btnNhanVien.Click += btnNhanVien_Click;
            // 
            // benKhuyenMai
            // 
            benKhuyenMai.BackColor = Color.FromArgb(64, 64, 64);
            benKhuyenMai.Dock = DockStyle.Top;
            benKhuyenMai.FlatAppearance.BorderSize = 0;
            benKhuyenMai.FlatAppearance.CheckedBackColor = Color.FromArgb(0, 130, 173);
            benKhuyenMai.FlatAppearance.MouseDownBackColor = Color.FromArgb(46, 93, 157);
            benKhuyenMai.FlatStyle = FlatStyle.Flat;
            benKhuyenMai.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            benKhuyenMai.ForeColor = Color.Yellow;
            benKhuyenMai.Location = new Point(0, 289);
            benKhuyenMai.Name = "benKhuyenMai";
            benKhuyenMai.Size = new Size(220, 49);
            benKhuyenMai.TabIndex = 4;
            benKhuyenMai.Text = "Khuyến mãi";
            benKhuyenMai.UseVisualStyleBackColor = false;
            benKhuyenMai.Click += benKhuyenMai_Click;
            // 
            // btnHoaDon
            // 
            btnHoaDon.BackColor = Color.FromArgb(64, 64, 64);
            btnHoaDon.Dock = DockStyle.Top;
            btnHoaDon.FlatAppearance.BorderSize = 0;
            btnHoaDon.FlatAppearance.CheckedBackColor = Color.FromArgb(0, 130, 173);
            btnHoaDon.FlatAppearance.MouseDownBackColor = Color.FromArgb(46, 93, 157);
            btnHoaDon.FlatStyle = FlatStyle.Flat;
            btnHoaDon.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnHoaDon.ForeColor = Color.Yellow;
            btnHoaDon.Location = new Point(0, 240);
            btnHoaDon.Name = "btnHoaDon";
            btnHoaDon.Size = new Size(220, 49);
            btnHoaDon.TabIndex = 3;
            btnHoaDon.Text = "Hóa đơn";
            btnHoaDon.UseVisualStyleBackColor = false;
            btnHoaDon.Click += btnHoaDon_Click;
            // 
            // btnSanPham
            // 
            btnSanPham.BackColor = Color.FromArgb(64, 64, 64);
            btnSanPham.Dock = DockStyle.Top;
            btnSanPham.FlatAppearance.BorderSize = 0;
            btnSanPham.FlatAppearance.CheckedBackColor = Color.FromArgb(0, 130, 173);
            btnSanPham.FlatAppearance.MouseDownBackColor = Color.FromArgb(46, 93, 157);
            btnSanPham.FlatStyle = FlatStyle.Flat;
            btnSanPham.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnSanPham.ForeColor = Color.Yellow;
            btnSanPham.Location = new Point(0, 191);
            btnSanPham.Name = "btnSanPham";
            btnSanPham.Size = new Size(220, 49);
            btnSanPham.TabIndex = 2;
            btnSanPham.Text = "Sản phẩm";
            btnSanPham.UseVisualStyleBackColor = false;
            btnSanPham.Click += btnSanPham_Click;
            // 
            // btnBanHang
            // 
            btnBanHang.BackColor = Color.FromArgb(64, 64, 64);
            btnBanHang.Dock = DockStyle.Top;
            btnBanHang.FlatAppearance.BorderSize = 0;
            btnBanHang.FlatAppearance.MouseDownBackColor = Color.FromArgb(46, 93, 157);
            btnBanHang.FlatStyle = FlatStyle.Flat;
            btnBanHang.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnBanHang.ForeColor = Color.Yellow;
            btnBanHang.ImageAlign = ContentAlignment.MiddleLeft;
            btnBanHang.Location = new Point(0, 142);
            btnBanHang.Name = "btnBanHang";
            btnBanHang.Size = new Size(220, 49);
            btnBanHang.TabIndex = 1;
            btnBanHang.Text = "Bán Hàng";
            btnBanHang.UseVisualStyleBackColor = false;
            btnBanHang.Click += btnBanHang_Click;
            // 
            // ptbLOGO
            // 
            ptbLOGO.BackColor = Color.FromArgb(64, 64, 64);
            ptbLOGO.Dock = DockStyle.Top;
            ptbLOGO.Image = (Image)resources.GetObject("ptbLOGO.Image");
            ptbLOGO.Location = new Point(0, 0);
            ptbLOGO.Name = "ptbLOGO";
            ptbLOGO.Size = new Size(220, 142);
            ptbLOGO.SizeMode = PictureBoxSizeMode.Zoom;
            ptbLOGO.TabIndex = 0;
            ptbLOGO.TabStop = false;
            // 
            // panel_US
            // 
            panel_US.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel_US.Location = new Point(225, 8);
            panel_US.Name = "panel_US";
            panel_US.Size = new Size(1094, 733);
            panel_US.TabIndex = 1;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoValidate = AutoValidate.EnablePreventFocusChange;
            ClientSize = new Size(1313, 733);
            Controls.Add(panel_US);
            Controls.Add(panel1);
            Name = "Main";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Phần mềm bán giày";
            FormClosing += Main_FormClosing;
            Load += Main_Load;
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)ptbLOGO).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button btnThongKe;
        private PictureBox ptbLOGO;
        private Panel panel_US;
        private Button btnDangXuat;
        private Label txtTenTaiKhoan;
        private Label label1;
        private Panel panel2;
        private Button btnGiaoCa;
        private Button btnKhachHang;
        private Button btnNhanVien;
        private Button benKhuyenMai;
        private Button btnHoaDon;
        private Button btnSanPham;
        private Button btnBanHang;
        private Button btnLuong;
    }
}