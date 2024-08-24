using BUS.Services;
using DAL.Models.DomainClass;
using DAL.Models.ModelRefer;
using Microsoft.VisualBasic.ApplicationServices;
using PRL.Frm_Main;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PRL
{
    public partial class ThuongHieu_Frm : System.Windows.Forms.Form
    {
        ThuongHieuServices _Ser = new ThuongHieuServices();
        List<Thuonghieu> _lstObj = new List<Thuonghieu>();
        DangNhap_Frm frm_DangNhap = new DangNhap_Frm();
        int idClicked;
        bool checkedTexbox;

        public ThuongHieu_Frm()
        {
            InitializeComponent();
        }
        private void ThuongHieu_Form_Load(object sender, EventArgs e)
        {
            LoadCBB();
            LoadDataGridView(null, null);


        }
        public void ClearTextBox()
        {
            txtMoTa.Text = "";
            txtEmail.Text = "";
            txtSDT.Text = "";
            txtTen.Text = "";
            txtTimKiem.Text = "";
        }
        public void LoadCBB()
        {
            cbbTimKiem.Items.Clear();
            cbbTimKiem.Items.Add(SearchType.All);
            cbbTimKiem.Items.Add(SearchType.tenThuongHieu);
            cbbTimKiem.Items.Add(SearchType.emailThuongHieu);
            cbbTimKiem.Items.Add(SearchType.sdtThuongHieu);
            cbbTimKiem.Items.Add(SearchType.moTaThuongHieu);
            cbbTimKiem.Items.Add(SearchType.trangThaiThuongHieu);
            cbbTimKiem.Items.Add(SearchType.idNguoiThemThuongHieu);
            cbbTimKiem.SelectedIndex = 0;
        }
        public void LoadDataGridView(string? txtTimKiem, string? SearchType)
        {
            dgv_Objects.Rows.Clear();

            dgv_Objects.ColumnCount = 7;
            dgv_Objects.Columns[0].Name = "STT";
            dgv_Objects.Columns[1].Name = "tên";
            dgv_Objects.Columns[2].Name = "email";
            dgv_Objects.Columns[3].Name = "số điện thoại";
            dgv_Objects.Columns[4].Name = "mô tả";
            dgv_Objects.Columns[5].Name = "id người tạo";
            dgv_Objects.Columns[6].Name = "trạng thái";

            _lstObj = _Ser.GetAll(txtTimKiem, SearchType);

            foreach (var item in _lstObj)
            {
                int stt = _lstObj.IndexOf(item) + 1;

                dgv_Objects.Rows.Add(stt,
                    item.Tenthuonghieu,
                    item.Email,
                    item.Sdt,
                    item.Mota,
                    item.Mataikhoan,
                    (item.Trangthai == true ? "Đang hoạt động" : "Ngừng hoạt động")
                    );
            }

        }
        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            LoadDataGridView(txtTimKiem.Text, cbbTimKiem.Text);
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            bool result;
            CheckTextbox();
            if (checkedTexbox)
            {
                var confirmResult = MessageBox.Show("Xác nhận 'thêm' thương hiệu không?", "Xác nhận", MessageBoxButtons.OKCancel);

                if (confirmResult == DialogResult.OK)
                {
                    var existingProduct = _Ser.GetAll(null, null)
                            .FirstOrDefault(p =>
                                p.Tenthuonghieu == txtTen.Text &&
                                p.Email == txtEmail.Text &&
                                p.Sdt == txtSDT.Text &&
                                p.Mota == txtMoTa.Text);
                    if (existingProduct != null)
                    {
                        MessageBox.Show("Thương hiệu đã tồn tại!");
                        result = false;
                    }
                    else
                    {
                        result = _Ser.Them(new Thuonghieu()
                        {
                            Tenthuonghieu = txtTen.Text,
                            Email = txtEmail.Text,
                            Sdt = txtSDT.Text,
                            Mota = txtMoTa.Text,
                            Mataikhoan = 1,
                            Trangthai = true
                        });
                    }

                    if (result)
                    {
                        MessageBox.Show("Đã 'thêm' thành công 1 thương hiệu mới");

                        LoadDataGridView(null, null);
                    }
                    else
                    {
                        MessageBox.Show("'Thêm' thất bại");
                    }
                }
                else
                {
                    MessageBox.Show("Đã hủy 'thêm' thương hiệu này");
                }
                ClearTextBox();

            }
            else
            {
                MessageBox.Show("Vui lòng nhập dữ liệu hợp lý!");
            }
        }
        private void btnSua_Click(object sender, EventArgs e)
        {
            CheckTextbox();
            if (checkedTexbox == true)
            {
                var confirmResult = MessageBox.Show("Xác nhận 'sửa' thương hiệu này không?", "Xác nhận", MessageBoxButtons.OKCancel);

                if (confirmResult == DialogResult.OK)
                {
                    var result = _Ser.Sua(idClicked, new Thuonghieu()
                    {
                        Tenthuonghieu = txtTen.Text,
                        Email = txtEmail.Text,
                        Sdt = txtSDT.Text,
                        Mota = txtMoTa.Text,
                    });

                    if (result)
                    {
                        MessageBox.Show("Đã 'sửa' thương hiệu này thành công");

                        LoadDataGridView(null, null);
                    }
                    else
                    {
                        MessageBox.Show("'Sửa' thất bại");
                    }
                }
                else
                {
                    MessageBox.Show("Đã hủy 'sửa' thương hiệu này");
                }
                ClearTextBox();

            }
            else
            {
                MessageBox.Show("Vui lòng nhập dữ liệu hợp lý!");
            }
        }
        private void btnKhoaMoKhoa_Click(object sender, EventArgs e)
        {
            if (_Ser.GetByID(idClicked).Trangthai == true)
            {
                var confirmResult = MessageBox.Show("Xác nhận 'khóa' thương hiệu này không?", "Xác nhận", MessageBoxButtons.OKCancel);

                if (confirmResult == DialogResult.OK)
                {
                    var result = _Ser.Khoa_MoKhoa(idClicked);

                    if (result)
                    {
                        MessageBox.Show("Đã 'khóa' thương hiệu này thành công");
                        LoadDataGridView(null, null);
                    }
                    else
                    {
                        MessageBox.Show("'Khóa' thất bại");
                    }
                }
                else
                {
                    MessageBox.Show("Đã hủy 'khóa' thương hiệu này");
                }
            }
            else
            {
                var confirmResult = MessageBox.Show("Xác nhận 'mở khóa' thương hiệu này không?", "Xác nhận", MessageBoxButtons.OKCancel);

                if (confirmResult == DialogResult.OK)
                {
                    var result = _Ser.Khoa_MoKhoa(idClicked);

                    if (result)
                    {
                        MessageBox.Show("Đã 'mở khóa' thương hiệu này thành công");
                        LoadDataGridView(null, null);
                    }
                    else
                    {
                        MessageBox.Show("'Mở khóa' thất bại");
                    }
                }
                else
                {
                    MessageBox.Show("Đã hủy 'mở khóa' thương hiệu này");
                }

            }
            ClearTextBox();
        }
        private void dgv_Objects_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;

            if (index < 0 || index >= _lstObj.Count)
            {
                ClearTextBox();
                return;
            }

            var objCellClick = _lstObj[index];

            idClicked = objCellClick.Mathuonghieu;

            txtTen.Text = objCellClick.Tenthuonghieu;
            txtEmail.Text = objCellClick.Email;
            txtSDT.Text = objCellClick.Sdt;
            txtMoTa.Text = objCellClick.Mota;
        }
        private void CheckTextbox()
        {
            if (txtTen.Text == "")
            {
                MessageBox.Show("Vui lòng nhập tên hợp lệ");
                checkedTexbox = false;
            }
            else if (txtMoTa.Text == "")
            {
                MessageBox.Show("Vui lòng nhập mô tả không quá 200 từ"); checkedTexbox = false;

            }
            else if (LoginManager.Instance.IdTaiKhoan == 0)
            {
                MessageBox.Show("Lỗi không nhận dạng được tài khoản đang sử dụng"); checkedTexbox = false;

            }
            else if (!Regex.IsMatch(txtEmail.Text, @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$"))
            {
                MessageBox.Show("Vui lòng nhập email đúng định dạng gồm 1 ít nhất 1 chữ, số @ gmail.com"); checkedTexbox = false;

            }
            else if (!Regex.IsMatch(txtSDT.Text, @"^\d{10}$"))
            {
                MessageBox.Show("Vui lòng nhập sđt hợp lệ gồm 10 chữ số"); checkedTexbox = false;
            }
            else
            {

                checkedTexbox = true;
            }


        }

    }
}
