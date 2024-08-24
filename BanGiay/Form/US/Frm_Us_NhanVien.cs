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
    public partial class Frm_Us_NhanVien : UserControl
    {
        public Frm_Us_NhanVien()
        {
            InitializeComponent(); LoadComBoBox();
            rbnNam.Checked = true;
            dateSinh.Format = DateTimePickerFormat.Custom;
            dateSinh.CustomFormat = "dd/MM/yyyy";
            LoadGird(null);
        }
        private NhanvienService _service = new NhanvienService();
        List<int> _list = new List<int>();
        int _idWhenclick;
        public void LoadComBoBox()
        {

            foreach (var item in _service.GetChucvu())
            {
                _list.Add(item.Machucvu);
                cmbChucvu.Items.Add(item.Tenchucvu);
            }
            cmbChucvu.SelectedIndex = 0;
            cmbChucvu.DropDownStyle = ComboBoxStyle.DropDownList;
        }
        public void LoadGird(string search)
        {
            int stt = 1;
            dgvHienThi.ColumnCount = 13;
            dgvHienThi.Columns[0].Name = "STT";
            dgvHienThi.Columns[1].Name = "Mã";
            dgvHienThi.Columns[2].Name = "UserName";
            dgvHienThi.Columns[3].Name = "Password";
            dgvHienThi.Columns[4].Name = "Tên";
            dgvHienThi.Columns[5].Name = "Giới tính";
            dgvHienThi.Columns[6].Name = "SĐT";
            dgvHienThi.Columns[7].Name = "Địa chỉ";
            dgvHienThi.Columns[8].Name = "Email";
            dgvHienThi.Columns[9].Name = "Ngày sinh";
            dgvHienThi.Columns[9].DefaultCellStyle.Format = "dd/MM/yyyy";
            dgvHienThi.Columns[10].Name = "Chức vụ";
            dgvHienThi.Columns[11].Name = "Ngày tạo";
            dgvHienThi.Columns[11].DefaultCellStyle.Format = "dd/MM/yyyy";
            dgvHienThi.Columns[12].Name = "Trạng thái";

            dgvHienThi.Rows.Clear();

            foreach (var x in _service.GetTaikhoan(search))
            {

                var idcv = _service.GetChucvu().FirstOrDefault(e => e.Machucvu == x.Machucvu);
                dgvHienThi.Rows.Add(stt++, x.Mataikhoan, x.Username, x.Pasword, x.Hovaten, x.Gioitinh == true ? "Nam" : "Nữ", x.Sodienthoai
                    , x.Diachi, x.Email, x.Ngaysinh, idcv.Tenchucvu, x.Ngaytaotaikhoan, x.Trangthai == false ? "Nghỉ làm" : "Đi làm");
            }
        }
        private void dgvHienThi_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            // Check if index is valid
            if (index < 0)
            {
                return;
            }

            _idWhenclick = int.Parse(dgvHienThi.Rows[index].Cells[1].Value.ToString());
            var nhanvien = _service.GetTaikhoan(null).FirstOrDefault(x => x.Mataikhoan == _idWhenclick);
            txtTaikhoan.Text = nhanvien.Username;
            txtMatkhau.Text = nhanvien.Pasword;
            txtTen.Text = nhanvien.Hovaten;
            if (nhanvien.Gioitinh == false)
            {
                rbnNu.Checked = true;
            }
            else
            {
                rbnNam.Checked = true;
            }
            txtSDT.Text = nhanvien.Sodienthoai;
            txtDiachi.Text = nhanvien.Diachi;
            txtEmail.Text = nhanvien.Email;
            dateSinh.Text = nhanvien.Ngaysinh.ToString();
            cmbChucvu.SelectedIndex = _list.FindIndex(x => x == nhanvien.Machucvu);
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (!checksdt(txtSDT.Text))
            {
                MessageBox.Show("Số điện thoại tồn tại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (Checkrong(txtEmail.Text, txtTaikhoan.Text))
            {
                Taikhoan taikhoan = new Taikhoan();
                taikhoan.Username = txtTaikhoan.Text;
                taikhoan.Pasword = txtMatkhau.Text;
                taikhoan.Hovaten = txtTen.Text;
                taikhoan.Gioitinh = rbnNam.Checked;
                taikhoan.Sodienthoai = txtSDT.Text;
                taikhoan.Diachi = txtDiachi.Text;
                taikhoan.Email = txtEmail.Text;
                taikhoan.Ngaysinh = dateSinh.Value;
                taikhoan.Machucvu = _list[cmbChucvu.SelectedIndex];
                taikhoan.Ngaytaotaikhoan = DateTime.Now;
                taikhoan.Trangthai = true;
                var relust = MessageBox.Show("Xác nhận muốm thêm", "Xác nhận", MessageBoxButtons.YesNo);
                if (relust == DialogResult.Yes)
                {
                    MessageBox.Show(_service.AddNhanVien(taikhoan));
                }
                LoadGird(null);
            }
        }
        private void btnSua_Click(object sender, EventArgs e)
        {
            if (Checkrong(txtEmail.Text, null))
            {
                Taikhoan taikhoan = new Taikhoan();
                taikhoan.Mataikhoan = _idWhenclick;
                taikhoan.Username = txtTaikhoan.Text;
                taikhoan.Pasword = txtMatkhau.Text;
                taikhoan.Hovaten = txtTen.Text;
                taikhoan.Gioitinh = rbnNam.Checked;
                taikhoan.Sodienthoai = txtSDT.Text;
                taikhoan.Diachi = txtDiachi.Text;
                taikhoan.Email = txtEmail.Text;
                taikhoan.Ngaysinh = dateSinh.Value;
                taikhoan.Machucvu = _list[cmbChucvu.SelectedIndex];
                var relust = MessageBox.Show("Xác nhận muốm sửa", "Xác nhận", MessageBoxButtons.YesNo);
                if (relust == DialogResult.Yes)
                {
                    MessageBox.Show(_service.UpdateNhanVien(taikhoan));
                }
                LoadGird(null);
            }
        }

        private void btnkhoamokhoa_Click(object sender, EventArgs e)
        {
            Taikhoan taikhoan = new Taikhoan();
            taikhoan.Mataikhoan = _idWhenclick;
            var relust = MessageBox.Show("Xác nhận muốm Khoá/Mở khoá", "Xác nhận", MessageBoxButtons.YesNo);
            if (relust == DialogResult.Yes)
            {
                MessageBox.Show(_service.Khoa_Mokhoa(taikhoan));
            }
            LoadGird(null);
        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            txtTaikhoan.Text = "";
            txtMatkhau.Text = "";
            txtTen.Text = "";
            txtSDT.Text = "";
            rbnNam.Checked = true;
            txtDiachi.Text = "";
            txtEmail.Text = "";
            dateSinh.Text = "";
            cmbChucvu.SelectedIndex = 0;
        }
        private void txtTimkiem_TextChanged(object sender, EventArgs e)
        {
            LoadGird(txtTimKiem.Text);
        }
        public bool Checkrong(string email, string username)
        {
            if (string.IsNullOrEmpty(txtTaikhoan.Text)
                || string.IsNullOrEmpty(txtMatkhau.Text)
                || string.IsNullOrEmpty(txtTen.Text)
                || string.IsNullOrEmpty(txtSDT.Text)
                || string.IsNullOrEmpty(txtDiachi.Text)
                || string.IsNullOrEmpty(txtEmail.Text))
            {
                MessageBox.Show("Vui lòng nhập đủ dữ liệu.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (!Regex.IsMatch(txtSDT.Text, @"^\d{10}$"))
            {
                MessageBox.Show("Số điện thoại 0 hợp lệ", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (!IsValidEmail(email))
            {
                MessageBox.Show("Email không hợp lệ", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (!checkusername(username))
            {
                MessageBox.Show("Username tồn tại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }
        private bool IsValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }
        private bool checkusername(string username)
        {
            int dem = 0;
            foreach (Taikhoan taikhoan in _service.GetTaikhoan(null))
            {
                if (taikhoan.Username == username)
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
        private bool checksdt(string sodienthoai)
        {
            int dem = 0;
            foreach (Taikhoan taikhoan in _service.GetTaikhoan(null))
            {
                if (taikhoan.Sodienthoai == sodienthoai)
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
        private void dgvHienThi_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            if (e.ColumnIndex == dgvHienThi.ColumnCount - 1)
            {
                e.Cancel = true;
            }
        }

        private void btnexcel_Click(object sender, EventArgs e)
        {
            using (ExcelPackage excelPackage = new ExcelPackage())
            {
                ExcelWorksheet worksheet = excelPackage.Workbook.Worksheets.Add("Sheet1");

                for (int i = 0; i < dgvHienThi.Columns.Count; i++)
                {
                    worksheet.Cells[1, i + 1].Value = dgvHienThi.Columns[i].HeaderText;
                }

                for (int i = 0; i < dgvHienThi.Rows.Count; i++)
                {
                    for (int j = 0; j < dgvHienThi.Columns.Count; j++)
                    {
                        worksheet.Cells[i + 2, j + 1].Value = dgvHienThi.Rows[i].Cells[j].Value?.ToString();
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
