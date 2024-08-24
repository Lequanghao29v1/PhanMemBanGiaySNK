using DAL.IRepositories;
using DAL.Models.Context;
using DAL.Models.DomainClass;
using DAL.Models.ModelRefer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories
{
    public class ThuongHieuRepository : IThuongHieuRepository
    {
        DBContext _db;
        public ThuongHieuRepository()
        {
            _db = new DBContext();
        }
        public List<Thuonghieu> GetAll(string? txtSearch, string? searchType)
        {
            if (string.Equals(searchType, SearchType.All))
            {
                return _db.Thuonghieus.Where(c => c.Mataikhoan.ToString().Contains(txtSearch) || c.Sdt.Contains(txtSearch) || c.Email.Contains(txtSearch) || c.Trangthai.ToString().Contains(txtSearch) || c.Tenthuonghieu.Contains(txtSearch) || c.Mota.Contains(txtSearch)).ToList();
            }
            if (string.Equals(searchType, SearchType.tenThuongHieu))
            {
                return _db.Thuonghieus.Where(c => c.Tenthuonghieu.Contains(txtSearch)).ToList();
            }
            if (string.Equals(searchType, SearchType.emailThuongHieu))
            {
                return _db.Thuonghieus.Where(c => c.Email.Contains(txtSearch)).ToList();
            }
            if (string.Equals(searchType, SearchType.sdtThuongHieu))
            {
                return _db.Thuonghieus.Where(c => c.Sdt.Contains(txtSearch)).ToList();
            }
            if (string.Equals(searchType, SearchType.idNguoiThemThuongHieu))
            {
                return _db.Thuonghieus.Where(c => c.Mataikhoan.ToString().Contains(txtSearch)).ToList();
            }
            if (string.Equals(searchType, SearchType.trangThaiThuongHieu))
            {
                return _db.Thuonghieus.Where(c => c.Trangthai.ToString().Contains(txtSearch)).ToList();
            }
            if (string.Equals(searchType, SearchType.moTaThuongHieu))
            {
                return _db.Thuonghieus.Where(c => c.Mota.Contains(txtSearch)).ToList();
            }

            return _db.Thuonghieus.ToList();
        }

        public Thuonghieu GetByID(int id)
        {
            return _db.Thuonghieus.FirstOrDefault(c => c.Mathuonghieu == id);
        }

        public bool Khoa_MoKhoa(int id)
        {
            try
            {
                var Obj = _db.Thuonghieus.FirstOrDefault(c => c.Mathuonghieu == id);
                if (Obj == null) { return false; }
                if (Obj.Trangthai == true)
                {
                    Obj.Trangthai = false;
                }
                else
                {
                    Obj.Trangthai = true;
                }
                _db.Thuonghieus.Update(Obj);
                _db.SaveChanges();
                return true;

            }
            catch { return false; }
        }

        public bool Sua(int id, Thuonghieu Thuonghieu)
        {
            try
            {
                var Obj = _db.Thuonghieus.FirstOrDefault(c => c.Mathuonghieu == id);
                if (Obj == null) { return false; }

                Obj.Tenthuonghieu = Thuonghieu.Tenthuonghieu;
                Obj.Mota = Thuonghieu.Mota;
                Obj.Email = Thuonghieu.Mota;
                Obj.Sdt = Thuonghieu.Mota;

                _db.Thuonghieus.Update(Obj);
                _db.SaveChanges();
                return true;

            }
            catch { return false; }
        }

        public bool Them(Thuonghieu Thuonghieu)
        {
            try
            {
                _db.Thuonghieus.Add(Thuonghieu);
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
    }
}

