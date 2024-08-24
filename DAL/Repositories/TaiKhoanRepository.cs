using DAL.IRepositories;
using DAL.Models.Context;
using DAL.Models.DomainClass;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories
{
    public class TaiKhoanRepository : ITaiKhoanRepository
    {
        DBContext _db;
        public TaiKhoanRepository()
        {
            _db = new DBContext();
        }
        public List<Taikhoan> GetAll(string? txtSearch, string? SearchType)
        {
            return _db.Taikhoans.ToList();
        }
        public bool Sua(int? id, Taikhoan taikhoan)
        {
            try
            {
                var objTaiKhoan = _db.Taikhoans.FirstOrDefault(a => a.Mataikhoan == id);
                objTaiKhoan.Username = taikhoan.Username;
                objTaiKhoan.Pasword = taikhoan.Pasword;
                objTaiKhoan.Hovaten = taikhoan.Hovaten;
                objTaiKhoan.Gioitinh = taikhoan.Gioitinh;
                objTaiKhoan.Sodienthoai = taikhoan.Sodienthoai;
                objTaiKhoan.Diachi = taikhoan.Diachi;
                objTaiKhoan.Email = taikhoan.Email;
                objTaiKhoan.Ngaysinh = taikhoan.Ngaysinh;
                objTaiKhoan.Ngaytaotaikhoan = taikhoan.Ngaytaotaikhoan;
                objTaiKhoan.Machucvu = taikhoan.Machucvu;
                objTaiKhoan.Trangthai = taikhoan.Trangthai;
                _db.Taikhoans.Update(objTaiKhoan);
                _db.SaveChanges();
                return true;

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                Console.WriteLine("Inner Exception: " + ex.InnerException.Message);

                return false;
            }
        }
    }
}