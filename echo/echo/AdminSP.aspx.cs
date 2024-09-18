using echo.Class;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace echo.echo
{
    public partial class AdminSP : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            checkdangnhap();

            Hiensp();
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
            string output = "<table>\r\n<thead>\r\n<td>ID</td>\r\n<td>Ảnh sản phẩm</td>\r\n<td>Tên sản phẩm</td>\r\n<td>Mô tả</td>\r\n<td>Loại sản phẩm</td>\r\n<td>Giá</td>\r\n<td>Sửa SP</td>\r\n</thead>\r\n<tbody>\r\n";
            List<string> list = new List<string>();

            foreach (Product pr in products)
            {
                output += "<tr>\r\n" +
                              "<td>"+pr.prId+"</td>\r\n" +
                              "<td><img src=\""+pr.imgLocation+"\" alt=\"anh-sp\"></td>\r\n" +
                              "<td>"+pr.prName+"</td>\r\n" +
                              "<td>"+pr.prDescribe+"</td>\r\n" +
                              "<td>#"+pr.prType+"</td>\r\n" +
                              "<td>"+formatgia(pr.prPrice.ToString())+" VNĐ</td>\r\n" +
                              "<td><button type=\"button\" value=\""+pr.imgLocation+"|"+ pr.prName +"|" + pr.prDescribe + "|" + pr.prType + "|" + pr.prPrice + "|" +pr.prId+"\" onclick=\"suasp(this.value)\">Chọn</button></td>\r\n</tr>\r\n";
            }
            output += "</table>";
            admincart.InnerHtml= output;           
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

        public bool Alertsp()
        {
            string tensp1 = Request.Form["tensp"];
            string motasp1 = Request.Form["motasp"];
            string loaisp1 = Request.Form["loaisp"];
            string giasp1 = Request.Form["giasp"];

            if(tensp1 == "")
            {
                alerttensp.InnerHtml = "Xin hãy điền tên sản phẩm!";
                alertmota.InnerHtml = "";
                alertloai.InnerHtml = "";
                alertgia.InnerHtml = "";
                tensp.Value= tensp1;
                motasp.Value= motasp1;
                loaisp.Value= loaisp1;
                giasp.Value= giasp1;
                return true;
            } else if(motasp1=="")
            {
                alerttensp.InnerHtml = "";
                alertmota.InnerHtml = "Xin hãy điều mô tả sản phẩm!";
                alertloai.InnerHtml = "";
                alertgia.InnerHtml = "";                
                tensp.Value = tensp1;
                motasp.Value = motasp1;
                loaisp.Value = loaisp1;
                giasp.Value = giasp1;
                return true;
            } else if(loaisp1 == "")
            {
                alerttensp.InnerHtml = "";
                alertmota.InnerHtml = "";
                alertloai.InnerHtml = "Xin hãy chọn lại loại sản phẩm!";
                alertgia.InnerHtml = "";
                tensp.Value = tensp1;
                motasp.Value = motasp1;
                loaisp.Value = loaisp1;
                giasp.Value = giasp1;
                return true;
            } else if(giasp1 == "")
            {
                alerttensp.InnerHtml = "";
                alertmota.InnerHtml = "";
                alertloai.InnerHtml = "";
                alertgia.InnerHtml = "xin hãy điền giá sản phẩm!";
                tensp.Value = tensp1;
                motasp.Value = motasp1;
                loaisp.Value = loaisp1;
                giasp.Value = giasp1;
                return true;
            } else return false;
        }

        public bool Alertsp2()
        {
            string tensp1 = Request.Form["tensp"];
            string motasp1 = Request.Form["motasp"];
            string loaisp1 = Request.Form["loaisp"];
            string giasp1 = Request.Form["giasp"];
            HttpPostedFile file = Request.Files["anhsp"];


            if (tensp1 == "")
            {
                alerttensp.InnerHtml = "Xin hãy điền tên sản phẩm!";
                alertmota.InnerHtml = "";
                alertloai.InnerHtml = "";
                alertgia.InnerHtml = "";
                tensp.Value = tensp1;
                motasp.Value = motasp1;
                loaisp.Value = loaisp1;
                giasp.Value = giasp1;
                return true;
            }
            else if (motasp1 == "")
            {
                alerttensp.InnerHtml = "";
                alertmota.InnerHtml = "Xin hãy điều mô tả sản phẩm!";
                alertloai.InnerHtml = "";
                alertgia.InnerHtml = "";
                tensp.Value = tensp1;
                motasp.Value = motasp1;
                loaisp.Value = loaisp1;
                giasp.Value = giasp1;
                return true;
            }
            else if (loaisp1 == "")
            {
                alerttensp.InnerHtml = "";
                alertmota.InnerHtml = "";
                alertloai.InnerHtml = "Xin hãy chọn lại loại sản phẩm!";
                alertgia.InnerHtml = "";
                tensp.Value = tensp1;
                motasp.Value = motasp1;
                loaisp.Value = loaisp1;
                giasp.Value = giasp1;
                return true;
            }
            else if (giasp1 == "")
            {
                alerttensp.InnerHtml = "";
                alertmota.InnerHtml = "";
                alertloai.InnerHtml = "";
                alertgia.InnerHtml = "xin hãy điền giá sản phẩm!";
                tensp.Value = tensp1;
                motasp.Value = motasp1;
                loaisp.Value = loaisp1;
                giasp.Value = giasp1;
                return true;
            } else if (file == null || file.FileName == "")
            {
                alertfile.InnerHtml = "Xin hãy chọn file ảnh!";
                alerttensp.InnerHtml = "";
                alertmota.InnerHtml = "";
                alertloai.InnerHtml = "";
                alertgia.InnerHtml = "";
                tensp.Value = tensp1;
                motasp.Value = motasp1;
                loaisp.Value = loaisp1;
                giasp.Value = giasp1;
                return true;
            }
            else return false;
        }

        protected void btnThem_Click(object sender, EventArgs e)
        {
            List<Product> products = (List<Product>)Application["DsProduct"];
            List<Product> newproducts = new List<Product>();
            Product newproduct = new Product();

            if (Alertsp2())
            {
                return;
            }
            else
            {
                string tensp1 = Request.Form["tensp"];
                string motasp1 = Request.Form["motasp"];
                string loaisp1 = Request.Form["loaisp"];
                string giasp1 = Request.Form["giasp"];
                HttpPostedFile file = Request.Files["anhsp"];

                newproduct.prId = "pr01";
                newproduct.prName = tensp1;
                newproduct.prDescribe=motasp1;
                newproduct.imgLocation= "Assets/Images/" + loaisp + "/" + file.FileName;
                newproduct.prType = loaisp1;
                newproduct.prPrice = Int32.Parse(giasp1);

                    file.SaveAs(Server.MapPath("Assets/Images/" + loaisp1 + "/" + file.FileName));
                    newproduct.imgLocation = "Assets/Images/" + loaisp1 + "/" + file.FileName;
                    //comment lại 2 dòng dưới này nếu muốn add xuống cuối và uncomment lại 2 dòng dưới nếu muốn add lên đầu
                    newproducts.Add(newproduct);
                    int i = 2;

                    //uncomment dòng này nếu muốn thêm xuống dưới cùng
                    //int i = 1;

                    foreach (Product pr in products)
                    {
                        if (i > 9)
                        {
                            pr.prId = "pr" + i.ToString();
                            newproducts.Add(pr);
                            i++;
                        }
                        else
                        {
                            pr.prId = "pr0" + i.ToString();
                            newproducts.Add(pr);
                            i++;
                        }
                    }

                    //comment lại  dòng dưới này nếu muốn add xuống đầu và uncomment lại dòng dưới nếu muốn add xuống cuối
                    //if(i> 9)
                    //{
                    //    newproduct.prId = "pr" + i;
                    //    newproducts.Add(newproduct);
                    //} 
                    //else
                    //{
                    //    newproduct.prId = "pr0" + i;
                    //    newproducts.Add(newproduct);
                    //}

                string output = "<table>\r\n<thead>\r\n<td>ID</td>\r\n<td>Ảnh sản phẩm</td>\r\n<td>Tên sản phẩm</td>\r\n<td>Mô tả</td>\r\n<td>Loại sản phẩm</td>\r\n<td>Giá</td>\r\n<td>Sửa SP</td>\r\n</thead>\r\n<tbody>\r\n";

                foreach (Product pr in newproducts)
                {
                    output += "<tr>\r\n" +
                                  "<td>" + pr.prId + "</td>\r\n" +
                                  "<td><img src=\"" + pr.imgLocation + "\" alt=\"anh-sp\"></td>\r\n" +
                                  "<td>" + pr.prName + "</td>\r\n" +
                                  "<td>" + pr.prDescribe + "</td>\r\n" +
                                  "<td>#" + pr.prType + "</td>\r\n" +
                                  "<td>" + formatgia(pr.prPrice.ToString()) + " VNĐ</td>\r\n" +
                                  "<td><button type=\"button\" value=\"" + pr.imgLocation + "|" + pr.prName + "|" + pr.prDescribe + "|" + pr.prType + "|" + pr.prPrice + "|" + pr.prId + "\" onclick=\"suasp(this.value)\">Chọn</button></td>\r\n</tr>\r\n";
                }
                output += "</table>";
                admincart.InnerHtml = output;
                Application["DsProduct"] = newproducts;
            }          

        }

        protected void btnSua_Click(object sender, EventArgs e)
        {
            List<Product> products = (List<Product>)Application["DsProduct"];
            List<Product> newproducts = new List<Product>();

            if (Alertsp())
            {
                return;
            } else
            {
                if (idsp.Value != "")
                {
                    string tensp = Request.Form["tensp"];
                    string motasp = Request.Form["motasp"];
                    string loaisp = Request.Form["loaisp"];
                    string giasp = Request.Form["giasp"];
                    HttpPostedFile file = Request.Files["anhsp"];

                    foreach (Product pr in products)
                    {
                        if (pr.prId == idsp.Value)
                        {
                            pr.prId = pr.prId;
                            pr.prName = tensp;
                            pr.prDescribe = motasp;
                            pr.prType = loaisp;
                            pr.prPrice = Int32.Parse(giasp);
                            if (file == null || file.FileName == "")
                            {
                                pr.imgLocation = pr.imgLocation;
                            }
                            else
                            {
                                file.SaveAs(Server.MapPath("Assets/Images/" + loaisp + "/" + file.FileName));
                                pr.imgLocation = "Assets/Images/" + loaisp + "/" + file.FileName;
                            }
                            newproducts.Add(pr);
                        }
                        else
                        {
                            newproducts.Add(pr);
                        }
                    }

                    Application["DsProduct"] = newproducts;
                }

                string output = "<table>\r\n<thead>\r\n<td>ID</td>\r\n<td>Ảnh sản phẩm</td>\r\n<td>Tên sản phẩm</td>\r\n<td>Mô tả</td>\r\n<td>Loại sản phẩm</td>\r\n<td>Giá</td>\r\n<td>Sửa SP</td>\r\n</thead>\r\n<tbody>\r\n";

                foreach (Product pr in newproducts)
                {
                    output += "<tr>\r\n" +
                                  "<td>" + pr.prId + "</td>\r\n" +
                                  "<td><img src=\"" + pr.imgLocation + "\" alt=\"anh-sp\"></td>\r\n" +
                                  "<td>" + pr.prName + "</td>\r\n" +
                                  "<td>" + pr.prDescribe + "</td>\r\n" +
                                  "<td>#" + pr.prType + "</td>\r\n" +
                                  "<td>" + formatgia(pr.prPrice.ToString()) + " VNĐ</td>\r\n" +
                                  "<td><button type=\"button\" value=\"" + pr.imgLocation + "|" + pr.prName + "|" + pr.prDescribe + "|" + pr.prType + "|" + pr.prPrice + "|" + pr.prId + "\" onclick=\"suasp(this.value)\">Chọn</button></td>\r\n</tr>\r\n";
                }
                output += "</table>";
                admincart.InnerHtml = output;
            }         
        }
    }
}