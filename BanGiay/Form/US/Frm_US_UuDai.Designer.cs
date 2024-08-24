namespace BanGiay.Form.US
{
    partial class Frm_US_UuDai
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
            groupBox4 = new GroupBox();
            datebatdau = new DateTimePicker();
            dateketthuc = new DateTimePicker();
            label5 = new Label();
            txtphantram = new TextBox();
            label4 = new Label();
            label2 = new Label();
            label1 = new Label();
            txtSoluong = new TextBox();
            label3 = new Label();
            txtTen = new TextBox();
            groupBox3 = new GroupBox();
            btnSua = new Button();
            btnThem = new Button();
            groupBox2 = new GroupBox();
            btnlammoi = new Button();
            btnketthuc = new Button();
            txtTimkiem = new TextBox();
            groupBox1 = new GroupBox();
            dtgHienthi = new DataGridView();
            panel1.SuspendLayout();
            groupBox4.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgHienthi).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(groupBox4);
            panel1.Controls.Add(groupBox3);
            panel1.Controls.Add(groupBox2);
            panel1.Dock = DockStyle.Right;
            panel1.Location = new Point(785, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(309, 733);
            panel1.TabIndex = 0;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(datebatdau);
            groupBox4.Controls.Add(dateketthuc);
            groupBox4.Controls.Add(label5);
            groupBox4.Controls.Add(txtphantram);
            groupBox4.Controls.Add(label4);
            groupBox4.Controls.Add(label2);
            groupBox4.Controls.Add(label1);
            groupBox4.Controls.Add(txtSoluong);
            groupBox4.Controls.Add(label3);
            groupBox4.Controls.Add(txtTen);
            groupBox4.Dock = DockStyle.Fill;
            groupBox4.Location = new Point(0, 100);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(309, 513);
            groupBox4.TabIndex = 2;
            groupBox4.TabStop = false;
            groupBox4.Text = "Thông tin";
            // 
            // datebatdau
            // 
            datebatdau.Location = new Point(18, 163);
            datebatdau.Name = "datebatdau";
            datebatdau.Size = new Size(246, 23);
            datebatdau.TabIndex = 23;
            // 
            // dateketthuc
            // 
            dateketthuc.Location = new Point(18, 221);
            dateketthuc.Name = "dateketthuc";
            dateketthuc.Size = new Size(246, 23);
            dateketthuc.TabIndex = 24;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(18, 261);
            label5.Name = "label5";
            label5.Size = new Size(114, 15);
            label5.TabIndex = 18;
            label5.Text = "Phần trăm giảm giá:";
            // 
            // txtphantram
            // 
            txtphantram.BorderStyle = BorderStyle.FixedSingle;
            txtphantram.Location = new Point(18, 283);
            txtphantram.Name = "txtphantram";
            txtphantram.Size = new Size(246, 23);
            txtphantram.TabIndex = 15;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(18, 203);
            label4.Name = "label4";
            label4.Size = new Size(84, 15);
            label4.TabIndex = 19;
            label4.Text = "Ngày kết thúc:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(18, 145);
            label2.Name = "label2";
            label2.Size = new Size(81, 15);
            label2.TabIndex = 20;
            label2.Text = "Ngày bắt đầu:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(18, 87);
            label1.Name = "label1";
            label1.Size = new Size(57, 15);
            label1.TabIndex = 21;
            label1.Text = "Số lượng:";
            // 
            // txtSoluong
            // 
            txtSoluong.BorderStyle = BorderStyle.FixedSingle;
            txtSoluong.Location = new Point(18, 109);
            txtSoluong.Name = "txtSoluong";
            txtSoluong.Size = new Size(246, 23);
            txtSoluong.TabIndex = 16;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(18, 29);
            label3.Name = "label3";
            label3.Size = new Size(61, 15);
            label3.TabIndex = 22;
            label3.Text = "Tên ưu đãi";
            // 
            // txtTen
            // 
            txtTen.BorderStyle = BorderStyle.FixedSingle;
            txtTen.Location = new Point(18, 51);
            txtTen.Name = "txtTen";
            txtTen.Size = new Size(246, 23);
            txtTen.TabIndex = 17;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(btnSua);
            groupBox3.Controls.Add(btnThem);
            groupBox3.Dock = DockStyle.Bottom;
            groupBox3.Location = new Point(0, 613);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(309, 120);
            groupBox3.TabIndex = 1;
            groupBox3.TabStop = false;
            groupBox3.Text = "Chức năng";
            // 
            // btnSua
            // 
            btnSua.BackColor = Color.FromArgb(64, 64, 64);
            btnSua.FlatAppearance.BorderSize = 0;
            btnSua.FlatAppearance.MouseDownBackColor = Color.FromArgb(69, 97, 120);
            btnSua.FlatStyle = FlatStyle.Flat;
            btnSua.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnSua.ForeColor = Color.Yellow;
            btnSua.Location = new Point(18, 67);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(272, 39);
            btnSua.TabIndex = 1;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = false;
            btnSua.Click += btnSua_Click;
            // 
            // btnThem
            // 
            btnThem.BackColor = Color.FromArgb(64, 64, 64);
            btnThem.FlatAppearance.BorderSize = 0;
            btnThem.FlatAppearance.MouseDownBackColor = Color.FromArgb(69, 97, 120);
            btnThem.FlatStyle = FlatStyle.Flat;
            btnThem.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnThem.ForeColor = Color.Yellow;
            btnThem.Location = new Point(18, 22);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(272, 39);
            btnThem.TabIndex = 2;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = false;
            btnThem.Click += btnThem_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnlammoi);
            groupBox2.Controls.Add(btnketthuc);
            groupBox2.Controls.Add(txtTimkiem);
            groupBox2.Dock = DockStyle.Top;
            groupBox2.Location = new Point(0, 0);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(309, 100);
            groupBox2.TabIndex = 0;
            groupBox2.TabStop = false;
            groupBox2.Text = "Tìm kiếm";
            // 
            // btnlammoi
            // 
            btnlammoi.BackColor = Color.FromArgb(64, 64, 64);
            btnlammoi.FlatAppearance.BorderSize = 0;
            btnlammoi.FlatAppearance.MouseDownBackColor = Color.FromArgb(69, 97, 120);
            btnlammoi.FlatStyle = FlatStyle.Flat;
            btnlammoi.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnlammoi.ForeColor = Color.Yellow;
            btnlammoi.Location = new Point(163, 50);
            btnlammoi.Margin = new Padding(3, 2, 3, 2);
            btnlammoi.Name = "btnlammoi";
            btnlammoi.Size = new Size(115, 38);
            btnlammoi.TabIndex = 7;
            btnlammoi.Text = "Làm mới";
            btnlammoi.UseVisualStyleBackColor = false;
            btnlammoi.Click += btnlammoi_Click;
            // 
            // btnketthuc
            // 
            btnketthuc.BackColor = Color.FromArgb(64, 64, 64);
            btnketthuc.FlatAppearance.BorderSize = 0;
            btnketthuc.FlatAppearance.MouseDownBackColor = Color.FromArgb(69, 97, 120);
            btnketthuc.FlatStyle = FlatStyle.Flat;
            btnketthuc.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnketthuc.ForeColor = Color.Yellow;
            btnketthuc.Location = new Point(36, 50);
            btnketthuc.Margin = new Padding(3, 2, 3, 2);
            btnketthuc.Name = "btnketthuc";
            btnketthuc.Size = new Size(115, 38);
            btnketthuc.TabIndex = 6;
            btnketthuc.Text = "Kết thúc";
            btnketthuc.UseVisualStyleBackColor = false;
            btnketthuc.Click += btnketthuc_Click;
            // 
            // txtTimkiem
            // 
            txtTimkiem.BorderStyle = BorderStyle.FixedSingle;
            txtTimkiem.Location = new Point(18, 22);
            txtTimkiem.Name = "txtTimkiem";
            txtTimkiem.Size = new Size(285, 23);
            txtTimkiem.TabIndex = 5;
            txtTimkiem.TextChanged += txtTimkiem_TextChanged;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dtgHienthi);
            groupBox1.Dock = DockStyle.Fill;
            groupBox1.Location = new Point(0, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(785, 733);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Danh sách ưu đãi";
            // 
            // dtgHienthi
            // 
            dtgHienthi.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgHienthi.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgHienthi.Dock = DockStyle.Fill;
            dtgHienthi.Location = new Point(3, 19);
            dtgHienthi.Name = "dtgHienthi";
            dtgHienthi.RowTemplate.Height = 25;
            dtgHienthi.Size = new Size(779, 711);
            dtgHienthi.TabIndex = 0;
            dtgHienthi.CellClick += dtgHienthi_CellClick;
            // 
            // Frm_US_UuDai
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(groupBox1);
            Controls.Add(panel1);
            Name = "Frm_US_UuDai";
            Size = new Size(1094, 733);
            Load += Frm_US_UuDai_Load;
            panel1.ResumeLayout(false);
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dtgHienthi).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private GroupBox groupBox4;
        private DateTimePicker datebatdau;
        private DateTimePicker dateketthuc;
        private Label label5;
        private TextBox txtphantram;
        private Label label4;
        private Label label2;
        private Label label1;
        private TextBox txtSoluong;
        private Label label3;
        private TextBox txtTen;
        private GroupBox groupBox3;
        private Button btnSua;
        private Button btnThem;
        private GroupBox groupBox2;
        private Button btnlammoi;
        private Button btnketthuc;
        private TextBox txtTimkiem;
        private GroupBox groupBox1;
        private DataGridView dtgHienthi;
    }
}
