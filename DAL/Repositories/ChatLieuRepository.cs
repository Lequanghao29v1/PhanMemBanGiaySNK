using DAL.IRepositories;
using DAL.Models.Context;
using DAL.Models.DomainClass;
using DAL.Models.ModelRefer;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DAL.Repositories
{
    public class ChatLieuRepository : IChatLieuRepository
    {
        DBContext _db;
        public ChatLieuRepository()
        {
            _db = new DBContext();
        }
        public List<Chatlieu> GetAll(string? txtSearch, string? searchType)
        {
            if (string.Equals(searchType, SearchType.All))
            {
                return _db.Chatlieus.Where(c => c.Mataikhoan.ToString().Contains(txtSearch) || c.Trangthai.ToString().Contains(txtSearch) || c.Tenchatlieu.Contains(txtSearch) || c.Mota.Contains(txtSearch)).ToList();
            }
            if (string.Equals(searchType, SearchType.tenChatLieu))
            {
                return _db.Chatlieus.Where(c => c.Tenchatlieu.Contains(txtSearch)).ToList();
            }
            if (string.Equals(searchType, SearchType.moTaChatLieu))
            {
                return _db.Chatlieus.Where(c => c.Mota.Contains(txtSearch)).ToList();
            }
            if (string.Equals(searchType, SearchType.trangThaiChatLieu))
            {
                return _db.Chatlieus.Where(c => c.Trangthai.ToString().Contains(txtSearch)).ToList();
            }
            if (string.Equals(searchType, SearchType.idNguoiThemChatLieu))
            {
                return _db.Chatlieus.Where(c => c.Mataikhoan.ToString().Contains(txtSearch)).ToList();
            }
            return _db.Chatlieus.ToList();
        }

        public Chatlieu GetByID(int id)
        {
            return _db.Chatlieus.FirstOrDefault(c => c.Machatlieu == id);
        }

        public bool Khoa_MoKhoa(int id)
        {
            try
            {
                var Obj = _db.Chatlieus.FirstOrDefault(c => c.Machatlieu == id);
                if (Obj == null) { return false; }
                if (Obj.Trangthai == true)
                {
                    Obj.Trangthai = false;
                }
                else
                {
                    Obj.Trangthai = true;
                }
                _db.Chatlieus.Update(Obj);
                _db.SaveChanges();
                return true;

            }
            catch { return false; }
        }

        public bool Sua(int id, Chatlieu chatlieu)
        {
            try
            {
                var Obj = _db.Chatlieus.FirstOrDefault(c => c.Machatlieu == id);
                if (Obj == null) { return false; }

                Obj.Tenchatlieu = chatlieu.Tenchatlieu;
                Obj.Mota = chatlieu.Mota;

                _db.Chatlieus.Update(Obj);
                _db.SaveChanges();
                return true;

            }
            catch { return false; }
        }

        public bool Them(Chatlieu chatlieu)
        {
            try
            {
                _db.Chatlieus.Add(chatlieu);
                _db.SaveChanges();

                return true;
            }
            catch(Exception e)
            {
                Console.WriteLine(e.ToString());
                Console.WriteLine("Inner Exception: " + e.InnerException.Message);
                return false;
            }
        }
    }
}
