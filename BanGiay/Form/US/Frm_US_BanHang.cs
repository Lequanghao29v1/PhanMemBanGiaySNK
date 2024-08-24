using BUS.Services;
using DAL.Models.Context;
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

namespace BanGiay.Form.US
{
    public partial class Frm_US_BanHang : UserControl
    {
        public Frm_US_BanHang()
        {
            InitializeComponent();
        }
        BanHangService _service = new BanHangService();
        UudaiService _ser_UuDai = new UudaiService();
        HinhThucTTService _ser_HinhThucThanhToan = new HinhThucTTService();
        Giay_ChiTietGiayService _Ser_Giay_ChiTietGiay = new Giay_ChiTietGiayService();
        ChiTietGiayService _ser_GiayChiTiet = new ChiTietGiayService();
        HoaDonService _Ser_HoaDon = new HoaDonService();
        DangNhap_Frm formDangNhap = new DangNhap_Frm();
        TimKhachhang_Frm formTimKhachHang = new TimKhachhang_Frm();
        KhachHangService _Ser_KhachHang = new KhachHangService();
        HoaDonChiTIetService _Ser_HoaDonChiTiet = new HoaDonChiTIetService();
        List<HoaDonChiTiet_SP> _lstHoadonChiTiet = new List<HoaDonChiTiet_SP>();
        List<Giay_ChiTietGiay> _lstGiay_ChiTietGiay = new List<Giay_ChiTietGiay>();
        List<HoaDon_Model> _lstHoaDon = new List<HoaDon_Model>();
        List<Hinhthucthanhtoan> _lstHinhThucThanhToan = new List<Hinhthucthanhtoan>();

        List<int> idHoaDonChiTiet_Clicked = new List<int>();
        List<int> idHoaDon_ChuaThanhToan = new List<int>();
        DateTime dateTime = DateTime.Now;
        int idSanPham_Clicked;
        int idHoaDon_Clicked;

        public void LoadGridHD(string? txtSearch, string? Searchtype)
        {
            int stt = 1;
            dgv_HD.ColumnCount = 9;
            dgv_HD.Columns[0].Name = "STT";
            dgv_HD.Columns[1].Name = "Mã hoá đơn";
            dgv_HD.Columns[2].Name = "Tên ưu đãi";
            dgv_HD.Columns[3].Name = "Ngày tạo";
            dgv_HD.Columns[4].Name = "Người tạo";
            dgv_HD.Columns[5].Name = "Tên Khách hàng";
            dgv_HD.Columns[6].Name = "Hình thức thanh toán";
            dgv_HD.Columns[7].Name = "Tổng tiền";
            dgv_HD.Columns[8].Name = "Trạng thái";

            dgv_HD.Rows.Clear();
            _lstHoaDon = _Ser_HoaDon.GetAll("false", "Trạng thái hóa đơn");
            foreach (var x in _lstHoaDon)
            {
                dgv_HD.Rows.Add(stt++, x.Hoadon.Mahoadon, x.tenUuDai, x.Hoadon.Ngaytao, x.tenTaiKhoan, x.tenKhachHang, x.tenHinhThucThanhToan, x.Hoadon.Tongtien == null ? "N/A" : x.Hoadon.Tongtien, x.Hoadon.Trangthai == true ? "Đã thanh toán" : "Chưa thanht toán");
            }

            dgv_HD.Columns[0].Width = 30;
        }
        public void LoadGridGH(int? idHoaDOn, string? SearchType)
        {
            int stt = 1;
            dgvHDCT.ColumnCount = 11;
            dgvHDCT.Columns[0].Name = "STT";
            dgvHDCT.Columns[1].Name = "Mã hóa đơn";
            dgvHDCT.Columns[2].Name = "Tên";
            dgvHDCT.Columns[3].Name = "Thương hiệu";
            dgvHDCT.Columns[4].Name = "Kích cỡ";
            dgvHDCT.Columns[5].Name = "Màu sắc";
            dgvHDCT.Columns[6].Name = "chất liệu";
            dgvHDCT.Columns[7].Name = "Kiểu dáng";
            dgvHDCT.Columns[8].Name = "Số lượng mua";
            dgvHDCT.Columns[9].Name = "Thành tiền";
            dgvHDCT.Columns[10].Name = "ID Hóa đơn chi tiết";
            dgvHDCT.Columns[10].Visible = false;

            dgvHDCT.Rows.Clear();
            _lstHoadonChiTiet = _Ser_HoaDonChiTiet.GetAll(idHoaDOn.ToString(), SearchType);
            foreach (var e in _lstHoadonChiTiet)
            {
                dgvHDCT.Rows.Add(stt++, e.Hoadonchitiet.Mahoadon, e.tenGiay, e.tenThuongHieu, e.tenKichCo, e.tenMauSac, e.tenChatLieu, e.tenKieuDang, e.Hoadonchitiet.Soluongmua, e.tongTien, e.Hoadonchitiet.Mahoadonchitiet);
            }
            DataGridViewCheckBoxColumn ChooseObj = new DataGridViewCheckBoxColumn();
            ChooseObj.HeaderText = "Chọn";
            ChooseObj.Name = "Chon";
            dgvHDCT.Columns.Add(ChooseObj);

            dgvHDCT.Columns[0].Width = 30;

        }
        public void LoadGridSP(string? txtSearch, string? Searchtype)
        {
            int stt = 1;
            dgvSP.ColumnCount = 10;
            dgvSP.Columns[0].Name = "STT";
            dgvSP.Columns[1].Name = "Mã giày chi tiết";
            dgvSP.Columns[2].Name = "Tên giày";
            dgvSP.Columns[3].Name = "Thương hiệu";
            dgvSP.Columns[4].Name = "Kích cỡ";
            dgvSP.Columns[5].Name = "Màu sắc";
            dgvSP.Columns[6].Name = "chất liệu";
            dgvSP.Columns[7].Name = "Kiểu dáng";
            dgvSP.Columns[8].Name = "Số lượng";
            dgvSP.Columns[9].Name = "Giá";
            dgvSP.Rows.Clear();
            if (txtSearch == null && Searchtype == null)
            {
                _lstGiay_ChiTietGiay = _Ser_Giay_ChiTietGiay.GetAll("true", "Trạng thái Giày");
            }
            else
            {
                _lstGiay_ChiTietGiay = _Ser_Giay_ChiTietGiay.GetAll(txtSearch, Searchtype);

            }
            foreach (var item in _lstGiay_ChiTietGiay)
            {
                dgvSP.Rows.Add(stt++, item.giaychitiet.Magiaychitiet, item.tenGiay, item.tenThuongHieu, item.tenKichCo, item.tenMauSac, item.tenChatLieu, item.tenKieuDang, item.soLuongCon, item.gia);
            }
        }
        private void LoadHinhThucThanhToan()
        {
            _lstHinhThucThanhToan = _ser_HinhThucThanhToan.GetHinhthucTT(null);
            cbbHinhThucThanhToan.DataSource = _lstHinhThucThanhToan.ToList();
            cbbHinhThucThanhToan.DisplayMember = "TENHINHTHUC";
            cbbHinhThucThanhToan.ValueMember = "MAHINHTHUCTHANHTOAN";
            cbbHinhThucThanhToan.SelectedIndex = 0;

        }
        private void dgv_HD_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;

