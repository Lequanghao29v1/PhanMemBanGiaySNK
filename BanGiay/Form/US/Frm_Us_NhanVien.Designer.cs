namespace BanGiay.Form.US
{
    partial class Frm_Us_NhanVien
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            groupBox3 = new GroupBox();
            btnClear = new Button();
            btnKhoa_MoKhoa = new Button();
            btnSua = new Button();
            btnThem = new Button();
            groupBox2 = new GroupBox();
            rbnNu = new RadioButton();
            rbnNam = new RadioButton();
            dateSinh = new DateTimePicker();
            cmbChucvu = new ComboBox();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            txtDiachi = new TextBox();
            label6 = new Label();
            txtEmail = new TextBox();
            label5 = new Label();
            txtSDT = new TextBox();
            label4 = new Label();
            label3 = new Label();
            txtTen = new TextBox();
            label2 = new Label();
            txtMatkhau = new TextBox();
            label10 = new Label();
            txtTaikhoan = new TextBox();
            groupBox1 = new GroupBox();
            dgvHienThi = new DataGridView();
            panel2 = new Panel();
            btnExcel = new Button();
            txtTimKiem = new TextBox();
            label1 = new Label();
            panel1.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvHienThi).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(groupBox3);
            panel1.Controls.Add(groupBox2);
            panel1.Dock = DockStyle.Right;
            panel1.Location = new Point(819, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(275, 733);
            panel1.TabIndex = 0;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(btnClear);
            groupBox3.Controls.Add(btnKhoa_MoKhoa);
            groupBox3.Controls.Add(btnSua);
            groupBox3.Controls.Add(btnThem);
            groupBox3.Dock = DockStyle.Bottom;
            groupBox3.Location = new Point(0, 607);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(275, 126);
            groupBox3.TabIndex = 1;
            groupBox3.TabStop = false;
            groupBox3.Text = "Chức năng";
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.FromArgb(64, 79, 105);
            btnClear.Cursor = Cursors.Hand;
            btnClear.FlatAppearance.BorderSize = 0;
            btnClear.FlatAppearance.MouseDownBackColor = Color.FromArgb(69, 97, 120);
            btnClear.FlatStyle = FlatStyle.Flat;
            btnClear.ForeColor = Color.White;
            btnClear.Location = new Point(228, 83);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(41, 37);
            btnClear.TabIndex = 0;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Visible = false;
            btnClear.Click += btnClear_Click;
            // 
            // btnKhoa_MoKhoa
            // 
            btnKhoa_MoKhoa.BackColor = Color.FromArgb(64, 64, 64);
            btnKhoa_MoKhoa.Cursor = Cursors.Hand;
            btnKhoa_MoKhoa.FlatAppearance.BorderSize = 0;
            btnKhoa_MoKhoa.FlatAppearance.MouseDownBackColor = Color.FromArgb(69, 97, 120);
            btnKhoa_MoKhoa.FlatStyle = FlatStyle.Flat;
            btnKhoa_MoKhoa.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnKhoa_MoKhoa.ForeColor = Color.Yellow;
            btnKhoa_MoKhoa.Location = new Point(89, 74);
            btnKhoa_MoKhoa.Name = "btnKhoa_MoKhoa";
            btnKhoa_MoKhoa.Size = new Size(100, 37);
            btnKhoa_MoKhoa.TabIndex = 0;
            btnKhoa_MoKhoa.Text = "Khóa/Mở khóa";
            btnKhoa_MoKhoa.UseVisualStyleBackColor = false;
            btnKhoa_MoKhoa.Click += btnkhoamokhoa_Click;
            // 
            // btnSua
            // 
            btnSua.BackColor = Color.FromArgb(64, 64, 64);
            btnSua.Cursor = Cursors.Hand;
            btnSua.FlatAppearance.BorderSize = 0;
            btnSua.FlatAppearance.MouseDownBackColor = Color.FromArgb(69, 97, 120);
            btnSua.FlatStyle = FlatStyle.Flat;
            btnSua.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnSua.ForeColor = Color.Yellow;
            btnSua.Location = new Point(152, 22);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(100, 37);
            btnSua.TabIndex = 0;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = false;
            btnSua.Click += btnSua_Click;
            // 
            // btnThem
            // 
            btnThem.BackColor = Color.FromArgb(64, 64, 64);
            btnThem.Cursor = Cursors.Hand;
            btnThem.FlatAppearance.BorderSize = 0;
            btnThem.FlatAppearance.MouseDownBackColor = Color.FromArgb(69, 97, 120);
            btnThem.FlatStyle = FlatStyle.Flat;
            btnThem.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnThem.ForeColor = Color.Yellow;
            btnThem.Location = new Point(18, 22);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(100, 37);
            btnThem.TabIndex = 0;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = false;
            btnThem.Click += btnThem_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(rbnNu);
            groupBox2.Controls.Add(rbnNam);
            groupBox2.Controls.Add(dateSinh);
            groupBox2.Controls.Add(cmbChucvu);
            groupBox2.Controls.Add(label9);
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(txtDiachi);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(txtEmail);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(txtSDT);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(txtTen);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(txtMatkhau);
            groupBox2.Controls.Add(label10);
            groupBox2.Controls.Add(txtTaikhoan);
            groupBox2.Dock = DockStyle.Fill;
            groupBox2.Location = new Point(0, 0);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(275, 733);
            groupBox2.TabIndex = 0;
            groupBox2.TabStop = false;
            groupBox2.Text = "Thông tin";
            // 
            // rbnNu
            // 
            rbnNu.AutoSize = true;
            rbnNu.Location = new Point(136, 223);
            rbnNu.Margin = new Padding(3, 2, 3, 2);
            rbnNu.Name = "rbnNu";
            rbnNu.Size = new Size(41, 19);
            rbnNu.TabIndex = 34;
            rbnNu.TabStop = true;
            rbnNu.Text = "Nữ";
            rbnNu.UseVisualStyleBackColor = true;
            // 
            // rbnNam
            // 
            rbnNam.AutoSize = true;
            rbnNam.Location = new Point(18, 223);
            rbnNam.Margin = new Padding(3, 2, 3, 2);
            rbnNam.Name = "rbnNam";
            rbnNam.Size = new Size(51, 19);
            rbnNam.TabIndex = 33;
            rbnNam.TabStop = true;
            rbnNam.Text = "Nam";
            rbnNam.UseVisualStyleBackColor = true;
            // 
            // dateSinh
            // 
            dateSinh.Location = new Point(6, 454);
            dateSinh.Margin = new Padding(3, 2, 3, 2);
            dateSinh.Name = "dateSinh";
            dateSinh.Size = new Size(246, 23);
            dateSinh.TabIndex = 32;
            // 
            // cmbChucvu
            // 
            cmbChucvu.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbChucvu.FormattingEnabled = true;
            cmbChucvu.Location = new Point(6, 505);
            cmbChucvu.Margin = new Padding(3, 2, 3, 2);
            cmbChucvu.Name = "cmbChucvu";
            cmbChucvu.Size = new Size(246, 23);
            cmbChucvu.TabIndex = 31;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(6, 487);
            label9.Name = "label9";
            label9.Size = new Size(54, 15);
            label9.TabIndex = 23;
            label9.Text = "Chức vụ:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(6, 429);
            label8.Name = "label8";
            label8.Size = new Size(63, 15);
            label8.TabIndex = 30;
            label8.Text = "Ngày sinh:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(6, 371);
            label7.Name = "label7";
            label7.Size = new Size(46, 15);
            label7.TabIndex = 22;
            label7.Text = "Địa chỉ:";
            // 
            // txtDiachi
            // 
            txtDiachi.BorderStyle = BorderStyle.FixedSingle;
            txtDiachi.Location = new Point(6, 389);
            txtDiachi.Name = "txtDiachi";
            txtDiachi.Size = new Size(246, 23);
            txtDiachi.TabIndex = 20;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(6, 313);
            label6.Name = "label6";
            label6.Size = new Size(39, 15);
            label6.TabIndex = 24;
            label6.Text = "Email:";
            // 
            // txtEmail
            // 
            txtEmail.BorderStyle = BorderStyle.FixedSingle;
            txtEmail.Location = new Point(6, 331);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(246, 23);
            txtEmail.TabIndex = 16;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(6, 255);
            label5.Name = "label5";
            label5.Size = new Size(79, 15);
            label5.TabIndex = 26;
            label5.Text = "Số điện thoại:";
            // 
            // txtSDT
            // 
            txtSDT.BorderStyle = BorderStyle.FixedSingle;
            txtSDT.Location = new Point(6, 273);
            txtSDT.Name = "txtSDT";
            txtSDT.Size = new Size(246, 23);
            txtSDT.TabIndex = 19;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 197);
            label4.Name = "label4";
            label4.Size = new Size(55, 15);
            label4.TabIndex = 27;
            label4.Text = "Giới tính:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 139);
            label3.Name = "label3";
            label3.Size = new Size(61, 15);
            label3.TabIndex = 28;
            label3.Text = "Họ và tên:";
            // 
            // txtTen
            // 
            txtTen.BorderStyle = BorderStyle.FixedSingle;
            txtTen.Location = new Point(6, 157);
            txtTen.Name = "txtTen";
            txtTen.Size = new Size(246, 23);
            txtTen.TabIndex = 18;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 81);
            label2.Name = "label2";
            label2.Size = new Size(60, 15);
            label2.TabIndex = 29;
            label2.Text = "Mật khẩu:";
            // 
            // txtMatkhau
            // 
            txtMatkhau.BorderStyle = BorderStyle.FixedSingle;
            txtMatkhau.Location = new Point(6, 103);
            txtMatkhau.Name = "txtMatkhau";
            txtMatkhau.Size = new Size(246, 23);
            txtMatkhau.TabIndex = 17;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(6, 23);
            label10.Name = "label10";
            label10.Size = new Size(80, 15);
            label10.TabIndex = 25;
            label10.Text = "Tên tài khoản:";
            // 
            // txtTaikhoan
            // 
            txtTaikhoan.BorderStyle = BorderStyle.FixedSingle;
            txtTaikhoan.Location = new Point(6, 45);
            txtTaikhoan.Name = "txtTaikhoan";
            txtTaikhoan.Size = new Size(246, 23);
            txtTaikhoan.TabIndex = 21;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dgvHienThi);
            groupBox1.Controls.Add(panel2);
            groupBox1.Dock = DockStyle.Fill;
            groupBox1.Location = new Point(0, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(819, 733);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Danh sách nhân viên";
            // 
            // dgvHienThi
            // 
            dgvHienThi.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            dgvHienThi.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvHienThi.Dock = DockStyle.Fill;
            dgvHienThi.Location = new Point(3, 58);
            dgvHienThi.Name = "dgvHienThi";
            dgvHienThi.RowTemplate.Height = 25;
            dgvHienThi.Size = new Size(813, 672);
            dgvHienThi.TabIndex = 1;
            dgvHienThi.CellClick += dgvHienThi_CellClick;
            // 
            // panel2
            // 
            panel2.Controls.Add(btnExcel);
            panel2.Controls.Add(txtTimKiem);
            panel2.Controls.Add(label1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(3, 19);
            panel2.Name = "panel2";
            panel2.Size = new Size(813, 39);
            panel2.TabIndex = 0;
            // 
            // btnExcel
            // 
            btnExcel.BackColor = Color.Green;
            btnExcel.Cursor = Cursors.Hand;
            btnExcel.FlatAppearance.BorderSize = 0;
            btnExcel.FlatAppearance.MouseDownBackColor = Color.FromArgb(69, 97, 120);
            btnExcel.FlatStyle = FlatStyle.Flat;
            btnExcel.ForeColor = Color.White;
            btnExcel.Location = new Point(725, 3);
            btnExcel.Name = "btnExcel";
            btnExcel.Size = new Size(85, 33);
            btnExcel.TabIndex = 0;
            btnExcel.Text = "Excel";
            btnExcel.UseVisualStyleBackColor = false;
            btnExcel.Click += btnexcel_Click;
            // 
            // txtTimKiem
            // 
            txtTimKiem.BorderStyle = BorderStyle.FixedSingle;
            txtTimKiem.Location = new Point(77, 7);
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.PlaceholderText = "Tìm kiếm ...";
            txtTimKiem.Size = new Size(284, 23);
            txtTimKiem.TabIndex = 1;
            txtTimKiem.TextChanged += txtTimkiem_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 10);
            label1.Name = "label1";
            label1.Size = new Size(59, 15);
            label1.TabIndex = 0;
            label1.Text = "Tìm kiếm:";
            // 
            // Frm_Us_NhanVien
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(groupBox1);
            Controls.Add(panel1);
            Name = "Frm_Us_NhanVien";
            Size = new Size(1094, 733);
            panel1.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvHienThi).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private GroupBox groupBox3;
        private GroupBox groupBox2;
        private GroupBox groupBox1;
        private DataGridView dgvHienThi;
        private Panel panel2;
        private TextBox txtTimKiem;
        private Label label1;
        private Button btnClear;
        private Button btnKhoa_MoKhoa;
        private Button btnSua;
        private Button btnThem;
        private RadioButton rbnNu;
        private RadioButton rbnNam;
        private DateTimePicker dateSinh;
        private ComboBox cmbChucvu;
        private Label label9;
        private Label label8;
        private Label label7;
        private TextBox txtDiachi;
        private Label label6;
        private TextBox txtEmail;
        private Label label5;
        private TextBox txtSDT;
        private Label label4;
        private Label label3;
        private TextBox txtTen;
        private Label label2;
        private TextBox txtMatkhau;
        private Label label10;
        private TextBox txtTaikhoan;
        private Button btnExcel;
    }
}
