<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AdminSP.aspx.cs" Inherits="echo.echo.AdminSP" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Echo Shop</title>
    <link rel="stylesheet" href="Assets/Admin.css"></link>
    <link rel="stylesheet" href="Assets/responsive.css"></link>
    <link rel="shortcut icon" type="image/png" href="Assets/Icons/Echo Shop Logo.svg"></link>
    <link rel="stylesheet" href="https://unicons.iconscout.com/release/v4.0.8/css/line.css"></link>
</head>
<form id="formadmin" name="formadmin" method="post" enctype="multipart/form-data" runat="server">
    <input type="hidden" id="imglocation" name="imglocation" value="" runat="server" />
    <input type="hidden" id="idsp" name="idsp" value="" runat="server" />
    <body>
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
                        <li><a href="#my-footer">Về chúng tôi</a></li>
                        <li><a href="Blog.aspx">Blog</a></li>
                        <li><a href="#my-footer">Liên hệ</a></li>
                    </ul>
                </div>
    
                <div class="search">
                    <div class="search-bar">
                        <input placeholder="Tìm kiếm sản phẩm..." type="text">
                        <button type="submit">Tìm</button>
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
        <!-- ADMIN ADD-->
        <section id="admin-input">
            <div class="input-img">
                <h4>Ảnh sp</h4>
                <input type="file" id="anhsp" name="anhsp">
                <div id="alertfile" name="alertfile" class="alert" runat="server"></div>
            </div>
            <div class="input-box">
                <h4>Tên sp</h4>
                <input type="text" id="tensp" name="tensp" value="" runat="server">
                <div id="alerttensp" name="alerttensp" class="alert" runat="server"></div>
            </div>
            <div class="input-box">
                <h4>Mô tả</h4>
                <textarea id="motasp" name="motasp" runat="server"></textarea>
                <div id="alertmota" name="alertmota" class="alert" runat="server"></div>
            </div>
            <div class="input-box">
                <h4>Loại sp</h4>
                <select value="Keyboard" id="loaisp" name="loaisp" runat="server">
                    <option  value="Keyboard">Keyboard</option>
                    <option  value="Mouse">Mouse</option>
                    <option  value="Other">Other</option>
                </select>
                <div id="alertloai" name="alertloai" class="alert" runat="server"></div>
            </div>            
            <div class="input-box">
                <h4>Giá</h4>
                <input type="number" id="giasp" name="giasp" runat="server">
                <div id="alertgia" name="alertgia" class="alert" runat="server"></div>
            </div>
        </section>                      
        <!--ADMIN OPTION-->
        <section id="admin-option">
            <h1>CHỈNH SỬA SP</h1>
            <div class="admin-button">
                    <asp:Button ID="btnThem" name="btnThem" CssClass="adminbttn" runat="server" Text="Thêm" OnClick="btnThem_Click" />
                    <asp:Button ID="btnSua" CssClass="adminbttn" name="btnSua" runat="server" Text="Sửa" OnClick="btnSua_Click" />
            </div>
        </section>
        <!-- ADMIN SAN PHAM -->
        <section id="admincart" name="admincart" runat="server">
            <%--<table>
                <%--<thead>
                    <td>ID</td>
                    <td>Ảnh sản phẩm</td>
                    <td>Tên sản phẩm</td>
                    <td>Mô tả</td>
                    <td>Loại sản phẩm</td>
                    <td>Giá</td>
                    <td>Sửa SP</td>
                </thead>
                <tbody>
                    <tr>
                        <td>PR01</td>
                        <td><img src="Assets/Images/Keyboard/Seasalt keyboard.jpg" alt="anh-sp"></td>
                        <td>Bàn phím cơ Seasalt Minimalist</td>
                        <td>Đây là bàn phím cơ trải nghiệm gõ phím mượt mà</td>
                        <td>#keyboard</td>
                        <td>350,000 VNĐ</td>
                        <td><button type="button">Sửa</button></td>
                    </tr>
                </tbody>
            </table>--%>
        </section>
        <!-- FOOTER -->
        <footer id="my-footer" class="section-p1">
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
        var loaisp = document.getElementById("loaisp");
        var imglocation = document.getElementById("imglocation");
        var spid = document.getElementById("idsp");
        var anhsp = document.getElementById("anhsp");
        var tensp = document.getElementById("tensp");
        var motasp = document.getElementById("motasp");
        var loaisp = document.getElementById("loaisp");
        var giasp = document.getElementById("giasp");



        function suasp(clicked_value){
            var sp = clicked_value.split("|");
            imglocation.value = sp[0];
            tensp.value = sp[1];
            motasp.value = sp[2];
            loaisp.value = sp[3];
            giasp.value = parseInt(sp[4]);
            spid.value = sp[5];
            location.href = "#admin-input";
        }
    </script>
</html>
