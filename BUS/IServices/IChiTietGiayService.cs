using DAL.Models.DomainClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS.IServices
{
    public interface IChiTietGiayService
    {
        public List<Giaychitiet> GetAll(string? txtSearch, string? searchType);
        public Giaychitiet GetByID(int? id);
        public bool Them(Giaychitiet Giaychitiet);
        public bool Sua(int? id, Giaychitiet Giaychitiet);
        public bool Khoa_MoKhoa(int id);

    }
}
