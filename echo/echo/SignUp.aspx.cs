using echo.Class;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace echo.echo
{
    public partial class SignUp : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack)
            {
                //lấy danh sách người dùng từ application
                List<User> users = (List<User>)Application["DsUser"];
                User u1 = new User();


                //lấy dữ liệu được gửi đi từ phía client
                int err = 0;
                string gmail = Request.Form["txtgmail"];
                string usdt = Request.Form["sdt"];
                string tk = Request.Form["txttaikhoan"];
                string mk = Request.Form["txtmatkhau"];
                string rmk = Request.Form["txtrmatkhau"];
                string diachi = Request.Form["txtdiachi"];

                //chạy vòng check xem tài khoản đã được đăng ký chưa
                foreach (User user in users)
                {
                    if (user.Ugmail == gmail)
                    {
                        alertgmail.InnerHtml = "Gmail này đã được đăng ký xin hãy nhập lại!";
                        alerttaikhoan.InnerHtml = "";
                        err = 1;
                        txtgmail.Value = "";
                        txtgmail.Focus();
                        sdt.Value = usdt;
                        txttaikhoan.Value = tk;
                        txtmatkhau.Value = mk;
                        txtrmatkhau.Value = rmk;
                        txtdiachi.Value = diachi;
                    }
                    else if (user.Tentaikhoan == tk)
                    {
                        alertgmail.InnerHtml = "";
                        alerttaikhoan.InnerHtml = "Tên tài khoản này đã tồn tại xin hãy nhập tên tài khoản khác!";
                        err = 1;
                        txtgmail.Value = gmail;
                        sdt.Value = usdt;
                        txttaikhoan.Value = "";
                        txttaikhoan.Focus();
                        txtmatkhau.Value = mk;
                        txtrmatkhau.Value = rmk;
                        txtdiachi.Value = diachi;
                    }
                }

                //nếu chưa có tài khoản đăng ký thì thực hiện lưu tài khoản vào application
                if (err != 1)
                {
                    u1.Ugmail = gmail;
                    u1.Sdt = usdt;
                    u1.Tentaikhoan = tk;
                    u1.Matkhau = mk;
                    u1.Diachi = diachi;
                    users.Add(u1);
                    Application["DsUser"] = users;
                    Response.Redirect("SignIn.aspx");
                }
            }
        }
    }
}