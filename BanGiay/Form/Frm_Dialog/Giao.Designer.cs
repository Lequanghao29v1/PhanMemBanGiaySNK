namespace PRL
{
    partial class Giao
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
            dataGridView1 = new DataGridView();
            btnlammoi = new Button();
            btnsua = new Button();
            txtTimkiem = new TextBox();
            label4 = new Label();
            btnthem = new Button();
            dateketthuc = new DateTimePicker();
            datebatdau = new DateTimePicker();
            txtTenca = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.Window;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(123, 183);
            dataGridView1.Margin = new Padding(3, 2, 3, 2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(494, 141);
            dataGridView1.TabIndex = 23;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // btnlammoi
            // 
            btnlammoi.BackColor = Color.FromArgb(64, 64, 64);
            btnlammoi.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnlammoi.ForeColor = Color.Yellow;
            btnlammoi.Location = new Point(510, 114);
            btnlammoi.Margin = new Padding(3, 2, 3, 2);
            btnlammoi.Name = "btnlammoi";
            btnlammoi.Size = new Size(108, 39);
            btnlammoi.TabIndex = 22;
            btnlammoi.Text = "Làm mới";
            btnlammoi.UseVisualStyleBackColor = false;
            btnlammoi.Click += btnlammoi_Click;
            // 
            // btnsua
            // 
            btnsua.BackColor = Color.FromArgb(64, 64, 64);
            btnsua.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnsua.ForeColor = Color.Yellow;
            btnsua.Location = new Point(510, 70);
            btnsua.Margin = new Padding(3, 2, 3, 2);
            btnsua.Name = "btnsua";
            btnsua.Size = new Size(108, 39);
            btnsua.TabIndex = 21;
            btnsua.Text = "Sửa";
            btnsua.UseVisualStyleBackColor = false;
            btnsua.Click += btnsua_Click;
            // 
            // txtTimkiem
            // 
            txtTimkiem.Location = new Point(167, 15);
            txtTimkiem.Margin = new Padding(3, 2, 3, 2);
            txtTimkiem.Multiline = true;
            txtTimkiem.Name = "txtTimkiem";
            txtTimkiem.Size = new Size(261, 33);
            txtTimkiem.TabIndex = 20;
            txtTimkiem.TextChanged += txtTimkiem_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(82, 25);
            label4.Name = "label4";
            label4.Size = new Size(57, 15);
            label4.TabIndex = 19;
            label4.Text = "Tìm kiếm";
            // 
            // btnthem
            // 
            btnthem.BackColor = Color.FromArgb(64, 64, 64);
            btnthem.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnthem.ForeColor = Color.Yellow;
            btnthem.Location = new Point(510, 27);
            btnthem.Margin = new Padding(3, 2, 3, 2);
            btnthem.Name = "btnthem";
            btnthem.Size = new Size(108, 39);
            btnthem.TabIndex = 18;
            btnthem.Text = "Thêm";
            btnthem.UseVisualStyleBackColor = false;
            btnthem.Click += btnthem_Click;
            // 
            // dateketthuc
            // 
            dateketthuc.Location = new Point(167, 138);
            dateketthuc.Margin = new Padding(3, 2, 3, 2);
            dateketthuc.Name = "dateketthuc";
            dateketthuc.Size = new Size(261, 23);
            dateketthuc.TabIndex = 17;
            // 
            // datebatdau
            // 
            datebatdau.Location = new Point(167, 100);
            datebatdau.Margin = new Padding(3, 2, 3, 2);
            datebatdau.Name = "datebatdau";
            datebatdau.Size = new Size(261, 23);
            datebatdau.TabIndex = 16;
            // 
            // txtTenca
            // 
            txtTenca.Location = new Point(167, 53);
            txtTenca.Margin = new Padding(3, 2, 3, 2);
            txtTenca.Multiline = true;
            txtTenca.Name = "txtTenca";
            txtTenca.Size = new Size(261, 33);
            txtTenca.TabIndex = 15;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(82, 138);
            label3.Name = "label3";
            label3.Size = new Size(51, 15);
            label3.TabIndex = 14;
            label3.Text = "Kết thúc";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(82, 104);
            label2.Name = "label2";
            label2.Size = new Size(47, 15);
            label2.TabIndex = 13;
            label2.Text = "Bắt đầu";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(82, 62);
            label1.Name = "label1";
            label1.Size = new Size(41, 15);
            label1.TabIndex = 12;
            label1.Text = "Tên ca";
            // 
            // Giao
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 338);
            Controls.Add(dataGridView1);
            Controls.Add(btnlammoi);
            Controls.Add(btnsua);
            Controls.Add(txtTimkiem);
            Controls.Add(label4);
            Controls.Add(btnthem);
            Controls.Add(dateketthuc);
            Controls.Add(datebatdau);
            Controls.Add(txtTenca);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Giao";
            Text = "Giaoca";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Button btnlammoi;
        private Button btnsua;
        private TextBox txtTimkiem;
        private Label label4;
        private Button btnthem;
        private DateTimePicker dateketthuc;
        private DateTimePicker datebatdau;
        private TextBox txtTenca;
        private Label label3;
        private Label label2;
        private Label label1;
    }
}