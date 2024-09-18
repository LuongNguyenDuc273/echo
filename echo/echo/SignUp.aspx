<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SignUp.aspx.cs" Inherits="echo.echo.SignUp" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Đăng ký</title>
    <link rel="stylesheet" href="Assets/Login_Register.css"></link>
    <link rel="shortcut icon" type="image/png" href="Assets/Icons/Echo Shop Logo.svg"></link>
    <link rel="stylesheet" href="https://unicons.iconscout.com/release/v4.0.8/css/line.css">
</head>
<body>
    <form id="formdangky" runat="server" class="form" method="post" onsubmit="return check()">
        <div class="form-title">
            <%--<a href="SignIn.aspx"><i class="uil uil-arrow-left"></i></a>--%>
            <p><span style="color:#2664ff;">Đăng ký</span> tài khoản!</p>
        </div>

        <div class="input-container">
           <p class="input-title">Tên đăng nhập</p>
           <input type="text" placeholder="Nhập tên đăng nhập" id="txttaikhoan" name="txttaikhoan" value="" runat="server"/>
            <div id="alerttaikhoan" name="alerttaikhoan" runat="server" class="alert"></div>
           <span>
           </span>
        </div>

        <div class="input-container">
           <p class="input-title">Email</p>
           <input type="email" placeholder="Nhập email" id="txtgmail" name="txtgmail" value="" runat="server"/>
            <div id="alertgmail" name="alertgmail" runat="server" class="alert"></div>
        </div>

        <div class="input-container">
            <p class="input-title">Số điện thoại</p>
            <input type="tel" placeholder="Nhập số điện thoại" id="sdt" name="sdt" value="" pattern="[0-9]{4} [0-9]{3} [0-9]{3}" maxlength="10" title="Ten digits code" onchange="this.value=formatsdt(this.value);" runat="server"/>
            <div id="alertnumber" name="alertnumber" runat="server" class="alert"></div>
        </div>

        <div class="input-container">
            <p class="input-title">Mật khẩu</p>
            <input type="password" placeholder="Nhập mật khẩu" id="txtmatkhau" name="txtmatkhau" value="" runat="server"/>
            <div id="alertmatkhau" name="alertmatkhau" runat="server" class="alert"></div>
        </div>

        <div class="input-container">
            <p class="input-title">Xác nhận mật khẩu</p>
            <input type="password" placeholder="Nhập mật khẩu" id="txtrmatkhau" name="txtrmatkhau" value="" runat="server"/>
            <div id="alertrmatkhau" name="alertrmatkhau" runat="server" class="alert"></div>
        </div>

        <div class="input-container">
            <p class="input-title">Địa chỉ</p>
            <input type="text" placeholder="Nhập địa chủ" id="txtdiachi" name="txtdiachi" value="" runat="server"/>
            <div id="alertdiachi" name="alertdiachi" runat="server" class="alert"></div>
        </div>

        <%--<div class="input-container">
            <p class="input-title">cccd</p>
            <input type="text" placeholder="Nhập cccd" id="txtcccd" name="txtcccd" value="" runat="server"/>
            <div id="alertcccd" name="alertcccd" runat="server" class="alert"></div>
        </div>--%>

        <button type="submit" id="register">
            Đăng ký
        </button>

        <p id="signin-link">
            Đã có tài khoản?
            <a href="SignIn.aspx">Đăng nhập ngay!</a>
        </p>
    </form>
</body>
    <script>
        function formatsdt(format) {
            var sdt = "";
            sdt = format.slice(0, 4) + " " + format.slice(4, 7) + " " + format.slice(7, 10);
            return sdt;
        }

        function check() {
            //var cccd = document.getElementById("txtcccd");
            var gmail = document.getElementById("txtgmail");
            var pnumber = document.getElementById("sdt");
            var taikhoan = document.getElementById("txttaikhoan");
            var matkhau = document.getElementById("txtmatkhau");
            var rmatkhau = document.getElementById("txtrmatkhau");
            var diachi = document.getElementById("txtdiachi");

            //var alcccd = document.getElementById("alertcccd");
            var algmail = document.getElementById("alertgmail");
            var alnumber = document.getElementById("alertnumber");
            var altaikhoan = document.getElementById("alerttaikhoan");
            var almatkhau = document.getElementById("alertmatkhau");
            var alrmatkhau = document.getElementById("alertrmatkhau");
            var aldiachi = document.getElementById("alertdiachi");

            var err = 1;
            if (gmail.value == "") {
                algmail.innerHTML = "Hãy điền thông tin gmail!"
                gmail.focus();
                err = 0;
            }
            else {
                algmail.innerHTML = "";
            }

            if (pnumber.value == "") {
                alnumber.innerHTML = "Hãy điền thông tin số điện thoại!"
                pnumber.focus();
                err = 0;
            }
            else if (pnumber.value.length != 12 && isNaN(pnumber.value)) {
                alnumber.innerHTML = "Số điện thoại không hợp lệ xin hãy điền lại";
                pnumber.focus();
                err = 0;
            }
            else {
                alnumber.innerHTML = "";
            }

            if (taikhoan.value == "") {
                altaikhoan.innerHTML = "Hãy điền tên tài khoản!";
                taikhoan.focus();
                err = 0;
            }
            else {
                altaikhoan.innerHTML = "";
            }

            if (matkhau.value == "") {
                almatkhau.innerHTML = "Hãy điền mật khẩu!";
                matkhau.focus();
                err = 0;
            }
            else {
                almatkhau.innerHTML = "";
            }

            if (rmatkhau.value == "" || matkhau.value!=rmatkhau.value) {
                alrmatkhau.innerHTML = "hãy điền lại mật khẩu!";
                rmatkhau.focus();
                err = 0;
            }
            else {
                alrmatkhau.innerHTML = "";
            }

            if (diachi.value == "") {
                aldiachi.innerHTML = "Hãy điền địa chỉ!";
                diachi.focus();
                err = 0;
            }
            else {
                aldiachi.innerHTML = "";
            }
            //alert((cccd.value)[0]);
            //(cccd.value)[0] lấy giá trị của phần tử đầu tiên nếu trong trường hợp muốn bắt cccd có giá trị = 0
            //aler((cccd.value).length)
            //(cccd.value).length lấy số lượng kí tự có trong cccd
            //if (cccd.value == "" ) {
            //    alcccd.innerHTML = "Điền cccd cho con mẹ mày đi";
            //    cccd.focus();
            //    err = 0;
            //}
            //else {
            //    alcccd.innerHTML = "";
            //}

            if (err == 0) {
                return false;
            }
        }
    </script>
</html>
