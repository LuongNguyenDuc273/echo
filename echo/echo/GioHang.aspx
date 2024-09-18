<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="GioHang.aspx.cs" Inherits="echo.echo.GioHang" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Echo shop</title>
    <link rel="stylesheet" href="Assets/style.css"></link>
    <link rel="stylesheet" href="Assets/responsive.css"></link>
    <link rel="shortcut icon" type="image/png" href="Assets/Icons/Echo Shop Logo.svg"></link>
    <link rel="stylesheet" href="https://unicons.iconscout.com/release/v4.0.8/css/line.css">
    <style>
        *{
            scroll-behavior: initial;
        }
    </style>
</head>
<body>
    <form id="formgiohang" name="formgiohang" method="post" runat="server">
        <input type="hidden" id="huysp" name="huysp" runat="server" />
        <input type="hidden" id="chinhsoluong" value="" name="chinhsoluong" runat="server" />
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
                        <li><a href="SanPham.aspx">Sản phẩm</a></li>
                        <li><a href="#my_footer">Về chúng tôi</a></li>
                        <li><a href="Blog.aspx">Blog</a></li>
                        <li><a href="#my_footer">Liên hệ</a></li>
                    </ul>
                </div>
    
                <div class="search">
                    <div class="search-bar">
                        <input id="search" name="search" placeholder="Tìm kiếm sản phẩm..." type="text">
                        <asp:Button ID="Buttonsearch" CssClass="bttnsearch" runat="server" Text="Tìm" OnClick="Buttonsearch_Click1" />                       
                    </div>
                </div>
    
                <div id="user">
                    <div class="avatar">
                        <%--<asp:Button ID="btndangnhap" CssClass="btndangnhap" runat="server" Text="Đăng nhập" OnClick="btndangnhap_Click" />--%>                       
                        <asp:Button ID="btndangnhap" CssClass="btndangnhap" runat="server" Text="Đăng nhập" OnClick="btndangnhap_Click" />
                    </div>
                    <div class="cart" onclick="location.href = 'GioHang.aspx';">
                        <a href="#"><i class="uil uil-shopping-bag"></i></a>
                    </div>
                </div>

            </section>
        </header>
        <!-- SP-HEADER -->
        <section id="sp-header">
            <div class="sp-text">
                <h1>GIẢM GIÁ ĐẾN 10%</h1>
                <p>Khi lần đầu mua hàng bằng thẻ MB Bank</p>
            </div>
        </section>
        <!-- DANH MỤC CART-->
        <section id="sp-category">
            <h1>LỊCH SỬ MUA HÀNG</h1>
            <div class="category-button">
                <button type="button" class="button-focus">
                    <p class="category-text">Giỏ hàng</p>
                </button>
                <button type="button" class="button" onclick="location.href='LichSuGiaoDich.aspx'">
                    <p class="category-text">Lịch sử mua hàng</p>
                </button>
            </div>
        </section>
        <!-- CART -->
        <section id="cart" class="section-p1" runat="server">
            <table>
                <thead>
                    <td>Hủy</td>
                    <td>Ảnh sản phẩm</td>
                    <td>Tên sản phẩm</td>
                    <td>Số lượng</td>
                    <td>Giá</td>
                    <td>Thành tiền</td>
                </thead>
                <%--<tbody>
                    <tr>
                        <td><button value="pr01" onclick="huysp_click(this.value)"><i class="uil uil-times-circle"></i></button></td>
                        <td><img src="Assets/Images/Keyboard/Seasalt keyboard.jpg" alt="anh-sp"></td>
                        <td>Bàn phím cơ Seasalt Minimalist</td>
                        <td><input type="number" value="1"></td>
                        <td>350,000 VNĐ</td>
                        <td></td>
                    </tr>
                </tbody>--%>
            </table>
        </section>
        <!-- TOTAL -->
        <section id="cart-add" class="section-p1">
            <div id="coupon">
                <h3>Mã giảm giá</h3>
                <div>
                    <input type="text" placeholder="Nhập mã giảm giá của bạn...">
                    <button class="normal">Áp dụng</button>
                </div>
            </div>

            <div id="total">
                <h3>Tổng tiền</h3>
                <table>
                    <tr>
                        <td>Tổng tiền hàng</td>
                        <td id="tongtienhang" name="tongtienhang" runat="server">0 VNĐ</td>
                    </tr>
                    <tr>
                        <td>Phí vận chuyển</td>
                        <td>Free</td>
                    </tr>
                    <tr>
                        <td>Mã giảm giá</td>
                        <td>Không có mã giảm giá</td>
                    </tr>
                    <tr>
                        <td><strong>Tổng thanh toán</strong></td>
                        <td><strong id="tongthanhtoan" name="tongthanhtoan" runat="server">0 VNĐ</strong></td>
                    </tr>
                </table>
                <asp:Button ID="bttnmua" CssClass="bttnmua" runat="server" Text="Mua hàng" OnClick="bttnmua_Click" />
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
        var sl = document.getElementById("soluong");
        var table = document.getElementById("cart");
        var inputsl = table.querySelectorAll("input");
        var csl = document.getElementById("chinhsoluong");
        var formgh = document.getElementById("formgiohang");
        function nhapsoluong(soluong) {
            if (parseInt(soluong) < 1) {
                sl.value = "1";               
            }    
            var sl1 = "";
            for (let i = 0; i < inputsl.length; i++) {
                if (i == 0) {
                    sl1 = inputsl[i].value;
                } else {
                    sl1 += "_" + inputsl[i].value;
                }
            }
            csl.value = sl1;
            console.log(sl1);
            formgh.submit();
        }

        var huysp = document.getElementById("huysp");
        function huysp_click(clicked_value) {
            huysp.value = clicked_value;
        }
        
    </script>
</html>
