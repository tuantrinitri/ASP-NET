ASP.NET MVC5

+ App_Data chứa tệp dữ liệu ứng dụng như LocalDB, file .mdf …
+ App_Start có thể chứa các tệp lớp sẽ được thực thi khi ứng dụng khởi động. Thông thường, đây sẽ là các tệp cấu hình như AuthConfig.cs, BundleConfig.cs,FilterConfig.cs, RouteConfig.cs, v.v. MVC 5 bao gồm BundleConfig.cs,FilterConfig.csvà RouteConfig.cs 
+ Content chứa các tệp hình ảnh và icon, css … Với MVC5 thì có bootsrap.css,  bootstrap.min.css và Site.css.
+ Font chứa tệp phông chữ tùy chỉnh với dự án.
+ Model chứa các thuộc tính công khai thường được sử dụng lưu trữ và thao tác với CSDL.
+ Scripts chứa các tệp JavaScript.
+ Views chứa các tệp .cshtml nơi viết nội dung giao diện cho website. Mỗi view đi kèm với controller riêng và tương ứng giữa view <-> controller đó.
+ Global.asax cho phép bạn viết mã chạy để đáp ứng với các sự kiện ở cấp ứng dụng, chẳng hạn như Application_BeginRequest, application_start, application_error, session_start, session_end, v.v.
+ packages.config được NuGet quản lý để theo dõi các gói và phiên bản bạn đã cài đặt trong ứng dụng.
+Tệp Web.config chứa cấu hình cấp ứng dụng.
