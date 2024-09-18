<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="TrangChu.aspx.cs" Inherits="echo.echo.TrangChu.TrangChu" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head >
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Echo Shop</title>
    <link rel="stylesheet" href="Assets/style.css"></link>
    <link rel="stylesheet" href="Assets/responsive.css"></link>
    <link rel="shortcut icon" type="image/png" href="Assets/Icons/Echo Shop Logo.svg"></link>
    <link rel="stylesheet" href="https://unicons.iconscout.com/release/v4.0.8/css/line.css">
</head>
<body>
    <form id="formtrangchu" runat="server" method="get">
        <input type="hidden" id="prDetail" name="prDetail" value="" runat="server"/>
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
                        <li><a class="active" href="TrangChu.aspx">Trang chủ</a></li>
                        <li><a href="SanPham.aspx">Sản phẩm</a></li>
                        <li><a href="#my_footer">Về chúng tôi</a></li>
                        <li><a href="Blog.aspx">Blog</a></li>                       
                        <li><a href="#my_footer">Liên hệ</a></li>
                        <li><a href="AdminSP.aspx" id="adminsp" name="adminsp" runat="server"></a></li>       
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
                        <%--<a href="#" id="dangnhapname" name="dangnhapname" runat="server" onclick="dangnhap_click()">Đăng nhập</a>--%>
                    </div>
                    <div class="cart" onclick="location.href = 'GioHang.aspx';">
                        <a href="#"><i class="uil uil-shopping-bag"></i></a>
                    </div>
                </div>
            </section>
         </header>
        <!-- SLIDER -->
        <section id="slider">
            <div class="slider-btn">
                <a href="#"><button>Mua ngay</button></a>
            </div>
        </section>
        <!-- NEW ARRIVALS -->
        <section id="product1" class="section-p1">
            <%--<h1 id="solandn" name="solandn" runat="server"></h1>--%>
            <%--<h1 id="tongsotien" name="tongsotien" runat="server"></h1>--%>
            <h1>HÀNG MỚI CHÀO HÈ</h1>
            <p>BST Mùa hè hiện đại, clean, simple & modern</p>

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

                <div class="sp-box" id="sp05" onclick="sanpham_click(this.id)">
                    <input type="hidden" value="pr05"/>
                    <img src="Assets/Images/Keyboard/Bauhaus keyboard.jpg" alt="anh-sp">
                    <div class="sp-content">
                        <span>#keyboard</span>
                        <h4>Bàn phím cơ Bauhaus Akolabs</h4>
                        <h3>848,000 VNĐ</h3>
                    </div>
                    <button value="pr05" onclick="giohang_click(this.value)"><i class="uil uil-shopping-cart-alt cart"></i></button>
                </div>

                <div class="sp-box" id="sp06" onclick="sanpham_click(this.id)">
                    <input type="hidden" value="pr06"/>
                    <img src="Assets/Images/Keyboard/Athena keyboard.jpg" alt="anh-sp">
                    <div class="sp-content">
                        <span>#keyboard</span>
                        <h4>Bàn phím cơ Athena Custom</h4>
                        <h3>684,000 VNĐ</h3>
                    </div>
                    <button value="pr06" onclick="giohang_click(this.value)"><i class="uil uil-shopping-cart-alt cart"></i></button>
                </div>

                <div class="sp-box" id="sp07" onclick="sanpham_click(this.id)">
                    <input type="hidden" value="pr07"/>
                    <img src="Assets/Images/Keyboard/Warm_Tenkai keyboard.jpg" alt="anh-sp" height="100%">
                    <div class="sp-content">
                        <span>#keyboard</span>
                        <h4>Bàn phím cơ Warm Tenkai Custom</h4>
                        <h3>684,000 VNĐ</h3>
                    </div>
                    <button value="pr07" onclick="giohang_click(this.value)"><i class="uil uil-shopping-cart-alt cart"></i></button>
                </div>

                <div class="sp-box" id="sp08" onclick="sanpham_click(this.id)">
                    <input type="hidden" value="pr08"/>
                    <img src="Assets/Images/Keyboard/Code_Geass keyboard.jpg" alt="anh-sp" height="100%">
                    <div class="sp-content">
                        <span>#keyboard</span>
                        <h4>Bàn phím cơ Code Geass Custom</h4>
                        <h3>960,000 VNĐ</h3>
                    </div>
                    <button value="pr08" onclick="giohang_click(this.value)"><i class="uil uil-shopping-cart-alt cart"></i></button>
                </div>

            </div>
        </section>
        <!-- BANNER -->
        <section id="sm-banner" class="section-p1">
            <div class="banner-box">
                <h4>Lần đầu mua hàng bằng thẻ MB Bank</h4>
                <h1>GIẢM GIÁ ĐẾN 10%</h1>
                <button class="white">Tìm hiểu ngay</button>
            </div>
        </section>
        <!-- BEST SELLER -->
        <section id="product1" class="section-p1">
            <h1>SẢN PHẨM NỔI BẬT</h1>
            <p>Best Seller tại Echo Shop</p>

            <div class="big-container">

                <div class="sp-box">
                    <input type="hidden" value="pr01"/>
                    <img src="Assets/Images/Keyboard/Simple keyboard.jpg" alt="anh-sp">
                    <div class="sp-content" id="sp09" onclick="sanpham_click(this.id)">
                        <span>#keyboard</span>
                        <h4>Bàn phím cơ Simple Minimalist</h4>
                        <h3>249,000 VNĐ</h3>
                    </div>
                    <button value="pr01" onclick="giohang_click(this.value)"><i class="uil uil-shopping-cart-alt cart"></i></button>
                </div>

                <div class="sp-box" id="sp10" onclick="sanpham_click(this.id)">
                    <input type="hidden" value="pr02"/>
                    <img src="Assets/Images/Keyboard/Seasalt keyboard.jpg" alt="anh-sp">
                    <div class="sp-content">
                        <span>#keyboard</span>
                        <h4>Bàn phím cơ Seasalt Minimalist</h4>
                        <h3>350,000 VNĐ</h3>
                    </div>
                    <button value="pr02" onclick="giohang_click(this.value)"><i class="uil uil-shopping-cart-alt cart"></i></button>
                </div>

                <div class="sp-box" id="sp11" onclick="sanpham_click(this.id)">
                    <input type="hidden" value="pr03"/>
                    <img src="Assets/Images/Keyboard/Pink keyboard.jpg" alt="anh-sp">
                    <div class="sp-content">
                        <span>#keyboard</span>
                        <h4>Bàn phím cơ Pink Minimalist</h4>
                        <h3>350,000 VNĐ</h3>
                    </div>
                    <button value="pr03" onclick="giohang_click(this.value)"><i class="uil uil-shopping-cart-alt cart"></i></button>
                </div>
            
                <div class="sp-box" id="sp12" onclick="sanpham_click(this.id)">
                    <input type="hidden" value="pr04"/>
                    <img src="Assets/Images/Keyboard/Gundam keyboard.jpg" alt="anh-sp">
                    <div class="sp-content">
                        <span>#keyboard</span>
                        <h4>Bàn phím cơ Gundam Custom</h4>
                        <h3>249,000 VNĐ</h3>
                    </div>
                    <button value="pr04" onclick="giohang_click(this.value)"><i class="uil uil-shopping-cart-alt cart"></i></button>
                </div>

                <div class="sp-box" id="sp13" onclick="sanpham_click(this.id)">
                    <input type="hidden" value="pr05"/>
                    <img src="Assets/Images/Keyboard/Bauhaus keyboard.jpg" alt="anh-sp">
                    <div class="sp-content">
                        <span>#keyboard</span>
                        <h4>Bàn phím cơ Bauhaus Akolabs</h4>
                        <h3>848,000 VNĐ</h3>
                    </div>
                    <button value="pr05" onclick="giohang_click(this.value)"><i class="uil uil-shopping-cart-alt cart"></i></button>
                </div>

                <div class="sp-box" id="sp14" onclick="sanpham_click(this.id)">
                    <input type="hidden" value="pr06"/>
                    <img src="Assets/Images/Keyboard/Athena keyboard.jpg" alt="anh-sp">
                    <div class="sp-content">
                        <span>#keyboard</span>
                        <h4>Bàn phím cơ Athena Custom</h4>
                        <h3>684,000 VNĐ</h3>
                    </div>
                    <button value="pr06" onclick="giohang_click(this.value)"><i class="uil uil-shopping-cart-alt cart"></i></button>
                </div>

                <div class="sp-box" id="sp15" onclick="sanpham_click(this.id)">
                    <input type="hidden" value="pr07"/>
                    <img src="Assets/Images/Keyboard/Warm_Tenkai keyboard.jpg" alt="anh-sp" height="100%">
                    <div class="sp-content">
                        <span>#keyboard</span>
                        <h4>Bàn phím cơ Warm Tenkai Custom</h4>
                        <h3>684,000 VNĐ</h3>
                    </div>
                    <button value="pr07" onclick="giohang_click(this.value)"><i class="uil uil-shopping-cart-alt cart"></i></button>
                </div>

                <div class="sp-box" id="sp16" onclick="sanpham_click(this.id)">
                    <input type="hidden" value="pr08"/>
                    <img src="Assets/Images/Keyboard/Code_Geass keyboard.jpg" alt="anh-sp" height="100%">
                    <div class="sp-content">
                        <span>#keyboard</span>
                        <h4>Bàn phím cơ Code Geass Custom</h4>
                        <h3>960,000 VNĐ</h3>
                    </div>
                    <button value="pr08" onclick="giohang_click(this.value)"><i class="uil uil-shopping-cart-alt cart"></i></button>
                </div>

            </div>
        </section>
        <!-- SERVICE -->
        <section id="service" class="section-p1">
            <h1>CÁC DỊCH VỤ GIÚP BẠN MUA SẮM</h1>

            <div class="big-container">
                <div class="sp-box freeship">
                    <div class="sp-content">
                        <h3>Free Shipping</h3>
                        <p>Miễn phí giao hàng cho các hóa đơn từ 99.000đ</p>
                    </div>
                    <a href="#"><i class="uil uil-truck service-icon"></i></a>
                </div>

                <div class="sp-box online-sp">
                    <div class="sp-content">
                        <h3>ONLINE SUPPORT 24/7</h3>
                        <p>Miễn phí giao hàng cho các hóa đơn từ 99.000đ</p>
                    </div>
                    <a href="#"><i class="uil uil-headphones service-icon"></i></a>
                </div>

                <div class="sp-box payment">
                    <div class="sp-content">
                        <h3>ACCPEPT PAYMENT</h3>
                        <p>Miễn phí giao hàng cho các hóa đơn từ 99.000đ</p>
                    </div>
                    <a href="#"><i class="uil uil-master-card service-icon"></i></a>
                </div>
            </div>
        </section>
        <!-- EMAIL-REGISTER -->
        <section id="email-register" class="section-p1 section-m1">
            <div class="newstext">
                <p>Đăng ký ngay email của bạn để luôn được cập nhật tin tức, và</p>
                <h2>NHẬN TIN KHUYẾN MÃI</h2>
            </div>
            <div class="email-form">
                <input type="text" placeholder="Email của bạn ..." name="" id="">
                <button class="normal">Đăng ký</button>
            </div>
        </section>
        <!-- BLOG -->
        <section id="product1" class="section-p1">
            <h1>BLOG CÔNG NGHỆ</h1>
            <p>Cập nhật những thông tin mới nhất về các sản phẩm, blog hướng dẫn, review sản phẩm, ...</p>

            <div class="blog-container">
                <div class="blog-box">
                    <img src="Assets/Images/Blog/Blog 1.jpg" alt="anh-sp">
                    <div class="blog-content">
                        <span>03/04/2024</span>
                        <h4>Cùng Echo Shop tìm hiểu về bố cục và form của bàn phím cơ </h4>
                        <p>
                            Bàn phím cơ không hẳn là một khái niệm mới, những để hiểu rõ về bố cục và form của nó, ...
                        </p>
                    </div>
                </div>

                <div class="blog-box">
                    <img src="Assets/Images/Blog/Blog 2.jpg" alt="anh-sp">
                    <div class="blog-content">
                        <span>03/04/2024</span>
                        <h4>Cùng Echo Shop tìm hiểu về bố cục và form của bàn phím cơ </h4>
                        <p>
                            Bàn phím cơ không hẳn là một khái niệm mới, những để hiểu rõ về bố cục và form của nó, ...
                        </p>
                    </div>
                </div>

                <div class="blog-box">
                    <img src="Assets/Images/Blog/Blog 3.jpg" alt="anh-sp">
                    <div class="blog-content">
                        <span>03/04/2024</span>
                        <h4>Cùng Echo Shop tìm hiểu về bố cục và form của bàn phím cơ </h4>
                        <p>
                            Bàn phím cơ không hẳn là một khái niệm mới, những để hiểu rõ về bố cục và form của nó, ...
                        </p>
                    </div>
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
        var dangnhap = document.getElementById("dangnhapname");
        var dangxuat = document.getElementById("dangxuat");
        var sanpham = document.getElementById("prDetail");
        var formtc = document.getElementById("formtrangchu");
        var giohang = document.getElementById("themvaogiohang");

        function sanpham_click(clicked_id) {
            var div = document.getElementById(clicked_id);
            var val = div.querySelector("input").value;
            location.href = "ChiTietSanPham.aspx?sp="+val;
        }

        function giohang_click(click_value) {
            event.cancelBubble = true;
            if (event.stopPropagation) event.stopPropagation();
            alert("Bạn đã thêm một sản phẩm!");
            giohang.value = "1";
            sanpham.value = click_value;
        }
    </script>
</html>
