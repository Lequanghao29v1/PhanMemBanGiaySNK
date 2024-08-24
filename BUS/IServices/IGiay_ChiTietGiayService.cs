using DAL.Models.ModelRefer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS.IServices
{
    public interface IGiay_ChiTietGiayService
    {
        public List<Giay_ChiTietGiay> GetAll(string? txtTimKiem, string? searchType);
        public Giay_ChiTietGiay GetById(int? id);

    }
}
