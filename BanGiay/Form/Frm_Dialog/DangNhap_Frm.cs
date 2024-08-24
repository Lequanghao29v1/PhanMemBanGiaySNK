using BanGiay;
using BUS.Services;
using DAL.Models.DomainClass;
using DAL.Models.ModelRefer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PRL.Frm_Main
{
    public partial class DangNhap_Frm : System.Windows.Forms.Form
    {
        TaiKhoanService _Ser_TaiKhoan = new TaiKhoanService();
        List<Taikhoan> _lstTaiKhoan = new List<Taikhoan>();
        int idTaiKhoan;
        bool? trangThai_TaiKhoan;
        string hoVaTen;
        int maChucVu;
        public DangNhap_Frm()
        {
            InitializeComponent();
        }
        private void DangNhap_Frm_Load(object sender, EventArgs e)
        {
            txtMatKhau.UseSystemPasswordChar = true;
        }
        private void btnDangnhap_Click(object sender, EventArgs e)
        {
            
            DangNhap();
        }
        public bool AuthenticateUser(string userName, string password, List<Taikhoan> lstTaiKhoan)
        {
            foreach (var user in lstTaiKhoan)
            {
                if (user.Username == userName && user.Pasword == password)
                {
                    idTaiKhoan = user.Mataikhoan;
                    maChucVu = user.Machucvu;
                    hoVaTen = user.Hovaten;
                    trangThai_TaiKhoan = user.Trangthai;
                    if (user.Trangthai == true)
                    {
                        LoginManager.Instance.UpdateLoginInfo(user.Mataikhoan, user.Machucvu, user.Hovaten);
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
            return false;
        }
        private void btnQuenmk_Click(object sender, EventArgs e)
        {
            QuenMatKhau_Frm formQuenMatKhau = new QuenMatKhau_Frm();
            formQuenMatKhau.Show();
        }
        private void txtMatKhau_Enter(object sender, EventArgs e)
        {
            if (e is KeyEventArgs keyEventArgs && keyEventArgs.KeyCode == Keys.Enter)
            {
                DangNhap();
            }
        }
        public void DangNhap()
        {
            _lstTaiKhoan = _Ser_TaiKhoan.GetAll(null, null);
            if (AuthenticateUser(txtTaiKhoan.Text, txtMatKhau.Text, _lstTaiKhoan))
            {
                MessageBox.Show($"Đăng nhập thành công!\n Xin chào '{hoVaTen}'\n Bạn là: '{(maChucVu == 1 ? "Nhân viên" : "Quản lý")}'");
                this.Hide();
            }
            else
            {
                if (trangThai_TaiKhoan == false)
                {
                    MessageBox.Show("Tài khoản này đã bị khóa không thể đăng nhập");
                }
                else
                {
                    MessageBox.Show("Đăng nhập thất bại. Sai tên đăng nhập hoặc mật khẩu.");
                }
            }
        }
        private void ptbTat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
