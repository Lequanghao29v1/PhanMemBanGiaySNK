namespace PRL
{
    partial class HinhThucThanhToan
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
            txtTimkiem = new TextBox();
            label3 = new Label();
            btnLammoi = new Button();
            btnSua = new Button();
            btnThem = new Button();
            dataGridView1 = new DataGridView();
            txtMota = new RichTextBox();
            txtTen = new TextBox();
            label2 = new Label();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // txtTimkiem
            // 
            txtTimkiem.Location = new Point(188, 21);
            txtTimkiem.Margin = new Padding(3, 2, 3, 2);
            txtTimkiem.Multiline = true;
            txtTimkiem.Name = "txtTimkiem";
            txtTimkiem.Size = new Size(252, 30);
            txtTimkiem.TabIndex = 20;
            txtTimkiem.TextChanged += txtTimkiem_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(99, 23);
            label3.Name = "label3";
            label3.Size = new Size(57, 15);
            label3.TabIndex = 19;
            label3.Text = "Tìm kiếm";
            // 
            // btnLammoi
            // 
            btnLammoi.BackColor = Color.FromArgb(64, 64, 64);
            btnLammoi.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnLammoi.ForeColor = Color.Yellow;
            btnLammoi.Location = new Point(510, 118);
            btnLammoi.Margin = new Padding(3, 2, 3, 2);
            btnLammoi.Name = "btnLammoi";
            btnLammoi.Size = new Size(92, 33);
            btnLammoi.TabIndex = 18;
            btnLammoi.Text = "Làm mới";
            btnLammoi.UseVisualStyleBackColor = false;
            btnLammoi.Click += btnLammoi_Click;
            // 
            // btnSua
            // 
            btnSua.BackColor = Color.FromArgb(64, 64, 64);
            btnSua.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnSua.ForeColor = Color.Yellow;
            btnSua.Location = new Point(510, 72);
            btnSua.Margin = new Padding(3, 2, 3, 2);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(92, 33);
            btnSua.TabIndex = 17;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = false;
            btnSua.Click += btnSua_Click;
            // 
            // btnThem
            // 
            btnThem.BackColor = Color.FromArgb(64, 64, 64);
            btnThem.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnThem.ForeColor = Color.Yellow;
            btnThem.Location = new Point(510, 21);
            btnThem.Margin = new Padding(3, 2, 3, 2);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(92, 33);
            btnThem.TabIndex = 16;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = false;
            btnThem.Click += btnThem_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.Window;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(98, 177);
            dataGridView1.Margin = new Padding(3, 2, 3, 2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(504, 141);
            dataGridView1.TabIndex = 15;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // txtMota
            // 
            txtMota.Location = new Point(188, 90);
            txtMota.Margin = new Padding(3, 2, 3, 2);
            txtMota.Name = "txtMota";
            txtMota.Size = new Size(252, 74);
            txtMota.TabIndex = 14;
            txtMota.Text = "";
            // 
            // txtTen
            // 
            txtTen.Location = new Point(188, 53);
            txtTen.Margin = new Padding(3, 2, 3, 2);
            txtTen.Multiline = true;
            txtTen.Name = "txtTen";
            txtTen.Size = new Size(252, 30);
            txtTen.TabIndex = 13;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(99, 90);
            label2.Name = "label2";
            label2.Size = new Size(38, 15);
            label2.TabIndex = 12;
            label2.Text = "Mô tả";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(98, 55);
            label1.Name = "label1";
            label1.Size = new Size(80, 15);
            label1.TabIndex = 11;
            label1.Text = "Tên hình thức";
            // 
            // HinhThucThanhToan
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 338);
            Controls.Add(txtTimkiem);
            Controls.Add(label3);
            Controls.Add(btnLammoi);
            Controls.Add(btnSua);
            Controls.Add(btnThem);
            Controls.Add(dataGridView1);
            Controls.Add(txtMota);
            Controls.Add(txtTen);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "HinhThucThanhToan";
            Text = "HinhThucThanhToan";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtTimkiem;
        private Label label3;
        private Button btnLammoi;
        private Button btnSua;
        private Button btnThem;
        private DataGridView dataGridView1;
        private RichTextBox txtMota;
        private TextBox txtTen;
        private Label label2;
        private Label label1;
    }
}