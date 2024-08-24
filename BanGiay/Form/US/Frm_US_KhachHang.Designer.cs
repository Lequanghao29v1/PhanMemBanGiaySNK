namespace BanGiay.Form.US
{
    partial class Frm_US_KhachHang
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
            groupBox1 = new GroupBox();
            btnThem = new Button();
            btnSua = new Button();
            btnKhoa_MoKhoa = new Button();
            btnExcel = new Button();
            txtDiemKH = new TextBox();
            txtSDT = new TextBox();
            txtHoVaTen = new TextBox();
            label4 = new Label();
            txtMaKhachHang = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            groupBox2 = new GroupBox();
            dgvHD = new DataGridView();
            groupBox3 = new GroupBox();
            dgvKH = new DataGridView();
            panel1 = new Panel();
            txtTimKiem_KhachHang = new TextBox();
            label5 = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvHD).BeginInit();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvKH).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnThem);
            groupBox1.Controls.Add(btnSua);
            groupBox1.Controls.Add(btnKhoa_MoKhoa);
            groupBox1.Controls.Add(btnExcel);
            groupBox1.Controls.Add(txtDiemKH);
            groupBox1.Controls.Add(txtSDT);
            groupBox1.Controls.Add(txtHoVaTen);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(txtMaKhachHang);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Dock = DockStyle.Top;
            groupBox1.Location = new Point(0, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1094, 124);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thêm khách hàng";
            // 
            // btnThem
            // 
            btnThem.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnThem.BackColor = Color.FromArgb(64, 64, 64);
            btnThem.Cursor = Cursors.Hand;
            btnThem.FlatAppearance.BorderSize = 0;
            btnThem.FlatAppearance.MouseDownBackColor = Color.FromArgb(69, 97, 120);
            btnThem.FlatStyle = FlatStyle.Flat;
            btnThem.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnThem.ForeColor = Color.Yellow;
            btnThem.Location = new Point(689, 67);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(93, 39);
            btnThem.TabIndex = 2;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = false;
            btnThem.Click += btnThem_Click;
            // 
            // btnSua
            // 
            btnSua.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnSua.BackColor = Color.FromArgb(64, 64, 64);
            btnSua.Cursor = Cursors.Hand;
            btnSua.FlatAppearance.BorderSize = 0;
            btnSua.FlatAppearance.MouseDownBackColor = Color.FromArgb(69, 97, 120);
            btnSua.FlatStyle = FlatStyle.Flat;
            btnSua.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnSua.ForeColor = Color.Yellow;
            btnSua.Location = new Point(788, 67);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(93, 39);
            btnSua.TabIndex = 2;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = false;
            btnSua.Click += btnSua_Click;
            // 
            // btnKhoa_MoKhoa
            // 
            btnKhoa_MoKhoa.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnKhoa_MoKhoa.BackColor = Color.FromArgb(64, 64, 64);
            btnKhoa_MoKhoa.Cursor = Cursors.Hand;
            btnKhoa_MoKhoa.FlatAppearance.BorderSize = 0;
            btnKhoa_MoKhoa.FlatAppearance.MouseDownBackColor = Color.FromArgb(69, 97, 120);
            btnKhoa_MoKhoa.FlatStyle = FlatStyle.Flat;
            btnKhoa_MoKhoa.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnKhoa_MoKhoa.ForeColor = Color.Yellow;
            btnKhoa_MoKhoa.Location = new Point(887, 67);
            btnKhoa_MoKhoa.Name = "btnKhoa_MoKhoa";
            btnKhoa_MoKhoa.Size = new Size(102, 39);
            btnKhoa_MoKhoa.TabIndex = 2;
            btnKhoa_MoKhoa.Text = "Khóa/Mở khóa";
            btnKhoa_MoKhoa.UseVisualStyleBackColor = false;
            btnKhoa_MoKhoa.Click += btnKhoaMoKhoa_Click;
            // 
            // btnExcel
            // 
            btnExcel.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnExcel.BackColor = Color.FromArgb(64, 64, 64);
            btnExcel.Cursor = Cursors.Hand;
            btnExcel.FlatAppearance.BorderSize = 0;
            btnExcel.FlatAppearance.MouseDownBackColor = Color.FromArgb(69, 97, 120);
            btnExcel.FlatStyle = FlatStyle.Flat;
            btnExcel.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnExcel.ForeColor = Color.Yellow;
            btnExcel.Location = new Point(995, 67);
            btnExcel.Name = "btnExcel";
            btnExcel.Size = new Size(93, 39);
            btnExcel.TabIndex = 1;
            btnExcel.Text = "Excel";
            btnExcel.UseVisualStyleBackColor = false;
            btnExcel.Click += btnExcel_Click;
            // 
            // txtDiemKH
            // 
            txtDiemKH.BorderStyle = BorderStyle.FixedSingle;
            txtDiemKH.Enabled = false;
            txtDiemKH.Location = new Point(395, 75);
            txtDiemKH.Name = "txtDiemKH";
            txtDiemKH.Size = new Size(225, 23);
            txtDiemKH.TabIndex = 0;
            // 
            // txtSDT
            // 
            txtSDT.BorderStyle = BorderStyle.FixedSingle;
            txtSDT.Location = new Point(430, 28);
            txtSDT.Name = "txtSDT";
            txtSDT.Size = new Size(190, 23);
            txtSDT.TabIndex = 0;
            // 
            // txtHoVaTen
            // 
            txtHoVaTen.BorderStyle = BorderStyle.FixedSingle;
            txtHoVaTen.Location = new Point(92, 75);
            txtHoVaTen.Name = "txtHoVaTen";
            txtHoVaTen.Size = new Size(225, 23);
            txtHoVaTen.TabIndex = 0;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(328, 79);
            label4.Name = "label4";
            label4.Size = new Size(38, 15);
            label4.TabIndex = 0;
            label4.Text = "Điểm:";
            // 
            // txtMaKhachHang
            // 
            txtMaKhachHang.BorderStyle = BorderStyle.FixedSingle;
            txtMaKhachHang.Enabled = false;
            txtMaKhachHang.Location = new Point(127, 28);
            txtMaKhachHang.Name = "txtMaKhachHang";
            txtMaKhachHang.Size = new Size(190, 23);
            txtMaKhachHang.TabIndex = 0;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(328, 32);
            label3.Name = "label3";
            label3.Size = new Size(79, 15);
            label3.TabIndex = 0;
            label3.Text = "Số điện thoại:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(25, 79);
            label2.Name = "label2";
            label2.Size = new Size(61, 15);
            label2.TabIndex = 0;
            label2.Text = "Họ và tên:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(25, 32);
            label1.Name = "label1";
            label1.Size = new Size(92, 15);
            label1.TabIndex = 0;
            label1.Text = "Mã khách hàng:";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dgvHD);
            groupBox2.Dock = DockStyle.Bottom;
            groupBox2.Location = new Point(0, 457);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1094, 276);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Hóa đơn đã mua";
            // 
            // dgvHD
            // 
            dgvHD.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvHD.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvHD.Dock = DockStyle.Fill;
            dgvHD.Location = new Point(3, 19);
            dgvHD.Name = "dgvHD";
            dgvHD.RowTemplate.Height = 25;
            dgvHD.Size = new Size(1088, 254);
            dgvHD.TabIndex = 0;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(dgvKH);
            groupBox3.Controls.Add(panel1);
            groupBox3.Dock = DockStyle.Fill;
            groupBox3.Location = new Point(0, 124);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(1094, 333);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Text = "Khách hàng";
            // 
            // dgvKH
            // 
            dgvKH.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvKH.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvKH.Dock = DockStyle.Fill;
            dgvKH.Location = new Point(3, 57);
            dgvKH.Name = "dgvKH";
            dgvKH.RowTemplate.Height = 25;
            dgvKH.Size = new Size(1088, 273);
            dgvKH.TabIndex = 1;
            dgvKH.CellClick += dgvKH_CellClick;
            // 
            // panel1
            // 
            panel1.Controls.Add(txtTimKiem_KhachHang);
            panel1.Controls.Add(label5);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(3, 19);
            panel1.Name = "panel1";
            panel1.Size = new Size(1088, 38);
            panel1.TabIndex = 0;
            // 
            // txtTimKiem_KhachHang
            // 
            txtTimKiem_KhachHang.BorderStyle = BorderStyle.FixedSingle;
            txtTimKiem_KhachHang.Location = new Point(71, 9);
            txtTimKiem_KhachHang.Name = "txtTimKiem_KhachHang";
            txtTimKiem_KhachHang.PlaceholderText = "Tìm kiếm...";
            txtTimKiem_KhachHang.Size = new Size(333, 23);
            txtTimKiem_KhachHang.TabIndex = 0;
            txtTimKiem_KhachHang.TextChanged += txtTimkiem_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(4, 13);
            label5.Name = "label5";
            label5.Size = new Size(59, 15);
            label5.TabIndex = 0;
            label5.Text = "Tìm kiếm:";
            // 
            // Frm_US_KhachHang
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Frm_US_KhachHang";
            Size = new Size(1094, 733);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvHD).EndInit();
            groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvKH).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private TextBox txtHoVaTen;
        private TextBox txtMaKhachHang;
        private Label label2;
        private Label label1;
        private GroupBox groupBox3;
        private Button btnThem;
        private Button btnSua;
        private Button btnKhoa_MoKhoa;
        private Button btnExcel;
        private TextBox txtDiemKH;
        private TextBox txtSDT;
        private Label label4;
        private Label label3;
        private DataGridView dgvHD;
        private DataGridView dgvKH;
        private Panel panel1;
        private TextBox txtTimKiem_KhachHang;
        private Label label5;
    }
}
