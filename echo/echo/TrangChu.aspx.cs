using echo.Class;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace echo.echo.TrangChu
{
    public partial class TrangChu : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            List<Product> products = (List<Product>)Application["DsProduct"];
            User user = (User)Session["User"];

            //if (user.Tentaikhoan != null)
            //{
            //    Hientongsotien();
            //}
            
            //hiện ra số lần đăng nhập
            //int sldn = (int)Session["solandn"];
            //solandn.InnerHtml="Số lần đăng nhập: "+sldn.ToString();

            //check đăng nhập
            if (user.Tentaikhoan != null)
            {
                btndangnhap.Text = user.Tentaikhoan;
                if(user.Tentaikhoan == "admin")
                {
                    adminsp.InnerHtml = "Quản lý sản phẩm";
                } else
                {
                    adminsp.InnerHtml = "";
                }
            } 


            //check xem ấn chi tiết sản phẩm
            if (prDetail.Value != "" && themvaogiohang.Value == "")
            {
                foreach (Product pr in products)
                {
                    if (prDetail.Value == pr.prId)
                    {
                        Session["Product"] = pr;
                        prDetail.Value = "";
                        themvaogiohang.Value = "";
                        Response.Redirect("ChiTietSanPham.aspx");
                    }
                }
            }

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
        }


        //public void Hientongsotien()
        //{
        //    List<Product> products = (List<Product>)Application["DsProduct"];
        //    User user = (User)Session["User"];
        //    string cookie = Request.Cookies[user.Tentaikhoan].Value;
        //    int tongtien= 0;

        //    //"pr01-2_pr02-3";
        //    //split("_") pr01-2  pr02-3 
        //    //split("-") pr01 2  pr02 3
        //    if (user.Tentaikhoan == null)
        //    {
        //        return;
        //    } else
        //    {
        //        foreach(Product pr in products)
        //        {
        //            string[] cacsp = cookie.Split('_');
        //            foreach(string sps in cacsp)
        //            {
        //                string[] spid = sps.Split('-');
        //                if (spid[0] == pr.prId)
        //                {
        //                    tongtien += pr.prPrice * Int32.Parse(spid[1]);
        //                }
        //            }
        //        }
        //    }
        //    tongsotien.InnerHtml = "Tổng tiền trong giỏ hàng là: " + tongtien.ToString() + " VNĐ";
        //}

        protected void btndangnhap_Click(object sender, EventArgs e)
        {
            if (btndangnhap.Text == "Đăng nhập")
            {
                Response.Redirect("SignIn.aspx");
            }
            else
            {
                Session["User"] = new User();
                btndangnhap.Text = "Đăng nhập";
                adminsp.InnerHtml = "";
            }
        }

        public void checkdangnhap()
        {
            User user = (User)Session["User"];

            //check đăng nhập
            if (user.Tentaikhoan != null)
            {
                btndangnhap.Text=user.Tentaikhoan.ToString();
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
                        Response.Redirect("TrangChu.aspx#product1");
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
                        Response.Redirect("TrangChu.aspx#product1");
                    }
                }
            }
            themvaogiohang.Value = "";
            prDetail.Value = "";
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