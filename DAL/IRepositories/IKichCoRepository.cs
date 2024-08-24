using DAL.Models.DomainClass;
using DAL.Models.ModelRefer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.IRepositories
{
    public interface IKichCoRepository
    {
        public List<Kichco> GetAll(string? txtTimKiem, string? searchType);
        public Kichco GetByID(int id);
        public bool Them(Kichco kichco);
        public bool Sua(int id, Kichco kichco);
        public bool Khoa_MoKhoa(int id);

    }
}
