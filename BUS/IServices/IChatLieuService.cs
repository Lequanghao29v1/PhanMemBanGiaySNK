using DAL.Models.DomainClass;
using DAL.Models.ModelRefer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.IRepositories
{
    public interface IChatLieuService
    {
        public List<Chatlieu> GetAll(string? txtSearch, string? searchType);
        public Chatlieu GetByID(int id);
        public bool Them(Chatlieu chatlieu);
        public bool Sua(int id, Chatlieu chatlieu);
        public bool Khoa_MoKhoa(int id);
    }
}
