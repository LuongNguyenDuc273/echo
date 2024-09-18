using echo.Class;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace echo.echo
{
    public partial class ChiTietSanPham : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            List<Product> products = (List<Product>)Application["DsProduct"];
            User user = (User)Session["User"];

            checkdangnhap();           

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

            Hiensp();
            if (them1.Value == "1")
            {
                themvaogiohang.Value = "";
                Them();
            }
        }
        public void Themgiohang()
        {
            List<Product> products = (List<Product>)Application["DsProduct"];
            User user = (User)Session["User"];
            foreach (Product pr1 in products)
            {
                if (prDetail.Value == pr1.prId)
                {
                    if (Request.Cookies[user.Tentaikhoan] == null || Request.Cookies[user.Tentaikhoan].Value == "")
                    {
                        string cookie = prDetail.Value + "-1";
                        Response.Cookies[user.Tentaikhoan].Value = cookie;
                        Response.Cookies[user.Tentaikhoan].Expires = DateTime.Now.AddDays(15);
                        Response.Redirect("ChiTietSanPham.aspx#sp-relative");
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
                        Response.Redirect("ChiTietSanPham.aspx#sp-relative");
                    }
                }
            }
            themvaogiohang.Value = "";
            prDetail.Value = "";
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

        public void Hiensp()
        {
            List<Product> products = (List<Product>)Application["DsProduct"];
            Product prhien = new Product();
            string pr = Request.QueryString["sp"];

            foreach (Product sp in products)
            {
                if (pr == sp.prId)
                {
                    prhien=sp;
                }
            }
            if (prhien.prId != null)
            {
                string type = "";
                if(prhien.prType == "Keyboard")
                {
                    type = "Bàn phím cơ";
                } else if(prhien.prType== "Mouse")
                {
                    type = "Chuột gaming";
                } else
                {
                    type = "Sản phảm khác";
                }
                MainImg.Src = prhien.imgLocation;
                tensp.InnerHtml = prhien.prName;
                string gia = prhien.prPrice.ToString();
                for (int i = gia.Length - 3; i > 0; i -= 3)
                {
                    gia = gia.Substring(0, i) + "," + gia.Substring(i);
                }
                navigator.InnerHtml = "Trang chủ -> Sản phẩm -> " + type;
                giasp.InnerHtml = gia;
                motasp.InnerHtml = prhien.prDescribe;              
            }
            else
            {
                Response.Redirect("TrangChu.aspx");
            }
        }

        public void Them()
        {
            User user = (User)Session["User"];
            Product pr = (Product)Session["Product"];
            if(pr.prId != null)
            {
                if (user.Tentaikhoan != null)
                {
                    if (Request.Cookies[user.Tentaikhoan] == null || Request.Cookies[user.Tentaikhoan].Value == "")
                    {
                        string cookie = pr.prId + "-" + soluong.Value;
                        Response.Cookies[user.Tentaikhoan].Value = cookie;
                        Response.Cookies[user.Tentaikhoan].Expires = DateTime.Now.AddDays(15);
                        //Response.Redirect("GioHang.aspx");
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
                            if (sp[0] == pr.prId)
                            {
                                string newelement = sp[0] + "-" + (Int32.Parse(sp[1]) + Int32.Parse(soluong.Value)).ToString();
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
                            string element = pr.prId + "-" + soluong.Value;
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
                else
                {
                    string dn = HttpContext.Current.Request.Url.PathAndQuery;
                    Session["SignIn"] = dn;
                    Response.Redirect("SignIn.aspx");
                }
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