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
    public class GiaocachitietService : IGiaocachitietService
    {
        GiaocachitietRepository _repos;
        public GiaocachitietService()
        {
            _repos = new GiaocachitietRepository();
        }
        public string AddCaCT(Giaocanhanvien cact)
        {
            try
            {
                _repos.AddCaCT(cact);
                return "Thêm thành công";
            }
            catch (Exception)
            {

                return "Thêm thất bại";
            }
        }
        public List<Giaoca> GetGiaocas(string search)
        {
            return _repos.GetGiaocas(search);
        }

        public List<Taikhoan> GetTaikhoans(string search)
        {
            return _repos.GetTaikhoans(search);
        }

        public List<Giaocanhanvien> giaocanhanviens(string search)
        {
            return _repos.giaocanhanviens(search);
        }
        public string HuyCaCT(Giaocanhanvien cact)
        {
            var coler = _repos.giaocanhanviens(null).FirstOrDefault(x => x.Magiaocanhanvien == cact.Magiaocanhanvien);
            if (coler == null)
            {
                return "Huỷ thất bại";
            }
            else
            {
                //if (coler.Trangthai == true)
                //{
                //    coler.Trangthai = 1;
                //    _repos.HuyCaCT(coler);
                //    return "Huỷ ca thành công";
                //}
                //else if (coler.Trangthai == 2)
                //{
                //    return "Ca đang diễn ra không thể huỷ";
                //}
                //else if (coler.Trangthai == 0)
                //{
                //    return "Ca đã kết thúc không thể huỷ";
                //}
                return "Ca đã huỷ rồi";
            }
        }
        public string UpdateCaCT(Giaocanhanvien cact)
        {
            var coler = _repos.giaocanhanviens(null).FirstOrDefault(x => x.Magiaocanhanvien == cact.Magiaocanhanvien);
            try
            {
                if (coler == null)
                {
                    return "Sửa thất bại";
                }
                else
                {
                    coler.Magiaoca = cact.Magiaoca;
                    coler.Mataikhoan = cact.Mataikhoan;
                    coler.Ngaygiaoca = cact.Ngaygiaoca;
                    coler.Thoigianden = cact.Thoigianden;
                    coler.Thoigianve = cact.Thoigianve;
                    coler.Sanphamdagiao = cact.Sanphamdagiao;
                    coler.Tiendagiao = cact.Tiendagiao;
                    coler.Ghichu = cact.Ghichu;
                    coler.Trangthai = cact.Trangthai;
                    _repos.UpdateCaCT(coler);
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
