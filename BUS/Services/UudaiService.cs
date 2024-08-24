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
    public class UudaiService : IUudaiService
    {
        UudaiRepository _repos;
        public UudaiService()
        {
            _repos = new UudaiRepository();
        }
        public string AddUudai(Uudai uudai)
        {
            try
            {
                _repos.AddUudai(uudai);
                return "Thêm thành công";
            }
            catch
            {
                return "Thêm thất bại";
            }
        }

        public List<Taikhoan> GetTaikhoan()
        {
            return _repos.GetTaikhoan();
        }

        public List<Uudai> GetUudais(string search)
        {
            return _repos.GetUudais(search);
        }

        public string Trangthai(Uudai uudai)
        {
            var coler = _repos.GetUudais(null).FirstOrDefault(x => x.Mauudai == uudai.Mauudai);
            if (coler == null)
            {
                return "Kết thúc thất bại";
            }
            else
            {
                //if (coler.Trangthai == 1)
                //{
                //    coler.Trangthai = 0;
                //    _repos.Trangthai(coler);
                //    return "Kết thúc thành công";
                //}
                //else if (coler.Trangthai == 2)
                //{
                //    coler.Trangthai = 0;
                //    _repos.Trangthai(coler);
                //    return "Kết thúc thành công";
                //}
                return "Sản phẩm đã kết thúc rồi";
            }
        }
        public string Updateuudai(Uudai uudai)
        {
            var coler = _repos.GetUudais(null).FirstOrDefault(x => x.Mauudai == uudai.Mauudai);
            try
            {
                if (coler == null)
                {
                    return "Sửa thất bại";
                }
                else
                {
                    coler.Mataikhoan = uudai.Mataikhoan;
                    coler.Tenuudai = uudai.Tenuudai;
                    coler.Phantram = uudai.Phantram;
                    coler.Soluong = uudai.Soluong;
                    coler.Ngaybatdau = uudai.Ngaybatdau;
                    coler.Ngayketthuc = uudai.Ngayketthuc;
                    coler.Trangthai = uudai.Trangthai;
                    _repos.Updateuudai(coler);
                    return "Sửa thành công";
                }
            }
            catch (Exception)
            {

                return "Có lỗi xảy ra";
            }

        }
        public Uudai GetUudai_InTime()
        {
            return _repos.GetUudai_InTime();
        }
    }
}