            if (index < 0 || index >= _lstHoaDon.Count)
            {
                return;
            }

            var objCellClick = _lstHoaDon[index];

            idHoaDon_Clicked = objCellClick.Hoadon.Mahoadon;
            try
            {

                var confirmResult = MessageBox.Show($"Xác nhận 'chọn' hóa đơn có mã '{objCellClick.Hoadon.Mahoadon}' không?", "Xác nhận", MessageBoxButtons.OKCancel);

                if (confirmResult == DialogResult.OK)
                {
                    txtMaHoaDon.Text = objCellClick.Hoadon.Mahoadon.ToString();
                    txtMaNhanVien.Text = objCellClick.Hoadon.Mataikhoan.ToString();
                    txtMaKhachhang.Text = objCellClick.Hoadon.Makhachhang.ToString();
                    txtTenKhachHang.Text = objCellClick.tenKhachHang.ToString();
                    txtDiem_KH.Text = objCellClick.diemKhachHang.ToString();
                    LoadGridGH(objCellClick.Hoadon.Mahoadon, "Mã hóa đơn");
                }
                else
                {
                    MessageBox.Show("Đã hủy 'chọn' hóa đơn này");
                }
                txtTongTienSP.Text = TinhTongTien_HoaDon(dgvHDCT).ToString();
                LoadTien_ThanhToan();

            }
            catch (Exception ex)
            {

                Console.WriteLine($"Thông tin chi tiết: {ex.ToString()}");
            }


        }
        private void dgvSP_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int index = e.RowIndex;

                if (index < 0 || index >= _lstGiay_ChiTietGiay.Count)
                {
                    return;
                }
                var objCellClick = _lstGiay_ChiTietGiay[index];
                idSanPham_Clicked = objCellClick.giaychitiet.Magiaychitiet;
                SoLuongMua_Frm formSoluongMua = new SoLuongMua_Frm();
                formSoluongMua.ShowDialog();

