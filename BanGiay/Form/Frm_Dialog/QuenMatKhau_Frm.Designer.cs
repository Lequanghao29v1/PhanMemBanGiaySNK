namespace PRL.Frm_Main
{
    partial class QuenMatKhau_Frm
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
            groupXacNhan = new GroupBox();
            btnXacNhan_MaXacMinh = new Button();
            btnGuiMa = new Button();
            txtMaXacMinh = new TextBox();
            label3 = new Label();
            txtEmail = new TextBox();
            label2 = new Label();
            label1 = new Label();
            groupBox2 = new GroupBox();
            btnXacNhan_DoiMatKhau = new Button();
            txtMatKhauMoi_2 = new TextBox();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            txtMatKhauMoi_1 = new TextBox();
            groupXacNhan.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupXacNhan
            // 
            groupXacNhan.Controls.Add(btnXacNhan_MaXacMinh);
            groupXacNhan.Controls.Add(btnGuiMa);
            groupXacNhan.Controls.Add(txtMaXacMinh);
            groupXacNhan.Controls.Add(label3);
            groupXacNhan.Controls.Add(txtEmail);
            groupXacNhan.Controls.Add(label2);
            groupXacNhan.Controls.Add(label1);
            groupXacNhan.Location = new Point(11, 12);
            groupXacNhan.Name = "groupXacNhan";
            groupXacNhan.Size = new Size(363, 368);
            groupXacNhan.TabIndex = 1;
            groupXacNhan.TabStop = false;
            // 
            // btnXacNhan_MaXacMinh
            // 
            btnXacNhan_MaXacMinh.BackColor = Color.FromArgb(64, 64, 64);
            btnXacNhan_MaXacMinh.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnXacNhan_MaXacMinh.ForeColor = Color.Yellow;
            btnXacNhan_MaXacMinh.Location = new Point(219, 242);
            btnXacNhan_MaXacMinh.Name = "btnXacNhan_MaXacMinh";
            btnXacNhan_MaXacMinh.Size = new Size(120, 40);
            btnXacNhan_MaXacMinh.TabIndex = 3;
            btnXacNhan_MaXacMinh.Text = "Xác nhận";
            btnXacNhan_MaXacMinh.UseVisualStyleBackColor = false;
            btnXacNhan_MaXacMinh.Click += btnXacNhan_MaXacMinh_Click;
            // 
            // btnGuiMa
            // 
            btnGuiMa.BackColor = Color.FromArgb(64, 64, 64);
            btnGuiMa.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnGuiMa.ForeColor = Color.Yellow;
            btnGuiMa.Location = new Point(219, 122);
            btnGuiMa.Name = "btnGuiMa";
            btnGuiMa.Size = new Size(120, 40);
            btnGuiMa.TabIndex = 1;
            btnGuiMa.Text = "Gửi mã";
            btnGuiMa.UseVisualStyleBackColor = false;
            btnGuiMa.Click += btnGuiMa_Click;
            // 
            // txtMaXacMinh
            // 
            txtMaXacMinh.Location = new Point(21, 202);
            txtMaXacMinh.Multiline = true;
            txtMaXacMinh.Name = "txtMaXacMinh";
            txtMaXacMinh.Size = new Size(318, 34);
            txtMaXacMinh.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(21, 184);
            label3.Name = "label3";
            label3.Size = new Size(240, 15);
            label3.TabIndex = 0;
            label3.Text = "Nhập mã xác nhận đã được gửi trong email:";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(21, 82);
            txtEmail.Multiline = true;
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(318, 34);
            txtEmail.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(21, 64);
            label2.Name = "label2";
            label2.Size = new Size(116, 15);
            label2.TabIndex = 0;
            label2.Text = "Nhập Email của bạn:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(90, 19);
            label1.Name = "label1";
            label1.Size = new Size(175, 25);
            label1.TabIndex = 0;
            label1.Text = "Xác nhận thông tin";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnXacNhan_DoiMatKhau);
            groupBox2.Controls.Add(txtMatKhauMoi_2);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(txtMatKhauMoi_1);
            groupBox2.Location = new Point(380, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(363, 368);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            // 
            // btnXacNhan_DoiMatKhau
            // 
            btnXacNhan_DoiMatKhau.BackColor = Color.FromArgb(64, 64, 64);
            btnXacNhan_DoiMatKhau.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnXacNhan_DoiMatKhau.ForeColor = Color.Yellow;
            btnXacNhan_DoiMatKhau.Location = new Point(218, 196);
            btnXacNhan_DoiMatKhau.Name = "btnXacNhan_DoiMatKhau";
            btnXacNhan_DoiMatKhau.Size = new Size(120, 40);
            btnXacNhan_DoiMatKhau.TabIndex = 6;
            btnXacNhan_DoiMatKhau.Text = "Xác nhận";
            btnXacNhan_DoiMatKhau.UseVisualStyleBackColor = false;
            btnXacNhan_DoiMatKhau.Click += btnXacNhan_DoiMatKhau_Click;
            // 
            // txtMatKhauMoi_2
            // 
            txtMatKhauMoi_2.Location = new Point(20, 156);
            txtMatKhauMoi_2.Multiline = true;
            txtMatKhauMoi_2.Name = "txtMatKhauMoi_2";
            txtMatKhauMoi_2.PasswordChar = '*';
            txtMatKhauMoi_2.Size = new Size(318, 34);
            txtMatKhauMoi_2.TabIndex = 5;
            txtMatKhauMoi_2.UseSystemPasswordChar = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(132, 19);
            label4.Name = "label4";
            label4.Size = new Size(128, 25);
            label4.TabIndex = 0;
            label4.Text = "Đổi mật khẩu";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(20, 64);
            label5.Name = "label5";
            label5.Size = new Size(161, 15);
            label5.TabIndex = 0;
            label5.Text = "Nhập mật khẩu mới của bạn:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(20, 138);
            label6.Name = "label6";
            label6.Size = new Size(151, 15);
            label6.TabIndex = 0;
            label6.Text = "Xác nhận lại mật khẩu mới:";
            // 
            // txtMatKhauMoi_1
            // 
            txtMatKhauMoi_1.Location = new Point(20, 82);
            txtMatKhauMoi_1.Multiline = true;
            txtMatKhauMoi_1.Name = "txtMatKhauMoi_1";
            txtMatKhauMoi_1.PasswordChar = '*';
            txtMatKhauMoi_1.Size = new Size(318, 34);
            txtMatKhauMoi_1.TabIndex = 4;
            txtMatKhauMoi_1.UseSystemPasswordChar = true;
            // 
            // QuenMatKhau_Frm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(754, 392);
            Controls.Add(groupXacNhan);
            Controls.Add(groupBox2);
            Name = "QuenMatKhau_Frm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Quên Mật Khẩu";
            FormClosed += QuenMatKhau_Frm_FormClosed;
            Load += QuenMatKhau_Frm_Load;
            groupXacNhan.ResumeLayout(false);
            groupXacNhan.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupXacNhan;
        private Button btnXacNhan_MaXacMinh;
        private Button btnGuiMa;
        private TextBox txtMaXacMinh;
        private Label label3;
        private TextBox txtEmail;
        private Label label2;
        private Label label1;
        private GroupBox groupBox2;
        private Button btnXacNhan_DoiMatKhau;
        private TextBox txtMatKhauMoi_2;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox txtMatKhauMoi_1;
    }
}