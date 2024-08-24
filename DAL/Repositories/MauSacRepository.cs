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
    public class MauSacRepository : IMauSacRepository
    {
        DBContext _db;
        public MauSacRepository()
        {
            _db = new DBContext();
        }
        public List<Mausac> GetAll(string? txtSearch, string? searchType)
        {
            if (string.Equals(searchType, SearchType.All))
            {
                return _db.Mausacs.Where(c => c.Mataikhoan.ToString().Contains(txtSearch) || c.Trangthai.ToString().Contains(txtSearch) || c.Tenmausac.Contains(txtSearch) || c.Mota.Contains(txtSearch)).ToList();
            }
            if (string.Equals(searchType, SearchType.tenKichCo))
            {
                return _db.Mausacs.Where(c => c.Tenmausac.Contains(txtSearch)).ToList();
            }
            if (string.Equals(searchType, SearchType.moTaMauSac))
            {
                return _db.Mausacs.Where(c => c.Mota.Contains(txtSearch)).ToList();
            }
            if (string.Equals(searchType, SearchType.trangThaiMauSac))
            {
                return _db.Mausacs.Where(c => c.Trangthai.ToString().Contains(txtSearch)).ToList();
            }
            if (string.Equals(searchType, SearchType.idNguoiThemMauSac))
            {
                return _db.Mausacs.Where(c => c.Mataikhoan.ToString().Contains(txtSearch)).ToList();
            }
            return _db.Mausacs.ToList();
        }

        public Mausac GetByID(int id)
        {
            return _db.Mausacs.FirstOrDefault(c => c.Mamausac == id);
        }

        public bool Khoa_MoKhoa(int id)
        {
            try
            {
                var Obj = _db.Mausacs.FirstOrDefault(c => c.Mamausac == id);
                if (Obj == null) { return false; }
                if (Obj.Trangthai == true)
                {
                    Obj.Trangthai = false;
                }
                else
                {
                    Obj.Trangthai = true;
                }
                _db.Mausacs.Update(Obj);
                _db.SaveChanges();
                return true;

            }
            catch { return false; }
        }

        public bool Sua(int id, Mausac Mausac)
        {
            try
            {
                var Obj = _db.Mausacs.FirstOrDefault(c => c.Mamausac == id);
                if (Obj == null) { return false; }

                Obj.Tenmausac = Mausac.Tenmausac;
                Obj.Mota = Mausac.Mota;

                _db.Mausacs.Update(Obj);
                _db.SaveChanges();
                return true;

            }
            catch { return false; }
        }

        public bool Them(Mausac Mausac)
        {
            try
            {
                _db.Mausacs.Add(Mausac);
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

