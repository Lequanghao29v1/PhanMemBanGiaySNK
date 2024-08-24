using DAL.IRepositories;
using DAL.Models.DomainClass;
using DAL.Models.ModelRefer;
using DAL.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace BUS.Services
{
    public class ThuongHieuServices:IThuongHieuRepository
    {
        ThuongHieuRepository _Rep;
        public ThuongHieuServices()
        {
            _Rep = new ThuongHieuRepository();
        }

        public List<Thuonghieu> GetAll(string? txtSearch, string? searchType)
        {
            return _Rep.GetAll(txtSearch, searchType);
        }

        public Thuonghieu GetByID(int id)
        {
            return _Rep.GetByID(id);
        }

        public bool Khoa_MoKhoa(int id)
        {
            if (id == 0 || id == null)
            {
                return false;
            }

            return _Rep.Khoa_MoKhoa(id);
        }

        public bool Sua(int id, Thuonghieu Thuonghieu)
        {
            if (id == 0)
            {
                return false;
            }
            else if (Thuonghieu == null)
            {
                return false;
            }
            else if (Thuonghieu.Tenthuonghieu == "" || Thuonghieu.Mota == "" ||
                !Regex.IsMatch(Thuonghieu.Email, @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$") ||
                !Regex.IsMatch(Thuonghieu.Sdt, @"^\d{10}$"))
            {
                return false;
            }

            return _Rep.Sua(id, Thuonghieu);
        }

        public bool Them(Thuonghieu Thuonghieu)
        {
             if (Thuonghieu == null)
            {
                return false;
            }
            else if (Thuonghieu.Tenthuonghieu == "" || Thuonghieu.Mota == "" ||
                !Regex.IsMatch(Thuonghieu.Email, @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$") ||
                !Regex.IsMatch(Thuonghieu.Sdt, @"^\d{10}$") ||
                Thuonghieu.Mataikhoan==0)
            {
                return false;
            }

            return _Rep.Them(Thuonghieu);
        }
    }
}
