using DAL.IRepositories;
using DAL.Models.Context;
using DAL.Models.ModelRefer;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories
{
    public class Giay_ChiTietGiayRepository : IGiay_ChiTietGiayRepository
    {
        DBContext _db;
        public Giay_ChiTietGiayRepository()
        {
            _db = new DBContext();
        }
        public List<Giay_ChiTietGiay> GetAll(string? txtTimKiem, string? searchType)
        {
            if (string.Equals(searchType, SearchType.moTa_GiayChiTiet))
            {
                return _db.Giaychitiets.Where(a => a.Mota.Contains(txtTimKiem))
            .Select(c => new Giay_ChiTietGiay()
            {
                giaychitiet = c,
                tenChatLieu = c.Machatlieu == null ? "N/A" : _db.Chatlieus.FirstOrDefault(ph => ph.Machatlieu == c.Machatlieu)!.Tenchatlieu,
                tenMauSac = c.Mamausac == null ? "N/A" : _db.Mausacs.FirstOrDefault(ph => ph.Mamausac == c.Mamausac)!.Tenmausac,
                tenKieuDang = c.Makieudang == null ? "N/A" : _db.Kieudangs.FirstOrDefault(ph => ph.Makieudang == c.Makieudang)!.Tenkieudang,
                tenKichCo = c.Makichco == null ? "N/A" : _db.Kichcos.FirstOrDefault(ph => ph.Makichco == c.Makichco)!.Tenkichco,
                tenGiay = c.Magiay == null ? "N/A" : _db.Giays.FirstOrDefault(ph => ph.Magiay == c.Magiay)!.Tengiay,
                tenThuongHieu = c.Mathuonghieu == null ? "N/A" : _db.Thuonghieus.FirstOrDefault(ph => ph.Mathuonghieu == c.Mathuonghieu)!.Tenthuonghieu,
                tenNguoiTao = c.Nguoitao == null ? "N/A" : _db.Taikhoans.FirstOrDefault(ph => ph.Mataikhoan == c.Nguoitao)!.Hovaten,
                tenNguoiSua = c.Nguoisua == null ? "N/A" : _db.Taikhoans.FirstOrDefault(ph => ph.Mataikhoan == c.Nguoisua)!.Hovaten,
                soLuongCon = _db.Giaychitiets.FirstOrDefault(ph => ph.Magiaychitiet == c.Magiaychitiet)!.Soluongcon,
                gia = _db.Giaychitiets.FirstOrDefault(ph => ph.Magiaychitiet == c.Magiaychitiet)!.Gia,
                trangThai = _db.Giaychitiets.FirstOrDefault(ph => ph.Magiaychitiet == c.Magiaychitiet)!.Trangthai,

            })
            .ToList();
            }
            if (string.Equals(searchType, SearchType.giaLonHon_GiayChiTiet))
            {
                return _db.Giaychitiets.Where(a => a.Gia <= int.Parse(txtTimKiem))
            .Select(c => new Giay_ChiTietGiay()
            {
                giaychitiet = c,
                tenChatLieu = c.Machatlieu == null ? "N/A" : _db.Chatlieus.FirstOrDefault(ph => ph.Machatlieu == c.Machatlieu)!.Tenchatlieu,
                tenMauSac = c.Mamausac == null ? "N/A" : _db.Mausacs.FirstOrDefault(ph => ph.Mamausac == c.Mamausac)!.Tenmausac,
                tenKieuDang = c.Makieudang == null ? "N/A" : _db.Kieudangs.FirstOrDefault(ph => ph.Makieudang == c.Makieudang)!.Tenkieudang,
                tenKichCo = c.Makichco == null ? "N/A" : _db.Kichcos.FirstOrDefault(ph => ph.Makichco == c.Makichco)!.Tenkichco,
                tenGiay = c.Magiay == null ? "N/A" : _db.Giays.FirstOrDefault(ph => ph.Magiay == c.Magiay)!.Tengiay,
                tenThuongHieu = c.Mathuonghieu == null ? "N/A" : _db.Thuonghieus.FirstOrDefault(ph => ph.Mathuonghieu == c.Mathuonghieu)!.Tenthuonghieu,
                tenNguoiTao = c.Nguoitao == null ? "N/A" : _db.Taikhoans.FirstOrDefault(ph => ph.Mataikhoan == c.Nguoitao)!.Hovaten,
                tenNguoiSua = c.Nguoisua == null ? "N/A" : _db.Taikhoans.FirstOrDefault(ph => ph.Mataikhoan == c.Nguoisua)!.Hovaten,
                soLuongCon = _db.Giaychitiets.FirstOrDefault(ph => ph.Magiaychitiet == c.Magiaychitiet)!.Soluongcon,
                gia = _db.Giaychitiets.FirstOrDefault(ph => ph.Magiaychitiet == c.Magiaychitiet)!.Gia,
                trangThai = _db.Giaychitiets.FirstOrDefault(ph => ph.Magiaychitiet == c.Magiaychitiet)!.Trangthai,

            })
            .ToList();
            }
            if (string.Equals(searchType, SearchType.giaNhoHon_GiayChiTiet))
            {
                return _db.Giaychitiets.Where(a => a.Gia >= int.Parse(txtTimKiem))
            .Select(c => new Giay_ChiTietGiay()
            {
                giaychitiet = c,
                tenChatLieu = c.Machatlieu == null ? "N/A" : _db.Chatlieus.FirstOrDefault(ph => ph.Machatlieu == c.Machatlieu)!.Tenchatlieu,
                tenMauSac = c.Mamausac == null ? "N/A" : _db.Mausacs.FirstOrDefault(ph => ph.Mamausac == c.Mamausac)!.Tenmausac,
                tenKieuDang = c.Makieudang == null ? "N/A" : _db.Kieudangs.FirstOrDefault(ph => ph.Makieudang == c.Makieudang)!.Tenkieudang,
                tenKichCo = c.Makichco == null ? "N/A" : _db.Kichcos.FirstOrDefault(ph => ph.Makichco == c.Makichco)!.Tenkichco,
                tenGiay = c.Magiay == null ? "N/A" : _db.Giays.FirstOrDefault(ph => ph.Magiay == c.Magiay)!.Tengiay,
                tenThuongHieu = c.Mathuonghieu == null ? "N/A" : _db.Thuonghieus.FirstOrDefault(ph => ph.Mathuonghieu == c.Mathuonghieu)!.Tenthuonghieu,
                tenNguoiTao = c.Nguoitao == null ? "N/A" : _db.Taikhoans.FirstOrDefault(ph => ph.Mataikhoan == c.Nguoitao)!.Hovaten,
                tenNguoiSua = c.Nguoisua == null ? "N/A" : _db.Taikhoans.FirstOrDefault(ph => ph.Mataikhoan == c.Nguoisua)!.Hovaten,
                soLuongCon = _db.Giaychitiets.FirstOrDefault(ph => ph.Magiaychitiet == c.Magiaychitiet)!.Soluongcon,
                gia = _db.Giaychitiets.FirstOrDefault(ph => ph.Magiaychitiet == c.Magiaychitiet)!.Gia,
                trangThai = _db.Giaychitiets.FirstOrDefault(ph => ph.Magiaychitiet == c.Magiaychitiet)!.Trangthai,

            })
            .ToList();
            }
            if (string.Equals(searchType, SearchType.tenNguoiSua_GiayChiTiet))
            {
                return _db.Giaychitiets
            .Select(c => new Giay_ChiTietGiay()
            {
                giaychitiet = c,
                tenChatLieu = c.Machatlieu == null ? "N/A" : _db.Chatlieus.FirstOrDefault(ph => ph.Machatlieu == c.Machatlieu)!.Tenchatlieu,
                tenMauSac = c.Mamausac == null ? "N/A" : _db.Mausacs.FirstOrDefault(ph => ph.Mamausac == c.Mamausac)!.Tenmausac,
                tenKieuDang = c.Makieudang == null ? "N/A" : _db.Kieudangs.FirstOrDefault(ph => ph.Makieudang == c.Makieudang)!.Tenkieudang,
                tenKichCo = c.Makichco == null ? "N/A" : _db.Kichcos.FirstOrDefault(ph => ph.Makichco == c.Makichco)!.Tenkichco,
                tenGiay = c.Magiay == null ? "N/A" : _db.Giays.FirstOrDefault(ph => ph.Magiay == c.Magiay)!.Tengiay,
                tenThuongHieu = c.Mathuonghieu == null ? "N/A" : _db.Thuonghieus.FirstOrDefault(ph => ph.Mathuonghieu == c.Mathuonghieu)!.Tenthuonghieu,
                tenNguoiTao = c.Nguoitao == null ? "N/A" : _db.Taikhoans.FirstOrDefault(ph => ph.Mataikhoan == c.Nguoitao)!.Hovaten,
                tenNguoiSua = c.Nguoisua == null ? "N/A" : _db.Taikhoans.FirstOrDefault(ph => ph.Mataikhoan == c.Nguoisua)!.Hovaten,
                soLuongCon = _db.Giaychitiets.FirstOrDefault(ph => ph.Magiaychitiet == c.Magiaychitiet)!.Soluongcon,
                gia = _db.Giaychitiets.FirstOrDefault(ph => ph.Magiaychitiet == c.Magiaychitiet)!.Gia,
                trangThai = _db.Giaychitiets.FirstOrDefault(ph => ph.Magiaychitiet == c.Magiaychitiet)!.Trangthai,

            }).Where(a => a.tenNguoiSua.Contains(txtTimKiem))
            .ToList();
            }
            if (string.Equals(searchType, SearchType.tenNguoiTao_GiayChiTiet))
            {
                return _db.Giaychitiets
            .Select(c => new Giay_ChiTietGiay()
            {
                giaychitiet = c,
                tenChatLieu = c.Machatlieu == null ? "N/A" : _db.Chatlieus.FirstOrDefault(ph => ph.Machatlieu == c.Machatlieu)!.Tenchatlieu,
                tenMauSac = c.Mamausac == null ? "N/A" : _db.Mausacs.FirstOrDefault(ph => ph.Mamausac == c.Mamausac)!.Tenmausac,
                tenKieuDang = c.Makieudang == null ? "N/A" : _db.Kieudangs.FirstOrDefault(ph => ph.Makieudang == c.Makieudang)!.Tenkieudang,
                tenKichCo = c.Makichco == null ? "N/A" : _db.Kichcos.FirstOrDefault(ph => ph.Makichco == c.Makichco)!.Tenkichco,
                tenGiay = c.Magiay == null ? "N/A" : _db.Giays.FirstOrDefault(ph => ph.Magiay == c.Magiay)!.Tengiay,
                tenThuongHieu = c.Mathuonghieu == null ? "N/A" : _db.Thuonghieus.FirstOrDefault(ph => ph.Mathuonghieu == c.Mathuonghieu)!.Tenthuonghieu,
                tenNguoiTao = c.Nguoitao == null ? "N/A" : _db.Taikhoans.FirstOrDefault(ph => ph.Mataikhoan == c.Nguoitao)!.Hovaten,
                tenNguoiSua = c.Nguoisua == null ? "N/A" : _db.Taikhoans.FirstOrDefault(ph => ph.Mataikhoan == c.Nguoisua)!.Hovaten,
                soLuongCon = _db.Giaychitiets.FirstOrDefault(ph => ph.Magiaychitiet == c.Magiaychitiet)!.Soluongcon,
                gia = _db.Giaychitiets.FirstOrDefault(ph => ph.Magiaychitiet == c.Magiaychitiet)!.Gia,
                trangThai = _db.Giaychitiets.FirstOrDefault(ph => ph.Magiaychitiet == c.Magiaychitiet)!.Trangthai,

            }).Where(a => a.tenNguoiTao.Contains(txtTimKiem))
            .ToList();
            }
            if (string.Equals(searchType, SearchType.soLuongTrongKhoLonHon))
            {
                return _db.Giaychitiets.Where(a => a.Soluongcon <= int.Parse(txtTimKiem))
            .Select(c => new Giay_ChiTietGiay()
            {
                giaychitiet = c,
                tenChatLieu = c.Machatlieu == null ? "N/A" : _db.Chatlieus.FirstOrDefault(ph => ph.Machatlieu == c.Machatlieu)!.Tenchatlieu,
                tenMauSac = c.Mamausac == null ? "N/A" : _db.Mausacs.FirstOrDefault(ph => ph.Mamausac == c.Mamausac)!.Tenmausac,
                tenKieuDang = c.Makieudang == null ? "N/A" : _db.Kieudangs.FirstOrDefault(ph => ph.Makieudang == c.Makieudang)!.Tenkieudang,
                tenKichCo = c.Makichco == null ? "N/A" : _db.Kichcos.FirstOrDefault(ph => ph.Makichco == c.Makichco)!.Tenkichco,
                tenGiay = c.Magiay == null ? "N/A" : _db.Giays.FirstOrDefault(ph => ph.Magiay == c.Magiay)!.Tengiay,
                tenThuongHieu = c.Mathuonghieu == null ? "N/A" : _db.Thuonghieus.FirstOrDefault(ph => ph.Mathuonghieu == c.Mathuonghieu)!.Tenthuonghieu,
                tenNguoiTao = c.Nguoitao == null ? "N/A" : _db.Taikhoans.FirstOrDefault(ph => ph.Mataikhoan == c.Nguoitao)!.Hovaten,
                tenNguoiSua = c.Nguoisua == null ? "N/A" : _db.Taikhoans.FirstOrDefault(ph => ph.Mataikhoan == c.Nguoisua)!.Hovaten,
                soLuongCon = _db.Giaychitiets.FirstOrDefault(ph => ph.Magiaychitiet == c.Magiaychitiet)!.Soluongcon,
                gia = _db.Giaychitiets.FirstOrDefault(ph => ph.Magiaychitiet == c.Magiaychitiet)!.Gia,
                trangThai = _db.Giaychitiets.FirstOrDefault(ph => ph.Magiaychitiet == c.Magiaychitiet)!.Trangthai,

            }).ToList();
            }
            if (string.Equals(searchType, SearchType.soLuongTrongKhoNhoHon))
            {
                return _db.Giaychitiets.Where(a => a.Soluongcon >= int.Parse(txtTimKiem))
            .Select(c => new Giay_ChiTietGiay()
            {
                giaychitiet = c,
                tenChatLieu = c.Machatlieu == null ? "N/A" : _db.Chatlieus.FirstOrDefault(ph => ph.Machatlieu == c.Machatlieu)!.Tenchatlieu,
                tenMauSac = c.Mamausac == null ? "N/A" : _db.Mausacs.FirstOrDefault(ph => ph.Mamausac == c.Mamausac)!.Tenmausac,
                tenKieuDang = c.Makieudang == null ? "N/A" : _db.Kieudangs.FirstOrDefault(ph => ph.Makieudang == c.Makieudang)!.Tenkieudang,
                tenKichCo = c.Makichco == null ? "N/A" : _db.Kichcos.FirstOrDefault(ph => ph.Makichco == c.Makichco)!.Tenkichco,
                tenGiay = c.Magiay == null ? "N/A" : _db.Giays.FirstOrDefault(ph => ph.Magiay == c.Magiay)!.Tengiay,
                tenThuongHieu = c.Mathuonghieu == null ? "N/A" : _db.Thuonghieus.FirstOrDefault(ph => ph.Mathuonghieu == c.Mathuonghieu)!.Tenthuonghieu,
                tenNguoiTao = c.Nguoitao == null ? "N/A" : _db.Taikhoans.FirstOrDefault(ph => ph.Mataikhoan == c.Nguoitao)!.Hovaten,
                tenNguoiSua = c.Nguoisua == null ? "N/A" : _db.Taikhoans.FirstOrDefault(ph => ph.Mataikhoan == c.Nguoisua)!.Hovaten,
                soLuongCon = _db.Giaychitiets.FirstOrDefault(ph => ph.Magiaychitiet == c.Magiaychitiet)!.Soluongcon,
                gia = _db.Giaychitiets.FirstOrDefault(ph => ph.Magiaychitiet == c.Magiaychitiet)!.Gia,
                trangThai = _db.Giaychitiets.FirstOrDefault(ph => ph.Magiaychitiet == c.Magiaychitiet)!.Trangthai,

            }).ToList();
            }
            if (string.Equals(searchType, SearchType.trangThai_GiayChiTiet))
            {
                return _db.Giaychitiets.Where(a => a.Trangthai == bool.Parse(txtTimKiem))
            .Select(c => new Giay_ChiTietGiay()
            {
                giaychitiet = c,
                tenChatLieu = c.Machatlieu == null ? "N/A" : _db.Chatlieus.FirstOrDefault(ph => ph.Machatlieu == c.Machatlieu)!.Tenchatlieu,
                tenMauSac = c.Mamausac == null ? "N/A" : _db.Mausacs.FirstOrDefault(ph => ph.Mamausac == c.Mamausac)!.Tenmausac,
                tenKieuDang = c.Makieudang == null ? "N/A" : _db.Kieudangs.FirstOrDefault(ph => ph.Makieudang == c.Makieudang)!.Tenkieudang,
                tenKichCo = c.Makichco == null ? "N/A" : _db.Kichcos.FirstOrDefault(ph => ph.Makichco == c.Makichco)!.Tenkichco,
                tenGiay = c.Magiay == null ? "N/A" : _db.Giays.FirstOrDefault(ph => ph.Magiay == c.Magiay)!.Tengiay,
                tenThuongHieu = c.Mathuonghieu == null ? "N/A" : _db.Thuonghieus.FirstOrDefault(ph => ph.Mathuonghieu == c.Mathuonghieu)!.Tenthuonghieu,
                tenNguoiTao = c.Nguoitao == null ? "N/A" : _db.Taikhoans.FirstOrDefault(ph => ph.Mataikhoan == c.Nguoitao)!.Hovaten,
                tenNguoiSua = c.Nguoisua == null ? "N/A" : _db.Taikhoans.FirstOrDefault(ph => ph.Mataikhoan == c.Nguoisua)!.Hovaten,
                soLuongCon = _db.Giaychitiets.FirstOrDefault(ph => ph.Magiaychitiet == c.Magiaychitiet)!.Soluongcon,
                gia = _db.Giaychitiets.FirstOrDefault(ph => ph.Magiaychitiet == c.Magiaychitiet)!.Gia,
                trangThai = _db.Giaychitiets.FirstOrDefault(ph => ph.Magiaychitiet == c.Magiaychitiet)!.Trangthai,

            }).ToList();
            }
            if (string.Equals(searchType, SearchType.tenGiay))
            {
                return _db.Giaychitiets.Where(a => a.Trangthai == true)
            .Select(c => new Giay_ChiTietGiay()
            {
                giaychitiet = c,
                tenChatLieu = c.Machatlieu == null ? "N/A" : _db.Chatlieus.FirstOrDefault(ph => ph.Machatlieu == c.Machatlieu)!.Tenchatlieu,
                tenMauSac = c.Mamausac == null ? "N/A" : _db.Mausacs.FirstOrDefault(ph => ph.Mamausac == c.Mamausac)!.Tenmausac,
                tenKieuDang = c.Makieudang == null ? "N/A" : _db.Kieudangs.FirstOrDefault(ph => ph.Makieudang == c.Makieudang)!.Tenkieudang,
                tenKichCo = c.Makichco == null ? "N/A" : _db.Kichcos.FirstOrDefault(ph => ph.Makichco == c.Makichco)!.Tenkichco,
                tenGiay = c.Magiay == null ? "N/A" : _db.Giays.FirstOrDefault(ph => ph.Magiay == c.Magiay)!.Tengiay,
                tenThuongHieu = c.Mathuonghieu == null ? "N/A" : _db.Thuonghieus.FirstOrDefault(ph => ph.Mathuonghieu == c.Mathuonghieu)!.Tenthuonghieu,
                tenNguoiTao = c.Nguoitao == null ? "N/A" : _db.Taikhoans.FirstOrDefault(ph => ph.Mataikhoan == c.Nguoitao)!.Hovaten,
                tenNguoiSua = c.Nguoisua == null ? "N/A" : _db.Taikhoans.FirstOrDefault(ph => ph.Mataikhoan == c.Nguoisua)!.Hovaten,
                soLuongCon = _db.Giaychitiets.FirstOrDefault(ph => ph.Magiaychitiet == c.Magiaychitiet)!.Soluongcon,
                trangThai = _db.Giaychitiets.FirstOrDefault(ph => ph.Magiaychitiet == c.Magiaychitiet)!.Trangthai,
                gia = _db.Giaychitiets.FirstOrDefault(ph => ph.Magiaychitiet == c.Magiaychitiet)!.Gia,
            }).Where(c => c.tenGiay.ToLower().Contains(txtTimKiem))
            .ToList();
            }

            return _db.Giaychitiets
        .Select(c => new Giay_ChiTietGiay()
        {
            giaychitiet = c,
            tenChatLieu = c.Machatlieu == null ? "N/A" : _db.Chatlieus.FirstOrDefault(ph => ph.Machatlieu == c.Machatlieu)!.Tenchatlieu,
            tenMauSac = c.Mamausac == null ? "N/A" : _db.Mausacs.FirstOrDefault(ph => ph.Mamausac == c.Mamausac)!.Tenmausac,
            tenKieuDang = c.Makieudang == null ? "N/A" : _db.Kieudangs.FirstOrDefault(ph => ph.Makieudang == c.Makieudang)!.Tenkieudang,
            tenKichCo = c.Makichco == null ? "N/A" : _db.Kichcos.FirstOrDefault(ph => ph.Makichco == c.Makichco)!.Tenkichco,
            tenGiay = c.Magiay == null ? "N/A" : _db.Giays.FirstOrDefault(ph => ph.Magiay == c.Magiay)!.Tengiay,
            tenThuongHieu = c.Mathuonghieu == null ? "N/A" : _db.Thuonghieus.FirstOrDefault(ph => ph.Mathuonghieu == c.Mathuonghieu)!.Tenthuonghieu,
            tenNguoiTao = c.Nguoitao == null ? "N/A" : _db.Taikhoans.FirstOrDefault(ph => ph.Mataikhoan == c.Nguoitao)!.Hovaten,
            tenNguoiSua = c.Nguoisua == null ? "N/A" : _db.Taikhoans.FirstOrDefault(ph => ph.Mataikhoan == c.Nguoisua)!.Hovaten,
            soLuongCon = _db.Giaychitiets.FirstOrDefault(ph => ph.Magiaychitiet == c.Magiaychitiet)!.Soluongcon,
            trangThai = _db.Giaychitiets.FirstOrDefault(ph => ph.Magiaychitiet == c.Magiaychitiet)!.Trangthai,
            gia = _db.Giaychitiets.FirstOrDefault(ph => ph.Magiaychitiet == c.Magiaychitiet)!.Gia,
        }).ToList();

        }
        public Giay_ChiTietGiay GetById(int? id)
        {
            return _db.Giaychitiets
                .Where(a => a.Magiaychitiet == id)
                .Select(c => new Giay_ChiTietGiay()
                {
                    giaychitiet = c,
                    tenChatLieu = c.Machatlieu == null ? "N/A" : _db.Chatlieus.FirstOrDefault(ph => ph.Machatlieu == c.Machatlieu)!.Tenchatlieu,
                    tenMauSac = c.Mamausac == null ? "N/A" : _db.Mausacs.FirstOrDefault(ph => ph.Mamausac == c.Mamausac)!.Tenmausac,
                    tenKieuDang = c.Makieudang == null ? "N/A" : _db.Kieudangs.FirstOrDefault(ph => ph.Makieudang == c.Makieudang)!.Tenkieudang,
                    tenKichCo = c.Makichco == null ? "N/A" : _db.Kichcos.FirstOrDefault(ph => ph.Makichco == c.Makichco)!.Tenkichco,
                    tenGiay = c.Magiay == null ? "N/A" : _db.Giays.FirstOrDefault(ph => ph.Magiay == c.Magiay)!.Tengiay,
                    tenThuongHieu = c.Mathuonghieu == null ? "N/A" : _db.Thuonghieus.FirstOrDefault(ph => ph.Mathuonghieu == c.Mathuonghieu)!.Tenthuonghieu,
                    tenNguoiTao = c.Nguoitao == null ? "N/A" : _db.Taikhoans.FirstOrDefault(ph => ph.Mataikhoan == c.Nguoitao)!.Hovaten,
                    tenNguoiSua = c.Nguoisua == null ? "N/A" : _db.Taikhoans.FirstOrDefault(ph => ph.Mataikhoan == c.Nguoisua)!.Hovaten,
                    soLuongCon = _db.Giaychitiets.FirstOrDefault(ph => ph.Magiaychitiet == c.Magiaychitiet)!.Soluongcon,
                    gia = _db.Giaychitiets.FirstOrDefault(ph => ph.Magiaychitiet == c.Magiaychitiet)!.Gia,
                })
                .FirstOrDefault(); // Use FirstOrDefault() here
        }
    }
}
