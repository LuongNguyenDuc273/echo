using echo.Class;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;

namespace echo.echo
{
    public partial class LichSuGiaoDich : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            User user = (User)Session["User"];
            checkdangnhap();
            if (user.Tentaikhoan != null)
            {
                if (Request.Cookies[user.Tentaikhoan + "_lichsumuahang"] == null || Request.Cookies[user.Tentaikhoan + "_lichsumuahang"].Value == "")
                {
                    return;
                } else
                {
                    Hiensp();
                }               
            }
            else
            {
                Response.Redirect("SignIn.aspx");
            }

            if(Request.Cookies[user.Tentaikhoan + "_lichsumuahang"] == null || Request.Cookies[user.Tentaikhoan + "_lichsumuahang"].Value == "")
            {
                string dn = HttpContext.Current.Request.Url.PathAndQuery;
                Session["SignIn"] = dn;
                Response.Redirect("TrangChu.aspx");
            } 
        }

        public void Hiensp()
        {
            User user = (User)Session["User"];
            //Tạo thẻ table và các thẻ con bên trong
            string input = "<table>\r\n<thead>\r\n<td>Ảnh sản phẩm</td>\r\n<td>Tên sản phẩm</td>\r\n<td>Số lượng</td>\r\n<td>Giá</td>\r\n<td>Thành tiền</td>\r\n</thead>\r\n<tbody>\r\n";
            List<Product> products = (List<Product>)Application["DsProduct"];
            string coo = Request.Cookies[user.Tentaikhoan + "_lichsumuahang"].Value;
            string[] arr = coo.Split('_');
            int tongtien = 0;
            foreach (string arr1 in arr)
            {
                string[] sp = arr1.Split('-');
                foreach (Product pr in products)
                {
                    if (sp[0] == pr.prId)
                    {
                        int tiensp = ((Int32.Parse(sp[1])) * pr.prPrice);
                        tongtien += tiensp;
                        input += "<tr>\r\n<td><img src=\"" + pr.imgLocation + "\" alt=\"anh-sp\"></td>\r\n<td>" + pr.prName + "</td>\r\n<td><input type=\"number\" value=\"" + sp[1] + "\" readonly></td>\r\n<td>" + formatgia(pr.prPrice.ToString()) + " VNĐ</td>\r\n<td>" + formatgia(tiensp.ToString()) + " VNĐ</td>\r\n</tr>\r\n";
                    }
                }
            }
            input += "</tbody>\r\n</table>";
            cart.InnerHtml = input;
            tongthanhtoan.InnerHtml = "TỔNG THANH TOÁN: "+ formatgia(tongtien.ToString());
        }

        public string formatgia(string input)
        {
            for (int i = input.Length - 3; i > 0; i -= 3)
            {
                input = input.Substring(0, i) + "," + input.Substring(i);
            }
            return input;
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

        protected void Buttonsearch_Click(object sender, EventArgs e)
        {
            List<Product> products = (List<Product>)Application["DsProduct"];
            Product searchedproduct = new Product();
            string search = Request.QueryString["search"];

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
    }
}