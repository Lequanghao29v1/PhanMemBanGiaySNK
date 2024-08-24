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
    public class CaService : ICaService
    {
        CaRepository _repos;
        public CaService()
        {
            _repos = new CaRepository();
        }
        public string AddCa(Giaoca ca)
        {
            try
            {
                _repos.AddCa(ca);
                return "Thêm thành công";
            }
            catch (Exception)
            {

                return "Thêm thất bại";
            }
        }

        public List<Giaoca> Giaocas(string search)
        {
            return _repos.Giaocas(search);
        }

        public string UpdateCa(Giaoca ca)
        {
            var coler = _repos.Giaocas(null).FirstOrDefault(x => x.Magiaoca == ca.Magiaoca);
            try
            {
                if(coler == null)
                {
                    return "Sửa thất bại";
                }
                else
                {
                    coler.Tenca = ca.Tenca;
                    coler.Thoigianbatdau = ca.Thoigianbatdau;
                    coler.Thoigianketthuc = ca.Thoigianketthuc;
                    _repos.UpdateCa(coler);
                    return "Sửa thành công";
                }
            }
            catch (Exception)
            {

                return "Có lỗi xảy ra";
            }
        }
    }
}
