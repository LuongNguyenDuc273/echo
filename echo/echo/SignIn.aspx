<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SignIn.aspx.cs" Inherits="echo.echo.SignIn" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <link rel="stylesheet" href="Assets/Login_Register.css"></link>
    <link rel="shortcut icon" type="image/png" href="Assets/Icons/Echo Shop Logo.svg"></link>
    <link rel="stylesheet" href="https://unicons.iconscout.com/release/v4.0.8/css/line.css">
</head>
<body>
    <form id="formdangnhap" runat="server" class="form" method="post" onsubmit="return check()">
        <div class="form-title">
            <%--<a href="TrangChu.aspx"><i class="uil uil-arrow-left"></i></a>--%>
            <p><span style="color:#2664ff;">Echo shop</span> chào mừng bạn!</p>
        </div>

        <div class="input-container">
           <p class="input-title">Tên đăng nhập</p>
           <input type="text" id="txttaikhoan" name="txttaikhoan" value="" runat="server" placeholder="Nhập tên đăng nhập hoặc email">
            <div id="alertk" class="alert" name="alerttk" runat="server"></div>
           <span>
           </span>
        </div>

        <div class="input-container">
           <p class="input-title">Mật khẩu</p>
           <input type="password" id="txtmatkhau" name="txtmatkhau" placeholder="Nhập mật khẩu">
            <div id="alertmk" class="alert" name="alertmk" runat="server"></div>
        </div>

        <button type="submit" id="login">
         Đăng nhập
        </button>

        <p id="signup-link">
            Chưa có tài khoản?
            <a href="SignUp.aspx">Đăng ký ngay!</a>
        </p>
    </form>
</body>
<script>
    function check() {
        var taikhoan = document.getElementById("txttaikhoan");
        var matkhau = document.getElementById("txtmatkhau");
        var alttk = document.getElementById("alertk");
        var altmk = document.getElementById("alertmk");
        var err = 0;
        if (taikhoan.value == "") {
            alttk.innerHTML = "Bạn chưa nhập tên đăng nhập hoặc email!";
            taikhoan.focus();
        } else {
            alttk.innerHTML = "";
        }
        if (matkhau.value == "") {
            altmk.innerHTML = "Bạn chưa nhập mật khẩu!";
            matkhau.focus();
        } else {
            altmk.innerHTML = "";
        }
        if (taikhoan.value == ""||matkhau.value=="") {
            return false;
        }

    }
</script>
</html>
