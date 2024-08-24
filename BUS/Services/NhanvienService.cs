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
    public class NhanvienService : INhanvienService
    {
        NhanVienRepository _repos;
        public NhanvienService()
        {
            _repos = new NhanVienRepository();
        }
        public string AddNhanVien(Taikhoan taikhoan)
        {
            try
            {
                _repos.AddNhanVien(taikhoan);
                return "Thêm thành công";
            }
            catch
            {
                return "Thêm thất bại";
            }
        }

        public List<Chucvu> GetChucvu()
        {
            return _repos.GetChucvu();
        }

        public List<Taikhoan> GetTaikhoan(string search)
        {
           return _repos.GetTaikhoan(search);
        }

        public string Khoa_Mokhoa(Taikhoan taikhoan)
        {
            var cloer = _repos.GetTaikhoan(null).FirstOrDefault(x => x.Mataikhoan == taikhoan.Mataikhoan);
            if (cloer == null)
            {
                return "Khoá thất bại";
            }
            else
            {
                if (cloer.Trangthai == true)
                {
                    cloer.Trangthai = false;
                    _repos.Khoa_Mokhoa(cloer);
                    return "Khoá thành công";
                }
                else if (cloer.Trangthai == false)
                {
                    cloer.Trangthai = true;
                    _repos.Khoa_Mokhoa(cloer);
                    return "Mở Khoá thành công";
                }
                return "";
            }
        }

        public string UpdateNhanVien(Taikhoan taikhoan)
        {
            var cloer = _repos.GetTaikhoan(null).FirstOrDefault(x => x.Mataikhoan == taikhoan.Mataikhoan);
            try
            {
                if (cloer == null)
                {
                    return "Sửa thất bại";
                }
                else
                {
                   cloer.Username = taikhoan.Username;
                    cloer.Pasword = taikhoan.Pasword;
                    cloer.Hovaten = taikhoan.Hovaten;
                    cloer.Gioitinh = taikhoan.Gioitinh;
                    cloer.Sodienthoai = taikhoan.Sodienthoai;
                    cloer.Diachi = taikhoan.Diachi;
                    cloer.Email = taikhoan.Email;
                    cloer.Ngaysinh = taikhoan.Ngaysinh;
                    cloer.Machucvu = taikhoan.Machucvu;
                    _repos.UpdateNhanVien(cloer);
                    return "Sửa thành công";
                }
            }
            catch
            {
                return "Có lỗi xảy ra";
            }
        }
    }
}
