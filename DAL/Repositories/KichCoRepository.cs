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
    public class KichCoRepository : IKichCoRepository
    {
        DBContext _db;
        public KichCoRepository()
        {
            _db = new DBContext();
        }

        public List<Kichco> GetAll(string? txtSearch, string? searchType)
        {
            if (string.Equals(searchType, SearchType.All))
            {
                return _db.Kichcos.Where(c => c.Mataikhoan.ToString().Contains(txtSearch) || c.Trangthai.ToString().Contains(txtSearch) || c.Tenkichco.Contains(txtSearch) || c.Mota.Contains(txtSearch)).ToList();
            }
            if (string.Equals(searchType, SearchType.tenKichCo))
            {
                return _db.Kichcos.Where(c => c.Tenkichco.Contains(txtSearch)).ToList();
            }
            if (string.Equals(searchType, SearchType.moTaKichCo))
            {
                return _db.Kichcos.Where(c => c.Mota.Contains(txtSearch)).ToList();
            }
            if (string.Equals(searchType, SearchType.trangThaiKichCo))
            {
                return _db.Kichcos.Where(c => c.Trangthai.ToString().Contains(txtSearch)).ToList();
            }
            if (string.Equals(searchType, SearchType.idNguoiThemKichCo))
            {
                return _db.Kichcos.Where(c => c.Mataikhoan.ToString().Contains(txtSearch)).ToList();
            }
            return _db.Kichcos.ToList();
        }

        public Kichco GetByID(int id)
        {
            return _db.Kichcos.FirstOrDefault(c => c.Makichco == id);
        }

        public bool Khoa_MoKhoa(int id)
        {
            try
            {
                var Obj = _db.Kichcos.FirstOrDefault(c => c.Makichco == id);
                if (Obj == null) { return false; }
                if (Obj.Trangthai == true)
                {
                    Obj.Trangthai = false;
                }
                else
                {
                    Obj.Trangthai = true;
                }
                _db.Kichcos.Update(Obj);
                _db.SaveChanges();
                return true;

            }
            catch { return false; }
        }

        public bool Sua(int id, Kichco Kichco)
        {
            try
            {
                var Obj = _db.Kichcos.FirstOrDefault(c => c.Makichco == id);
                if (Obj == null) { return false; }

                Obj.Tenkichco = Kichco.Tenkichco;
                Obj.Mota = Kichco.Mota;

                _db.Kichcos.Update(Obj);
                _db.SaveChanges();
                return true;

            }
            catch { return false; }
        }

        public bool Them(Kichco Kichco)
        {
            try
            {
                _db.Kichcos.Add(Kichco);
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