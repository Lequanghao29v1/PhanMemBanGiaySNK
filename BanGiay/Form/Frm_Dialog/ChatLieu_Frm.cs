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
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PRL
{
    public partial class ChatLieu_Frm : System.Windows.Forms.Form
    {
        ChatLieuService _Ser = new ChatLieuService();
        List<Chatlieu> _lstObj = new List<Chatlieu>();
        DangNhap_Frm frm_DangNhap = new DangNhap_Frm();
        int idClicked;
        int idMaTaiKhoan;
        public ChatLieu_Frm()
        {
            InitializeComponent();
        }
        private void ChatLieu_Load(object sender, EventArgs e)
        {
            LoadCBB();
            LoadDataGridView(null, null);
        }
        public void ClearTextBox()
        {
            txtMoTa.Text = "";
            txtTen.Text = "";
            txtTimKiem.Text = "";
        }
        public void LoadCBB()
        {
            cbbTimKiem.Items.Clear();
            cbbTimKiem.Items.Add(SearchType.All);
            cbbTimKiem.Items.Add(SearchType.tenChatLieu);
            cbbTimKiem.Items.Add(SearchType.moTaChatLieu);
            cbbTimKiem.Items.Add(SearchType.trangThaiChatLieu);
            cbbTimKiem.Items.Add(SearchType.idNguoiThemChatLieu);
            cbbTimKiem.SelectedIndex = 0;
        }
        public void LoadDataGridView(string? txtTimKiem, string? SearchType)
        {
            dgv_Objects.Rows.Clear();

            dgv_Objects.ColumnCount = 5;
            dgv_Objects.Columns[0].Name = "STT";
            dgv_Objects.Columns[1].Name = "tên";
            dgv_Objects.Columns[2].Name = "mô tả";
            dgv_Objects.Columns[3].Name = "id người tạo";
            dgv_Objects.Columns[4].Name = "trạng thái";

            _lstObj = _Ser.GetAll(txtTimKiem, SearchType);

            foreach (var item in _lstObj)
            {
                int stt = _lstObj.IndexOf(item) + 1;

                dgv_Objects.Rows.Add(stt,
                    item.Tenchatlieu,
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
            if (CheckTextbox())
            {
                var confirmResult = MessageBox.Show("Xác nhận 'thêm' chất liệu không?", "Xác nhận", MessageBoxButtons.OKCancel);

                if (confirmResult == DialogResult.OK)
                {
                    var existingProduct = _Ser.GetAll(null, null)
                                                .FirstOrDefault(p =>
                                                    p.Tenchatlieu == txtTen.Text &&
                                                    p.Mota == txtMoTa.Text);
                    if (existingProduct != null)
                    {
                        MessageBox.Show("Chất liệu đã tồn tại!");
                        result = false;
                    }
                    else
                    {
                        result = _Ser.Them(new Chatlieu()
                        {
                            Tenchatlieu = txtTen.Text,
                            Mota = txtMoTa.Text,
                            Mataikhoan = LoginManager.Instance.IdTaiKhoan,
                            Trangthai = true
                        });

                    }

                    if (result)
                    {
                        MessageBox.Show("Đã 'thêm' thành công 1 chất liệu mới");

                        LoadDataGridView(null, null);
                    }
                    else
                    {
                        MessageBox.Show("'Thêm' thất bại");
                    }
                }
                else
                {
                    MessageBox.Show("Đã hủy 'thêm' sản phẩm này");
                }
                ClearTextBox();
            }
            else
            {
                MessageBox.Show("Vui lòng nhập dữ liệu hợp lệ!");
            }
        }
        private void btnSua_Click(object sender, EventArgs e)
        {
            if (CheckTextbox())
            {
                var confirmResult = MessageBox.Show("Xác nhận 'sửa' chất liệu này không?", "Xác nhận", MessageBoxButtons.OKCancel);

                if (confirmResult == DialogResult.OK)
                {
                    var result = _Ser.Sua(idClicked, new Chatlieu()
                    {
                        Tenchatlieu = txtTen.Text,
                        Mota = txtMoTa.Text,
                    });

                    if (result)
                    {
                        MessageBox.Show("Đã 'sửa' chất liệu này thành công");

                        LoadDataGridView(null, null);
                    }
                    else
                    {
                        MessageBox.Show("'Sửa' thất bại");
                    }
                }
                else
                {
                    MessageBox.Show("Đã hủy 'sửa' chất liệu này");
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
                var confirmResult = MessageBox.Show("Xác nhận 'khóa' chất liệu này không?", "Xác nhận", MessageBoxButtons.OKCancel);

                if (confirmResult == DialogResult.OK)
                {
                    var result = _Ser.Khoa_MoKhoa(idClicked);

                    if (result)
                    {
                        MessageBox.Show("Đã 'khóa' chất liệu này thành công");
                        LoadDataGridView(null, null);
                    }
                    else
                    {
                        MessageBox.Show("'Khóa' thất bại");
                    }
                }
                else
                {
                    MessageBox.Show("Đã hủy 'khóa' chất liệu này");
                }
            }
            else
            {
                var confirmResult = MessageBox.Show("Xác nhận 'mở khóa' chất liệu này không?", "Xác nhận", MessageBoxButtons.OKCancel);

                if (confirmResult == DialogResult.OK)
                {
                    var result = _Ser.Khoa_MoKhoa(idClicked);

                    if (result)
                    {
                        MessageBox.Show("Đã 'mở khóa' chất liệu này thành công");
                        LoadDataGridView(null, null);
                    }
                    else
                    {
                        MessageBox.Show("'Mở khóa' thất bại");
                    }
                }
                else
                {
                    MessageBox.Show("Đã hủy 'mở khóa' chất liệu này");
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

            idClicked = objCellClick.Machatlieu;

            txtTen.Text = objCellClick.Tenchatlieu;
            txtMoTa.Text = objCellClick.Mota;
        }
        private bool CheckTextbox()
        {
            if (txtTen.Text == "" || txtMoTa.Text == "" || LoginManager.Instance.IdTaiKhoan == 0)
            {
                return false;
            }
            return true;
        }
    }
}