                if (formSoluongMua.soLuongMua > 0 && formSoluongMua.soLuongMua < objCellClick.giaychitiet.Soluongcon && txtMaHoaDon.Text != "N/A")
                {
                    if (_lstHoadonChiTiet.Any(a => a.Hoadonchitiet.Magiaychitiet == idSanPham_Clicked))
                    {
                        var Obj = _lstHoadonChiTiet.FirstOrDefault(a => a.Hoadonchitiet.Magiaychitiet == idSanPham_Clicked);

                        var Sua = _Ser_HoaDonChiTiet.Sua(Obj.Hoadonchitiet.Mahoadonchitiet, new Hoadonchitiet()
                        {
                            Magiaychitiet = Obj.Hoadonchitiet.Magiaychitiet,
                            Mahoadon = int.Parse(txtMaHoaDon.Text),
                            Soluongmua = Obj.Hoadonchitiet.Soluongmua + formSoluongMua.soLuongMua,
                            Gia = objCellClick.giaychitiet.Gia * (Obj.Hoadonchitiet.Soluongmua + formSoluongMua.soLuongMua),
                        });

                        if (Sua)
                        {
                            MessageBox.Show("Đã 'thêm' thành công 1 giày mới vào hóa đơn.");
                            var objGiayDaTonTai = _ser_GiayChiTiet.GetByID(idSanPham_Clicked);
                            objGiayDaTonTai.Soluongcon = objGiayDaTonTai.Soluongcon - formSoluongMua.soLuongMua;
                            objGiayDaTonTai.Ngaysua = dateTime;
                            var a = _ser_GiayChiTiet.Sua(idSanPham_Clicked, objGiayDaTonTai);
                            LoadGridGH(int.Parse(txtMaHoaDon.Text), "Mã hóa đơn");
                            LoadGridSP(null, null);
                        }
                        else
                        {
                            MessageBox.Show("'Thêm' thất bại");
                        }
                    }
                    else
                    {
                        var result = _Ser_HoaDonChiTiet.Them(new Hoadonchitiet()
                        {
                            Magiaychitiet = idSanPham_Clicked,
                            Mahoadon = int.Parse(txtMaHoaDon.Text),
                            Soluongmua = formSoluongMua.soLuongMua,
                            Gia = objCellClick.giaychitiet.Gia * formSoluongMua.soLuongMua,
                        });

                        if (result)
                        {
                            MessageBox.Show("Đã 'thêm' thành công 1 giày mới vào hóa đơn");
                            var objGiayChuaTonTai = _ser_GiayChiTiet.GetByID(idSanPham_Clicked);
                            objGiayChuaTonTai.Soluongcon = objGiayChuaTonTai.Soluongcon - formSoluongMua.soLuongMua;
                            objGiayChuaTonTai.Ngaysua = dateTime;
                            var a = _ser_GiayChiTiet.Sua(idSanPham_Clicked, objGiayChuaTonTai);
                            LoadGridGH(int.Parse(txtMaHoaDon.Text), "Mã hóa đơn");
                        }
                        else
                        {
                            MessageBox.Show("'Thêm' thất bại");
                        }
                    }
                    var objHoaDon_TongTien = _Ser_HoaDon.GetByID(int.Parse(txtMaHoaDon.Text));
                    objHoaDon_TongTien.Tongtien = TinhTongTien_HoaDon(dgvHDCT);
                    _Ser_HoaDon.Sua(int.Parse(txtMaHoaDon.Text), objHoaDon_TongTien);
                    LoadGridHD(null, null);

                }
                else
                {
                    if (txtMaHoaDon.Text == "N/A")
                    {
                        MessageBox.Show("Chưa chọn hóa đơn!");
                        return;
                    }
                    else if (formSoluongMua.soLuongMua == 0)
                    {
                        MessageBox.Show("Vui lòng chọn số lượng hợp lệ");
                    }
                    else
                    {

                        MessageBox.Show($"Không đủ số lượng! Chỉ còn {objCellClick.giaychitiet.Soluongcon} đôi.");
                    }
                }
                LoadGridSP(null, null);
                txtTongTienSP.Text = TinhTongTien_HoaDon(dgvHDCT).ToString();
                LoadTien_ThanhToan();
            }
            catch (Exception ex)
            {

                Console.WriteLine($"Thông tin chi tiết: {ex.ToString()}");
            }
        }
        private void pictureBox3_Click(object sender, EventArgs e)
        {
            LoadGridSP(null, null);
        }
        private void ptbThemHoaDon_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    var objUuDai = _ser_UuDai.GetUudai_InTime();
            //    var confirmResult = MessageBox.Show("Xác nhận 'thêm' hóa đơn không?", "Xác nhận", MessageBoxButtons.OKCancel);

            //    if (confirmResult == DialogResult.OK)
            //    {
            //        var result = _Ser_HoaDon.Them(new Hoadon()
            //        {
            //            Mataikhoan = LoginManager.Instance.IdTaiKhoan,
            //            Mauudai = objUuDai.Mauudai == null ? 1 : objUuDai.Mauudai,
            //            Makhachhang = 1,
            //            Mahinhthucthanhtoan = 1,
            //            Tencuahang = "",
            //            Diachicuahang = "",
            //            Sdtcuahang = "",
            //            Emailcuahang = "",
            //            Ngaytao = dateTime,
            //            Tongtien = null,
            //            Ghichu = "",
            //            Trangthai = false
            //        });

            //        if (result)
            //        {
            //            MessageBox.Show("Đã 'thêm' thành công 1 hóa đơn mới");

            //            LoadGridHD(null, null);
            //        }
            //        else
            //        {
            //            MessageBox.Show("'Thêm' thất bại");
            //        }
            //    }
            //    else
            //    {
            //        MessageBox.Show("Đã hủy 'thêm' hóa đơn");
            //    }
            //}
            //catch (Exception ex)
            //{

            //    Console.WriteLine($"Thông tin chi tiết: {ex.ToString()}");
            //}
            try
            {
                var objUuDai = _ser_UuDai.GetUudai_InTime();
                if (objUuDai == null)
                {
                    MessageBox.Show("Không tìm thấy ưu đãi");
                    return;
                }

                var confirmResult = MessageBox.Show("Xác nhận 'thêm' hóa đơn không?", "Xác nhận", MessageBoxButtons.OKCancel);

                if (confirmResult == DialogResult.OK)
                {
                    var newHoaDon = new Hoadon()
                    {
                        Mataikhoan = LoginManager.Instance.IdTaiKhoan,
                        Mauudai = objUuDai.Mauudai == null ? 1 : objUuDai.Mauudai,
                        Makhachhang = 1,
                        Mahinhthucthanhtoan = 1,
                        Tencuahang = "",
                        Diachicuahang = "",
                        Sdtcuahang = "",
                        Emailcuahang = "",
                        Ngaytao = dateTime,
                        Tongtien = null,
                        Ghichu = "",
                        Trangthai = false
                    };

                    var result = _Ser_HoaDon.Them(newHoaDon);

                    if (result == null)
                    {
                        MessageBox.Show("Không thể thêm hóa đơn");
                        return;
                    }

                    if (result)
                    {
                        MessageBox.Show("Đã 'thêm' thành công 1 hóa đơn mới");

                        LoadGridHD(null, null);
                    }
                    else
                    {
                        MessageBox.Show("'Thêm' thất bại");
                    }
                }
                else
                {
                    MessageBox.Show("Đã hủy 'thêm' hóa đơn");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Thông tin chi tiết: {ex.ToString()}");
            }


        }
        private void ptbChonKhachHang_Click(object sender, EventArgs e)
        {
            if (txtMaHoaDon.Text == "N/A" || txtMaHoaDon.Text == "N/A")
            {
                MessageBox.Show("Vui lòng chọn hóa đơn trước!");
            }
            else
            {
                TimKhachhang_Frm formTimKhachHang = new TimKhachhang_Frm();
                formTimKhachHang.ShowDialog();
                LoadKhachHang(formTimKhachHang.ChooseID);
                chbox_Dung_DiemKH.Enabled = true;

                var objHoaDon_KhachHang = _Ser_HoaDon.GetByID(int.Parse(txtMaHoaDon.Text));
                objHoaDon_KhachHang.Makhachhang = int.Parse(txtMaKhachhang.Text);
                _Ser_HoaDon.Sua(int.Parse(txtMaHoaDon.Text), objHoaDon_KhachHang);
                LoadGridHD(null, null);
                chbox_Dung_DiemKH.Checked = false;
            }
        }
        public void LoadKhachHang(int? id)
        {
            var Obj = _Ser_KhachHang.GetAllKhachhang(null).FirstOrDefault(x => x.Makhachhang == id);
            if (Obj == null)
            {
                return;
            }
            txtMaKhachhang.Text = Obj.Makhachhang == null ? "N/A" : Obj.Makhachhang.ToString();
            txtTenKhachHang.Text = Obj.Tenkhachhang == null ? "N/A" : Obj.Tenkhachhang.ToString();
            txtMaNhanVien.Text = LoginManager.Instance.IdTaiKhoan.ToString();
            txtDiem_KH.Text = Obj.Diemkhachhang == null ? "0 điểm" : Obj.Diemkhachhang.ToString() + " điểm";
        }
        private void btnXoa_Click(object sender, EventArgs e)
        {
            int soluongMuonXoa = (int)txtSoLuongMuonXoa.Value;
            if (idHoaDonChiTiet_Clicked.Count == 0)
            {
                MessageBox.Show("Vui lòng tích vào ô chọn ở cuối bảng bên phải!");
            }
            else
            {
                try
                {
                    var confirmResult = MessageBox.Show("Xác nhận 'xóa' mặt hàng trong hóa đơn không?", "Xác nhận", MessageBoxButtons.OKCancel);

                    if (confirmResult == DialogResult.OK)
                    {
                        if (soluongMuonXoa <= 0)
                        {
                            foreach (var item in idHoaDonChiTiet_Clicked)
                            {
                                var objHoaDonDaCanXoa = _Ser_HoaDonChiTiet.GetByID(item);
                                var objGiayCanSua = _ser_GiayChiTiet.GetByID(objHoaDonDaCanXoa.Magiaychitiet);
                                objGiayCanSua.Soluongcon = objGiayCanSua.Soluongcon + objHoaDonDaCanXoa.Soluongmua;
                                var a = _ser_GiayChiTiet.Sua(objHoaDonDaCanXoa.Magiaychitiet, objGiayCanSua);
                                var result = _Ser_HoaDonChiTiet.Xoa(item);

                            }
                            MessageBox.Show("Đã 'xóa' mặt hàng trong hóa đơn");
                            LoadGridSP(null, null);
                            LoadGridGH(int.Parse(txtMaHoaDon.Text), "Mã hóa đơn");
                            LamMoi_IDHoaDon();
                        }
                        else
                        {
                            bool result;
                            foreach (var item in idHoaDonChiTiet_Clicked)
                            {
                                var objHoaDonDaCanXoa = _Ser_HoaDonChiTiet.GetByID(item);
                                var objGiayCanSua = _ser_GiayChiTiet.GetByID(objHoaDonDaCanXoa.Magiaychitiet);
                                objHoaDonDaCanXoa.Soluongmua = objHoaDonDaCanXoa.Soluongmua - soluongMuonXoa;
                                objHoaDonDaCanXoa.Gia = objHoaDonDaCanXoa.Soluongmua * objGiayCanSua.Gia;
                                objGiayCanSua.Soluongcon = objGiayCanSua.Soluongcon + soluongMuonXoa;
                                var a = _ser_GiayChiTiet.Sua(objHoaDonDaCanXoa.Magiaychitiet, objGiayCanSua);
                                if (objHoaDonDaCanXoa.Soluongmua <= 0)
                                {
                                    result = _Ser_HoaDonChiTiet.Xoa(item);
                                }
                                else
                                {
                                    result = _Ser_HoaDonChiTiet.Sua(item, objHoaDonDaCanXoa);
                                }
                            }
                            MessageBox.Show("Đã 'xóa' mặt hàng trong hóa đơn");
                            LoadGridSP(null, null);
                            LoadGridGH(int.Parse(txtMaHoaDon.Text), "Mã hóa đơn");
                            LamMoi_IDHoaDon();
                            txtSoLuongMuonXoa.Value = 0;



                        }

                    }
                    else
                    {
                        MessageBox.Show("Đã hủy 'xóa' hóa đơn");
                    }
                    idHoaDonChiTiet_Clicked.Clear();
                    txtTongTienSP.Text = TinhTongTien_HoaDon(dgvHDCT).ToString();
                    LoadTien_ThanhToan();
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Thông tin chi tiết: {ex.ToString()}");
                }
            }
        }
        private void dgvHDCT_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgvHDCT.Columns["Chon"].Index && e.RowIndex >= 0)
            {
                DataGridViewCheckBoxCell checkBoxCell = (DataGridViewCheckBoxCell)dgvHDCT.Rows[e.RowIndex].Cells["Chon"];

                checkBoxCell.Value = !Convert.ToBoolean(checkBoxCell.Value);

                int idHoaDonChiTiet = Convert.ToInt32(dgvHDCT.Rows[e.RowIndex].Cells["ID Hóa đơn chi tiết"].Value);

                if (Convert.ToBoolean(checkBoxCell.Value))
                {
                    idHoaDonChiTiet_Clicked.Add(idHoaDonChiTiet);
                }
                else
                {
                    idHoaDonChiTiet_Clicked.Remove(idHoaDonChiTiet);
                }

                StringBuilder sb = new StringBuilder();
                foreach (int id in idHoaDonChiTiet_Clicked)
                {
                    sb.Append(id.ToString());
                    sb.Append(", ");
                }
                string danhSachIdText = sb.ToString().TrimEnd(',', ' ');
                txtID_HDCT.Text = danhSachIdText;
            }
        }
        private void btnChonTatCa_Click(object sender, EventArgs e)
        {
            if (CheckIfAnyChecked() == false)
            {
                idHoaDonChiTiet_Clicked.Clear();

                foreach (DataGridViewRow row in dgvHDCT.Rows)
                {
                    row.Cells["Chon"].Value = true;

                    int idHoaDonChiTiet = Convert.ToInt32(row.Cells["ID Hóa đơn chi tiết"].Value);

                    idHoaDonChiTiet_Clicked.Add(idHoaDonChiTiet);
                }

                StringBuilder sb = new StringBuilder();
                foreach (int id in idHoaDonChiTiet_Clicked)
                {
                    sb.Append(id.ToString());
                    sb.Append(", ");
                }
                string danhSachIdText = sb.ToString().TrimEnd(',', ' ');
                txtID_HDCT.Text = danhSachIdText;

            }
            else
            {
                foreach (DataGridViewRow row in dgvHDCT.Rows)
                {
                    row.Cells["Chon"].Value = false;
                }

                idHoaDonChiTiet_Clicked.Clear();
                txtID_HDCT.Text = "";

                StringBuilder sb = new StringBuilder();
                foreach (int id in idHoaDonChiTiet_Clicked)
                {
                    sb.Append(id.ToString());
                    sb.Append(", ");
                }
                string danhSachIdText = sb.ToString().TrimEnd(',', ' ');
                txtID_HDCT.Text = danhSachIdText;

            }
        }
        private void Frm_BanHang_Load(object sender, EventArgs e)
        {
            LoadGridHD(null, null);
            LoadGridSP(null, null);
            txtID_HDCT.BorderStyle = BorderStyle.FixedSingle;
            LoadMaGiamGia();
            LoadHinhThucThanhToan();
        }
        private void ptbLamMoiIdHoaDonChiTiet_Click(object sender, EventArgs e)
        {
            LamMoi_IDHoaDon();
        }
        private void LamMoi_IDHoaDon()
        {
            foreach (DataGridViewRow row in dgvHDCT.Rows)
            {
                row.Cells["Chon"].Value = false;
            }

            idHoaDonChiTiet_Clicked.Clear();
            txtID_HDCT.Text = "";


            StringBuilder sb = new StringBuilder();
            foreach (int id in idHoaDonChiTiet_Clicked)
            {
                sb.Append(id.ToString());
                sb.Append(", ");
            }
            string danhSachIdText = sb.ToString().TrimEnd(',', ' ');
            txtID_HDCT.Text = danhSachIdText;

        }
        private bool CheckIfAnyChecked()
        {
            bool isChecked = false;
            foreach (DataGridViewRow row in dgvHDCT.Rows)
            {
                DataGridViewCheckBoxCell checkBoxCell = row.Cells["Chon"] as DataGridViewCheckBoxCell;

                if (checkBoxCell != null && Convert.ToBoolean(checkBoxCell.Value))
                {
                    isChecked = true;
                    break;
                }
            }
            return isChecked;
        }
        private void LoadMaGiamGia()
        {
            //var objUuDai = _ser_UuDai.GetUudai_InTime();
            //txtGiamGia.Text = objUuDai.Soluong <= 0 || objUuDai == null ? "Đã hết ưu đãi" : objUuDai.Phantram.ToString() + " % - " + objUuDai.Tenuudai.ToString(); ;
            var objUuDai = _ser_UuDai.GetUudai_InTime();
            if (objUuDai != null)
            {
                txtGiamGia.Text = objUuDai.Soluong <= 0 ? "Đã hết ưu đãi" : objUuDai.Phantram.ToString() + " % - " + objUuDai.Tenuudai.ToString();
            }
            else
            {
                txtGiamGia.Text = "Đã hết ưu đãi";
            }
        }
        private double TinhTongTien_HoaDon(DataGridView dataGridView)
        {
            double tongTien = 0;

            foreach (DataGridViewRow row in dataGridView.Rows)
            {
                if (!row.IsNewRow)
                {
                    object cellValue = row.Cells["Thành tiền"].Value;

                    if (cellValue != null && double.TryParse(cellValue.ToString(), out double giaTriCot))
                    {
                        tongTien += giaTriCot;
                    }
                }
            }
            return tongTien;
        }
        private void txtSoTienNhan_TextChanged(object sender, EventArgs e)
        {
            LoadSoTienNhan();
            cboxDungDiemKH_CheckedChanged(this, EventArgs.Empty);
        }
        private void LoadSoTienNhan()
        {
            if (txtSoTienNhan.Text == "")
            {
                txtGhiChu.Text = "";
                txtSoTienThieu.Text = txtTongTien.Text;
                txtSoTienThua.Text = "0";
            }
            if (double.TryParse(txtSoTienNhan.Text, out double soTienNhan))
            {

                double tongTien = double.Parse(txtTongTien.Text);
                double soTienThua = soTienNhan - tongTien;
                double soTienThieu = tongTien - soTienNhan;

                txtSoTienThua.Text = soTienThua >= 0 ? soTienThua.ToString() : "0";
                txtSoTienThieu.Text = soTienThieu >= 0 ? soTienThieu.ToString() : "0";
                txtGhiChu.Text = $"khách đưa: {soTienNhan} - khách nhận: {(soTienThua >= 0 ? soTienThua.ToString() : "0")}";
            }
        }
        private void cboxDungDiemKH_CheckedChanged(object sender, EventArgs e)
        {
            LoadTien_ThanhToan();
            var Obj = _Ser_KhachHang.GetAllKhachhang(null).FirstOrDefault(x => x.Makhachhang == int.Parse(txtMaKhachhang.Text));
            var objUuDai = _ser_UuDai.GetUudai_InTime();

            double tongTienSP = TinhTongTien_HoaDon(dgvHDCT);
            int? phanTram_GiamGia = PhanTramUuDai(objUuDai);
            int? diemKH = Obj.Diemkhachhang;

            double giamGia = tongTienSP * (phanTram_GiamGia ?? 0) / 100;
            double giamGiaDiemKH = (diemKH ?? 0) * 1000;

            if (chbox_Dung_DiemKH.Checked)
            {
                txtTongTien.Text = (tongTienSP - giamGia - giamGiaDiemKH).ToString();
                LoadSoTienNhan();
                txtGhiChu.Text += $" - Đã dùng {Obj.Diemkhachhang} điểm = {Obj.Diemkhachhang * 1000} VNĐ";
            }
            else
            {
                txtTongTien.Text = (tongTienSP - giamGia).ToString();
                LoadSoTienNhan();
                string diemDungTruocDo = $" - Đã dùng {Obj.Diemkhachhang} điểm = {Obj.Diemkhachhang * 1000} VNĐ";
                txtGhiChu.Text = txtGhiChu.Text.Replace(diemDungTruocDo, "");
            }

        }
        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            if (cbbHinhThucThanhToan.SelectedIndex == 0)
            {
                MessageBox.Show("Vui lòng lựa chọn hình thức thanh toán!");
            }
            else if (txtSoTienThieu.Text == "N/A")
            {
                MessageBox.Show("Bạn chưa nhận tiền!");
            }
            else if (int.Parse(txtSoTienThieu.Text) > 0)
            {
                MessageBox.Show("Bạn chưa nhận đủ tiền!");
            }
            else if (txtMaHoaDon.Text == "N/A")
            {
                MessageBox.Show("Vui lòng chọn mã hóa đơn");
            }
            else if (int.Parse(txtTongTienSP.Text) == 0 || txtTongTienSP.Text == "N/A")
            {
                MessageBox.Show("Vui lòng kiểm tra lại giỏ hàng!");
            }
            else if (txtTenKhachHang.Text == "N/A")
            {
                try
                {
                    var confirmResult = MessageBox.Show("Xác nhận 'thanh toán' hóa đơn mà không chọn 'khách hàng' không?", "Xác nhận", MessageBoxButtons.OKCancel);
                    if (confirmResult == DialogResult.OK)
                    {
                        var objUuDai = _ser_UuDai.GetUudai_InTime();
                        if (objUuDai.Soluong > 0)
                        {
                            objUuDai.Soluong = objUuDai.Soluong - 1;
                        }
                        var objHoaDon_ThanhToan = _Ser_HoaDon.GetByID(int.Parse(txtMaHoaDon.Text));
                        objHoaDon_ThanhToan.Trangthai = true;
                        objHoaDon_ThanhToan.Mahinhthucthanhtoan = (int)cbbHinhThucThanhToan.SelectedValue;
                        objHoaDon_ThanhToan.Tongtien = int.Parse(txtTongTien.Text);
                        objHoaDon_ThanhToan.Ghichu = txtGhiChu.Text;
                        _ser_UuDai.Updateuudai(objUuDai);

                        var result = _Ser_HoaDon.Sua(int.Parse(txtMaHoaDon.Text), objHoaDon_ThanhToan);

                        if (result)
                        {
                            MessageBox.Show("Đã 'thanh toán' thành công hóa đơn");

                            LoadGridHD(null, null);
                            dgvHDCT.Rows.Clear();
                        }
                        else
                        {
                            MessageBox.Show("'Thanh toán' thất bại. Có gì đó sai sai");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Đã hủy 'thanh toán' hóa đơn");
                    }
                }
                catch (Exception ex)
                {

                    Console.WriteLine($"Thông tin chi tiết: {ex.ToString()}");
                }
                LamMoi_ThanhToan();
            }
            else
            {
                try
                {
                    var confirmResult = MessageBox.Show("Xác nhận 'thanh toán' hóa đơn không?", "Xác nhận", MessageBoxButtons.OKCancel);
                    if (confirmResult == DialogResult.OK)
                    {
                        var objUuDai = _ser_UuDai.GetUudai_InTime();
                        if (objUuDai.Soluong > 0)
                        {
                            objUuDai.Soluong = objUuDai.Soluong - 1;
                        }
                        var objHoaDon_ThanhToan = _Ser_HoaDon.GetByID(int.Parse(txtMaHoaDon.Text));
                        objHoaDon_ThanhToan.Trangthai = true;
                        objHoaDon_ThanhToan.Mahinhthucthanhtoan = (int)cbbHinhThucThanhToan.SelectedValue;
                        objHoaDon_ThanhToan.Tongtien = int.Parse(txtTongTien.Text);
                        objHoaDon_ThanhToan.Ghichu = txtGhiChu.Text;
                        _ser_UuDai.Updateuudai(objUuDai);

                        var result = _Ser_HoaDon.Sua(int.Parse(txtMaHoaDon.Text), objHoaDon_ThanhToan);

                        if (result)
                        {
                            TimKhachhang_Frm formTimKhachHang = new TimKhachhang_Frm();
                            DBContext _db = new();
                            var objKhachhang = _db.Khachhangs.FirstOrDefault(a => a.Makhachhang == int.Parse(txtMaKhachhang.Text));
                            if (chbox_Dung_DiemKH.Checked == true)
                            {
                                objKhachhang.Diemkhachhang = 0;
                                _Ser_KhachHang.UpdateKhachHang(objKhachhang);
                            }
                            int? soluongMuaHang = 0;
                            foreach (var item in _lstHoadonChiTiet)
                            {
                                soluongMuaHang += item.Hoadonchitiet.Soluongmua;
                            }
                            objKhachhang.Diemkhachhang = objKhachhang.Diemkhachhang + soluongMuaHang;
                            _Ser_KhachHang.Sua(objKhachhang);

                            MessageBox.Show("Đã 'thanh toán' thành công hóa đơn");

                            LoadGridHD(null, null);
                            dgvHDCT.Rows.Clear();

                        }
                        else
                        {
                            MessageBox.Show("'Thanh toán' thất bại. Có gì đó sai sai");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Đã hủy 'thanh toán' hóa đơn");
                    }
                }
                catch (Exception ex)
                {

                    Console.WriteLine($"Thông tin chi tiết: {ex.ToString()}");
                }
                LamMoi_ThanhToan();
            }
        }
        private void txtDiemKH_TextChanged(object sender, EventArgs e)
        {
            if (txtDiem_KH.Text == "" || txtDiem_KH.Text == null)
            {
                return;
            }
            else
            {
                chbox_Dung_DiemKH.Enabled = true;
            }
        }
        private void LoadTien_ThanhToan()
        {
            var objUuDai = _ser_UuDai.GetUudai_InTime();
            var Obj = _Ser_KhachHang.GetAllKhachhang(null).FirstOrDefault(x => x.Makhachhang == (txtMaKhachhang.Text == "N/A" ? 1 : int.Parse(txtMaKhachhang.Text)));
            txtTongTienSP.Text = TinhTongTien_HoaDon(dgvHDCT).ToString();
            txtTongTien.Text = (TinhTongTien_HoaDon(dgvHDCT)
                - (int.Parse(txtTongTienSP.Text)
                * ((objUuDai.Soluong <= 0 ? 0 : double.Parse("0," + objUuDai.Phantram))))
                - ((chbox_Dung_DiemKH.Checked ? (Obj.Diemkhachhang == null || txtDiem_KH.Text == "" ? 0 : Obj.Diemkhachhang) : 0)
                * 1000)).ToString();

        }
        private void btnXoaHoaDon_Click(object sender, EventArgs e)
        {
            try
            {
                if (idHoaDon_Clicked == null)
                {
                    MessageBox.Show("Xóa thất bại!");
                }
                var confirmResult = MessageBox.Show("Xác nhận 'xóa' hóa đơn không?", "Xác nhận", MessageBoxButtons.OKCancel);

                if (confirmResult == DialogResult.OK)
                {

                    foreach (var item in _lstHoadonChiTiet)
                    {
                        var objHoaDonDaCanXoa = _Ser_HoaDonChiTiet.GetByID(item.Hoadonchitiet.Mahoadonchitiet);
                        var objGiayCanSua = _ser_GiayChiTiet.GetByID(objHoaDonDaCanXoa.Magiaychitiet);
                        objGiayCanSua.Soluongcon = objGiayCanSua.Soluongcon + objHoaDonDaCanXoa.Soluongmua;
                        _ser_GiayChiTiet.Sua(objHoaDonDaCanXoa.Magiaychitiet, objGiayCanSua);
                        var ketqua = _Ser_HoaDonChiTiet.Xoa(item.Hoadonchitiet.Mahoadonchitiet);

                    }
                    var result = _Ser_HoaDon.Xoa(idHoaDon_Clicked);
                    if (result)
                    {
                        MessageBox.Show("Xóa thành công!");
                        LoadGridHD(null, null);
                        LoadGridSP(null, null);
                        dgvHDCT.Rows.Clear();
                    }
                    else
                    {
                        MessageBox.Show("Xóa thất bại!");
                    }


                }
                else
                {
                    MessageBox.Show("Đã hủy 'xóa' hóa đơn");
                }
                txtTongTienSP.Text = TinhTongTien_HoaDon(dgvHDCT).ToString();
                LoadTien_ThanhToan();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Thông tin chi tiết: {ex.ToString()}");
            }

        }
        public void XoaHoaDon_ChuaThanhToan()
        {
            //
            _lstHoaDon.Clear();
            _lstHoaDon = _Ser_HoaDon.GetAll("false", "Trạng thái hóa đơn");
            _lstHoadonChiTiet.Clear();
            foreach (var item in _lstHoaDon)
            {
                _lstHoadonChiTiet = _Ser_HoaDonChiTiet.GetAll(item.Hoadon.Mahoadon.ToString(), "Mã hóa đơn");
            }
            foreach (var item in _lstHoadonChiTiet)
            {
                var objGiay_HoaDonChiTiet = _ser_GiayChiTiet.GetByID(item.Hoadonchitiet.Magiaychitiet);
                objGiay_HoaDonChiTiet.Soluongcon = objGiay_HoaDonChiTiet.Soluongcon + item.Hoadonchitiet.Soluongmua;
                var a = _ser_GiayChiTiet.Sua(item.Hoadonchitiet.Magiaychitiet, objGiay_HoaDonChiTiet);
                int? id = item.Hoadonchitiet.Mahoadonchitiet;
                var b = _Ser_HoaDonChiTiet.Xoa(id);
            }
            foreach (var item in _lstHoaDon)
            {
                var a = _Ser_HoaDon.Xoa(item.Hoadon.Mahoadon);

            }
            //
        }
        private int? PhanTramUuDai(Uudai uudai)
        {

            if (uudai.Soluong > 0)
            {
                return uudai.Phantram;
            }

            return 0;
        }
        private void btnTimKiem_SP_Click(object sender, EventArgs e)
        {
            LoadGridSP(txtTimKiem_SP.Text, "Tên giày");
        }
        private void LamMoi_ThanhToan()
        {
            //txtMaKhachhang.Text = "1";
            txtTenKhachHang.Text = "N/A";
            txtMaNhanVien.Text = "N/A";
            txtMaHoaDon.Text = "N/A";
            txtGiamGia.Text = "";
            cbbHinhThucThanhToan.SelectedIndex = 0;
            txtDiem_KH.Text = "";
            chbox_Dung_DiemKH.Checked = false;
            txtSoTienNhan.Text = "";
            txtTongTienSP.Text = "N/A";
            txtSoTienThua.Text = "N/A";
            txtSoTienThieu.Text = "N/A";
            txtTongTien.Text = "N/A";
            txtGhiChu.Text = "";
        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void cbbHinhThucThanhToan_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbHinhThucThanhToan.SelectedIndex == 0)
            {
               pictureBox1.Visible = false;
            }
            if (cbbHinhThucThanhToan.SelectedIndex == 1)
            {
                pictureBox1.Visible = false;
            }
            if (cbbHinhThucThanhToan.SelectedIndex == 2)
            {
                pictureBox1.Visible = true;
            }
            
        }

        private void txtTongTien_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
