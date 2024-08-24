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
    public partial class KichCo_Frm : System.Windows.Forms.Form
    {
        KichCoService _Ser = new KichCoService();
        List<Kichco> _lstObj = new List<Kichco>();
        DangNhap_Frm frm_DangNhap = new DangNhap_Frm();
        int idClicked;
        int idMaTaiKhoan;
        public KichCo_Frm()
        {
            InitializeComponent();
        }
        private void KichCo_Form_Load(object sender, EventArgs e)
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
            cbbTimKiem.Items.Add(SearchType.tenKichCo);
            cbbTimKiem.Items.Add(SearchType.moTaKichCo);
            cbbTimKiem.Items.Add(SearchType.trangThaiKichCo);
            cbbTimKiem.Items.Add(SearchType.idNguoiThemKichCo);
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
                    item.Tenkichco,
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
                var confirmResult = MessageBox.Show("Xác nhận 'thêm' kích cỡ không?", "Xác nhận", MessageBoxButtons.OKCancel);

                if (confirmResult == DialogResult.OK)
                {
                    var existingProduct = _Ser.GetAll(null, null)
                            .FirstOrDefault(p =>
                                p.Tenkichco == txtTen.Text &&
                                p.Mota == txtMoTa.Text);
                    if (existingProduct != null)
                    {
                        MessageBox.Show("Kích cỡ đã tồn tại!");
                        result = false;
                    }
                    else
                    {
                        result = _Ser.Them(new Kichco()
                        {
                            Tenkichco = txtTen.Text,
                            Mota = txtMoTa.Text,
                            Mataikhoan = 1,
                            Trangthai = true
                        });

                    }


                    if (result)
                    {
                        MessageBox.Show("Đã 'thêm' thành công 1 kích cỡ mới");

                        LoadDataGridView(null, null);
                    }
                    else
                    {
                        MessageBox.Show("'Thêm' thất bại");
                    }
                }
                else
                {
                    MessageBox.Show("Đã hủy 'thêm' kích cỡ này");
                }
                ClearTextBox();

            }
            else
            {
                MessageBox.Show("Vui lòng nhập dữ liệu hợp lý!");
            }
            //if (CheckTextbox())
            //{

            //}
            //else
            //{
            //    MessageBox.Show("Vui lòng nhập dữ liệu hợp lý!");
            //}

        }
        private void btnSua_Click(object sender, EventArgs e)
        {
            if (CheckTextbox())
            {
                var confirmResult = MessageBox.Show("Xác nhận 'sửa' kích cỡ này không?", "Xác nhận", MessageBoxButtons.OKCancel);

                if (confirmResult == DialogResult.OK)
                {
                    var result = _Ser.Sua(idClicked, new Kichco()
                    {
                        Tenkichco = txtTen.Text,
                        Mota = txtMoTa.Text,
                    });

                    if (result)
                    {
                        MessageBox.Show("Đã 'sửa' kích cỡ này thành công");

                        LoadDataGridView(null, null);
                    }
                    else
                    {
                        MessageBox.Show("'Sửa' thất bại");
                    }
                }
                else
                {
                    MessageBox.Show("Đã hủy 'sửa' kích cỡ này");
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
                var confirmResult = MessageBox.Show("Xác nhận 'khóa' kích cỡ này không?", "Xác nhận", MessageBoxButtons.OKCancel);

                if (confirmResult == DialogResult.OK)
                {
                    var result = _Ser.Khoa_MoKhoa(idClicked);

                    if (result)
                    {
                        MessageBox.Show("Đã 'khóa' kích cỡ này thành công");
                        LoadDataGridView(null, null);
                    }
                    else
                    {
                        MessageBox.Show("'Khóa' thất bại");
                    }
                }
                else
                {
                    MessageBox.Show("Đã hủy 'khóa' kích cỡ này");
                }
            }
            else
            {
                var confirmResult = MessageBox.Show("Xác nhận 'mở khóa' kích cỡ này không?", "Xác nhận", MessageBoxButtons.OKCancel);

                if (confirmResult == DialogResult.OK)
                {
                    var result = _Ser.Khoa_MoKhoa(idClicked);

                    if (result)
                    {
                        MessageBox.Show("Đã 'mở khóa' kích cỡ này thành công");
                        LoadDataGridView(null, null);
                    }
                    else
                    {
                        MessageBox.Show("'Mở khóa' thất bại");
                    }
                }
                else
                {
                    MessageBox.Show("Đã hủy 'mở khóa' kích cỡ này");
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

            idClicked = objCellClick.Makichco;

            txtTen.Text = objCellClick.Tenkichco;
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
