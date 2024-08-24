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
    public class HoaDonChiTietRepository : IHoaDonChiTietRepository
    {
        Giay_ChiTietGiayRepository _Rep_Giay;
        DBContext _db;
        public HoaDonChiTietRepository()
        {
            _db = new DBContext();
            _Rep_Giay = new();
        }
        public List<HoaDonChiTiet_SP> GetAll(string? txtTimKiem, string? searchType)
        {
            if (string.Equals(searchType, SearchType.maHoaDon))
            {
                return _db.Hoadonchitiets.Where(c => c.Mahoadon.ToString().Contains(txtTimKiem))
                    .Select(c => new HoaDonChiTiet_SP()
                    {
                        Hoadonchitiet = c,
                        tenChatLieu = _Rep_Giay.GetById(c.Magiaychitiet).tenChatLieu,
                        tenMauSac = _Rep_Giay.GetById(c.Magiaychitiet).tenMauSac,
                        tenKieuDang = _Rep_Giay.GetById(c.Magiaychitiet).tenKieuDang,
                        tenKichCo = _Rep_Giay.GetById(c.Magiaychitiet).tenKichCo,
                        tenGiay = _Rep_Giay.GetById(c.Magiaychitiet).tenGiay,
                        tenThuongHieu = _Rep_Giay.GetById(c.Magiaychitiet).tenThuongHieu,
                        tongTien = _db.Hoadonchitiets.FirstOrDefault(ph => ph.Mahoadonchitiet == c.Mahoadonchitiet)!.Gia,

                    }).ToList();

            }

            return _db.Hoadonchitiets
                .Select(c => new HoaDonChiTiet_SP()
                {
                Hoadonchitiet = c,
                tenChatLieu = _Rep_Giay.GetById(c.Magiaychitiet).tenChatLieu,
                tenMauSac = _Rep_Giay.GetById(c.Magiaychitiet).tenMauSac,
                tenKieuDang = _Rep_Giay.GetById(c.Magiaychitiet).tenKieuDang,
                tenKichCo = _Rep_Giay.GetById(c.Magiaychitiet).tenKichCo,
                tenGiay = _Rep_Giay.GetById(c.Magiaychitiet).tenGiay,
                tenThuongHieu = _Rep_Giay.GetById(c.Magiaychitiet).tenThuongHieu,
                }).ToList();
                

        }

        public Hoadonchitiet GetByID(int? id)
        {
            return _db.Hoadonchitiets.FirstOrDefault(a => a.Mahoadonchitiet == id);
        }

        public bool Sua(int? id ,Hoadonchitiet hoadonchitiet)
        {
            try
            {
                var Obj = _db.Hoadonchitiets.FirstOrDefault(a => a.Mahoadonchitiet == id);
                if (Obj == null) { return false; }

                Obj.Magiaychitiet = hoadonchitiet.Magiaychitiet;
                Obj.Mahoadon = hoadonchitiet.Mahoadon;
                Obj.Soluongmua = hoadonchitiet.Soluongmua;
                Obj.Gia = hoadonchitiet.Gia;

                _db.Hoadonchitiets.Update(Obj);
                _db.SaveChanges();
                return true;

            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.ToString());
                Console.WriteLine("Inner Exception: " + ex.InnerException.Message);
                return false;


            }
        }

            public bool Them(Hoadonchitiet hoadonchitiet)
        {
            try
            {
                _db.Hoadonchitiets.Add(hoadonchitiet);
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

        public bool Xoa(int? id)
        {
            try
            {
                var existedObj = _db.Hoadonchitiets.FirstOrDefault(a => a.Mahoadonchitiet == id);

                if (existedObj == null)
                {
                    return false;
                }
                _db.Hoadonchitiets.Remove(existedObj);
                _db.SaveChanges();

                return true;
            }
            catch(Exception e)
            {
                Console.WriteLine(e.ToString());
                Console.WriteLine("Inner Exception: " + e.InnerException.Message);
                return false;

            }
        }
    }
}
