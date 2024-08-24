namespace BanGiay.Form.US
{
    partial class Frm_US_BangLuong
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
            groupBox3 = new GroupBox();
            dgvHienThi = new DataGridView();
            panel1 = new Panel();
            btn_Excel = new Button();
            panel2 = new Panel();
            txtTimkiem_NhanVien = new TextBox();
            label1 = new Label();
            label2 = new Label();
            txtManv = new TextBox();
            label3 = new Label();
            label4 = new Label();
            txtTennv = new TextBox();
            txtLCB = new TextBox();
            label5 = new Label();
            txtTienthuong = new TextBox();
            label6 = new Label();
            txtTienkhautru = new TextBox();
            label7 = new Label();
            txtTongthunhap = new TextBox();
            label8 = new Label();
            txtThanglam = new TextBox();
            panel3 = new Panel();
            btnLamMoi = new Button();
            btnSua = new Button();
            panel4 = new Panel();
            btnThem = new Button();
            groupBox1 = new GroupBox();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvHienThi).BeginInit();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(dgvHienThi);
            groupBox3.Controls.Add(panel1);
            groupBox3.Dock = DockStyle.Fill;
            groupBox3.Location = new Point(0, 0);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(609, 346);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Text = "Bảng Lương";
            // 
            // dgvHienThi
            // 
            dgvHienThi.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvHienThi.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvHienThi.Dock = DockStyle.Fill;
            dgvHienThi.Location = new Point(3, 72);
            dgvHienThi.Name = "dgvHienThi";
            dgvHienThi.RowHeadersWidth = 51;
            dgvHienThi.RowTemplate.Height = 25;
            dgvHienThi.Size = new Size(603, 271);
            dgvHienThi.TabIndex = 2;
            dgvHienThi.CellClick += dgvHienThi_CellClick;
            // 
            // panel1
            // 
            panel1.Controls.Add(btn_Excel);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(txtTimkiem_NhanVien);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(3, 19);
            panel1.Name = "panel1";
            panel1.Size = new Size(603, 53);
            panel1.TabIndex = 1;
            // 
            // btn_Excel
            // 
            btn_Excel.BackColor = Color.Green;
            btn_Excel.Cursor = Cursors.Hand;
            btn_Excel.Dock = DockStyle.Right;
            btn_Excel.FlatAppearance.BorderSize = 0;
            btn_Excel.FlatAppearance.MouseDownBackColor = Color.FromArgb(69, 97, 120);
            btn_Excel.FlatStyle = FlatStyle.Flat;
            btn_Excel.ForeColor = Color.White;
            btn_Excel.Location = new Point(463, 0);
            btn_Excel.Name = "btn_Excel";
            btn_Excel.Size = new Size(76, 53);
            btn_Excel.TabIndex = 4;
            btn_Excel.Text = "Excel";
            btn_Excel.UseVisualStyleBackColor = false;
            btn_Excel.Click += btnexcel_Click;
            // 
            // panel2
            // 
            panel2.Dock = DockStyle.Right;
            panel2.Location = new Point(539, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(64, 53);
            panel2.TabIndex = 3;
            // 
            // txtTimkiem_NhanVien
            // 
            txtTimkiem_NhanVien.BorderStyle = BorderStyle.FixedSingle;
            txtTimkiem_NhanVien.Location = new Point(84, 16);
            txtTimkiem_NhanVien.Name = "txtTimkiem_NhanVien";
            txtTimkiem_NhanVien.Size = new Size(316, 23);
            txtTimkiem_NhanVien.TabIndex = 1;
            txtTimkiem_NhanVien.TextChanged += txtTimkiem_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(20, 20);
            label1.Name = "label1";
            label1.Size = new Size(59, 15);
            label1.TabIndex = 0;
            label1.Text = "Tìm kiếm:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(13, 106);
            label2.Name = "label2";
            label2.Size = new Size(63, 15);
            label2.TabIndex = 16;
            label2.Text = "Tháng làm";
            // 
            // txtManv
            // 
            txtManv.BorderStyle = BorderStyle.FixedSingle;
            txtManv.Location = new Point(102, 49);
            txtManv.Margin = new Padding(3, 2, 3, 2);
            txtManv.Name = "txtManv";
            txtManv.Size = new Size(194, 23);
            txtManv.TabIndex = 17;
            txtManv.TextChanged += txtManv_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(13, 49);
            label3.Name = "label3";
            label3.Size = new Size(79, 15);
            label3.TabIndex = 18;
            label3.Text = "Mã nhân viên";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(13, 79);
            label4.Name = "label4";
            label4.Size = new Size(80, 15);
            label4.TabIndex = 20;
            label4.Text = "Tên nhân viên";
            // 
            // txtTennv
            // 
            txtTennv.BorderStyle = BorderStyle.FixedSingle;
            txtTennv.Enabled = false;
            txtTennv.Location = new Point(102, 79);
            txtTennv.Margin = new Padding(3, 2, 3, 2);
            txtTennv.Name = "txtTennv";
            txtTennv.Size = new Size(194, 23);
            txtTennv.TabIndex = 22;
            // 
            // txtLCB
            // 
            txtLCB.BorderStyle = BorderStyle.FixedSingle;
            txtLCB.Location = new Point(102, 140);
            txtLCB.Margin = new Padding(3, 2, 3, 2);
            txtLCB.Name = "txtLCB";
            txtLCB.Size = new Size(194, 23);
            txtLCB.TabIndex = 23;
            txtLCB.TextChanged += txtLCB_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(13, 140);
            label5.Name = "label5";
            label5.Size = new Size(80, 15);
            label5.TabIndex = 24;
            label5.Text = "Lương cơ bản";
            // 
            // txtTienthuong
            // 
            txtTienthuong.BorderStyle = BorderStyle.FixedSingle;
            txtTienthuong.Location = new Point(102, 172);
            txtTienthuong.Margin = new Padding(3, 2, 3, 2);
            txtTienthuong.Name = "txtTienthuong";
            txtTienthuong.Size = new Size(194, 23);
            txtTienthuong.TabIndex = 25;
            txtTienthuong.TextChanged += txtTienthuong_TextChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(13, 173);
            label6.Name = "label6";
            label6.Size = new Size(71, 15);
            label6.TabIndex = 26;
            label6.Text = "Tiền thưởng";
            // 
            // txtTienkhautru
            // 
            txtTienkhautru.BorderStyle = BorderStyle.FixedSingle;
            txtTienkhautru.Location = new Point(102, 204);
            txtTienkhautru.Margin = new Padding(3, 2, 3, 2);
            txtTienkhautru.Name = "txtTienkhautru";
            txtTienkhautru.Size = new Size(194, 23);
            txtTienkhautru.TabIndex = 27;
            txtTienkhautru.TextChanged += txtTienkhautru_TextChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(13, 204);
            label7.Name = "label7";
            label7.Size = new Size(76, 15);
            label7.TabIndex = 28;
            label7.Text = "Tiền khấu trừ";
            // 
            // txtTongthunhap
            // 
            txtTongthunhap.BorderStyle = BorderStyle.FixedSingle;
            txtTongthunhap.Enabled = false;
            txtTongthunhap.Location = new Point(102, 236);
            txtTongthunhap.Margin = new Padding(3, 2, 3, 2);
            txtTongthunhap.Name = "txtTongthunhap";
            txtTongthunhap.Size = new Size(194, 23);
            txtTongthunhap.TabIndex = 29;
            txtTongthunhap.TextChanged += txtTongthunhap_TextChanged;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(13, 236);
            label8.Name = "label8";
            label8.Size = new Size(68, 15);
            label8.TabIndex = 30;
            label8.Text = "Tổng lương";
            // 
            // txtThanglam
            // 
            txtThanglam.BorderStyle = BorderStyle.FixedSingle;
            txtThanglam.Location = new Point(102, 108);
            txtThanglam.Margin = new Padding(3, 2, 3, 2);
            txtThanglam.Name = "txtThanglam";
            txtThanglam.Size = new Size(194, 23);
            txtThanglam.TabIndex = 32;
            // 
            // panel3
            // 
            panel3.Controls.Add(btnLamMoi);
            panel3.Controls.Add(btnSua);
            panel3.Controls.Add(panel4);
            panel3.Controls.Add(btnThem);
            panel3.Dock = DockStyle.Bottom;
            panel3.Location = new Point(3, 298);
            panel3.Name = "panel3";
            panel3.Size = new Size(305, 45);
            panel3.TabIndex = 33;
            // 
            // btnLamMoi
            // 
            btnLamMoi.BackColor = Color.FromArgb(64, 64, 64);
            btnLamMoi.Cursor = Cursors.Hand;
            btnLamMoi.Dock = DockStyle.Right;
            btnLamMoi.FlatAppearance.BorderSize = 0;
            btnLamMoi.FlatAppearance.MouseDownBackColor = Color.FromArgb(69, 97, 120);
            btnLamMoi.FlatStyle = FlatStyle.Flat;
            btnLamMoi.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnLamMoi.ForeColor = Color.Yellow;
            btnLamMoi.Location = new Point(228, 0);
            btnLamMoi.Name = "btnLamMoi";
            btnLamMoi.Size = new Size(77, 45);
            btnLamMoi.TabIndex = 23;
            btnLamMoi.Text = "Làm mới";
            btnLamMoi.UseVisualStyleBackColor = false;
            btnLamMoi.Click += btnLammoi_Click;
            // 
            // btnSua
            // 
            btnSua.BackColor = Color.FromArgb(64, 64, 64);
            btnSua.Cursor = Cursors.Hand;
            btnSua.Dock = DockStyle.Left;
            btnSua.FlatAppearance.BorderSize = 0;
            btnSua.FlatAppearance.MouseDownBackColor = Color.FromArgb(69, 97, 120);
            btnSua.FlatStyle = FlatStyle.Flat;
            btnSua.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnSua.ForeColor = Color.Yellow;
            btnSua.Location = new Point(114, 0);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(76, 45);
            btnSua.TabIndex = 21;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = false;
            btnSua.Click += btnSua_Click;
            // 
            // panel4
            // 
            panel4.Dock = DockStyle.Left;
            panel4.Location = new Point(78, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(36, 45);
            panel4.TabIndex = 20;
            // 
            // btnThem
            // 
            btnThem.BackColor = Color.FromArgb(64, 64, 64);
            btnThem.Cursor = Cursors.Hand;
            btnThem.Dock = DockStyle.Left;
            btnThem.FlatAppearance.BorderSize = 0;
            btnThem.FlatAppearance.MouseDownBackColor = Color.FromArgb(69, 97, 120);
            btnThem.FlatStyle = FlatStyle.Flat;
            btnThem.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnThem.ForeColor = Color.Yellow;
            btnThem.Location = new Point(0, 0);
            btnThem.Margin = new Padding(1, 2, 1, 2);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(78, 45);
            btnThem.TabIndex = 19;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = false;
            btnThem.Click += btnThem_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(panel3);
            groupBox1.Controls.Add(txtThanglam);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(txtTongthunhap);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(txtTienkhautru);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(txtTienthuong);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(txtLCB);
            groupBox1.Controls.Add(txtTennv);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txtManv);
            groupBox1.Controls.Add(label2);
            groupBox1.Dock = DockStyle.Right;
            groupBox1.Location = new Point(609, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(311, 346);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Tính Lương";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // Frm_US_BangLuong
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(groupBox3);
            Controls.Add(groupBox1);
            Name = "Frm_US_BangLuong";
            Size = new Size(920, 346);
            groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvHienThi).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel3.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private GroupBox groupBox3;
        private Panel panel1;
        private TextBox txtTimkiem_NhanVien;
        private Label label1;
        private Button btn_Excel;
        private Panel panel2;
        private DataGridView dgvHienThi;
        private Label label2;
        private TextBox txtManv;
        private Label label3;
        private Label label4;
        private TextBox txtTennv;
        private TextBox txtLCB;
        private Label label5;
        private TextBox txtTienthuong;
        private Label label6;
        private TextBox txtTienkhautru;
        private Label label7;
        private TextBox txtTongthunhap;
        private Label label8;
        private TextBox txtThanglam;
        private Panel panel3;
        private Button btnLamMoi;
        private Button btnSua;
        private Panel panel4;
        private Button btnThem;
        private GroupBox groupBox1;
    }
}
