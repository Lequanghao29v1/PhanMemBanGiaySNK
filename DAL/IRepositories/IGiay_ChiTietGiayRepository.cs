using DAL.Models.ModelRefer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.IRepositories
{
    public interface IGiay_ChiTietGiayRepository
    {
        public List<Giay_ChiTietGiay> GetAll(string? txtTimKiem, string? searchType);
    public Giay_ChiTietGiay GetById(int? id);
    }
}
