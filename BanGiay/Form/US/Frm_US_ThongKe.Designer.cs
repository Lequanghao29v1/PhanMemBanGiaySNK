namespace BanGiay.Form.US
{
    partial class Frm_US_ThongKe
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
            panel3 = new Panel();
            lbTongSP = new Label();
            label6 = new Label();
            panel2 = new Panel();
            lbTonghoadon = new Label();
            label8 = new Label();
            panel1 = new Panel();
            lbTongtien = new Label();
            label4 = new Label();
            groupBox2 = new GroupBox();
            btnTimkiem = new Button();
            dateketthuc = new DateTimePicker();
            label2 = new Label();
            datebatdau = new DateTimePicker();
            label1 = new Label();
            groupBox3 = new GroupBox();
            dgvSP_BanChay = new DataGridView();
            groupBox1.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSP_BanChay).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.FromArgb(64, 79, 105);
            groupBox1.Controls.Add(panel3);
            groupBox1.Controls.Add(panel2);
            groupBox1.Controls.Add(panel1);
            groupBox1.Dock = DockStyle.Top;
            groupBox1.ForeColor = Color.White;
            groupBox1.Location = new Point(0, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1094, 166);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thống kê";
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(64, 64, 64);
            panel3.Controls.Add(lbTongSP);
            panel3.Controls.Add(label6);
            panel3.Dock = DockStyle.Fill;
            panel3.ForeColor = Color.Yellow;
            panel3.Location = new Point(353, 19);
            panel3.Name = "panel3";
            panel3.Size = new Size(377, 144);
            panel3.TabIndex = 2;
            // 
            // lbTongSP
            // 
            lbTongSP.Anchor = AnchorStyles.None;
            lbTongSP.AutoSize = true;
            lbTongSP.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lbTongSP.Location = new Point(171, 79);
            lbTongSP.Name = "lbTongSP";
            lbTongSP.Size = new Size(35, 32);
            lbTongSP.TabIndex = 1;
            lbTongSP.Text = "...";
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.None;
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(93, 33);
            label6.Name = "label6";
            label6.Size = new Size(190, 32);
            label6.TabIndex = 2;
            label6.Text = "Tổng sản phẩm";
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(64, 64, 64);
            panel2.Controls.Add(lbTonghoadon);
            panel2.Controls.Add(label8);
            panel2.Dock = DockStyle.Right;
            panel2.ForeColor = Color.Yellow;
            panel2.Location = new Point(730, 19);
            panel2.Name = "panel2";
            panel2.Size = new Size(361, 144);
            panel2.TabIndex = 1;
            // 
            // lbTonghoadon
            // 
            lbTonghoadon.AutoSize = true;
            lbTonghoadon.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lbTonghoadon.Location = new Point(163, 79);
            lbTonghoadon.Name = "lbTonghoadon";
            lbTonghoadon.Size = new Size(35, 32);
            lbTonghoadon.TabIndex = 1;
            lbTonghoadon.Text = "...";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(93, 33);
            label8.Name = "label8";
            label8.Size = new Size(174, 32);
            label8.TabIndex = 2;
            label8.Text = "Tổng hóa đơn";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(64, 64, 64);
            panel1.Controls.Add(lbTongtien);
            panel1.Controls.Add(label4);
            panel1.Dock = DockStyle.Left;
            panel1.ForeColor = Color.Yellow;
            panel1.Location = new Point(3, 19);
            panel1.Name = "panel1";
            panel1.Size = new Size(350, 144);
            panel1.TabIndex = 0;
            // 
            // lbTongtien
            // 
            lbTongtien.AutoSize = true;
            lbTongtien.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lbTongtien.Location = new Point(154, 79);
            lbTongtien.Name = "lbTongtien";
            lbTongtien.Size = new Size(35, 32);
            lbTongtien.TabIndex = 1;
            lbTongtien.Text = "...";
            lbTongtien.Click += lbTongtien_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(113, 33);
            label4.Name = "label4";
            label4.Size = new Size(124, 32);
            label4.TabIndex = 2;
            label4.Text = "Tổng tiền";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnTimkiem);
            groupBox2.Controls.Add(dateketthuc);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(datebatdau);
            groupBox2.Controls.Add(label1);
            groupBox2.Dock = DockStyle.Top;
            groupBox2.Location = new Point(0, 166);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1094, 87);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Tìm kiếm";
            // 
            // btnTimkiem
            // 
            btnTimkiem.BackColor = Color.FromArgb(64, 64, 64);
            btnTimkiem.FlatAppearance.BorderSize = 0;
            btnTimkiem.FlatAppearance.MouseDownBackColor = Color.FromArgb(69, 97, 120);
            btnTimkiem.FlatStyle = FlatStyle.Flat;
            btnTimkiem.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnTimkiem.ForeColor = Color.Yellow;
            btnTimkiem.Location = new Point(866, 22);
            btnTimkiem.Name = "btnTimkiem";
            btnTimkiem.Size = new Size(131, 52);
            btnTimkiem.TabIndex = 6;
            btnTimkiem.Text = "Tìm kiếm";
            btnTimkiem.UseVisualStyleBackColor = false;
            btnTimkiem.Click += btnTimkiem_Click;
            // 
            // dateketthuc
            // 
            dateketthuc.Location = new Point(641, 36);
            dateketthuc.Name = "dateketthuc";
            dateketthuc.Size = new Size(200, 23);
            dateketthuc.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(608, 39);
            label2.Name = "label2";
            label2.Size = new Size(27, 15);
            label2.TabIndex = 2;
            label2.Text = "đến";
            // 
            // datebatdau
            // 
            datebatdau.Location = new Point(374, 36);
            datebatdau.Name = "datebatdau";
            datebatdau.Size = new Size(200, 23);
            datebatdau.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(333, 39);
            label1.Name = "label1";
            label1.Size = new Size(35, 15);
            label1.TabIndex = 3;
            label1.Text = "Ngày";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(dgvSP_BanChay);
            groupBox3.Dock = DockStyle.Fill;
            groupBox3.Location = new Point(0, 253);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(1094, 480);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Text = "Top sản phẩm bán chạy";
            // 
            // dgvSP_BanChay
            // 
            dgvSP_BanChay.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvSP_BanChay.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSP_BanChay.Dock = DockStyle.Fill;
            dgvSP_BanChay.Location = new Point(3, 19);
            dgvSP_BanChay.Name = "dgvSP_BanChay";
            dgvSP_BanChay.RowTemplate.Height = 25;
            dgvSP_BanChay.Size = new Size(1088, 458);
            dgvSP_BanChay.TabIndex = 0;
            // 
            // Frm_US_ThongKe
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Frm_US_ThongKe";
            Size = new Size(1094, 733);
            groupBox1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvSP_BanChay).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Panel panel3;
        private Label lbTongSP;
        private Label label6;
        private Panel panel2;
        private Label lbTonghoadon;
        private Label label8;
        private Panel panel1;
        private Label lbTongtien;
        private Label label4;
        private GroupBox groupBox2;
        private Button btnTimkiem;
        private DateTimePicker dateketthuc;
        private Label label2;
        private DateTimePicker datebatdau;
        private Label label1;
        private GroupBox groupBox3;
        private DataGridView dgvSP_BanChay;
    }
}
