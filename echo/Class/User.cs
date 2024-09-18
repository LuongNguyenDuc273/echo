using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace echo.Class
{
    public class User
    {
        string ugmail;
        string sdt;
        string tentaikhoan;
        string matkhau;
        string diachi;

        public string Ugmail
        {
            get { return ugmail; }
            set { ugmail = value; }
        }
        public string Sdt
        {
            get { return sdt; }
            set { sdt = value; }
        }

        public string Tentaikhoan
        {
            get { return tentaikhoan; }
            set { tentaikhoan = value; }
        }

        public string Matkhau
        {
            get { return matkhau; }
            set { matkhau = value; }
        }

        public string Diachi
        {
            get { return diachi; }
            set { diachi = value; }
        }
    }
}