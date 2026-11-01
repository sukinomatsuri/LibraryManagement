# LibraryManagement (Quản Lý Thư Viện)

Phần mềm Quản lý Thư viện viết bằng C# .NET Framework (Windows Forms) và SQL Server.

## 🛠️ Công nghệ sử dụng
- **Ngôn ngữ**: C# (.NET Framework 4.8)
- **Giao diện**: Windows Forms, MetroModernUI, FontAwesome.Sharp
- **Cơ sở dữ liệu**: SQL Server / Entity Framework 6
- **Báo cáo**: Microsoft Reporting Services (RDLC)

## 📁 Cấu trúc thư mục
- QuanLyThuVienApp/: Mã nguồn ứng dụng và Visual Studio Solution (QuanLyThuVienApp.sln)
- QuanLyThuVienC#.sql / SQLQuery1qltv.sql: Script khởi tạo cơ sở dữ liệu SQL Server
- Cách kết nối sql.docx: Hướng dẫn cấu hình kết nối cơ sở dữ liệu

## 🚀 Hướng dẫn cài đặt & chạy
1. Khởi chạy file script SQL QuanLyThuVienC#.sql trên SQL Server Management Studio (SSMS) để tạo database QLTV.
2. Mở file QuanLyThuVienApp/QuanLyThuVienApp.sln bằng Visual Studio.
3. Kiểm tra chuỗi kết nối trong App.config để đảm bảo kết nối chính xác tới SQL Server của bạn.
4. Build và chạy dự án (F5).
