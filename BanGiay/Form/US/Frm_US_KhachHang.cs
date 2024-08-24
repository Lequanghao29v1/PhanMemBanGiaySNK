using BUS.Services;
using DAL.Models.DomainClass;
using OfficeOpenXml;
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

namespace BanGiay.Form.US
{
    public partial class Frm_US_KhachHang : UserControl
    {
        public Frm_US_KhachHang()
        {
            InitializeComponent();
            LoadGird(null);
        }
        private KhachHangService _service = new KhachHangService();
        int _idWhenClick;
        public void LoadGird(string search)
        {
            int stt = 1;
            dgvKH.ColumnCount = 6;
            dgvKH.Columns[0].Name = "STT";
            dgvKH.Columns[1].Name = "Mã";
            dgvKH.Columns[2].Name = "Tên";
            dgvKH.Columns[3].Name = "SDT";
            dgvKH.Columns[4].Name = "Điểm";
            dgvKH.Columns[5].Name = "Trạng Thái";
            dgvKH.Rows.Clear();

            foreach (var x in _service.GetAllKhachhang(search))
            {
                dgvKH.Rows.Add(stt++, x.Makhachhang, x.Tenkhachhang, x.Sdt, x.Diemkhachhang, x.Trangthai == false ? "Không hoạt động" : "Hoạt đông");
            }
        }
        public void Loadhodon(int selectedID)
        {

            int stt = 1;
            dgvHD.ColumnCount = 5;
            dgvHD.Columns[0].Name = "STT";
            dgvHD.Columns[1].Name = "Mã Hoá Đơn";
            dgvHD.Columns[2].Name = "Ngày tạo";
            dgvHD.Columns[3].Name = "Loại thanh toán";
            dgvHD.Columns[4].Name = "Tổng tiền";

            dgvHD.Rows.Clear();
            foreach (var e in _service.GetAllHoadon().Where(x => x.Makhachhang == selectedID))
            {
                var idtt = _service.GetHinhthucthanhtoans().FirstOrDefault(x => x.Mahinhthucthanhtoan == e.Mahinhthucthanhtoan);
                dgvHD.Rows.Add(stt++, e.Mahoadon, e.Ngaytao, idtt.Tenhinhthuc, e.Tongtien);
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (!checksdt(txtSDT.Text))
            {
                MessageBox.Show("Số điện thoại tồn tại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (checkdulieu(txtSDT.Text))
            {

                Khachhang khachhang = new Khachhang();
                khachhang.Tenkhachhang = txtHoVaTen.Text;
                khachhang.Sdt = txtSDT.Text;
                khachhang.Diemkhachhang = 0;
                khachhang.Trangthai = true;

                var relust = MessageBox.Show("Xác nhận muốm thêm", "Xác nhận", MessageBoxButtons.YesNo);
                if (relust == DialogResult.Yes)
                {
                    MessageBox.Show(_service.AddKhachHang(khachhang));
                }
                LoadGird(null);
            }
        }

        private void dgvKH_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (index < 0 || index >= _service.GetAllKhachhang(null).Count)
            {
                return;
            }

            if (index >= 0)
            {
                _idWhenClick = int.Parse(dgvKH.Rows[index].Cells[1].Value.ToString());
                var khach = _service.GetAllKhachhang(null).FirstOrDefault(x => x.Makhachhang == _idWhenClick);
                txtMaKhachHang.Text = khach.Makhachhang.ToString();
                txtHoVaTen.Text = khach.Tenkhachhang;
                txtSDT.Text = khach.Sdt;
                txtDiemKH.Text = khach.Diemkhachhang.ToString();
                Loadhodon(_idWhenClick);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (checkdulieu(txtSDT.Text))
            {

                Khachhang khachhang = new Khachhang();
                khachhang.Makhachhang = _idWhenClick;
                khachhang.Tenkhachhang = txtHoVaTen.Text;
                khachhang.Sdt = txtSDT.Text;
                var khachHangID = _service.GetAllKhachhang(null).FirstOrDefault(x => x.Makhachhang == _idWhenClick);
                if (khachHangID != null && khachHangID.Trangthai == false)
                {
                    MessageBox.Show("Không thể sửa khách hàng đang bị khoá.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                // khachhang.Diemkhachhang = int.Parse(txtDiemKH.Text);
                var relust = MessageBox.Show("Xác nhận muốm sửa", "Xác nhận", MessageBoxButtons.YesNo);
                if (relust == DialogResult.Yes)
                {
                    MessageBox.Show(_service.UpdateKhachHang(khachhang));
                }
                LoadGird(null);
            }
        }

        private void txtTimkiem_TextChanged(object sender, EventArgs e)
        {
            LoadGird(txtTimKiem_KhachHang.Text);
        }

        private void btnKhoaMoKhoa_Click(object sender, EventArgs e)
        {
            Khachhang khachhang = new Khachhang();
            khachhang.Makhachhang = _idWhenClick;
            var relust = MessageBox.Show("Xác nhận muốm Khoá/Mở khoá", "Xác nhận", MessageBoxButtons.YesNo);
            if (relust == DialogResult.Yes)
            {
                MessageBox.Show(_service.Khoa_MoKhoa(khachhang));
            }
            LoadGird(null);
        }

        public bool checkdulieu(string sodienthoai)
        {
            if (string.IsNullOrEmpty(txtSDT.Text)
            || string.IsNullOrEmpty(txtHoVaTen.Text))
            {
                MessageBox.Show("Vui lòng nhập đủ dữ liệu.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (!Regex.IsMatch(txtSDT.Text, @"^\d{10}$"))
            {
                MessageBox.Show("Số điện thoại 0 hợp lệ", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }
        private bool checksdt(string sodienthoai)
        {
            int dem = 0;
            foreach (Khachhang khachhang in _service.GetAllKhachhang(null))
            {
                if (khachhang.Sdt == sodienthoai)
                {
                    dem++;
                }
            }
            if (dem == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void btnExcel_Click(object sender, EventArgs e)
        {
            using (ExcelPackage excelPackage = new ExcelPackage())
            {
                ExcelWorksheet worksheet = excelPackage.Workbook.Worksheets.Add("Sheet1");

                for (int i = 0; i < dgvKH.Columns.Count; i++)
                {
                    worksheet.Cells[1, i + 1].Value = dgvKH.Columns[i].HeaderText;
                }

                for (int i = 0; i < dgvKH.Rows.Count; i++)
                {
                    for (int j = 0; j < dgvKH.Columns.Count; j++)
                    {
                        worksheet.Cells[i + 2, j + 1].Value = dgvKH.Rows[i].Cells[j].Value?.ToString();
                    }
                }

                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "Excel files (*.xlsx)|*.xlsx|All files (*.*)|*.*";
                var result = saveFileDialog.ShowDialog();
                if (result == DialogResult.OK)
                {
                    FileInfo fileInfo = new FileInfo(saveFileDialog.FileName);
                    excelPackage.SaveAs(fileInfo);
                    MessageBox.Show("Dữ liệu đã được xuất thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Xuất file thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }
        
    }
}
