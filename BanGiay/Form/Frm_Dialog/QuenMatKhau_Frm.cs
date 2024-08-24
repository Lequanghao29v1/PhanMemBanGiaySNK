using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL.Models.DomainClass;
using BUS.Services;
using DAL.Models.Context;

namespace PRL.Frm_Main
{
    public partial class QuenMatKhau_Frm : System.Windows.Forms.Form
    {
        TaiKhoanService _Ser_TaiKhoan = new TaiKhoanService();
        List<Taikhoan> _lstTaiKhoan = new List<Taikhoan>();
        DangNhap_Frm dangNhapFrm = new DangNhap_Frm();
        DBContext _db = new DBContext();
        int idTaiKhoan;
        string otp;
        public QuenMatKhau_Frm()
        {
            InitializeComponent();
        }

        private void GuiTinEmail(string toEmail, string NoiDungEmail)
        {
            string fromEmail, passFromEmail, context;

            fromEmail = "myemail42635461@gmail.com";
            toEmail = txtEmail.Text;
            passFromEmail = "cqeu uxxz purm njpw";
            context = NoiDungEmail;

            MailMessage mail = new MailMessage();
            mail.Subject = "Mã xác nhận OTP";
            mail.To.Add(toEmail);
            mail.From = new MailAddress(fromEmail);
            mail.Body = context;

            SmtpClient smtp = new SmtpClient("smtp.gmail.com");
            smtp.EnableSsl = true;
            smtp.Port = 587;
            smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
            smtp.Credentials = new NetworkCredential(fromEmail, passFromEmail);

            try
            {
                smtp.Send(mail);
                MessageBox.Show("Đã gửi mã xác nhận qua Email của bạn.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi gửi email: {ex.Message}");
            }
        }
        private string GenerateRandomCode()
        {
            return otp = Guid.NewGuid().ToString("N").Substring(0, 6); // Lấy 6 ký tự đầu tiên
        }
        private void btnGuiMa_Click(object sender, EventArgs e)
        {
            _lstTaiKhoan = _Ser_TaiKhoan.GetAll(null, null);
            if (AuthenticateUser(txtEmail.Text, _lstTaiKhoan))
            {
                string confirmationCode = GenerateRandomCode();

                GuiTinEmail(txtEmail.Text, "Verification code: " + confirmationCode);
            }
            else
            {
                MessageBox.Show("Email không tồn tại!");
            }
        }
        public bool AuthenticateUser(string email, List<Taikhoan> lstTaiKhoan)
        {
            foreach (var user in lstTaiKhoan)
            {
                if (user.Email == email)
                {
                    idTaiKhoan = user.Mataikhoan;
                    return true;
                }
            }

            return false;
        }
        private void btnXacNhan_MaXacMinh_Click(object sender, EventArgs e)
        {
            if (txtMaXacMinh.Text == otp)
            {
                MessageBox.Show("Bạn đã xác minh thành công danh tính. Tiếp theo bạn có để đặt mật khẩu mới!");
                this.Size = new System.Drawing.Size(771, 431);
                groupXacNhan.Enabled = false;
            }
            else
            {
                MessageBox.Show("Mã xác nhận không đúng!");
            }
        }
        private void btnXacNhan_DoiMatKhau_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtMatKhauMoi_1.Text == txtMatKhauMoi_2.Text)
                {
                    var confirmResult = MessageBox.Show("Bạn Có chắc chắn 'đặt lại' mật khẩu không?", "Xác nhận", MessageBoxButtons.OKCancel);

                    if (confirmResult == DialogResult.OK)
                    {
                        var objTaiKhoan = _db.Taikhoans.Where(a => a.Mataikhoan == idTaiKhoan).FirstOrDefault();
                        objTaiKhoan.Pasword = txtMatKhauMoi_1.Text;
                        var result = _Ser_TaiKhoan.Sua(idTaiKhoan, objTaiKhoan);
                        if (result)
                        {
                            MessageBox.Show("Bạn Đã đổi mật khẩu 'thành công'!");
                            this.Hide();
                            DangNhap_Frm formDangNhap = new DangNhap_Frm();
                            formDangNhap.Show();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Bạn đã 'hủy' đổi mật khẩu!");
                    }

                }
                else
                {
                    MessageBox.Show("Vui lòng nhập 'mật khẩu mới' và 'xác nhận mật khẩu' guống nhau!");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        private void QuenMatKhau_Frm_Load(object sender, EventArgs e)
        {
            LoadMau();
            this.Size = new System.Drawing.Size(398, 431);

        }
        private void QuenMatKhau_Frm_FormClosed(object sender, FormClosedEventArgs e)
        {
            DangNhap_Frm formDangNhap = new();
            formDangNhap.Show();

        }
        private void LoadMau()
        {
            this.BackColor = Color.FromArgb(69, 97, 120);
            btnGuiMa.BackColor = Color.FromArgb(32, 150, 37);
            btnGuiMa.ForeColor = Color.FromArgb(255, 255, 255);
            btnXacNhan_DoiMatKhau.BackColor = Color.FromArgb(32, 150, 37);
            btnXacNhan_DoiMatKhau.ForeColor = Color.FromArgb(255, 255, 255);
            btnXacNhan_MaXacMinh.BackColor = Color.FromArgb(32, 150, 37);
            btnXacNhan_MaXacMinh.ForeColor = Color.FromArgb(255, 255, 255);
            groupXacNhan.BackColor = Color.FromArgb(255, 255, 255);
        }
    }
}

