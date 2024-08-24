namespace PRL.Frm_Main
{
    partial class TimKhachhang_Frm
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
            groupBox1 = new GroupBox();
            btnChon = new Button();
            btnThem = new Button();
            btnTimKiem = new Button();
            txtTimKiem = new TextBox();
            label2 = new Label();
            label1 = new Label();
            txtSdt = new TextBox();
            txtTen = new TextBox();
            dgv_Objects = new DataGridView();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_Objects).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnChon);
            groupBox1.Controls.Add(btnThem);
            groupBox1.Location = new Point(14, 105);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(513, 92);
            groupBox1.TabIndex = 82;
            groupBox1.TabStop = false;
            groupBox1.Text = "Chức năng";
            // 
            // btnChon
            // 
            btnChon.BackColor = Color.FromArgb(64, 64, 64);
            btnChon.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnChon.ForeColor = Color.Yellow;
            btnChon.Location = new Point(281, 15);
            btnChon.Name = "btnChon";
            btnChon.Size = new Size(165, 71);
            btnChon.TabIndex = 14;
            btnChon.Text = "Chọn";
            btnChon.UseVisualStyleBackColor = false;
            btnChon.Click += btnChon_Click;
            // 
            // btnThem
            // 
            btnThem.BackColor = Color.FromArgb(64, 64, 64);
            btnThem.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnThem.ForeColor = Color.Yellow;
            btnThem.Location = new Point(66, 15);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(165, 71);
            btnThem.TabIndex = 15;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = false;
            btnThem.Click += btnThem_Click;
            // 
            // btnTimKiem
            // 
            btnTimKiem.BackColor = Color.FromArgb(64, 64, 64);
            btnTimKiem.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnTimKiem.ForeColor = Color.Yellow;
            btnTimKiem.Location = new Point(424, 11);
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.Size = new Size(103, 30);
            btnTimKiem.TabIndex = 84;
            btnTimKiem.Text = "Tìm kiếm";
            btnTimKiem.UseVisualStyleBackColor = false;
            btnTimKiem.Click += btnTimKiem_Click;
            // 
            // txtTimKiem
            // 
            txtTimKiem.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtTimKiem.Location = new Point(14, 11);
            txtTimKiem.Multiline = true;
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.PlaceholderText = "Tìm kiếm số điện thoại...";
            txtTimKiem.Size = new Size(404, 30);
            txtTimKiem.TabIndex = 83;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(266, 44);
            label2.Name = "label2";
            label2.Size = new Size(80, 15);
            label2.TabIndex = 80;
            label2.Text = "Số điện thoại:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(14, 44);
            label1.Name = "label1";
            label1.Size = new Size(29, 15);
            label1.TabIndex = 81;
            label1.Text = "Tên:";
            // 
            // txtSdt
            // 
            txtSdt.Location = new Point(266, 66);
            txtSdt.Multiline = true;
            txtSdt.Name = "txtSdt";
            txtSdt.Size = new Size(261, 33);
            txtSdt.TabIndex = 78;
            // 
            // txtTen
            // 
            txtTen.Location = new Point(14, 66);
            txtTen.Multiline = true;
            txtTen.Name = "txtTen";
            txtTen.Size = new Size(246, 33);
            txtTen.TabIndex = 79;
            // 
            // dgv_Objects
            // 
            dgv_Objects.BackgroundColor = SystemColors.Window;
            dgv_Objects.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_Objects.Location = new Point(14, 203);
            dgv_Objects.Name = "dgv_Objects";
            dgv_Objects.RowHeadersWidth = 51;
            dgv_Objects.RowTemplate.Height = 25;
            dgv_Objects.Size = new Size(513, 194);
            dgv_Objects.TabIndex = 77;
            dgv_Objects.CellClick += dgv_Objects_CellClick;
            // 
            // TimKhachhang_Frm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(541, 408);
            Controls.Add(groupBox1);
            Controls.Add(btnTimKiem);
            Controls.Add(txtTimKiem);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtSdt);
            Controls.Add(txtTen);
            Controls.Add(dgv_Objects);
            Name = "TimKhachhang_Frm";
            Text = "TimKhachhang_Frm";
            Load += TimKhachhang_Frm_Load;
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgv_Objects).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private Button btnChon;
        private Button btnThem;
        private Button btnTimKiem;
        private TextBox txtTimKiem;
        private Label label2;
        private Label label1;
        private TextBox txtSdt;
        private TextBox txtTen;
        private DataGridView dgv_Objects;
    }
}