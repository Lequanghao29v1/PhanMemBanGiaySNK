using DAL.IRepositories;
using DAL.Models.Context;
using DAL.Models.DomainClass;
using DAL.Models.ModelRefer;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories
{
    public class HoaDonRepository : IHoaDonRepository
    {
        DBContext _db;
        public HoaDonRepository()
        {
            _db = new DBContext();
        }
        public List<HoaDon_Model> GetAll(string? txtTimKiem, string? searchType)
        {
            if (string.Equals(searchType, SearchType.trangThaiHoaDon))
            {
                return _db.Hoadons.Where(a=>a.Trangthai == bool.Parse(txtTimKiem))
                        .Select(c => new HoaDon_Model()
                        {
                            Hoadon = c,
                            tenTaiKhoan = c.Mataikhoan == null ? "N/A" : _db.Taikhoans.FirstOrDefault(ph => ph.Mataikhoan == c.Mataikhoan)!.Hovaten,
                            tenUuDai = c.Mauudai == null ? "N/A" : _db.Uudais.FirstOrDefault(ph => ph.Mauudai == c.Mauudai)!.Tenuudai,
                            tenKhachHang = c.Makhachhang == null ? "N/A" : _db.Khachhangs.FirstOrDefault(ph => ph.Makhachhang == c.Makhachhang)!.Tenkhachhang,
                            diemKhachHang = _db.Khachhangs.FirstOrDefault(ph => ph.Makhachhang == c.Makhachhang)!.Diemkhachhang,
                            tenHinhThucThanhToan = c.Mahinhthucthanhtoan == null ? "N/A" : _db.Hinhthucthanhtoans.FirstOrDefault(ph => ph.Mahinhthucthanhtoan == c.Mahinhthucthanhtoan)!.Tenhinhthuc,
                        }).ToList();
            }
            if (string.Equals(searchType, SearchType.maHoaDon))
            {
                return _db.Hoadons.Where(a=>a.Mahoadon == int.Parse(txtTimKiem))
                        .Select(c => new HoaDon_Model()
                        {
                            Hoadon = c,
                            tenTaiKhoan = c.Mataikhoan == null ? "N/A" : _db.Taikhoans.FirstOrDefault(ph => ph.Mataikhoan == c.Mataikhoan)!.Hovaten,
                            tenUuDai = c.Mauudai == null ? "N/A" : _db.Uudais.FirstOrDefault(ph => ph.Mauudai == c.Mauudai)!.Tenuudai,
                            tenKhachHang = c.Makhachhang == null ? "N/A" : _db.Khachhangs.FirstOrDefault(ph => ph.Makhachhang == c.Makhachhang)!.Tenkhachhang,
                            diemKhachHang = _db.Khachhangs.FirstOrDefault(ph => ph.Makhachhang == c.Makhachhang)!.Diemkhachhang,
                            tenHinhThucThanhToan = c.Mahinhthucthanhtoan == null ? "N/A" : _db.Hinhthucthanhtoans.FirstOrDefault(ph => ph.Mahinhthucthanhtoan == c.Mahinhthucthanhtoan)!.Tenhinhthuc,
                        }).ToList();
            }

            return _db.Hoadons
                .Select(c => new HoaDon_Model()
                {
                    Hoadon = c,
                    tenTaiKhoan = c.Mataikhoan == null ? "N/A" : _db.Taikhoans.FirstOrDefault(ph => ph.Mataikhoan == c.Mataikhoan)!.Hovaten,
                    tenUuDai = c.Mauudai == null ? "N/A" : _db.Uudais.FirstOrDefault(ph => ph.Mauudai == c.Mauudai)!.Tenuudai,
                    tenKhachHang = c.Makhachhang == null ? "N/A" : _db.Khachhangs.FirstOrDefault(ph => ph.Makhachhang == c.Makhachhang)!.Tenkhachhang,
                    tenHinhThucThanhToan = c.Mahinhthucthanhtoan == null ? "N/A" : _db.Hinhthucthanhtoans.FirstOrDefault(ph => ph.Mahinhthucthanhtoan == c.Mahinhthucthanhtoan)!.Tenhinhthuc,
                }).ToList();

        }

        public Hoadon GetByID(int id)
        {
            return _db.Hoadons.FirstOrDefault(a => a.Mahoadon == id);
        }

        public bool Sua(int id, Hoadon hoadon)
        {
            try
            {
                var Obj = _db.Hoadons.FirstOrDefault(a => a.Mahoadon == id);
                if (Obj == null) { return false; }

                Obj.Mataikhoan = hoadon.Mataikhoan;
                Obj.Mauudai = hoadon.Mauudai;
                Obj.Makhachhang = hoadon.Makhachhang;
                Obj.Mahinhthucthanhtoan = hoadon.Mahinhthucthanhtoan;
                Obj.Tongtien = hoadon.Tongtien;
                Obj.Ghichu = hoadon.Ghichu;

                _db.Hoadons.Update(Obj);
                _db.SaveChanges();
                return true;

            }
            catch { return false; }
        }
        public List<Giaychitiet> GetGiaychitiets()
        {
            return _db.Giaychitiets.ToList();
        }

        public bool Them(Hoadon hoadon)
        {
            try
            {
                hoadon.Tencuahang = "Cửa hàng bán giày sneaker";
                hoadon.Diachicuahang = "221 Phú Diễn, phường Phú Diễn, Quận Bắc Từ Liêm, Hà Nội";
                hoadon.Sdtcuahang = "0358384108";
                hoadon.Emailcuahang = "vuongxuanha8@gmail.com";
                _db.Hoadons.Add(hoadon);
                _db.SaveChanges();

                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
                Console.WriteLine("Inner Exception: " + e.InnerException.Message);
                return false;
            }
        }

        public bool Xoa(int id)
        {
            try
            {
                var existedObj = _db.Hoadons.FirstOrDefault(a => a.Mahoadon == id);

                if (existedObj == null) return false;

                _db.Hoadons.Remove(existedObj);
                _db.SaveChanges();

                return true;
            }
            catch(Exception ex) 
            {
                Console.WriteLine($"Thông tin chi tiết: {ex.ToString()}");
                Console.WriteLine("Inner Exception: " + ex.InnerException.Message);
                return false;

            }
        }
        public List<Hinhthucthanhtoan> GetHinhthucthanhtoans()
        {
            return _db.Hinhthucthanhtoans.ToList();
        }
        public List<Hoadonchitiet> GetHoadonchitiets()
        {

            return _db.Hoadonchitiets.ToList();
        }
        public List<HoaDonNhe> hoaDonNhes(string searchText, string searchType)
        {
            if (string.Equals(searchType, SearchType.tenkhach))
            {
                return _db.Hoadons
                    .Select(c => new HoaDonNhe()
                    {
                        Hoadone = c,
                        tenkhachhang = c.Makhachhang == null ? "N/A" : _db.Khachhangs.FirstOrDefault(cn => cn.Makhachhang == c.Makhachhang)!.Tenkhachhang,
                        sdtkhach = c.Makhachhang == null ? "N/A" : _db.Khachhangs.FirstOrDefault(cn => cn.Makhachhang == c.Makhachhang)!.Sdt,
                        hovatentaikhoan = c.Mataikhoan == null ? "N/A" : _db.Taikhoans.FirstOrDefault(cn => cn.Mataikhoan == c.Mataikhoan)!.Hovaten,
                        tenhinhthuc = c.Mahinhthucthanhtoan == null ? "N/A" : _db.Hinhthucthanhtoans.FirstOrDefault(cn => cn.Mahinhthucthanhtoan == c.Mahinhthucthanhtoan)!.Tenhinhthuc

                    })
                    .Where(c => c.tenkhachhang.Contains(searchText)).ToList();
            }
            if (string.Equals(searchType, SearchType.SDTkhach))
            {
                return _db.Hoadons
                    .Select(c => new HoaDonNhe()
                    {
                        Hoadone = c,
                        tenkhachhang = c.Makhachhang == null ? "N/A" : _db.Khachhangs.FirstOrDefault(cn => cn.Makhachhang == c.Makhachhang)!.Tenkhachhang,
                        sdtkhach = c.Makhachhang == null ? "N/A" : _db.Khachhangs.FirstOrDefault(cn => cn.Makhachhang == c.Makhachhang)!.Sdt,
                        hovatentaikhoan = c.Mataikhoan == null ? "N/A" : _db.Taikhoans.FirstOrDefault(cn => cn.Mataikhoan == c.Mataikhoan)!.Hovaten,
                        tenhinhthuc = c.Mahinhthucthanhtoan == null ? "N/A" : _db.Hinhthucthanhtoans.FirstOrDefault(cn => cn.Mahinhthucthanhtoan == c.Mahinhthucthanhtoan)!.Tenhinhthuc
                    })
                    .Where(c => c.sdtkhach.Contains(searchText)).ToList();
            }
            if (string.Equals(searchType, SearchType.TenTaikhoan))
            {
                return _db.Hoadons
                    .Select(c => new HoaDonNhe()
                    {
                        Hoadone = c,
                        tenkhachhang = c.Makhachhang == null ? "N/A" : _db.Khachhangs.FirstOrDefault(cn => cn.Makhachhang == c.Makhachhang)!.Tenkhachhang,
                        sdtkhach = c.Makhachhang == null ? "N/A" : _db.Khachhangs.FirstOrDefault(cn => cn.Makhachhang == c.Makhachhang)!.Sdt,
                        hovatentaikhoan = c.Mataikhoan == null ? "N/A" : _db.Taikhoans.FirstOrDefault(cn => cn.Mataikhoan == c.Mataikhoan)!.Hovaten,
                        tenhinhthuc = c.Mahinhthucthanhtoan == null ? "N/A" : _db.Hinhthucthanhtoans.FirstOrDefault(cn => cn.Mahinhthucthanhtoan == c.Mahinhthucthanhtoan)!.Tenhinhthuc
                    })
                    .Where(c => c.hovatentaikhoan.Contains(searchText)).ToList();
            }
            if (string.Equals(searchType, SearchType.tatca))
            {
                return _db.Hoadons
                    .Select(c => new HoaDonNhe()
                    {
                        Hoadone = c,
                        tenkhachhang = c.Makhachhang == null ? "N/A" : _db.Khachhangs.FirstOrDefault(cn => cn.Makhachhang == c.Makhachhang)!.Tenkhachhang,
                        sdtkhach = c.Makhachhang == null ? "N/A" : _db.Khachhangs.FirstOrDefault(cn => cn.Makhachhang == c.Makhachhang)!.Sdt,
                        hovatentaikhoan = c.Mataikhoan == null ? "N/A" : _db.Taikhoans.FirstOrDefault(cn => cn.Mataikhoan == c.Mataikhoan)!.Hovaten,
                        tenhinhthuc = c.Mahinhthucthanhtoan == null ? "N/A" : _db.Hinhthucthanhtoans.FirstOrDefault(cn => cn.Mahinhthucthanhtoan == c.Mahinhthucthanhtoan)!.Tenhinhthuc
                    })
                    .Where(c => c.hovatentaikhoan.Contains(searchText) || c.sdtkhach.Contains(searchText) || c.tenkhachhang.Contains(searchText)).ToList();
            }

            var query = _db.Hoadons.AsQueryable();
            if (!string.IsNullOrEmpty(searchType))
            {
                query = query
                    .Where(x => x.Mahinhthucthanhtoan != null &&
                                _db.Hinhthucthanhtoans.Any(cn => cn.Mahinhthucthanhtoan == x.Mahinhthucthanhtoan &&
                                                                        (string.Equals(cn.Tenhinhthuc, searchType))));
            }
            var result = query
                .Select(x => new HoaDonNhe()
                {
                    Hoadone = x,
                    tenkhachhang = x.Makhachhang == null ? "N/A" : _db.Khachhangs.FirstOrDefault(cn => cn.Makhachhang == x.Makhachhang)!.Tenkhachhang,
                    sdtkhach = x.Makhachhang == null ? "N/A" : _db.Khachhangs.FirstOrDefault(cn => cn.Makhachhang == x.Makhachhang)!.Sdt,
                    hovatentaikhoan = x.Mataikhoan == null ? "N/A" : _db.Taikhoans.FirstOrDefault(cn => cn.Mataikhoan == x.Mataikhoan)!.Hovaten,
                    tenhinhthuc = x.Mahinhthucthanhtoan == null ? "N/A" : _db.Hinhthucthanhtoans.FirstOrDefault(cn => cn.Mahinhthucthanhtoan == x.Mahinhthucthanhtoan)!.Tenhinhthuc
                })
                .ToList();

            return result;
        }

        public List<Giay> GetGiays()
        {
            return _db.Giays.ToList();
        }

        public List<Hoadon> GetHoadons(string search)
        {
            return _db.Hoadons.ToList();
        }

        public List<Khachhang> GetKhachhangs()
        {
            return _db.Khachhangs.ToList();
        }

        public List<Taikhoan> GetTaikhoans()
        {
            return _db.Taikhoans.ToList();
        }

        public List<Uudai> GetUudais()
        {
            return _db.Uudais.ToList();
        }



    }
}
