using echo.Class;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace echo.echo
{
    public partial class SanPhamTimKiem : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            List<Product> products = (List<Product>)Application["DsProduct"];
            User user = (User)Session["User"];
            Product searched = (Product)Session["search"];

            checkdangnhap();

            if(searched.prId == ""|| searched.prId==null)
            {
                thongbao.InnerHtml = "Không có sản phẩm tìm kiếm";
                dssanpham.InnerHtml = "";
            } else
            {
                //hiện ra danh sách sản phẩm
                HiensptK();

                //check xem ấn thêm vào giỏ hàng
                if (themvaogiohang.Value == "1")
                {
                    if (user.Tentaikhoan == null)
                    {
                        Response.Redirect("SignIn.aspx");
                        themvaogiohang.Value = "";
                    }
                    else
                    {
                        Themgiohang();
                    }
                }

                //Session["search"] = new Product();
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
        public void Themgiohang()
        {
            List<Product> products = (List<Product>)Application["DsProduct"];
            User user = (User)Session["User"];
            foreach (Product pr in products)
            {
                if (prDetail.Value == pr.prId)
                {
                    if (Request.Cookies[user.Tentaikhoan] == null || Request.Cookies[user.Tentaikhoan].Value == "")
                    {
                        string cookie = prDetail.Value + "-1";
                        Response.Cookies[user.Tentaikhoan].Value = cookie;
                        Response.Cookies[user.Tentaikhoan].Expires = DateTime.Now.AddDays(15);
                    }
                    else
                    {
                        string cookie = Request.Cookies[user.Tentaikhoan].Value;
                        string[] arr = cookie.Split('_');
                        string newcookie = "";
                        List<string> newarr = new List<string>();
                        int endlp = 0;
                        foreach (string arr1 in arr)
                        {
                            string[] sp = arr1.Split('-');
                            if (sp[0] == prDetail.Value)
                            {
                                string newelement = sp[0] + "-" + (Int32.Parse(sp[1]) + 1).ToString();
                                newarr.Add(newelement);
                                endlp++;
                            }
                            else
                            {
                                newarr.Add(arr1);
                            }
                        }

                        if (endlp == 0)
                        {
                            string element = prDetail.Value + "-1";
                            newarr.Add(element);
                        }
                        int i = 0;
                        foreach (string arr2 in newarr)
                        {
                            if (i == 0)
                            {
                                newcookie = arr2;
                            }
                            else
                            {
                                newcookie += "_" + arr2;
                            }
                            i++;
                        }
                        Response.Cookies[user.Tentaikhoan].Value = newcookie;
                    }
                }
            }
            themvaogiohang.Value = "";
            prDetail.Value = "";
            Response.Redirect("SanPhamChuot.aspx#product1");
        }

        public void HiensptK()
        {
            Product searched = (Product)Session["search"];
            string output = "<div class=\"sp-box\" id=\"sp01\" onclick=\"sanpham_click(this.id)\">\r\n<input type=\"hidden\" value=\"" + searched.prId + "\"/>\r\n<img src=\"" + searched.imgLocation + "\" alt=\"anh-sp\">\r\n<div class=\"sp-content\">\r\n<span>#" + searched.prType + "</span>\r\n<h4>" + searched.prName + "</h4>\r\n<h3>" + formatgia(searched.prPrice.ToString()) + " VNĐ</h3>\r\n</div>\r\n<button value=\"" + searched.prId + "\" onclick=\"giohang_click(this.value)\"><i class=\"uil uil-shopping-cart-alt cart\"></i></button>\r\n </div>";
            dssanpham.InnerHtml = output;
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
            }
        }

        protected void Buttonsearch_Click(object sender, EventArgs e)
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
    }
}