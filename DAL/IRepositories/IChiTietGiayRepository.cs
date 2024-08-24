using DAL.Models.DomainClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.IRepositories
{
    public interface IChiTietGiayRepository
    {
        public List<Giaychitiet> GetAll(string? txtSearch, string? searchType);
        public Giaychitiet GetByID(int? id);
        public bool Them(Giaychitiet Giaychitiet);
        public bool Sua(int? id, Giaychitiet Giaychitiet);
        public bool Khoa_MoKhoa(int id);

    }
}
