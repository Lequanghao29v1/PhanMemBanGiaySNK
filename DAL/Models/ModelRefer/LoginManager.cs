using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models.ModelRefer
{
    public class LoginManager
    {
        private static LoginManager _instance;
        public static LoginManager Instance => _instance ?? (_instance = new LoginManager());

        public int IdTaiKhoan { get; private set; }
        public int MaChucVu { get; private set; }
        public string HoVaTen { get; private set; }

        public void UpdateLoginInfo(int idTaiKhoan, int maChucVu, string hoVaTen)
        {
            IdTaiKhoan = idTaiKhoan;
            MaChucVu = maChucVu;
            HoVaTen = hoVaTen;
        }
        public void Logout()
        {
            IdTaiKhoan = 0;
            MaChucVu = 0;
            HoVaTen = null;
        }
    }
}
