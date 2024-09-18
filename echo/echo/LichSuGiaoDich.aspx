<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="LichSuGiaoDich.aspx.cs" Inherits="echo.echo.LichSuGiaoDich" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Echo Shop</title>
    <link rel="stylesheet" href="Assets/style.css"></link>
    <link rel="stylesheet" href="Assets/responsive.css"></link>
    <link rel="shortcut icon" type="image/png" href="Assets/Icons/Echo Shop Logo.svg"></link>
    <link rel="stylesheet" href="https://unicons.iconscout.com/release/v4.0.8/css/line.css">
</head>
<body>
    <form id="formlichsu" method="post" runat="server">
        <!-- HEADER -->
        <header>
            <!-- SMALL HEADER -->
            <section id="small-header">
                <p>Tận hưởng giao hàng miễn phí toàn quốc với hóa đơn từ 199.000 VNĐ</p>
            </section>
            <!-- MAIN HEADER -->
            <section id="main-header">
                <a href="index.html"><img src="Assets/Icons/Echo Shop Logo.svg" alt="anh-logo"></a>
    
                <div class="">
                    <ul id="navbar">
                        <li><a href="index.html">Trang chủ</a></li>
                        <li><a href="sp_keyboard.html">Sản phẩm</a></li>
                        <li><a href="#my_footer">Về chúng tôi</a></li>
                        <li><a href="Blog.aspx">Blog</a></li>
                        <li><a href="#my_footer">Liên hệ</a></li>
                    </ul>
                </div>
    
                <div class="search">
                    <div class="search-bar">
                        <input id="search" name="search" placeholder="Tìm kiếm sản phẩm..." type="text"/>
                        <asp:Button ID="Buttonsearch" CssClass="bttnsearch" runat="server" Text="Tìm" OnClick="Buttonsearch_Click" />
                    </div>
                </div>
    
                <div id="user">
                <div class="avatar">
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
                <button type="button" class="button" onclick="location.href='GioHang.aspx'">
                    <p class="category-text">Giỏ hàng</p>
                </button>
                <button type="button" class="button-focus">
                    <p class="category-text">Lịch sử mua hàng</p>
                </button>
            </div>
        </section>
        <!-- HISTORY -->
        <section id="cart" name="cart" class="section-p1" runat="server">
            <table>
                <thead>
                    <td>ảnh sản phẩm</td>
                    <td>tên sản phẩm</td>
                    <td>số lượng</td>
                    <td>giá</td>
                    <td>thành tiền</td>
                </thead>
                <%--<tbody>
                    <tr>
                        <td><img src="assets/images/keyboard/seasalt keyboard.jpg" alt="anh-sp"></td>
                        <td>bàn phím cơ seasalt minimalist</td>
                        <td><p>1</p></td>
                        <td>350,000 vnđ</td>
                        <td></td>
                    </tr>
                    <tr>
                        <td><img src="assets/images/keyboard/seasalt keyboard.jpg" alt="anh-sp"></td>
                        <td>bàn phím cơ seasalt minimalist</td>
                        <td><p>1</p></td>
                        <td>350,000 vnđ</td>
                        <td></td>
                    </tr>
                    <tr>
                        <td><img src="assets/images/keyboard/seasalt keyboard.jpg" alt="anh-sp"></td>
                        <td>bàn phím cơ seasalt minimalist</td>
                        <td><p>1</p></td>
                        <td>350,000 vnđ</td>
                        <td></td>
                    </tr>
                </tbody>--%>
            </table>
        </section>
        <!-- TOTAL-HISTORY -->
        <section id="his-total" class="section-p1">
            <p id="tongthanhtoan" name="tongthanhtoan" runat="server"></p>
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
</html>
