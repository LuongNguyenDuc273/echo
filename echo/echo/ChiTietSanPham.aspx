<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ChiTietSanPham.aspx.cs" Inherits="echo.echo.ChiTietSanPham" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title></title>
    <link rel="stylesheet" href="Assets/style.css"></link>
    <link rel="stylesheet" href="Assets/responsive.css"></link>
    <link rel="shortcut icon" type="image/png" href="Assets/Icons/Echo Shop Logo.svg"></link>
    <link rel="stylesheet" href="https://unicons.iconscout.com/release/v4.0.8/css/line.css">
</head>
<body>
    <form id="formchitiet" name="formchitiet" runat="server" method="get">
        <input type="hidden" id="prDetail" name="prDetail" value="" runat="server"/>
        <input type="hidden" id="them1" name="themvaogiohang" value="" runat="server"/>
        <input type="hidden" id="themvaogiohang" name="themvaogiohang" value="" runat="server"/>
        <!-- HEADER -->
         <header>
            <!-- SMALL HEADER -->
            <section id="small-header">
                <p>Tận hưởng giao hàng miễn phí toàn quốc với hóa đơn từ 199.000 VNĐ</p>
            </section>
            <!-- MAIN HEADER -->
            <section id="main-header">
                <a href="TrangChu.aspx"><img src="Assets/Icons/Echo Shop Logo.svg" alt="anh-logo"></a>
    
                <div class="">
                    <ul id="navbar">
                        <li><a href="TrangChu.aspx">Trang chủ</a></li>
                        <li><a class="active" href="SanPham.aspx">Sản phẩm</a></li>
                        <li><a href="#my_footer">Về chúng tôi</a></li>
                        <li><a href="Blog.aspx">Blog</a></li>
                        <li><a href="#my_footer">Liên hệ</a></li>
                    </ul>
                </div>
    
                <div class="search">
                    <div class="search-bar">
                        <input id="search" name="search" placeholder="Tìm kiếm sản phẩm..." type="text">
                        <asp:Button ID="Buttonsearch" CssClass="bttnsearch" runat="server" Text="Tìm" OnClick="Buttonsearch_Click" />                     
                    </div>
                </div>

                <div id="user">
                    <div class="avatar">
                        <asp:Button ID="btndangnhap" CssClass="btndangnhap" runat="server" Text="Đăng nhập" OnClick="btndangnhap_Click" />                 
                        <%--<asp:Button ID="btndangnhap" CssClass="btndangnhap" runat="server" Text="Đăng nhập" OnClick="btndangnhap_Click" />--%>
                    </div>
                    <div class="cart" onclick="location.href = 'GioHang.aspx';">
                        <a href="#"><i class="uil uil-shopping-bag"></i></a>
                    </div>
                </div>


            </section>
         </header>
        <!-- CONTENT -->
        <section id="sp-detail" class="section-p1">
            <div class="single-pro-image">
                <p id="navigator" name="navigator" runat="server">Trang chủ -> Sản phẩm -> Keyboard</p>
                <img src="Assets/Images/Keyboard/Seasalt keyboard.jpg" id="MainImg" name="MainImg" alt="anh-keyboard" runat="server">
            </div>
            <div class="sp-info">
                <h4 id="tensp" name="tensp" runat="server">Bàn phím cơ Seasalt Minimalist</h4>
                <hr>
                <h2 id="giasp" name="giasp" runat="server">350,000 VNĐ</h2>
                <input type="number" id="soluong" name="soluong" value="1" onchange="nhapsoluong(this.value)" runat="server">              
                <button class="sp-button" onclick="button_click()">Thêm vào giỏ hàng</button>
                <h4>Giới thiệu sản phẩm</h4>
                <span id="motasp" name="motasp" runat="server">
                    The Gildan Ultra Contton T-shirt is made from a substantial 6.0 oz. per sq. yd. fabric constructed from 100% cotton, this classic
                    fit preshrunk jersey knit provides umathched  comfort with each wear. Featuring a taped neck and shounder, and a seamless double-needle 
                    collar, and available in a range of color, it offers it all in the unltimate head-turning package.
                </span>
                <span></span>
            </div>
        </section>

        <section id="sp-relative" class="section-p1">
            <h1>SẢN PHẨM LIÊN QUAN</h1>

            <div class="big-container">
                <div class="sp-box" id="sp01" onclick="sanpham_click(this.id)">
                    <input type="hidden" value="pr01"/>
                    <img src="Assets/Images/Keyboard/Simple keyboard.jpg" alt="anh-sp">
                    <div class="sp-content">
                        <span>#keyboard</span>
                        <h4>Bàn phím cơ Simple Minimalist</h4>
                        <h3>249,000 VNĐ</h3>
                    </div>
                    <button value="pr01" onclick="giohang_click(this.value)"><i class="uil uil-shopping-cart-alt cart"></i></button>
                </div>

                <div class="sp-box" id="sp02" onclick="sanpham_click(this.id)">
                    <input type="hidden" value="pr02"/>
                    <img src="Assets/Images/Keyboard/Seasalt keyboard.jpg" alt="anh-sp">
                    <div class="sp-content">
                        <span>#keyboard</span>
                        <h4>Bàn phím cơ Seasalt Minimalist</h4>
                        <h3>350,000 VNĐ</h3>
                    </div>
                    <button value="pr02" onclick="giohang_click(this.value)"><i class="uil uil-shopping-cart-alt cart"></i></button>
                </div>

                <div class="sp-box" id="sp03" onclick="sanpham_click(this.id)">
                    <input type="hidden" value="pr03"/>
                    <img src="Assets/Images/Keyboard/Pink keyboard.jpg" alt="anh-sp">
                    <div class="sp-content">
                        <span>#keyboard</span>
                        <h4>Bàn phím cơ Pink Minimalist</h4>
                        <h3>350,000 VNĐ</h3>
                    </div>
                    <button value="pr03" onclick="giohang_click(this.value)"><i class="uil uil-shopping-cart-alt cart"></i></button>
                </div>
            
                <div class="sp-box" id="sp04" onclick="sanpham_click(this.id)">
                    <input type="hidden" value="pr04"/>
                    <img src="Assets/Images/Keyboard/Gundam keyboard.jpg" alt="anh-sp">
                    <div class="sp-content">
                        <span>#keyboard</span>
                        <h4>Bàn phím cơ Gundam Custom</h4>
                        <h3>249,000 VNĐ</h3>
                    </div>
                        <button value="pr04" onclick="giohang_click(this.value)"><i class="uil uil-shopping-cart-alt cart"></i></button>
                    </div>

            </div>
        </section>

        <!-- FOOTER -->
        <footer id="my_footer" class="section-p1">
            <div class="col">
                <img class="logo" src="Assets/Icons/Echo Shop Logo.svg" alt="">
                <h4>@2024 Công ty TNHH Echo Shop</h4>
                <p>
                    Amet minim mollit non deserunt 
                    ullamco est sit aliqua dolor do 
                    amet sint. Velit officia consequat 
                    duis enim velit mollit.
                </p>
                <div class="follow">
                    <div class="icon">
                        <i class="uil uil-instagram ig"></i>
                        <i class="uil uil-linkedin ld"></i>
                        <i class="uil uil-facebook-f fb"></i>
                        <i class="uil uil-youtube yt"></i>
                    </div>
                </div>
            </div>

            <div class="col link">
                <h4>Đường dẫn</h4>
                <a href="#">Trang chủ</a>
                <a href="#">Sản phẩm</a>
                <a href="#">Về chúng tôi</a>
                <a href="#">Blog</a>
                <a href="#">Liên hệ</a>
            </div>

            <div class="col contact">
                <h4>Thông tin liên hệ</h4>
                <a href="#">+84 77 6461 724</a>
                <a href="#">
                    Số 99 phố Định Công Hạ, Quận Hoàng Mai,</br>Tp Hà Nội
                </a>
                <a href="#">echoshop@gmail.com</a>
            </div>

            <div class="col install">
                <h4>Install App</h4>
                <p>From Appstore & Google Play</p>
                <div class="row">
                    <img src="Assets/Images/Footer/Appstore.png" alt="">
                    <img src="Assets/Images/Footer/Google Play.png" alt="">
                </div>
                <p>Secured Payment Gateways</p>
                <img src="Assets/Images/Footer/Payment Gateway.png" alt="">
            </div>

            <div class="copyright">
                <p>2024 BTL LTW Nhóm số 12</p>
            </div>
        </footer>
    </form>
</body>
    <script>
        var sanpham = document.getElementById("prDetail");
        var formtc = document.getElementById("formchitiet");
        var giohang = document.getElementById("themvaogiohang");
        var sl = document.getElementById("soluong");
        var addvaogiohang = document.getElementById("them1");
        function nhapsoluong(soluong) {
            if (parseInt(soluong) <= 0) {
                sl.value = "1";
            }
        }

        function button_click() {
            addvaogiohang.value = "1";
        }     

        function sanpham_click(clicked_id) {
            var div = document.getElementById(clicked_id);
            var val = div.querySelector("input").value;
            location.href = "ChiTietSanPham.aspx?sp=" + val;
        }

        function giohang_click(click_value) {
            event.cancelBubble = true;
            if (event.stopPropagation) event.stopPropagation();
            giohang.value = "1";
            alert("Bạn đã thêm một sản phẩm!");
            sanpham.value = click_value;
        }
    </script>
</html>
