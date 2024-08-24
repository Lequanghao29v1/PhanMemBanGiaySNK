using BanGiay.Form.US;
using DAL.Models.DomainClass;
using DAL.Models.ModelRefer;
using PRL.Frm_Main;

namespace BanGiay
{
    public partial class Main : System.Windows.Forms.Form
    {
        Frm_US_BanHang form_BanHang = new Frm_US_BanHang();
        DangNhap_Frm form_DangNhap = new DangNhap_Frm();
        private Button btnHienTai;
        private int tempIndex;
        public int idTaiKhoan;
        public int maChucVu;
        string hoVaTen;

        public Main()
        {
            InitializeComponent();

        }
        private void ActivateButton(object btnsender)
        {
            if (btnsender != null)
            {
                if (btnHienTai != (Button)btnsender)
                {
                    DisableButton();
                    btnHienTai = (Button)btnsender;
                    btnHienTai.BackColor = Color.FromArgb(64,64,64);
                    btnHienTai.Font = new System.Drawing.Font("Segoe UI", 12, FontStyle.Bold);
                }
            }
        }
        private void DisableButton()
        {
            foreach (Control previousBtn in panel1.Controls)
            {
                if (previousBtn.GetType() == typeof(Button))
                {
                    previousBtn.BackColor = Color.FromArgb(64, 64, 64);
                    previousBtn.Font = new System.Drawing.Font("Segoe UI", 10);
                }
            }
        }
        private void btnBanHang_Click(object sender, EventArgs e)
        {
            
            Frm_US_BanHang US_BanHang = new Frm_US_BanHang();
            Load_Usercontrol(US_BanHang);
            ActivateButton(sender);
        }
        private void btnSanPham_Click(object sender, EventArgs e)
        {
            Frm_US_SanPham US_SanPham = new Frm_US_SanPham();
            Load_Usercontrol(US_SanPham);
            ActivateButton(sender);

        }
        private void btnHoaDon_Click(object sender, EventArgs e)
        {
            Frm_US_HoaDon US_HoaDon = new Frm_US_HoaDon();
            Load_Usercontrol(US_HoaDon);
            ActivateButton(sender);

        }
        private void benKhuyenMai_Click(object sender, EventArgs e)
        {
            if (maChucVu == 1)
            {
                MessageBox.Show("Bạn là nhận viên không thể dùng chức năng quản lý 'ưu đãi'!");
            }
            else
            {
                Frm_US_UuDai US_UuDai = new Frm_US_UuDai();
                Load_Usercontrol(US_UuDai);
                ActivateButton(sender);

            }

        }
        private void btnNhanVien_Click(object sender, EventArgs e)
        {
            if (maChucVu == 1)
            {
                MessageBox.Show("Bạn là nhận viên không thể dùng chức năng quản lý 'nhân viên'!");
            }
            else
            {
                Frm_Us_NhanVien US_NhanVien = new Frm_Us_NhanVien();
                Load_Usercontrol(US_NhanVien);
                ActivateButton(sender);

            }


        }
        private void btnKhachHang_Click(object sender, EventArgs e)
        {
            Frm_US_KhachHang US_KhachHang = new Frm_US_KhachHang();
            Load_Usercontrol(US_KhachHang);
            ActivateButton(sender);

        }
        private void btnThongKe_Click(object sender, EventArgs e)
        {
            if (maChucVu == 1)
            {
                MessageBox.Show("Bạn là nhận viên không thể dùng chức năng quản lý 'thông kê'!");
            }
            else
            {
                Frm_US_ThongKe US_ThongKe = new Frm_US_ThongKe();
                Load_Usercontrol(US_ThongKe);
                ActivateButton(sender);

            }
        }
        private void btnLuong_Click(object sender, EventArgs e)
        {
            if (maChucVu == 1)
            {
                MessageBox.Show("Bạn là nhận viên không thể dùng chức năng quản lý 'lương'!");
                
            }
            else
            {
                Frm_US_BangLuong US_Luong = new Frm_US_BangLuong();
                Load_Usercontrol(US_Luong);
                ActivateButton(sender);
                
            }


        }
        private void btnGiaoCa_Click(object sender, EventArgs e)
        {
            if (maChucVu == 1)
            {
                MessageBox.Show("Bạn là nhận viên không thể dùng chức năng 'giao ca'!");
            }
            else
            {
                Frm_US_GiaoCa US_GiaoCa = new Frm_US_GiaoCa();
                Load_Usercontrol(US_GiaoCa);
                ActivateButton(sender);

            }


        }
        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            LoginManager.Instance.Logout();
            this.Hide();

            DangNhap_Frm loginForm = new DangNhap_Frm();
            loginForm.ShowDialog();
            this.Show();

            idTaiKhoan = LoginManager.Instance.IdTaiKhoan;
            maChucVu = LoginManager.Instance.MaChucVu;
            hoVaTen = LoginManager.Instance.HoVaTen;
            txtTenTaiKhoan.Text = hoVaTen;
            btnBanHang.PerformClick();
        }
        private void Load_Usercontrol(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            panel_US.Controls.Clear();
            panel_US.Controls.Add(userControl);
            userControl.BringToFront();
        }
        private void OpenLoginForm()
        {
            form_DangNhap.ShowDialog();

            idTaiKhoan = LoginManager.Instance.IdTaiKhoan;
            maChucVu = LoginManager.Instance.MaChucVu;
            hoVaTen = LoginManager.Instance.HoVaTen;

            txtTenTaiKhoan.Text = hoVaTen;
            if (idTaiKhoan != 0 || maChucVu != 0)
            {
                this.Show();
            }
            else
            {
                this.Close();
            }
           
            /////////////////////////////////////////////
        }
        private void Main_Load(object sender, EventArgs e)
        {

            btnBanHang.PerformClick();

            this.Hide();
           
            OpenLoginForm();
            
            if (LoginManager.Instance.MaChucVu == 1)
            {
                MessageBox.Show("Bạn là nhân viên");
                btnLuong.Visible = false;
            }
            else if (LoginManager.Instance.MaChucVu == 2)
            {
                MessageBox.Show("Bạn là quản lý");
                btnLuong.Visible = true;
            }
            else
            {
                MessageBox.Show("Không nhận dạng được chức vụ");
            }

        }
        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            form_BanHang.XoaHoaDon_ChuaThanhToan();
        }
    }
}