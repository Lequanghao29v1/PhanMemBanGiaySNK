namespace PRL
{
    partial class ThuongHieu_Frm
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
            btnTimKiem = new Button();
            cbbTimKiem = new ComboBox();
            txtTimKiem = new TextBox();
            groupBox1 = new GroupBox();
            btnKhoa_MoKhoa = new Button();
            btnSua = new Button();
            btnThem = new Button();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label1 = new Label();
            txtEmail = new TextBox();
            txtMoTa = new TextBox();
            txtSDT = new TextBox();
            txtTen = new TextBox();
            dgv_Objects = new DataGridView();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_Objects).BeginInit();
            SuspendLayout();
            // 
            // btnTimKiem
            // 
            btnTimKiem.BackColor = Color.FromArgb(64, 64, 64);
            btnTimKiem.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnTimKiem.ForeColor = Color.Yellow;
            btnTimKiem.Location = new Point(416, 17);
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.Size = new Size(103, 30);
            btnTimKiem.TabIndex = 64;
            btnTimKiem.Text = "Tìm kiếm";
            btnTimKiem.UseVisualStyleBackColor = false;
            btnTimKiem.Click += btnTimKiem_Click;
            // 
            // cbbTimKiem
            // 
            cbbTimKiem.DropDownStyle = ComboBoxStyle.DropDownList;
            cbbTimKiem.FormattingEnabled = true;
            cbbTimKiem.Location = new Point(258, 19);
            cbbTimKiem.Name = "cbbTimKiem";
            cbbTimKiem.Size = new Size(150, 23);
            cbbTimKiem.TabIndex = 63;
            // 
            // txtTimKiem
            // 
            txtTimKiem.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtTimKiem.Location = new Point(6, 17);
            txtTimKiem.Multiline = true;
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.Size = new Size(246, 30);
            txtTimKiem.TabIndex = 62;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnKhoa_MoKhoa);
            groupBox1.Controls.Add(btnSua);
            groupBox1.Controls.Add(btnThem);
            groupBox1.Location = new Point(6, 174);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(513, 92);
            groupBox1.TabIndex = 61;
            groupBox1.TabStop = false;
            groupBox1.Text = "Chức năng";
            // 
            // btnKhoa_MoKhoa
            // 
            btnKhoa_MoKhoa.BackColor = Color.FromArgb(64, 64, 64);
            btnKhoa_MoKhoa.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnKhoa_MoKhoa.ForeColor = Color.Yellow;
            btnKhoa_MoKhoa.Location = new Point(347, 34);
            btnKhoa_MoKhoa.Name = "btnKhoa_MoKhoa";
            btnKhoa_MoKhoa.Size = new Size(124, 35);
            btnKhoa_MoKhoa.TabIndex = 13;
            btnKhoa_MoKhoa.Text = "Khóa/Mở khóa";
            btnKhoa_MoKhoa.UseVisualStyleBackColor = false;
            btnKhoa_MoKhoa.Click += btnKhoaMoKhoa_Click;
            // 
            // btnSua
            // 
            btnSua.BackColor = Color.FromArgb(64, 64, 64);
            btnSua.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnSua.ForeColor = Color.Yellow;
            btnSua.Location = new Point(195, 34);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(124, 35);
            btnSua.TabIndex = 14;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = false;
            btnSua.Click += btnSua_Click;
            // 
            // btnThem
            // 
            btnThem.BackColor = Color.FromArgb(64, 64, 64);
            btnThem.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnThem.ForeColor = Color.Yellow;
            btnThem.Location = new Point(38, 34);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(124, 35);
            btnThem.TabIndex = 15;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = false;
            btnThem.Click += btnThem_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(273, 113);
            label2.Name = "label2";
            label2.Size = new Size(41, 15);
            label2.TabIndex = 57;
            label2.Text = "Mô tả:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(6, 113);
            label3.Name = "label3";
            label3.Size = new Size(80, 15);
            label3.TabIndex = 58;
            label3.Text = "Số điện thoại:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(273, 54);
            label4.Name = "label4";
            label4.Size = new Size(39, 15);
            label4.TabIndex = 59;
            label4.Text = "Email:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(6, 50);
            label1.Name = "label1";
            label1.Size = new Size(29, 15);
            label1.TabIndex = 60;
            label1.Text = "Tên:";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(273, 72);
            txtEmail.Multiline = true;
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(261, 33);
            txtEmail.TabIndex = 54;
            // 
            // txtMoTa
            // 
            txtMoTa.Location = new Point(273, 135);
            txtMoTa.Multiline = true;
            txtMoTa.Name = "txtMoTa";
            txtMoTa.Size = new Size(246, 33);
            txtMoTa.TabIndex = 53;
            // 
            // txtSDT
            // 
            txtSDT.Location = new Point(6, 135);
            txtSDT.Multiline = true;
            txtSDT.Name = "txtSDT";
            txtSDT.Size = new Size(261, 33);
            txtSDT.TabIndex = 55;
            // 
            // txtTen
            // 
            txtTen.Location = new Point(6, 72);
            txtTen.Multiline = true;
            txtTen.Name = "txtTen";
            txtTen.Size = new Size(261, 33);
            txtTen.TabIndex = 56;
            // 
            // dgv_Objects
            // 
            dgv_Objects.BackgroundColor = SystemColors.Window;
            dgv_Objects.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_Objects.Location = new Point(6, 272);
            dgv_Objects.Name = "dgv_Objects";
            dgv_Objects.RowHeadersWidth = 51;
            dgv_Objects.RowTemplate.Height = 25;
            dgv_Objects.Size = new Size(513, 131);
            dgv_Objects.TabIndex = 52;
            dgv_Objects.CellClick += dgv_Objects_CellClick;
            // 
            // ThuongHieu_Frm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(541, 420);
            Controls.Add(btnTimKiem);
            Controls.Add(cbbTimKiem);
            Controls.Add(txtTimKiem);
            Controls.Add(groupBox1);
            Controls.Add(label2);
            Controls.Add(label3);
            Controls.Add(label4);
            Controls.Add(label1);
            Controls.Add(txtEmail);
            Controls.Add(txtMoTa);
            Controls.Add(txtSDT);
            Controls.Add(txtTen);
            Controls.Add(dgv_Objects);
            Name = "ThuongHieu_Frm";
            Text = "ThuongHieu";
            Load += ThuongHieu_Form_Load;
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgv_Objects).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnTimKiem;
        private ComboBox cbbTimKiem;
        private TextBox txtTimKiem;
        private GroupBox groupBox1;
        private Button btnKhoa_MoKhoa;
        private Button btnSua;
        private Button btnThem;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label1;
        private TextBox txtEmail;
        private TextBox txtMoTa;
        private TextBox txtSDT;
        private TextBox txtTen;
        private DataGridView dgv_Objects;
    }
}