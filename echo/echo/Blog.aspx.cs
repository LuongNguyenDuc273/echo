using echo.Class;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace echo.echo
{
    public partial class Blog : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            checkdangnhap();
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