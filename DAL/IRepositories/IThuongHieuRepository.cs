using DAL.Models.DomainClass;
using DAL.Models.ModelRefer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.IRepositories
{
    public interface IThuongHieuRepository
    {
        public List<Thuonghieu> GetAll(string? txtTimKiem, string? searchType);
        public Thuonghieu GetByID(int id);
        public bool Them(Thuonghieu thuonghieu);
        public bool Sua(int id, Thuonghieu thuonghieu);
        public bool Khoa_MoKhoa(int id);

    }
}
