using BUS.IServices;
using BUS.Services;
using DAL.Models.DomainClass;
using DAL.Models.ModelRefer;
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
    public partial class KieuDang_Frm : System.Windows.Forms.Form
    {
        KieuDangService _Ser = new KieuDangService();
        List<Kieudang> _lstObj = new List<Kieudang>();
        DangNhap_Frm frm_DangNhap = new DangNhap_Frm();
        int idClicked;

        public KieuDang_Frm()
        {
            InitializeComponent();
        }

        private void KieuDang_Form_Load(object sender, EventArgs e)
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
            cbbTimKiem.Items.Add(SearchType.tenKieuDang);
            cbbTimKiem.Items.Add(SearchType.moTaKieuDang);
            cbbTimKiem.Items.Add(SearchType.trangThaiKieuDang);
            cbbTimKiem.Items.Add(SearchType.idNguoiThemKieuDang);
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
                    item.Tenkieudang,
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
                var confirmResult = MessageBox.Show("Xác nhận 'thêm' kiểu dáng không?", "Xác nhận", MessageBoxButtons.OKCancel);

                if (confirmResult == DialogResult.OK)
                {
                    var existingProduct = _Ser.GetAll(null, null)
                            .FirstOrDefault(p =>
                                p.Tenkieudang == txtTen.Text &&
                                p.Mota == txtMoTa.Text);
                    if (existingProduct != null)
                    {
                        MessageBox.Show("Kiểu dáng đã tồn tại!");
                        result = false;
                    }
                    else
                    {
                        result = _Ser.Them(new Kieudang()
                        {
                            Tenkieudang = txtTen.Text,
                            Mota = txtMoTa.Text,
                            Mataikhoan = 1,
                            Trangthai = true
                        });

                    }


                    if (result)
                    {
                        MessageBox.Show("Đã 'thêm' thành công 1 kiểu dáng mới");

                        LoadDataGridView(null, null);
                    }
                    else
                    {
                        MessageBox.Show("'Thêm' thất bại");
                    }
                }
                else
                {
                    MessageBox.Show("Đã hủy 'thêm' kiểu dáng này");
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
            if (CheckTextbox())
            {
                var confirmResult = MessageBox.Show("Xác nhận 'sửa' kiểu dáng này không?", "Xác nhận", MessageBoxButtons.OKCancel);

                if (confirmResult == DialogResult.OK)
                {
                    var result = _Ser.Sua(idClicked, new Kieudang()
                    {
                        Tenkieudang = txtTen.Text,
                        Mota = txtMoTa.Text,
                    });

                    if (result)
                    {
                        MessageBox.Show("Đã 'sửa' kiểu dáng này thành công");

                        LoadDataGridView(null, null);
                    }
                    else
                    {
                        MessageBox.Show("'Sửa' thất bại");
                    }
                }
                else
                {
                    MessageBox.Show("Đã hủy 'sửa' kiểu dáng này");
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
                var confirmResult = MessageBox.Show("Xác nhận 'khóa' kiểu dáng này không?", "Xác nhận", MessageBoxButtons.OKCancel);

                if (confirmResult == DialogResult.OK)
                {
                    var result = _Ser.Khoa_MoKhoa(idClicked);

                    if (result)
                    {
                        MessageBox.Show("Đã 'khóa' kiểu dáng này thành công");
                        LoadDataGridView(null, null);
                    }
                    else
                    {
                        MessageBox.Show("'Khóa' thất bại");
                    }
                }
                else
                {
                    MessageBox.Show("Đã hủy 'khóa' kiểu dáng này");
                }
            }
            else
            {
                var confirmResult = MessageBox.Show("Xác nhận 'mở khóa' kiểu dáng này không?", "Xác nhận", MessageBoxButtons.OKCancel);

                if (confirmResult == DialogResult.OK)
                {
                    var result = _Ser.Khoa_MoKhoa(idClicked);

                    if (result)
                    {
                        MessageBox.Show("Đã 'mở khóa' kiểu dáng này thành công");
                        LoadDataGridView(null, null);
                    }
                    else
                    {
                        MessageBox.Show("'Mở khóa' thất bại");
                    }
                }
                else
                {
                    MessageBox.Show("Đã hủy 'mở khóa' kiểu dáng này");
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

            idClicked = objCellClick.Makieudang;

            txtTen.Text = objCellClick.Tenkieudang;
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
