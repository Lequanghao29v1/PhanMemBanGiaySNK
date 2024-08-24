namespace BanGiay.Form.US
{
    partial class Frm_US_HoaDon
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
            btnExcel = new Button();
            cmbTimkiem = new ComboBox();
            label2 = new Label();
            label1 = new Label();
            cmbloaitt = new ComboBox();
            txtTimkiem = new TextBox();
            groupBox2 = new GroupBox();
            dgvHDCT = new DataGridView();
            groupBox3 = new GroupBox();
            dgvHD = new DataGridView();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvHDCT).BeginInit();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvHD).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnExcel);
            groupBox1.Controls.Add(cmbTimkiem);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(cmbloaitt);
            groupBox1.Controls.Add(txtTimkiem);
            groupBox1.Dock = DockStyle.Top;
            groupBox1.Location = new Point(0, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1094, 117);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Tìm kiếm";
            // 
            // btnExcel
            // 
            btnExcel.BackColor = Color.Green;
            btnExcel.Cursor = Cursors.Hand;
            btnExcel.FlatAppearance.BorderSize = 0;
            btnExcel.FlatAppearance.MouseDownBackColor = Color.FromArgb(69, 97, 120);
            btnExcel.FlatStyle = FlatStyle.Flat;
            btnExcel.ForeColor = Color.White;
            btnExcel.Location = new Point(535, 60);
            btnExcel.Margin = new Padding(3, 2, 3, 2);
            btnExcel.Name = "btnExcel";
            btnExcel.Size = new Size(84, 43);
            btnExcel.TabIndex = 16;
            btnExcel.Text = "Excel";
            btnExcel.UseVisualStyleBackColor = false;
            btnExcel.Click += btnExcel_Click;
            // 
            // cmbTimkiem
            // 
            cmbTimkiem.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbTimkiem.FormattingEnabled = true;
            cmbTimkiem.Location = new Point(497, 23);
            cmbTimkiem.Margin = new Padding(3, 2, 3, 2);
            cmbTimkiem.Name = "cmbTimkiem";
            cmbTimkiem.Size = new Size(133, 23);
            cmbTimkiem.TabIndex = 15;
            cmbTimkiem.SelectedIndexChanged += cmbTimkiem_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(14, 81);
            label2.Name = "label2";
            label2.Size = new Size(101, 17);
            label2.TabIndex = 13;
            label2.Text = "Loại thanh toán:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(14, 27);
            label1.Name = "label1";
            label1.Size = new Size(63, 17);
            label1.TabIndex = 14;
            label1.Text = "Tìm kiếm:";
            // 
            // cmbloaitt
            // 
            cmbloaitt.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbloaitt.FormattingEnabled = true;
            cmbloaitt.Location = new Point(138, 80);
            cmbloaitt.Name = "cmbloaitt";
            cmbloaitt.Size = new Size(150, 23);
            cmbloaitt.TabIndex = 12;
            cmbloaitt.SelectedIndexChanged += cmbloaitt_SelectedIndexChanged;
            // 
            // txtTimkiem
            // 
            txtTimkiem.BorderStyle = BorderStyle.FixedSingle;
            txtTimkiem.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtTimkiem.Location = new Point(104, 22);
            txtTimkiem.Multiline = true;
            txtTimkiem.Name = "txtTimkiem";
            txtTimkiem.Size = new Size(380, 30);
            txtTimkiem.TabIndex = 11;
            txtTimkiem.TextChanged += txtTimkiem_TextChanged;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dgvHDCT);
            groupBox2.Dock = DockStyle.Bottom;
            groupBox2.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox2.Location = new Point(0, 517);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1094, 216);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Hóa đơn chi tiết";
            // 
            // dgvHDCT
            // 
            dgvHDCT.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvHDCT.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvHDCT.Dock = DockStyle.Fill;
            dgvHDCT.Location = new Point(3, 21);
            dgvHDCT.Name = "dgvHDCT";
            dgvHDCT.RowTemplate.Height = 25;
            dgvHDCT.Size = new Size(1088, 192);
            dgvHDCT.TabIndex = 0;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(dgvHD);
            groupBox3.Dock = DockStyle.Fill;
            groupBox3.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox3.Location = new Point(0, 117);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(1094, 400);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Text = "Hóa đơn";
            // 
            // dgvHD
            // 
            dgvHD.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            dgvHD.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvHD.Dock = DockStyle.Fill;
            dgvHD.Location = new Point(3, 21);
            dgvHD.Name = "dgvHD";
            dgvHD.RowTemplate.Height = 25;
            dgvHD.Size = new Size(1088, 376);
            dgvHD.TabIndex = 0;
            dgvHD.CellClick += dtgHoadon_CellClick;
            // 
            // Frm_US_HoaDon
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Frm_US_HoaDon";
            Size = new Size(1094, 733);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvHDCT).EndInit();
            groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvHD).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Button btnExcel;
        private ComboBox cmbTimkiem;
        private Label label2;
        private Label label1;
        private ComboBox cmbloaitt;
        private TextBox txtTimkiem;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private DataGridView dgvHDCT;
        private DataGridView dgvHD;
    }
}
