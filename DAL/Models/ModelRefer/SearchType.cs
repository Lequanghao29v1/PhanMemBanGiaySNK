using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models.ModelRefer
{
    public class SearchType
    {
        public const string All = "All";
        public const string maChatLieu = "Mã chất liệu";
        public const string tenChatLieu = "Tên chất liệu";
        public const string moTaChatLieu = "Mô tả chất liệu";
        public const string trangThaiChatLieu = "Trạng thái Chất liệu";
        public const string idNguoiThemChatLieu = "ID Người thêm chất liệu";
        public const string maMauSac = "Mã màu sắc";
        public const string tenMauSac = "Tên màu sắc";
        public const string moTaMauSac = "Mô tả màu sắc";
        public const string trangThaiMauSac = "Trạng thái Màu sắc";
        public const string idNguoiThemMauSac = "ID Người thêm Màu sắc";
        public const string maKichCo = "Mã kích cỡ";
        public const string tenKichCo = "Tên kích cỡ";
        public const string moTaKichCo = "Mô tả kích cỡ";
        public const string trangThaiKichCo = "Trạng thái Kích cỡ";
        public const string idNguoiThemKichCo = "ID Người thêm kích cỡ";
        public const string maThuongHieu = "Mã thương hiệu";
        public const string tenThuongHieu = "Tên thương hiệu";
        public const string moTaThuongHieu = "Mô tả thương hiệu";
        public const string sdtThuongHieu = "Số điện thoại thương hiệu";
        public const string emailThuongHieu = "Email thương hiệu";
        public const string trangThaiThuongHieu = "Trạng thái Thương hiệu";
        public const string idNguoiThemThuongHieu = "ID Người thêm thương hiệu";
        public const string maGiay = "Mã giày";
        public const string maGiayChiTiet = "Mã giày chi tiết";
        public const string tenGiay = "Tên giày";
        public const string maHoaDonChiTiet = "Mã hóa đơn chi tiết";
        public const string soLuongMua_HoaDonChiTiet = "Số lượng mua";
        public const string gia_HoaDonChiTiet = "Giá";
        public const string maKhachHang = "Mã khách hàng";
        public const string tenKhachHang = "Tên khách hàng";
        public const string sdtKhachHang = "SĐT khách hàng";
        public const string diemKhachHang = "Điểm khách hàng";
        public const string trangThaiKhachHang = "Trạng thái Khách hàng";
        public const string maHoaDon = "Mã hóa đơn";
        public const string ngayTaoHoaDon = "Ngày tạo hóa đơn";
        public const string tongTienHoaDon = "Tổng tiền hóa đơn";
        public const string trangThaiHoaDon = "Trạng thái hóa đơn";
        public const string ghiChuHoaDon = "Ghi chú hóa đơn";
        public const string maHinhThucThanhToan = "Mã hình thức thanh toán";
        public const string tenHinhThucThanhToan = "Tên hình thức thanh toán";
        public const string moTaHinhThucThanhToan = "Mô tả hình thức thanh toán";
        public const string maChucVu = "Mã chức vụ";
        public const string tenChucVu = "Tên chức vụ";
        public const string moTaChucVu = "Mô tả chức vụ";
        public const string maTaiKhoan = "Mã tài khoản";
        public const string userNameTaiKhoan = "Tên đăng nhập";
        public const string passwordTaiKhoan = "Mật khẩu";
        public const string HoVaTenTaiKhoan = "Họ và tên";
        public const string gioiTinhTaiKhoan = "Giới tính";
        public const string sdtTaiKhoan = "Số điện thoại";
        public const string diaChiTaiKhoan = "Địa chỉ";
        public const string emailTaiKhoan = "Email";
        public const string ngayThangNamSinhTaiKhoan = "Ngày tháng năm sinh";
        public const string ngayTaoTaiKhoan = "Ngày tạo tài khoản";
        public const string trangThaiTaiKhoan = "Trạng thái Tài khoản";
        public const string maUuDai = "Mã Ưu đãi";
        public const string tenUuDai = "Tên Ưu đãi";
        public const string ngayBatDauUuDai = "Ngày bắt đầu Ưu đãi";
        public const string ngayKetThucUuDai = "Ngày kết thúc Ưu đãi";
        public const string phanTramUuDai = "Phần trăm giảm giá";
        public const string trangThaiUuDai = "Trạng thái Ưu đãi";
        public const string soLuongUuDai = "Số lượng Ưu đãi còn";
        public const string maKieuDang = "Mã kiểu dáng";
        public const string tenKieuDang = "Tên kiểu dáng";
        public const string moTaKieuDang = "Mô tả kiểu dáng";
        public const string trangThaiKieuDang = "Trạng thái Kiểu dáng";
        public const string idNguoiThemKieuDang = "ID Người thêm Kiểu dáng";
        public const string soLuongTrongKhoNhoHon = "số lượng <= (x) ";
        public const string soLuongTrongKhoLonHon = "số lượng >= (x) ";
        public const string ngayTao_GiayChiTiet = "Ngày tạo giày";
        public const string ngaySua_GiayChiTiet = "Ngày sửa giày";
        public const string idNguoiTao_GiayChiTiet = "Mã người tạo giày";
        public const string idNguoiSua_GiayChiTiet = "Mã người sửa giày";
        public const string tenNguoiSua_GiayChiTiet = "Tên người sửa giày";
        public const string tenNguoiTao_GiayChiTiet = "Tên người tạo giày";
        public const string giaLonHon_GiayChiTiet = "(x) <= giá";
        public const string giaNhoHon_GiayChiTiet = "(x) >= giá";
        public const string moTa_GiayChiTiet = "Mô tả";
        public const string trangThai_GiayChiTiet = "Trạng thái Giày";
        public const string tenca = "Tên ca";
        public const string magiaocainhanvien = "Mã giao ca nv";

        public const string tatca = "Tất cả";

        public const string chuyenkhoan = "Chuyển khoản";
        public const string tienmat = "Tiền mặt";
        public const string hinhthucthanhtoan = "Hình thức thanh toán";
        public const string SDTkhach = "Số điện thoại khách";
        public const string TenTaikhoan = "Tên nhân viên";
        public const string tenkhach = "Tên khách";

    }
}
