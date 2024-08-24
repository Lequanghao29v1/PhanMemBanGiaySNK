namespace PRL
{
    partial class KichCo_Frm
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
            txtMoTa = new TextBox();
            btnSua = new Button();
            txtTimKiem = new TextBox();
            dgv_Objects = new DataGridView();
            btnThem = new Button();
            groupBox1 = new GroupBox();
            btnKhoa_MoKhoa = new Button();
            label2 = new Label();
            label1 = new Label();
            txtTen = new TextBox();
            btnTimKiem = new Button();
            cbbTimKiem = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dgv_Objects).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // txtMoTa
            // 
            txtMoTa.Location = new Point(281, 72);
            txtMoTa.Multiline = true;
            txtMoTa.Name = "txtMoTa";
            txtMoTa.Size = new Size(246, 33);
            txtMoTa.TabIndex = 62;
            // 
            // btnSua
            // 
            btnSua.BackColor = Color.FromArgb(64, 64, 64);
            btnSua.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnSua.ForeColor = Color.Yellow;
            btnSua.Location = new Point(187, 32);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(124, 35);
            btnSua.TabIndex = 14;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = false;
            btnSua.Click += btnSua_Click;
            // 
            // txtTimKiem
            // 
            txtTimKiem.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtTimKiem.Location = new Point(14, 17);
            txtTimKiem.Multiline = true;
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.PlaceholderText = "Tìm kiếm...";
            txtTimKiem.Size = new Size(246, 30);
            txtTimKiem.TabIndex = 67;
            // 
            // dgv_Objects
            // 
            dgv_Objects.BackgroundColor = SystemColors.Window;
            dgv_Objects.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_Objects.Location = new Point(14, 209);
            dgv_Objects.Name = "dgv_Objects";
            dgv_Objects.RowHeadersWidth = 51;
            dgv_Objects.RowTemplate.Height = 25;
            dgv_Objects.Size = new Size(513, 194);
            dgv_Objects.TabIndex = 61;
            dgv_Objects.CellClick += dgv_Objects_CellClick;
            // 
            // btnThem
            // 
            btnThem.BackColor = Color.FromArgb(64, 64, 64);
            btnThem.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnThem.ForeColor = Color.Yellow;
            btnThem.Location = new Point(32, 32);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(124, 35);
            btnThem.TabIndex = 15;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = false;
            btnThem.Click += btnThem_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnKhoa_MoKhoa);
            groupBox1.Controls.Add(btnSua);
            groupBox1.Controls.Add(btnThem);
            groupBox1.Location = new Point(14, 111);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(513, 92);
            groupBox1.TabIndex = 66;
            groupBox1.TabStop = false;
            groupBox1.Text = "Chức năng";
            // 
            // btnKhoa_MoKhoa
            // 
            btnKhoa_MoKhoa.BackColor = Color.FromArgb(64, 64, 64);
            btnKhoa_MoKhoa.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnKhoa_MoKhoa.ForeColor = Color.Yellow;
            btnKhoa_MoKhoa.Location = new Point(350, 32);
            btnKhoa_MoKhoa.Name = "btnKhoa_MoKhoa";
            btnKhoa_MoKhoa.Size = new Size(124, 35);
            btnKhoa_MoKhoa.TabIndex = 13;
            btnKhoa_MoKhoa.Text = "Khóa/Mở khóa";
            btnKhoa_MoKhoa.UseVisualStyleBackColor = false;
            btnKhoa_MoKhoa.Click += btnKhoaMoKhoa_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(281, 50);
            label2.Name = "label2";
            label2.Size = new Size(41, 15);
            label2.TabIndex = 64;
            label2.Text = "Mô tả:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(14, 50);
            label1.Name = "label1";
            label1.Size = new Size(29, 15);
            label1.TabIndex = 65;
            label1.Text = "Tên:";
            // 
            // txtTen
            // 
            txtTen.Location = new Point(14, 72);
            txtTen.Multiline = true;
            txtTen.Name = "txtTen";
            txtTen.Size = new Size(261, 33);
            txtTen.TabIndex = 63;
            // 
            // btnTimKiem
            // 
            btnTimKiem.BackColor = Color.FromArgb(64, 64, 64);
            btnTimKiem.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnTimKiem.ForeColor = Color.Yellow;
            btnTimKiem.Location = new Point(424, 17);
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.Size = new Size(103, 30);
            btnTimKiem.TabIndex = 69;
            btnTimKiem.Text = "Tìm kiếm";
            btnTimKiem.UseVisualStyleBackColor = false;
            btnTimKiem.Click += btnTimKiem_Click;
            // 
            // cbbTimKiem
            // 
            cbbTimKiem.DropDownStyle = ComboBoxStyle.DropDownList;
            cbbTimKiem.FormattingEnabled = true;
            cbbTimKiem.Location = new Point(266, 19);
            cbbTimKiem.Name = "cbbTimKiem";
            cbbTimKiem.Size = new Size(150, 23);
            cbbTimKiem.TabIndex = 68;
            // 
            // KichCo_Frm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(541, 420);
            Controls.Add(txtMoTa);
            Controls.Add(txtTimKiem);
            Controls.Add(dgv_Objects);
            Controls.Add(groupBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtTen);
            Controls.Add(btnTimKiem);
            Controls.Add(cbbTimKiem);
            Name = "KichCo_Frm";
            Text = "KichCo";
            Load += KichCo_Form_Load;
            ((System.ComponentModel.ISupportInitialize)dgv_Objects).EndInit();
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtMoTa;
        private Button btnSua;
        private TextBox txtTimKiem;
        private DataGridView dgv_Objects;
        private Button btnThem;
        private GroupBox groupBox1;
        private Button btnKhoa_MoKhoa;
        private Label label2;
        private Label label1;
        private TextBox txtTen;
        private Button btnTimKiem;
        private ComboBox cbbTimKiem;
    }
}