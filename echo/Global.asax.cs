using echo.Class;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.SessionState;

namespace echo
{
    public class Global : System.Web.HttpApplication
    {

        protected void Application_Start(object sender, EventArgs e)
        {
            //Application người dùng
            Application["DsUser"] = new List<User>();
            List<User> users = (List<User>)Application["DsUser"];
            

            User u1 = new User();
            u1.Ugmail = "luong@gmail.com";
            u1.Sdt = "0393777111";
            u1.Tentaikhoan = "luong";
            u1.Matkhau = "1234";
            u1.Diachi = "Hà Nội";
            users.Add(u1);

            User u2 = new User();
            u2.Ugmail = "tuong@gmail.com";
            u2.Sdt = "0393777111";
            u2.Tentaikhoan = "tuong";
            u2.Matkhau = "1234";
            u2.Diachi = "Hà Nội";
            users.Add(u2);

            User u3 = new User();
            u3.Ugmail = "linh@gmail.com";
            u3.Sdt = "0393777111";
            u3.Tentaikhoan = "linh";
            u3.Matkhau = "1234";
            u3.Diachi = "Hà Nội";
            users.Add(u3);

            User u4 = new User();
            u4.Ugmail = "admin@gmail.com";
            u4.Sdt = "0393777111";
            u4.Tentaikhoan = "admin";
            u4.Matkhau = "1234";
            u4.Diachi = "Hà Nội";
            users.Add(u4);


            Application["DsUser"]= users;

            //Application sản phẩm
            Application["DsProduct"] = new List<Product>();
            List<Product> products = (List<Product>)Application["DsProduct"];
            //keyboard
            Product p1 = new Product();
            p1.prId = "pr01";
            p1.prName = "Bàn phím cơ Simple Minimalist";
            p1.prPrice = 450000;
            p1.prDescribe = "Bàn phím cơ Simple Minimalist được thiết kế với phong cách tối giản nhưng vô cùng tinh tế với các đường nét thẳng. Với chất liệu và mềm, bền đẹp, chất lượng in sắc nét, dày dặn, chiếc deskmat này vừa có thể trở thành điểm nhấn trên chiếc bàn làm việc của bạn, vừa bảo vệ chiếc bàn phím của bạn khỏi va đập và tăng thêm trải nghiệm khi gõ và làm việc.";
            p1.imgLocation = "Assets/Images/Keyboard/Simple keyboard.jpg";
            p1.prType = "Keyboard";
            products.Add(p1);

            Product p2 = new Product();
            p2.prId = "pr02";
            p2.prName = "Bàn phím cơ Seasalt Minimalist";
            p2.prPrice = 3000000;
            p2.prDescribe = "Bàn phím cơ Seasalt Minimalist được trang bị phần khung hoàn thiện bằng kim loại mang đến cảm giác chắc chắn.";
            p2.imgLocation = "Assets/Images/Keyboard/Seasalt keyboard.jpg";
            p2.prType = "Keyboard";
            products.Add(p2);

            Product p3 = new Product();
            p3.prId = "pr03";
            p3.prName = "Bàn phím cơ Pink Minimalist";
            p3.prPrice = 700000;
            p3.prDescribe = "Bàn phím cơ Pink Minimalist đặc biệt đẹp với bộ keycap ABS DoubleShot thế hệ mới với màu hồng phấn và độ hoàn thiện cao, font chữ trên keycap rất đẹp và liền mạch, tốt hơn hẳn so với các loại phím cơ khác.";
            p3.imgLocation = "Assets/Images/Keyboard/Pink keyboard.jpg";
            p3.prType = "Keyboard";
            products.Add(p3);

            Product p4 = new Product();
            p4.prId = "pr04";
            p4.prName = "Bàn phím cơ Gundam Custom";
            p4.prPrice = 450000;
            p4.prDescribe = "Bàn phím cơ Gundam Custom là bàn phím cơ chơi game hiệu suất cao với kích thước nhỏ, giải phóng không gian trên mặt bàn làm việc của bạn để di chuyển chuột rộng hơn - hoàn hảo cho các cài đặt độ nhạy thấp hơn giúp làm chậm kẻ ô để nâng cao độ chính xác của mục tiêu. Bàn phím được phủ một lớp mặt nhôm để có khả năng phục hồi hàng ngày và được hoàn thiện với một nét thẩm mỹ nổi bật cho một chút phong cách.";
            p4.imgLocation = "Assets/Images/Keyboard/Gundam keyboard.jpg";
            p4.prType = "Keyboard";
            products.Add(p4);

            Product p5 = new Product();
            p5.prId = "pr05";
            p5.prName = "Bàn phím cơ Bauhaus Akolabs";
            p5.prPrice = 7000000;
            p5.prDescribe = "Bàn phím cơ Bauhaus Akolabs Là dòng sản phẩm bàn phím gaming sở hữu tông màu đỏ gạch chủ đạo cực kỳ bắt mắt, đáp ứng nhu cầu học tập, làm việc và chơi game, phù hợp với nhiều đối tượng người sử dụng.";
            p5.imgLocation = "Assets/Images/Keyboard/Bauhaus keyboard.jpg";
            p5.prType = "Keyboard";
            products.Add(p5);

            Product p6 = new Product();
            p6.prId = "pr06";
            p6.prName = "Bàn phím cơ Athena Custom";
            p6.prPrice = 450000;
            p6.prDescribe = "Về cảm quan bên ngoài: Tuy là bàn phím cơ fullsize nhưng lại khá nhẹ, thiết kế đơn giản. Mặt trên là lớp vỏ kim loại đen mờ chống bám vân tay, logo được khắc hơi lệch qua bên phải. Keycap được làm double shot cao cấp cùng bộ blue switch hãng Bsun và thuộc loại có công nghệ CIY có thể thay nóng được. Bàn phím sử dụng led rainbow theo hàng ngang. Dây cáp được trang bị cục chống nhiễu.";
            p6.imgLocation = "Assets/Images/Keyboard/Athena keyboard.jpg";
            p6.prType = "Keyboard";
            products.Add(p6);

            Product p7 = new Product();
            p7.prId = "pr07";
            p7.prName = "Bàn phím cơ Warm Tenkai Custom";
            p7.prPrice = 450000;
            p7.prDescribe = "Bàn phím cơ Warm Tenkai Custom là một chiếc bàn phím cơ luôn sẵn sàng cho bạn custom trong mọi tình huống. Đây là một lựa chọn tuyệt vời để bạn bước đầu dấn thân vào thế giới custom phím cơ.";
            p7.imgLocation = "Assets/Images/Keyboard/Warm_Tenkai keyboard.jpg";
            p7.prType = "Keyboard";
            products.Add(p7);

            Product p8 = new Product();
            p8.prId = "pr08";
            p8.prName = "Bàn phím cơ Code Geass Custom";
            p8.prPrice = 500000;
            p8.prDescribe = "Bàn phím cơ Code Geass Custom là dòng sản phẩm Bàn Phím Cơ Led đổi màu Gaming cao cấp của Spartan với nhiều chế độ led cực kỳ độc đáo mang đến cảm giác chơi game tuyệt vời.";
            p8.imgLocation = "Assets/Images/Keyboard/Code_Geass keyboard.jpg";
            p8.prType = "Keyboard";
            products.Add(p8);
            //chuot
            Product p9 = new Product();
            p9.prId = "pr09";
            p9.prName = "Chuột gaming Gravastar";
            p9.prPrice = 400000;
            p9.prDescribe = "GravaStar là thương hiệu thiết kế và sản xuất thiết bị loa và phụ kiện đi kèm trên thị trường. Các thiết kế của thương hiệu mang ý tưởng điên rồ, độc đáo vượt qua mọi giới hạn sẵn có. Sứ mệnh của GravaStar là mong muốn tạo ra sản phẩm thú vị với trải nghiệm mới lạ đến khách hàng trên khắp thế giới. Gravastar đã và đang mở rộng ngành hàng của mình, tạo nên một không gian làm việc và giải trí ấn tượng.";
            p9.imgLocation = "Assets/Images/Mouse/Gravastar mouse.jpg";
            p9.prType = "Mouse";
            products.Add(p9);

            Product p10 = new Product();
            p10.prId = "pr10";
            p10.prName = "Chuột gaming HyperX";
            p10.prPrice = 500000;
            p10.prDescribe = "HyperX Pulsefire Raid là một con chuột siêu nhẹ, thiết kế công thái học, đặt nhiều lệnh điều khiển trực tiếp dưới ngón tay của bạn, giúp tiết kiệm thời gian quý báu trong các trận chiến xây dựng, đổi vũ khí hoặc cướp bóc và chạy. Pulsefire Raid là chuột có thể lập trình 11 nút, trọng lượng nhẹ và có các miếng cầm bên thoải mái, là lựa chọn hoàn hảo cho game thủ Battle Royale, MOBA và MMO.";
            p10.imgLocation = "Assets/Images/Mouse/HyperX mouse.jpg";
            p10.prType = "Mouse";
            products.Add(p10);

            Product p11 = new Product();
            p11.prId = "pr11";
            p11.prName = "Chuột gaming Kreoshpere";
            p11.prPrice = 550000;
            p11.prDescribe = "Kreoshpere One PRO thuộc dự án Glorious Forge được sản xuất giới hạn một lần duy nhất - chỉ những ai thật sự nhanh tay và đặt trước mới có thể sở hữu mẫu chuột giới hạn đến từ Glorious này.";
            p11.imgLocation = "Assets/Images/Mouse/Kreoshpere mouse.jpg";
            p11.prType = "Mouse";
            products.Add(p11);

            Product p12 = new Product();
            p12.prId = "pr12";
            p12.prName = "Chuột gaming Lamzu";
            p12.prPrice = 2500000;
            p12.prDescribe = "Lamzu là một công ty được thành lập từ những người đam mê các thiết bị ngoại vi máy tính, game thủ FPS, designer, kỹ sư kết cấu và quản lý chuỗi cung ứng với nhiều năm kinh nghiệm trong ngành công nghiệp gaming.";
            p12.imgLocation = "Assets/Images/Mouse/Lamzu mouse.jpg";
            p12.prType = "Mouse";
            products.Add(p12);

            Product p13 = new Product();
            p13.prId = "pr13";
            p13.prName = "Chuột gaming Logitech Nano";
            p13.prPrice = 400000;
            p13.prDescribe = "Chuột không dây Logitech Nano với thiết kế thông minh, hỗ trợ nâng cấp bố cục của bạn để có hiệu suất và sự thoải mái suốt cả ngày...";
            p13.imgLocation = "Assets/Images/Mouse/Logitech_Nano mouse.jpg";
            p13.prType = "Mouse";
            products.Add(p13);

            Product p14 = new Product();
            p14.prId = "pr14";
            p14.prName = "Chuột gaming Machenike";
            p14.prPrice = 600000;
            p14.prDescribe = "Chuột không dây Machenike M7 Pro Dual Mode với mắt đọc PAW3395 cao cấp nhất thời điểm hiện tại và switch Kailh GM8.0 lên đến 80 triệu lần nhấn.";
            p14.imgLocation = "Assets/Images/Mouse/Machenike mouse.jpg";
            p14.prType = "Mouse";
            products.Add(p14);

            Product p15 = new Product();
            p15.prId = "pr15";
            p15.prName = "Chuột gaming Pulsar";
            p15.prPrice = 650000;
            p15.prDescribe = "Chuột Xlite Wireless V2 Mini (Black) là mẫu chuột gaming không dây có thiết kế công thái học, siêu nhẹ, siêu bền đến từ hãng Pulsar. Pulsar là một trong những thương hiệu gaming gear mới ra mắt nhưng vô cùng nổi tiếng tại thị trường Việt Nam.";
            p15.imgLocation = "Assets/Images/Mouse/Pulsar mouse.jpg";
            p15.prType = "Mouse";
            products.Add(p15);

            Product p16 = new Product();
            p16.prId = "pr16";
            p16.prName = "Chuột gaming Razer";
            p16.prPrice = 4000000;
            p16.prDescribe = "Chuột chơi game Razer Cobra nổi bật với thiết kế đối xứng. Mang lại cảm giác cầm nắm chắc chắn và thao tác chính xác. Với 6 nút bấm được bố trí thông minh dọc theo thân chuột.";
            p16.imgLocation = "Assets/Images/Mouse/Razer.jpg";
            p16.prType = "Mouse";
            products.Add(p16);
            //other
            Product p17 = new Product();
            p17.prId = "pr17";
            p17.prName = "Controller Hyperx";
            p17.prPrice = 450000;
            p17.prDescribe = "Controller HyperX không chỉ đơn thuần là một thiết bị điều khiển, mà còn là một người bạn đồng hành đáng tin cậy của các game thủ. Với thiết kế tỉ mỉ, chất lượng xây dựng vượt trội và các tính năng tùy biến linh hoạt, HyperX đã tạo ra những sản phẩm mang đến trải nghiệm chơi game tuyệt vời.";
            p17.imgLocation = "Assets/Images/Other/HyperX Controller.jpg";
            p17.prType = "Other";
            products.Add(p17);

            Product p18 = new Product();
            p18.prId = "pr18";
            p18.prName = "HyperX Earphone";
            p18.prPrice = 750000;
            p18.prDescribe = "Tai nghe HyperX không chỉ là một thiết bị nghe nhạc thông thường, mà còn là một phụ kiện thời trang và công cụ hỗ trợ đắc lực cho các game thủ. Với thiết kế trẻ trung, năng động, chất lượng âm thanh tuyệt vời và độ bền cao, HyperX đã tạo ra những sản phẩm tai nghe đáp ứng mọi nhu cầu của người dùng.";
            p18.imgLocation = "Assets/Images/Other/HyperX Earphone.jpg";
            p18.prType = "Other";
            products.Add(p18);

            Product p19 = new Product();
            p19.prId = "pr19";
            p19.prName = "JBL No4";
            p19.prPrice = 500000;
            p19.prDescribe = "JBL Quantum 400 không chỉ là một chiếc tai nghe thông thường, mà còn là một vũ khí lợi hại giúp bạn chinh phục mọi trận đấu. Với thiết kế đậm chất gaming, chất lượng âm thanh sống động và các tính năng chuyên biệt, JBL Quantum 400 sẽ mang đến cho bạn những trải nghiệm chơi game tuyệt vời nhất.";
            p19.imgLocation = "Assets/Images/Other/JBL No4.jpg";
            p19.prType = "Other";
            products.Add(p19);

            Product p20 = new Product();
            p20.prId = "pr20";
            p20.prName = "Keycap Remover";
            p20.prPrice = 200000;
            p20.prDescribe = "Keycap Remover, hay còn gọi là dụng cụ tháo nắp phím, là một công cụ nhỏ gọn nhưng vô cùng hữu ích, giúp bạn dễ dàng tháo lắp các nắp phím trên bàn phím cơ hoặc bàn phím văn phòng. Với Keycap Remover, bạn có thể thoải mái tùy biến bàn phím theo ý thích của mình, thay thế các nắp phím bị hỏng hoặc đơn giản chỉ là đổi màu sắc, kiểu dáng để tạo nên một bàn phím độc đáo và cá tính.";
            p20.imgLocation = "Assets/Images/Other/Keycap Remover.jpg";
            p20.prType = "Other";
            products.Add(p20);

            Product p21 = new Product();
            p21.prId = "pr21";
            p21.prName = "Logitech Astro";
            p21.prPrice = 550000;
            p21.prDescribe = "Logitech Astro là một trong những thương hiệu tai nghe gaming hàng đầu thế giới, được các game thủ chuyên nghiệp và những người yêu thích game tin tưởng lựa chọn. Với thiết kế đậm chất gaming, chất lượng âm thanh tuyệt vời và các tính năng chuyên biệt, Logitech Astro mang đến trải nghiệm chơi game đỉnh cao.";
            p21.imgLocation = "Assets/Images/Other/Logitech Astro.jpg";
            p21.prType = "Other";
            products.Add(p21);

            Product p22 = new Product();
            p22.prId = "pr22";
            p22.prName = "Micro Stream";
            p22.prPrice = 550000;
            p22.prDescribe = "Micro Stream, hay còn gọi là micro thu âm trực tiếp, là một thiết bị không thể thiếu đối với những người làm nội dung, streamer, podcaster, hay đơn giản chỉ là những ai muốn có những bản thu âm chất lượng cao. Với thiết kế nhỏ gọn, tiện lợi và chất lượng âm thanh tuyệt vời, Micro Stream giúp bạn truyền tải giọng nói của mình một cách rõ ràng, chân thực và chuyên nghiệp.";
            p22.imgLocation = "Assets/Images/Other/Micro Stream.jpg";
            p22.prType = "Other";
            products.Add(p22);

            Product p23 = new Product();
            p23.prId = "pr23";
            p23.prName = "Ghế gaming Secret Lab";
            p23.prPrice = 4000000;
            p23.prDescribe = "Ghế gaming Secretlab không chỉ đơn thuần là một chiếc ghế để ngồi, mà còn là một tác phẩm nghệ thuật, một biểu tượng của sự đẳng cấp và thoải mái. Với thiết kế công thái học hoàn hảo, chất liệu cao cấp và khả năng tùy biến cao, Secretlab đã tạo ra những chiếc ghế gaming đáp ứng mọi nhu cầu của các game thủ khó tính nhất.";
            p23.imgLocation = "Assets/Images/Other/Secret_Lab Chair.jpg";
            p23.prType = "Other";
            products.Add(p23);

            Product p24 = new Product();
            p24.prId = "pr24";
            p24.prName = "String Keyboard";
            p24.prPrice = 700000;
            p24.prDescribe = "String Keyboard là một khái niệm vô cùng thú vị, kết hợp giữa vẻ đẹp cổ điển của đàn dây và sự tiện lợi của bàn phím hiện đại. Thay vì các phím bấm truyền thống, String Keyboard sử dụng các dây đàn được căng theo một trật tự nhất định, tương ứng với các phím trên bàn phím thông thường. Khi người dùng gõ phím, các dây đàn sẽ rung động và tạo ra âm thanh đặc biệt, mang đến một trải nghiệm hoàn toàn mới lạ.";
            p24.imgLocation = "Assets/Images/Other/String Keyboard.jpg";
            p24.prType = "Other";
            products.Add(p24);

            Application["DsProduct"]=products;
        }

        protected void Session_Start(object sender, EventArgs e)
        {
            Session["User"] = new User();
            Session["Product"] = new Product();
            Session["search"] = new Product();
            Session["SignIn"] = "";
            //Session["solandn"] = 0;
        }

        protected void Application_BeginRequest(object sender, EventArgs e)
        {

        }

        protected void Application_AuthenticateRequest(object sender, EventArgs e)
        {

        }

        protected void Application_Error(object sender, EventArgs e)
        {

        }

        protected void Session_End(object sender, EventArgs e)
        {

        }

        protected void Application_End(object sender, EventArgs e)
        {

        }
    }
}