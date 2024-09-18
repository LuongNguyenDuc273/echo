using echo.Class;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace echo.echo
{
    public partial class SignIn : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(IsPostBack)
            {
                //int sldn = (int)Session["solandn"];

                //lấy danh sách người dùng từ application
                List<User> users = (List<User>)Application["DsUser"];
                User user = new User();
                string dn = (string)Session["SignIn"];

                //lấy dữ liệu được gửi đi từ phía client
                string tk = Request.Form["txttaikhoan"];
                string mk = Request.Form["txtmatkhau"];
                int err = 0;

                //chạy vòng lặp xem có đúng tài khoản và mật khẩu không
                foreach (User user1 in users)
                {
                    if ((user1.Tentaikhoan == tk && user1.Matkhau == mk) || (user1.Ugmail == tk && user1.Matkhau == mk))
                    {
                        err = 1;
                        user = user1;
                        Session["User"] = user;
                    }
                }

                //nếu đúng tài khoản và mật khẩu thì chuyển sang trang tương ứng
                if (err != 0)
                {
                    //sldn++;
                    //Session["solandn"] = sldn;
                    if (dn != "")
                    {
                        Response.Redirect(dn);

                    }
                    else
                    {
                        Response.Redirect("TrangChu.aspx");
                    }
                }
                else
                {
                    alertk.InnerHtml = "Tài khoản hoặc mật khẩu không chính xác";
                    txttaikhoan.Value = tk;
                }


            }
        }
    }
}