using BUS.IServices;
using DAL.Models.DomainClass;
using DAL.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS.Services
{
    public class ChiTietGiayService : IChiTietGiayService
    {
        ChiTietGiayRepository _Rep;
        public ChiTietGiayService()
        {
            _Rep = new ChiTietGiayRepository();
        }
        public List<Giaychitiet> GetAll(string? txtSearch, string? searchType)
        {
            return _Rep.GetAll(txtSearch, searchType);
        }

        public Giaychitiet GetByID(int? id)
        {
            return _Rep.GetByID(id);
        }

        public bool Khoa_MoKhoa(int id)
        {
            if(id == 0)
            {
                return false;
            }
            return _Rep.Khoa_MoKhoa(id);
        }

        public bool Sua(int? id, Giaychitiet Giaychitiet)
        {
            if (id == 0 || Giaychitiet == null)
            {
                return false;
            }
            else if (Giaychitiet.Magiay == 0 ||
                Giaychitiet.Machatlieu == 0 ||
                Giaychitiet.Mamausac == 0 ||
                Giaychitiet.Makichco == 0 ||
                Giaychitiet.Mathuonghieu == 0 ||
                Giaychitiet.Makieudang == 0 ||
                Giaychitiet.Soluongcon < 0 ||
                Giaychitiet.Ngaysua == null ||
                Giaychitiet.Nguoisua == 0 ||
                Giaychitiet.Gia < 0 ||
                Giaychitiet.Mota == "")
            {
                return false;
            }
            return _Rep.Sua(id, Giaychitiet);
        }

        public bool Them(Giaychitiet Giaychitiet)
        {
            if (Giaychitiet.Magiay == 0 ||
                Giaychitiet.Machatlieu == 0 ||
                Giaychitiet.Mamausac == 0 ||
                Giaychitiet.Makichco == 0 ||
                Giaychitiet.Mathuonghieu == 0 ||
                Giaychitiet.Makieudang == 0 ||
                Giaychitiet.Soluongcon <= 0 ||
                Giaychitiet.Ngaytao == null ||
                Giaychitiet.Nguoitao == 0 ||
                Giaychitiet.Gia < 0 ||
                Giaychitiet.Mota == "")
            {
                return false;
            }
            return _Rep.Them(Giaychitiet);
        }
    }
}
