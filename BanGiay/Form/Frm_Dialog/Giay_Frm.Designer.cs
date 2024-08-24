namespace PRL.Form
{
    partial class Giay_Frm
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
            btnSua = new Button();
            btnThem = new Button();
            btnTimKiem = new Button();
            cbbTimKiem = new ComboBox();
            txtTimKiem = new TextBox();
            label1 = new Label();
            txtTen = new TextBox();
            dgv_Objects = new DataGridView();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_Objects).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnSua);
            groupBox1.Controls.Add(btnThem);
            groupBox1.Location = new Point(14, 111);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(513, 92);
            groupBox1.TabIndex = 73;
            groupBox1.TabStop = false;
            groupBox1.Text = "Chức năng";
            // 
            // btnSua
            // 
            btnSua.BackColor = Color.FromArgb(64, 64, 64);
            btnSua.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnSua.ForeColor = Color.Yellow;
            btnSua.Location = new Point(282, 36);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(108, 39);
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
            btnThem.Location = new Point(101, 36);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(108, 39);
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
            btnTimKiem.Location = new Point(424, 17);
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.Size = new Size(103, 30);
            btnTimKiem.TabIndex = 76;
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
            cbbTimKiem.TabIndex = 75;
            // 
            // txtTimKiem
            // 
            txtTimKiem.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtTimKiem.Location = new Point(14, 17);
            txtTimKiem.Multiline = true;
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.PlaceholderText = "Tìm kiếm...";
            txtTimKiem.Size = new Size(246, 30);
            txtTimKiem.TabIndex = 74;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(14, 50);
            label1.Name = "label1";
            label1.Size = new Size(29, 15);
            label1.TabIndex = 72;
            label1.Text = "Tên:";
            // 
            // txtTen
            // 
            txtTen.Location = new Point(14, 72);
            txtTen.Multiline = true;
            txtTen.Name = "txtTen";
            txtTen.Size = new Size(513, 33);
            txtTen.TabIndex = 71;
            // 
            // dgv_Objects
            // 
            dgv_Objects.BackgroundColor = Color.White;
            dgv_Objects.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_Objects.Location = new Point(14, 209);
            dgv_Objects.Name = "dgv_Objects";
            dgv_Objects.RowHeadersWidth = 51;
            dgv_Objects.RowTemplate.Height = 25;
            dgv_Objects.Size = new Size(513, 194);
            dgv_Objects.TabIndex = 70;
            dgv_Objects.CellClick += dgv_Objects_CellClick;
            // 
            // Giay_Frm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(541, 420);
            Controls.Add(groupBox1);
            Controls.Add(btnTimKiem);
            Controls.Add(cbbTimKiem);
            Controls.Add(txtTimKiem);
            Controls.Add(label1);
            Controls.Add(txtTen);
            Controls.Add(dgv_Objects);
            Name = "Giay_Frm";
            Text = "Giay_Form";
            Load += Giay_Frm_Load;
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgv_Objects).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private Button btnSua;
        private Button btnThem;
        private Button btnTimKiem;
        private ComboBox cbbTimKiem;
        private TextBox txtTimKiem;
        private Label label1;
        private TextBox txtTen;
        private DataGridView dgv_Objects;
    }
}