using echo.Class;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace echo.echo
{
    public partial class GioHang : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            checkdangnhap();
            //lấy session user
            User user = (User)Session["User"];

            //check xem đã đăng nhập chưa
            if(user.Tentaikhoan != null)
            {
                //check xem đã có cookies chưa
                if (Request.Cookies[user.Tentaikhoan] == null || Request.Cookies[user.Tentaikhoan].Value == "")
                {
                    return;
                }
                else
                {

                    string cookie_value = Request.Cookies[user.Tentaikhoan].Value;

                    //nếu đăng nhập rồi thì sẽ gắn các giá trị vào thẻ table với cookie tương ứng
                    Hiensp(cookie_value);

                    //sự kiến ấn nút bỏ sp
                    if (huysp.Value != "")
                    {
                        Huysp(cookie_value);
                        huysp.Value = "";
                    }

                    //thay đổi số lượng
                    if (chinhsoluong.Value != "")
                    {
                        Updatesoluong();
                        Response.Redirect("GioHang.aspx#cart");
                    }
                }
            }   
            else
            {
                string dn = HttpContext.Current.Request.Url.PathAndQuery;
                Session["SignIn"] = dn;
                Response.Redirect("SignIn.aspx");
            }
        }
        
        public void Hiensp(string cookie_value)
        {
            //Tạo thẻ table và các thẻ con bên trong
            string input = "<table>\r\n<thead>\r\n<td>Hủy</td>\r\n<td>Ảnh sản phẩm</td>\r\n<td>Tên sản phẩm</td>\r\n<td>Số lượng</td>\r\n<td>Giá</td>\r\n<td>Thành tiền</td>\r\n</thead>\r\n<tbody>\r\n";
            List<Product> products = (List<Product>)Application["DsProduct"];
            string coo = cookie_value;
            string[] arr = coo.Split('_');
            int tongtien= 0;
            foreach (string arr1 in arr)
            {
                string[] sp = arr1.Split('-');
                foreach (Product pr in products)
                {
                    if (sp[0] == pr.prId)
                    {
                        int tiensp = ((Int32.Parse(sp[1])) * pr.prPrice);
                        tongtien += tiensp;
                        input += "<tr>\r\n<td><button value=\"" + sp[0] + "\" onclick=\"huysp_click(this.value)\"><i class=\"uil uil-times-circle\"></i></button></td>\r\n<td><img src=\"" + pr.imgLocation + "\" alt=\"anh-sp\"></td>\r\n<td>" + pr.prName + "</td>\r\n<td><input type=\"number\" value=\"" + sp[1] + "\" id=\"soluong\" name=\"soluong\" value=\"1\" onchange=\"nhapsoluong(this.value)\"></td>\r\n<td>" + formatgia(pr.prPrice.ToString()) + " VNĐ</td>\r\n<td>" + formatgia(tiensp.ToString()) + " VNĐ</td>\r\n</tr>\r\n";
                    }
                }
            }
            input += "</tbody>\r\n</table>";
            cart.InnerHtml = input;
            tongtienhang.InnerHtml = formatgia(tongtien.ToString());
            tongthanhtoan.InnerHtml = formatgia(tongtien.ToString());
        }

        public void Huysp(string cookie_value)
        {
            User user = (User)Session["User"];
            List<Product> products = (List<Product>)Application["DsProduct"];
            string cook = cookie_value;
            string[] arr = cook.Split('_');
            List<string> newarr = new List<string>();
            foreach (string arr1 in arr)
            {
                string[] sp = arr1.Split('-');
                if (huysp.Value != sp[0])
                {
                    newarr.Add(arr1);
                }
            }
            string newcookie = "";
            int i = 0;
            foreach (string arr2 in newarr)
            {
                if (i == 0)
                {
                    newcookie = arr2;
                }
                else
                {
                    newcookie+="_"+ arr2;
                }
                i++;
            }
            Response.Cookies[user.Tentaikhoan].Value = newcookie;
            Hiensp(newcookie);
        }

        public string formatgia(string input)
        {
            for (int i = input.Length - 3; i > 0; i -= 3)
            {
                input = input.Substring(0, i) + "," + input.Substring(i);
            }
            return input;
        }

        protected void btndangnhap_Click(object sender, EventArgs e)
        {
            if (btndangnhap.Text == "Đăng nhập")
            {
                string dn = HttpContext.Current.Request.Url.PathAndQuery;
                Session["SignIn"] = dn;
                Response.Redirect("SignIn.aspx");
            }
            else
            {
                Session["User"] = new User();
                btndangnhap.Text = "Đăng nhập";
                Response.Redirect("TrangChu.aspx");
            }
        }

        public void checkdangnhap()
        {
            User user = (User)Session["User"];

            //check đăng nhập
            if (user.Tentaikhoan != null)
            {
                btndangnhap.Text = user.Tentaikhoan;
            }          
        }

        public void Updatesoluong()
        {
            User user = (User)Session["User"];
            string cookie = Request.Cookies[user.Tentaikhoan].Value;
            string newcookie = "";

            if (chinhsoluong.Value != "")
            {
                string[] sl = (chinhsoluong.Value).Split('_');
                string[] cookiearr= cookie.Split('_');
                int i = 0;
                foreach(string arr1 in cookiearr)
                {
                    string[] sp = arr1.Split('-');
                    if (i == 0)
                    {                      
                        newcookie = sp[0] + "-" + sl[i];
                    }   
                    else
                    {
                        newcookie+= "_" + sp[0] + "-" + sl[i];
                    }
                    i++;
                }
                Response.Cookies[user.Tentaikhoan].Value=newcookie;
                Hiensp(newcookie);
                chinhsoluong.Value = "";
            }
        }

        protected void Buttonsearch_Click1(object sender, EventArgs e)
        {
            List<Product> products = (List<Product>)Application["DsProduct"];
            Product searchedproduct = new Product();
            string search = Request.Form["search"];

            foreach (Product pr in products)
            {
                if ((pr.prName).ToLower() == search.ToLower())
                {
                    searchedproduct = pr;
                    Session["search"] = searchedproduct;
                }
            }
            Response.Redirect("SanPhamTimKiem.aspx");
        }

        protected void bttnmua_Click(object sender, EventArgs e)
        {
            User user = (User)Session["User"];
            if (Request.Cookies[user.Tentaikhoan + "_lichsumuahang"]==null|| Request.Cookies[user.Tentaikhoan + "_lichsumuahang"].Value=="")
            {               
                Response.Cookies[user.Tentaikhoan + "_lichsumuahang"].Value = Request.Cookies[user.Tentaikhoan].Value;
                Response.Cookies[user.Tentaikhoan + "_lichsumuahang"].Expires = DateTime.Now.AddDays(15);
                string input = "<table>\r\n<thead>\r\n<td>Hủy</td>\r\n<td>Ảnh sản phẩm</td>\r\n<td>Tên sản phẩm</td>\r\n<td>Số lượng</td>\r\n<td>Giá</td>\r\n<td>Thành tiền</td>\r\n</thead>\r\n<tbody>\r\n";
                cart.InnerHtml = input;
                Response.Cookies[user.Tentaikhoan].Value = "";
                Response.Redirect("LichSuGiaoDich.aspx");
            }   else
            {
                string cookie = Request.Cookies[user.Tentaikhoan + "_lichsumuahang"].Value;
                cookie +="_"+ Request.Cookies[user.Tentaikhoan].Value;
                Response.Cookies[user.Tentaikhoan + "_lichsumuahang"].Value = cookie;
                string input = "<table>\r\n<thead>\r\n<td>Hủy</td>\r\n<td>Ảnh sản phẩm</td>\r\n<td>Tên sản phẩm</td>\r\n<td>Số lượng</td>\r\n<td>Giá</td>\r\n<td>Thành tiền</td>\r\n</thead>\r\n<tbody>\r\n";
                cart.InnerHtml = input;
                Response.Cookies[user.Tentaikhoan].Value = "";
                Response.Redirect("LichSuGiaoDich.aspx");
            } 
        }
    }
}