using BUS.Services;
using DAL.Models.DomainClass;
using DAL.Models.ModelRefer;
using OfficeOpenXml;
using PRL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BanGiay.Form.US
{
    public partial class Frm_US_GiaoCa : UserControl
    {
        public Frm_US_GiaoCa()
        {
            InitializeComponent(); dateDen.Format = DateTimePickerFormat.Time;
            dateDen.CustomFormat = "HH:mm";
            dateVe.Format = DateTimePickerFormat.Time;
            dateVe.CustomFormat = "HH:mm";
            dateGiaoca.Format = DateTimePickerFormat.Custom;
            dateGiaoca.CustomFormat = "dd/MM/yyyy";
            LoadComBoBox();
            LoadCa(null);
            LoadGirdnhanvien(null);
            LoadGrid(null);
        }
        GiaocachitietService _service = new GiaocachitietService();
        List<int> _list1 = new List<int>();
        List<int> _list2 = new List<int>();
        int _idWhenclick;

        public void LoadComBoBox()
        {

            foreach (var item in _service.GetGiaocas(null))
            {
                _list1.Add(item.Magiaoca);
                cmbTenca.Items.Add(item.Tenca);
            }
            cmbTenca.SelectedIndex = 0;
            cmbTenca.DropDownStyle = ComboBoxStyle.DropDownList;

            foreach (var item in _service.GetTaikhoans(null))
            {
                _list2.Add(item.Mataikhoan);
                cmbnhanvien.Items.Add(item.Hovaten);
            }
            cmbnhanvien.SelectedIndex = 0;
            cmbnhanvien.DropDownStyle = ComboBoxStyle.DropDownList;

        }
        public void LoadGrid(string search)
        {
            int stt = 1;
            dgvGCCT.ColumnCount = 12;
            dgvGCCT.Columns[0].Name = "STT";
            dgvGCCT.Columns[1].Name = "Mã";
            dgvGCCT.Columns[2].Name = "Tên nhân viên";
            dgvGCCT.Columns[3].Name = "Tên ca";
            dgvGCCT.Columns[4].Name = "Ngày giao ca";
            dgvGCCT.Columns[4].DefaultCellStyle.Format = "dd/MM/yyy";
            dgvGCCT.Columns[5].Name = "Thời gian đến";
            dgvGCCT.Columns[6].Name = "Thời gian về";
            dgvGCCT.Columns[7].Name = "Số tiền bàn giao";
            dgvGCCT.Columns[8].Name = "Số sản phẩm bàn giao";
            dgvGCCT.Columns[9].Name = "Ghi chú";
            dgvGCCT.Columns[10].Name = "Tổng thời gian";
            dgvGCCT.Columns[11].Name = "Người cập nhập";
            dgvGCCT.Rows.Clear();
            foreach (var x in _service.giaocanhanviens(search))
            {
                TimeSpan totalWorking;
                DateTime ngayTao = DateTime.Now;
                TimeSpan batDau = x.Thoigianden.Value;
                TimeSpan ketThuc = x.Thoigianve.Value;
                if (x.Thoigianve < x.Thoigianden)
                {
                    totalWorking = TimeSpan.FromHours(24) - batDau + ketThuc;
                }
                else
                {
                    totalWorking = ketThuc - batDau;
                }
                var idca = _service.GetGiaocas(null).FirstOrDefault(i => i.Magiaoca == x.Magiaoca);
                var idnv = _service.GetTaikhoans(null).FirstOrDefault(e => e.Mataikhoan == x.Mataikhoan);
                dgvGCCT.Rows.Add(stt++, x.Magiaocanhanvien, idnv.Hovaten, idca.Tenca, x.Ngaygiaoca, x.Thoigianden, x.Thoigianve, x.Tiendagiao, x.Sanphamdagiao, x.Ghichu, totalWorking, x.Mataikhoan);
            }
        }
        private string MapTrangThai(int? trangThai)
        {
            switch (trangThai)
            {
                case 0:
                    return "Kết thúc";
                case 1:
                    return "Sắp diễn ra";
                case 2:
                    return "Đang diễn ra";
                case 3:
                    return "Huỷ ca";
                default:
                    return "";
            }
        }
        public void LoadCa(string searchs)
        {
            int stt = 1;
            dgv_GiaoCa.ColumnCount = 6;
            dgv_GiaoCa.Columns[0].Name = "STT";
            dgv_GiaoCa.Columns[1].Name = "Mã";
            dgv_GiaoCa.Columns[2].Name = "Tên";
            dgv_GiaoCa.Columns[3].Name = "Thời gian bắt đầu";
            dgv_GiaoCa.Columns[4].Name = "Thời gian kết thúc";
            dgv_GiaoCa.Columns[5].Name = "Tổng thời gian";

            dgv_GiaoCa.Rows.Clear();
            foreach (var x in _service.GetGiaocas(searchs))
            {
                TimeSpan totalWorkingTime;
                TimeSpan batDau = x.Thoigianbatdau.Value;
                TimeSpan ketThuc = x.Thoigianketthuc.Value;
                if (x.Thoigianketthuc < x.Thoigianbatdau)
                {
                    totalWorkingTime = TimeSpan.FromHours(24) - batDau + ketThuc;
                }
                else
                {
                    totalWorkingTime = ketThuc - batDau;
                }
                dgv_GiaoCa.Rows.Add(stt++, x.Magiaoca, x.Tenca, x.Thoigianbatdau, x.Thoigianketthuc, totalWorkingTime);
            }
        }
        public void LoadGirdnhanvien(string search)
        {
            int stt = 1;
            dgvNhanVien.ColumnCount = 7;
            dgvNhanVien.Columns[0].Name = "STT";
            dgvNhanVien.Columns[1].Name = "Mã";
            dgvNhanVien.Columns[2].Name = "Tên";
            dgvNhanVien.Columns[3].Name = "Giới tính";
            dgvNhanVien.Columns[4].Name = "SĐT";
            dgvNhanVien.Columns[5].Name = "Địa chỉ";
            dgvNhanVien.Columns[6].Name = "Trạng thái";

            dgvNhanVien.Rows.Clear();

            foreach (var x in _service.GetTaikhoans(search))
            {
                dgvNhanVien.Rows.Add(stt++, x.Mataikhoan, x.Hovaten, x.Gioitinh == true ? "Nam" : "Nữ", x.Sodienthoai
                    , x.Diachi, x.Trangthai == false ? "Nghỉ làm" : "Đi làm");
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            DateTime ngaygiao = dateGiaoca.Value;
            TimeSpan thoiGianden = dateDen.Value.TimeOfDay;
            TimeSpan thoiGianve = dateVe.Value.TimeOfDay;
            int selectedMaTaiKhoan = _list2[cmbnhanvien.SelectedIndex];
            if (_service.giaocanhanviens(null).Any(x => x.Mataikhoan == selectedMaTaiKhoan &&
                                                        x.Ngaygiaoca == ngaygiao &&
                                                ((thoiGianden >= x.Thoigianden && thoiGianden <= x.Thoigianve) ||
                                                 (thoiGianve >= x.Thoigianden && thoiGianve <= x.Thoigianve))))
            {
                MessageBox.Show("Thời gian của ca này đã tồn tại một ca khác.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Giaocanhanvien GC = new Giaocanhanvien();
            GC.Magiaoca = _list1[cmbTenca.SelectedIndex];
            GC.Mataikhoan = _list2[cmbnhanvien.SelectedIndex];
            GC.Ngaygiaoca = dateGiaoca.Value;
            GC.Thoigianden = thoiGianden;
            GC.Thoigianve = thoiGianve;
            GC.Sanphamdagiao = txtSanpham.Text;
            GC.Tiendagiao = float.Parse(txtTienbangiao.Text);
            GC.Ghichu = txtGhichu.Text;
            GC.Mataikhoan = LoginManager.Instance.IdTaiKhoan;
            if (thoiGianve <= thoiGianden)
            {
                MessageBox.Show("Thời gian về phải lớn hơn thời gian đến.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            var relust = MessageBox.Show("Xác nhận muốm thêm", "Xác nhận", MessageBoxButtons.YesNo);
            if (relust == DialogResult.Yes)
            {
                MessageBox.Show(_service.AddCaCT(GC));
            }
            LoadGrid(null);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Giao ca = new Giao();
            this.Hide();
            ca.ShowDialog();
            this.Show();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            TimeSpan thoiGianden = dateDen.Value.TimeOfDay;
            TimeSpan thoiGianve = dateVe.Value.TimeOfDay;
            Giaocanhanvien GC = new Giaocanhanvien();
            GC.Magiaocanhanvien = _idWhenclick;
            GC.Magiaoca = _list1[cmbTenca.SelectedIndex];
            GC.Mataikhoan = _list2[cmbnhanvien.SelectedIndex];
            GC.Ngaygiaoca = dateGiaoca.Value;
            GC.Thoigianden = thoiGianden;
            GC.Thoigianve = thoiGianve;
            GC.Sanphamdagiao = txtSanpham.Text;
            GC.Tiendagiao = float.Parse(txtTienbangiao.Text);
            GC.Ghichu = txtGhichu.Text;
            GC.Mataikhoan = LoginManager.Instance.IdTaiKhoan;

            if (thoiGianve <= thoiGianden)
            {
                MessageBox.Show("Thời gian về phải lớn hơn thời gian đến.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            var relust = MessageBox.Show("Xác nhận muốm sửa", "Xác nhận", MessageBoxButtons.YesNo);
            if (relust == DialogResult.Yes)
            {
                MessageBox.Show(_service.UpdateCaCT(GC));
            }
            LoadGrid(null);
        }

        private void dgvGCCT_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            int rowindex = e.RowIndex;

            _idWhenclick = int.Parse(dgvGCCT.Rows[rowindex].Cells[1].Value.ToString());
            var obj = _service.giaocanhanviens(null).FirstOrDefault(x => x.Magiaocanhanvien == _idWhenclick);
            cmbTenca.SelectedIndex = _list1.FindIndex(x => x == obj.Magiaoca);
            cmbnhanvien.SelectedIndex = _list2.FindIndex(e => e == obj.Mataikhoan);
            dateGiaoca.Text = obj.Ngaygiaoca.ToString();
            dateDen.Text = obj.Thoigianden.ToString();
            dateVe.Text = obj.Thoigianve.ToString();
            txtSanpham.Text = obj.Sanphamdagiao;
            txtTienbangiao.Text = obj.Tiendagiao.ToString();
            txtGhichu.Text = obj.Ghichu;
        }
        private void btnHuy_Click(object sender, EventArgs e)
        {
            Giaocanhanvien GC = new Giaocanhanvien();
            GC.Magiaocanhanvien = _idWhenclick;
            var relust = MessageBox.Show("Xác nhận muốm huỷ", "Xác nhận", MessageBoxButtons.YesNo);
            if (relust == DialogResult.Yes)
            {
                MessageBox.Show(_service.HuyCaCT(GC));
            }
            LoadGrid(null);
        }

        private void btnexcel_Click(object sender, EventArgs e)
        {
            using (ExcelPackage excelPackage = new ExcelPackage())
            {
                ExcelWorksheet worksheet = excelPackage.Workbook.Worksheets.Add("Sheet1");

                for (int i = 0; i < dgvGCCT.Columns.Count; i++)
                {
                    worksheet.Cells[1, i + 1].Value = dgvGCCT.Columns[i].HeaderText;
                }

                for (int i = 0; i < dgvGCCT.Rows.Count; i++)
                {
                    for (int j = 0; j < dgvGCCT.Columns.Count; j++)
                    {
                        worksheet.Cells[i + 2, j + 1].Value = dgvGCCT.Rows[i].Cells[j].Value?.ToString();
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

        private void txtTimkiemGiaoca_TextChanged(object sender, EventArgs e)
        {
            LoadCa(txtTimKiem_GiaoCa.Text);
        }

        private void txtTimkiemCt_TextChanged(object sender, EventArgs e)
        {
            LoadGrid(txtTimKiem_GCCT.Text);
        }
        private void txtTimkiemnv_TextChanged(object sender, EventArgs e)
        {
            LoadGirdnhanvien(txtTimKiem_NhanVien.Text);
        }


    }
}
