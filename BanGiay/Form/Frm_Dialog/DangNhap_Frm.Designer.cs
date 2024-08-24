namespace PRL.Frm_Main
{
    partial class DangNhap_Frm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DangNhap_Frm));
            ptbTat = new PictureBox();
            txtQuenMatKhau = new Label();
            txtMatKhau = new TextBox();
            txt2 = new Label();
            txt1 = new Label();
            pictureBox1 = new PictureBox();
            btnDangnhap = new Button();
            txt4 = new Label();
            txt3 = new Label();
            txtTaiKhoan = new TextBox();
            ((System.ComponentModel.ISupportInitialize)ptbTat).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // ptbTat
            // 
            ptbTat.Cursor = Cursors.Hand;
            ptbTat.Image = BanGiay.Properties.Resources.power_switch;
            ptbTat.Location = new Point(671, 12);
            ptbTat.Name = "ptbTat";
            ptbTat.Size = new Size(34, 28);
            ptbTat.SizeMode = PictureBoxSizeMode.Zoom;
            ptbTat.TabIndex = 33;
            ptbTat.TabStop = false;
            ptbTat.Click += ptbTat_Click;
            // 
            // txtQuenMatKhau
            // 
            txtQuenMatKhau.AutoSize = true;
            txtQuenMatKhau.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            txtQuenMatKhau.ForeColor = Color.Maroon;
            txtQuenMatKhau.Location = new Point(446, 309);
            txtQuenMatKhau.Name = "txtQuenMatKhau";
            txtQuenMatKhau.Size = new Size(108, 17);
            txtQuenMatKhau.TabIndex = 42;
            txtQuenMatKhau.Text = "Quên mật khẩu?";
            txtQuenMatKhau.Click += btnQuenmk_Click;
            // 
            // txtMatKhau
            // 
            txtMatKhau.BackColor = SystemColors.Window;
            txtMatKhau.Font = new Font("Calibri", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtMatKhau.ForeColor = SystemColors.ControlText;
            txtMatKhau.Location = new Point(320, 207);
            txtMatKhau.Name = "txtMatKhau";
            txtMatKhau.PasswordChar = '*';
            txtMatKhau.Size = new Size(278, 23);
            txtMatKhau.TabIndex = 35;
            txtMatKhau.UseSystemPasswordChar = true;
            // 
            // txt2
            // 
            txt2.AutoSize = true;
            txt2.Font = new Font("Calibri", 11.25F, FontStyle.Italic, GraphicsUnit.Point);
            txt2.ForeColor = SystemColors.ControlDarkDark;
            txt2.Image = (Image)resources.GetObject("txt2.Image");
            txt2.Location = new Point(320, 70);
            txt2.Margin = new Padding(2, 0, 2, 0);
            txt2.Name = "txt2";
            txt2.Size = new Size(252, 18);
            txt2.TabIndex = 41;
            txt2.Text = "Vui lòng nhập thông tin chi tiết của bạn!";
            // 
            // txt1
            // 
            txt1.AutoSize = true;
            txt1.FlatStyle = FlatStyle.Popup;
            txt1.Font = new Font("Calibri", 30F, FontStyle.Bold, GraphicsUnit.Point);
            txt1.ForeColor = Color.Black;
            txt1.Image = (Image)resources.GetObject("txt1.Image");
            txt1.Location = new Point(312, 21);
            txt1.Margin = new Padding(2, 0, 2, 0);
            txt1.Name = "txt1";
            txt1.Size = new Size(285, 49);
            txt1.TabIndex = 40;
            txt1.Text = "Chào mừng bạn";
            txt1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(3, -1);
            pictureBox1.Margin = new Padding(2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(294, 400);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 39;
            pictureBox1.TabStop = false;
            // 
            // btnDangnhap
            // 
            btnDangnhap.BackColor = Color.FromArgb(64, 64, 64);
            btnDangnhap.FlatAppearance.BorderSize = 0;
            btnDangnhap.FlatStyle = FlatStyle.Flat;
            btnDangnhap.Font = new Font("Calibri", 18.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnDangnhap.ForeColor = Color.Yellow;
            btnDangnhap.Location = new Point(309, 257);
            btnDangnhap.Name = "btnDangnhap";
            btnDangnhap.Size = new Size(398, 49);
            btnDangnhap.TabIndex = 36;
            btnDangnhap.Text = "Đăng nhập";
            btnDangnhap.UseVisualStyleBackColor = false;
            btnDangnhap.Click += btnDangnhap_Click;
            // 
            // txt4
            // 
            txt4.AutoSize = true;
            txt4.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txt4.ForeColor = Color.Black;
            txt4.Location = new Point(320, 185);
            txt4.Name = "txt4";
            txt4.Size = new Size(79, 19);
            txt4.TabIndex = 37;
            txt4.Text = "Mật khẩu:";
            // 
            // txt3
            // 
            txt3.AutoSize = true;
            txt3.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txt3.ForeColor = Color.Black;
            txt3.Image = (Image)resources.GetObject("txt3.Image");
            txt3.Location = new Point(320, 110);
            txt3.Name = "txt3";
            txt3.Size = new Size(106, 19);
            txt3.TabIndex = 38;
            txt3.Text = "Tên tài khoản:";
            // 
            // txtTaiKhoan
            // 
            txtTaiKhoan.BackColor = SystemColors.Window;
            txtTaiKhoan.Font = new Font("Calibri", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtTaiKhoan.ForeColor = SystemColors.ControlText;
            txtTaiKhoan.Location = new Point(320, 132);
            txtTaiKhoan.Margin = new Padding(10);
            txtTaiKhoan.Multiline = true;
            txtTaiKhoan.Name = "txtTaiKhoan";
            txtTaiKhoan.Size = new Size(278, 35);
            txtTaiKhoan.TabIndex = 34;
            // 
            // DangNhap_Frm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            ClientSize = new Size(711, 398);
            Controls.Add(txtQuenMatKhau);
            Controls.Add(txtMatKhau);
            Controls.Add(txt2);
            Controls.Add(txt1);
            Controls.Add(pictureBox1);
            Controls.Add(btnDangnhap);
            Controls.Add(txt4);
            Controls.Add(txt3);
            Controls.Add(txtTaiKhoan);
            Controls.Add(ptbTat);
            FormBorderStyle = FormBorderStyle.None;
            Name = "DangNhap_Frm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "DangNhap_Form";
            Load += DangNhap_Frm_Load;
            ((System.ComponentModel.ISupportInitialize)ptbTat).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox ptbTat;
        private Label txtQuenMatKhau;
        private TextBox txtMatKhau;
        private Label txt2;
        private Label txt1;
        private PictureBox pictureBox1;
        private Button btnDangnhap;
        private Label txt4;
        private Label txt3;
        private TextBox txtTaiKhoan;
    }
}