using BUS.Services;
using DAL.Models.DomainClass;
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
    public partial class TimKhachhang_Frm : System.Windows.Forms.Form
    {
        KhachHangService _Ser_KhachHang = new KhachHangService();
        List<Khachhang> _lstKhachHang = new List<Khachhang>();
        int idClicked;
        public int ChooseID;
        int sdt;
        public TimKhachhang_Frm()
        {
            InitializeComponent(); LoadGird(null);
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            LoadGird(txtTimKiem.Text);
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            _lstKhachHang.Clear();
            _lstKhachHang = _Ser_KhachHang.GetAllKhachhang(null);
            if (txtTen.Text == "")
            {
                MessageBox.Show("Vui lòng nhập tên!");
            }
            else if (!int.TryParse(txtSdt.Text, out sdt))
            {
                MessageBox.Show("Vui lòng nhấp sđt hợp lệ");
            }
            else if (_lstKhachHang.Any(a => a.Sdt == txtSdt.Text))
            {
                MessageBox.Show("Số điện thoại này đã được đăng kí!");
            }
            else
            {
                Khachhang khachhang = new Khachhang();
                khachhang.Tenkhachhang = txtTen.Text;
                khachhang.Sdt = txtSdt.Text;
                khachhang.Diemkhachhang = 0;
                khachhang.Trangthai = true;


                MessageBox.Show(_Ser_KhachHang.AddKhachHang(khachhang));
                LoadGird(null);
            }
        }
        public void LoadGird(string search)
        {
            int stt = 1;
            dgv_Objects.ColumnCount = 6;
            dgv_Objects.Columns[0].Name = "STT";
            dgv_Objects.Columns[1].Name = "Mã";
            dgv_Objects.Columns[2].Name = "Tên";
            dgv_Objects.Columns[3].Name = "SDT";
            dgv_Objects.Columns[4].Name = "Điểm";
            dgv_Objects.Columns[5].Name = "Trạng Thái";
            dgv_Objects.Rows.Clear();

            foreach (var x in _Ser_KhachHang.GetAllKhachhang(search))
            {
                dgv_Objects.Rows.Add(stt++, x.Makhachhang, x.Tenkhachhang, x.Sdt, x.Diemkhachhang, x.Trangthai == false ? "Không hoạt động" : "Hoạt đông");
            }
        }

        private void btnChon_Click(object sender, EventArgs e)
        {
            try
            {

                var confirmResult = MessageBox.Show("Xác nhận 'chọn' khách hàng này không?", "Xác nhận", MessageBoxButtons.OKCancel);

                if (confirmResult == DialogResult.OK)
                {
                    var objKhachHang = _Ser_KhachHang.GetAllKhachhang(null).FirstOrDefault(a => a.Makhachhang == idClicked);
                    if (objKhachHang.Trangthai == true)
                    {
                        ChooseID = idClicked;
                        MessageBox.Show($"Đã chọn khách hàng có mã: {ChooseID}");
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Khách hàng này đã bị khóa.");
                    }
                }
                else
                {
                    MessageBox.Show("Đã hủy 'chọn' khách hàng");
                }
            }
            catch (Exception ex)
            {

                Console.WriteLine($"Thông tin chi tiết: {ex.ToString()}");
            }
        }

        private void dgv_Objects_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (index < 0 || index >= _Ser_KhachHang.GetAllKhachhang(null).Count)
            {
                return;
            }

            idClicked = int.Parse(dgv_Objects.Rows[index].Cells[1].Value.ToString());
            var khach = _Ser_KhachHang.GetAllKhachhang(null).FirstOrDefault(x => x.Makhachhang == idClicked);
            txtTen.Text = khach.Tenkhachhang;
            txtSdt.Text = khach.Sdt;
        }

        private void TimKhachhang_Frm_Load(object sender, EventArgs e)
        {
            loadDgvKhachHang(null);
        }
        public void loadDgvKhachHang(string? search)
        {
            int stt = 1;
            dgv_Objects.ColumnCount = 6;
            dgv_Objects.Columns[0].Name = "STT";
            dgv_Objects.Columns[1].Name = "Mã";
            dgv_Objects.Columns[2].Name = "Tên";
            dgv_Objects.Columns[3].Name = "SDT";
            dgv_Objects.Columns[4].Name = "Điểm";
            dgv_Objects.Columns[5].Name = "Trạng Thái";
            dgv_Objects.Rows.Clear();

            foreach (var x in _Ser_KhachHang.GetAllKhachhang(search))
            {
                dgv_Objects.Rows.Add(stt++, x.Makhachhang, x.Tenkhachhang, x.Sdt, x.Diemkhachhang, x.Trangthai == false ? "Không hoạt động" : "Hoạt đông");
            }

        }
    }
}
