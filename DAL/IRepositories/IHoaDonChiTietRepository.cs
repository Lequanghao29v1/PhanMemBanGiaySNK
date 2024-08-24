using DAL.Models.DomainClass;
using DAL.Models.ModelRefer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.IRepositories
{
    public interface IHoaDonChiTietRepository
    {
        public List<HoaDonChiTiet_SP> GetAll(string? txtTimKiem, string? searchType);
        public Hoadonchitiet GetByID(int? id);
        public bool Them(Hoadonchitiet hoadonchitiet);
        public bool Sua(int? id,Hoadonchitiet hoadonchitiet);
        public bool Xoa(int? id);
    }
}
